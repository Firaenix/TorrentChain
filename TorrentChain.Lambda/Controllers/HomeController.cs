using System;
using Microsoft.AspNetCore.Mvc;
using TorrentChain.Core.Services;
using Microsoft.Extensions.Logging;
using TorrentChain.Web.Models;
using System.Text;
using System.IO;
using BencodeNET.Parsing;
using BencodeNET.Torrents;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        
        [HttpPost]
        [Route("UploadTorrent")]
        public async Task<IActionResult> UploadTorrent(List<IFormFile> files)
        {
            long size = files.Sum(f => f.Length);

            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    using (var stream = new MemoryStream())
                    {
                        await formFile.CopyToAsync(stream);
                        _chainService.AddBlockToChain(new Data.Models.BlockData(stream.ToArray()));
                    }
                }
            }

            return RedirectToAction("Index");
        }
    }
}
