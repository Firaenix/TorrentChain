using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TorrentChain.Lambda.Mapper
{
    public class MappingRegistry
    {
        public static void RegisterMappings() => new AutoMapperMapper().Configure();
    }
}
