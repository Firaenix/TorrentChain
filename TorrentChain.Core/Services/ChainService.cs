using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using TorrentChain.Core.Models;

namespace TorrentChain.Core.Services
{
    public class ChainService : IChainService
    {
        private readonly BlockChain _blockChain;
        private readonly ILogger<ChainService> _logger;

        public ChainService(BlockChain blockChain, ILogger<ChainService> logger)
        {
            _blockChain = blockChain;
            _logger = logger;
        }

        public IReadOnlyList<Block> GetBlockChain()
        {
            return _blockChain.GetChain();
        }
        
        public void AddBlockToChain(Block newBlock)
        {
            try
            {
                _blockChain.AddBlock(newBlock);
            }
            catch (Exception e)
            {
                _logger.LogCritical(e.Message, e);
            }
        }
    }
}
