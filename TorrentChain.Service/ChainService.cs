using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using TorrentChain.Data.Models;
using TorrentChain.Service.Contracts;
using TorrentChain.Service.Interfaces;

namespace TorrentChain.Service
{
    public class ChainService : BlockSync.BlockSyncBase, IChainService
    {
        private readonly IBlockChain _blockChain;
        private readonly IChainResolutionService _chainResolutionService;
        private readonly IBroadcastClient _broadcastClient;
        private readonly ILogger<ChainService> _logger;

        public ChainService(IBlockChain blockChain, IChainResolutionService chainResolutionService, IBroadcastClient broadcastClient, ILogger<ChainService> logger)
        {
            _chainResolutionService = chainResolutionService;
            _logger = logger;
            _broadcastClient = broadcastClient;
            _blockChain = blockChain;
        }

        public IReadOnlyList<Block> GetBlockChain()
        {
            return _blockChain.GetChain();
        }

        public void AddBlockToChain(BlockData newBlockData)
        {
            try
            {
                var block = _blockChain.AddBlock(newBlockData);
                _broadcastClient.BroadcastNewBlock(block);
            }
            catch (Exception e)
            {
                _logger.LogCritical(e.Message, e);
            }
        }

        public override async Task<SendBlockReply> SendBlock(SendBlockRequest request, ServerCallContext context)
        {
            return new SendBlockReply
            {
                Success = true
            };
        }

        public override async Task<ResolveChainReply> ResolveChain(ResolveChainRequest request, ServerCallContext context)
        {
            return new ResolveChainReply()
            {
                Blockchain = { new ProtoBlock()
                {

                }}
            };
        }
    }
}