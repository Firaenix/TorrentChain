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
            try
            {
                var parser = new BencodeParser();
                var torrent = parser.Parse<Torrent>(data.ToArray());

                _data = data;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        private IEnumerable<byte> _data { get; set; }

        public IEnumerable<byte> Data => _data;

        public string Title => GetTorrentTitle();

        public string Author => GetTorrentAuthor();

        private string GetTorrentAuthor()
        {
            var parser = new BencodeParser();
            var torrent = parser.Parse<Torrent>(_data.ToArray());

            return torrent.CreatedBy;
        }

        private string GetTorrentTitle()
        {
            var parser = new BencodeParser();
            var torrent = parser.Parse<Torrent>(_data.ToArray());

            return torrent.DisplayName;
        }

        // May need to modify this further later
        public IEnumerable<byte> GetBytes()
        {
            return _data;
        }
    }
}
