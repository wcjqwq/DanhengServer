// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueAction.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueAction.proto</summary>
  public static partial class RogueActionReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueAction.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueActionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFSb2d1ZUFjdGlvbi5wcm90bxoRQ0VMTERLT0NKSUEucHJvdG8aH1JvZ3Vl",
            "TWlyYWNsZURlc3RvcnlBY3Rpb24ucHJvdG8aJ1JvZ3VlTWlyYWNsZVNlbGVj",
            "dERlc3RvcnllZEFjdGlvbi5wcm90bxocUm9ndWVCb251c1NlbGVjdEFjdGlv",
            "bi5wcm90bxoZUm9ndWVCdWZmRHJvcEFjdGlvbi5wcm90bxoiUm9ndWVCdWZm",
            "RW5oYW5jZVNlbGVjdEFjdGlvbi5wcm90bxoeUm9ndWVNaXJhY2xlUmVwYWly",
            "QWN0aW9uLnByb3RvGhtSb2d1ZUJ1ZmZTZWxlY3RBY3Rpb24ucHJvdG8aHFJv",
            "Z3VlTWlyYWNsZURyb3BBY3Rpb24ucHJvdG8aHlJvZ3VlTWlyYWNsZVNlbGVj",
            "dEFjdGlvbi5wcm90byKrBAoLUm9ndWVBY3Rpb24SMQoQYnVmZl9zZWxlY3Rf",
            "aW5mbxjsCiABKAsyFi5Sb2d1ZUJ1ZmZTZWxlY3RBY3Rpb24SLwoQZHJvcF9i",
            "dWZmX2FjdGlvbhjOBCABKAsyFC5Sb2d1ZUJ1ZmZEcm9wQWN0aW9uEjsKE2Vu",
            "aGFuY2Vfc2VsZWN0X2luZm8YrQ4gASgLMh0uUm9ndWVCdWZmRW5oYW5jZVNl",
            "bGVjdEFjdGlvbhI3ChNtaXJhY2xlX3NlbGVjdF9pbmZvGPsIIAEoCzIZLlJv",
            "Z3VlTWlyYWNsZVNlbGVjdEFjdGlvbhIiCgtET05NQU9FSk1FRhjqBCABKAsy",
            "DC5DRUxMREtPQ0pJQRI5ChVyZXBhaXJfbWlyYWNsZV9hY3Rpb24Y0g0gASgL",
            "MhkuUm9ndWVNaXJhY2xlUmVwYWlyQWN0aW9uEjsKFmRlc3Ryb3lfbWlyYWNs",
            "ZV9hY3Rpb24Y+wogASgLMhouUm9ndWVNaXJhY2xlRGVzdG9yeUFjdGlvbhI1",
            "ChNkcm9wX21pcmFjbGVfYWN0aW9uGMQBIAEoCzIXLlJvZ3VlTWlyYWNsZURy",
            "b3BBY3Rpb24SOAoLUEtFRklLQ01ET00YuAogASgLMiIuUm9ndWVNaXJhY2xl",
            "U2VsZWN0RGVzdG9yeWVkQWN0aW9uEjUKE2JvbnVzX3NlbGVjdF9hY3Rpb24Y",
            "lAogASgLMhcuUm9ndWVCb251c1NlbGVjdEFjdGlvbkIeqgIbRWdnTGluay5E",
            "YW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.CELLDKOCJIAReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueMiracleDestoryActionReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueMiracleSelectDestoryedActionReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueBonusSelectActionReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueBuffDropActionReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueBuffEnhanceSelectActionReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueMiracleRepairActionReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueBuffSelectActionReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueMiracleDropActionReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueMiracleSelectActionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueAction), global::EggLink.DanhengServer.Proto.RogueAction.Parser, new[]{ "BuffSelectInfo", "DropBuffAction", "EnhanceSelectInfo", "MiracleSelectInfo", "DONMAOEJMEF", "RepairMiracleAction", "DestroyMiracleAction", "DropMiracleAction", "PKEFIKCMDOM", "BonusSelectAction" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueAction : pb::IMessage<RogueAction>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueAction> _parser = new pb::MessageParser<RogueAction>(() => new RogueAction());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueAction> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueActionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueAction() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueAction(RogueAction other) : this() {
      buffSelectInfo_ = other.buffSelectInfo_ != null ? other.buffSelectInfo_.Clone() : null;
      dropBuffAction_ = other.dropBuffAction_ != null ? other.dropBuffAction_.Clone() : null;
      enhanceSelectInfo_ = other.enhanceSelectInfo_ != null ? other.enhanceSelectInfo_.Clone() : null;
      miracleSelectInfo_ = other.miracleSelectInfo_ != null ? other.miracleSelectInfo_.Clone() : null;
      dONMAOEJMEF_ = other.dONMAOEJMEF_ != null ? other.dONMAOEJMEF_.Clone() : null;
      repairMiracleAction_ = other.repairMiracleAction_ != null ? other.repairMiracleAction_.Clone() : null;
      destroyMiracleAction_ = other.destroyMiracleAction_ != null ? other.destroyMiracleAction_.Clone() : null;
      dropMiracleAction_ = other.dropMiracleAction_ != null ? other.dropMiracleAction_.Clone() : null;
      pKEFIKCMDOM_ = other.pKEFIKCMDOM_ != null ? other.pKEFIKCMDOM_.Clone() : null;
      bonusSelectAction_ = other.bonusSelectAction_ != null ? other.bonusSelectAction_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueAction Clone() {
      return new RogueAction(this);
    }

    /// <summary>Field number for the "buff_select_info" field.</summary>
    public const int BuffSelectInfoFieldNumber = 1388;
    private global::EggLink.DanhengServer.Proto.RogueBuffSelectAction buffSelectInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueBuffSelectAction BuffSelectInfo {
      get { return buffSelectInfo_; }
      set {
        buffSelectInfo_ = value;
      }
    }

    /// <summary>Field number for the "drop_buff_action" field.</summary>
    public const int DropBuffActionFieldNumber = 590;
    private global::EggLink.DanhengServer.Proto.RogueBuffDropAction dropBuffAction_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueBuffDropAction DropBuffAction {
      get { return dropBuffAction_; }
      set {
        dropBuffAction_ = value;
      }
    }

    /// <summary>Field number for the "enhance_select_info" field.</summary>
    public const int EnhanceSelectInfoFieldNumber = 1837;
    private global::EggLink.DanhengServer.Proto.RogueBuffEnhanceSelectAction enhanceSelectInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueBuffEnhanceSelectAction EnhanceSelectInfo {
      get { return enhanceSelectInfo_; }
      set {
        enhanceSelectInfo_ = value;
      }
    }

    /// <summary>Field number for the "miracle_select_info" field.</summary>
    public const int MiracleSelectInfoFieldNumber = 1147;
    private global::EggLink.DanhengServer.Proto.RogueMiracleSelectAction miracleSelectInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueMiracleSelectAction MiracleSelectInfo {
      get { return miracleSelectInfo_; }
      set {
        miracleSelectInfo_ = value;
      }
    }

    /// <summary>Field number for the "DONMAOEJMEF" field.</summary>
    public const int DONMAOEJMEFFieldNumber = 618;
    private global::EggLink.DanhengServer.Proto.CELLDKOCJIA dONMAOEJMEF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.CELLDKOCJIA DONMAOEJMEF {
      get { return dONMAOEJMEF_; }
      set {
        dONMAOEJMEF_ = value;
      }
    }

    /// <summary>Field number for the "repair_miracle_action" field.</summary>
    public const int RepairMiracleActionFieldNumber = 1746;
    private global::EggLink.DanhengServer.Proto.RogueMiracleRepairAction repairMiracleAction_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueMiracleRepairAction RepairMiracleAction {
      get { return repairMiracleAction_; }
      set {
        repairMiracleAction_ = value;
      }
    }

    /// <summary>Field number for the "destroy_miracle_action" field.</summary>
    public const int DestroyMiracleActionFieldNumber = 1403;
    private global::EggLink.DanhengServer.Proto.RogueMiracleDestoryAction destroyMiracleAction_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueMiracleDestoryAction DestroyMiracleAction {
      get { return destroyMiracleAction_; }
      set {
        destroyMiracleAction_ = value;
      }
    }

    /// <summary>Field number for the "drop_miracle_action" field.</summary>
    public const int DropMiracleActionFieldNumber = 196;
    private global::EggLink.DanhengServer.Proto.RogueMiracleDropAction dropMiracleAction_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueMiracleDropAction DropMiracleAction {
      get { return dropMiracleAction_; }
      set {
        dropMiracleAction_ = value;
      }
    }

    /// <summary>Field number for the "PKEFIKCMDOM" field.</summary>
    public const int PKEFIKCMDOMFieldNumber = 1336;
    private global::EggLink.DanhengServer.Proto.RogueMiracleSelectDestoryedAction pKEFIKCMDOM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueMiracleSelectDestoryedAction PKEFIKCMDOM {
      get { return pKEFIKCMDOM_; }
      set {
        pKEFIKCMDOM_ = value;
      }
    }

    /// <summary>Field number for the "bonus_select_action" field.</summary>
    public const int BonusSelectActionFieldNumber = 1300;
    private global::EggLink.DanhengServer.Proto.RogueBonusSelectAction bonusSelectAction_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueBonusSelectAction BonusSelectAction {
      get { return bonusSelectAction_; }
      set {
        bonusSelectAction_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueAction);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueAction other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(BuffSelectInfo, other.BuffSelectInfo)) return false;
      if (!object.Equals(DropBuffAction, other.DropBuffAction)) return false;
      if (!object.Equals(EnhanceSelectInfo, other.EnhanceSelectInfo)) return false;
      if (!object.Equals(MiracleSelectInfo, other.MiracleSelectInfo)) return false;
      if (!object.Equals(DONMAOEJMEF, other.DONMAOEJMEF)) return false;
      if (!object.Equals(RepairMiracleAction, other.RepairMiracleAction)) return false;
      if (!object.Equals(DestroyMiracleAction, other.DestroyMiracleAction)) return false;
      if (!object.Equals(DropMiracleAction, other.DropMiracleAction)) return false;
      if (!object.Equals(PKEFIKCMDOM, other.PKEFIKCMDOM)) return false;
      if (!object.Equals(BonusSelectAction, other.BonusSelectAction)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (buffSelectInfo_ != null) hash ^= BuffSelectInfo.GetHashCode();
      if (dropBuffAction_ != null) hash ^= DropBuffAction.GetHashCode();
      if (enhanceSelectInfo_ != null) hash ^= EnhanceSelectInfo.GetHashCode();
      if (miracleSelectInfo_ != null) hash ^= MiracleSelectInfo.GetHashCode();
      if (dONMAOEJMEF_ != null) hash ^= DONMAOEJMEF.GetHashCode();
      if (repairMiracleAction_ != null) hash ^= RepairMiracleAction.GetHashCode();
      if (destroyMiracleAction_ != null) hash ^= DestroyMiracleAction.GetHashCode();
      if (dropMiracleAction_ != null) hash ^= DropMiracleAction.GetHashCode();
      if (pKEFIKCMDOM_ != null) hash ^= PKEFIKCMDOM.GetHashCode();
      if (bonusSelectAction_ != null) hash ^= BonusSelectAction.GetHashCode();
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
      if (dropMiracleAction_ != null) {
        output.WriteRawTag(162, 12);
        output.WriteMessage(DropMiracleAction);
      }
      if (dropBuffAction_ != null) {
        output.WriteRawTag(242, 36);
        output.WriteMessage(DropBuffAction);
      }
      if (dONMAOEJMEF_ != null) {
        output.WriteRawTag(210, 38);
        output.WriteMessage(DONMAOEJMEF);
      }
      if (miracleSelectInfo_ != null) {
        output.WriteRawTag(218, 71);
        output.WriteMessage(MiracleSelectInfo);
      }
      if (bonusSelectAction_ != null) {
        output.WriteRawTag(162, 81);
        output.WriteMessage(BonusSelectAction);
      }
      if (pKEFIKCMDOM_ != null) {
        output.WriteRawTag(194, 83);
        output.WriteMessage(PKEFIKCMDOM);
      }
      if (buffSelectInfo_ != null) {
        output.WriteRawTag(226, 86);
        output.WriteMessage(BuffSelectInfo);
      }
      if (destroyMiracleAction_ != null) {
        output.WriteRawTag(218, 87);
        output.WriteMessage(DestroyMiracleAction);
      }
      if (repairMiracleAction_ != null) {
        output.WriteRawTag(146, 109);
        output.WriteMessage(RepairMiracleAction);
      }
      if (enhanceSelectInfo_ != null) {
        output.WriteRawTag(234, 114);
        output.WriteMessage(EnhanceSelectInfo);
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
      if (dropMiracleAction_ != null) {
        output.WriteRawTag(162, 12);
        output.WriteMessage(DropMiracleAction);
      }
      if (dropBuffAction_ != null) {
        output.WriteRawTag(242, 36);
        output.WriteMessage(DropBuffAction);
      }
      if (dONMAOEJMEF_ != null) {
        output.WriteRawTag(210, 38);
        output.WriteMessage(DONMAOEJMEF);
      }
      if (miracleSelectInfo_ != null) {
        output.WriteRawTag(218, 71);
        output.WriteMessage(MiracleSelectInfo);
      }
      if (bonusSelectAction_ != null) {
        output.WriteRawTag(162, 81);
        output.WriteMessage(BonusSelectAction);
      }
      if (pKEFIKCMDOM_ != null) {
        output.WriteRawTag(194, 83);
        output.WriteMessage(PKEFIKCMDOM);
      }
      if (buffSelectInfo_ != null) {
        output.WriteRawTag(226, 86);
        output.WriteMessage(BuffSelectInfo);
      }
      if (destroyMiracleAction_ != null) {
        output.WriteRawTag(218, 87);
        output.WriteMessage(DestroyMiracleAction);
      }
      if (repairMiracleAction_ != null) {
        output.WriteRawTag(146, 109);
        output.WriteMessage(RepairMiracleAction);
      }
      if (enhanceSelectInfo_ != null) {
        output.WriteRawTag(234, 114);
        output.WriteMessage(EnhanceSelectInfo);
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
      if (buffSelectInfo_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(BuffSelectInfo);
      }
      if (dropBuffAction_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(DropBuffAction);
      }
      if (enhanceSelectInfo_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(EnhanceSelectInfo);
      }
      if (miracleSelectInfo_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(MiracleSelectInfo);
      }
      if (dONMAOEJMEF_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(DONMAOEJMEF);
      }
      if (repairMiracleAction_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(RepairMiracleAction);
      }
      if (destroyMiracleAction_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(DestroyMiracleAction);
      }
      if (dropMiracleAction_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(DropMiracleAction);
      }
      if (pKEFIKCMDOM_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(PKEFIKCMDOM);
      }
      if (bonusSelectAction_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(BonusSelectAction);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueAction other) {
      if (other == null) {
        return;
      }
      if (other.buffSelectInfo_ != null) {
        if (buffSelectInfo_ == null) {
          BuffSelectInfo = new global::EggLink.DanhengServer.Proto.RogueBuffSelectAction();
        }
        BuffSelectInfo.MergeFrom(other.BuffSelectInfo);
      }
      if (other.dropBuffAction_ != null) {
        if (dropBuffAction_ == null) {
          DropBuffAction = new global::EggLink.DanhengServer.Proto.RogueBuffDropAction();
        }
        DropBuffAction.MergeFrom(other.DropBuffAction);
      }
      if (other.enhanceSelectInfo_ != null) {
        if (enhanceSelectInfo_ == null) {
          EnhanceSelectInfo = new global::EggLink.DanhengServer.Proto.RogueBuffEnhanceSelectAction();
        }
        EnhanceSelectInfo.MergeFrom(other.EnhanceSelectInfo);
      }
      if (other.miracleSelectInfo_ != null) {
        if (miracleSelectInfo_ == null) {
          MiracleSelectInfo = new global::EggLink.DanhengServer.Proto.RogueMiracleSelectAction();
        }
        MiracleSelectInfo.MergeFrom(other.MiracleSelectInfo);
      }
      if (other.dONMAOEJMEF_ != null) {
        if (dONMAOEJMEF_ == null) {
          DONMAOEJMEF = new global::EggLink.DanhengServer.Proto.CELLDKOCJIA();
        }
        DONMAOEJMEF.MergeFrom(other.DONMAOEJMEF);
      }
      if (other.repairMiracleAction_ != null) {
        if (repairMiracleAction_ == null) {
          RepairMiracleAction = new global::EggLink.DanhengServer.Proto.RogueMiracleRepairAction();
        }
        RepairMiracleAction.MergeFrom(other.RepairMiracleAction);
      }
      if (other.destroyMiracleAction_ != null) {
        if (destroyMiracleAction_ == null) {
          DestroyMiracleAction = new global::EggLink.DanhengServer.Proto.RogueMiracleDestoryAction();
        }
        DestroyMiracleAction.MergeFrom(other.DestroyMiracleAction);
      }
      if (other.dropMiracleAction_ != null) {
        if (dropMiracleAction_ == null) {
          DropMiracleAction = new global::EggLink.DanhengServer.Proto.RogueMiracleDropAction();
        }
        DropMiracleAction.MergeFrom(other.DropMiracleAction);
      }
      if (other.pKEFIKCMDOM_ != null) {
        if (pKEFIKCMDOM_ == null) {
          PKEFIKCMDOM = new global::EggLink.DanhengServer.Proto.RogueMiracleSelectDestoryedAction();
        }
        PKEFIKCMDOM.MergeFrom(other.PKEFIKCMDOM);
      }
      if (other.bonusSelectAction_ != null) {
        if (bonusSelectAction_ == null) {
          BonusSelectAction = new global::EggLink.DanhengServer.Proto.RogueBonusSelectAction();
        }
        BonusSelectAction.MergeFrom(other.BonusSelectAction);
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
          case 1570: {
            if (dropMiracleAction_ == null) {
              DropMiracleAction = new global::EggLink.DanhengServer.Proto.RogueMiracleDropAction();
            }
            input.ReadMessage(DropMiracleAction);
            break;
          }
          case 4722: {
            if (dropBuffAction_ == null) {
              DropBuffAction = new global::EggLink.DanhengServer.Proto.RogueBuffDropAction();
            }
            input.ReadMessage(DropBuffAction);
            break;
          }
          case 4946: {
            if (dONMAOEJMEF_ == null) {
              DONMAOEJMEF = new global::EggLink.DanhengServer.Proto.CELLDKOCJIA();
            }
            input.ReadMessage(DONMAOEJMEF);
            break;
          }
          case 9178: {
            if (miracleSelectInfo_ == null) {
              MiracleSelectInfo = new global::EggLink.DanhengServer.Proto.RogueMiracleSelectAction();
            }
            input.ReadMessage(MiracleSelectInfo);
            break;
          }
          case 10402: {
            if (bonusSelectAction_ == null) {
              BonusSelectAction = new global::EggLink.DanhengServer.Proto.RogueBonusSelectAction();
            }
            input.ReadMessage(BonusSelectAction);
            break;
          }
          case 10690: {
            if (pKEFIKCMDOM_ == null) {
              PKEFIKCMDOM = new global::EggLink.DanhengServer.Proto.RogueMiracleSelectDestoryedAction();
            }
            input.ReadMessage(PKEFIKCMDOM);
            break;
          }
          case 11106: {
            if (buffSelectInfo_ == null) {
              BuffSelectInfo = new global::EggLink.DanhengServer.Proto.RogueBuffSelectAction();
            }
            input.ReadMessage(BuffSelectInfo);
            break;
          }
          case 11226: {
            if (destroyMiracleAction_ == null) {
              DestroyMiracleAction = new global::EggLink.DanhengServer.Proto.RogueMiracleDestoryAction();
            }
            input.ReadMessage(DestroyMiracleAction);
            break;
          }
          case 13970: {
            if (repairMiracleAction_ == null) {
              RepairMiracleAction = new global::EggLink.DanhengServer.Proto.RogueMiracleRepairAction();
            }
            input.ReadMessage(RepairMiracleAction);
            break;
          }
          case 14698: {
            if (enhanceSelectInfo_ == null) {
              EnhanceSelectInfo = new global::EggLink.DanhengServer.Proto.RogueBuffEnhanceSelectAction();
            }
            input.ReadMessage(EnhanceSelectInfo);
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
          case 1570: {
            if (dropMiracleAction_ == null) {
              DropMiracleAction = new global::EggLink.DanhengServer.Proto.RogueMiracleDropAction();
            }
            input.ReadMessage(DropMiracleAction);
            break;
          }
          case 4722: {
            if (dropBuffAction_ == null) {
              DropBuffAction = new global::EggLink.DanhengServer.Proto.RogueBuffDropAction();
            }
            input.ReadMessage(DropBuffAction);
            break;
          }
          case 4946: {
            if (dONMAOEJMEF_ == null) {
              DONMAOEJMEF = new global::EggLink.DanhengServer.Proto.CELLDKOCJIA();
            }
            input.ReadMessage(DONMAOEJMEF);
            break;
          }
          case 9178: {
            if (miracleSelectInfo_ == null) {
              MiracleSelectInfo = new global::EggLink.DanhengServer.Proto.RogueMiracleSelectAction();
            }
            input.ReadMessage(MiracleSelectInfo);
            break;
          }
          case 10402: {
            if (bonusSelectAction_ == null) {
              BonusSelectAction = new global::EggLink.DanhengServer.Proto.RogueBonusSelectAction();
            }
            input.ReadMessage(BonusSelectAction);
            break;
          }
          case 10690: {
            if (pKEFIKCMDOM_ == null) {
              PKEFIKCMDOM = new global::EggLink.DanhengServer.Proto.RogueMiracleSelectDestoryedAction();
            }
            input.ReadMessage(PKEFIKCMDOM);
            break;
          }
          case 11106: {
            if (buffSelectInfo_ == null) {
              BuffSelectInfo = new global::EggLink.DanhengServer.Proto.RogueBuffSelectAction();
            }
            input.ReadMessage(BuffSelectInfo);
            break;
          }
          case 11226: {
            if (destroyMiracleAction_ == null) {
              DestroyMiracleAction = new global::EggLink.DanhengServer.Proto.RogueMiracleDestoryAction();
            }
            input.ReadMessage(DestroyMiracleAction);
            break;
          }
          case 13970: {
            if (repairMiracleAction_ == null) {
              RepairMiracleAction = new global::EggLink.DanhengServer.Proto.RogueMiracleRepairAction();
            }
            input.ReadMessage(RepairMiracleAction);
            break;
          }
          case 14698: {
            if (enhanceSelectInfo_ == null) {
              EnhanceSelectInfo = new global::EggLink.DanhengServer.Proto.RogueBuffEnhanceSelectAction();
            }
            input.ReadMessage(EnhanceSelectInfo);
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
