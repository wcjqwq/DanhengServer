// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetAetherDivideInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetAetherDivideInfoScRsp.proto</summary>
  public static partial class GetAetherDivideInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetAetherDivideInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetAetherDivideInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5HZXRBZXRoZXJEaXZpZGVJbmZvU2NSc3AucHJvdG8aHEFldGhlckRpdmlk",
            "ZUxpbmV1cEluZm8ucHJvdG8aFUFldGhlclNraWxsSW5mby5wcm90bxocQWV0",
            "aGVyRGl2aWRlU3Bpcml0SW5mby5wcm90byKpAgoYR2V0QWV0aGVyRGl2aWRl",
            "SW5mb1NjUnNwEhMKC09IRENFRUJBSEJGGAIgASgNEiwKC0xMT0tBSEhLSU5F",
            "GAYgAygLMhcuQWV0aGVyRGl2aWRlU3Bpcml0SW5mbxIlCgtBTEJFRE5JQUhL",
            "ThgLIAMoCzIQLkFldGhlclNraWxsSW5mbxIPCgdyZXRjb2RlGAQgASgNEiUK",
            "HWluZmluaXRlX2NoYWxsZW5nZV9taXNzaW9uX2lkGAEgASgNEhMKC0hLSUdN",
            "R05DSU9MGAMgASgNEhMKC0JLSUxFTFBFTEJIGAUgASgNEhMKC0hDSktEUE1M",
            "RFBBGA8gASgNEiwKC2xpbmV1cF9saXN0GAggAygLMhcuQWV0aGVyRGl2aWRl",
            "TGluZXVwSW5mb0IeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.AetherDivideLineupInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.AetherSkillInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetAetherDivideInfoScRsp), global::EggLink.DanhengServer.Proto.GetAetherDivideInfoScRsp.Parser, new[]{ "OHDCEEBAHBF", "LLOKAHHKINE", "ALBEDNIAHKN", "Retcode", "InfiniteChallengeMissionId", "HKIGMGNCIOL", "BKILELPELBH", "HCJKDPMLDPA", "LineupList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetAetherDivideInfoScRsp : pb::IMessage<GetAetherDivideInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetAetherDivideInfoScRsp> _parser = new pb::MessageParser<GetAetherDivideInfoScRsp>(() => new GetAetherDivideInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetAetherDivideInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetAetherDivideInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAetherDivideInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAetherDivideInfoScRsp(GetAetherDivideInfoScRsp other) : this() {
      oHDCEEBAHBF_ = other.oHDCEEBAHBF_;
      lLOKAHHKINE_ = other.lLOKAHHKINE_.Clone();
      aLBEDNIAHKN_ = other.aLBEDNIAHKN_.Clone();
      retcode_ = other.retcode_;
      infiniteChallengeMissionId_ = other.infiniteChallengeMissionId_;
      hKIGMGNCIOL_ = other.hKIGMGNCIOL_;
      bKILELPELBH_ = other.bKILELPELBH_;
      hCJKDPMLDPA_ = other.hCJKDPMLDPA_;
      lineupList_ = other.lineupList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAetherDivideInfoScRsp Clone() {
      return new GetAetherDivideInfoScRsp(this);
    }

    /// <summary>Field number for the "OHDCEEBAHBF" field.</summary>
    public const int OHDCEEBAHBFFieldNumber = 2;
    private uint oHDCEEBAHBF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OHDCEEBAHBF {
      get { return oHDCEEBAHBF_; }
      set {
        oHDCEEBAHBF_ = value;
      }
    }

    /// <summary>Field number for the "LLOKAHHKINE" field.</summary>
    public const int LLOKAHHKINEFieldNumber = 6;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo> _repeated_lLOKAHHKINE_codec
        = pb::FieldCodec.ForMessage(50, global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo> lLOKAHHKINE_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AetherDivideSpiritInfo> LLOKAHHKINE {
      get { return lLOKAHHKINE_; }
    }

    /// <summary>Field number for the "ALBEDNIAHKN" field.</summary>
    public const int ALBEDNIAHKNFieldNumber = 11;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.AetherSkillInfo> _repeated_aLBEDNIAHKN_codec
        = pb::FieldCodec.ForMessage(90, global::EggLink.DanhengServer.Proto.AetherSkillInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AetherSkillInfo> aLBEDNIAHKN_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AetherSkillInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AetherSkillInfo> ALBEDNIAHKN {
      get { return aLBEDNIAHKN_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 4;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "infinite_challenge_mission_id" field.</summary>
    public const int InfiniteChallengeMissionIdFieldNumber = 1;
    private uint infiniteChallengeMissionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint InfiniteChallengeMissionId {
      get { return infiniteChallengeMissionId_; }
      set {
        infiniteChallengeMissionId_ = value;
      }
    }

    /// <summary>Field number for the "HKIGMGNCIOL" field.</summary>
    public const int HKIGMGNCIOLFieldNumber = 3;
    private uint hKIGMGNCIOL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HKIGMGNCIOL {
      get { return hKIGMGNCIOL_; }
      set {
        hKIGMGNCIOL_ = value;
      }
    }

    /// <summary>Field number for the "BKILELPELBH" field.</summary>
    public const int BKILELPELBHFieldNumber = 5;
    private uint bKILELPELBH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BKILELPELBH {
      get { return bKILELPELBH_; }
      set {
        bKILELPELBH_ = value;
      }
    }

    /// <summary>Field number for the "HCJKDPMLDPA" field.</summary>
    public const int HCJKDPMLDPAFieldNumber = 15;
    private uint hCJKDPMLDPA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HCJKDPMLDPA {
      get { return hCJKDPMLDPA_; }
      set {
        hCJKDPMLDPA_ = value;
      }
    }

    /// <summary>Field number for the "lineup_list" field.</summary>
    public const int LineupListFieldNumber = 8;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.AetherDivideLineupInfo> _repeated_lineupList_codec
        = pb::FieldCodec.ForMessage(66, global::EggLink.DanhengServer.Proto.AetherDivideLineupInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AetherDivideLineupInfo> lineupList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AetherDivideLineupInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.AetherDivideLineupInfo> LineupList {
      get { return lineupList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetAetherDivideInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetAetherDivideInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OHDCEEBAHBF != other.OHDCEEBAHBF) return false;
      if(!lLOKAHHKINE_.Equals(other.lLOKAHHKINE_)) return false;
      if(!aLBEDNIAHKN_.Equals(other.aLBEDNIAHKN_)) return false;
      if (Retcode != other.Retcode) return false;
      if (InfiniteChallengeMissionId != other.InfiniteChallengeMissionId) return false;
      if (HKIGMGNCIOL != other.HKIGMGNCIOL) return false;
      if (BKILELPELBH != other.BKILELPELBH) return false;
      if (HCJKDPMLDPA != other.HCJKDPMLDPA) return false;
      if(!lineupList_.Equals(other.lineupList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OHDCEEBAHBF != 0) hash ^= OHDCEEBAHBF.GetHashCode();
      hash ^= lLOKAHHKINE_.GetHashCode();
      hash ^= aLBEDNIAHKN_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (InfiniteChallengeMissionId != 0) hash ^= InfiniteChallengeMissionId.GetHashCode();
      if (HKIGMGNCIOL != 0) hash ^= HKIGMGNCIOL.GetHashCode();
      if (BKILELPELBH != 0) hash ^= BKILELPELBH.GetHashCode();
      if (HCJKDPMLDPA != 0) hash ^= HCJKDPMLDPA.GetHashCode();
      hash ^= lineupList_.GetHashCode();
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
      if (InfiniteChallengeMissionId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(InfiniteChallengeMissionId);
      }
      if (OHDCEEBAHBF != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(OHDCEEBAHBF);
      }
      if (HKIGMGNCIOL != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(HKIGMGNCIOL);
      }
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      if (BKILELPELBH != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(BKILELPELBH);
      }
      lLOKAHHKINE_.WriteTo(output, _repeated_lLOKAHHKINE_codec);
      lineupList_.WriteTo(output, _repeated_lineupList_codec);
      aLBEDNIAHKN_.WriteTo(output, _repeated_aLBEDNIAHKN_codec);
      if (HCJKDPMLDPA != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(HCJKDPMLDPA);
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
      if (InfiniteChallengeMissionId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(InfiniteChallengeMissionId);
      }
      if (OHDCEEBAHBF != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(OHDCEEBAHBF);
      }
      if (HKIGMGNCIOL != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(HKIGMGNCIOL);
      }
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Retcode);
      }
      if (BKILELPELBH != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(BKILELPELBH);
      }
      lLOKAHHKINE_.WriteTo(ref output, _repeated_lLOKAHHKINE_codec);
      lineupList_.WriteTo(ref output, _repeated_lineupList_codec);
      aLBEDNIAHKN_.WriteTo(ref output, _repeated_aLBEDNIAHKN_codec);
      if (HCJKDPMLDPA != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(HCJKDPMLDPA);
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
      if (OHDCEEBAHBF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OHDCEEBAHBF);
      }
      size += lLOKAHHKINE_.CalculateSize(_repeated_lLOKAHHKINE_codec);
      size += aLBEDNIAHKN_.CalculateSize(_repeated_aLBEDNIAHKN_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (InfiniteChallengeMissionId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(InfiniteChallengeMissionId);
      }
      if (HKIGMGNCIOL != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HKIGMGNCIOL);
      }
      if (BKILELPELBH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BKILELPELBH);
      }
      if (HCJKDPMLDPA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HCJKDPMLDPA);
      }
      size += lineupList_.CalculateSize(_repeated_lineupList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetAetherDivideInfoScRsp other) {
      if (other == null) {
        return;
      }
      if (other.OHDCEEBAHBF != 0) {
        OHDCEEBAHBF = other.OHDCEEBAHBF;
      }
      lLOKAHHKINE_.Add(other.lLOKAHHKINE_);
      aLBEDNIAHKN_.Add(other.aLBEDNIAHKN_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.InfiniteChallengeMissionId != 0) {
        InfiniteChallengeMissionId = other.InfiniteChallengeMissionId;
      }
      if (other.HKIGMGNCIOL != 0) {
        HKIGMGNCIOL = other.HKIGMGNCIOL;
      }
      if (other.BKILELPELBH != 0) {
        BKILELPELBH = other.BKILELPELBH;
      }
      if (other.HCJKDPMLDPA != 0) {
        HCJKDPMLDPA = other.HCJKDPMLDPA;
      }
      lineupList_.Add(other.lineupList_);
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
            InfiniteChallengeMissionId = input.ReadUInt32();
            break;
          }
          case 16: {
            OHDCEEBAHBF = input.ReadUInt32();
            break;
          }
          case 24: {
            HKIGMGNCIOL = input.ReadUInt32();
            break;
          }
          case 32: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 40: {
            BKILELPELBH = input.ReadUInt32();
            break;
          }
          case 50: {
            lLOKAHHKINE_.AddEntriesFrom(input, _repeated_lLOKAHHKINE_codec);
            break;
          }
          case 66: {
            lineupList_.AddEntriesFrom(input, _repeated_lineupList_codec);
            break;
          }
          case 90: {
            aLBEDNIAHKN_.AddEntriesFrom(input, _repeated_aLBEDNIAHKN_codec);
            break;
          }
          case 120: {
            HCJKDPMLDPA = input.ReadUInt32();
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
            InfiniteChallengeMissionId = input.ReadUInt32();
            break;
          }
          case 16: {
            OHDCEEBAHBF = input.ReadUInt32();
            break;
          }
          case 24: {
            HKIGMGNCIOL = input.ReadUInt32();
            break;
          }
          case 32: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 40: {
            BKILELPELBH = input.ReadUInt32();
            break;
          }
          case 50: {
            lLOKAHHKINE_.AddEntriesFrom(ref input, _repeated_lLOKAHHKINE_codec);
            break;
          }
          case 66: {
            lineupList_.AddEntriesFrom(ref input, _repeated_lineupList_codec);
            break;
          }
          case 90: {
            aLBEDNIAHKN_.AddEntriesFrom(ref input, _repeated_aLBEDNIAHKN_codec);
            break;
          }
          case 120: {
            HCJKDPMLDPA = input.ReadUInt32();
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
