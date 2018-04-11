using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using TorrentChain.Data.Models;

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
        
        public void AddBlockToChain(BlockData newBlockData)
        {
            try
            {
                _blockChain.AddBlock(newBlockData);
            }
            catch (Exception e)
            {
                _logger.LogCritical(e.Message, e);
            }
        }
    }
}
