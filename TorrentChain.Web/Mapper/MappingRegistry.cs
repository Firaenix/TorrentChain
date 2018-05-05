using TorrentChain.Service.Mapper;

namespace TorrentChain.Web.Mapper
{
    public class MappingRegistry
    {
        public static void RegisterMappings()
        {
            new ServiceMapper().Configure();
            new WebMapper().Configure();
        }
    }
}
