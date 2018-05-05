using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;
using TorrentChain.Data.Models;
using TorrentChain.Service.Mapper;

namespace TorrentChain.Service
{
    public class ChainResolveServiceImpl : ChainResolve.ChainResolveBase
    {
        private readonly IBlockChain _blockChain;
        private readonly IMapperService _mapper;

        public ChainResolveServiceImpl(IBlockChain blockChain, IMapperService mapper)
        {
            _blockChain = blockChain;
            _mapper = mapper;
        }

        public override async Task<ResolveChainReply> ResolveChain(ResolveChainRequest request, ServerCallContext context)
        {
            var chainToSend = _mapper.Map<Block[], ProtoBlock[]>(_blockChain.GetChain().ToArray());

            return new ResolveChainReply()
            {
                Blockchain =
                {
                    chainToSend
                }
            };
        }
    }
}
