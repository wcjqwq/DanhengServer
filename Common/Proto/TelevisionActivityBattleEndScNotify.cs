// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TelevisionActivityBattleEndScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from TelevisionActivityBattleEndScNotify.proto</summary>
  public static partial class TelevisionActivityBattleEndScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for TelevisionActivityBattleEndScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TelevisionActivityBattleEndScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilUZWxldmlzaW9uQWN0aXZpdHlCYXR0bGVFbmRTY05vdGlmeS5wcm90bxoc",
            "VGVsZXZpc2lvbkFjdGl2aXR5RGF0YS5wcm90byKnAQojVGVsZXZpc2lvbkFj",
            "dGl2aXR5QmF0dGxlRW5kU2NOb3RpZnkSEwoLRkdGUEtFQUZLSkEYCSABKA0S",
            "EwoLR0pMTUZPSkFCSUoYBiABKA0SEwoLdG90YWxfc2NvcmUYAiABKA0SLAoL",
            "RUFHUEJFTk5KQ0YYDSABKAsyFy5UZWxldmlzaW9uQWN0aXZpdHlEYXRhEhMK",
            "C0tCR0tPR0xKQ0hCGAcgASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
            "UHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.TelevisionActivityDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.TelevisionActivityBattleEndScNotify), global::EggLink.DanhengServer.Proto.TelevisionActivityBattleEndScNotify.Parser, new[]{ "FGFPKEAFKJA", "GJLMFOJABIJ", "TotalScore", "EAGPBENNJCF", "KBGKOGLJCHB" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TelevisionActivityBattleEndScNotify : pb::IMessage<TelevisionActivityBattleEndScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TelevisionActivityBattleEndScNotify> _parser = new pb::MessageParser<TelevisionActivityBattleEndScNotify>(() => new TelevisionActivityBattleEndScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TelevisionActivityBattleEndScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.TelevisionActivityBattleEndScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TelevisionActivityBattleEndScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TelevisionActivityBattleEndScNotify(TelevisionActivityBattleEndScNotify other) : this() {
      fGFPKEAFKJA_ = other.fGFPKEAFKJA_;
      gJLMFOJABIJ_ = other.gJLMFOJABIJ_;
      totalScore_ = other.totalScore_;
      eAGPBENNJCF_ = other.eAGPBENNJCF_ != null ? other.eAGPBENNJCF_.Clone() : null;
      kBGKOGLJCHB_ = other.kBGKOGLJCHB_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TelevisionActivityBattleEndScNotify Clone() {
      return new TelevisionActivityBattleEndScNotify(this);
    }

    /// <summary>Field number for the "FGFPKEAFKJA" field.</summary>
    public const int FGFPKEAFKJAFieldNumber = 9;
    private uint fGFPKEAFKJA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FGFPKEAFKJA {
      get { return fGFPKEAFKJA_; }
      set {
        fGFPKEAFKJA_ = value;
      }
    }

    /// <summary>Field number for the "GJLMFOJABIJ" field.</summary>
    public const int GJLMFOJABIJFieldNumber = 6;
    private uint gJLMFOJABIJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GJLMFOJABIJ {
      get { return gJLMFOJABIJ_; }
      set {
        gJLMFOJABIJ_ = value;
      }
    }

    /// <summary>Field number for the "total_score" field.</summary>
    public const int TotalScoreFieldNumber = 2;
    private uint totalScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalScore {
      get { return totalScore_; }
      set {
        totalScore_ = value;
      }
    }

    /// <summary>Field number for the "EAGPBENNJCF" field.</summary>
    public const int EAGPBENNJCFFieldNumber = 13;
    private global::EggLink.DanhengServer.Proto.TelevisionActivityData eAGPBENNJCF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.TelevisionActivityData EAGPBENNJCF {
      get { return eAGPBENNJCF_; }
      set {
        eAGPBENNJCF_ = value;
      }
    }

    /// <summary>Field number for the "KBGKOGLJCHB" field.</summary>
    public const int KBGKOGLJCHBFieldNumber = 7;
    private uint kBGKOGLJCHB_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KBGKOGLJCHB {
      get { return kBGKOGLJCHB_; }
      set {
        kBGKOGLJCHB_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TelevisionActivityBattleEndScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TelevisionActivityBattleEndScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FGFPKEAFKJA != other.FGFPKEAFKJA) return false;
      if (GJLMFOJABIJ != other.GJLMFOJABIJ) return false;
      if (TotalScore != other.TotalScore) return false;
      if (!object.Equals(EAGPBENNJCF, other.EAGPBENNJCF)) return false;
      if (KBGKOGLJCHB != other.KBGKOGLJCHB) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FGFPKEAFKJA != 0) hash ^= FGFPKEAFKJA.GetHashCode();
      if (GJLMFOJABIJ != 0) hash ^= GJLMFOJABIJ.GetHashCode();
      if (TotalScore != 0) hash ^= TotalScore.GetHashCode();
      if (eAGPBENNJCF_ != null) hash ^= EAGPBENNJCF.GetHashCode();
      if (KBGKOGLJCHB != 0) hash ^= KBGKOGLJCHB.GetHashCode();
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
      if (TotalScore != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(TotalScore);
      }
      if (GJLMFOJABIJ != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(GJLMFOJABIJ);
      }
      if (KBGKOGLJCHB != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(KBGKOGLJCHB);
      }
      if (FGFPKEAFKJA != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(FGFPKEAFKJA);
      }
      if (eAGPBENNJCF_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(EAGPBENNJCF);
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
      if (TotalScore != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(TotalScore);
      }
      if (GJLMFOJABIJ != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(GJLMFOJABIJ);
      }
      if (KBGKOGLJCHB != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(KBGKOGLJCHB);
      }
      if (FGFPKEAFKJA != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(FGFPKEAFKJA);
      }
      if (eAGPBENNJCF_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(EAGPBENNJCF);
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
      if (FGFPKEAFKJA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FGFPKEAFKJA);
      }
      if (GJLMFOJABIJ != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GJLMFOJABIJ);
      }
      if (TotalScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalScore);
      }
      if (eAGPBENNJCF_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EAGPBENNJCF);
      }
      if (KBGKOGLJCHB != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KBGKOGLJCHB);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TelevisionActivityBattleEndScNotify other) {
      if (other == null) {
        return;
      }
      if (other.FGFPKEAFKJA != 0) {
        FGFPKEAFKJA = other.FGFPKEAFKJA;
      }
      if (other.GJLMFOJABIJ != 0) {
        GJLMFOJABIJ = other.GJLMFOJABIJ;
      }
      if (other.TotalScore != 0) {
        TotalScore = other.TotalScore;
      }
      if (other.eAGPBENNJCF_ != null) {
        if (eAGPBENNJCF_ == null) {
          EAGPBENNJCF = new global::EggLink.DanhengServer.Proto.TelevisionActivityData();
        }
        EAGPBENNJCF.MergeFrom(other.EAGPBENNJCF);
      }
      if (other.KBGKOGLJCHB != 0) {
        KBGKOGLJCHB = other.KBGKOGLJCHB;
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
          case 16: {
            TotalScore = input.ReadUInt32();
            break;
          }
          case 48: {
            GJLMFOJABIJ = input.ReadUInt32();
            break;
          }
          case 56: {
            KBGKOGLJCHB = input.ReadUInt32();
            break;
          }
          case 72: {
            FGFPKEAFKJA = input.ReadUInt32();
            break;
          }
          case 106: {
            if (eAGPBENNJCF_ == null) {
              EAGPBENNJCF = new global::EggLink.DanhengServer.Proto.TelevisionActivityData();
            }
            input.ReadMessage(EAGPBENNJCF);
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
          case 16: {
            TotalScore = input.ReadUInt32();
            break;
          }
          case 48: {
            GJLMFOJABIJ = input.ReadUInt32();
            break;
          }
          case 56: {
            KBGKOGLJCHB = input.ReadUInt32();
            break;
          }
          case 72: {
            FGFPKEAFKJA = input.ReadUInt32();
            break;
          }
          case 106: {
            if (eAGPBENNJCF_ == null) {
              EAGPBENNJCF = new global::EggLink.DanhengServer.Proto.TelevisionActivityData();
            }
            input.ReadMessage(EAGPBENNJCF);
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
