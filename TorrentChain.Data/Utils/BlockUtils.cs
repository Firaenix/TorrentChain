using BencodeNET.Parsing;
using BencodeNET.Torrents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TorrentChain.Data.Models;

namespace TorrentChain.Data.Utils
{
    public static class BlockUtils
    {
        public static bool IsDataValidTorrent(BlockData blockData)
        {
            try
            {
                var parser = new BencodeParser();
                var torrent = parser.Parse<Torrent>(blockData.Data.ToArray());
                
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
