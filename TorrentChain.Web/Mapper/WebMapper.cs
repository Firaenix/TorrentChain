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
            EMapper.RegisterCustom<Block, BlockViewModel>((block) => new BlockViewModel()
            {
                Block = block,
                TorrentInfo = BlockUtils.GetTorrentInformation(block),
                MagnetLink = BlockUtils.GetTorrentInformation(block).GetMagnetLink()
            });

            EMapper.Compile();
        }
    }
}
