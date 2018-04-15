using System;
using System.Collections.Generic;

namespace TorrentChain.Data.Models
{

  public class BlockParams
  {
    public long Index { get; set; }
    public IEnumerable<byte> PreviousHash { get; set; }
    public DateTime Timestamp { get; set; }
    public IEnumerable<byte> Hash { get; set; }
    public BlockData Data { get; set; }
    public Signature Signature { get; set; }
  }
}