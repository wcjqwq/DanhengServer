// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HBAIHAJBONO.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from HBAIHAJBONO.proto</summary>
  public static partial class HBAIHAJBONOReflection {

    #region Descriptor
    /// <summary>File descriptor for HBAIHAJBONO.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HBAIHAJBONOReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFIQkFJSEFKQk9OTy5wcm90byKHAQoLSEJBSUhBSkJPTk8SEwoLS0tCR0hI",
            "RUVMR0IYBCABKA0SEwoLR09ER05BS0dEQVAYASABKA0SEQoJaXRlbV9saXN0",
            "GAggAygNEhEKCXVuaXF1ZV9pZBgKIAEoDRITCgtLSExBSkFPQUpJRhgLIAEo",
            "CBITCgtJSENFREdNUEdCRhgFIAMoDUIeqgIbRWdnTGluay5EYW5oZW5nU2Vy",
            "dmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.HBAIHAJBONO), global::EggLink.DanhengServer.Proto.HBAIHAJBONO.Parser, new[]{ "KKBGHHEELGB", "GODGNAKGDAP", "ItemList", "UniqueId", "KHLAJAOAJIF", "IHCEDGMPGBF" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class HBAIHAJBONO : pb::IMessage<HBAIHAJBONO>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HBAIHAJBONO> _parser = new pb::MessageParser<HBAIHAJBONO>(() => new HBAIHAJBONO());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HBAIHAJBONO> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.HBAIHAJBONOReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HBAIHAJBONO() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HBAIHAJBONO(HBAIHAJBONO other) : this() {
      kKBGHHEELGB_ = other.kKBGHHEELGB_;
      gODGNAKGDAP_ = other.gODGNAKGDAP_;
      itemList_ = other.itemList_.Clone();
      uniqueId_ = other.uniqueId_;
      kHLAJAOAJIF_ = other.kHLAJAOAJIF_;
      iHCEDGMPGBF_ = other.iHCEDGMPGBF_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HBAIHAJBONO Clone() {
      return new HBAIHAJBONO(this);
    }

    /// <summary>Field number for the "KKBGHHEELGB" field.</summary>
    public const int KKBGHHEELGBFieldNumber = 4;
    private uint kKBGHHEELGB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KKBGHHEELGB {
      get { return kKBGHHEELGB_; }
      set {
        kKBGHHEELGB_ = value;
      }
    }

    /// <summary>Field number for the "GODGNAKGDAP" field.</summary>
    public const int GODGNAKGDAPFieldNumber = 1;
    private uint gODGNAKGDAP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GODGNAKGDAP {
      get { return gODGNAKGDAP_; }
      set {
        gODGNAKGDAP_ = value;
      }
    }

    /// <summary>Field number for the "item_list" field.</summary>
    public const int ItemListFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_itemList_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> itemList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ItemList {
      get { return itemList_; }
    }

    /// <summary>Field number for the "unique_id" field.</summary>
    public const int UniqueIdFieldNumber = 10;
    private uint uniqueId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UniqueId {
      get { return uniqueId_; }
      set {
        uniqueId_ = value;
      }
    }

    /// <summary>Field number for the "KHLAJAOAJIF" field.</summary>
    public const int KHLAJAOAJIFFieldNumber = 11;
    private bool kHLAJAOAJIF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool KHLAJAOAJIF {
      get { return kHLAJAOAJIF_; }
      set {
        kHLAJAOAJIF_ = value;
      }
    }

    /// <summary>Field number for the "IHCEDGMPGBF" field.</summary>
    public const int IHCEDGMPGBFFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_iHCEDGMPGBF_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> iHCEDGMPGBF_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> IHCEDGMPGBF {
      get { return iHCEDGMPGBF_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HBAIHAJBONO);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HBAIHAJBONO other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (KKBGHHEELGB != other.KKBGHHEELGB) return false;
      if (GODGNAKGDAP != other.GODGNAKGDAP) return false;
      if(!itemList_.Equals(other.itemList_)) return false;
      if (UniqueId != other.UniqueId) return false;
      if (KHLAJAOAJIF != other.KHLAJAOAJIF) return false;
      if(!iHCEDGMPGBF_.Equals(other.iHCEDGMPGBF_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (KKBGHHEELGB != 0) hash ^= KKBGHHEELGB.GetHashCode();
      if (GODGNAKGDAP != 0) hash ^= GODGNAKGDAP.GetHashCode();
      hash ^= itemList_.GetHashCode();
      if (UniqueId != 0) hash ^= UniqueId.GetHashCode();
      if (KHLAJAOAJIF != false) hash ^= KHLAJAOAJIF.GetHashCode();
      hash ^= iHCEDGMPGBF_.GetHashCode();
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
      if (GODGNAKGDAP != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GODGNAKGDAP);
      }
      if (KKBGHHEELGB != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(KKBGHHEELGB);
      }
      iHCEDGMPGBF_.WriteTo(output, _repeated_iHCEDGMPGBF_codec);
      itemList_.WriteTo(output, _repeated_itemList_codec);
      if (UniqueId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(UniqueId);
      }
      if (KHLAJAOAJIF != false) {
        output.WriteRawTag(88);
        output.WriteBool(KHLAJAOAJIF);
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
      if (GODGNAKGDAP != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GODGNAKGDAP);
      }
      if (KKBGHHEELGB != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(KKBGHHEELGB);
      }
      iHCEDGMPGBF_.WriteTo(ref output, _repeated_iHCEDGMPGBF_codec);
      itemList_.WriteTo(ref output, _repeated_itemList_codec);
      if (UniqueId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(UniqueId);
      }
      if (KHLAJAOAJIF != false) {
        output.WriteRawTag(88);
        output.WriteBool(KHLAJAOAJIF);
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
      if (KKBGHHEELGB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KKBGHHEELGB);
      }
      if (GODGNAKGDAP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GODGNAKGDAP);
      }
      size += itemList_.CalculateSize(_repeated_itemList_codec);
      if (UniqueId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UniqueId);
      }
      if (KHLAJAOAJIF != false) {
        size += 1 + 1;
      }
      size += iHCEDGMPGBF_.CalculateSize(_repeated_iHCEDGMPGBF_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HBAIHAJBONO other) {
      if (other == null) {
        return;
      }
      if (other.KKBGHHEELGB != 0) {
        KKBGHHEELGB = other.KKBGHHEELGB;
      }
      if (other.GODGNAKGDAP != 0) {
        GODGNAKGDAP = other.GODGNAKGDAP;
      }
      itemList_.Add(other.itemList_);
      if (other.UniqueId != 0) {
        UniqueId = other.UniqueId;
      }
      if (other.KHLAJAOAJIF != false) {
        KHLAJAOAJIF = other.KHLAJAOAJIF;
      }
      iHCEDGMPGBF_.Add(other.iHCEDGMPGBF_);
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
            GODGNAKGDAP = input.ReadUInt32();
            break;
          }
          case 32: {
            KKBGHHEELGB = input.ReadUInt32();
            break;
          }
          case 42:
          case 40: {
            iHCEDGMPGBF_.AddEntriesFrom(input, _repeated_iHCEDGMPGBF_codec);
            break;
          }
          case 66:
          case 64: {
            itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
            break;
          }
          case 80: {
            UniqueId = input.ReadUInt32();
            break;
          }
          case 88: {
            KHLAJAOAJIF = input.ReadBool();
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
            GODGNAKGDAP = input.ReadUInt32();
            break;
          }
          case 32: {
            KKBGHHEELGB = input.ReadUInt32();
            break;
          }
          case 42:
          case 40: {
            iHCEDGMPGBF_.AddEntriesFrom(ref input, _repeated_iHCEDGMPGBF_codec);
            break;
          }
          case 66:
          case 64: {
            itemList_.AddEntriesFrom(ref input, _repeated_itemList_codec);
            break;
          }
          case 80: {
            UniqueId = input.ReadUInt32();
            break;
          }
          case 88: {
            KHLAJAOAJIF = input.ReadBool();
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
