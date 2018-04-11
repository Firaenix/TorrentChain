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

        public string Title => GetTorrentTitle();

        public string Author => GetTorrentAuthor();

        private string GetTorrentAuthor()
        {
            try
            {
                var parser = new BencodeParser();
                var torrent = parser.Parse<Torrent>(_data);

                return torrent.CreatedBy;
            }
            catch
            {
                return "Error getting Author from data";
            }
        }

        private string GetTorrentTitle()
        {
            try
            {
                var parser = new BencodeParser();
                var torrent = parser.Parse<Torrent>(_data);

                return torrent.DisplayName;
            }
            catch
            {
                return "Error getting title from data";
            }
        }

        // May need to modify this further later
        public IEnumerable<byte> GetBytes()
        {
            return _data;
        }
    }
}
