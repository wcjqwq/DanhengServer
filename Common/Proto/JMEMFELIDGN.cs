// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: JMEMFELIDGN.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from JMEMFELIDGN.proto</summary>
  public static partial class JMEMFELIDGNReflection {

    #region Descriptor
    /// <summary>File descriptor for JMEMFELIDGN.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static JMEMFELIDGNReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFKTUVNRkVMSURHTi5wcm90bxoPU3BCYXJJbmZvLnByb3RvGhFMQU9BS0JF",
            "SVBLRi5wcm90byJRCgtKTUVNRkVMSURHThIaCgR0eXBlGAEgASgOMgwuTEFP",
            "QUtCRUlQS0YSCgoCaWQYAiABKA0SGgoGc3BfYmFyGAMgASgLMgouU3BCYXJJ",
            "bmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.SpBarInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.LAOAKBEIPKFReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.JMEMFELIDGN), global::EggLink.DanhengServer.Proto.JMEMFELIDGN.Parser, new[]{ "Type", "Id", "SpBar" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class JMEMFELIDGN : pb::IMessage<JMEMFELIDGN>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<JMEMFELIDGN> _parser = new pb::MessageParser<JMEMFELIDGN>(() => new JMEMFELIDGN());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<JMEMFELIDGN> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.JMEMFELIDGNReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JMEMFELIDGN() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JMEMFELIDGN(JMEMFELIDGN other) : this() {
      type_ = other.type_;
      id_ = other.id_;
      spBar_ = other.spBar_ != null ? other.spBar_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public JMEMFELIDGN Clone() {
      return new JMEMFELIDGN(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.LAOAKBEIPKF type_ = global::EggLink.DanhengServer.Proto.LAOAKBEIPKF.AetherdivideSpiritLineupNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.LAOAKBEIPKF Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "sp_bar" field.</summary>
    public const int SpBarFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.SpBarInfo spBar_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.SpBarInfo SpBar {
      get { return spBar_; }
      set {
        spBar_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as JMEMFELIDGN);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(JMEMFELIDGN other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (Id != other.Id) return false;
      if (!object.Equals(SpBar, other.SpBar)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != global::EggLink.DanhengServer.Proto.LAOAKBEIPKF.AetherdivideSpiritLineupNone) hash ^= Type.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      if (spBar_ != null) hash ^= SpBar.GetHashCode();
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
      if (Type != global::EggLink.DanhengServer.Proto.LAOAKBEIPKF.AetherdivideSpiritLineupNone) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (Id != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Id);
      }
      if (spBar_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(SpBar);
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
      if (Type != global::EggLink.DanhengServer.Proto.LAOAKBEIPKF.AetherdivideSpiritLineupNone) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (Id != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Id);
      }
      if (spBar_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(SpBar);
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
      if (Type != global::EggLink.DanhengServer.Proto.LAOAKBEIPKF.AetherdivideSpiritLineupNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (spBar_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SpBar);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(JMEMFELIDGN other) {
      if (other == null) {
        return;
      }
      if (other.Type != global::EggLink.DanhengServer.Proto.LAOAKBEIPKF.AetherdivideSpiritLineupNone) {
        Type = other.Type;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.spBar_ != null) {
        if (spBar_ == null) {
          SpBar = new global::EggLink.DanhengServer.Proto.SpBarInfo();
        }
        SpBar.MergeFrom(other.SpBar);
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
            Type = (global::EggLink.DanhengServer.Proto.LAOAKBEIPKF) input.ReadEnum();
            break;
          }
          case 16: {
            Id = input.ReadUInt32();
            break;
          }
          case 26: {
            if (spBar_ == null) {
              SpBar = new global::EggLink.DanhengServer.Proto.SpBarInfo();
            }
            input.ReadMessage(SpBar);
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
            Type = (global::EggLink.DanhengServer.Proto.LAOAKBEIPKF) input.ReadEnum();
            break;
          }
          case 16: {
            Id = input.ReadUInt32();
            break;
          }
          case 26: {
            if (spBar_ == null) {
              SpBar = new global::EggLink.DanhengServer.Proto.SpBarInfo();
            }
            input.ReadMessage(SpBar);
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
