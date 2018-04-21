using BencodeNET.Parsing;
using BencodeNET.Torrents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TorrentChain.Data.Models
{
    public class BlockData
    {
        public BlockData(IEnumerable<byte> data)
        {
            Data = data.ToArray();
        }

        public byte[] Data { get; }

        // May need to modify this further later
        public virtual IEnumerable<byte> GetBytes()
        {
            return Data;
        }
    }
}
