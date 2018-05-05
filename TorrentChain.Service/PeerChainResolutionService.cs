using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Protobuf;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using TorrentChain.Data.Models;
using TorrentChain.Service.Contracts;
using TorrentChain.Service.Interfaces;
using TorrentChain.Service.Mapper;

namespace TorrentChain.Service
{
    public class PeerChainResolutionService : IChainResolutionService
    {
        private readonly IBroadcastClient _client;
        private readonly ILogger<PeerChainResolutionService> _logger;
        private readonly IMapperService _mapper;
        
        public PeerChainResolutionService(ILogger<PeerChainResolutionService> logger, IBroadcastClient client)
        {
            _logger = logger;
            _client = client;
        }

        public async Task<IBlockChain> ResolveChain()
        {
            try
            {
                var reply = await _client.ResolveChain();

                var blocks = _mapper.Map<ProtoBlock[], Block[]>(reply.Blockchain.ToArray());

                return new BlockChain().ReplaceChain(new LinkedList<Block>(blocks));
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e);
                throw;
            }
        }
    }
}