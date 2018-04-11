using System;
using System.Collections.Generic;
using System.Text;

namespace TorrentChain.Data.Models
{
    public class Block
    {
        public Block(long index, IEnumerable<byte> previousHash, DateTime timestamp, IEnumerable<byte> hash, BlockData data)
        {
            this.Index = index;
            this.PreviousHash = previousHash;
            this.TimeStamp = timestamp;
            this._hash = hash;
            this.BlockData = data;
        }

        public BlockData BlockData { get; set; }

        public long Index { get; set; }
        
        public DateTime TimeStamp { get; set; }
        
        public IEnumerable<byte> Signature { get; set; }
        
        private IEnumerable<byte> _hash { get; set; }

        public IEnumerable<byte> Hash => _hash;

        public IEnumerable<byte> PreviousHash { get; set; }
    }
}
