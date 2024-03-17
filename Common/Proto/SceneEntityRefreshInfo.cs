// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneEntityRefreshInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SceneEntityRefreshInfo.proto</summary>
  public static partial class SceneEntityRefreshInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneEntityRefreshInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneEntityRefreshInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxTY2VuZUVudGl0eVJlZnJlc2hJbmZvLnByb3RvGhVTY2VuZUVudGl0eUlu",
            "Zm8ucHJvdG8iZwoWU2NlbmVFbnRpdHlSZWZyZXNoSW5mbxIkCgphZGRfZW50",
            "aXR5GAEgASgLMhAuU2NlbmVFbnRpdHlJbmZvEhIKCmRlbF9lbnRpdHkYByAB",
            "KA0SEwoLRERLRUxQREVDREMYDCABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1Nl",
            "cnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.SceneEntityInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SceneEntityRefreshInfo), global::EggLink.DanhengServer.Proto.SceneEntityRefreshInfo.Parser, new[]{ "AddEntity", "DelEntity", "DDKELPDECDC" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SceneEntityRefreshInfo : pb::IMessage<SceneEntityRefreshInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneEntityRefreshInfo> _parser = new pb::MessageParser<SceneEntityRefreshInfo>(() => new SceneEntityRefreshInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneEntityRefreshInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SceneEntityRefreshInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneEntityRefreshInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneEntityRefreshInfo(SceneEntityRefreshInfo other) : this() {
      addEntity_ = other.addEntity_ != null ? other.addEntity_.Clone() : null;
      delEntity_ = other.delEntity_;
      dDKELPDECDC_ = other.dDKELPDECDC_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneEntityRefreshInfo Clone() {
      return new SceneEntityRefreshInfo(this);
    }

    /// <summary>Field number for the "add_entity" field.</summary>
    public const int AddEntityFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.SceneEntityInfo addEntity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.SceneEntityInfo AddEntity {
      get { return addEntity_; }
      set {
        addEntity_ = value;
      }
    }

    /// <summary>Field number for the "del_entity" field.</summary>
    public const int DelEntityFieldNumber = 7;
    private uint delEntity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DelEntity {
      get { return delEntity_; }
      set {
        delEntity_ = value;
      }
    }

    /// <summary>Field number for the "DDKELPDECDC" field.</summary>
    public const int DDKELPDECDCFieldNumber = 12;
    private uint dDKELPDECDC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DDKELPDECDC {
      get { return dDKELPDECDC_; }
      set {
        dDKELPDECDC_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneEntityRefreshInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneEntityRefreshInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(AddEntity, other.AddEntity)) return false;
      if (DelEntity != other.DelEntity) return false;
      if (DDKELPDECDC != other.DDKELPDECDC) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (addEntity_ != null) hash ^= AddEntity.GetHashCode();
      if (DelEntity != 0) hash ^= DelEntity.GetHashCode();
      if (DDKELPDECDC != 0) hash ^= DDKELPDECDC.GetHashCode();
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
      if (addEntity_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AddEntity);
      }
      if (DelEntity != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(DelEntity);
      }
      if (DDKELPDECDC != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(DDKELPDECDC);
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
      if (addEntity_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(AddEntity);
      }
      if (DelEntity != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(DelEntity);
      }
      if (DDKELPDECDC != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(DDKELPDECDC);
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
      if (addEntity_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AddEntity);
      }
      if (DelEntity != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DelEntity);
      }
      if (DDKELPDECDC != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DDKELPDECDC);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneEntityRefreshInfo other) {
      if (other == null) {
        return;
      }
      if (other.addEntity_ != null) {
        if (addEntity_ == null) {
          AddEntity = new global::EggLink.DanhengServer.Proto.SceneEntityInfo();
        }
        AddEntity.MergeFrom(other.AddEntity);
      }
      if (other.DelEntity != 0) {
        DelEntity = other.DelEntity;
      }
      if (other.DDKELPDECDC != 0) {
        DDKELPDECDC = other.DDKELPDECDC;
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
          case 10: {
            if (addEntity_ == null) {
              AddEntity = new global::EggLink.DanhengServer.Proto.SceneEntityInfo();
            }
            input.ReadMessage(AddEntity);
            break;
          }
          case 56: {
            DelEntity = input.ReadUInt32();
            break;
          }
          case 96: {
            DDKELPDECDC = input.ReadUInt32();
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
          case 10: {
            if (addEntity_ == null) {
              AddEntity = new global::EggLink.DanhengServer.Proto.SceneEntityInfo();
            }
            input.ReadMessage(AddEntity);
            break;
          }
          case 56: {
            DelEntity = input.ReadUInt32();
            break;
          }
          case 96: {
            DDKELPDECDC = input.ReadUInt32();
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
