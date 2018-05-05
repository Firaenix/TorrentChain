using System.Collections.Generic;
using System.Linq;

namespace TorrentChain.Data.Models
{
    public class BlockData
    {
        public BlockData(IEnumerable<byte> data)
        {
            Data = data.ToArray();
        }

        public IEnumerable<byte> Data { get; }

        public IEnumerable<byte> GetBytes()
        {
            return Data;
        }
    }
}