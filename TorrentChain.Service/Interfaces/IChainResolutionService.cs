using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TorrentChain.Data.Models;

namespace TorrentChain.Service.Interfaces
{
    public interface IChainResolutionService
    {
        Task<BlockChain> ResolveChain();

        Task BroadcastNewBlock(Block block);

        Task ReceieveBlock(Block block);
    }
}
