using System;
using System.Collections.Generic;
using TorrentChain.Data.Models;

namespace TorrentChain.Web.Models
{
    public class HomeViewModel
    {
        public IReadOnlyList<Block> BlockChain { get; set; }
    }
}
