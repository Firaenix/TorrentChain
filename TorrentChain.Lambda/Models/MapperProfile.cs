using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TorrentChain.Data.Models;
using TorrentChain.Data.Utils;

namespace TorrentChain.Lambda.Models
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Block, BlockViewModel>()
                .ForMember(dest => dest.TorrentInfo, opts => opts.MapFrom(
                            src => BlockUtils.GetTorrentInformation(src)))
                           .ReverseMap();
        }
    }
}
