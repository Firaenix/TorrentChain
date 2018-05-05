using System.Collections.Generic;
using TorrentChain.Data.Models;

namespace TorrentChain.Service.Interfaces
{
    public interface IChainService
    {
        IReadOnlyList<Block> GetBlockChain();

        void AddBlockToChain(BlockData newBlock);
    }
}