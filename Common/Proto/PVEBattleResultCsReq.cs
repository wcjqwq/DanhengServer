// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PVEBattleResultCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from PVEBattleResultCsReq.proto</summary>
  public static partial class PVEBattleResultCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for PVEBattleResultCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PVEBattleResultCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpQVkVCYXR0bGVSZXN1bHRDc1JlcS5wcm90bxoVQmF0dGxlRW5kU3RhdHVz",
            "LnByb3RvGhZCYXR0bGVTdGF0aXN0aWNzLnByb3RvGg5CYXR0bGVPcC5wcm90",
            "byLyAwoUUFZFQmF0dGxlUmVzdWx0Q3NSZXESHgoDc3R0GAggASgLMhEuQmF0",
            "dGxlU3RhdGlzdGljcxIRCgliYXR0bGVfaWQYAyABKA0SHAoUdG90YWxfZGVs",
            "YXlfY3VtdWxhdGUYDiABKA0SOgoLY2xpZW50X3RhZ3MYBiADKAsyJS5QVkVC",
            "YXR0bGVSZXN1bHRDc1JlcS5DbGllbnRUYWdzRW50cnkSEwoLTk5DRUNMR0NJ",
            "REYYCiABKA0SEwoLTkNJUEJIRkVGR0cYCSABKAgSEwoLcmVzX3ZlcnNpb24Y",
            "AiABKA0SEAoIc3RhZ2VfaWQYCyABKA0SGgoSdHVybl9zbmFwc2hvdF9oYXNo",
            "GA0gASgMEhYKDmNsaWVudF92ZXJzaW9uGAQgASgNEiQKCmVuZF9zdGF0dXMY",
            "DCABKA4yEC5CYXR0bGVFbmRTdGF0dXMSGgoHb3BfbGlzdBgBIAMoCzIJLkJh",
            "dHRsZU9wEhgKEGRlYnVnX2V4dHJhX2luZm8YByABKAkSFQoNaXNfYXV0b19m",
            "aWdodBgFIAEoCBIiChppc19haV9jb25zaWRlcl91bHRyYV9za2lsbBgPIAEo",
            "CBoxCg9DbGllbnRUYWdzRW50cnkSCwoDa2V5GAEgASgJEg0KBXZhbHVlGAIg",
            "ASgNOgI4AUIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.BattleEndStatusReflection.Descriptor, global::EggLink.DanhengServer.Proto.BattleStatisticsReflection.Descriptor, global::EggLink.DanhengServer.Proto.BattleOpReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.PVEBattleResultCsReq), global::EggLink.DanhengServer.Proto.PVEBattleResultCsReq.Parser, new[]{ "Stt", "BattleId", "TotalDelayCumulate", "ClientTags", "NNCECLGCIDF", "NCIPBHFEFGG", "ResVersion", "StageId", "TurnSnapshotHash", "ClientVersion", "EndStatus", "OpList", "DebugExtraInfo", "IsAutoFight", "IsAiConsiderUltraSkill" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class PVEBattleResultCsReq : pb::IMessage<PVEBattleResultCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PVEBattleResultCsReq> _parser = new pb::MessageParser<PVEBattleResultCsReq>(() => new PVEBattleResultCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PVEBattleResultCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.PVEBattleResultCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PVEBattleResultCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PVEBattleResultCsReq(PVEBattleResultCsReq other) : this() {
      stt_ = other.stt_ != null ? other.stt_.Clone() : null;
      battleId_ = other.battleId_;
      totalDelayCumulate_ = other.totalDelayCumulate_;
      clientTags_ = other.clientTags_.Clone();
      nNCECLGCIDF_ = other.nNCECLGCIDF_;
      nCIPBHFEFGG_ = other.nCIPBHFEFGG_;
      resVersion_ = other.resVersion_;
      stageId_ = other.stageId_;
      turnSnapshotHash_ = other.turnSnapshotHash_;
      clientVersion_ = other.clientVersion_;
      endStatus_ = other.endStatus_;
      opList_ = other.opList_.Clone();
      debugExtraInfo_ = other.debugExtraInfo_;
      isAutoFight_ = other.isAutoFight_;
      isAiConsiderUltraSkill_ = other.isAiConsiderUltraSkill_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PVEBattleResultCsReq Clone() {
      return new PVEBattleResultCsReq(this);
    }

    /// <summary>Field number for the "stt" field.</summary>
    public const int SttFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.BattleStatistics stt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BattleStatistics Stt {
      get { return stt_; }
      set {
        stt_ = value;
      }
    }

    /// <summary>Field number for the "battle_id" field.</summary>
    public const int BattleIdFieldNumber = 3;
    private uint battleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BattleId {
      get { return battleId_; }
      set {
        battleId_ = value;
      }
    }

    /// <summary>Field number for the "total_delay_cumulate" field.</summary>
    public const int TotalDelayCumulateFieldNumber = 14;
    private uint totalDelayCumulate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalDelayCumulate {
      get { return totalDelayCumulate_; }
      set {
        totalDelayCumulate_ = value;
      }
    }

    /// <summary>Field number for the "client_tags" field.</summary>
    public const int ClientTagsFieldNumber = 6;
    private static readonly pbc::MapField<string, uint>.Codec _map_clientTags_codec
        = new pbc::MapField<string, uint>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForUInt32(16, 0), 50);
    private readonly pbc::MapField<string, uint> clientTags_ = new pbc::MapField<string, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, uint> ClientTags {
      get { return clientTags_; }
    }

    /// <summary>Field number for the "NNCECLGCIDF" field.</summary>
    public const int NNCECLGCIDFFieldNumber = 10;
    private uint nNCECLGCIDF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NNCECLGCIDF {
      get { return nNCECLGCIDF_; }
      set {
        nNCECLGCIDF_ = value;
      }
    }

    /// <summary>Field number for the "NCIPBHFEFGG" field.</summary>
    public const int NCIPBHFEFGGFieldNumber = 9;
    private bool nCIPBHFEFGG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool NCIPBHFEFGG {
      get { return nCIPBHFEFGG_; }
      set {
        nCIPBHFEFGG_ = value;
      }
    }

    /// <summary>Field number for the "res_version" field.</summary>
    public const int ResVersionFieldNumber = 2;
    private uint resVersion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ResVersion {
      get { return resVersion_; }
      set {
        resVersion_ = value;
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 11;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "turn_snapshot_hash" field.</summary>
    public const int TurnSnapshotHashFieldNumber = 13;
    private pb::ByteString turnSnapshotHash_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString TurnSnapshotHash {
      get { return turnSnapshotHash_; }
      set {
        turnSnapshotHash_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "client_version" field.</summary>
    public const int ClientVersionFieldNumber = 4;
    private uint clientVersion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ClientVersion {
      get { return clientVersion_; }
      set {
        clientVersion_ = value;
      }
    }

    /// <summary>Field number for the "end_status" field.</summary>
    public const int EndStatusFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.BattleEndStatus endStatus_ = global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BattleEndStatus EndStatus {
      get { return endStatus_; }
      set {
        endStatus_ = value;
      }
    }

    /// <summary>Field number for the "op_list" field.</summary>
    public const int OpListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.BattleOp> _repeated_opList_codec
        = pb::FieldCodec.ForMessage(10, global::EggLink.DanhengServer.Proto.BattleOp.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleOp> opList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleOp>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleOp> OpList {
      get { return opList_; }
    }

    /// <summary>Field number for the "debug_extra_info" field.</summary>
    public const int DebugExtraInfoFieldNumber = 7;
    private string debugExtraInfo_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DebugExtraInfo {
      get { return debugExtraInfo_; }
      set {
        debugExtraInfo_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "is_auto_fight" field.</summary>
    public const int IsAutoFightFieldNumber = 5;
    private bool isAutoFight_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAutoFight {
      get { return isAutoFight_; }
      set {
        isAutoFight_ = value;
      }
    }

    /// <summary>Field number for the "is_ai_consider_ultra_skill" field.</summary>
    public const int IsAiConsiderUltraSkillFieldNumber = 15;
    private bool isAiConsiderUltraSkill_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAiConsiderUltraSkill {
      get { return isAiConsiderUltraSkill_; }
      set {
        isAiConsiderUltraSkill_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PVEBattleResultCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PVEBattleResultCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Stt, other.Stt)) return false;
      if (BattleId != other.BattleId) return false;
      if (TotalDelayCumulate != other.TotalDelayCumulate) return false;
      if (!ClientTags.Equals(other.ClientTags)) return false;
      if (NNCECLGCIDF != other.NNCECLGCIDF) return false;
      if (NCIPBHFEFGG != other.NCIPBHFEFGG) return false;
      if (ResVersion != other.ResVersion) return false;
      if (StageId != other.StageId) return false;
      if (TurnSnapshotHash != other.TurnSnapshotHash) return false;
      if (ClientVersion != other.ClientVersion) return false;
      if (EndStatus != other.EndStatus) return false;
      if(!opList_.Equals(other.opList_)) return false;
      if (DebugExtraInfo != other.DebugExtraInfo) return false;
      if (IsAutoFight != other.IsAutoFight) return false;
      if (IsAiConsiderUltraSkill != other.IsAiConsiderUltraSkill) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (stt_ != null) hash ^= Stt.GetHashCode();
      if (BattleId != 0) hash ^= BattleId.GetHashCode();
      if (TotalDelayCumulate != 0) hash ^= TotalDelayCumulate.GetHashCode();
      hash ^= ClientTags.GetHashCode();
      if (NNCECLGCIDF != 0) hash ^= NNCECLGCIDF.GetHashCode();
      if (NCIPBHFEFGG != false) hash ^= NCIPBHFEFGG.GetHashCode();
      if (ResVersion != 0) hash ^= ResVersion.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
      if (TurnSnapshotHash.Length != 0) hash ^= TurnSnapshotHash.GetHashCode();
      if (ClientVersion != 0) hash ^= ClientVersion.GetHashCode();
      if (EndStatus != global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone) hash ^= EndStatus.GetHashCode();
      hash ^= opList_.GetHashCode();
      if (DebugExtraInfo.Length != 0) hash ^= DebugExtraInfo.GetHashCode();
      if (IsAutoFight != false) hash ^= IsAutoFight.GetHashCode();
      if (IsAiConsiderUltraSkill != false) hash ^= IsAiConsiderUltraSkill.GetHashCode();
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
      opList_.WriteTo(output, _repeated_opList_codec);
      if (ResVersion != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ResVersion);
      }
      if (BattleId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(BattleId);
      }
      if (ClientVersion != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ClientVersion);
      }
      if (IsAutoFight != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsAutoFight);
      }
      clientTags_.WriteTo(output, _map_clientTags_codec);
      if (DebugExtraInfo.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(DebugExtraInfo);
      }
      if (stt_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Stt);
      }
      if (NCIPBHFEFGG != false) {
        output.WriteRawTag(72);
        output.WriteBool(NCIPBHFEFGG);
      }
      if (NNCECLGCIDF != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(NNCECLGCIDF);
      }
      if (StageId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(StageId);
      }
      if (EndStatus != global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone) {
        output.WriteRawTag(96);
        output.WriteEnum((int) EndStatus);
      }
      if (TurnSnapshotHash.Length != 0) {
        output.WriteRawTag(106);
        output.WriteBytes(TurnSnapshotHash);
      }
      if (TotalDelayCumulate != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(TotalDelayCumulate);
      }
      if (IsAiConsiderUltraSkill != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsAiConsiderUltraSkill);
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
      opList_.WriteTo(ref output, _repeated_opList_codec);
      if (ResVersion != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ResVersion);
      }
      if (BattleId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(BattleId);
      }
      if (ClientVersion != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ClientVersion);
      }
      if (IsAutoFight != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsAutoFight);
      }
      clientTags_.WriteTo(ref output, _map_clientTags_codec);
      if (DebugExtraInfo.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(DebugExtraInfo);
      }
      if (stt_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Stt);
      }
      if (NCIPBHFEFGG != false) {
        output.WriteRawTag(72);
        output.WriteBool(NCIPBHFEFGG);
      }
      if (NNCECLGCIDF != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(NNCECLGCIDF);
      }
      if (StageId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(StageId);
      }
      if (EndStatus != global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone) {
        output.WriteRawTag(96);
        output.WriteEnum((int) EndStatus);
      }
      if (TurnSnapshotHash.Length != 0) {
        output.WriteRawTag(106);
        output.WriteBytes(TurnSnapshotHash);
      }
      if (TotalDelayCumulate != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(TotalDelayCumulate);
      }
      if (IsAiConsiderUltraSkill != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsAiConsiderUltraSkill);
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
      if (stt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Stt);
      }
      if (BattleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BattleId);
      }
      if (TotalDelayCumulate != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalDelayCumulate);
      }
      size += clientTags_.CalculateSize(_map_clientTags_codec);
      if (NNCECLGCIDF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NNCECLGCIDF);
      }
      if (NCIPBHFEFGG != false) {
        size += 1 + 1;
      }
      if (ResVersion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ResVersion);
      }
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (TurnSnapshotHash.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(TurnSnapshotHash);
      }
      if (ClientVersion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ClientVersion);
      }
      if (EndStatus != global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) EndStatus);
      }
      size += opList_.CalculateSize(_repeated_opList_codec);
      if (DebugExtraInfo.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DebugExtraInfo);
      }
      if (IsAutoFight != false) {
        size += 1 + 1;
      }
      if (IsAiConsiderUltraSkill != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PVEBattleResultCsReq other) {
      if (other == null) {
        return;
      }
      if (other.stt_ != null) {
        if (stt_ == null) {
          Stt = new global::EggLink.DanhengServer.Proto.BattleStatistics();
        }
        Stt.MergeFrom(other.Stt);
      }
      if (other.BattleId != 0) {
        BattleId = other.BattleId;
      }
      if (other.TotalDelayCumulate != 0) {
        TotalDelayCumulate = other.TotalDelayCumulate;
      }
      clientTags_.MergeFrom(other.clientTags_);
      if (other.NNCECLGCIDF != 0) {
        NNCECLGCIDF = other.NNCECLGCIDF;
      }
      if (other.NCIPBHFEFGG != false) {
        NCIPBHFEFGG = other.NCIPBHFEFGG;
      }
      if (other.ResVersion != 0) {
        ResVersion = other.ResVersion;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      if (other.TurnSnapshotHash.Length != 0) {
        TurnSnapshotHash = other.TurnSnapshotHash;
      }
      if (other.ClientVersion != 0) {
        ClientVersion = other.ClientVersion;
      }
      if (other.EndStatus != global::EggLink.DanhengServer.Proto.BattleEndStatus.BattleEndNone) {
        EndStatus = other.EndStatus;
      }
      opList_.Add(other.opList_);
      if (other.DebugExtraInfo.Length != 0) {
        DebugExtraInfo = other.DebugExtraInfo;
      }
      if (other.IsAutoFight != false) {
        IsAutoFight = other.IsAutoFight;
      }
      if (other.IsAiConsiderUltraSkill != false) {
        IsAiConsiderUltraSkill = other.IsAiConsiderUltraSkill;
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
            opList_.AddEntriesFrom(input, _repeated_opList_codec);
            break;
          }
          case 16: {
            ResVersion = input.ReadUInt32();
            break;
          }
          case 24: {
            BattleId = input.ReadUInt32();
            break;
          }
          case 32: {
            ClientVersion = input.ReadUInt32();
            break;
          }
          case 40: {
            IsAutoFight = input.ReadBool();
            break;
          }
          case 50: {
            clientTags_.AddEntriesFrom(input, _map_clientTags_codec);
            break;
          }
          case 58: {
            DebugExtraInfo = input.ReadString();
            break;
          }
          case 66: {
            if (stt_ == null) {
              Stt = new global::EggLink.DanhengServer.Proto.BattleStatistics();
            }
            input.ReadMessage(Stt);
            break;
          }
          case 72: {
            NCIPBHFEFGG = input.ReadBool();
            break;
          }
          case 80: {
            NNCECLGCIDF = input.ReadUInt32();
            break;
          }
          case 88: {
            StageId = input.ReadUInt32();
            break;
          }
          case 96: {
            EndStatus = (global::EggLink.DanhengServer.Proto.BattleEndStatus) input.ReadEnum();
            break;
          }
          case 106: {
            TurnSnapshotHash = input.ReadBytes();
            break;
          }
          case 112: {
            TotalDelayCumulate = input.ReadUInt32();
            break;
          }
          case 120: {
            IsAiConsiderUltraSkill = input.ReadBool();
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
            opList_.AddEntriesFrom(ref input, _repeated_opList_codec);
            break;
          }
          case 16: {
            ResVersion = input.ReadUInt32();
            break;
          }
          case 24: {
            BattleId = input.ReadUInt32();
            break;
          }
          case 32: {
            ClientVersion = input.ReadUInt32();
            break;
          }
          case 40: {
            IsAutoFight = input.ReadBool();
            break;
          }
          case 50: {
            clientTags_.AddEntriesFrom(ref input, _map_clientTags_codec);
            break;
          }
          case 58: {
            DebugExtraInfo = input.ReadString();
            break;
          }
          case 66: {
            if (stt_ == null) {
              Stt = new global::EggLink.DanhengServer.Proto.BattleStatistics();
            }
            input.ReadMessage(Stt);
            break;
          }
          case 72: {
            NCIPBHFEFGG = input.ReadBool();
            break;
          }
          case 80: {
            NNCECLGCIDF = input.ReadUInt32();
            break;
          }
          case 88: {
            StageId = input.ReadUInt32();
            break;
          }
          case 96: {
            EndStatus = (global::EggLink.DanhengServer.Proto.BattleEndStatus) input.ReadEnum();
            break;
          }
          case 106: {
            TurnSnapshotHash = input.ReadBytes();
            break;
          }
          case 112: {
            TotalDelayCumulate = input.ReadUInt32();
            break;
          }
          case 120: {
            IsAiConsiderUltraSkill = input.ReadBool();
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
