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
            _data = data.ToArray();
        }

        private byte[] _data { get; set; }

        public IEnumerable<byte> Data => _data;

        // May need to modify this further later
        public virtual IEnumerable<byte> GetBytes()
        {
            return _data;
        }
    }
}
