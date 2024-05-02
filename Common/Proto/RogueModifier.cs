// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueModifier.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueModifier.proto</summary>
  public static partial class RogueModifierReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueModifier.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueModifierReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNSb2d1ZU1vZGlmaWVyLnByb3RvGhpSb2d1ZU1vZGlmaWVyQ29udGVudC5w",
            "cm90bxoXUm9ndWVNb2RpZmllckluZm8ucHJvdG8aHVJvZ3VlTW9kaWZpZXJT",
            "b3VyY2VUeXBlLnByb3RvIrABCg1Sb2d1ZU1vZGlmaWVyEikKDW1vZGlmaWVy",
            "X2luZm8YBSABKAsyEi5Sb2d1ZU1vZGlmaWVySW5mbxI2ChRtb2RpZmllcl9z",
            "b3VyY2VfdHlwZRgNIAEoDjIYLlJvZ3VlTW9kaWZpZXJTb3VyY2VUeXBlEhMK",
            "C21vZGlmaWVyX2lkGAsgASgEEicKB2NvbnRlbnQY7QogASgLMhUuUm9ndWVN",
            "b2RpZmllckNvbnRlbnRCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.RogueModifierContentReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueModifierInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.RogueModifierSourceTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.RogueModifier), global::EggLink.DanhengServer.Proto.RogueModifier.Parser, new[]{ "ModifierInfo", "ModifierSourceType", "ModifierId", "Content" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RogueModifier : pb::IMessage<RogueModifier>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueModifier> _parser = new pb::MessageParser<RogueModifier>(() => new RogueModifier());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueModifier> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.RogueModifierReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueModifier() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueModifier(RogueModifier other) : this() {
      modifierInfo_ = other.modifierInfo_ != null ? other.modifierInfo_.Clone() : null;
      modifierSourceType_ = other.modifierSourceType_;
      modifierId_ = other.modifierId_;
      content_ = other.content_ != null ? other.content_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueModifier Clone() {
      return new RogueModifier(this);
    }

    /// <summary>Field number for the "modifier_info" field.</summary>
    public const int ModifierInfoFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.RogueModifierInfo modifierInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueModifierInfo ModifierInfo {
      get { return modifierInfo_; }
      set {
        modifierInfo_ = value;
      }
    }

    /// <summary>Field number for the "modifier_source_type" field.</summary>
    public const int ModifierSourceTypeFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.RogueModifierSourceType modifierSourceType_ = global::EggLink.DanhengServer.Proto.RogueModifierSourceType.RogueModifierSourceNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueModifierSourceType ModifierSourceType {
      get { return modifierSourceType_; }
      set {
        modifierSourceType_ = value;
      }
    }

    /// <summary>Field number for the "modifier_id" field.</summary>
    public const int ModifierIdFieldNumber = 11;
    private ulong modifierId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong ModifierId {
      get { return modifierId_; }
      set {
        modifierId_ = value;
      }
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 1389;
    private global::EggLink.DanhengServer.Proto.RogueModifierContent content_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.RogueModifierContent Content {
      get { return content_; }
      set {
        content_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueModifier);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueModifier other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ModifierInfo, other.ModifierInfo)) return false;
      if (ModifierSourceType != other.ModifierSourceType) return false;
      if (ModifierId != other.ModifierId) return false;
      if (!object.Equals(Content, other.Content)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (modifierInfo_ != null) hash ^= ModifierInfo.GetHashCode();
      if (ModifierSourceType != global::EggLink.DanhengServer.Proto.RogueModifierSourceType.RogueModifierSourceNone) hash ^= ModifierSourceType.GetHashCode();
      if (ModifierId != 0UL) hash ^= ModifierId.GetHashCode();
      if (content_ != null) hash ^= Content.GetHashCode();
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
      if (modifierInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ModifierInfo);
      }
      if (ModifierId != 0UL) {
        output.WriteRawTag(88);
        output.WriteUInt64(ModifierId);
      }
      if (ModifierSourceType != global::EggLink.DanhengServer.Proto.RogueModifierSourceType.RogueModifierSourceNone) {
        output.WriteRawTag(104);
        output.WriteEnum((int) ModifierSourceType);
      }
      if (content_ != null) {
        output.WriteRawTag(234, 86);
        output.WriteMessage(Content);
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
      if (modifierInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ModifierInfo);
      }
      if (ModifierId != 0UL) {
        output.WriteRawTag(88);
        output.WriteUInt64(ModifierId);
      }
      if (ModifierSourceType != global::EggLink.DanhengServer.Proto.RogueModifierSourceType.RogueModifierSourceNone) {
        output.WriteRawTag(104);
        output.WriteEnum((int) ModifierSourceType);
      }
      if (content_ != null) {
        output.WriteRawTag(234, 86);
        output.WriteMessage(Content);
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
      if (modifierInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ModifierInfo);
      }
      if (ModifierSourceType != global::EggLink.DanhengServer.Proto.RogueModifierSourceType.RogueModifierSourceNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ModifierSourceType);
      }
      if (ModifierId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ModifierId);
      }
      if (content_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(Content);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueModifier other) {
      if (other == null) {
        return;
      }
      if (other.modifierInfo_ != null) {
        if (modifierInfo_ == null) {
          ModifierInfo = new global::EggLink.DanhengServer.Proto.RogueModifierInfo();
        }
        ModifierInfo.MergeFrom(other.ModifierInfo);
      }
      if (other.ModifierSourceType != global::EggLink.DanhengServer.Proto.RogueModifierSourceType.RogueModifierSourceNone) {
        ModifierSourceType = other.ModifierSourceType;
      }
      if (other.ModifierId != 0UL) {
        ModifierId = other.ModifierId;
      }
      if (other.content_ != null) {
        if (content_ == null) {
          Content = new global::EggLink.DanhengServer.Proto.RogueModifierContent();
        }
        Content.MergeFrom(other.Content);
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
          case 42: {
            if (modifierInfo_ == null) {
              ModifierInfo = new global::EggLink.DanhengServer.Proto.RogueModifierInfo();
            }
            input.ReadMessage(ModifierInfo);
            break;
          }
          case 88: {
            ModifierId = input.ReadUInt64();
            break;
          }
          case 104: {
            ModifierSourceType = (global::EggLink.DanhengServer.Proto.RogueModifierSourceType) input.ReadEnum();
            break;
          }
          case 11114: {
            if (content_ == null) {
              Content = new global::EggLink.DanhengServer.Proto.RogueModifierContent();
            }
            input.ReadMessage(Content);
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
          case 42: {
            if (modifierInfo_ == null) {
              ModifierInfo = new global::EggLink.DanhengServer.Proto.RogueModifierInfo();
            }
            input.ReadMessage(ModifierInfo);
            break;
          }
          case 88: {
            ModifierId = input.ReadUInt64();
            break;
          }
          case 104: {
            ModifierSourceType = (global::EggLink.DanhengServer.Proto.RogueModifierSourceType) input.ReadEnum();
            break;
          }
          case 11114: {
            if (content_ == null) {
              Content = new global::EggLink.DanhengServer.Proto.RogueModifierContent();
            }
            input.ReadMessage(Content);
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
