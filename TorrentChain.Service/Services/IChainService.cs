using System;
using System.Collections.Generic;
using System.Text;
using TorrentChain.Data.Models;

namespace TorrentChain.Core.Services
{
    public interface IChainService
    {
        IReadOnlyList<Block> GetBlockChain();

        void AddBlockToChain(BlockData newBlock);
    }
}
