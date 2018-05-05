using TorrentChain.Data.Models;
using EMapper = ExpressMapper.Mapper;

namespace TorrentChain.Service.Mapper
{
    public interface IMapperService
    {
        void Configure();
        To Map<From, To>(From from);
    }

    public abstract class BaseMapper : IMapperService
    {
        public abstract void Configure();

        public To Map<From, To>(From from) => EMapper.Map<From, To>(from);
    }

    public class ServiceMapper : BaseMapper
    {
        public override void Configure()
        {
            EMapper.Register<ProtoBlock, Block>();
        }
    }
}