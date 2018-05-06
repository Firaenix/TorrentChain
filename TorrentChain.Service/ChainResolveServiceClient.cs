using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using TorrentChain.Data.Models;
using TorrentChain.Service.Mapper;
using Microsoft.Extensions.Configuration;

namespace TorrentChain.Service
{
    public class ChainResolveImpl : ChainResolve.ChainResolveBase
    {
        private readonly IBlockChain _blockchain;
        private readonly IMapperService _mapper;

        public ChainResolveImpl(IBlockChain blockChain, IMapperService mapper)
        {
            _blockchain = blockChain;
            _mapper = mapper;
        }

        public async override Task<GetBlockChainReply> GetBlockchain(GetBlockChainRequest request,
            ServerCallContext context)
        {
            return new GetBlockChainReply()
            {
                Blockchain = {
                    _mapper.Map<IReadOnlyList<Block>, ProtoBlock[]>(_blockchain.GetChain())
                }
            };
        }
    }

    public class ChainResolveServiceClient
    {
        private readonly Server _server;
        private readonly Channel _channel;
        private readonly ChainResolve.ChainResolveClient _client;
        private readonly IMapperService _mapperService;

        public ChainResolveServiceClient(IConfiguration configuration, ChainResolveImpl blockSyncService, IMapperService mapperService)
        {
            _mapperService = mapperService;

            _server = new Server
            {
                Services = {ChainResolve.BindService(blockSyncService)},
                Ports = {new ServerPort("localhost", int.Parse(configuration["RPCConnection:ChainResolveServicePort"]), ServerCredentials.Insecure)}
            };
            _server.Start();

            var peer = configuration["RPCConnection:FirstPeerAddress"];
            _channel = new Channel(peer, ChannelCredentials.Insecure);
            // var thing = BlockSync.BindService(new BlockSyncServiceImpl());
            _client = new ChainResolve.ChainResolveClient(_channel);
        }

        public IBlockChain ResolveChainFromPeers()
        {
            _channel.ConnectAsync().Wait();
            var res = _client.GetBlockchain(new GetBlockChainRequest());
            _channel.ShutdownAsync().Wait();

            var chain = _mapperService.Map<List<ProtoBlock>, LinkedList<Block>>(res.Blockchain.ToList());
            return new BlockChain(chain);
        }

        public void DestroyConnection()
        {
            _server.ShutdownAsync().Wait();
        }
    }
}
