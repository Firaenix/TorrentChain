using System.Collections.Generic;

namespace TorrentChain.Data.Models
{
    public abstract class Signature
    {
        public Signature(IEnumerable<byte> sig)
        {
            if (IsValidSignature(sig)) Bytes = sig;
        }

        public IEnumerable<byte> Bytes
        {
            get => new byte[] {0};
            set { }
        }

        public abstract string Name();

        public abstract bool IsValidSignature(IEnumerable<byte> signature);
    }
}