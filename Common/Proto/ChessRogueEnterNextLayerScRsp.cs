// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueEnterNextLayerScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueEnterNextLayerScRsp.proto</summary>
  public static partial class ChessRogueEnterNextLayerScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueEnterNextLayerScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueEnterNextLayerScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNDaGVzc1JvZ3VlRW50ZXJOZXh0TGF5ZXJTY1JzcC5wcm90bxoRTUFQRklE",
            "R0VHR0MucHJvdG8aGENoZXNzUm9ndWVHYW1lSW5mby5wcm90bxoYQ2hlc3NS",
            "b2d1ZUNlbGxJbmZvLnByb3RvGhRDaGVzc1JvZ3VlSW5mby5wcm90byLOAQod",
            "Q2hlc3NSb2d1ZUVudGVyTmV4dExheWVyU2NSc3ASLAoPcm9ndWVfZ2FtZV9p",
            "bmZvGAEgASgLMhMuQ2hlc3NSb2d1ZUdhbWVJbmZvEiMKCnJvZ3VlX2luZm8Y",
            "CyABKAsyDy5DaGVzc1JvZ3VlSW5mbxImCgljZWxsX2luZm8YDiABKAsyEy5D",
            "aGVzc1JvZ3VlQ2VsbEluZm8SDwoHcmV0Y29kZRgFIAEoDRIhCgtPTkpGQ05F",
            "QURMShgIIAEoCzIMLk1BUEZJREdFR0dDQh6qAhtFZ2dMaW5rLkRhbmhlbmdT",
            "ZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.MAPFIDGEGGCReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueGameInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueCellInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueEnterNextLayerScRsp), global::EggLink.DanhengServer.Proto.ChessRogueEnterNextLayerScRsp.Parser, new[]{ "RogueGameInfo", "RogueInfo", "CellInfo", "Retcode", "ONJFCNEADLJ" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueEnterNextLayerScRsp : pb::IMessage<ChessRogueEnterNextLayerScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueEnterNextLayerScRsp> _parser = new pb::MessageParser<ChessRogueEnterNextLayerScRsp>(() => new ChessRogueEnterNextLayerScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueEnterNextLayerScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueEnterNextLayerScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueEnterNextLayerScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueEnterNextLayerScRsp(ChessRogueEnterNextLayerScRsp other) : this() {
      rogueGameInfo_ = other.rogueGameInfo_ != null ? other.rogueGameInfo_.Clone() : null;
      rogueInfo_ = other.rogueInfo_ != null ? other.rogueInfo_.Clone() : null;
      cellInfo_ = other.cellInfo_ != null ? other.cellInfo_.Clone() : null;
      retcode_ = other.retcode_;
      oNJFCNEADLJ_ = other.oNJFCNEADLJ_ != null ? other.oNJFCNEADLJ_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueEnterNextLayerScRsp Clone() {
      return new ChessRogueEnterNextLayerScRsp(this);
    }

    /// <summary>Field number for the "rogue_game_info" field.</summary>
    public const int RogueGameInfoFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.ChessRogueGameInfo rogueGameInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueGameInfo RogueGameInfo {
      get { return rogueGameInfo_; }
      set {
        rogueGameInfo_ = value;
      }
    }

    /// <summary>Field number for the "rogue_info" field.</summary>
    public const int RogueInfoFieldNumber = 11;
    private global::EggLink.DanhengServer.Proto.ChessRogueInfo rogueInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueInfo RogueInfo {
      get { return rogueInfo_; }
      set {
        rogueInfo_ = value;
      }
    }

    /// <summary>Field number for the "cell_info" field.</summary>
    public const int CellInfoFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.ChessRogueCellInfo cellInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueCellInfo CellInfo {
      get { return cellInfo_; }
      set {
        cellInfo_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 5;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "ONJFCNEADLJ" field.</summary>
    public const int ONJFCNEADLJFieldNumber = 8;
    private global::EggLink.DanhengServer.Proto.MAPFIDGEGGC oNJFCNEADLJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MAPFIDGEGGC ONJFCNEADLJ {
      get { return oNJFCNEADLJ_; }
      set {
        oNJFCNEADLJ_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueEnterNextLayerScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueEnterNextLayerScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RogueGameInfo, other.RogueGameInfo)) return false;
      if (!object.Equals(RogueInfo, other.RogueInfo)) return false;
      if (!object.Equals(CellInfo, other.CellInfo)) return false;
      if (Retcode != other.Retcode) return false;
      if (!object.Equals(ONJFCNEADLJ, other.ONJFCNEADLJ)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (rogueGameInfo_ != null) hash ^= RogueGameInfo.GetHashCode();
      if (rogueInfo_ != null) hash ^= RogueInfo.GetHashCode();
      if (cellInfo_ != null) hash ^= CellInfo.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (oNJFCNEADLJ_ != null) hash ^= ONJFCNEADLJ.GetHashCode();
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
      if (rogueGameInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(RogueGameInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Retcode);
      }
      if (oNJFCNEADLJ_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(ONJFCNEADLJ);
      }
      if (rogueInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(RogueInfo);
      }
      if (cellInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(CellInfo);
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
      if (rogueGameInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(RogueGameInfo);
      }
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Retcode);
      }
      if (oNJFCNEADLJ_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(ONJFCNEADLJ);
      }
      if (rogueInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(RogueInfo);
      }
      if (cellInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(CellInfo);
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
      if (rogueGameInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueGameInfo);
      }
      if (rogueInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RogueInfo);
      }
      if (cellInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CellInfo);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (oNJFCNEADLJ_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ONJFCNEADLJ);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueEnterNextLayerScRsp other) {
      if (other == null) {
        return;
      }
      if (other.rogueGameInfo_ != null) {
        if (rogueGameInfo_ == null) {
          RogueGameInfo = new global::EggLink.DanhengServer.Proto.ChessRogueGameInfo();
        }
        RogueGameInfo.MergeFrom(other.RogueGameInfo);
      }
      if (other.rogueInfo_ != null) {
        if (rogueInfo_ == null) {
          RogueInfo = new global::EggLink.DanhengServer.Proto.ChessRogueInfo();
        }
        RogueInfo.MergeFrom(other.RogueInfo);
      }
      if (other.cellInfo_ != null) {
        if (cellInfo_ == null) {
          CellInfo = new global::EggLink.DanhengServer.Proto.ChessRogueCellInfo();
        }
        CellInfo.MergeFrom(other.CellInfo);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.oNJFCNEADLJ_ != null) {
        if (oNJFCNEADLJ_ == null) {
          ONJFCNEADLJ = new global::EggLink.DanhengServer.Proto.MAPFIDGEGGC();
        }
        ONJFCNEADLJ.MergeFrom(other.ONJFCNEADLJ);
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
            if (rogueGameInfo_ == null) {
              RogueGameInfo = new global::EggLink.DanhengServer.Proto.ChessRogueGameInfo();
            }
            input.ReadMessage(RogueGameInfo);
            break;
          }
          case 40: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 66: {
            if (oNJFCNEADLJ_ == null) {
              ONJFCNEADLJ = new global::EggLink.DanhengServer.Proto.MAPFIDGEGGC();
            }
            input.ReadMessage(ONJFCNEADLJ);
            break;
          }
          case 90: {
            if (rogueInfo_ == null) {
              RogueInfo = new global::EggLink.DanhengServer.Proto.ChessRogueInfo();
            }
            input.ReadMessage(RogueInfo);
            break;
          }
          case 114: {
            if (cellInfo_ == null) {
              CellInfo = new global::EggLink.DanhengServer.Proto.ChessRogueCellInfo();
            }
            input.ReadMessage(CellInfo);
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
            if (rogueGameInfo_ == null) {
              RogueGameInfo = new global::EggLink.DanhengServer.Proto.ChessRogueGameInfo();
            }
            input.ReadMessage(RogueGameInfo);
            break;
          }
          case 40: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 66: {
            if (oNJFCNEADLJ_ == null) {
              ONJFCNEADLJ = new global::EggLink.DanhengServer.Proto.MAPFIDGEGGC();
            }
            input.ReadMessage(ONJFCNEADLJ);
            break;
          }
          case 90: {
            if (rogueInfo_ == null) {
              RogueInfo = new global::EggLink.DanhengServer.Proto.ChessRogueInfo();
            }
            input.ReadMessage(RogueInfo);
            break;
          }
          case 114: {
            if (cellInfo_ == null) {
              CellInfo = new global::EggLink.DanhengServer.Proto.ChessRogueCellInfo();
            }
            input.ReadMessage(CellInfo);
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
