using System;
using Microsoft.AspNetCore.Mvc;
using TorrentChain.Core.Services;
using Microsoft.Extensions.Logging;
using TorrentChain.Web.Models;
using System.Text;
using System.IO;
using BencodeNET.Parsing;
using BencodeNET.Torrents;

namespace TorrentChain.Lambda.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        private readonly IChainService _chainService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IChainService chainService, ILogger<HomeController> logger)
        {
            _chainService = chainService;
            _logger = logger;
        }

        public IActionResult Index() => View(new HomeViewModel()
        {
            BlockChain = _chainService.GetBlockChain()
        });

        [HttpGet]
        [Route("api/chain/add")]
        public IActionResult UpdateChain()
        {
            try
            {
                // Read Torrent file from disk
                var file = System.IO.File.ReadAllBytes(Path.Combine(Directory.GetCurrentDirectory(), "Files/alice.torrent"));

                _chainService.AddBlockToChain(new Data.Models.BlockData(file));

                return Redirect("/");
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message, e);
                return Redirect("/");
            }
        }
    }
}
