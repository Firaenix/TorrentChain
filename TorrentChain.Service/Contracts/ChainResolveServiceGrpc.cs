// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChainResolveService.proto
// </auto-generated>
#pragma warning disable 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace TorrentChain.Service {
  public static partial class ChainResolve
  {
    static readonly string __ServiceName = "ChainResolve";

    static readonly grpc::Marshaller<global::GetBlockChainRequest> __Marshaller_GetBlockChainRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GetBlockChainRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GetBlockChainReply> __Marshaller_GetBlockChainReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GetBlockChainReply.Parser.ParseFrom);

    static readonly grpc::Method<global::GetBlockChainRequest, global::GetBlockChainReply> __Method_GetBlockchain = new grpc::Method<global::GetBlockChainRequest, global::GetBlockChainReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetBlockchain",
        __Marshaller_GetBlockChainRequest,
        __Marshaller_GetBlockChainReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ChainResolveServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ChainResolve</summary>
    public abstract partial class ChainResolveBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GetBlockChainReply> GetBlockchain(global::GetBlockChainRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ChainResolve</summary>
    public partial class ChainResolveClient : grpc::ClientBase<ChainResolveClient>
    {
      /// <summary>Creates a new client for ChainResolve</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ChainResolveClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ChainResolve that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ChainResolveClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ChainResolveClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ChainResolveClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::GetBlockChainReply GetBlockchain(global::GetBlockChainRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetBlockchain(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GetBlockChainReply GetBlockchain(global::GetBlockChainRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetBlockchain, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GetBlockChainReply> GetBlockchainAsync(global::GetBlockChainRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetBlockchainAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GetBlockChainReply> GetBlockchainAsync(global::GetBlockChainRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetBlockchain, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ChainResolveClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ChainResolveClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ChainResolveBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetBlockchain, serviceImpl.GetBlockchain).Build();
    }

  }
}
#endregion
