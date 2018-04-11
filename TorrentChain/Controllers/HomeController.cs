using System;
using Microsoft.AspNetCore.Mvc;
using TorrentChain.Core.Services;
using Microsoft.Extensions.Logging;
using TorrentChain.Web.Models;
using System.Text;
using System.IO;

namespace TorrentChain.Controllers
{
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
                var file = System.IO.File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Files/edubuntu-12.04.5-dvd-amd64.iso.torrent"));

                _chainService.AddBlockToChain(new Data.Models.BlockData(Encoding.ASCII.GetBytes(file)));

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
