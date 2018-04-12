using System.Collections.Generic;

namespace TorrentChain.Data.Models {
    public class RSASignature : Signature {

        public RSASignature(IEnumerable<byte> sig): base(sig) {}

        public override string Name() => "RSA"; 

        public override bool IsValidSignature(IEnumerable<byte> signature) {
            return true;
        }
    }
}