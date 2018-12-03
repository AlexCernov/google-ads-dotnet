// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/enums/content_label_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/enums/content_label_type.proto</summary>
  public static partial class ContentLabelTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/enums/content_label_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ContentLabelTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9jb250ZW50X2xhYmVs",
            "X3R5cGUucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLmVudW1zIu0C",
            "ChRDb250ZW50TGFiZWxUeXBlRW51bSLUAgoQQ29udGVudExhYmVsVHlwZRIP",
            "CgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIXChNTRVhVQUxMWV9TVUdH",
            "RVNUSVZFEAISEgoOQkVMT1dfVEhFX0ZPTEQQAxIRCg1QQVJLRURfRE9NQUlO",
            "EAQSCAoER0FNRRAFEgwKCEpVVkVOSUxFEAYSDQoJUFJPRkFOSVRZEAcSCwoH",
            "VFJBR0VEWRAIEgkKBVZJREVPEAkSFQoRVklERU9fUkFUSU5HX0RWX0cQChIW",
            "ChJWSURFT19SQVRJTkdfRFZfUEcQCxIVChFWSURFT19SQVRJTkdfRFZfVBAM",
            "EhYKElZJREVPX1JBVElOR19EVl9NQRANEhcKE1ZJREVPX05PVF9ZRVRfUkFU",
            "RUQQDhISCg5FTUJFRERFRF9WSURFTxAPEhgKFExJVkVfU1RSRUFNSU5HX1ZJ",
            "REVPEBBCxgEKIWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5lbnVtc0IV",
            "Q29udGVudExhYmVsVHlwZVByb3RvUAFaQmdvb2dsZS5nb2xhbmcub3JnL2dl",
            "bnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MC9lbnVtcztlbnVt",
            "c6ICA0dBQaoCHUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYwLkVudW1zygIdR29v",
            "Z2xlXEFkc1xHb29nbGVBZHNcVjBcRW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Enums.ContentLabelTypeEnum), global::Google.Ads.GoogleAds.V0.Enums.ContentLabelTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Enums.ContentLabelTypeEnum.Types.ContentLabelType) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing content label types in ContentLabel.
  /// </summary>
  public sealed partial class ContentLabelTypeEnum : pb::IMessage<ContentLabelTypeEnum> {
    private static readonly pb::MessageParser<ContentLabelTypeEnum> _parser = new pb::MessageParser<ContentLabelTypeEnum>(() => new ContentLabelTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ContentLabelTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Enums.ContentLabelTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContentLabelTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContentLabelTypeEnum(ContentLabelTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContentLabelTypeEnum Clone() {
      return new ContentLabelTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ContentLabelTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ContentLabelTypeEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ContentLabelTypeEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ContentLabelTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum listing the content label types supported by ContentLabel criterion.
      /// </summary>
      public enum ContentLabelType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Sexually suggestive content.
        /// </summary>
        [pbr::OriginalName("SEXUALLY_SUGGESTIVE")] SexuallySuggestive = 2,
        /// <summary>
        /// Below the fold placement.
        /// </summary>
        [pbr::OriginalName("BELOW_THE_FOLD")] BelowTheFold = 3,
        /// <summary>
        /// Parked domain.
        /// </summary>
        [pbr::OriginalName("PARKED_DOMAIN")] ParkedDomain = 4,
        /// <summary>
        /// Game.
        /// </summary>
        [pbr::OriginalName("GAME")] Game = 5,
        /// <summary>
        /// Juvenile, gross &amp; bizarre content.
        /// </summary>
        [pbr::OriginalName("JUVENILE")] Juvenile = 6,
        /// <summary>
        /// Profanity &amp; rough language.
        /// </summary>
        [pbr::OriginalName("PROFANITY")] Profanity = 7,
        /// <summary>
        /// Death &amp; tragedy.
        /// </summary>
        [pbr::OriginalName("TRAGEDY")] Tragedy = 8,
        /// <summary>
        /// Video.
        /// </summary>
        [pbr::OriginalName("VIDEO")] Video = 9,
        /// <summary>
        /// Content rating: G.
        /// </summary>
        [pbr::OriginalName("VIDEO_RATING_DV_G")] VideoRatingDvG = 10,
        /// <summary>
        /// Content rating: PG.
        /// </summary>
        [pbr::OriginalName("VIDEO_RATING_DV_PG")] VideoRatingDvPg = 11,
        /// <summary>
        /// Content rating: T.
        /// </summary>
        [pbr::OriginalName("VIDEO_RATING_DV_T")] VideoRatingDvT = 12,
        /// <summary>
        /// Content rating: MA.
        /// </summary>
        [pbr::OriginalName("VIDEO_RATING_DV_MA")] VideoRatingDvMa = 13,
        /// <summary>
        /// Content rating: not yet rated.
        /// </summary>
        [pbr::OriginalName("VIDEO_NOT_YET_RATED")] VideoNotYetRated = 14,
        /// <summary>
        /// Embedded video.
        /// </summary>
        [pbr::OriginalName("EMBEDDED_VIDEO")] EmbeddedVideo = 15,
        /// <summary>
        /// Live streaming video.
        /// </summary>
        [pbr::OriginalName("LIVE_STREAMING_VIDEO")] LiveStreamingVideo = 16,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code