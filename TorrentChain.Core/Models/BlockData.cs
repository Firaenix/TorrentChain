using System;
using System.Collections.Generic;
using System.Text;

namespace TorrentChain.Core.Models
{
    public class BlockData
    {
        public BlockData(IEnumerable<byte> data)
        {
            _data = data;
        }

        private IEnumerable<byte> _data { get; set; }

        public IEnumerable<byte> Data => _data;

        public string Title => GetTorrentTitle();

        public string Author => GetTorrentAuthor();

        private string GetTorrentAuthor()
        {
            return "Nick";
        }

        private string GetTorrentTitle()
        {
            return "How to make a shit blockchain";
        }

        public IEnumerable<byte> GetBytes()
        {
            return new byte[0];
        }
    }
}
