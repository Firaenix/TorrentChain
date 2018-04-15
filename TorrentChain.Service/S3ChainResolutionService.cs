﻿using Microsoft.Extensions.Logging;
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

    public async Task<BlockChain> ResolveChainAsync()
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
