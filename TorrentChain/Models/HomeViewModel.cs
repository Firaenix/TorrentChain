using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TorrentChain.Core.Models;

namespace TorrentChain.Web.Models
{
    public class HomeViewModel
    {
        public List<Block> BlockChain { get; set; }
    }
}
