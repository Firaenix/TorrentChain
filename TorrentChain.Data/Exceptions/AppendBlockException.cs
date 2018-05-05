using System;

namespace TorrentChain.Data.Exceptions
{
    public class AppendBlockException : Exception
    {
        public AppendBlockException()
        {
        }

        public AppendBlockException(string message) : base(message)
        {
        }

        public AppendBlockException(string message, Exception inner)
        {
        }
    }
}