// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PropRogueInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PropRogueInfo.proto</summary>
  public static partial class PropRogueInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for PropRogueInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PropRogueInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNQcm9wUm9ndWVJbmZvLnByb3RvIl0KDVByb3BSb2d1ZUluZm8SFQoNY2Fu",
            "X3VzZV9jb3VudBgCIAEoDRIPCgdyb29tX2lkGAogASgNEhMKC0NOQUNDTUVP",
            "TkZLGAsgASgNEg8KB3NpdGVfaWQYDSABKA1CHqoCG0VnZ0xpbmsuRGFuaGVu",
            "Z1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PropRogueInfo), global::EggLink.DanhengServer.Proto.PropRogueInfo.Parser, new[]{ "CanUseCount", "RoomId", "CNACCMEONFK", "SiteId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PropRogueInfo : pb::IMessage<PropRogueInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PropRogueInfo> _parser = new pb::MessageParser<PropRogueInfo>(() => new PropRogueInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PropRogueInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PropRogueInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PropRogueInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PropRogueInfo(PropRogueInfo other) : this() {
      canUseCount_ = other.canUseCount_;
      roomId_ = other.roomId_;
      cNACCMEONFK_ = other.cNACCMEONFK_;
      siteId_ = other.siteId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PropRogueInfo Clone() {
      return new PropRogueInfo(this);
    }

    /// <summary>Field number for the "can_use_count" field.</summary>
    public const int CanUseCountFieldNumber = 2;
    private uint canUseCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CanUseCount {
      get { return canUseCount_; }
      set {
        canUseCount_ = value;
      }
    }

    /// <summary>Field number for the "room_id" field.</summary>
    public const int RoomIdFieldNumber = 10;
    private uint roomId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RoomId {
      get { return roomId_; }
      set {
        roomId_ = value;
      }
    }

    /// <summary>Field number for the "CNACCMEONFK" field.</summary>
    public const int CNACCMEONFKFieldNumber = 11;
    private uint cNACCMEONFK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CNACCMEONFK {
      get { return cNACCMEONFK_; }
      set {
        cNACCMEONFK_ = value;
      }
    }

    /// <summary>Field number for the "site_id" field.</summary>
    public const int SiteIdFieldNumber = 13;
    private uint siteId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SiteId {
      get { return siteId_; }
      set {
        siteId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PropRogueInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PropRogueInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CanUseCount != other.CanUseCount) return false;
      if (RoomId != other.RoomId) return false;
      if (CNACCMEONFK != other.CNACCMEONFK) return false;
      if (SiteId != other.SiteId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CanUseCount != 0) hash ^= CanUseCount.GetHashCode();
      if (RoomId != 0) hash ^= RoomId.GetHashCode();
      if (CNACCMEONFK != 0) hash ^= CNACCMEONFK.GetHashCode();
      if (SiteId != 0) hash ^= SiteId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (CanUseCount != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CanUseCount);
      }
      if (RoomId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(RoomId);
      }
      if (CNACCMEONFK != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CNACCMEONFK);
      }
      if (SiteId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(SiteId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (CanUseCount != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CanUseCount);
      }
      if (RoomId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(RoomId);
      }
      if (CNACCMEONFK != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CNACCMEONFK);
      }
      if (SiteId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(SiteId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (CanUseCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CanUseCount);
      }
      if (RoomId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RoomId);
      }
      if (CNACCMEONFK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CNACCMEONFK);
      }
      if (SiteId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SiteId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PropRogueInfo other) {
      if (other == null) {
        return;
      }
      if (other.CanUseCount != 0) {
        CanUseCount = other.CanUseCount;
      }
      if (other.RoomId != 0) {
        RoomId = other.RoomId;
      }
      if (other.CNACCMEONFK != 0) {
        CNACCMEONFK = other.CNACCMEONFK;
      }
      if (other.SiteId != 0) {
        SiteId = other.SiteId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 16: {
            CanUseCount = input.ReadUInt32();
            break;
          }
          case 80: {
            RoomId = input.ReadUInt32();
            break;
          }
          case 88: {
            CNACCMEONFK = input.ReadUInt32();
            break;
          }
          case 104: {
            SiteId = input.ReadUInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 16: {
            CanUseCount = input.ReadUInt32();
            break;
          }
          case 80: {
            RoomId = input.ReadUInt32();
            break;
          }
          case 88: {
            CNACCMEONFK = input.ReadUInt32();
            break;
          }
          case 104: {
            SiteId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
