using System.Threading.Tasks;
using TorrentChain.Data.Models;

namespace TorrentChain.Service.Interfaces
{
    public interface IChainResolutionService
    {
        Task<IBlockChain> ResolveChain();
    }
}