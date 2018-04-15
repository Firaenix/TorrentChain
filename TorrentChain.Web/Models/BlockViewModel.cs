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
    public Block Block { get; set; }

    public Torrent TorrentInfo { get; set; }

    public string MagnetLink { get; set; }
  }
}
