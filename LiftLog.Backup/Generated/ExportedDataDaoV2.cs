// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Models/ExportedDataDao/ExportedDataDaoV2.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace LiftLog.Ui.Models.ExportedDataDao {

  /// <summary>Holder for reflection information generated from Models/ExportedDataDao/ExportedDataDaoV2.proto</summary>
  public static partial class ExportedDataDaoV2Reflection {

    #region Descriptor
    /// <summary>File descriptor for Models/ExportedDataDao/ExportedDataDaoV2.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExportedDataDaoV2Reflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5Nb2RlbHMvRXhwb3J0ZWREYXRhRGFvL0V4cG9ydGVkRGF0YURhb1YyLnBy",
            "b3RvEiFMaWZ0TG9nLlVpLk1vZGVscy5FeHBvcnRlZERhdGFEYW8aMk1vZGVs",
            "cy9TZXNzaW9uSGlzdG9yeURhby9TZXNzaW9uSGlzdG9yeURhb1YyLnByb3Rv",
            "GjZNb2RlbHMvU2Vzc2lvbkJsdWVwcmludERhby9TZXNzaW9uQmx1ZXByaW50",
            "RGFvVjIucHJvdG8aNk1vZGVscy9Qcm9ncmFtQmx1ZXByaW50RGFvL1Byb2dy",
            "YW1CbHVlcHJpbnREYW9WMS5wcm90bxoZTW9kZWxzL0ZlZWRTdGF0ZURhby5w",
            "cm90bxoeZ29vZ2xlL3Byb3RvYnVmL3dyYXBwZXJzLnByb3RvIuwDChFFeHBv",
            "cnRlZERhdGFEYW9WMhJDCghzZXNzaW9ucxgBIAMoCzIxLkxpZnRMb2cuVWku",
            "TW9kZWxzLlNlc3Npb25IaXN0b3J5RGFvLlNlc3Npb25EYW9WMhJNCgdwcm9n",
            "cmFtGAIgAygLMjwuTGlmdExvZy5VaS5Nb2RlbHMuU2Vzc2lvbkJsdWVwcmlu",
            "dERhby5TZXNzaW9uQmx1ZXByaW50RGFvVjISXwoOc2F2ZWRfcHJvZ3JhbXMY",
            "AyADKAsyRy5MaWZ0TG9nLlVpLk1vZGVscy5FeHBvcnRlZERhdGFEYW8uRXhw",
            "b3J0ZWREYXRhRGFvVjIuU2F2ZWRQcm9ncmFtc0VudHJ5EjcKEWFjdGl2ZV9w",
            "cm9ncmFtX2lkGAQgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVl",
            "EjUKCmZlZWRfc3RhdGUYBSABKAsyIS5MaWZ0TG9nLlVpLk1vZGVscy5GZWVk",
            "U3RhdGVEYW9WMRpyChJTYXZlZFByb2dyYW1zRW50cnkSCwoDa2V5GAEgASgJ",
            "EksKBXZhbHVlGAIgASgLMjwuTGlmdExvZy5VaS5Nb2RlbHMuUHJvZ3JhbUJs",
            "dWVwcmludERhby5Qcm9ncmFtQmx1ZXByaW50RGFvVjE6AjgBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::LiftLog.Ui.Models.SessionHistoryDao.SessionHistoryDaoV2Reflection.Descriptor, global::LiftLog.Ui.Models.SessionBlueprintDao.SessionBlueprintDaoV2Reflection.Descriptor, global::LiftLog.Ui.Models.ProgramBlueprintDao.ProgramBlueprintDaoV1Reflection.Descriptor, global::LiftLog.Ui.Models.FeedStateDaoReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::LiftLog.Ui.Models.ExportedDataDao.ExportedDataDaoV2), global::LiftLog.Ui.Models.ExportedDataDao.ExportedDataDaoV2.Parser, new[]{ "Sessions", "Program", "SavedPrograms", "ActiveProgramId", "FeedState" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ExportedDataDaoV2 : pb::IMessage<ExportedDataDaoV2> {
    private static readonly pb::MessageParser<ExportedDataDaoV2> _parser = new pb::MessageParser<ExportedDataDaoV2>(() => new ExportedDataDaoV2());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ExportedDataDaoV2> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::LiftLog.Ui.Models.ExportedDataDao.ExportedDataDaoV2Reflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExportedDataDaoV2() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExportedDataDaoV2(ExportedDataDaoV2 other) : this() {
      sessions_ = other.sessions_.Clone();
      program_ = other.program_.Clone();
      savedPrograms_ = other.savedPrograms_.Clone();
      ActiveProgramId = other.ActiveProgramId;
      feedState_ = other.feedState_ != null ? other.feedState_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExportedDataDaoV2 Clone() {
      return new ExportedDataDaoV2(this);
    }

    /// <summary>Field number for the "sessions" field.</summary>
    public const int SessionsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::LiftLog.Ui.Models.SessionHistoryDao.SessionDaoV2> _repeated_sessions_codec
        = pb::FieldCodec.ForMessage(10, global::LiftLog.Ui.Models.SessionHistoryDao.SessionDaoV2.Parser);
    private readonly pbc::RepeatedField<global::LiftLog.Ui.Models.SessionHistoryDao.SessionDaoV2> sessions_ = new pbc::RepeatedField<global::LiftLog.Ui.Models.SessionHistoryDao.SessionDaoV2>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::LiftLog.Ui.Models.SessionHistoryDao.SessionDaoV2> Sessions {
      get { return sessions_; }
    }

    /// <summary>Field number for the "program" field.</summary>
    public const int ProgramFieldNumber = 2;
    private static readonly pb::FieldCodec<global::LiftLog.Ui.Models.SessionBlueprintDao.SessionBlueprintDaoV2> _repeated_program_codec
        = pb::FieldCodec.ForMessage(18, global::LiftLog.Ui.Models.SessionBlueprintDao.SessionBlueprintDaoV2.Parser);
    private readonly pbc::RepeatedField<global::LiftLog.Ui.Models.SessionBlueprintDao.SessionBlueprintDaoV2> program_ = new pbc::RepeatedField<global::LiftLog.Ui.Models.SessionBlueprintDao.SessionBlueprintDaoV2>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::LiftLog.Ui.Models.SessionBlueprintDao.SessionBlueprintDaoV2> Program {
      get { return program_; }
    }

    /// <summary>Field number for the "saved_programs" field.</summary>
    public const int SavedProgramsFieldNumber = 3;
    private static readonly pbc::MapField<string, global::LiftLog.Ui.Models.ProgramBlueprintDao.ProgramBlueprintDaoV1>.Codec _map_savedPrograms_codec
        = new pbc::MapField<string, global::LiftLog.Ui.Models.ProgramBlueprintDao.ProgramBlueprintDaoV1>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForMessage(18, global::LiftLog.Ui.Models.ProgramBlueprintDao.ProgramBlueprintDaoV1.Parser), 26);
    private readonly pbc::MapField<string, global::LiftLog.Ui.Models.ProgramBlueprintDao.ProgramBlueprintDaoV1> savedPrograms_ = new pbc::MapField<string, global::LiftLog.Ui.Models.ProgramBlueprintDao.ProgramBlueprintDaoV1>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::LiftLog.Ui.Models.ProgramBlueprintDao.ProgramBlueprintDaoV1> SavedPrograms {
      get { return savedPrograms_; }
    }

    /// <summary>Field number for the "active_program_id" field.</summary>
    public const int ActiveProgramIdFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _single_activeProgramId_codec = pb::FieldCodec.ForClassWrapper<string>(34);
    private string activeProgramId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ActiveProgramId {
      get { return activeProgramId_; }
      set {
        activeProgramId_ = value;
      }
    }


    /// <summary>Field number for the "feed_state" field.</summary>
    public const int FeedStateFieldNumber = 5;
    private global::LiftLog.Ui.Models.FeedStateDaoV1 feedState_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::LiftLog.Ui.Models.FeedStateDaoV1 FeedState {
      get { return feedState_; }
      set {
        feedState_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ExportedDataDaoV2);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ExportedDataDaoV2 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!sessions_.Equals(other.sessions_)) return false;
      if(!program_.Equals(other.program_)) return false;
      if (!SavedPrograms.Equals(other.SavedPrograms)) return false;
      if (ActiveProgramId != other.ActiveProgramId) return false;
      if (!object.Equals(FeedState, other.FeedState)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= sessions_.GetHashCode();
      hash ^= program_.GetHashCode();
      hash ^= SavedPrograms.GetHashCode();
      if (activeProgramId_ != null) hash ^= ActiveProgramId.GetHashCode();
      if (feedState_ != null) hash ^= FeedState.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      sessions_.WriteTo(output, _repeated_sessions_codec);
      program_.WriteTo(output, _repeated_program_codec);
      savedPrograms_.WriteTo(output, _map_savedPrograms_codec);
      if (activeProgramId_ != null) {
        _single_activeProgramId_codec.WriteTagAndValue(output, ActiveProgramId);
      }
      if (feedState_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(FeedState);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += sessions_.CalculateSize(_repeated_sessions_codec);
      size += program_.CalculateSize(_repeated_program_codec);
      size += savedPrograms_.CalculateSize(_map_savedPrograms_codec);
      if (activeProgramId_ != null) {
        size += _single_activeProgramId_codec.CalculateSizeWithTag(ActiveProgramId);
      }
      if (feedState_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FeedState);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ExportedDataDaoV2 other) {
      if (other == null) {
        return;
      }
      sessions_.Add(other.sessions_);
      program_.Add(other.program_);
      savedPrograms_.Add(other.savedPrograms_);
      if (other.activeProgramId_ != null) {
        if (activeProgramId_ == null || other.ActiveProgramId != "") {
          ActiveProgramId = other.ActiveProgramId;
        }
      }
      if (other.feedState_ != null) {
        if (feedState_ == null) {
          FeedState = new global::LiftLog.Ui.Models.FeedStateDaoV1();
        }
        FeedState.MergeFrom(other.FeedState);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            sessions_.AddEntriesFrom(input, _repeated_sessions_codec);
            break;
          }
          case 18: {
            program_.AddEntriesFrom(input, _repeated_program_codec);
            break;
          }
          case 26: {
            savedPrograms_.AddEntriesFrom(input, _map_savedPrograms_codec);
            break;
          }
          case 34: {
            string value = _single_activeProgramId_codec.Read(input);
            if (activeProgramId_ == null || value != "") {
              ActiveProgramId = value;
            }
            break;
          }
          case 42: {
            if (feedState_ == null) {
              FeedState = new global::LiftLog.Ui.Models.FeedStateDaoV1();
            }
            input.ReadMessage(FeedState);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
