using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TorrentChain.Web.Models;
using System.IO;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TorrentChain.Service;

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

                        for (int i = 0; i < 100; i++)
                        {
                            _chainService.AddBlockToChain(new Data.Models.BlockData(stream.ToArray()));
                        }
                    }
                }
            }

            return RedirectToAction("Index");
        }
    }
}
