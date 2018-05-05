using TorrentChain.Data.Models;
using TorrentChain.Data.Utils;
using TorrentChain.Service.Mapper;
using TorrentChain.Web.Models;
using EMapper = ExpressMapper.Mapper;

namespace TorrentChain.Web.Mapper
{
    public class WebMapper : BaseMapper
    {
        public override void Configure()
        {
            EMapper.Register<Block, BlockViewModel>()
                   .Member(dest => dest.Block, src => src)
                   .Member(dest => dest.TorrentInfo, src => BlockUtils.GetTorrentInformation(src))
                   .Member(dest => dest.MagnetLink, 
                           src => BlockUtils.GetTorrentInformation(src).GetMagnetLink(BencodeNET.Torrents.MagnetLinkOptions.IncludeTrackers));
        }
    }
}
