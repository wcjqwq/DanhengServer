// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MonopolyEventLoadUpdateScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from MonopolyEventLoadUpdateScNotify.proto</summary>
  public static partial class MonopolyEventLoadUpdateScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for MonopolyEventLoadUpdateScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MonopolyEventLoadUpdateScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVNb25vcG9seUV2ZW50TG9hZFVwZGF0ZVNjTm90aWZ5LnByb3RvGhFHREpC",
            "QU5JRkhEQS5wcm90byJnCh9Nb25vcG9seUV2ZW50TG9hZFVwZGF0ZVNjTm90",
            "aWZ5EiEKC0hOQlBMSkxFT05NGAogAygLMgwuR0RKQkFOSUZIREESIQoLSkRE",
            "TURQSE1MT0cYBSADKAsyDC5HREpCQU5JRkhEQUIeqgIbRWdnTGluay5EYW5o",
            "ZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.GDJBANIFHDAReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.MonopolyEventLoadUpdateScNotify), global::EggLink.DanhengServer.Proto.MonopolyEventLoadUpdateScNotify.Parser, new[]{ "HNBPLJLEONM", "JDDMDPHMLOG" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MonopolyEventLoadUpdateScNotify : pb::IMessage<MonopolyEventLoadUpdateScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MonopolyEventLoadUpdateScNotify> _parser = new pb::MessageParser<MonopolyEventLoadUpdateScNotify>(() => new MonopolyEventLoadUpdateScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MonopolyEventLoadUpdateScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.MonopolyEventLoadUpdateScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyEventLoadUpdateScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyEventLoadUpdateScNotify(MonopolyEventLoadUpdateScNotify other) : this() {
      hNBPLJLEONM_ = other.hNBPLJLEONM_.Clone();
      jDDMDPHMLOG_ = other.jDDMDPHMLOG_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonopolyEventLoadUpdateScNotify Clone() {
      return new MonopolyEventLoadUpdateScNotify(this);
    }

    /// <summary>Field number for the "HNBPLJLEONM" field.</summary>
    public const int HNBPLJLEONMFieldNumber = 10;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.GDJBANIFHDA> _repeated_hNBPLJLEONM_codec
        = pb::FieldCodec.ForMessage(82, global::EggLink.DanhengServer.Proto.GDJBANIFHDA.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GDJBANIFHDA> hNBPLJLEONM_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GDJBANIFHDA>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GDJBANIFHDA> HNBPLJLEONM {
      get { return hNBPLJLEONM_; }
    }

    /// <summary>Field number for the "JDDMDPHMLOG" field.</summary>
    public const int JDDMDPHMLOGFieldNumber = 5;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.GDJBANIFHDA> _repeated_jDDMDPHMLOG_codec
        = pb::FieldCodec.ForMessage(42, global::EggLink.DanhengServer.Proto.GDJBANIFHDA.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GDJBANIFHDA> jDDMDPHMLOG_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GDJBANIFHDA>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.GDJBANIFHDA> JDDMDPHMLOG {
      get { return jDDMDPHMLOG_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MonopolyEventLoadUpdateScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MonopolyEventLoadUpdateScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!hNBPLJLEONM_.Equals(other.hNBPLJLEONM_)) return false;
      if(!jDDMDPHMLOG_.Equals(other.jDDMDPHMLOG_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= hNBPLJLEONM_.GetHashCode();
      hash ^= jDDMDPHMLOG_.GetHashCode();
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
      jDDMDPHMLOG_.WriteTo(output, _repeated_jDDMDPHMLOG_codec);
      hNBPLJLEONM_.WriteTo(output, _repeated_hNBPLJLEONM_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      jDDMDPHMLOG_.WriteTo(ref output, _repeated_jDDMDPHMLOG_codec);
      hNBPLJLEONM_.WriteTo(ref output, _repeated_hNBPLJLEONM_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += hNBPLJLEONM_.CalculateSize(_repeated_hNBPLJLEONM_codec);
      size += jDDMDPHMLOG_.CalculateSize(_repeated_jDDMDPHMLOG_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MonopolyEventLoadUpdateScNotify other) {
      if (other == null) {
        return;
      }
      hNBPLJLEONM_.Add(other.hNBPLJLEONM_);
      jDDMDPHMLOG_.Add(other.jDDMDPHMLOG_);
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
          case 42: {
            jDDMDPHMLOG_.AddEntriesFrom(input, _repeated_jDDMDPHMLOG_codec);
            break;
          }
          case 82: {
            hNBPLJLEONM_.AddEntriesFrom(input, _repeated_hNBPLJLEONM_codec);
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
          case 42: {
            jDDMDPHMLOG_.AddEntriesFrom(ref input, _repeated_jDDMDPHMLOG_codec);
            break;
          }
          case 82: {
            hNBPLJLEONM_.AddEntriesFrom(ref input, _repeated_hNBPLJLEONM_codec);
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
