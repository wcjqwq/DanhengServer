// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FMMFFCLCNJF.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from FMMFFCLCNJF.proto</summary>
  public static partial class FMMFFCLCNJFReflection {

    #region Descriptor
    /// <summary>File descriptor for FMMFFCLCNJF.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FMMFFCLCNJFReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFGTU1GRkNMQ05KRi5wcm90bxoRSE5ES0lQSkdBRUkucHJvdG8aEUdESURI",
            "SU5DQ0RGLnByb3RvIlMKC0ZNTUZGQ0xDTkpGEiEKC0xIRE1LRE9OQURMGAMg",
            "ASgLMgwuSE5ES0lQSkdBRUkSIQoLR05BSkpHRUJGT0gYCiABKAsyDC5HRElE",
            "SElOQ0NERkIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.HNDKIPJGAEIReflection.Descriptor, global::EggLink.DanhengServer.Proto.GDIDHINCCDFReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.FMMFFCLCNJF), global::EggLink.DanhengServer.Proto.FMMFFCLCNJF.Parser, new[]{ "LHDMKDONADL", "GNAJJGEBFOH" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FMMFFCLCNJF : pb::IMessage<FMMFFCLCNJF>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FMMFFCLCNJF> _parser = new pb::MessageParser<FMMFFCLCNJF>(() => new FMMFFCLCNJF());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FMMFFCLCNJF> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.FMMFFCLCNJFReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FMMFFCLCNJF() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FMMFFCLCNJF(FMMFFCLCNJF other) : this() {
      lHDMKDONADL_ = other.lHDMKDONADL_ != null ? other.lHDMKDONADL_.Clone() : null;
      gNAJJGEBFOH_ = other.gNAJJGEBFOH_ != null ? other.gNAJJGEBFOH_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FMMFFCLCNJF Clone() {
      return new FMMFFCLCNJF(this);
    }

    /// <summary>Field number for the "LHDMKDONADL" field.</summary>
    public const int LHDMKDONADLFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.HNDKIPJGAEI lHDMKDONADL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HNDKIPJGAEI LHDMKDONADL {
      get { return lHDMKDONADL_; }
      set {
        lHDMKDONADL_ = value;
      }
    }

    /// <summary>Field number for the "GNAJJGEBFOH" field.</summary>
    public const int GNAJJGEBFOHFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.GDIDHINCCDF gNAJJGEBFOH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.GDIDHINCCDF GNAJJGEBFOH {
      get { return gNAJJGEBFOH_; }
      set {
        gNAJJGEBFOH_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FMMFFCLCNJF);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FMMFFCLCNJF other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(LHDMKDONADL, other.LHDMKDONADL)) return false;
      if (!object.Equals(GNAJJGEBFOH, other.GNAJJGEBFOH)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (lHDMKDONADL_ != null) hash ^= LHDMKDONADL.GetHashCode();
      if (gNAJJGEBFOH_ != null) hash ^= GNAJJGEBFOH.GetHashCode();
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
      if (lHDMKDONADL_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(LHDMKDONADL);
      }
      if (gNAJJGEBFOH_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(GNAJJGEBFOH);
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
      if (lHDMKDONADL_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(LHDMKDONADL);
      }
      if (gNAJJGEBFOH_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(GNAJJGEBFOH);
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
      if (lHDMKDONADL_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LHDMKDONADL);
      }
      if (gNAJJGEBFOH_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GNAJJGEBFOH);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FMMFFCLCNJF other) {
      if (other == null) {
        return;
      }
      if (other.lHDMKDONADL_ != null) {
        if (lHDMKDONADL_ == null) {
          LHDMKDONADL = new global::EggLink.DanhengServer.Proto.HNDKIPJGAEI();
        }
        LHDMKDONADL.MergeFrom(other.LHDMKDONADL);
      }
      if (other.gNAJJGEBFOH_ != null) {
        if (gNAJJGEBFOH_ == null) {
          GNAJJGEBFOH = new global::EggLink.DanhengServer.Proto.GDIDHINCCDF();
        }
        GNAJJGEBFOH.MergeFrom(other.GNAJJGEBFOH);
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
          case 26: {
            if (lHDMKDONADL_ == null) {
              LHDMKDONADL = new global::EggLink.DanhengServer.Proto.HNDKIPJGAEI();
            }
            input.ReadMessage(LHDMKDONADL);
            break;
          }
          case 82: {
            if (gNAJJGEBFOH_ == null) {
              GNAJJGEBFOH = new global::EggLink.DanhengServer.Proto.GDIDHINCCDF();
            }
            input.ReadMessage(GNAJJGEBFOH);
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
          case 26: {
            if (lHDMKDONADL_ == null) {
              LHDMKDONADL = new global::EggLink.DanhengServer.Proto.HNDKIPJGAEI();
            }
            input.ReadMessage(LHDMKDONADL);
            break;
          }
          case 82: {
            if (gNAJJGEBFOH_ == null) {
              GNAJJGEBFOH = new global::EggLink.DanhengServer.Proto.GDIDHINCCDF();
            }
            input.ReadMessage(GNAJJGEBFOH);
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
