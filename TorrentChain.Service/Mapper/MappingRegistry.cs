namespace TorrentChain.Service.Mapper
{
    public class MappingRegistry
    {
        public static void RegisterMappings() => new ServiceMapper().Configure();
    }
}
