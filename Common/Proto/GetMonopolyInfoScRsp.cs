// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetMonopolyInfoScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetMonopolyInfoScRsp.proto</summary>
  public static partial class GetMonopolyInfoScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetMonopolyInfoScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetMonopolyInfoScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpHZXRNb25vcG9seUluZm9TY1JzcC5wcm90bxoRS0NIQUFPRE9ESk8ucHJv",
            "dG8aEUdCSVBMTkFGTElHLnByb3RvGhFOTlBBUEZNSkNESC5wcm90bxoRRk5G",
            "Q01GSEVBQlAucHJvdG8aEVBNT0hHQkpBTlBGLnByb3RvGhFIS09ESU1LTk1I",
            "Qy5wcm90bxoRREVCUEdDR0JJRUUucHJvdG8aFk1vbm9wb2x5QnVmZkluZm8u",
            "cHJvdG8aFU1vbm9wb2x5TWFwSW5mby5wcm90bxoXTW9ub3BvbHlFdmVudElu",
            "Zm8ucHJvdG8aFE1vbm9wb2x5UmVwb3J0LnByb3RvIsMDChRHZXRNb25vcG9s",
            "eUluZm9TY1JzcBIfCgZyZXBvcnQYByABKAsyDy5Nb25vcG9seVJlcG9ydBIT",
            "CgtLQkNPQVBNQkpETBgDIAMoDRIhCgtKS0hOT0hHT01LSxgKIAEoCzIMLkdC",
            "SVBMTkFGTElHEiEKC01HQUhNSE9CRExCGAUgASgLMgwuUE1PSEdCSkFOUEYS",
            "KgoPcm9ndWVfYnVmZl9pbmZvGAQgASgLMhEuTW9ub3BvbHlCdWZmSW5mbxIf",
            "CgNzdHQYDiABKAsyEi5Nb25vcG9seUV2ZW50SW5mbxIhCgtPREVPQUNNQkVB",
            "SxgMIAEoCzIMLktDSEFBT0RPREpPEiEKC0JEQ0xHS0pCQkpNGAggASgLMgwu",
            "REVCUEdDR0JJRUUSIQoLQkJOSEhHRkNQRUUYDSABKAsyDC5OTlBBUEZNSkNE",
            "SBIhCgtJREJCQUdJTUlOTRgGIAEoCzIMLkZORkNNRkhFQUJQEiIKCG1hcF9p",
            "bmZvGAEgASgLMhAuTW9ub3BvbHlNYXBJbmZvEg8KB3JldGNvZGUYCyABKA0S",
            "IQoLT1BDQUdDT0ZJREQYAiABKAsyDC5IS09ESU1LTk1IQ0IeqgIbRWdnTGlu",
            "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.KCHAAODODJOReflection.Descriptor, global::EggLink.DanhengServer.Proto.GBIPLNAFLIGReflection.Descriptor, global::EggLink.DanhengServer.Proto.NNPAPFMJCDHReflection.Descriptor, global::EggLink.DanhengServer.Proto.FNFCMFHEABPReflection.Descriptor, global::EggLink.DanhengServer.Proto.PMOHGBJANPFReflection.Descriptor, global::EggLink.DanhengServer.Proto.HKODIMKNMHCReflection.Descriptor, global::EggLink.DanhengServer.Proto.DEBPGCGBIEEReflection.Descriptor, global::EggLink.DanhengServer.Proto.MonopolyBuffInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.MonopolyMapInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.MonopolyEventInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.MonopolyReportReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetMonopolyInfoScRsp), global::EggLink.DanhengServer.Proto.GetMonopolyInfoScRsp.Parser, new[]{ "Report", "KBCOAPMBJDL", "JKHNOHGOMKK", "MGAHMHOBDLB", "RogueBuffInfo", "Stt", "ODEOACMBEAK", "BDCLGKJBBJM", "BBNHHGFCPEE", "IDBBAGIMINM", "MapInfo", "Retcode", "OPCAGCOFIDD" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetMonopolyInfoScRsp : pb::IMessage<GetMonopolyInfoScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetMonopolyInfoScRsp> _parser = new pb::MessageParser<GetMonopolyInfoScRsp>(() => new GetMonopolyInfoScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetMonopolyInfoScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetMonopolyInfoScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMonopolyInfoScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMonopolyInfoScRsp(GetMonopolyInfoScRsp other) : this() {
      report_ = other.report_ != null ? other.report_.Clone() : null;
      kBCOAPMBJDL_ = other.kBCOAPMBJDL_.Clone();
      jKHNOHGOMKK_ = other.jKHNOHGOMKK_ != null ? other.jKHNOHGOMKK_.Clone() : null;
      mGAHMHOBDLB_ = other.mGAHMHOBDLB_ != null ? other.mGAHMHOBDLB_.Clone() : null;
      rogueBuffInfo_ = other.rogueBuffInfo_ != null ? other.rogueBuffInfo_.Clone() : null;
      stt_ = other.stt_ != null ? other.stt_.Clone() : null;
      oDEOACMBEAK_ = other.oDEOACMBEAK_ != null ? other.oDEOACMBEAK_.Clone() : null;
      bDCLGKJBBJM_ = other.bDCLGKJBBJM_ != null ? other.bDCLGKJBBJM_.Clone() : null;
      bBNHHGFCPEE_ = other.bBNHHGFCPEE_ != null ? other.bBNHHGFCPEE_.Clone() : null;
      iDBBAGIMINM_ = other.iDBBAGIMINM_ != null ? other.iDBBAGIMINM_.Clone() : null;
      mapInfo_ = other.mapInfo_ != null ? other.mapInfo_.Clone() : null;
      retcode_ = other.retcode_;
      oPCAGCOFIDD_ = other.oPCAGCOFIDD_ != null ? other.oPCAGCOFIDD_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetMonopolyInfoScRsp Clone() {
      return new GetMonopolyInfoScRsp(this);
    }

    /// <summary>Field number for the "report" field.</summary>
    public const int ReportFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.MonopolyReport report_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MonopolyReport Report {
      get { return report_; }
      set {
        report_ = value;
      }
    }

    /// <summary>Field number for the "KBCOAPMBJDL" field.</summary>
    public const int KBCOAPMBJDLFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_kBCOAPMBJDL_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> kBCOAPMBJDL_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> KBCOAPMBJDL {
      get { return kBCOAPMBJDL_; }
    }

    /// <summary>Field number for the "JKHNOHGOMKK" field.</summary>
    public const int JKHNOHGOMKKFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.GBIPLNAFLIG jKHNOHGOMKK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.GBIPLNAFLIG JKHNOHGOMKK {
      get { return jKHNOHGOMKK_; }
      set {
        jKHNOHGOMKK_ = value;
      }
    }

    /// <summary>Field number for the "MGAHMHOBDLB" field.</summary>
    public const int MGAHMHOBDLBFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.PMOHGBJANPF mGAHMHOBDLB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PMOHGBJANPF MGAHMHOBDLB {
      get { return mGAHMHOBDLB_; }
      set {
        mGAHMHOBDLB_ = value;
      }
    }

    /// <summary>Field number for the "rogue_buff_info" field.</summary>
    public const int RogueBuffInfoFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.MonopolyBuffInfo rogueBuffInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MonopolyBuffInfo RogueBuffInfo {
      get { return rogueBuffInfo_; }
      set {
        rogueBuffInfo_ = value;
      }
    }

    /// <summary>Field number for the "stt" field.</summary>
    public const int SttFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.MonopolyEventInfo stt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MonopolyEventInfo Stt {
      get { return stt_; }
      set {
        stt_ = value;
      }
    }

    /// <summary>Field number for the "ODEOACMBEAK" field.</summary>
    public const int ODEOACMBEAKFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.KCHAAODODJO oDEOACMBEAK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.KCHAAODODJO ODEOACMBEAK {
      get { return oDEOACMBEAK_; }
      set {
        oDEOACMBEAK_ = value;
      }
    }

    /// <summary>Field number for the "BDCLGKJBBJM" field.</summary>
    public const int BDCLGKJBBJMFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.DEBPGCGBIEE bDCLGKJBBJM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.DEBPGCGBIEE BDCLGKJBBJM {
      get { return bDCLGKJBBJM_; }
      set {
        bDCLGKJBBJM_ = value;
      }
    }

    /// <summary>Field number for the "BBNHHGFCPEE" field.</summary>
    public const int BBNHHGFCPEEFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.NNPAPFMJCDH bBNHHGFCPEE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.NNPAPFMJCDH BBNHHGFCPEE {
      get { return bBNHHGFCPEE_; }
      set {
        bBNHHGFCPEE_ = value;
      }
    }

    /// <summary>Field number for the "IDBBAGIMINM" field.</summary>
    public const int IDBBAGIMINMFieldNumber = 6;
    private global::EggLink.DanhengServer.Proto.FNFCMFHEABP iDBBAGIMINM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.FNFCMFHEABP IDBBAGIMINM {
      get { return iDBBAGIMINM_; }
      set {
        iDBBAGIMINM_ = value;
      }
    }

    /// <summary>Field number for the "map_info" field.</summary>
    public const int MapInfoFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.MonopolyMapInfo mapInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MonopolyMapInfo MapInfo {
      get { return mapInfo_; }
      set {
        mapInfo_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 11;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "OPCAGCOFIDD" field.</summary>
    public const int OPCAGCOFIDDFieldNumber = 2;
    private global::EggLink.DanhengServer.Proto.HKODIMKNMHC oPCAGCOFIDD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HKODIMKNMHC OPCAGCOFIDD {
      get { return oPCAGCOFIDD_; }
      set {
        oPCAGCOFIDD_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetMonopolyInfoScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetMonopolyInfoScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Report, other.Report)) return false;
      if(!kBCOAPMBJDL_.Equals(other.kBCOAPMBJDL_)) return false;
      if (!object.Equals(JKHNOHGOMKK, other.JKHNOHGOMKK)) return false;
      if (!object.Equals(MGAHMHOBDLB, other.MGAHMHOBDLB)) return false;
      if (!object.Equals(RogueBuffInfo, other.RogueBuffInfo)) return false;
      if (!object.Equals(Stt, other.Stt)) return false;
      if (!object.Equals(ODEOACMBEAK, other.ODEOACMBEAK)) return false;
      if (!object.Equals(BDCLGKJBBJM, other.BDCLGKJBBJM)) return false;
      if (!object.Equals(BBNHHGFCPEE, other.BBNHHGFCPEE)) return false;
      if (!object.Equals(IDBBAGIMINM, other.IDBBAGIMINM)) return false;
      if (!object.Equals(MapInfo, other.MapInfo)) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(OPCAGCOFIDD, other.OPCAGCOFIDD)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (report_ != null) hash ^= Report.GetHashCode();
      hash ^= kBCOAPMBJDL_.GetHashCode();
      if (jKHNOHGOMKK_ != null) hash ^= JKHNOHGOMKK.GetHashCode();
      if (mGAHMHOBDLB_ != null) hash ^= MGAHMHOBDLB.GetHashCode();
      if (rogueBuffInfo_ != null) hash ^= RogueBuffInfo.GetHashCode();
      if (stt_ != null) hash ^= Stt.GetHashCode();
      if (oDEOACMBEAK_ != null) hash ^= ODEOACMBEAK.GetHashCode();
      if (bDCLGKJBBJM_ != null) hash ^= BDCLGKJBBJM.GetHashCode();
      if (bBNHHGFCPEE_ != null) hash ^= BBNHHGFCPEE.GetHashCode();
      if (iDBBAGIMINM_ != null) hash ^= IDBBAGIMINM.GetHashCode();
      if (mapInfo_ != null) hash ^= MapInfo.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (oPCAGCOFIDD_ != null) hash ^= OPCAGCOFIDD.GetHashCode();
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
      if (mapInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(MapInfo);
      }
      if (oPCAGCOFIDD_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(OPCAGCOFIDD);
      }
      kBCOAPMBJDL_.WriteTo(output, _repeated_kBCOAPMBJDL_codec);
      if (rogueBuffInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(RogueBuffInfo);
      }
      if (mGAHMHOBDLB_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(MGAHMHOBDLB);
      }
      if (iDBBAGIMINM_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(IDBBAGIMINM);
      }
      if (report_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Report);
      }
      if (bDCLGKJBBJM_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(BDCLGKJBBJM);
      }
      if (jKHNOHGOMKK_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(JKHNOHGOMKK);
      }
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Retcode);
      }
      if (oDEOACMBEAK_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(ODEOACMBEAK);
      }
      if (bBNHHGFCPEE_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(BBNHHGFCPEE);
      }
      if (stt_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(Stt);
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
      if (mapInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(MapInfo);
      }
      if (oPCAGCOFIDD_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(OPCAGCOFIDD);
      }
      kBCOAPMBJDL_.WriteTo(ref output, _repeated_kBCOAPMBJDL_codec);
      if (rogueBuffInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(RogueBuffInfo);
      }
      if (mGAHMHOBDLB_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(MGAHMHOBDLB);
      }
      if (iDBBAGIMINM_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(IDBBAGIMINM);
      }
      if (report_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Report);
      }
      if (bDCLGKJBBJM_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(BDCLGKJBBJM);
      }
      if (jKHNOHGOMKK_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(JKHNOHGOMKK);
      }
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Retcode);
      }
      if (oDEOACMBEAK_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(ODEOACMBEAK);
      }
      if (bBNHHGFCPEE_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(BBNHHGFCPEE);
      }
      if (stt_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(Stt);
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
      if (report_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Report);
      }
      size += kBCOAPMBJDL_.CalculateSize(_repeated_kBCOAPMBJDL_codec);
      if (jKHNOHGOMKK_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(JKHNOHGOMKK);
      }
      if (mGAHMHOBDLB_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MGAHMHOBDLB);
      }
      if (rogueBuffInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueBuffInfo);
      }
      if (stt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Stt);
      }
      if (oDEOACMBEAK_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ODEOACMBEAK);
      }
      if (bDCLGKJBBJM_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BDCLGKJBBJM);
      }
      if (bBNHHGFCPEE_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BBNHHGFCPEE);
      }
      if (iDBBAGIMINM_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(IDBBAGIMINM);
      }
      if (mapInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MapInfo);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (oPCAGCOFIDD_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OPCAGCOFIDD);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetMonopolyInfoScRsp other) {
      if (other == null) {
        return;
      }
      if (other.report_ != null) {
        if (report_ == null) {
          Report = new global::EggLink.DanhengServer.Proto.MonopolyReport();
        }
        Report.MergeFrom(other.Report);
      }
      kBCOAPMBJDL_.Add(other.kBCOAPMBJDL_);
      if (other.jKHNOHGOMKK_ != null) {
        if (jKHNOHGOMKK_ == null) {
          JKHNOHGOMKK = new global::EggLink.DanhengServer.Proto.GBIPLNAFLIG();
        }
        JKHNOHGOMKK.MergeFrom(other.JKHNOHGOMKK);
      }
      if (other.mGAHMHOBDLB_ != null) {
        if (mGAHMHOBDLB_ == null) {
          MGAHMHOBDLB = new global::EggLink.DanhengServer.Proto.PMOHGBJANPF();
        }
        MGAHMHOBDLB.MergeFrom(other.MGAHMHOBDLB);
      }
      if (other.rogueBuffInfo_ != null) {
        if (rogueBuffInfo_ == null) {
          RogueBuffInfo = new global::EggLink.DanhengServer.Proto.MonopolyBuffInfo();
        }
        RogueBuffInfo.MergeFrom(other.RogueBuffInfo);
      }
      if (other.stt_ != null) {
        if (stt_ == null) {
          Stt = new global::EggLink.DanhengServer.Proto.MonopolyEventInfo();
        }
        Stt.MergeFrom(other.Stt);
      }
      if (other.oDEOACMBEAK_ != null) {
        if (oDEOACMBEAK_ == null) {
          ODEOACMBEAK = new global::EggLink.DanhengServer.Proto.KCHAAODODJO();
        }
        ODEOACMBEAK.MergeFrom(other.ODEOACMBEAK);
      }
      if (other.bDCLGKJBBJM_ != null) {
        if (bDCLGKJBBJM_ == null) {
          BDCLGKJBBJM = new global::EggLink.DanhengServer.Proto.DEBPGCGBIEE();
        }
        BDCLGKJBBJM.MergeFrom(other.BDCLGKJBBJM);
      }
      if (other.bBNHHGFCPEE_ != null) {
        if (bBNHHGFCPEE_ == null) {
          BBNHHGFCPEE = new global::EggLink.DanhengServer.Proto.NNPAPFMJCDH();
        }
        BBNHHGFCPEE.MergeFrom(other.BBNHHGFCPEE);
      }
      if (other.iDBBAGIMINM_ != null) {
        if (iDBBAGIMINM_ == null) {
          IDBBAGIMINM = new global::EggLink.DanhengServer.Proto.FNFCMFHEABP();
        }
        IDBBAGIMINM.MergeFrom(other.IDBBAGIMINM);
      }
      if (other.mapInfo_ != null) {
        if (mapInfo_ == null) {
          MapInfo = new global::EggLink.DanhengServer.Proto.MonopolyMapInfo();
        }
        MapInfo.MergeFrom(other.MapInfo);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.oPCAGCOFIDD_ != null) {
        if (oPCAGCOFIDD_ == null) {
          OPCAGCOFIDD = new global::EggLink.DanhengServer.Proto.HKODIMKNMHC();
        }
        OPCAGCOFIDD.MergeFrom(other.OPCAGCOFIDD);
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
            if (mapInfo_ == null) {
              MapInfo = new global::EggLink.DanhengServer.Proto.MonopolyMapInfo();
            }
            input.ReadMessage(MapInfo);
            break;
          }
          case 18: {
            if (oPCAGCOFIDD_ == null) {
              OPCAGCOFIDD = new global::EggLink.DanhengServer.Proto.HKODIMKNMHC();
            }
            input.ReadMessage(OPCAGCOFIDD);
            break;
          }
          case 26:
          case 24: {
            kBCOAPMBJDL_.AddEntriesFrom(input, _repeated_kBCOAPMBJDL_codec);
            break;
          }
          case 34: {
            if (rogueBuffInfo_ == null) {
              RogueBuffInfo = new global::EggLink.DanhengServer.Proto.MonopolyBuffInfo();
            }
            input.ReadMessage(RogueBuffInfo);
            break;
          }
          case 42: {
            if (mGAHMHOBDLB_ == null) {
              MGAHMHOBDLB = new global::EggLink.DanhengServer.Proto.PMOHGBJANPF();
            }
            input.ReadMessage(MGAHMHOBDLB);
            break;
          }
          case 50: {
            if (iDBBAGIMINM_ == null) {
              IDBBAGIMINM = new global::EggLink.DanhengServer.Proto.FNFCMFHEABP();
            }
            input.ReadMessage(IDBBAGIMINM);
            break;
          }
          case 58: {
            if (report_ == null) {
              Report = new global::EggLink.DanhengServer.Proto.MonopolyReport();
            }
            input.ReadMessage(Report);
            break;
          }
          case 66: {
            if (bDCLGKJBBJM_ == null) {
              BDCLGKJBBJM = new global::EggLink.DanhengServer.Proto.DEBPGCGBIEE();
            }
            input.ReadMessage(BDCLGKJBBJM);
            break;
          }
          case 82: {
            if (jKHNOHGOMKK_ == null) {
              JKHNOHGOMKK = new global::EggLink.DanhengServer.Proto.GBIPLNAFLIG();
            }
            input.ReadMessage(JKHNOHGOMKK);
            break;
          }
          case 88: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 98: {
            if (oDEOACMBEAK_ == null) {
              ODEOACMBEAK = new global::EggLink.DanhengServer.Proto.KCHAAODODJO();
            }
            input.ReadMessage(ODEOACMBEAK);
            break;
          }
          case 106: {
            if (bBNHHGFCPEE_ == null) {
              BBNHHGFCPEE = new global::EggLink.DanhengServer.Proto.NNPAPFMJCDH();
            }
            input.ReadMessage(BBNHHGFCPEE);
            break;
          }
          case 114: {
            if (stt_ == null) {
              Stt = new global::EggLink.DanhengServer.Proto.MonopolyEventInfo();
            }
            input.ReadMessage(Stt);
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
            if (mapInfo_ == null) {
              MapInfo = new global::EggLink.DanhengServer.Proto.MonopolyMapInfo();
            }
            input.ReadMessage(MapInfo);
            break;
          }
          case 18: {
            if (oPCAGCOFIDD_ == null) {
              OPCAGCOFIDD = new global::EggLink.DanhengServer.Proto.HKODIMKNMHC();
            }
            input.ReadMessage(OPCAGCOFIDD);
            break;
          }
          case 26:
          case 24: {
            kBCOAPMBJDL_.AddEntriesFrom(ref input, _repeated_kBCOAPMBJDL_codec);
            break;
          }
          case 34: {
            if (rogueBuffInfo_ == null) {
              RogueBuffInfo = new global::EggLink.DanhengServer.Proto.MonopolyBuffInfo();
            }
            input.ReadMessage(RogueBuffInfo);
            break;
          }
          case 42: {
            if (mGAHMHOBDLB_ == null) {
              MGAHMHOBDLB = new global::EggLink.DanhengServer.Proto.PMOHGBJANPF();
            }
            input.ReadMessage(MGAHMHOBDLB);
            break;
          }
          case 50: {
            if (iDBBAGIMINM_ == null) {
              IDBBAGIMINM = new global::EggLink.DanhengServer.Proto.FNFCMFHEABP();
            }
            input.ReadMessage(IDBBAGIMINM);
            break;
          }
          case 58: {
            if (report_ == null) {
              Report = new global::EggLink.DanhengServer.Proto.MonopolyReport();
            }
            input.ReadMessage(Report);
            break;
          }
          case 66: {
            if (bDCLGKJBBJM_ == null) {
              BDCLGKJBBJM = new global::EggLink.DanhengServer.Proto.DEBPGCGBIEE();
            }
            input.ReadMessage(BDCLGKJBBJM);
            break;
          }
          case 82: {
            if (jKHNOHGOMKK_ == null) {
              JKHNOHGOMKK = new global::EggLink.DanhengServer.Proto.GBIPLNAFLIG();
            }
            input.ReadMessage(JKHNOHGOMKK);
            break;
          }
          case 88: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 98: {
            if (oDEOACMBEAK_ == null) {
              ODEOACMBEAK = new global::EggLink.DanhengServer.Proto.KCHAAODODJO();
            }
            input.ReadMessage(ODEOACMBEAK);
            break;
          }
          case 106: {
            if (bBNHHGFCPEE_ == null) {
              BBNHHGFCPEE = new global::EggLink.DanhengServer.Proto.NNPAPFMJCDH();
            }
            input.ReadMessage(BBNHHGFCPEE);
            break;
          }
          case 114: {
            if (stt_ == null) {
              Stt = new global::EggLink.DanhengServer.Proto.MonopolyEventInfo();
            }
            input.ReadMessage(Stt);
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
