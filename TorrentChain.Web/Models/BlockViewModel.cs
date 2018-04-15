using BencodeNET.Torrents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TorrentChain.Data.Models;
using TorrentChain.Data.Utils;

namespace TorrentChain.Web.Models
{
    public class BlockViewModel
    {
        public BlockData BlockData { get; set; }

        public Signature Signature { get; set; }

        public long Index { get; set; }

        public DateTime TimeStamp { get; set; }

        public byte[] Hash { get; set; }

        public byte[] PreviousHash { get; set; }

        public Torrent TorrentInfo { get; set; }

        public string MagnetLink { get; set; }
    }
}
