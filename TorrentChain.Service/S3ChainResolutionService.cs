using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using TorrentChain.Data.Models;
using TorrentChain.Service.Interfaces;

namespace TorrentChain.Service
{
    public class S3ChainResolutionService : IChainResolutionService
    {
        private readonly ILogger<BlockChain> _blockChainLogger;
        private readonly ILogger<S3ChainResolutionService> _logger;

        public S3ChainResolutionService(ILogger<S3ChainResolutionService> logger, ILogger<BlockChain> blockChainLogger)
        {
            _logger = logger;
            _blockChainLogger = blockChainLogger;
        }

        public Task BroadcastNewBlock(Block block)
        {
            throw new NotImplementedException();
        }

        public Task ReceieveBlock(Block block)
        {
            throw new NotImplementedException();
        }

        public async Task<IBlockChain> ResolveChain()
        {
            using (var client = new HttpClient())
            {
                // var message = await client.GetAsync("http://somewherecool/api/blockchain");
                // var blockChainJson = await message.Content.ReadAsStringAsync();

                // var chain = JsonConvert.DeserializeObject<LinkedList<Block>>(blockChainJson);
                return new BlockChain();
            }

            // return Task.FromResult(new BlockChain(new LinkedList<Block>(), _blockChainLogger));
        }
    }
}