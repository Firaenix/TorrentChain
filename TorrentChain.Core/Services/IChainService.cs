using System;
using System.Collections.Generic;
using System.Text;
using TorrentChain.Core.Models;

namespace TorrentChain.Core.Services
{
    public interface IChainService
    {
        IReadOnlyList<Block> GetBlockChain();

        void AddBlockToChain(Block newBlock);
    }
}
