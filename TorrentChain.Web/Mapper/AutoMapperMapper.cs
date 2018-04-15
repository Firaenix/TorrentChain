using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TorrentChain.Data.Models;
using TorrentChain.Data.Utils;
using TorrentChain.Web.Models;

namespace TorrentChain.Web.Mapper
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
              .ForMember(dest => dest.Block, opts => opts.MapFrom(
                         src => src
              ))
              .ForMember(dest => dest.TorrentInfo, opts => opts.MapFrom(
                          src => BlockUtils.GetTorrentInformation(src)
                         ))
              .ForMember(dest => dest.MagnetLink, opts => opts.MapFrom(
                         src => BlockUtils.GetTorrentInformation(src).GetMagnetLink(BencodeNET.Torrents.MagnetLinkOptions.IncludeTrackers)
                         ))
                         .ReverseMap();
      });
    }

    public To Map<From, To>(From from)
    {
      return AutoMapper.Mapper.Map<To>(from);
    }
  }
}
