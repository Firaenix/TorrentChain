using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TorrentChain.Models;
using TorrentChain.Core.Services;
using Microsoft.Extensions.Logging;
using TorrentChain.Web.Models;
using System.Text;

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
            BlockChain = _chainService.GetBlockChain().ToList()
        });

        [HttpGet]
        [Route("api/chain/add")]
        public IActionResult UpdateChain()
        {
            try
            {
                var block = _chainService.GenerateNextBlock(Encoding.ASCII.GetBytes($"This block was created at: {DateTime.Now.ToLongTimeString()}"));
                _chainService.AddBlockToChain(block);

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
