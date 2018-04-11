using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using TorrentChain.Core.Exceptions;

namespace TorrentChain.Core.Models
{
    public class BlockChain
    {
        private readonly LinkedList<Block> _chain;
        private readonly ILogger<BlockChain> _logger;

        public BlockChain(ILogger<BlockChain> logger)
        {
            _logger = logger;

            #if DEBUG
                AddGenesisBlock();
            #endif
        }

        public IReadOnlyList<Block> GetChain()
        {
            return _chain.ToList();
        }

        public void AddBlock(Block newBlock)
        {
            if (!IsValidNewBlock(_chain.Last.Value, newBlock))
            {
                throw new AppendBlockException("Attempted to add invalid block to chain!");
            }

            _chain.AddLast(newBlock);
        }

        private Block GenerateNextBlock(IEnumerable<byte> newData)
        {
            var previousBlock = _chain.Last.Value;

            var nextIndex = previousBlock.Index + 1;
            var nextTimestamp = DateTime.Now;
            var nextHash = CalculateHash(previousBlock.Hash, nextIndex, nextTimestamp, newData);

            return new Block(nextIndex, previousBlock.Hash, nextTimestamp, nextHash, newData);
        }

        private IEnumerable<byte> CalculateBlockHash(Block block)
        {
            return CalculateHash(block.PreviousHash, block.Index, block.TimeStamp, block.Data);
        }

        public bool IsValidNewBlock(Block previousBlock, Block newBlock)
        {
            if (previousBlock.Index + 1 != newBlock.Index)
                return false;

            if (!previousBlock.Hash.Equals(newBlock.PreviousHash))
                return false;

            // Calculate the hash for the given block and make sure its correct
            if (!Enumerable.SequenceEqual(CalculateBlockHash(newBlock), newBlock.Hash))
                return false;

            // Make sure the data only contains a valid torrent file

            return true;
        }
       
        private IEnumerable<byte> CalculateHash(IEnumerable<byte> previousBlockHash, long nextIndex, DateTime nextTimestamp, IEnumerable<byte> blockData)
        {
            var dataToHash = previousBlockHash.Concat(BitConverter.GetBytes(nextIndex))
                                              .Concat(BitConverter.GetBytes(nextTimestamp.Ticks)
                                              .Concat(blockData));

            var sha512 = SHA512.Create();
            var hash = sha512.ComputeHash(dataToHash.ToArray());
            return hash;
        }

        private void AddGenesisBlock()
        {
            if (_chain.Count > 0)
            {
                return;
            }

            _logger.LogInformation("Adding genesis block");

            var genesisData = Encoding.ASCII.GetBytes("This is the genesis block!!");
            var sha512 = SHA512.Create();
            var genesishash = sha512.ComputeHash(genesisData);
            var genesisBlock = new Block(0, new byte[0], DateTime.Now, genesishash, genesisData);

            _chain.AddBlock(genesisBlock);
        }
    }
}
