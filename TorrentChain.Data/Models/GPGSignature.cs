using System.Collections.Generic;

namespace TorrentChain.Data.Models {
    public class GPGSignature : Signature {

        public GPGSignature(IEnumerable<byte> sig): base(sig) {}

        public override string Name() => "GPG"; 

        public override bool IsValidSignature(IEnumerable<byte> signature) {
            return true;
        }
    }
}