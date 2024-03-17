// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueItemInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueItemInfo.proto</summary>
  public static partial class ChessRogueItemInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueItemInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueItemInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhDaGVzc1JvZ3VlSXRlbUluZm8ucHJvdG8aF0NoZXNzR2FtZUFlb25JbmZv",
            "LnByb3RvGh9DaGVzc1JvZ3VlVmlydHVhbEl0ZW1JbmZvLnByb3RvGhFFQ0JL",
            "RExKSE9MTi5wcm90bxobQ2hlc3NSb2d1ZU1pcmFjbGVJbmZvLnByb3RvGhhD",
            "aGVzc1JvZ3VlQnVmZkluZm8ucHJvdG8i+AEKEkNoZXNzUm9ndWVJdGVtSW5m",
            "bxIrCg5nYW1lX2J1ZmZfaW5mbxgIIAEoCzITLkNoZXNzUm9ndWVCdWZmSW5m",
            "bxIxChFnYW1lX21pcmFjbGVfaW5mbxgDIAEoCzIWLkNoZXNzUm9ndWVNaXJh",
            "Y2xlSW5mbxIyCg5nYW1lX2l0ZW1faW5mbxgLIAEoCzIaLkNoZXNzUm9ndWVW",
            "aXJ0dWFsSXRlbUluZm8SKwoPcm9ndWVfYWVvbl9pbmZvGA8gASgLMhIuQ2hl",
            "c3NHYW1lQWVvbkluZm8SIQoLT0tNSkZFSkpJR04YBCABKAsyDC5FQ0JLRExK",
            "SE9MTkIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ChessGameAeonInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueVirtualItemInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ECBKDLJHOLNReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueBuffInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueItemInfo), global::EggLink.DanhengServer.Proto.ChessRogueItemInfo.Parser, new[]{ "GameBuffInfo", "GameMiracleInfo", "GameItemInfo", "RogueAeonInfo", "OKMJFEJJIGN" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueItemInfo : pb::IMessage<ChessRogueItemInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueItemInfo> _parser = new pb::MessageParser<ChessRogueItemInfo>(() => new ChessRogueItemInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueItemInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueItemInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueItemInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueItemInfo(ChessRogueItemInfo other) : this() {
      gameBuffInfo_ = other.gameBuffInfo_ != null ? other.gameBuffInfo_.Clone() : null;
      gameMiracleInfo_ = other.gameMiracleInfo_ != null ? other.gameMiracleInfo_.Clone() : null;
      gameItemInfo_ = other.gameItemInfo_ != null ? other.gameItemInfo_.Clone() : null;
      rogueAeonInfo_ = other.rogueAeonInfo_ != null ? other.rogueAeonInfo_.Clone() : null;
      oKMJFEJJIGN_ = other.oKMJFEJJIGN_ != null ? other.oKMJFEJJIGN_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueItemInfo Clone() {
      return new ChessRogueItemInfo(this);
    }

    /// <summary>Field number for the "game_buff_info" field.</summary>
    public const int GameBuffInfoFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.ChessRogueBuffInfo gameBuffInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueBuffInfo GameBuffInfo {
      get { return gameBuffInfo_; }
      set {
        gameBuffInfo_ = value;
      }
    }

    /// <summary>Field number for the "game_miracle_info" field.</summary>
    public const int GameMiracleInfoFieldNumber = 3;
    private global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfo gameMiracleInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfo GameMiracleInfo {
      get { return gameMiracleInfo_; }
      set {
        gameMiracleInfo_ = value;
      }
    }

    /// <summary>Field number for the "game_item_info" field.</summary>
    public const int GameItemInfoFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.ChessRogueVirtualItemInfo gameItemInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueVirtualItemInfo GameItemInfo {
      get { return gameItemInfo_; }
      set {
        gameItemInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_aeon_info" field.</summary>
    public const int RogueAeonInfoFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.ChessGameAeonInfo rogueAeonInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessGameAeonInfo RogueAeonInfo {
      get { return rogueAeonInfo_; }
      set {
        rogueAeonInfo_ = value;
      }
    }

    /// <summary>Field number for the "OKMJFEJJIGN" field.</summary>
    public const int OKMJFEJJIGNFieldNumber = 4;
    private global::EggLink.DanhengServer.Proto.ECBKDLJHOLN oKMJFEJJIGN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ECBKDLJHOLN OKMJFEJJIGN {
      get { return oKMJFEJJIGN_; }
      set {
        oKMJFEJJIGN_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueItemInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueItemInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(GameBuffInfo, other.GameBuffInfo)) return false;
      if (!object.Equals(GameMiracleInfo, other.GameMiracleInfo)) return false;
      if (!object.Equals(GameItemInfo, other.GameItemInfo)) return false;
      if (!object.Equals(RogueAeonInfo, other.RogueAeonInfo)) return false;
      if (!object.Equals(OKMJFEJJIGN, other.OKMJFEJJIGN)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (gameBuffInfo_ != null) hash ^= GameBuffInfo.GetHashCode();
      if (gameMiracleInfo_ != null) hash ^= GameMiracleInfo.GetHashCode();
      if (gameItemInfo_ != null) hash ^= GameItemInfo.GetHashCode();
      if (rogueAeonInfo_ != null) hash ^= RogueAeonInfo.GetHashCode();
      if (oKMJFEJJIGN_ != null) hash ^= OKMJFEJJIGN.GetHashCode();
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
      if (gameMiracleInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(GameMiracleInfo);
      }
      if (oKMJFEJJIGN_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(OKMJFEJJIGN);
      }
      if (gameBuffInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(GameBuffInfo);
      }
      if (gameItemInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(GameItemInfo);
      }
      if (rogueAeonInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(RogueAeonInfo);
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
      if (gameMiracleInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(GameMiracleInfo);
      }
      if (oKMJFEJJIGN_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(OKMJFEJJIGN);
      }
      if (gameBuffInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(GameBuffInfo);
      }
      if (gameItemInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(GameItemInfo);
      }
      if (rogueAeonInfo_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(RogueAeonInfo);
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
      if (gameBuffInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GameBuffInfo);
      }
      if (gameMiracleInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GameMiracleInfo);
      }
      if (gameItemInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GameItemInfo);
      }
      if (rogueAeonInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueAeonInfo);
      }
      if (oKMJFEJJIGN_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OKMJFEJJIGN);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueItemInfo other) {
      if (other == null) {
        return;
      }
      if (other.gameBuffInfo_ != null) {
        if (gameBuffInfo_ == null) {
          GameBuffInfo = new global::EggLink.DanhengServer.Proto.ChessRogueBuffInfo();
        }
        GameBuffInfo.MergeFrom(other.GameBuffInfo);
      }
      if (other.gameMiracleInfo_ != null) {
        if (gameMiracleInfo_ == null) {
          GameMiracleInfo = new global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfo();
        }
        GameMiracleInfo.MergeFrom(other.GameMiracleInfo);
      }
      if (other.gameItemInfo_ != null) {
        if (gameItemInfo_ == null) {
          GameItemInfo = new global::EggLink.DanhengServer.Proto.ChessRogueVirtualItemInfo();
        }
        GameItemInfo.MergeFrom(other.GameItemInfo);
      }
      if (other.rogueAeonInfo_ != null) {
        if (rogueAeonInfo_ == null) {
          RogueAeonInfo = new global::EggLink.DanhengServer.Proto.ChessGameAeonInfo();
        }
        RogueAeonInfo.MergeFrom(other.RogueAeonInfo);
      }
      if (other.oKMJFEJJIGN_ != null) {
        if (oKMJFEJJIGN_ == null) {
          OKMJFEJJIGN = new global::EggLink.DanhengServer.Proto.ECBKDLJHOLN();
        }
        OKMJFEJJIGN.MergeFrom(other.OKMJFEJJIGN);
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
            if (gameMiracleInfo_ == null) {
              GameMiracleInfo = new global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfo();
            }
            input.ReadMessage(GameMiracleInfo);
            break;
          }
          case 34: {
            if (oKMJFEJJIGN_ == null) {
              OKMJFEJJIGN = new global::EggLink.DanhengServer.Proto.ECBKDLJHOLN();
            }
            input.ReadMessage(OKMJFEJJIGN);
            break;
          }
          case 66: {
            if (gameBuffInfo_ == null) {
              GameBuffInfo = new global::EggLink.DanhengServer.Proto.ChessRogueBuffInfo();
            }
            input.ReadMessage(GameBuffInfo);
            break;
          }
          case 90: {
            if (gameItemInfo_ == null) {
              GameItemInfo = new global::EggLink.DanhengServer.Proto.ChessRogueVirtualItemInfo();
            }
            input.ReadMessage(GameItemInfo);
            break;
          }
          case 122: {
            if (rogueAeonInfo_ == null) {
              RogueAeonInfo = new global::EggLink.DanhengServer.Proto.ChessGameAeonInfo();
            }
            input.ReadMessage(RogueAeonInfo);
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
            if (gameMiracleInfo_ == null) {
              GameMiracleInfo = new global::EggLink.DanhengServer.Proto.ChessRogueMiracleInfo();
            }
            input.ReadMessage(GameMiracleInfo);
            break;
          }
          case 34: {
            if (oKMJFEJJIGN_ == null) {
              OKMJFEJJIGN = new global::EggLink.DanhengServer.Proto.ECBKDLJHOLN();
            }
            input.ReadMessage(OKMJFEJJIGN);
            break;
          }
          case 66: {
            if (gameBuffInfo_ == null) {
              GameBuffInfo = new global::EggLink.DanhengServer.Proto.ChessRogueBuffInfo();
            }
            input.ReadMessage(GameBuffInfo);
            break;
          }
          case 90: {
            if (gameItemInfo_ == null) {
              GameItemInfo = new global::EggLink.DanhengServer.Proto.ChessRogueVirtualItemInfo();
            }
            input.ReadMessage(GameItemInfo);
            break;
          }
          case 122: {
            if (rogueAeonInfo_ == null) {
              RogueAeonInfo = new global::EggLink.DanhengServer.Proto.ChessGameAeonInfo();
            }
            input.ReadMessage(RogueAeonInfo);
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
