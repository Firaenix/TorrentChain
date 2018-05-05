using Grpc.Core;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TorrentChain.Data.Models;
using TorrentChain.Service.Interfaces;
using Google.Protobuf;

namespace TorrentChain.Service
{
    public class PeerChainResolutionService : IChainResolutionService
    {
        private readonly ILogger<PeerChainResolutionService> _logger;
        private readonly ILogger<BlockChain> _blockChainLogger;
        private readonly Channel _channel;
        private readonly BlockSync.BlockSyncClient _client;

        public PeerChainResolutionService(ILogger<PeerChainResolutionService> logger, ILogger<BlockChain> blockChainLogger)
        {
            _logger = logger;
            _blockChainLogger = blockChainLogger;

            _channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);
            // var thing = BlockSync.BindService(new BlockSyncServiceImpl());
            _client = new BlockSync.BlockSyncClient(_channel);
        }

        public async Task BroadcastNewBlock(Block block)
        {
            var req = new SendBlockRequest
            {
                Index = block.Index,
                BlockData = block.BlockData.Data as ByteString,
                Hash = block.Hash as ByteString,
                PreviousHash = block.PreviousHash as ByteString,
                Signature = block.Signature.Bytes as ByteString,
                TimeStamp = new DateTimeOffset(block.TimeStamp).ToUnixTimeMilliseconds()
            };

            var result = await _client.SendBlockAsync(req);
            _logger.LogInformation($"Sent block to client with response: {result.Success}");
        }

        public Task ReceieveBlock(Block block)
        {
            throw new NotImplementedException();
        }

        public async Task<BlockChain> ResolveChain()
        {
            using (var client = new HttpClient())
            {

                var message = await client.GetAsync("http://somewherecool/api/blockchain");
                var blockChainJson = await message.Content.ReadAsStringAsync();

                var chain = JsonConvert.DeserializeObject<LinkedList<Block>>(blockChainJson);
                return new BlockChain(chain, _blockChainLogger);
            }

            // return Task.FromResult(new BlockChain(new LinkedList<Block>(), _blockChainLogger));
        }
    }
}
