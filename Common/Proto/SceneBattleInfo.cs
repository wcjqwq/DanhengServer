// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneBattleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SceneBattleInfo.proto</summary>
  public static partial class SceneBattleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneBattleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneBattleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVTY2VuZUJhdHRsZUluZm8ucHJvdG8aFkJhdHRsZVRhcmdldExpc3QucHJv",
            "dG8aFlNjZW5lTW9uc3RlcldhdmUucHJvdG8aG0JhdHRsZUV2ZW50QmF0dGxl",
            "SW5mby5wcm90bxoYQmF0dGxlTWVjaGFuaXNtQmFyLnByb3RvGhJCYXR0bGVB",
            "dmF0YXIucHJvdG8aEUtGRU1LQ09GT0ZBLnByb3RvGhBCYXR0bGVCdWZmLnBy",
            "b3RvIrQECg9TY2VuZUJhdHRsZUluZm8SLAoRbW9uc3Rlcl93YXZlX2xpc3QY",
            "CCADKAsyES5TY2VuZU1vbnN0ZXJXYXZlEhAKCHN0YWdlX2lkGAkgASgNEi8K",
            "Em1lY2hhbmlzbV9iYXJfaW5mbxgDIAEoCzITLkJhdHRsZU1lY2hhbmlzbUJh",
            "chIUCgxyb3VuZHNfbGltaXQYDSABKA0SEwoLTU9MTkZOQkxLQkwYAiABKAgS",
            "LQoMYmF0dGxlX2V2ZW50GPMKIAMoCzIWLkJhdHRsZUV2ZW50QmF0dGxlSW5m",
            "bxIZChFsb2dpY19yYW5kb21fc2VlZBgHIAEoDRIRCgliYXR0bGVfaWQYDiAB",
            "KA0SHgoJYnVmZl9saXN0GAwgAygLMgsuQmF0dGxlQnVmZhITCgtCSkVMT0lK",
            "SkZQTxgKIAEoDRIpChJiYXR0bGVfYXZhdGFyX2xpc3QYBSADKAsyDS5CYXR0",
            "bGVBdmF0YXISQwoSYmF0dGxlX3RhcmdldF9pbmZvGNoLIAMoCzImLlNjZW5l",
            "QmF0dGxlSW5mby5CYXR0bGVUYXJnZXRJbmZvRW50cnkSEwoLd29ybGRfbGV2",
            "ZWwYASABKA0SIgoLRFBNRkRBSkdPQUYY/g0gASgLMgwuS0ZFTUtDT0ZPRkEa",
            "SgoVQmF0dGxlVGFyZ2V0SW5mb0VudHJ5EgsKA2tleRgBIAEoDRIgCgV2YWx1",
            "ZRgCIAEoCzIRLkJhdHRsZVRhcmdldExpc3Q6AjgBQh6qAhtFZ2dMaW5rLkRh",
            "bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.BattleTargetListReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneMonsterWaveReflection.Descriptor, global::EggLink.DanhengServer.Proto.BattleEventBattleInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.BattleMechanismBarReflection.Descriptor, global::EggLink.DanhengServer.Proto.BattleAvatarReflection.Descriptor, global::EggLink.DanhengServer.Proto.KFEMKCOFOFAReflection.Descriptor, global::EggLink.DanhengServer.Proto.BattleBuffReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SceneBattleInfo), global::EggLink.DanhengServer.Proto.SceneBattleInfo.Parser, new[]{ "MonsterWaveList", "StageId", "MechanismBarInfo", "RoundsLimit", "MOLNFNBLKBL", "BattleEvent", "LogicRandomSeed", "BattleId", "BuffList", "BJELOIJJFPO", "BattleAvatarList", "BattleTargetInfo", "WorldLevel", "DPMFDAJGOAF" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SceneBattleInfo : pb::IMessage<SceneBattleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneBattleInfo> _parser = new pb::MessageParser<SceneBattleInfo>(() => new SceneBattleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneBattleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SceneBattleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneBattleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneBattleInfo(SceneBattleInfo other) : this() {
      monsterWaveList_ = other.monsterWaveList_.Clone();
      stageId_ = other.stageId_;
      mechanismBarInfo_ = other.mechanismBarInfo_ != null ? other.mechanismBarInfo_.Clone() : null;
      roundsLimit_ = other.roundsLimit_;
      mOLNFNBLKBL_ = other.mOLNFNBLKBL_;
      battleEvent_ = other.battleEvent_.Clone();
      logicRandomSeed_ = other.logicRandomSeed_;
      battleId_ = other.battleId_;
      buffList_ = other.buffList_.Clone();
      bJELOIJJFPO_ = other.bJELOIJJFPO_;
      battleAvatarList_ = other.battleAvatarList_.Clone();
      battleTargetInfo_ = other.battleTargetInfo_.Clone();
      worldLevel_ = other.worldLevel_;
      dPMFDAJGOAF_ = other.dPMFDAJGOAF_ != null ? other.dPMFDAJGOAF_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneBattleInfo Clone() {
      return new SceneBattleInfo(this);
    }

    /// <summary>Field number for the "monster_wave_list" field.</summary>
    public const int MonsterWaveListFieldNumber = 8;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.SceneMonsterWave> _repeated_monsterWaveList_codec
        = pb::FieldCodec.ForMessage(66, global::EggLink.DanhengServer.Proto.SceneMonsterWave.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneMonsterWave> monsterWaveList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneMonsterWave>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SceneMonsterWave> MonsterWaveList {
      get { return monsterWaveList_; }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 9;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "mechanism_bar_info" field.</summary>
    public const int MechanismBarInfoFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.BattleMechanismBar mechanismBarInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.BattleMechanismBar MechanismBarInfo {
      get { return mechanismBarInfo_; }
      set {
        mechanismBarInfo_ = value;
      }
    }

    /// <summary>Field number for the "rounds_limit" field.</summary>
    public const int RoundsLimitFieldNumber = 13;
    private uint roundsLimit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RoundsLimit {
      get { return roundsLimit_; }
      set {
        roundsLimit_ = value;
      }
    }

    /// <summary>Field number for the "MOLNFNBLKBL" field.</summary>
    public const int MOLNFNBLKBLFieldNumber = 2;
    private bool mOLNFNBLKBL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool MOLNFNBLKBL {
      get { return mOLNFNBLKBL_; }
      set {
        mOLNFNBLKBL_ = value;
      }
    }

    /// <summary>Field number for the "battle_event" field.</summary>
    public const int BattleEventFieldNumber = 1395;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.BattleEventBattleInfo> _repeated_battleEvent_codec
        = pb::FieldCodec.ForMessage(11162, global::EggLink.DanhengServer.Proto.BattleEventBattleInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleEventBattleInfo> battleEvent_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleEventBattleInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleEventBattleInfo> BattleEvent {
      get { return battleEvent_; }
    }

    /// <summary>Field number for the "logic_random_seed" field.</summary>
    public const int LogicRandomSeedFieldNumber = 7;
    private uint logicRandomSeed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LogicRandomSeed {
      get { return logicRandomSeed_; }
      set {
        logicRandomSeed_ = value;
      }
    }

    /// <summary>Field number for the "battle_id" field.</summary>
    public const int BattleIdFieldNumber = 14;
    private uint battleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BattleId {
      get { return battleId_; }
      set {
        battleId_ = value;
      }
    }

    /// <summary>Field number for the "buff_list" field.</summary>
    public const int BuffListFieldNumber = 12;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.BattleBuff> _repeated_buffList_codec
        = pb::FieldCodec.ForMessage(98, global::EggLink.DanhengServer.Proto.BattleBuff.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleBuff> buffList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleBuff>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleBuff> BuffList {
      get { return buffList_; }
    }

    /// <summary>Field number for the "BJELOIJJFPO" field.</summary>
    public const int BJELOIJJFPOFieldNumber = 10;
    private uint bJELOIJJFPO_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BJELOIJJFPO {
      get { return bJELOIJJFPO_; }
      set {
        bJELOIJJFPO_ = value;
      }
    }

    /// <summary>Field number for the "battle_avatar_list" field.</summary>
    public const int BattleAvatarListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.BattleAvatar> _repeated_battleAvatarList_codec
        = pb::FieldCodec.ForMessage(42, global::EggLink.DanhengServer.Proto.BattleAvatar.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleAvatar> battleAvatarList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleAvatar>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.BattleAvatar> BattleAvatarList {
      get { return battleAvatarList_; }
    }

    /// <summary>Field number for the "battle_target_info" field.</summary>
    public const int BattleTargetInfoFieldNumber = 1498;
    private static readonly pbc::MapField<uint, global::EggLink.DanhengServer.Proto.BattleTargetList>.Codec _map_battleTargetInfo_codec
        = new pbc::MapField<uint, global::EggLink.DanhengServer.Proto.BattleTargetList>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.BattleTargetList.Parser), 11986);
    private readonly pbc::MapField<uint, global::EggLink.DanhengServer.Proto.BattleTargetList> battleTargetInfo_ = new pbc::MapField<uint, global::EggLink.DanhengServer.Proto.BattleTargetList>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::EggLink.DanhengServer.Proto.BattleTargetList> BattleTargetInfo {
      get { return battleTargetInfo_; }
    }

    /// <summary>Field number for the "world_level" field.</summary>
    public const int WorldLevelFieldNumber = 1;
    private uint worldLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WorldLevel {
      get { return worldLevel_; }
      set {
        worldLevel_ = value;
      }
    }

    /// <summary>Field number for the "DPMFDAJGOAF" field.</summary>
    public const int DPMFDAJGOAFFieldNumber = 1790;
    private global::EggLink.DanhengServer.Proto.KFEMKCOFOFA dPMFDAJGOAF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.KFEMKCOFOFA DPMFDAJGOAF {
      get { return dPMFDAJGOAF_; }
      set {
        dPMFDAJGOAF_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneBattleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneBattleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!monsterWaveList_.Equals(other.monsterWaveList_)) return false;
      if (StageId != other.StageId) return false;
      if (!object.Equals(MechanismBarInfo, other.MechanismBarInfo)) return false;
      if (RoundsLimit != other.RoundsLimit) return false;
      if (MOLNFNBLKBL != other.MOLNFNBLKBL) return false;
      if(!battleEvent_.Equals(other.battleEvent_)) return false;
      if (LogicRandomSeed != other.LogicRandomSeed) return false;
      if (BattleId != other.BattleId) return false;
      if(!buffList_.Equals(other.buffList_)) return false;
      if (BJELOIJJFPO != other.BJELOIJJFPO) return false;
      if(!battleAvatarList_.Equals(other.battleAvatarList_)) return false;
      if (!BattleTargetInfo.Equals(other.BattleTargetInfo)) return false;
      if (WorldLevel != other.WorldLevel) return false;
      if (!object.Equals(DPMFDAJGOAF, other.DPMFDAJGOAF)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= monsterWaveList_.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
      if (mechanismBarInfo_ != null) hash ^= MechanismBarInfo.GetHashCode();
      if (RoundsLimit != 0) hash ^= RoundsLimit.GetHashCode();
      if (MOLNFNBLKBL != false) hash ^= MOLNFNBLKBL.GetHashCode();
      hash ^= battleEvent_.GetHashCode();
      if (LogicRandomSeed != 0) hash ^= LogicRandomSeed.GetHashCode();
      if (BattleId != 0) hash ^= BattleId.GetHashCode();
      hash ^= buffList_.GetHashCode();
      if (BJELOIJJFPO != 0) hash ^= BJELOIJJFPO.GetHashCode();
      hash ^= battleAvatarList_.GetHashCode();
      hash ^= BattleTargetInfo.GetHashCode();
      if (WorldLevel != 0) hash ^= WorldLevel.GetHashCode();
      if (dPMFDAJGOAF_ != null) hash ^= DPMFDAJGOAF.GetHashCode();
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
      if (WorldLevel != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(WorldLevel);
      }
      if (MOLNFNBLKBL != false) {
        output.WriteRawTag(16);
        output.WriteBool(MOLNFNBLKBL);
      }
      if (mechanismBarInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(MechanismBarInfo);
      }
      battleAvatarList_.WriteTo(output, _repeated_battleAvatarList_codec);
      if (LogicRandomSeed != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(LogicRandomSeed);
      }
      monsterWaveList_.WriteTo(output, _repeated_monsterWaveList_codec);
      if (StageId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(StageId);
      }
      if (BJELOIJJFPO != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(BJELOIJJFPO);
      }
      buffList_.WriteTo(output, _repeated_buffList_codec);
      if (RoundsLimit != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(RoundsLimit);
      }
      if (BattleId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(BattleId);
      }
      battleEvent_.WriteTo(output, _repeated_battleEvent_codec);
      battleTargetInfo_.WriteTo(output, _map_battleTargetInfo_codec);
      if (dPMFDAJGOAF_ != null) {
        output.WriteRawTag(242, 111);
        output.WriteMessage(DPMFDAJGOAF);
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
      if (WorldLevel != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(WorldLevel);
      }
      if (MOLNFNBLKBL != false) {
        output.WriteRawTag(16);
        output.WriteBool(MOLNFNBLKBL);
      }
      if (mechanismBarInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(MechanismBarInfo);
      }
      battleAvatarList_.WriteTo(ref output, _repeated_battleAvatarList_codec);
      if (LogicRandomSeed != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(LogicRandomSeed);
      }
      monsterWaveList_.WriteTo(ref output, _repeated_monsterWaveList_codec);
      if (StageId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(StageId);
      }
      if (BJELOIJJFPO != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(BJELOIJJFPO);
      }
      buffList_.WriteTo(ref output, _repeated_buffList_codec);
      if (RoundsLimit != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(RoundsLimit);
      }
      if (BattleId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(BattleId);
      }
      battleEvent_.WriteTo(ref output, _repeated_battleEvent_codec);
      battleTargetInfo_.WriteTo(ref output, _map_battleTargetInfo_codec);
      if (dPMFDAJGOAF_ != null) {
        output.WriteRawTag(242, 111);
        output.WriteMessage(DPMFDAJGOAF);
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
      size += monsterWaveList_.CalculateSize(_repeated_monsterWaveList_codec);
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (mechanismBarInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MechanismBarInfo);
      }
      if (RoundsLimit != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RoundsLimit);
      }
      if (MOLNFNBLKBL != false) {
        size += 1 + 1;
      }
      size += battleEvent_.CalculateSize(_repeated_battleEvent_codec);
      if (LogicRandomSeed != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LogicRandomSeed);
      }
      if (BattleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BattleId);
      }
      size += buffList_.CalculateSize(_repeated_buffList_codec);
      if (BJELOIJJFPO != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BJELOIJJFPO);
      }
      size += battleAvatarList_.CalculateSize(_repeated_battleAvatarList_codec);
      size += battleTargetInfo_.CalculateSize(_map_battleTargetInfo_codec);
      if (WorldLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WorldLevel);
      }
      if (dPMFDAJGOAF_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(DPMFDAJGOAF);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneBattleInfo other) {
      if (other == null) {
        return;
      }
      monsterWaveList_.Add(other.monsterWaveList_);
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      if (other.mechanismBarInfo_ != null) {
        if (mechanismBarInfo_ == null) {
          MechanismBarInfo = new global::EggLink.DanhengServer.Proto.BattleMechanismBar();
        }
        MechanismBarInfo.MergeFrom(other.MechanismBarInfo);
      }
      if (other.RoundsLimit != 0) {
        RoundsLimit = other.RoundsLimit;
      }
      if (other.MOLNFNBLKBL != false) {
        MOLNFNBLKBL = other.MOLNFNBLKBL;
      }
      battleEvent_.Add(other.battleEvent_);
      if (other.LogicRandomSeed != 0) {
        LogicRandomSeed = other.LogicRandomSeed;
      }
      if (other.BattleId != 0) {
        BattleId = other.BattleId;
      }
      buffList_.Add(other.buffList_);
      if (other.BJELOIJJFPO != 0) {
        BJELOIJJFPO = other.BJELOIJJFPO;
      }
      battleAvatarList_.Add(other.battleAvatarList_);
      battleTargetInfo_.MergeFrom(other.battleTargetInfo_);
      if (other.WorldLevel != 0) {
        WorldLevel = other.WorldLevel;
      }
      if (other.dPMFDAJGOAF_ != null) {
        if (dPMFDAJGOAF_ == null) {
          DPMFDAJGOAF = new global::EggLink.DanhengServer.Proto.KFEMKCOFOFA();
        }
        DPMFDAJGOAF.MergeFrom(other.DPMFDAJGOAF);
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
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 16: {
            MOLNFNBLKBL = input.ReadBool();
            break;
          }
          case 26: {
            if (mechanismBarInfo_ == null) {
              MechanismBarInfo = new global::EggLink.DanhengServer.Proto.BattleMechanismBar();
            }
            input.ReadMessage(MechanismBarInfo);
            break;
          }
          case 42: {
            battleAvatarList_.AddEntriesFrom(input, _repeated_battleAvatarList_codec);
            break;
          }
          case 56: {
            LogicRandomSeed = input.ReadUInt32();
            break;
          }
          case 66: {
            monsterWaveList_.AddEntriesFrom(input, _repeated_monsterWaveList_codec);
            break;
          }
          case 72: {
            StageId = input.ReadUInt32();
            break;
          }
          case 80: {
            BJELOIJJFPO = input.ReadUInt32();
            break;
          }
          case 98: {
            buffList_.AddEntriesFrom(input, _repeated_buffList_codec);
            break;
          }
          case 104: {
            RoundsLimit = input.ReadUInt32();
            break;
          }
          case 112: {
            BattleId = input.ReadUInt32();
            break;
          }
          case 11162: {
            battleEvent_.AddEntriesFrom(input, _repeated_battleEvent_codec);
            break;
          }
          case 11986: {
            battleTargetInfo_.AddEntriesFrom(input, _map_battleTargetInfo_codec);
            break;
          }
          case 14322: {
            if (dPMFDAJGOAF_ == null) {
              DPMFDAJGOAF = new global::EggLink.DanhengServer.Proto.KFEMKCOFOFA();
            }
            input.ReadMessage(DPMFDAJGOAF);
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
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 16: {
            MOLNFNBLKBL = input.ReadBool();
            break;
          }
          case 26: {
            if (mechanismBarInfo_ == null) {
              MechanismBarInfo = new global::EggLink.DanhengServer.Proto.BattleMechanismBar();
            }
            input.ReadMessage(MechanismBarInfo);
            break;
          }
          case 42: {
            battleAvatarList_.AddEntriesFrom(ref input, _repeated_battleAvatarList_codec);
            break;
          }
          case 56: {
            LogicRandomSeed = input.ReadUInt32();
            break;
          }
          case 66: {
            monsterWaveList_.AddEntriesFrom(ref input, _repeated_monsterWaveList_codec);
            break;
          }
          case 72: {
            StageId = input.ReadUInt32();
            break;
          }
          case 80: {
            BJELOIJJFPO = input.ReadUInt32();
            break;
          }
          case 98: {
            buffList_.AddEntriesFrom(ref input, _repeated_buffList_codec);
            break;
          }
          case 104: {
            RoundsLimit = input.ReadUInt32();
            break;
          }
          case 112: {
            BattleId = input.ReadUInt32();
            break;
          }
          case 11162: {
            battleEvent_.AddEntriesFrom(ref input, _repeated_battleEvent_codec);
            break;
          }
          case 11986: {
            battleTargetInfo_.AddEntriesFrom(ref input, _map_battleTargetInfo_codec);
            break;
          }
          case 14322: {
            if (dPMFDAJGOAF_ == null) {
              DPMFDAJGOAF = new global::EggLink.DanhengServer.Proto.KFEMKCOFOFA();
            }
            input.ReadMessage(DPMFDAJGOAF);
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
