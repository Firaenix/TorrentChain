using System.Collections.Generic;

namespace TorrentChain.Data.Models
{
    public class PGPSignature : Signature
    {
        public PGPSignature(IEnumerable<byte> sig) : base(sig)
        {
        }

        public override string Name()
        {
            return "PGP";
        }

        public override bool IsValidSignature(IEnumerable<byte> signature)
        {
            return true;
        }
    }
}