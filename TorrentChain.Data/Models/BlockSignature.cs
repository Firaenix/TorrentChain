using System.Collections.Generic;

namespace TorrentChain.Data.Models {
    public abstract class Signature {

        public Signature(IEnumerable<byte> sig) {
            if (IsValidSignature(sig)) {
                _signature = sig;
            }
        }

        public abstract string Name(); 

        public abstract bool IsValidSignature(IEnumerable<byte> signature);

        private IEnumerable<byte> _signature { get; set; }

        public IEnumerable<byte> GetSignature() => _signature;
    }
}