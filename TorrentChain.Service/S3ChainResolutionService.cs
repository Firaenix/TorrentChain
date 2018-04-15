using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using TorrentChain.Data.Models;
using TorrentChain.Service.Interfaces;

namespace TorrentChain.Service
{
    public class S3ChainResolutionService : IChainResolutionService
    {
        private readonly ILogger<S3ChainResolutionService> _logger;
        private readonly ILogger<BlockChain> _blockChainLogger;

        public S3ChainResolutionService(ILogger<S3ChainResolutionService> logger, ILogger<BlockChain> blockChainLogger)
        {
            _logger = logger;
            _blockChainLogger = blockChainLogger;
        }

        public BlockChain ResolveChain()
        {
            return new BlockChain(new LinkedList<Block>(), _blockChainLogger);
        }
    }
}
