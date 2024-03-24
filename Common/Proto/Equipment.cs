// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Equipment.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from Equipment.proto</summary>
  public static partial class EquipmentReflection {

    #region Descriptor
    /// <summary>File descriptor for Equipment.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EquipmentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9FcXVpcG1lbnQucHJvdG8ilgEKCUVxdWlwbWVudBILCgN0aWQYAyABKA0S",
            "CwoDZXhwGAYgASgNEhQKDGlzX3Byb3RlY3RlZBgFIAEoCBINCgVsZXZlbBgO",
            "IAEoDRIWCg5iYXNlX2F2YXRhcl9pZBgPIAEoDRIMCgRyYW5rGAQgASgNEhEK",
            "CXByb21vdGlvbhgMIAEoDRIRCgl1bmlxdWVfaWQYCyABKA1CHqoCG0VnZ0xp",
            "bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.Equipment), global::EggLink.DanhengServer.Proto.Equipment.Parser, new[]{ "Tid", "Exp", "IsProtected", "Level", "BaseAvatarId", "Rank", "Promotion", "UniqueId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Equipment : pb::IMessage<Equipment>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Equipment> _parser = new pb::MessageParser<Equipment>(() => new Equipment());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Equipment> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.EquipmentReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Equipment() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Equipment(Equipment other) : this() {
      tid_ = other.tid_;
      exp_ = other.exp_;
      isProtected_ = other.isProtected_;
      level_ = other.level_;
      baseAvatarId_ = other.baseAvatarId_;
      rank_ = other.rank_;
      promotion_ = other.promotion_;
      uniqueId_ = other.uniqueId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Equipment Clone() {
      return new Equipment(this);
    }

    /// <summary>Field number for the "tid" field.</summary>
    public const int TidFieldNumber = 3;
    private uint tid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Tid {
      get { return tid_; }
      set {
        tid_ = value;
      }
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 6;
    private uint exp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    /// <summary>Field number for the "is_protected" field.</summary>
    public const int IsProtectedFieldNumber = 5;
    private bool isProtected_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsProtected {
      get { return isProtected_; }
      set {
        isProtected_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 14;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "base_avatar_id" field.</summary>
    public const int BaseAvatarIdFieldNumber = 15;
    private uint baseAvatarId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BaseAvatarId {
      get { return baseAvatarId_; }
      set {
        baseAvatarId_ = value;
      }
    }

    /// <summary>Field number for the "rank" field.</summary>
    public const int RankFieldNumber = 4;
    private uint rank_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Rank {
      get { return rank_; }
      set {
        rank_ = value;
      }
    }

    /// <summary>Field number for the "promotion" field.</summary>
    public const int PromotionFieldNumber = 12;
    private uint promotion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Promotion {
      get { return promotion_; }
      set {
        promotion_ = value;
      }
    }

    /// <summary>Field number for the "unique_id" field.</summary>
    public const int UniqueIdFieldNumber = 11;
    private uint uniqueId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UniqueId {
      get { return uniqueId_; }
      set {
        uniqueId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Equipment);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Equipment other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Tid != other.Tid) return false;
      if (Exp != other.Exp) return false;
      if (IsProtected != other.IsProtected) return false;
      if (Level != other.Level) return false;
      if (BaseAvatarId != other.BaseAvatarId) return false;
      if (Rank != other.Rank) return false;
      if (Promotion != other.Promotion) return false;
      if (UniqueId != other.UniqueId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Tid != 0) hash ^= Tid.GetHashCode();
      if (Exp != 0) hash ^= Exp.GetHashCode();
      if (IsProtected != false) hash ^= IsProtected.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (BaseAvatarId != 0) hash ^= BaseAvatarId.GetHashCode();
      if (Rank != 0) hash ^= Rank.GetHashCode();
      if (Promotion != 0) hash ^= Promotion.GetHashCode();
      if (UniqueId != 0) hash ^= UniqueId.GetHashCode();
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
      if (Tid != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Tid);
      }
      if (Rank != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Rank);
      }
      if (IsProtected != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsProtected);
      }
      if (Exp != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Exp);
      }
      if (UniqueId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(UniqueId);
      }
      if (Promotion != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Promotion);
      }
      if (Level != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Level);
      }
      if (BaseAvatarId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(BaseAvatarId);
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
      if (Tid != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Tid);
      }
      if (Rank != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Rank);
      }
      if (IsProtected != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsProtected);
      }
      if (Exp != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Exp);
      }
      if (UniqueId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(UniqueId);
      }
      if (Promotion != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Promotion);
      }
      if (Level != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Level);
      }
      if (BaseAvatarId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(BaseAvatarId);
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
      if (Tid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Tid);
      }
      if (Exp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Exp);
      }
      if (IsProtected != false) {
        size += 1 + 1;
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (BaseAvatarId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BaseAvatarId);
      }
      if (Rank != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Rank);
      }
      if (Promotion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Promotion);
      }
      if (UniqueId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UniqueId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Equipment other) {
      if (other == null) {
        return;
      }
      if (other.Tid != 0) {
        Tid = other.Tid;
      }
      if (other.Exp != 0) {
        Exp = other.Exp;
      }
      if (other.IsProtected != false) {
        IsProtected = other.IsProtected;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.BaseAvatarId != 0) {
        BaseAvatarId = other.BaseAvatarId;
      }
      if (other.Rank != 0) {
        Rank = other.Rank;
      }
      if (other.Promotion != 0) {
        Promotion = other.Promotion;
      }
      if (other.UniqueId != 0) {
        UniqueId = other.UniqueId;
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
          case 24: {
            Tid = input.ReadUInt32();
            break;
          }
          case 32: {
            Rank = input.ReadUInt32();
            break;
          }
          case 40: {
            IsProtected = input.ReadBool();
            break;
          }
          case 48: {
            Exp = input.ReadUInt32();
            break;
          }
          case 88: {
            UniqueId = input.ReadUInt32();
            break;
          }
          case 96: {
            Promotion = input.ReadUInt32();
            break;
          }
          case 112: {
            Level = input.ReadUInt32();
            break;
          }
          case 120: {
            BaseAvatarId = input.ReadUInt32();
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
          case 24: {
            Tid = input.ReadUInt32();
            break;
          }
          case 32: {
            Rank = input.ReadUInt32();
            break;
          }
          case 40: {
            IsProtected = input.ReadBool();
            break;
          }
          case 48: {
            Exp = input.ReadUInt32();
            break;
          }
          case 88: {
            UniqueId = input.ReadUInt32();
            break;
          }
          case 96: {
            Promotion = input.ReadUInt32();
            break;
          }
          case 112: {
            Level = input.ReadUInt32();
            break;
          }
          case 120: {
            BaseAvatarId = input.ReadUInt32();
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
