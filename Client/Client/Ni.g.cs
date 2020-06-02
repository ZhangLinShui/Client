// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: proto/ni.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using scg = global::System.Collections.Generic;
namespace Google.Protobuf.WellKnownTypes {

  #region Messages
  public sealed class Person : pb::IMessage {
    private static readonly pb::MessageParser<Person> _parser = new pb::MessageParser<Person>(() => new Person());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Person> Parser { get { return _parser; } }

    /// <summary>Field number for the "aliases" field.</summary>
    public const int AliasesFieldNumber = 8;
    private string aliases_ = "";
    /// <summary>
    /// Other fields elided
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Aliases {
      get { return aliases_; }
      set {
        aliases_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "body" field.</summary>
    public const int BodyFieldNumber = 4;
    private pb::ByteString body_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Body {
      get { return body_; }
      set {
        body_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "bodyLength" field.</summary>
    public const int BodyLengthFieldNumber = 5;
    private int bodyLength_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BodyLength {
      get { return bodyLength_; }
      set {
        bodyLength_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Body.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(Body);
      }
      if (BodyLength != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(BodyLength);
      }
      if (Aliases.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Aliases);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Aliases.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Aliases);
      }
      if (Body.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Body);
      }
      if (BodyLength != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BodyLength);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 34: {
            Body = input.ReadBytes();
            break;
          }
          case 40: {
            BodyLength = input.ReadInt32();
            break;
          }
          case 66: {
            Aliases = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
