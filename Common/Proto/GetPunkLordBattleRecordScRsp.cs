// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetPunkLordBattleRecordScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from GetPunkLordBattleRecordScRsp.proto</summary>
  public static partial class GetPunkLordBattleRecordScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetPunkLordBattleRecordScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetPunkLordBattleRecordScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJHZXRQdW5rTG9yZEJhdHRsZVJlY29yZFNjUnNwLnByb3RvGhpQdW5rTG9y",
            "ZEJhdHRsZVJlcGxheS5wcm90bxoaUHVua0xvcmRCYXR0bGVSZWNvcmQucHJv",
            "dG8aGFB1bmtMb3JkTW9uc3RlcktleS5wcm90byK4AQocR2V0UHVua0xvcmRC",
            "YXR0bGVSZWNvcmRTY1JzcBIqCgtISkJHSkZIREhPRhgGIAMoCzIVLlB1bmtM",
            "b3JkQmF0dGxlUmVwbGF5EigKC0ZKRU1HRklBTUdDGAwgASgLMhMuUHVua0xv",
            "cmRNb25zdGVyS2V5EjEKEmJhdHRsZV9yZWNvcmRfbGlzdBgCIAMoCzIVLlB1",
            "bmtMb3JkQmF0dGxlUmVjb3JkEg8KB3JldGNvZGUYCyABKA1CHqoCG0VnZ0xp",
            "bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.PunkLordBattleReplayReflection.Descriptor, global::EggLink.DanhengServer.Proto.PunkLordBattleRecordReflection.Descriptor, global::EggLink.DanhengServer.Proto.PunkLordMonsterKeyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.GetPunkLordBattleRecordScRsp), global::EggLink.DanhengServer.Proto.GetPunkLordBattleRecordScRsp.Parser, new[]{ "HJBGJFHDHOF", "FJEMGFIAMGC", "BattleRecordList", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetPunkLordBattleRecordScRsp : pb::IMessage<GetPunkLordBattleRecordScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetPunkLordBattleRecordScRsp> _parser = new pb::MessageParser<GetPunkLordBattleRecordScRsp>(() => new GetPunkLordBattleRecordScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetPunkLordBattleRecordScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.GetPunkLordBattleRecordScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetPunkLordBattleRecordScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetPunkLordBattleRecordScRsp(GetPunkLordBattleRecordScRsp other) : this() {
      hJBGJFHDHOF_ = other.hJBGJFHDHOF_.Clone();
      fJEMGFIAMGC_ = other.fJEMGFIAMGC_ != null ? other.fJEMGFIAMGC_.Clone() : null;
      battleRecordList_ = other.battleRecordList_.Clone();
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetPunkLordBattleRecordScRsp Clone() {
      return new GetPunkLordBattleRecordScRsp(this);
    }

    /// <summary>Field number for the "HJBGJFHDHOF" field.</summary>
    public const int HJBGJFHDHOFFieldNumber = 6;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.PunkLordBattleReplay> _repeated_hJBGJFHDHOF_codec
        = pb::FieldCodec.ForMessage(50, global::EggLink.DanhengServer.Proto.PunkLordBattleReplay.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PunkLordBattleReplay> hJBGJFHDHOF_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PunkLordBattleReplay>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PunkLordBattleReplay> HJBGJFHDHOF {
      get { return hJBGJFHDHOF_; }
    }

    /// <summary>Field number for the "FJEMGFIAMGC" field.</summary>
    public const int FJEMGFIAMGCFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.PunkLordMonsterKey fJEMGFIAMGC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PunkLordMonsterKey FJEMGFIAMGC {
      get { return fJEMGFIAMGC_; }
      set {
        fJEMGFIAMGC_ = value;
      }
    }

    /// <summary>Field number for the "battle_record_list" field.</summary>
    public const int BattleRecordListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.PunkLordBattleRecord> _repeated_battleRecordList_codec
        = pb::FieldCodec.ForMessage(18, global::EggLink.DanhengServer.Proto.PunkLordBattleRecord.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PunkLordBattleRecord> battleRecordList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PunkLordBattleRecord>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.PunkLordBattleRecord> BattleRecordList {
      get { return battleRecordList_; }
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

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetPunkLordBattleRecordScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetPunkLordBattleRecordScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!hJBGJFHDHOF_.Equals(other.hJBGJFHDHOF_)) return false;
      if (!object.Equals(FJEMGFIAMGC, other.FJEMGFIAMGC)) return false;
      if(!battleRecordList_.Equals(other.battleRecordList_)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= hJBGJFHDHOF_.GetHashCode();
      if (fJEMGFIAMGC_ != null) hash ^= FJEMGFIAMGC.GetHashCode();
      hash ^= battleRecordList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      battleRecordList_.WriteTo(output, _repeated_battleRecordList_codec);
      hJBGJFHDHOF_.WriteTo(output, _repeated_hJBGJFHDHOF_codec);
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Retcode);
      }
      if (fJEMGFIAMGC_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(FJEMGFIAMGC);
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
      battleRecordList_.WriteTo(ref output, _repeated_battleRecordList_codec);
      hJBGJFHDHOF_.WriteTo(ref output, _repeated_hJBGJFHDHOF_codec);
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Retcode);
      }
      if (fJEMGFIAMGC_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(FJEMGFIAMGC);
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
      size += hJBGJFHDHOF_.CalculateSize(_repeated_hJBGJFHDHOF_codec);
      if (fJEMGFIAMGC_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FJEMGFIAMGC);
      }
      size += battleRecordList_.CalculateSize(_repeated_battleRecordList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetPunkLordBattleRecordScRsp other) {
      if (other == null) {
        return;
      }
      hJBGJFHDHOF_.Add(other.hJBGJFHDHOF_);
      if (other.fJEMGFIAMGC_ != null) {
        if (fJEMGFIAMGC_ == null) {
          FJEMGFIAMGC = new global::EggLink.DanhengServer.Proto.PunkLordMonsterKey();
        }
        FJEMGFIAMGC.MergeFrom(other.FJEMGFIAMGC);
      }
      battleRecordList_.Add(other.battleRecordList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
          case 18: {
            battleRecordList_.AddEntriesFrom(input, _repeated_battleRecordList_codec);
            break;
          }
          case 50: {
            hJBGJFHDHOF_.AddEntriesFrom(input, _repeated_hJBGJFHDHOF_codec);
            break;
          }
          case 88: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 98: {
            if (fJEMGFIAMGC_ == null) {
              FJEMGFIAMGC = new global::EggLink.DanhengServer.Proto.PunkLordMonsterKey();
            }
            input.ReadMessage(FJEMGFIAMGC);
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
          case 18: {
            battleRecordList_.AddEntriesFrom(ref input, _repeated_battleRecordList_codec);
            break;
          }
          case 50: {
            hJBGJFHDHOF_.AddEntriesFrom(ref input, _repeated_hJBGJFHDHOF_codec);
            break;
          }
          case 88: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 98: {
            if (fJEMGFIAMGC_ == null) {
              FJEMGFIAMGC = new global::EggLink.DanhengServer.Proto.PunkLordMonsterKey();
            }
            input.ReadMessage(FJEMGFIAMGC);
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
