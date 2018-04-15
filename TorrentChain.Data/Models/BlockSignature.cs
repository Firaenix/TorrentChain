using System.Collections.Generic;

namespace TorrentChain.Data.Models
{
  public abstract class Signature
  {

    public Signature(IEnumerable<byte> sig)
    {
      if (IsValidSignature(sig))
      {
        Bytes = sig;
      }
    }

    public abstract string Name();

    public abstract bool IsValidSignature(IEnumerable<byte> signature);

    public IEnumerable<byte> Bytes { get; }
  }
}