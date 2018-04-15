using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
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

        public async Task<BlockChain> ResolveChain()
        {
            using (var client = new HttpClient())
            {
                var message = await client.GetAsync("http://torrentchainweb-test.ap-southeast-2.elasticbeanstalk.com/api/blockchain");
                var blockChainJson = await message.Content.ReadAsStringAsync();

                var chain = JsonConvert.DeserializeObject<LinkedList<Block>>(blockChainJson);
                return new BlockChain(chain, _blockChainLogger);
            }
        }
    }
}
