// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Models/SessionBlueprintDao/SessionBlueprintDaoV2.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace LiftLog.Ui.Models.SessionBlueprintDao {

  /// <summary>Holder for reflection information generated from Models/SessionBlueprintDao/SessionBlueprintDaoV2.proto</summary>
  public static partial class SessionBlueprintDaoV2Reflection {

    #region Descriptor
    /// <summary>File descriptor for Models/SessionBlueprintDao/SessionBlueprintDaoV2.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SessionBlueprintDaoV2Reflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZNb2RlbHMvU2Vzc2lvbkJsdWVwcmludERhby9TZXNzaW9uQmx1ZXByaW50",
            "RGFvVjIucHJvdG8SJUxpZnRMb2cuVWkuTW9kZWxzLlNlc3Npb25CbHVlcHJp",
            "bnREYW8aEk1vZGVscy9VdGlscy5wcm90bxoeZ29vZ2xlL3Byb3RvYnVmL2R1",
            "cmF0aW9uLnByb3RvInoKHlNlc3Npb25CbHVlcHJpbnRDb250YWluZXJEYW9W",
            "MhJYChJzZXNzaW9uX2JsdWVwcmludHMYASADKAsyPC5MaWZ0TG9nLlVpLk1v",
            "ZGVscy5TZXNzaW9uQmx1ZXByaW50RGFvLlNlc3Npb25CbHVlcHJpbnREYW9W",
            "MiKQAQoVU2Vzc2lvbkJsdWVwcmludERhb1YyEgwKBG5hbWUYASABKAkSWgoT",
            "ZXhlcmNpc2VfYmx1ZXByaW50cxgCIAMoCzI9LkxpZnRMb2cuVWkuTW9kZWxz",
            "LlNlc3Npb25CbHVlcHJpbnREYW8uRXhlcmNpc2VCbHVlcHJpbnREYW9WMhIN",
            "CgVub3RlcxgDIAEoCSKNAgoWRXhlcmNpc2VCbHVlcHJpbnREYW9WMhIMCgRu",
            "YW1lGAEgASgJEgwKBHNldHMYAiABKAUSFAoMcmVwc19wZXJfc2V0GAMgASgF",
            "EkMKGndlaWdodF9pbmNyZWFzZV9vbl9zdWNjZXNzGAUgASgLMh8uTGlmdExv",
            "Zy5VaS5Nb2RlbHMuRGVjaW1hbFZhbHVlEksKEXJlc3RfYmV0d2Vlbl9zZXRz",
            "GAYgASgLMjAuTGlmdExvZy5VaS5Nb2RlbHMuU2Vzc2lvbkJsdWVwcmludERh",
            "by5SZXN0RGFvVjISGgoSc3VwZXJzZXRfd2l0aF9uZXh0GAcgASgIEg0KBW5v",
            "dGVzGAggASgJSgQIBBAFIpYBCglSZXN0RGFvVjISKwoIbWluX3Jlc3QYASAB",
            "KAsyGS5nb29nbGUucHJvdG9idWYuRHVyYXRpb24SKwoIbWF4X3Jlc3QYAiAB",
            "KAsyGS5nb29nbGUucHJvdG9idWYuRHVyYXRpb24SLwoMZmFpbHVyZV9yZXN0",
            "GAMgASgLMhkuZ29vZ2xlLnByb3RvYnVmLkR1cmF0aW9uYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::LiftLog.Ui.Models.UtilsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::LiftLog.Ui.Models.SessionBlueprintDao.SessionBlueprintContainerDaoV2), global::LiftLog.Ui.Models.SessionBlueprintDao.SessionBlueprintContainerDaoV2.Parser, new[]{ "SessionBlueprints" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::LiftLog.Ui.Models.SessionBlueprintDao.SessionBlueprintDaoV2), global::LiftLog.Ui.Models.SessionBlueprintDao.SessionBlueprintDaoV2.Parser, new[]{ "Name", "ExerciseBlueprints", "Notes" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::LiftLog.Ui.Models.SessionBlueprintDao.ExerciseBlueprintDaoV2), global::LiftLog.Ui.Models.SessionBlueprintDao.ExerciseBlueprintDaoV2.Parser, new[]{ "Name", "Sets", "RepsPerSet", "WeightIncreaseOnSuccess", "RestBetweenSets", "SupersetWithNext", "Notes" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::LiftLog.Ui.Models.SessionBlueprintDao.RestDaoV2), global::LiftLog.Ui.Models.SessionBlueprintDao.RestDaoV2.Parser, new[]{ "MinRest", "MaxRest", "FailureRest" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SessionBlueprintContainerDaoV2 : pb::IMessage<SessionBlueprintContainerDaoV2> {
    private static readonly pb::MessageParser<SessionBlueprintContainerDaoV2> _parser = new pb::MessageParser<SessionBlueprintContainerDaoV2>(() => new SessionBlueprintContainerDaoV2());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SessionBlueprintContainerDaoV2> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::LiftLog.Ui.Models.SessionBlueprintDao.SessionBlueprintDaoV2Reflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SessionBlueprintContainerDaoV2() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SessionBlueprintContainerDaoV2(SessionBlueprintContainerDaoV2 other) : this() {
      sessionBlueprints_ = other.sessionBlueprints_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SessionBlueprintContainerDaoV2 Clone() {
      return new SessionBlueprintContainerDaoV2(this);
    }

    /// <summary>Field number for the "session_blueprints" field.</summary>
    public const int SessionBlueprintsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::LiftLog.Ui.Models.SessionBlueprintDao.SessionBlueprintDaoV2> _repeated_sessionBlueprints_codec
        = pb::FieldCodec.ForMessage(10, global::LiftLog.Ui.Models.SessionBlueprintDao.SessionBlueprintDaoV2.Parser);
    private readonly pbc::RepeatedField<global::LiftLog.Ui.Models.SessionBlueprintDao.SessionBlueprintDaoV2> sessionBlueprints_ = new pbc::RepeatedField<global::LiftLog.Ui.Models.SessionBlueprintDao.SessionBlueprintDaoV2>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::LiftLog.Ui.Models.SessionBlueprintDao.SessionBlueprintDaoV2> SessionBlueprints {
      get { return sessionBlueprints_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SessionBlueprintContainerDaoV2);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SessionBlueprintContainerDaoV2 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!sessionBlueprints_.Equals(other.sessionBlueprints_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= sessionBlueprints_.GetHashCode();
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
      sessionBlueprints_.WriteTo(output, _repeated_sessionBlueprints_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += sessionBlueprints_.CalculateSize(_repeated_sessionBlueprints_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SessionBlueprintContainerDaoV2 other) {
      if (other == null) {
        return;
      }
      sessionBlueprints_.Add(other.sessionBlueprints_);
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
            sessionBlueprints_.AddEntriesFrom(input, _repeated_sessionBlueprints_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class SessionBlueprintDaoV2 : pb::IMessage<SessionBlueprintDaoV2> {
    private static readonly pb::MessageParser<SessionBlueprintDaoV2> _parser = new pb::MessageParser<SessionBlueprintDaoV2>(() => new SessionBlueprintDaoV2());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SessionBlueprintDaoV2> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::LiftLog.Ui.Models.SessionBlueprintDao.SessionBlueprintDaoV2Reflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SessionBlueprintDaoV2() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SessionBlueprintDaoV2(SessionBlueprintDaoV2 other) : this() {
      name_ = other.name_;
      exerciseBlueprints_ = other.exerciseBlueprints_.Clone();
      notes_ = other.notes_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SessionBlueprintDaoV2 Clone() {
      return new SessionBlueprintDaoV2(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "exercise_blueprints" field.</summary>
    public const int ExerciseBlueprintsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::LiftLog.Ui.Models.SessionBlueprintDao.ExerciseBlueprintDaoV2> _repeated_exerciseBlueprints_codec
        = pb::FieldCodec.ForMessage(18, global::LiftLog.Ui.Models.SessionBlueprintDao.ExerciseBlueprintDaoV2.Parser);
    private readonly pbc::RepeatedField<global::LiftLog.Ui.Models.SessionBlueprintDao.ExerciseBlueprintDaoV2> exerciseBlueprints_ = new pbc::RepeatedField<global::LiftLog.Ui.Models.SessionBlueprintDao.ExerciseBlueprintDaoV2>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::LiftLog.Ui.Models.SessionBlueprintDao.ExerciseBlueprintDaoV2> ExerciseBlueprints {
      get { return exerciseBlueprints_; }
    }

    /// <summary>Field number for the "notes" field.</summary>
    public const int NotesFieldNumber = 3;
    private string notes_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Notes {
      get { return notes_; }
      set {
        notes_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SessionBlueprintDaoV2);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SessionBlueprintDaoV2 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if(!exerciseBlueprints_.Equals(other.exerciseBlueprints_)) return false;
      if (Notes != other.Notes) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= exerciseBlueprints_.GetHashCode();
      if (Notes.Length != 0) hash ^= Notes.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      exerciseBlueprints_.WriteTo(output, _repeated_exerciseBlueprints_codec);
      if (Notes.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Notes);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += exerciseBlueprints_.CalculateSize(_repeated_exerciseBlueprints_codec);
      if (Notes.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Notes);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SessionBlueprintDaoV2 other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      exerciseBlueprints_.Add(other.exerciseBlueprints_);
      if (other.Notes.Length != 0) {
        Notes = other.Notes;
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            exerciseBlueprints_.AddEntriesFrom(input, _repeated_exerciseBlueprints_codec);
            break;
          }
          case 26: {
            Notes = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ExerciseBlueprintDaoV2 : pb::IMessage<ExerciseBlueprintDaoV2> {
    private static readonly pb::MessageParser<ExerciseBlueprintDaoV2> _parser = new pb::MessageParser<ExerciseBlueprintDaoV2>(() => new ExerciseBlueprintDaoV2());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ExerciseBlueprintDaoV2> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::LiftLog.Ui.Models.SessionBlueprintDao.SessionBlueprintDaoV2Reflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExerciseBlueprintDaoV2() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExerciseBlueprintDaoV2(ExerciseBlueprintDaoV2 other) : this() {
      name_ = other.name_;
      sets_ = other.sets_;
      repsPerSet_ = other.repsPerSet_;
      weightIncreaseOnSuccess_ = other.weightIncreaseOnSuccess_ != null ? other.weightIncreaseOnSuccess_.Clone() : null;
      restBetweenSets_ = other.restBetweenSets_ != null ? other.restBetweenSets_.Clone() : null;
      supersetWithNext_ = other.supersetWithNext_;
      notes_ = other.notes_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExerciseBlueprintDaoV2 Clone() {
      return new ExerciseBlueprintDaoV2(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sets" field.</summary>
    public const int SetsFieldNumber = 2;
    private int sets_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Sets {
      get { return sets_; }
      set {
        sets_ = value;
      }
    }

    /// <summary>Field number for the "reps_per_set" field.</summary>
    public const int RepsPerSetFieldNumber = 3;
    private int repsPerSet_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RepsPerSet {
      get { return repsPerSet_; }
      set {
        repsPerSet_ = value;
      }
    }

    /// <summary>Field number for the "weight_increase_on_success" field.</summary>
    public const int WeightIncreaseOnSuccessFieldNumber = 5;
    private global::LiftLog.Ui.Models.DecimalValue weightIncreaseOnSuccess_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::LiftLog.Ui.Models.DecimalValue WeightIncreaseOnSuccess {
      get { return weightIncreaseOnSuccess_; }
      set {
        weightIncreaseOnSuccess_ = value;
      }
    }

    /// <summary>Field number for the "rest_between_sets" field.</summary>
    public const int RestBetweenSetsFieldNumber = 6;
    private global::LiftLog.Ui.Models.SessionBlueprintDao.RestDaoV2 restBetweenSets_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::LiftLog.Ui.Models.SessionBlueprintDao.RestDaoV2 RestBetweenSets {
      get { return restBetweenSets_; }
      set {
        restBetweenSets_ = value;
      }
    }

    /// <summary>Field number for the "superset_with_next" field.</summary>
    public const int SupersetWithNextFieldNumber = 7;
    private bool supersetWithNext_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool SupersetWithNext {
      get { return supersetWithNext_; }
      set {
        supersetWithNext_ = value;
      }
    }

    /// <summary>Field number for the "notes" field.</summary>
    public const int NotesFieldNumber = 8;
    private string notes_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Notes {
      get { return notes_; }
      set {
        notes_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ExerciseBlueprintDaoV2);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ExerciseBlueprintDaoV2 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Sets != other.Sets) return false;
      if (RepsPerSet != other.RepsPerSet) return false;
      if (!object.Equals(WeightIncreaseOnSuccess, other.WeightIncreaseOnSuccess)) return false;
      if (!object.Equals(RestBetweenSets, other.RestBetweenSets)) return false;
      if (SupersetWithNext != other.SupersetWithNext) return false;
      if (Notes != other.Notes) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Sets != 0) hash ^= Sets.GetHashCode();
      if (RepsPerSet != 0) hash ^= RepsPerSet.GetHashCode();
      if (weightIncreaseOnSuccess_ != null) hash ^= WeightIncreaseOnSuccess.GetHashCode();
      if (restBetweenSets_ != null) hash ^= RestBetweenSets.GetHashCode();
      if (SupersetWithNext != false) hash ^= SupersetWithNext.GetHashCode();
      if (Notes.Length != 0) hash ^= Notes.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Sets != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Sets);
      }
      if (RepsPerSet != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(RepsPerSet);
      }
      if (weightIncreaseOnSuccess_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(WeightIncreaseOnSuccess);
      }
      if (restBetweenSets_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(RestBetweenSets);
      }
      if (SupersetWithNext != false) {
        output.WriteRawTag(56);
        output.WriteBool(SupersetWithNext);
      }
      if (Notes.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Notes);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Sets != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Sets);
      }
      if (RepsPerSet != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RepsPerSet);
      }
      if (weightIncreaseOnSuccess_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(WeightIncreaseOnSuccess);
      }
      if (restBetweenSets_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RestBetweenSets);
      }
      if (SupersetWithNext != false) {
        size += 1 + 1;
      }
      if (Notes.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Notes);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ExerciseBlueprintDaoV2 other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Sets != 0) {
        Sets = other.Sets;
      }
      if (other.RepsPerSet != 0) {
        RepsPerSet = other.RepsPerSet;
      }
      if (other.weightIncreaseOnSuccess_ != null) {
        if (weightIncreaseOnSuccess_ == null) {
          WeightIncreaseOnSuccess = new global::LiftLog.Ui.Models.DecimalValue();
        }
        WeightIncreaseOnSuccess.MergeFrom(other.WeightIncreaseOnSuccess);
      }
      if (other.restBetweenSets_ != null) {
        if (restBetweenSets_ == null) {
          RestBetweenSets = new global::LiftLog.Ui.Models.SessionBlueprintDao.RestDaoV2();
        }
        RestBetweenSets.MergeFrom(other.RestBetweenSets);
      }
      if (other.SupersetWithNext != false) {
        SupersetWithNext = other.SupersetWithNext;
      }
      if (other.Notes.Length != 0) {
        Notes = other.Notes;
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
            Name = input.ReadString();
            break;
          }
          case 16: {
            Sets = input.ReadInt32();
            break;
          }
          case 24: {
            RepsPerSet = input.ReadInt32();
            break;
          }
          case 42: {
            if (weightIncreaseOnSuccess_ == null) {
              WeightIncreaseOnSuccess = new global::LiftLog.Ui.Models.DecimalValue();
            }
            input.ReadMessage(WeightIncreaseOnSuccess);
            break;
          }
          case 50: {
            if (restBetweenSets_ == null) {
              RestBetweenSets = new global::LiftLog.Ui.Models.SessionBlueprintDao.RestDaoV2();
            }
            input.ReadMessage(RestBetweenSets);
            break;
          }
          case 56: {
            SupersetWithNext = input.ReadBool();
            break;
          }
          case 66: {
            Notes = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class RestDaoV2 : pb::IMessage<RestDaoV2> {
    private static readonly pb::MessageParser<RestDaoV2> _parser = new pb::MessageParser<RestDaoV2>(() => new RestDaoV2());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RestDaoV2> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::LiftLog.Ui.Models.SessionBlueprintDao.SessionBlueprintDaoV2Reflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RestDaoV2() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RestDaoV2(RestDaoV2 other) : this() {
      minRest_ = other.minRest_ != null ? other.minRest_.Clone() : null;
      maxRest_ = other.maxRest_ != null ? other.maxRest_.Clone() : null;
      failureRest_ = other.failureRest_ != null ? other.failureRest_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RestDaoV2 Clone() {
      return new RestDaoV2(this);
    }

    /// <summary>Field number for the "min_rest" field.</summary>
    public const int MinRestFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Duration minRest_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration MinRest {
      get { return minRest_; }
      set {
        minRest_ = value;
      }
    }

    /// <summary>Field number for the "max_rest" field.</summary>
    public const int MaxRestFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Duration maxRest_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration MaxRest {
      get { return maxRest_; }
      set {
        maxRest_ = value;
      }
    }

    /// <summary>Field number for the "failure_rest" field.</summary>
    public const int FailureRestFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Duration failureRest_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration FailureRest {
      get { return failureRest_; }
      set {
        failureRest_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RestDaoV2);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RestDaoV2 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(MinRest, other.MinRest)) return false;
      if (!object.Equals(MaxRest, other.MaxRest)) return false;
      if (!object.Equals(FailureRest, other.FailureRest)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (minRest_ != null) hash ^= MinRest.GetHashCode();
      if (maxRest_ != null) hash ^= MaxRest.GetHashCode();
      if (failureRest_ != null) hash ^= FailureRest.GetHashCode();
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
      if (minRest_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(MinRest);
      }
      if (maxRest_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(MaxRest);
      }
      if (failureRest_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(FailureRest);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (minRest_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MinRest);
      }
      if (maxRest_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MaxRest);
      }
      if (failureRest_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FailureRest);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RestDaoV2 other) {
      if (other == null) {
        return;
      }
      if (other.minRest_ != null) {
        if (minRest_ == null) {
          MinRest = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        MinRest.MergeFrom(other.MinRest);
      }
      if (other.maxRest_ != null) {
        if (maxRest_ == null) {
          MaxRest = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        MaxRest.MergeFrom(other.MaxRest);
      }
      if (other.failureRest_ != null) {
        if (failureRest_ == null) {
          FailureRest = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        FailureRest.MergeFrom(other.FailureRest);
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
            if (minRest_ == null) {
              MinRest = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(MinRest);
            break;
          }
          case 18: {
            if (maxRest_ == null) {
              MaxRest = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(MaxRest);
            break;
          }
          case 26: {
            if (failureRest_ == null) {
              FailureRest = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(FailureRest);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code