using System;
using System.Collections.Generic;
using System.Text;
using TorrentChain.Data.Models;

namespace TorrentChain.Service
{
    public interface IChainService
    {
        IReadOnlyList<Block> GetBlockChain();

        void AddBlockToChain(BlockData newBlock);
    }
}
