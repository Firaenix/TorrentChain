using System;
using System.Linq;
using Google.Protobuf;
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

        public virtual To Map<From, To>(From from) => EMapper.Map<From, To>(from);
    }

    public class ServiceMapper : BaseMapper
    {
        public override void Configure()
        {
            EMapper.RegisterCustom<ProtoBlock, Block>((proto) => new Block(new BlockParams()
            {
                Index = proto.Index,
                Hash = proto.Hash,
                Data = new BlockData(proto.BlockData),
                PreviousHash = proto.PreviousHash,
                Signature = new PGPSignature(proto.Signature),
                Timestamp = DateTimeOffset.FromUnixTimeMilliseconds(proto.TimeStamp).DateTime
            }));
            
            EMapper.RegisterCustom<Block, ProtoBlock>((block) => new ProtoBlock()
            {
                Index = block.Index,
                BlockData = ByteString.CopyFrom(block.BlockData.Data.ToArray()),
                Hash = ByteString.CopyFrom(block.Hash.ToArray()),
                PreviousHash = ByteString.CopyFrom(block.PreviousHash.ToArray()),
                Signature = ByteString.CopyFrom(new byte[0]),
                TimeStamp = new DateTimeOffset(block.TimeStamp).ToUnixTimeMilliseconds()
            });

            EMapper.Compile();
        }
    }
}