// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TrainVisitorRewardSendNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TrainVisitorRewardSendNotify.proto</summary>
  public static partial class TrainVisitorRewardSendNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for TrainVisitorRewardSendNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TrainVisitorRewardSendNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJUcmFpblZpc2l0b3JSZXdhcmRTZW5kTm90aWZ5LnByb3RvGh5UcmFpblZp",
            "c2l0b3JSZXdhcmRTdGF0dXMucHJvdG8aDkl0ZW1MaXN0LnByb3RvIncKHFRy",
            "YWluVmlzaXRvclJld2FyZFNlbmROb3RpZnkSJwoEdHlwZRgEIAEoDjIZLlRy",
            "YWluVmlzaXRvclJld2FyZFN0YXR1cxITCgtKT0JMQkxDT05BTRgBIAEoDRIZ",
            "CgZyZXdhcmQYCyABKAsyCS5JdGVtTGlzdEIeqgIbRWdnTGluay5EYW5oZW5n",
            "U2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.TrainVisitorRewardStatusReflection.Descriptor, global::EggLink.DanhengServer.Proto.ItemListReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TrainVisitorRewardSendNotify), global::EggLink.DanhengServer.Proto.TrainVisitorRewardSendNotify.Parser, new[]{ "Type", "JOBLBLCONAM", "Reward" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TrainVisitorRewardSendNotify : pb::IMessage<TrainVisitorRewardSendNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TrainVisitorRewardSendNotify> _parser = new pb::MessageParser<TrainVisitorRewardSendNotify>(() => new TrainVisitorRewardSendNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TrainVisitorRewardSendNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TrainVisitorRewardSendNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrainVisitorRewardSendNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrainVisitorRewardSendNotify(TrainVisitorRewardSendNotify other) : this() {
      type_ = other.type_;
      jOBLBLCONAM_ = other.jOBLBLCONAM_;
      reward_ = other.reward_ != null ? other.reward_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrainVisitorRewardSendNotify Clone() {
      return new TrainVisitorRewardSendNotify(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.TrainVisitorRewardStatus type_ = global::EggLink.DanhengServer.Proto.TrainVisitorRewardStatus.TrainVisitorRewardSendNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.TrainVisitorRewardStatus Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "JOBLBLCONAM" field.</summary>
    public const int JOBLBLCONAMFieldNumber = 1;
    private uint jOBLBLCONAM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint JOBLBLCONAM {
      get { return jOBLBLCONAM_; }
      set {
        jOBLBLCONAM_ = value;
      }
    }

    /// <summary>Field number for the "reward" field.</summary>
    public const int RewardFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.ItemList reward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ItemList Reward {
      get { return reward_; }
      set {
        reward_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TrainVisitorRewardSendNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TrainVisitorRewardSendNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (JOBLBLCONAM != other.JOBLBLCONAM) return false;
      if (!object.Equals(Reward, other.Reward)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != global::EggLink.DanhengServer.Proto.TrainVisitorRewardStatus.TrainVisitorRewardSendNone) hash ^= Type.GetHashCode();
      if (JOBLBLCONAM != 0) hash ^= JOBLBLCONAM.GetHashCode();
      if (reward_ != null) hash ^= Reward.GetHashCode();
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
      if (JOBLBLCONAM != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(JOBLBLCONAM);
      }
      if (Type != global::EggLink.DanhengServer.Proto.TrainVisitorRewardStatus.TrainVisitorRewardSendNone) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Type);
      }
      if (reward_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(Reward);
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
      if (JOBLBLCONAM != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(JOBLBLCONAM);
      }
      if (Type != global::EggLink.DanhengServer.Proto.TrainVisitorRewardStatus.TrainVisitorRewardSendNone) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Type);
      }
      if (reward_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(Reward);
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
      if (Type != global::EggLink.DanhengServer.Proto.TrainVisitorRewardStatus.TrainVisitorRewardSendNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (JOBLBLCONAM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(JOBLBLCONAM);
      }
      if (reward_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reward);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TrainVisitorRewardSendNotify other) {
      if (other == null) {
        return;
      }
      if (other.Type != global::EggLink.DanhengServer.Proto.TrainVisitorRewardStatus.TrainVisitorRewardSendNone) {
        Type = other.Type;
      }
      if (other.JOBLBLCONAM != 0) {
        JOBLBLCONAM = other.JOBLBLCONAM;
      }
      if (other.reward_ != null) {
        if (reward_ == null) {
          Reward = new global::EggLink.DanhengServer.Proto.ItemList();
        }
        Reward.MergeFrom(other.Reward);
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
          case 8: {
            JOBLBLCONAM = input.ReadUInt32();
            break;
          }
          case 32: {
            Type = (global::EggLink.DanhengServer.Proto.TrainVisitorRewardStatus) input.ReadEnum();
            break;
          }
          case 90: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
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
          case 8: {
            JOBLBLCONAM = input.ReadUInt32();
            break;
          }
          case 32: {
            Type = (global::EggLink.DanhengServer.Proto.TrainVisitorRewardStatus) input.ReadEnum();
            break;
          }
          case 90: {
            if (reward_ == null) {
              Reward = new global::EggLink.DanhengServer.Proto.ItemList();
            }
            input.ReadMessage(Reward);
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
