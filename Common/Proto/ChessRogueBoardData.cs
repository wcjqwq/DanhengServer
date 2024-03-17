// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessRogueBoardData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ChessRogueBoardData.proto</summary>
  public static partial class ChessRogueBoardDataReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessRogueBoardData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessRogueBoardDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlDaGVzc1JvZ3VlQm9hcmREYXRhLnByb3RvGhBDZWxsU3RhdHVzLnByb3Rv",
            "GhZDaGVzc0JvYXJkTGF5b3V0LnByb3RvGhVDaGVzc1JvZ3VlVGhlbWUucHJv",
            "dG8aFUhpc3RvcnlDZWxsRGF0YS5wcm90byL+AQoTQ2hlc3NSb2d1ZUJvYXJk",
            "RGF0YRImCgxoaXN0b3J5X2NlbGwYBCADKAsyEC5IaXN0b3J5Q2VsbERhdGES",
            "EwoLTERMSU9JRU1ITEoYAiABKA0SIAoLY2VsbF9zdGF0dXMYByABKA4yCy5D",
            "ZWxsU3RhdHVzEhMKC0xITEpISkVLTUZKGA0gASgNEicKDGJvYXJkX2xheW91",
            "dBgPIAEoCzIRLkNoZXNzQm9hcmRMYXlvdXQSJQoLTUhJRE1DQklPQkcYASAB",
            "KAsyEC5DaGVzc1JvZ3VlVGhlbWUSIwobYWxsb3dlZF9zZWxlY3RfY2VsbF9p",
            "ZF9saXN0GAwgAygNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.CellStatusReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessBoardLayoutReflection.Descriptor, global::EggLink.DanhengServer.Proto.ChessRogueThemeReflection.Descriptor, global::EggLink.DanhengServer.Proto.HistoryCellDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ChessRogueBoardData), global::EggLink.DanhengServer.Proto.ChessRogueBoardData.Parser, new[]{ "HistoryCell", "LDLIOIEMHLJ", "CellStatus", "LHLJHJEKMFJ", "BoardLayout", "MHIDMCBIOBG", "AllowedSelectCellIdList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ChessRogueBoardData : pb::IMessage<ChessRogueBoardData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessRogueBoardData> _parser = new pb::MessageParser<ChessRogueBoardData>(() => new ChessRogueBoardData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessRogueBoardData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ChessRogueBoardDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueBoardData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueBoardData(ChessRogueBoardData other) : this() {
      historyCell_ = other.historyCell_.Clone();
      lDLIOIEMHLJ_ = other.lDLIOIEMHLJ_;
      cellStatus_ = other.cellStatus_;
      lHLJHJEKMFJ_ = other.lHLJHJEKMFJ_;
      boardLayout_ = other.boardLayout_ != null ? other.boardLayout_.Clone() : null;
      mHIDMCBIOBG_ = other.mHIDMCBIOBG_ != null ? other.mHIDMCBIOBG_.Clone() : null;
      allowedSelectCellIdList_ = other.allowedSelectCellIdList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessRogueBoardData Clone() {
      return new ChessRogueBoardData(this);
    }

    /// <summary>Field number for the "history_cell" field.</summary>
    public const int HistoryCellFieldNumber = 4;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.HistoryCellData> _repeated_historyCell_codec
        = pb::FieldCodec.ForMessage(34, global::EggLink.DanhengServer.Proto.HistoryCellData.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HistoryCellData> historyCell_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HistoryCellData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.HistoryCellData> HistoryCell {
      get { return historyCell_; }
    }

    /// <summary>Field number for the "LDLIOIEMHLJ" field.</summary>
    public const int LDLIOIEMHLJFieldNumber = 2;
    private uint lDLIOIEMHLJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LDLIOIEMHLJ {
      get { return lDLIOIEMHLJ_; }
      set {
        lDLIOIEMHLJ_ = value;
      }
    }

    /// <summary>Field number for the "cell_status" field.</summary>
    public const int CellStatusFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.CellStatus cellStatus_ = global::EggLink.DanhengServer.Proto.CellStatus.Idle;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CellStatus CellStatus {
      get { return cellStatus_; }
      set {
        cellStatus_ = value;
      }
    }

    /// <summary>Field number for the "LHLJHJEKMFJ" field.</summary>
    public const int LHLJHJEKMFJFieldNumber = 13;
    private uint lHLJHJEKMFJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LHLJHJEKMFJ {
      get { return lHLJHJEKMFJ_; }
      set {
        lHLJHJEKMFJ_ = value;
      }
    }

    /// <summary>Field number for the "board_layout" field.</summary>
    public const int BoardLayoutFieldNumber = 15;
    private global::EggLink.DanhengServer.Proto.ChessBoardLayout boardLayout_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessBoardLayout BoardLayout {
      get { return boardLayout_; }
      set {
        boardLayout_ = value;
      }
    }

    /// <summary>Field number for the "MHIDMCBIOBG" field.</summary>
    public const int MHIDMCBIOBGFieldNumber = 1;
    private global::EggLink.DanhengServer.Proto.ChessRogueTheme mHIDMCBIOBG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ChessRogueTheme MHIDMCBIOBG {
      get { return mHIDMCBIOBG_; }
      set {
        mHIDMCBIOBG_ = value;
      }
    }

    /// <summary>Field number for the "allowed_select_cell_id_list" field.</summary>
    public const int AllowedSelectCellIdListFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_allowedSelectCellIdList_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> allowedSelectCellIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> AllowedSelectCellIdList {
      get { return allowedSelectCellIdList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessRogueBoardData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessRogueBoardData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!historyCell_.Equals(other.historyCell_)) return false;
      if (LDLIOIEMHLJ != other.LDLIOIEMHLJ) return false;
      if (CellStatus != other.CellStatus) return false;
      if (LHLJHJEKMFJ != other.LHLJHJEKMFJ) return false;
      if (!object.Equals(BoardLayout, other.BoardLayout)) return false;
      if (!object.Equals(MHIDMCBIOBG, other.MHIDMCBIOBG)) return false;
      if(!allowedSelectCellIdList_.Equals(other.allowedSelectCellIdList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= historyCell_.GetHashCode();
      if (LDLIOIEMHLJ != 0) hash ^= LDLIOIEMHLJ.GetHashCode();
      if (CellStatus != global::EggLink.DanhengServer.Proto.CellStatus.Idle) hash ^= CellStatus.GetHashCode();
      if (LHLJHJEKMFJ != 0) hash ^= LHLJHJEKMFJ.GetHashCode();
      if (boardLayout_ != null) hash ^= BoardLayout.GetHashCode();
      if (mHIDMCBIOBG_ != null) hash ^= MHIDMCBIOBG.GetHashCode();
      hash ^= allowedSelectCellIdList_.GetHashCode();
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
      if (mHIDMCBIOBG_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(MHIDMCBIOBG);
      }
      if (LDLIOIEMHLJ != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(LDLIOIEMHLJ);
      }
      historyCell_.WriteTo(output, _repeated_historyCell_codec);
      if (CellStatus != global::EggLink.DanhengServer.Proto.CellStatus.Idle) {
        output.WriteRawTag(56);
        output.WriteEnum((int) CellStatus);
      }
      allowedSelectCellIdList_.WriteTo(output, _repeated_allowedSelectCellIdList_codec);
      if (LHLJHJEKMFJ != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(LHLJHJEKMFJ);
      }
      if (boardLayout_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(BoardLayout);
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
      if (mHIDMCBIOBG_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(MHIDMCBIOBG);
      }
      if (LDLIOIEMHLJ != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(LDLIOIEMHLJ);
      }
      historyCell_.WriteTo(ref output, _repeated_historyCell_codec);
      if (CellStatus != global::EggLink.DanhengServer.Proto.CellStatus.Idle) {
        output.WriteRawTag(56);
        output.WriteEnum((int) CellStatus);
      }
      allowedSelectCellIdList_.WriteTo(ref output, _repeated_allowedSelectCellIdList_codec);
      if (LHLJHJEKMFJ != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(LHLJHJEKMFJ);
      }
      if (boardLayout_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(BoardLayout);
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
      size += historyCell_.CalculateSize(_repeated_historyCell_codec);
      if (LDLIOIEMHLJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LDLIOIEMHLJ);
      }
      if (CellStatus != global::EggLink.DanhengServer.Proto.CellStatus.Idle) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CellStatus);
      }
      if (LHLJHJEKMFJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LHLJHJEKMFJ);
      }
      if (boardLayout_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BoardLayout);
      }
      if (mHIDMCBIOBG_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MHIDMCBIOBG);
      }
      size += allowedSelectCellIdList_.CalculateSize(_repeated_allowedSelectCellIdList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessRogueBoardData other) {
      if (other == null) {
        return;
      }
      historyCell_.Add(other.historyCell_);
      if (other.LDLIOIEMHLJ != 0) {
        LDLIOIEMHLJ = other.LDLIOIEMHLJ;
      }
      if (other.CellStatus != global::EggLink.DanhengServer.Proto.CellStatus.Idle) {
        CellStatus = other.CellStatus;
      }
      if (other.LHLJHJEKMFJ != 0) {
        LHLJHJEKMFJ = other.LHLJHJEKMFJ;
      }
      if (other.boardLayout_ != null) {
        if (boardLayout_ == null) {
          BoardLayout = new global::EggLink.DanhengServer.Proto.ChessBoardLayout();
        }
        BoardLayout.MergeFrom(other.BoardLayout);
      }
      if (other.mHIDMCBIOBG_ != null) {
        if (mHIDMCBIOBG_ == null) {
          MHIDMCBIOBG = new global::EggLink.DanhengServer.Proto.ChessRogueTheme();
        }
        MHIDMCBIOBG.MergeFrom(other.MHIDMCBIOBG);
      }
      allowedSelectCellIdList_.Add(other.allowedSelectCellIdList_);
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
            if (mHIDMCBIOBG_ == null) {
              MHIDMCBIOBG = new global::EggLink.DanhengServer.Proto.ChessRogueTheme();
            }
            input.ReadMessage(MHIDMCBIOBG);
            break;
          }
          case 16: {
            LDLIOIEMHLJ = input.ReadUInt32();
            break;
          }
          case 34: {
            historyCell_.AddEntriesFrom(input, _repeated_historyCell_codec);
            break;
          }
          case 56: {
            CellStatus = (global::EggLink.DanhengServer.Proto.CellStatus) input.ReadEnum();
            break;
          }
          case 98:
          case 96: {
            allowedSelectCellIdList_.AddEntriesFrom(input, _repeated_allowedSelectCellIdList_codec);
            break;
          }
          case 104: {
            LHLJHJEKMFJ = input.ReadUInt32();
            break;
          }
          case 122: {
            if (boardLayout_ == null) {
              BoardLayout = new global::EggLink.DanhengServer.Proto.ChessBoardLayout();
            }
            input.ReadMessage(BoardLayout);
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
            if (mHIDMCBIOBG_ == null) {
              MHIDMCBIOBG = new global::EggLink.DanhengServer.Proto.ChessRogueTheme();
            }
            input.ReadMessage(MHIDMCBIOBG);
            break;
          }
          case 16: {
            LDLIOIEMHLJ = input.ReadUInt32();
            break;
          }
          case 34: {
            historyCell_.AddEntriesFrom(ref input, _repeated_historyCell_codec);
            break;
          }
          case 56: {
            CellStatus = (global::EggLink.DanhengServer.Proto.CellStatus) input.ReadEnum();
            break;
          }
          case 98:
          case 96: {
            allowedSelectCellIdList_.AddEntriesFrom(ref input, _repeated_allowedSelectCellIdList_codec);
            break;
          }
          case 104: {
            LHLJHJEKMFJ = input.ReadUInt32();
            break;
          }
          case 122: {
            if (boardLayout_ == null) {
              BoardLayout = new global::EggLink.DanhengServer.Proto.ChessBoardLayout();
            }
            input.ReadMessage(BoardLayout);
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
