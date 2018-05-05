using System;
using System.Linq;
using System.Threading.Tasks;
using Google.Protobuf;
using Grpc.Core;
using Grpc.Core.Logging;
using Microsoft.Extensions.Logging;
using TorrentChain.Data.Models;
using TorrentChain.Service.Interfaces;
using TorrentChain.Service.Mapper;

namespace TorrentChain.Service
{
    public class BlockSyncServiceImpl : BlockSync.BlockSyncBase
    {
        private readonly IBlockChain _blockChain;
        private readonly IMapperService _mapper;

        public BlockSyncServiceImpl(IBlockChain blockChain, IMapperService mapper)
        {
            _blockChain = blockChain;
            _mapper = mapper;
        }

        public override async Task<SendBlockReply> SendBlock(SendBlockRequest request, ServerCallContext context)
        {
            var protoblock = request.Block;
            var block = _mapper.Map<ProtoBlock, Block>(protoblock);

            var prevBlock = _blockChain.GetChain().First(x => x.Hash.Equals(block.PreviousHash));
            if (_blockChain.IsValidNewBlock(prevBlock, block))
            {
                _blockChain.AddBlock(block.BlockData);

                return new SendBlockReply
                {
                    Success = true
                };
            }

            return new SendBlockReply
            {
                Success = false
            };
        }

        
    }

    public interface IBroadcastClient
    {
        Task BroadcastNewBlock(Block block);
    }

    public class BlockSyncServiceClient : IBroadcastClient
    {
        private readonly Server _server;
        private readonly Channel _channel;
        private readonly BlockSync.BlockSyncClient _client;

        private readonly ILogger<BlockSyncServiceClient> _logger;

        public BlockSyncServiceClient(BlockSyncServiceImpl blockSyncService, ILogger<BlockSyncServiceClient> logger)
        {
            _logger = logger;

            _server = new Server
            {
                Services = { BlockSync.BindService(blockSyncService) },
                Ports = { new ServerPort("localhost", 7777, ServerCredentials.Insecure) }
            };
            _server.Start();


            _channel = new Channel("127.0.0.1:7777", ChannelCredentials.Insecure);
            // var thing = BlockSync.BindService(new BlockSyncServiceImpl());
            _client = new BlockSync.BlockSyncClient(_channel);
        }

        public async Task BroadcastNewBlock(Block block)
        {
            var req = new SendBlockRequest
            {
                Block = new ProtoBlock
                {
                    Index = block.Index,
                    BlockData = ByteString.CopyFrom(block.BlockData.Data.ToArray()),
                    Hash = ByteString.CopyFrom(block.Hash.ToArray()),
                    PreviousHash = ByteString.CopyFrom(block.PreviousHash.ToArray()),
                    Signature = ByteString.CopyFrom(new byte[0]),
                    TimeStamp = new DateTimeOffset(block.TimeStamp).ToUnixTimeMilliseconds()
                }
            };

            var result = await _client.SendBlockAsync(req);
            _logger.LogInformation($"Sent block to client with response: {result.Success}");
        }
    }
}