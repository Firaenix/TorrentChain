using System.Linq;
using BencodeNET.Parsing;
using BencodeNET.Torrents;
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

        public static Torrent GetTorrentInformation(Block block)
        {
            try
            {
                var parser = new BencodeParser();
                var torrent = parser.Parse<Torrent>(block.BlockData.Data.ToArray());

                return torrent;
            }
            catch
            {
                return null;
            }
        }

        public static string GetTorrentAuthor(Block block)
        {
            try
            {
                return GetTorrentInformation(block).CreatedBy;
            }
            catch
            {
                return "Not a valid Torrent file";
            }
        }

        public static string GetTorrentTitle(Block block)
        {
            try
            {
                return GetTorrentInformation(block).DisplayName;
            }
            catch
            {
                return "Not a valid Torrent file";
            }
        }
    }
}