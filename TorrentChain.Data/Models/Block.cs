using System;
using System.Collections.Generic;
using System.Text;

namespace TorrentChain.Data.Models
{
    public class Block
    {
        public Block(BlockParams param)
        {
            this.Index = param.Index;
            this.PreviousHash = param.PreviousHash;
            this.TimeStamp = param.Timestamp;
            this._hash = param.Hash;
            this.BlockData = param.Data;
            this.Signature = param.Signature;
        }

        public BlockData BlockData { get; set; }

        public Signature Signature { get; set; }

        public long Index { get; set; }
        
        public DateTime TimeStamp { get; set; }
        
        private IEnumerable<byte> _hash { get; set; }

        public IEnumerable<byte> Hash => _hash;

        public IEnumerable<byte> PreviousHash { get; set; }
    }
}
