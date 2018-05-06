using System;
using System.Collections.Generic;

namespace TorrentChain.Data.Models
{
    public class Block
    {
        // Private for deserialising
        public Block()
        {
        }

        public Block(BlockParams param)
        {
            Index = param.Index;
            PreviousHash = param.PreviousHash;
            TimeStamp = param.Timestamp;
            Hash = param.Hash;
            BlockData = param.Data;
            Signature = param.Signature;
        }

        public BlockData BlockData { get; set; }

        public Signature Signature { get; set; }

        public long Index { get; set; }

        public DateTime TimeStamp { get; set; }

        public IEnumerable<byte> Hash { get; }

        public IEnumerable<byte> PreviousHash { get; set; }
    }
}