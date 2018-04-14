using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using TorrentChain.Data.Exceptions;
using TorrentChain.Data.Utils;

namespace TorrentChain.Data.Models
{
    public class BlockChain
    {
        private readonly LinkedList<Block> _chain;
        private readonly ILogger<BlockChain> _logger;

        public BlockChain(LinkedList<Block> chain, ILogger<BlockChain> logger)
        {
            _chain = chain;
            _logger = logger;

            #if DEBUG
                AddGenesisBlock();
            #endif
        }

        public IReadOnlyList<Block> GetChain()
        {
            return _chain.ToList();
        }

        public void AddBlock(BlockData newBlockData)
        {
            var newBlock = GenerateNextBlock(newBlockData);

            if (!IsValidNewBlock(_chain.Last.Value, newBlock))
            {
                throw new AppendBlockException("Attempted to add invalid block to chain!");
            }

            _chain.AddLast(newBlock);
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
            if (!BlockUtils.IsDataValidTorrent(newBlock.BlockData))
                return false;

            return true;
        }

        private Block GenerateNextBlock(BlockData newData)
        {
            var previousBlock = _chain.Last.Value;

            var nextIndex = previousBlock.Index + 1;
            var nextTimestamp = DateTime.Now;

            var blockParams = new BlockParams() {
                Data = newData,
                Timestamp = nextTimestamp,
                PreviousHash = previousBlock.Hash,
                Index = nextIndex,
                Hash = CalculateHash(previousBlock.Hash, nextIndex, nextTimestamp, newData.GetBytes())
            };

            return new Block(blockParams);
        }

        private IEnumerable<byte> CalculateBlockHash(Block block)
        {
            return CalculateHash(block.PreviousHash, block.Index, block.TimeStamp, block.BlockData.GetBytes());
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

            var genesisData = new BlockData(Encoding.ASCII.GetBytes("This is the genesis block!!"));
            var sha512 = SHA512.Create();

            var blockParams = new BlockParams {
                Hash = sha512.ComputeHash(genesisData.GetBytes().ToArray()),
                PreviousHash = new byte[0],
                Data = genesisData,
                Index = 0,
                Timestamp = DateTime.Now
            };

            var genesisBlock = new Block(blockParams);
            _chain.AddLast(genesisBlock);
        }
    }
}
