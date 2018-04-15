using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using TorrentChain.Data.Models;
using TorrentChain.Service.Interfaces;

namespace TorrentChain.Service
{
    public class ChainService : IChainService
    {
        private readonly IChainResolutionService _chainResolutionService;
        private readonly BlockChain _blockChain;
        private readonly ILogger<ChainService> _logger;

        public ChainService(IChainResolutionService chainResolutionService, ILogger<ChainService> logger)
        {
            _chainResolutionService = chainResolutionService;
            _logger = logger;

            _blockChain = _chainResolutionService.ResolveChain();
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
