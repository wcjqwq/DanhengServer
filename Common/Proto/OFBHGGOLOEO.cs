// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: OFBHGGOLOEO.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from OFBHGGOLOEO.proto</summary>
  public static partial class OFBHGGOLOEOReflection {

    #region Descriptor
    /// <summary>File descriptor for OFBHGGOLOEO.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OFBHGGOLOEOReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFPRkJIR0dPTE9FTy5wcm90byI3CgtPRkJIR0dPTE9FTxITCgtPRUlNRE5I",
            "REFGRxgNIAEoDRITCgtES0hPREtITkVQQhgDIAEoDUIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.OFBHGGOLOEO), global::EggLink.DanhengServer.Proto.OFBHGGOLOEO.Parser, new[]{ "OEIMDNHDAFG", "DKHODKHNEPB" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class OFBHGGOLOEO : pb::IMessage<OFBHGGOLOEO>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OFBHGGOLOEO> _parser = new pb::MessageParser<OFBHGGOLOEO>(() => new OFBHGGOLOEO());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OFBHGGOLOEO> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.OFBHGGOLOEOReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OFBHGGOLOEO() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OFBHGGOLOEO(OFBHGGOLOEO other) : this() {
      oEIMDNHDAFG_ = other.oEIMDNHDAFG_;
      dKHODKHNEPB_ = other.dKHODKHNEPB_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OFBHGGOLOEO Clone() {
      return new OFBHGGOLOEO(this);
    }

    /// <summary>Field number for the "OEIMDNHDAFG" field.</summary>
    public const int OEIMDNHDAFGFieldNumber = 13;
    private uint oEIMDNHDAFG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OEIMDNHDAFG {
      get { return oEIMDNHDAFG_; }
      set {
        oEIMDNHDAFG_ = value;
      }
    }

    /// <summary>Field number for the "DKHODKHNEPB" field.</summary>
    public const int DKHODKHNEPBFieldNumber = 3;
    private uint dKHODKHNEPB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DKHODKHNEPB {
      get { return dKHODKHNEPB_; }
      set {
        dKHODKHNEPB_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OFBHGGOLOEO);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OFBHGGOLOEO other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OEIMDNHDAFG != other.OEIMDNHDAFG) return false;
      if (DKHODKHNEPB != other.DKHODKHNEPB) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OEIMDNHDAFG != 0) hash ^= OEIMDNHDAFG.GetHashCode();
      if (DKHODKHNEPB != 0) hash ^= DKHODKHNEPB.GetHashCode();
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
      if (DKHODKHNEPB != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DKHODKHNEPB);
      }
      if (OEIMDNHDAFG != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(OEIMDNHDAFG);
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
      if (DKHODKHNEPB != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DKHODKHNEPB);
      }
      if (OEIMDNHDAFG != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(OEIMDNHDAFG);
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
      if (OEIMDNHDAFG != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OEIMDNHDAFG);
      }
      if (DKHODKHNEPB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DKHODKHNEPB);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OFBHGGOLOEO other) {
      if (other == null) {
        return;
      }
      if (other.OEIMDNHDAFG != 0) {
        OEIMDNHDAFG = other.OEIMDNHDAFG;
      }
      if (other.DKHODKHNEPB != 0) {
        DKHODKHNEPB = other.DKHODKHNEPB;
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
            DKHODKHNEPB = input.ReadUInt32();
            break;
          }
          case 104: {
            OEIMDNHDAFG = input.ReadUInt32();
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
            DKHODKHNEPB = input.ReadUInt32();
            break;
          }
          case 104: {
            OEIMDNHDAFG = input.ReadUInt32();
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
