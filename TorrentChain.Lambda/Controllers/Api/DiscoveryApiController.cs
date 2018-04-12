using Microsoft.AspNetCore.Mvc;

namespace TorrentChain.Lambda.Controllers.Api {

    [Route("api/discovery")]
    public class DiscoveryApiController: Controller {

        [HttpGet]
        [Route("api/discovery/discover")]
        public IActionResult Discover() {
            return Ok();
        }
    }
}