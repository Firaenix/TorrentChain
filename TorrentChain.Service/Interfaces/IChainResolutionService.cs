using System;
using System.Collections.Generic;
using System.Text;
using TorrentChain.Data.Models;

namespace TorrentChain.Service.Interfaces
{
    public interface IChainResolutionService
    {
        BlockChain ResolveChain();
    }
}
