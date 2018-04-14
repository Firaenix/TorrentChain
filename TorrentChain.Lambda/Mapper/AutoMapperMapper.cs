using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TorrentChain.Data.Models;
using TorrentChain.Data.Utils;
using TorrentChain.Lambda.Models;

namespace TorrentChain.Lambda.Mapper
{
    public interface IMapperService
    {
        void Configure();
        To Map<From, To>(From from);
    }

    public class AutoMapperMapper : IMapperService
    {
        public void Configure()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Block, BlockViewModel>()
                .ForMember(dest => dest.TorrentInfo, opts => opts.MapFrom(
                            src => BlockUtils.GetTorrentInformation(src)))
                           .ReverseMap();
            });
        }

        public To Map<From, To>(From from)
        {
            return AutoMapper.Mapper.Map<To>(from);
        }
    }
}
