// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneCastSkillCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SceneCastSkillCsReq.proto</summary>
  public static partial class SceneCastSkillCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneCastSkillCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneCastSkillCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlTY2VuZUNhc3RTa2lsbENzUmVxLnByb3RvGhNTa2lsbEV4dHJhVGFnLnBy",
            "b3RvGhBNb3Rpb25JbmZvLnByb3RvGhFFS0NGTklDQklISi5wcm90byLYAgoT",
            "U2NlbmVDYXN0U2tpbGxDc1JlcRIlCh1hc3Npc3RfbW9uc3Rlcl9lbnRpdHlf",
            "aWRfbGlzdBgOIAMoDRITCgtNQ0tOSENHTk9HRhgCIAEoDRIhChloaXRfdGFy",
            "Z2V0X2VudGl0eV9pZF9saXN0GAkgAygNEhMKC3NraWxsX2luZGV4GAYgASgN",
            "EhYKDmNhc3RfZW50aXR5X2lkGAggASgNEiQKDmR5bmFtaWNfdmFsdWVzGAsg",
            "AygLMgwuRUtDRk5JQ0JJSEoSHQoVYXR0YWNrZWRfYnlfZW50aXR5X2lkGAEg",
            "ASgNEigKEHNraWxsX2V4dHJhX3RhZ3MYAyADKA4yDi5Ta2lsbEV4dHJhVGFn",
            "EiIKDXRhcmdldF9tb3Rpb24YDyABKAsyCy5Nb3Rpb25JbmZvEiIKGmhpdF9t",
            "b25zdGVyX2VudGl0eV9pZF9saXN0GA0gAygNQh6qAhtFZ2dMaW5rLkRhbmhl",
            "bmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.SkillExtraTagReflection.Descriptor, global::EggLink.DanhengServer.Proto.MotionInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.EKCFNICBIHJReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SceneCastSkillCsReq), global::EggLink.DanhengServer.Proto.SceneCastSkillCsReq.Parser, new[]{ "AssistMonsterEntityIdList", "MCKNHCGNOGF", "HitTargetEntityIdList", "SkillIndex", "CastEntityId", "DynamicValues", "AttackedByEntityId", "SkillExtraTags", "TargetMotion", "HitMonsterEntityIdList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SceneCastSkillCsReq : pb::IMessage<SceneCastSkillCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneCastSkillCsReq> _parser = new pb::MessageParser<SceneCastSkillCsReq>(() => new SceneCastSkillCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneCastSkillCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SceneCastSkillCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneCastSkillCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneCastSkillCsReq(SceneCastSkillCsReq other) : this() {
      assistMonsterEntityIdList_ = other.assistMonsterEntityIdList_.Clone();
      mCKNHCGNOGF_ = other.mCKNHCGNOGF_;
      hitTargetEntityIdList_ = other.hitTargetEntityIdList_.Clone();
      skillIndex_ = other.skillIndex_;
      castEntityId_ = other.castEntityId_;
      dynamicValues_ = other.dynamicValues_.Clone();
      attackedByEntityId_ = other.attackedByEntityId_;
      skillExtraTags_ = other.skillExtraTags_.Clone();
      targetMotion_ = other.targetMotion_ != null ? other.targetMotion_.Clone() : null;
      hitMonsterEntityIdList_ = other.hitMonsterEntityIdList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneCastSkillCsReq Clone() {
      return new SceneCastSkillCsReq(this);
    }

    /// <summary>Field number for the "assist_monster_entity_id_list" field.</summary>
    public const int AssistMonsterEntityIdListFieldNumber = 14;
    private static readonly pb::FieldCodec<uint> _repeated_assistMonsterEntityIdList_codec
        = pb::FieldCodec.ForUInt32(114);
    private readonly pbc::RepeatedField<uint> assistMonsterEntityIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AssistMonsterEntityIdList {
      get { return assistMonsterEntityIdList_; }
    }

    /// <summary>Field number for the "MCKNHCGNOGF" field.</summary>
    public const int MCKNHCGNOGFFieldNumber = 2;
    private uint mCKNHCGNOGF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MCKNHCGNOGF {
      get { return mCKNHCGNOGF_; }
      set {
        mCKNHCGNOGF_ = value;
      }
    }

    /// <summary>Field number for the "hit_target_entity_id_list" field.</summary>
    public const int HitTargetEntityIdListFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_hitTargetEntityIdList_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> hitTargetEntityIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> HitTargetEntityIdList {
      get { return hitTargetEntityIdList_; }
    }

    /// <summary>Field number for the "skill_index" field.</summary>
    public const int SkillIndexFieldNumber = 6;
    private uint skillIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SkillIndex {
      get { return skillIndex_; }
      set {
        skillIndex_ = value;
      }
    }

    /// <summary>Field number for the "cast_entity_id" field.</summary>
    public const int CastEntityIdFieldNumber = 8;
    private uint castEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CastEntityId {
      get { return castEntityId_; }
      set {
        castEntityId_ = value;
      }
    }

    /// <summary>Field number for the "dynamic_values" field.</summary>
    public const int DynamicValuesFieldNumber = 11;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.EKCFNICBIHJ> _repeated_dynamicValues_codec
        = pb::FieldCodec.ForMessage(90, global::EggLink.DanhengServer.Proto.EKCFNICBIHJ.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EKCFNICBIHJ> dynamicValues_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EKCFNICBIHJ>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.EKCFNICBIHJ> DynamicValues {
      get { return dynamicValues_; }
    }

    /// <summary>Field number for the "attacked_by_entity_id" field.</summary>
    public const int AttackedByEntityIdFieldNumber = 1;
    private uint attackedByEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AttackedByEntityId {
      get { return attackedByEntityId_; }
      set {
        attackedByEntityId_ = value;
      }
    }

    /// <summary>Field number for the "skill_extra_tags" field.</summary>
    public const int SkillExtraTagsFieldNumber = 3;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.SkillExtraTag> _repeated_skillExtraTags_codec
        = pb::FieldCodec.ForEnum(26, x => (int) x, x => (global::EggLink.DanhengServer.Proto.SkillExtraTag) x);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SkillExtraTag> skillExtraTags_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SkillExtraTag>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.SkillExtraTag> SkillExtraTags {
      get { return skillExtraTags_; }
    }

    /// <summary>Field number for the "target_motion" field.</summary>
    public const int TargetMotionFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.MotionInfo targetMotion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MotionInfo TargetMotion {
      get { return targetMotion_; }
      set {
        targetMotion_ = value;
      }
    }

    /// <summary>Field number for the "hit_monster_entity_id_list" field.</summary>
    public const int HitMonsterEntityIdListFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_hitMonsterEntityIdList_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> hitMonsterEntityIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> HitMonsterEntityIdList {
      get { return hitMonsterEntityIdList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneCastSkillCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneCastSkillCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!assistMonsterEntityIdList_.Equals(other.assistMonsterEntityIdList_)) return false;
      if (MCKNHCGNOGF != other.MCKNHCGNOGF) return false;
      if(!hitTargetEntityIdList_.Equals(other.hitTargetEntityIdList_)) return false;
      if (SkillIndex != other.SkillIndex) return false;
      if (CastEntityId != other.CastEntityId) return false;
      if(!dynamicValues_.Equals(other.dynamicValues_)) return false;
      if (AttackedByEntityId != other.AttackedByEntityId) return false;
      if(!skillExtraTags_.Equals(other.skillExtraTags_)) return false;
      if (!object.Equals(TargetMotion, other.TargetMotion)) return false;
      if(!hitMonsterEntityIdList_.Equals(other.hitMonsterEntityIdList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= assistMonsterEntityIdList_.GetHashCode();
      if (MCKNHCGNOGF != 0) hash ^= MCKNHCGNOGF.GetHashCode();
      hash ^= hitTargetEntityIdList_.GetHashCode();
      if (SkillIndex != 0) hash ^= SkillIndex.GetHashCode();
      if (CastEntityId != 0) hash ^= CastEntityId.GetHashCode();
      hash ^= dynamicValues_.GetHashCode();
      if (AttackedByEntityId != 0) hash ^= AttackedByEntityId.GetHashCode();
      hash ^= skillExtraTags_.GetHashCode();
      if (targetMotion_ != null) hash ^= TargetMotion.GetHashCode();
      hash ^= hitMonsterEntityIdList_.GetHashCode();
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
      if (AttackedByEntityId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(AttackedByEntityId);
      }
      if (MCKNHCGNOGF != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MCKNHCGNOGF);
      }
      skillExtraTags_.WriteTo(output, _repeated_skillExtraTags_codec);
      if (SkillIndex != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SkillIndex);
      }
      if (CastEntityId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CastEntityId);
      }
      hitTargetEntityIdList_.WriteTo(output, _repeated_hitTargetEntityIdList_codec);
      dynamicValues_.WriteTo(output, _repeated_dynamicValues_codec);
      hitMonsterEntityIdList_.WriteTo(output, _repeated_hitMonsterEntityIdList_codec);
      assistMonsterEntityIdList_.WriteTo(output, _repeated_assistMonsterEntityIdList_codec);
      if (targetMotion_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(TargetMotion);
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
      if (AttackedByEntityId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(AttackedByEntityId);
      }
      if (MCKNHCGNOGF != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MCKNHCGNOGF);
      }
      skillExtraTags_.WriteTo(ref output, _repeated_skillExtraTags_codec);
      if (SkillIndex != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SkillIndex);
      }
      if (CastEntityId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CastEntityId);
      }
      hitTargetEntityIdList_.WriteTo(ref output, _repeated_hitTargetEntityIdList_codec);
      dynamicValues_.WriteTo(ref output, _repeated_dynamicValues_codec);
      hitMonsterEntityIdList_.WriteTo(ref output, _repeated_hitMonsterEntityIdList_codec);
      assistMonsterEntityIdList_.WriteTo(ref output, _repeated_assistMonsterEntityIdList_codec);
      if (targetMotion_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(TargetMotion);
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
      size += assistMonsterEntityIdList_.CalculateSize(_repeated_assistMonsterEntityIdList_codec);
      if (MCKNHCGNOGF != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MCKNHCGNOGF);
      }
      size += hitTargetEntityIdList_.CalculateSize(_repeated_hitTargetEntityIdList_codec);
      if (SkillIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SkillIndex);
      }
      if (CastEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CastEntityId);
      }
      size += dynamicValues_.CalculateSize(_repeated_dynamicValues_codec);
      if (AttackedByEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AttackedByEntityId);
      }
      size += skillExtraTags_.CalculateSize(_repeated_skillExtraTags_codec);
      if (targetMotion_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TargetMotion);
      }
      size += hitMonsterEntityIdList_.CalculateSize(_repeated_hitMonsterEntityIdList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneCastSkillCsReq other) {
      if (other == null) {
        return;
      }
      assistMonsterEntityIdList_.Add(other.assistMonsterEntityIdList_);
      if (other.MCKNHCGNOGF != 0) {
        MCKNHCGNOGF = other.MCKNHCGNOGF;
      }
      hitTargetEntityIdList_.Add(other.hitTargetEntityIdList_);
      if (other.SkillIndex != 0) {
        SkillIndex = other.SkillIndex;
      }
      if (other.CastEntityId != 0) {
        CastEntityId = other.CastEntityId;
      }
      dynamicValues_.Add(other.dynamicValues_);
      if (other.AttackedByEntityId != 0) {
        AttackedByEntityId = other.AttackedByEntityId;
      }
      skillExtraTags_.Add(other.skillExtraTags_);
      if (other.targetMotion_ != null) {
        if (targetMotion_ == null) {
          TargetMotion = new global::EggLink.DanhengServer.Proto.MotionInfo();
        }
        TargetMotion.MergeFrom(other.TargetMotion);
      }
      hitMonsterEntityIdList_.Add(other.hitMonsterEntityIdList_);
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
            AttackedByEntityId = input.ReadUInt32();
            break;
          }
          case 16: {
            MCKNHCGNOGF = input.ReadUInt32();
            break;
          }
          case 26:
          case 24: {
            skillExtraTags_.AddEntriesFrom(input, _repeated_skillExtraTags_codec);
            break;
          }
          case 48: {
            SkillIndex = input.ReadUInt32();
            break;
          }
          case 64: {
            CastEntityId = input.ReadUInt32();
            break;
          }
          case 74:
          case 72: {
            hitTargetEntityIdList_.AddEntriesFrom(input, _repeated_hitTargetEntityIdList_codec);
            break;
          }
          case 90: {
            dynamicValues_.AddEntriesFrom(input, _repeated_dynamicValues_codec);
            break;
          }
          case 106:
          case 104: {
            hitMonsterEntityIdList_.AddEntriesFrom(input, _repeated_hitMonsterEntityIdList_codec);
            break;
          }
          case 114:
          case 112: {
            assistMonsterEntityIdList_.AddEntriesFrom(input, _repeated_assistMonsterEntityIdList_codec);
            break;
          }
          case 122: {
            if (targetMotion_ == null) {
              TargetMotion = new global::EggLink.DanhengServer.Proto.MotionInfo();
            }
            input.ReadMessage(TargetMotion);
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
            AttackedByEntityId = input.ReadUInt32();
            break;
          }
          case 16: {
            MCKNHCGNOGF = input.ReadUInt32();
            break;
          }
          case 26:
          case 24: {
            skillExtraTags_.AddEntriesFrom(ref input, _repeated_skillExtraTags_codec);
            break;
          }
          case 48: {
            SkillIndex = input.ReadUInt32();
            break;
          }
          case 64: {
            CastEntityId = input.ReadUInt32();
            break;
          }
          case 74:
          case 72: {
            hitTargetEntityIdList_.AddEntriesFrom(ref input, _repeated_hitTargetEntityIdList_codec);
            break;
          }
          case 90: {
            dynamicValues_.AddEntriesFrom(ref input, _repeated_dynamicValues_codec);
            break;
          }
          case 106:
          case 104: {
            hitMonsterEntityIdList_.AddEntriesFrom(ref input, _repeated_hitMonsterEntityIdList_codec);
            break;
          }
          case 114:
          case 112: {
            assistMonsterEntityIdList_.AddEntriesFrom(ref input, _repeated_assistMonsterEntityIdList_codec);
            break;
          }
          case 122: {
            if (targetMotion_ == null) {
              TargetMotion = new global::EggLink.DanhengServer.Proto.MotionInfo();
            }
            input.ReadMessage(TargetMotion);
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
