// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HandleRogueCommonPendingActionScRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from HandleRogueCommonPendingActionScRsp.proto</summary>
  public static partial class HandleRogueCommonPendingActionScRspReflection {

    #region Descriptor
    /// <summary>File descriptor for HandleRogueCommonPendingActionScRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HandleRogueCommonPendingActionScRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilIYW5kbGVSb2d1ZUNvbW1vblBlbmRpbmdBY3Rpb25TY1JzcC5wcm90bxoR",
            "SkVLQ09PT09NR1AucHJvdG8aEVBFREZFQ0dCTEFQLnByb3RvGipSb2d1ZU1p",
            "cmFjbGVTZWxlY3RIYW5kbGVBY3Rpb25SZXN1bHQucHJvdG8aEUhJRkVKRUZG",
            "TURNLnByb3RvGhFHTk1OT09BSklKSi5wcm90bxonUm9ndWVCdWZmU2VsZWN0",
            "SGFuZGxlQWN0aW9uUmVzdWx0LnByb3RvGhFQRk5HT1BERk9QTy5wcm90bxoR",
            "T0hJS09FQU5BT00ucHJvdG8aEVBLUElCTUhQRERJLnByb3RvGhFLR05ISEFH",
            "TkpFTC5wcm90byKeBAojSGFuZGxlUm9ndWVDb21tb25QZW5kaW5nQWN0aW9u",
            "U2NSc3ASFgoOcXVldWVfcG9zaXRpb24YDCABKA0SDwoHcmV0Y29kZRgNIAEo",
            "DRIWCg5xdWV1ZV9sb2NhdGlvbhgKIAEoDRI6CgtidWZmX3NlbGVjdBizDyAB",
            "KAsyIi5Sb2d1ZUJ1ZmZTZWxlY3RIYW5kbGVBY3Rpb25SZXN1bHRIABIkCgtO",
            "T01ESVBMT0VBRRirAyABKAsyDC5KRUtDT09PT01HUEgAEiQKC09QQ01MQkNN",
            "RE1PGJQJIAEoCzIMLktHTkhIQUdOSkVMSAASJAoLQk5NQklCQUxBRUYYoAkg",
            "ASgLMgwuUEVERkVDR0JMQVBIABJACg5taXJhY2xlX3NlbGVjdBjKASABKAsy",
            "JS5Sb2d1ZU1pcmFjbGVTZWxlY3RIYW5kbGVBY3Rpb25SZXN1bHRIABIkCgtM",
            "SUhPQ05FT0xGQxjaAyABKAsyDC5QRk5HT1BERk9QT0gAEiQKC0lKQktFT0RO",
            "S01JGNgBIAEoCzIMLk9ISUtPRUFOQU9NSAASJAoLS0hPREJGSE1NT08YtQsg",
            "ASgLMgwuSElGRUpFRkZNRE1IABIkCgtMQUJCTE9OTUJERxjGDCABKAsyDC5H",
            "Tk1OT09BSklKSkgAEiQKC0RDREVFQUJCRU5GGP0NIAEoCzIMLlBLUElCTUhQ",
            "RERJSABCCAoGYWN0aW9uQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv",
            "dG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.JEKCOOOOMGPReflection.Descriptor, global::EggLink.DanhengServer.Proto.PEDFECGBLAPReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueMiracleSelectHandleActionResultReflection.Descriptor, global::EggLink.DanhengServer.Proto.HIFEJEFFMDMReflection.Descriptor, global::EggLink.DanhengServer.Proto.GNMNOOAJIJJReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueBuffSelectHandleActionResultReflection.Descriptor, global::EggLink.DanhengServer.Proto.PFNGOPDFOPOReflection.Descriptor, global::EggLink.DanhengServer.Proto.OHIKOEANAOMReflection.Descriptor, global::EggLink.DanhengServer.Proto.PKPIBMHPDDIReflection.Descriptor, global::EggLink.DanhengServer.Proto.KGNHHAGNJELReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.HandleRogueCommonPendingActionScRsp), global::EggLink.DanhengServer.Proto.HandleRogueCommonPendingActionScRsp.Parser, new[]{ "QueuePosition", "Retcode", "QueueLocation", "BuffSelect", "NOMDIPLOEAE", "OPCMLBCMDMO", "BNMBIBALAEF", "MiracleSelect", "LIHOCNEOLFC", "IJBKEODNKMI", "KHODBFHMMOO", "LABBLONMBDG", "DCDEEABBENF" }, new[]{ "Action" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class HandleRogueCommonPendingActionScRsp : pb::IMessage<HandleRogueCommonPendingActionScRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HandleRogueCommonPendingActionScRsp> _parser = new pb::MessageParser<HandleRogueCommonPendingActionScRsp>(() => new HandleRogueCommonPendingActionScRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HandleRogueCommonPendingActionScRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.HandleRogueCommonPendingActionScRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HandleRogueCommonPendingActionScRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HandleRogueCommonPendingActionScRsp(HandleRogueCommonPendingActionScRsp other) : this() {
      queuePosition_ = other.queuePosition_;
      retcode_ = other.retcode_;
      queueLocation_ = other.queueLocation_;
      switch (other.ActionCase) {
        case ActionOneofCase.BuffSelect:
          BuffSelect = other.BuffSelect.Clone();
          break;
        case ActionOneofCase.NOMDIPLOEAE:
          NOMDIPLOEAE = other.NOMDIPLOEAE.Clone();
          break;
        case ActionOneofCase.OPCMLBCMDMO:
          OPCMLBCMDMO = other.OPCMLBCMDMO.Clone();
          break;
        case ActionOneofCase.BNMBIBALAEF:
          BNMBIBALAEF = other.BNMBIBALAEF.Clone();
          break;
        case ActionOneofCase.MiracleSelect:
          MiracleSelect = other.MiracleSelect.Clone();
          break;
        case ActionOneofCase.LIHOCNEOLFC:
          LIHOCNEOLFC = other.LIHOCNEOLFC.Clone();
          break;
        case ActionOneofCase.IJBKEODNKMI:
          IJBKEODNKMI = other.IJBKEODNKMI.Clone();
          break;
        case ActionOneofCase.KHODBFHMMOO:
          KHODBFHMMOO = other.KHODBFHMMOO.Clone();
          break;
        case ActionOneofCase.LABBLONMBDG:
          LABBLONMBDG = other.LABBLONMBDG.Clone();
          break;
        case ActionOneofCase.DCDEEABBENF:
          DCDEEABBENF = other.DCDEEABBENF.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HandleRogueCommonPendingActionScRsp Clone() {
      return new HandleRogueCommonPendingActionScRsp(this);
    }

    /// <summary>Field number for the "queue_position" field.</summary>
    public const int QueuePositionFieldNumber = 12;
    private uint queuePosition_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint QueuePosition {
      get { return queuePosition_; }
      set {
        queuePosition_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 13;
    private uint retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "queue_location" field.</summary>
    public const int QueueLocationFieldNumber = 10;
    private uint queueLocation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint QueueLocation {
      get { return queueLocation_; }
      set {
        queueLocation_ = value;
      }
    }

    /// <summary>Field number for the "buff_select" field.</summary>
    public const int BuffSelectFieldNumber = 1971;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueBuffSelectHandleActionResult BuffSelect {
      get { return actionCase_ == ActionOneofCase.BuffSelect ? (global::EggLink.DanhengServer.Proto.RogueBuffSelectHandleActionResult) action_ : null; }
      set {
        action_ = value;
        actionCase_ = value == null ? ActionOneofCase.None : ActionOneofCase.BuffSelect;
      }
    }

    /// <summary>Field number for the "NOMDIPLOEAE" field.</summary>
    public const int NOMDIPLOEAEFieldNumber = 427;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.JEKCOOOOMGP NOMDIPLOEAE {
      get { return actionCase_ == ActionOneofCase.NOMDIPLOEAE ? (global::EggLink.DanhengServer.Proto.JEKCOOOOMGP) action_ : null; }
      set {
        action_ = value;
        actionCase_ = value == null ? ActionOneofCase.None : ActionOneofCase.NOMDIPLOEAE;
      }
    }

    /// <summary>Field number for the "OPCMLBCMDMO" field.</summary>
    public const int OPCMLBCMDMOFieldNumber = 1172;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.KGNHHAGNJEL OPCMLBCMDMO {
      get { return actionCase_ == ActionOneofCase.OPCMLBCMDMO ? (global::EggLink.DanhengServer.Proto.KGNHHAGNJEL) action_ : null; }
      set {
        action_ = value;
        actionCase_ = value == null ? ActionOneofCase.None : ActionOneofCase.OPCMLBCMDMO;
      }
    }

    /// <summary>Field number for the "BNMBIBALAEF" field.</summary>
    public const int BNMBIBALAEFFieldNumber = 1184;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PEDFECGBLAP BNMBIBALAEF {
      get { return actionCase_ == ActionOneofCase.BNMBIBALAEF ? (global::EggLink.DanhengServer.Proto.PEDFECGBLAP) action_ : null; }
      set {
        action_ = value;
        actionCase_ = value == null ? ActionOneofCase.None : ActionOneofCase.BNMBIBALAEF;
      }
    }

    /// <summary>Field number for the "miracle_select" field.</summary>
    public const int MiracleSelectFieldNumber = 202;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueMiracleSelectHandleActionResult MiracleSelect {
      get { return actionCase_ == ActionOneofCase.MiracleSelect ? (global::EggLink.DanhengServer.Proto.RogueMiracleSelectHandleActionResult) action_ : null; }
      set {
        action_ = value;
        actionCase_ = value == null ? ActionOneofCase.None : ActionOneofCase.MiracleSelect;
      }
    }

    /// <summary>Field number for the "LIHOCNEOLFC" field.</summary>
    public const int LIHOCNEOLFCFieldNumber = 474;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PFNGOPDFOPO LIHOCNEOLFC {
      get { return actionCase_ == ActionOneofCase.LIHOCNEOLFC ? (global::EggLink.DanhengServer.Proto.PFNGOPDFOPO) action_ : null; }
      set {
        action_ = value;
        actionCase_ = value == null ? ActionOneofCase.None : ActionOneofCase.LIHOCNEOLFC;
      }
    }

    /// <summary>Field number for the "IJBKEODNKMI" field.</summary>
    public const int IJBKEODNKMIFieldNumber = 216;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.OHIKOEANAOM IJBKEODNKMI {
      get { return actionCase_ == ActionOneofCase.IJBKEODNKMI ? (global::EggLink.DanhengServer.Proto.OHIKOEANAOM) action_ : null; }
      set {
        action_ = value;
        actionCase_ = value == null ? ActionOneofCase.None : ActionOneofCase.IJBKEODNKMI;
      }
    }

    /// <summary>Field number for the "KHODBFHMMOO" field.</summary>
    public const int KHODBFHMMOOFieldNumber = 1461;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.HIFEJEFFMDM KHODBFHMMOO {
      get { return actionCase_ == ActionOneofCase.KHODBFHMMOO ? (global::EggLink.DanhengServer.Proto.HIFEJEFFMDM) action_ : null; }
      set {
        action_ = value;
        actionCase_ = value == null ? ActionOneofCase.None : ActionOneofCase.KHODBFHMMOO;
      }
    }

    /// <summary>Field number for the "LABBLONMBDG" field.</summary>
    public const int LABBLONMBDGFieldNumber = 1606;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.GNMNOOAJIJJ LABBLONMBDG {
      get { return actionCase_ == ActionOneofCase.LABBLONMBDG ? (global::EggLink.DanhengServer.Proto.GNMNOOAJIJJ) action_ : null; }
      set {
        action_ = value;
        actionCase_ = value == null ? ActionOneofCase.None : ActionOneofCase.LABBLONMBDG;
      }
    }

    /// <summary>Field number for the "DCDEEABBENF" field.</summary>
    public const int DCDEEABBENFFieldNumber = 1789;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.PKPIBMHPDDI DCDEEABBENF {
      get { return actionCase_ == ActionOneofCase.DCDEEABBENF ? (global::EggLink.DanhengServer.Proto.PKPIBMHPDDI) action_ : null; }
      set {
        action_ = value;
        actionCase_ = value == null ? ActionOneofCase.None : ActionOneofCase.DCDEEABBENF;
      }
    }

    private object action_;
    /// <summary>Enum of possible cases for the "action" oneof.</summary>
    public enum ActionOneofCase {
      None = 0,
      BuffSelect = 1971,
      NOMDIPLOEAE = 427,
      OPCMLBCMDMO = 1172,
      BNMBIBALAEF = 1184,
      MiracleSelect = 202,
      LIHOCNEOLFC = 474,
      IJBKEODNKMI = 216,
      KHODBFHMMOO = 1461,
      LABBLONMBDG = 1606,
      DCDEEABBENF = 1789,
    }
    private ActionOneofCase actionCase_ = ActionOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ActionOneofCase ActionCase {
      get { return actionCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearAction() {
      actionCase_ = ActionOneofCase.None;
      action_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HandleRogueCommonPendingActionScRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HandleRogueCommonPendingActionScRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (QueuePosition != other.QueuePosition) return false;
      if (Retcode != other.Retcode) return false;
      if (QueueLocation != other.QueueLocation) return false;
      if (!object.Equals(BuffSelect, other.BuffSelect)) return false;
      if (!object.Equals(NOMDIPLOEAE, other.NOMDIPLOEAE)) return false;
      if (!object.Equals(OPCMLBCMDMO, other.OPCMLBCMDMO)) return false;
      if (!object.Equals(BNMBIBALAEF, other.BNMBIBALAEF)) return false;
      if (!object.Equals(MiracleSelect, other.MiracleSelect)) return false;
      if (!object.Equals(LIHOCNEOLFC, other.LIHOCNEOLFC)) return false;
      if (!object.Equals(IJBKEODNKMI, other.IJBKEODNKMI)) return false;
      if (!object.Equals(KHODBFHMMOO, other.KHODBFHMMOO)) return false;
      if (!object.Equals(LABBLONMBDG, other.LABBLONMBDG)) return false;
      if (!object.Equals(DCDEEABBENF, other.DCDEEABBENF)) return false;
      if (ActionCase != other.ActionCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (QueuePosition != 0) hash ^= QueuePosition.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (QueueLocation != 0) hash ^= QueueLocation.GetHashCode();
      if (actionCase_ == ActionOneofCase.BuffSelect) hash ^= BuffSelect.GetHashCode();
      if (actionCase_ == ActionOneofCase.NOMDIPLOEAE) hash ^= NOMDIPLOEAE.GetHashCode();
      if (actionCase_ == ActionOneofCase.OPCMLBCMDMO) hash ^= OPCMLBCMDMO.GetHashCode();
      if (actionCase_ == ActionOneofCase.BNMBIBALAEF) hash ^= BNMBIBALAEF.GetHashCode();
      if (actionCase_ == ActionOneofCase.MiracleSelect) hash ^= MiracleSelect.GetHashCode();
      if (actionCase_ == ActionOneofCase.LIHOCNEOLFC) hash ^= LIHOCNEOLFC.GetHashCode();
      if (actionCase_ == ActionOneofCase.IJBKEODNKMI) hash ^= IJBKEODNKMI.GetHashCode();
      if (actionCase_ == ActionOneofCase.KHODBFHMMOO) hash ^= KHODBFHMMOO.GetHashCode();
      if (actionCase_ == ActionOneofCase.LABBLONMBDG) hash ^= LABBLONMBDG.GetHashCode();
      if (actionCase_ == ActionOneofCase.DCDEEABBENF) hash ^= DCDEEABBENF.GetHashCode();
      hash ^= (int) actionCase_;
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
      if (QueueLocation != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(QueueLocation);
      }
      if (QueuePosition != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(QueuePosition);
      }
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Retcode);
      }
      if (actionCase_ == ActionOneofCase.MiracleSelect) {
        output.WriteRawTag(210, 12);
        output.WriteMessage(MiracleSelect);
      }
      if (actionCase_ == ActionOneofCase.IJBKEODNKMI) {
        output.WriteRawTag(194, 13);
        output.WriteMessage(IJBKEODNKMI);
      }
      if (actionCase_ == ActionOneofCase.NOMDIPLOEAE) {
        output.WriteRawTag(218, 26);
        output.WriteMessage(NOMDIPLOEAE);
      }
      if (actionCase_ == ActionOneofCase.LIHOCNEOLFC) {
        output.WriteRawTag(210, 29);
        output.WriteMessage(LIHOCNEOLFC);
      }
      if (actionCase_ == ActionOneofCase.OPCMLBCMDMO) {
        output.WriteRawTag(162, 73);
        output.WriteMessage(OPCMLBCMDMO);
      }
      if (actionCase_ == ActionOneofCase.BNMBIBALAEF) {
        output.WriteRawTag(130, 74);
        output.WriteMessage(BNMBIBALAEF);
      }
      if (actionCase_ == ActionOneofCase.KHODBFHMMOO) {
        output.WriteRawTag(170, 91);
        output.WriteMessage(KHODBFHMMOO);
      }
      if (actionCase_ == ActionOneofCase.LABBLONMBDG) {
        output.WriteRawTag(178, 100);
        output.WriteMessage(LABBLONMBDG);
      }
      if (actionCase_ == ActionOneofCase.DCDEEABBENF) {
        output.WriteRawTag(234, 111);
        output.WriteMessage(DCDEEABBENF);
      }
      if (actionCase_ == ActionOneofCase.BuffSelect) {
        output.WriteRawTag(154, 123);
        output.WriteMessage(BuffSelect);
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
      if (QueueLocation != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(QueueLocation);
      }
      if (QueuePosition != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(QueuePosition);
      }
      if (Retcode != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Retcode);
      }
      if (actionCase_ == ActionOneofCase.MiracleSelect) {
        output.WriteRawTag(210, 12);
        output.WriteMessage(MiracleSelect);
      }
      if (actionCase_ == ActionOneofCase.IJBKEODNKMI) {
        output.WriteRawTag(194, 13);
        output.WriteMessage(IJBKEODNKMI);
      }
      if (actionCase_ == ActionOneofCase.NOMDIPLOEAE) {
        output.WriteRawTag(218, 26);
        output.WriteMessage(NOMDIPLOEAE);
      }
      if (actionCase_ == ActionOneofCase.LIHOCNEOLFC) {
        output.WriteRawTag(210, 29);
        output.WriteMessage(LIHOCNEOLFC);
      }
      if (actionCase_ == ActionOneofCase.OPCMLBCMDMO) {
        output.WriteRawTag(162, 73);
        output.WriteMessage(OPCMLBCMDMO);
      }
      if (actionCase_ == ActionOneofCase.BNMBIBALAEF) {
        output.WriteRawTag(130, 74);
        output.WriteMessage(BNMBIBALAEF);
      }
      if (actionCase_ == ActionOneofCase.KHODBFHMMOO) {
        output.WriteRawTag(170, 91);
        output.WriteMessage(KHODBFHMMOO);
      }
      if (actionCase_ == ActionOneofCase.LABBLONMBDG) {
        output.WriteRawTag(178, 100);
        output.WriteMessage(LABBLONMBDG);
      }
      if (actionCase_ == ActionOneofCase.DCDEEABBENF) {
        output.WriteRawTag(234, 111);
        output.WriteMessage(DCDEEABBENF);
      }
      if (actionCase_ == ActionOneofCase.BuffSelect) {
        output.WriteRawTag(154, 123);
        output.WriteMessage(BuffSelect);
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
      if (QueuePosition != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(QueuePosition);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Retcode);
      }
      if (QueueLocation != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(QueueLocation);
      }
      if (actionCase_ == ActionOneofCase.BuffSelect) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(BuffSelect);
      }
      if (actionCase_ == ActionOneofCase.NOMDIPLOEAE) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(NOMDIPLOEAE);
      }
      if (actionCase_ == ActionOneofCase.OPCMLBCMDMO) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(OPCMLBCMDMO);
      }
      if (actionCase_ == ActionOneofCase.BNMBIBALAEF) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(BNMBIBALAEF);
      }
      if (actionCase_ == ActionOneofCase.MiracleSelect) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(MiracleSelect);
      }
      if (actionCase_ == ActionOneofCase.LIHOCNEOLFC) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(LIHOCNEOLFC);
      }
      if (actionCase_ == ActionOneofCase.IJBKEODNKMI) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(IJBKEODNKMI);
      }
      if (actionCase_ == ActionOneofCase.KHODBFHMMOO) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(KHODBFHMMOO);
      }
      if (actionCase_ == ActionOneofCase.LABBLONMBDG) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(LABBLONMBDG);
      }
      if (actionCase_ == ActionOneofCase.DCDEEABBENF) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(DCDEEABBENF);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HandleRogueCommonPendingActionScRsp other) {
      if (other == null) {
        return;
      }
      if (other.QueuePosition != 0) {
        QueuePosition = other.QueuePosition;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.QueueLocation != 0) {
        QueueLocation = other.QueueLocation;
      }
      switch (other.ActionCase) {
        case ActionOneofCase.BuffSelect:
          if (BuffSelect == null) {
            BuffSelect = new global::EggLink.DanhengServer.Proto.RogueBuffSelectHandleActionResult();
          }
          BuffSelect.MergeFrom(other.BuffSelect);
          break;
        case ActionOneofCase.NOMDIPLOEAE:
          if (NOMDIPLOEAE == null) {
            NOMDIPLOEAE = new global::EggLink.DanhengServer.Proto.JEKCOOOOMGP();
          }
          NOMDIPLOEAE.MergeFrom(other.NOMDIPLOEAE);
          break;
        case ActionOneofCase.OPCMLBCMDMO:
          if (OPCMLBCMDMO == null) {
            OPCMLBCMDMO = new global::EggLink.DanhengServer.Proto.KGNHHAGNJEL();
          }
          OPCMLBCMDMO.MergeFrom(other.OPCMLBCMDMO);
          break;
        case ActionOneofCase.BNMBIBALAEF:
          if (BNMBIBALAEF == null) {
            BNMBIBALAEF = new global::EggLink.DanhengServer.Proto.PEDFECGBLAP();
          }
          BNMBIBALAEF.MergeFrom(other.BNMBIBALAEF);
          break;
        case ActionOneofCase.MiracleSelect:
          if (MiracleSelect == null) {
            MiracleSelect = new global::EggLink.DanhengServer.Proto.RogueMiracleSelectHandleActionResult();
          }
          MiracleSelect.MergeFrom(other.MiracleSelect);
          break;
        case ActionOneofCase.LIHOCNEOLFC:
          if (LIHOCNEOLFC == null) {
            LIHOCNEOLFC = new global::EggLink.DanhengServer.Proto.PFNGOPDFOPO();
          }
          LIHOCNEOLFC.MergeFrom(other.LIHOCNEOLFC);
          break;
        case ActionOneofCase.IJBKEODNKMI:
          if (IJBKEODNKMI == null) {
            IJBKEODNKMI = new global::EggLink.DanhengServer.Proto.OHIKOEANAOM();
          }
          IJBKEODNKMI.MergeFrom(other.IJBKEODNKMI);
          break;
        case ActionOneofCase.KHODBFHMMOO:
          if (KHODBFHMMOO == null) {
            KHODBFHMMOO = new global::EggLink.DanhengServer.Proto.HIFEJEFFMDM();
          }
          KHODBFHMMOO.MergeFrom(other.KHODBFHMMOO);
          break;
        case ActionOneofCase.LABBLONMBDG:
          if (LABBLONMBDG == null) {
            LABBLONMBDG = new global::EggLink.DanhengServer.Proto.GNMNOOAJIJJ();
          }
          LABBLONMBDG.MergeFrom(other.LABBLONMBDG);
          break;
        case ActionOneofCase.DCDEEABBENF:
          if (DCDEEABBENF == null) {
            DCDEEABBENF = new global::EggLink.DanhengServer.Proto.PKPIBMHPDDI();
          }
          DCDEEABBENF.MergeFrom(other.DCDEEABBENF);
          break;
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
          case 80: {
            QueueLocation = input.ReadUInt32();
            break;
          }
          case 96: {
            QueuePosition = input.ReadUInt32();
            break;
          }
          case 104: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 1618: {
            global::EggLink.DanhengServer.Proto.RogueMiracleSelectHandleActionResult subBuilder = new global::EggLink.DanhengServer.Proto.RogueMiracleSelectHandleActionResult();
            if (actionCase_ == ActionOneofCase.MiracleSelect) {
              subBuilder.MergeFrom(MiracleSelect);
            }
            input.ReadMessage(subBuilder);
            MiracleSelect = subBuilder;
            break;
          }
          case 1730: {
            global::EggLink.DanhengServer.Proto.OHIKOEANAOM subBuilder = new global::EggLink.DanhengServer.Proto.OHIKOEANAOM();
            if (actionCase_ == ActionOneofCase.IJBKEODNKMI) {
              subBuilder.MergeFrom(IJBKEODNKMI);
            }
            input.ReadMessage(subBuilder);
            IJBKEODNKMI = subBuilder;
            break;
          }
          case 3418: {
            global::EggLink.DanhengServer.Proto.JEKCOOOOMGP subBuilder = new global::EggLink.DanhengServer.Proto.JEKCOOOOMGP();
            if (actionCase_ == ActionOneofCase.NOMDIPLOEAE) {
              subBuilder.MergeFrom(NOMDIPLOEAE);
            }
            input.ReadMessage(subBuilder);
            NOMDIPLOEAE = subBuilder;
            break;
          }
          case 3794: {
            global::EggLink.DanhengServer.Proto.PFNGOPDFOPO subBuilder = new global::EggLink.DanhengServer.Proto.PFNGOPDFOPO();
            if (actionCase_ == ActionOneofCase.LIHOCNEOLFC) {
              subBuilder.MergeFrom(LIHOCNEOLFC);
            }
            input.ReadMessage(subBuilder);
            LIHOCNEOLFC = subBuilder;
            break;
          }
          case 9378: {
            global::EggLink.DanhengServer.Proto.KGNHHAGNJEL subBuilder = new global::EggLink.DanhengServer.Proto.KGNHHAGNJEL();
            if (actionCase_ == ActionOneofCase.OPCMLBCMDMO) {
              subBuilder.MergeFrom(OPCMLBCMDMO);
            }
            input.ReadMessage(subBuilder);
            OPCMLBCMDMO = subBuilder;
            break;
          }
          case 9474: {
            global::EggLink.DanhengServer.Proto.PEDFECGBLAP subBuilder = new global::EggLink.DanhengServer.Proto.PEDFECGBLAP();
            if (actionCase_ == ActionOneofCase.BNMBIBALAEF) {
              subBuilder.MergeFrom(BNMBIBALAEF);
            }
            input.ReadMessage(subBuilder);
            BNMBIBALAEF = subBuilder;
            break;
          }
          case 11690: {
            global::EggLink.DanhengServer.Proto.HIFEJEFFMDM subBuilder = new global::EggLink.DanhengServer.Proto.HIFEJEFFMDM();
            if (actionCase_ == ActionOneofCase.KHODBFHMMOO) {
              subBuilder.MergeFrom(KHODBFHMMOO);
            }
            input.ReadMessage(subBuilder);
            KHODBFHMMOO = subBuilder;
            break;
          }
          case 12850: {
            global::EggLink.DanhengServer.Proto.GNMNOOAJIJJ subBuilder = new global::EggLink.DanhengServer.Proto.GNMNOOAJIJJ();
            if (actionCase_ == ActionOneofCase.LABBLONMBDG) {
              subBuilder.MergeFrom(LABBLONMBDG);
            }
            input.ReadMessage(subBuilder);
            LABBLONMBDG = subBuilder;
            break;
          }
          case 14314: {
            global::EggLink.DanhengServer.Proto.PKPIBMHPDDI subBuilder = new global::EggLink.DanhengServer.Proto.PKPIBMHPDDI();
            if (actionCase_ == ActionOneofCase.DCDEEABBENF) {
              subBuilder.MergeFrom(DCDEEABBENF);
            }
            input.ReadMessage(subBuilder);
            DCDEEABBENF = subBuilder;
            break;
          }
          case 15770: {
            global::EggLink.DanhengServer.Proto.RogueBuffSelectHandleActionResult subBuilder = new global::EggLink.DanhengServer.Proto.RogueBuffSelectHandleActionResult();
            if (actionCase_ == ActionOneofCase.BuffSelect) {
              subBuilder.MergeFrom(BuffSelect);
            }
            input.ReadMessage(subBuilder);
            BuffSelect = subBuilder;
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
          case 80: {
            QueueLocation = input.ReadUInt32();
            break;
          }
          case 96: {
            QueuePosition = input.ReadUInt32();
            break;
          }
          case 104: {
            Retcode = input.ReadUInt32();
            break;
          }
          case 1618: {
            global::EggLink.DanhengServer.Proto.RogueMiracleSelectHandleActionResult subBuilder = new global::EggLink.DanhengServer.Proto.RogueMiracleSelectHandleActionResult();
            if (actionCase_ == ActionOneofCase.MiracleSelect) {
              subBuilder.MergeFrom(MiracleSelect);
            }
            input.ReadMessage(subBuilder);
            MiracleSelect = subBuilder;
            break;
          }
          case 1730: {
            global::EggLink.DanhengServer.Proto.OHIKOEANAOM subBuilder = new global::EggLink.DanhengServer.Proto.OHIKOEANAOM();
            if (actionCase_ == ActionOneofCase.IJBKEODNKMI) {
              subBuilder.MergeFrom(IJBKEODNKMI);
            }
            input.ReadMessage(subBuilder);
            IJBKEODNKMI = subBuilder;
            break;
          }
          case 3418: {
            global::EggLink.DanhengServer.Proto.JEKCOOOOMGP subBuilder = new global::EggLink.DanhengServer.Proto.JEKCOOOOMGP();
            if (actionCase_ == ActionOneofCase.NOMDIPLOEAE) {
              subBuilder.MergeFrom(NOMDIPLOEAE);
            }
            input.ReadMessage(subBuilder);
            NOMDIPLOEAE = subBuilder;
            break;
          }
          case 3794: {
            global::EggLink.DanhengServer.Proto.PFNGOPDFOPO subBuilder = new global::EggLink.DanhengServer.Proto.PFNGOPDFOPO();
            if (actionCase_ == ActionOneofCase.LIHOCNEOLFC) {
              subBuilder.MergeFrom(LIHOCNEOLFC);
            }
            input.ReadMessage(subBuilder);
            LIHOCNEOLFC = subBuilder;
            break;
          }
          case 9378: {
            global::EggLink.DanhengServer.Proto.KGNHHAGNJEL subBuilder = new global::EggLink.DanhengServer.Proto.KGNHHAGNJEL();
            if (actionCase_ == ActionOneofCase.OPCMLBCMDMO) {
              subBuilder.MergeFrom(OPCMLBCMDMO);
            }
            input.ReadMessage(subBuilder);
            OPCMLBCMDMO = subBuilder;
            break;
          }
          case 9474: {
            global::EggLink.DanhengServer.Proto.PEDFECGBLAP subBuilder = new global::EggLink.DanhengServer.Proto.PEDFECGBLAP();
            if (actionCase_ == ActionOneofCase.BNMBIBALAEF) {
              subBuilder.MergeFrom(BNMBIBALAEF);
            }
            input.ReadMessage(subBuilder);
            BNMBIBALAEF = subBuilder;
            break;
          }
          case 11690: {
            global::EggLink.DanhengServer.Proto.HIFEJEFFMDM subBuilder = new global::EggLink.DanhengServer.Proto.HIFEJEFFMDM();
            if (actionCase_ == ActionOneofCase.KHODBFHMMOO) {
              subBuilder.MergeFrom(KHODBFHMMOO);
            }
            input.ReadMessage(subBuilder);
            KHODBFHMMOO = subBuilder;
            break;
          }
          case 12850: {
            global::EggLink.DanhengServer.Proto.GNMNOOAJIJJ subBuilder = new global::EggLink.DanhengServer.Proto.GNMNOOAJIJJ();
            if (actionCase_ == ActionOneofCase.LABBLONMBDG) {
              subBuilder.MergeFrom(LABBLONMBDG);
            }
            input.ReadMessage(subBuilder);
            LABBLONMBDG = subBuilder;
            break;
          }
          case 14314: {
            global::EggLink.DanhengServer.Proto.PKPIBMHPDDI subBuilder = new global::EggLink.DanhengServer.Proto.PKPIBMHPDDI();
            if (actionCase_ == ActionOneofCase.DCDEEABBENF) {
              subBuilder.MergeFrom(DCDEEABBENF);
            }
            input.ReadMessage(subBuilder);
            DCDEEABBENF = subBuilder;
            break;
          }
          case 15770: {
            global::EggLink.DanhengServer.Proto.RogueBuffSelectHandleActionResult subBuilder = new global::EggLink.DanhengServer.Proto.RogueBuffSelectHandleActionResult();
            if (actionCase_ == ActionOneofCase.BuffSelect) {
              subBuilder.MergeFrom(BuffSelect);
            }
            input.ReadMessage(subBuilder);
            BuffSelect = subBuilder;
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
