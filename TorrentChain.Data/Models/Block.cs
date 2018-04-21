using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TorrentChain.Data.Models
{
    public class Block
    {
        // Private for deserialising
        private Block() { }

        public Block(BlockParams param)
        {
            this.Index = param.Index;
            this.PreviousHash = param.PreviousHash;
            this.TimeStamp = param.Timestamp;
            this.Hash = param.Hash;
            this.BlockData = param.Data;
            this.Signature = param.Signature;
        }

        public BlockData BlockData { get; set; }

        public Signature Signature { get; set; }

        public long Index { get; set; }

        public DateTime TimeStamp { get; set; }

        public IEnumerable<byte> Hash { get; }

        public IEnumerable<byte> PreviousHash { get; set; }
    }
}
