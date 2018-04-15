using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using TorrentChain.Data.Models;
using TorrentChain.Web.Mapper;
using TorrentChain.Web.Models;
using TorrentChain.Service;

namespace TorrentChain.Web.Controllers.Api
{
    [Route("api/blockchain")]
    public class BlockchainApiController: Controller
    {
        private readonly IChainService _chainService;
        private readonly ILogger<BlockchainApiController> _logger;
        private readonly IMapperService _mapper;

        public BlockchainApiController(IChainService chainService, ILogger<BlockchainApiController> logger, IMapperService mapper)
        {
            _chainService = chainService;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_mapper.Map<IReadOnlyList<Block>, IReadOnlyList<BlockViewModel>>(_chainService.GetBlockChain()));
        }
    }
}
