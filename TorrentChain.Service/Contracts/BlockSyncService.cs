// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: BlockSyncService.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from BlockSyncService.proto</summary>
public static partial class BlockSyncServiceReflection {

  #region Descriptor
  /// <summary>File descriptor for BlockSyncService.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static BlockSyncServiceReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChZCbG9ja1N5bmNTZXJ2aWNlLnByb3RvIngKClByb3RvQmxvY2sSDQoFSW5k",
          "ZXgYASABKAMSEQoJQmxvY2tEYXRhGAIgASgMEgwKBEhhc2gYAyABKAwSFAoM",
          "UHJldmlvdXNIYXNoGAQgASgMEhEKCVNpZ25hdHVyZRgFIAEoDBIRCglUaW1l",
          "U3RhbXAYBiABKAMiFQoTUmVzb2x2ZUNoYWluUmVxdWVzdCI0ChFSZXNvbHZl",
          "Q2hhaW5SZXBseRIfCgpCbG9ja2NoYWluGAEgAygLMgsuUHJvdG9CbG9jayIu",
          "ChBTZW5kQmxvY2tSZXF1ZXN0EhoKBUJsb2NrGAEgASgLMgsuUHJvdG9CbG9j",
          "ayIhCg5TZW5kQmxvY2tSZXBseRIPCgdTdWNjZXNzGAEgASgIMnoKCUJsb2Nr",
          "U3luYxIxCglTZW5kQmxvY2sSES5TZW5kQmxvY2tSZXF1ZXN0Gg8uU2VuZEJs",
          "b2NrUmVwbHkiABI6CgxSZXNvbHZlQ2hhaW4SFC5SZXNvbHZlQ2hhaW5SZXF1",
          "ZXN0GhIuUmVzb2x2ZUNoYWluUmVwbHkiAGIGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ProtoBlock), global::ProtoBlock.Parser, new[]{ "Index", "BlockData", "Hash", "PreviousHash", "Signature", "TimeStamp" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::ResolveChainRequest), global::ResolveChainRequest.Parser, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::ResolveChainReply), global::ResolveChainReply.Parser, new[]{ "Blockchain" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::SendBlockRequest), global::SendBlockRequest.Parser, new[]{ "Block" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::SendBlockReply), global::SendBlockReply.Parser, new[]{ "Success" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class ProtoBlock : pb::IMessage<ProtoBlock> {
  private static readonly pb::MessageParser<ProtoBlock> _parser = new pb::MessageParser<ProtoBlock>(() => new ProtoBlock());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<ProtoBlock> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::BlockSyncServiceReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ProtoBlock() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ProtoBlock(ProtoBlock other) : this() {
    index_ = other.index_;
    blockData_ = other.blockData_;
    hash_ = other.hash_;
    previousHash_ = other.previousHash_;
    signature_ = other.signature_;
    timeStamp_ = other.timeStamp_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ProtoBlock Clone() {
    return new ProtoBlock(this);
  }

  /// <summary>Field number for the "Index" field.</summary>
  public const int IndexFieldNumber = 1;
  private long index_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public long Index {
    get { return index_; }
    set {
      index_ = value;
    }
  }

  /// <summary>Field number for the "BlockData" field.</summary>
  public const int BlockDataFieldNumber = 2;
  private pb::ByteString blockData_ = pb::ByteString.Empty;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pb::ByteString BlockData {
    get { return blockData_; }
    set {
      blockData_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "Hash" field.</summary>
  public const int HashFieldNumber = 3;
  private pb::ByteString hash_ = pb::ByteString.Empty;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pb::ByteString Hash {
    get { return hash_; }
    set {
      hash_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "PreviousHash" field.</summary>
  public const int PreviousHashFieldNumber = 4;
  private pb::ByteString previousHash_ = pb::ByteString.Empty;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pb::ByteString PreviousHash {
    get { return previousHash_; }
    set {
      previousHash_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "Signature" field.</summary>
  public const int SignatureFieldNumber = 5;
  private pb::ByteString signature_ = pb::ByteString.Empty;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pb::ByteString Signature {
    get { return signature_; }
    set {
      signature_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "TimeStamp" field.</summary>
  public const int TimeStampFieldNumber = 6;
  private long timeStamp_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public long TimeStamp {
    get { return timeStamp_; }
    set {
      timeStamp_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as ProtoBlock);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(ProtoBlock other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Index != other.Index) return false;
    if (BlockData != other.BlockData) return false;
    if (Hash != other.Hash) return false;
    if (PreviousHash != other.PreviousHash) return false;
    if (Signature != other.Signature) return false;
    if (TimeStamp != other.TimeStamp) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Index != 0L) hash ^= Index.GetHashCode();
    if (BlockData.Length != 0) hash ^= BlockData.GetHashCode();
    if (Hash.Length != 0) hash ^= Hash.GetHashCode();
    if (PreviousHash.Length != 0) hash ^= PreviousHash.GetHashCode();
    if (Signature.Length != 0) hash ^= Signature.GetHashCode();
    if (TimeStamp != 0L) hash ^= TimeStamp.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Index != 0L) {
      output.WriteRawTag(8);
      output.WriteInt64(Index);
    }
    if (BlockData.Length != 0) {
      output.WriteRawTag(18);
      output.WriteBytes(BlockData);
    }
    if (Hash.Length != 0) {
      output.WriteRawTag(26);
      output.WriteBytes(Hash);
    }
    if (PreviousHash.Length != 0) {
      output.WriteRawTag(34);
      output.WriteBytes(PreviousHash);
    }
    if (Signature.Length != 0) {
      output.WriteRawTag(42);
      output.WriteBytes(Signature);
    }
    if (TimeStamp != 0L) {
      output.WriteRawTag(48);
      output.WriteInt64(TimeStamp);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Index != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(Index);
    }
    if (BlockData.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeBytesSize(BlockData);
    }
    if (Hash.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeBytesSize(Hash);
    }
    if (PreviousHash.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeBytesSize(PreviousHash);
    }
    if (Signature.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeBytesSize(Signature);
    }
    if (TimeStamp != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(TimeStamp);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(ProtoBlock other) {
    if (other == null) {
      return;
    }
    if (other.Index != 0L) {
      Index = other.Index;
    }
    if (other.BlockData.Length != 0) {
      BlockData = other.BlockData;
    }
    if (other.Hash.Length != 0) {
      Hash = other.Hash;
    }
    if (other.PreviousHash.Length != 0) {
      PreviousHash = other.PreviousHash;
    }
    if (other.Signature.Length != 0) {
      Signature = other.Signature;
    }
    if (other.TimeStamp != 0L) {
      TimeStamp = other.TimeStamp;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 8: {
          Index = input.ReadInt64();
          break;
        }
        case 18: {
          BlockData = input.ReadBytes();
          break;
        }
        case 26: {
          Hash = input.ReadBytes();
          break;
        }
        case 34: {
          PreviousHash = input.ReadBytes();
          break;
        }
        case 42: {
          Signature = input.ReadBytes();
          break;
        }
        case 48: {
          TimeStamp = input.ReadInt64();
          break;
        }
      }
    }
  }

}

public sealed partial class ResolveChainRequest : pb::IMessage<ResolveChainRequest> {
  private static readonly pb::MessageParser<ResolveChainRequest> _parser = new pb::MessageParser<ResolveChainRequest>(() => new ResolveChainRequest());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<ResolveChainRequest> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::BlockSyncServiceReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ResolveChainRequest() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ResolveChainRequest(ResolveChainRequest other) : this() {
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ResolveChainRequest Clone() {
    return new ResolveChainRequest(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as ResolveChainRequest);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(ResolveChainRequest other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(ResolveChainRequest other) {
    if (other == null) {
      return;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
      }
    }
  }

}

public sealed partial class ResolveChainReply : pb::IMessage<ResolveChainReply> {
  private static readonly pb::MessageParser<ResolveChainReply> _parser = new pb::MessageParser<ResolveChainReply>(() => new ResolveChainReply());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<ResolveChainReply> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::BlockSyncServiceReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ResolveChainReply() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ResolveChainReply(ResolveChainReply other) : this() {
    blockchain_ = other.blockchain_.Clone();
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ResolveChainReply Clone() {
    return new ResolveChainReply(this);
  }

  /// <summary>Field number for the "Blockchain" field.</summary>
  public const int BlockchainFieldNumber = 1;
  private static readonly pb::FieldCodec<global::ProtoBlock> _repeated_blockchain_codec
      = pb::FieldCodec.ForMessage(10, global::ProtoBlock.Parser);
  private readonly pbc::RepeatedField<global::ProtoBlock> blockchain_ = new pbc::RepeatedField<global::ProtoBlock>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<global::ProtoBlock> Blockchain {
    get { return blockchain_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as ResolveChainReply);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(ResolveChainReply other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!blockchain_.Equals(other.blockchain_)) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= blockchain_.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    blockchain_.WriteTo(output, _repeated_blockchain_codec);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    size += blockchain_.CalculateSize(_repeated_blockchain_codec);
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(ResolveChainReply other) {
    if (other == null) {
      return;
    }
    blockchain_.Add(other.blockchain_);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 10: {
          blockchain_.AddEntriesFrom(input, _repeated_blockchain_codec);
          break;
        }
      }
    }
  }

}

public sealed partial class SendBlockRequest : pb::IMessage<SendBlockRequest> {
  private static readonly pb::MessageParser<SendBlockRequest> _parser = new pb::MessageParser<SendBlockRequest>(() => new SendBlockRequest());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<SendBlockRequest> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::BlockSyncServiceReflection.Descriptor.MessageTypes[3]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SendBlockRequest() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SendBlockRequest(SendBlockRequest other) : this() {
    Block = other.block_ != null ? other.Block.Clone() : null;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SendBlockRequest Clone() {
    return new SendBlockRequest(this);
  }

  /// <summary>Field number for the "Block" field.</summary>
  public const int BlockFieldNumber = 1;
  private global::ProtoBlock block_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::ProtoBlock Block {
    get { return block_; }
    set {
      block_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as SendBlockRequest);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(SendBlockRequest other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(Block, other.Block)) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (block_ != null) hash ^= Block.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (block_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(Block);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (block_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Block);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(SendBlockRequest other) {
    if (other == null) {
      return;
    }
    if (other.block_ != null) {
      if (block_ == null) {
        block_ = new global::ProtoBlock();
      }
      Block.MergeFrom(other.Block);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 10: {
          if (block_ == null) {
            block_ = new global::ProtoBlock();
          }
          input.ReadMessage(block_);
          break;
        }
      }
    }
  }

}

public sealed partial class SendBlockReply : pb::IMessage<SendBlockReply> {
  private static readonly pb::MessageParser<SendBlockReply> _parser = new pb::MessageParser<SendBlockReply>(() => new SendBlockReply());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<SendBlockReply> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::BlockSyncServiceReflection.Descriptor.MessageTypes[4]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SendBlockReply() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SendBlockReply(SendBlockReply other) : this() {
    success_ = other.success_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public SendBlockReply Clone() {
    return new SendBlockReply(this);
  }

  /// <summary>Field number for the "Success" field.</summary>
  public const int SuccessFieldNumber = 1;
  private bool success_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Success {
    get { return success_; }
    set {
      success_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as SendBlockReply);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(SendBlockReply other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Success != other.Success) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Success != false) hash ^= Success.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Success != false) {
      output.WriteRawTag(8);
      output.WriteBool(Success);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Success != false) {
      size += 1 + 1;
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(SendBlockReply other) {
    if (other == null) {
      return;
    }
    if (other.Success != false) {
      Success = other.Success;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 8: {
          Success = input.ReadBool();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
