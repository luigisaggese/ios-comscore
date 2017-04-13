//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

[Protocol (Name = "SCORStreamingAnalyticsProtocol", WrapperType = typeof (SCORStreamingAnalyticsProtocolWrapper))]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyPlayWithPosition", Selector = "notifyPlayWithPosition:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyPlayWithPosition", Selector = "notifyPlayWithPosition:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyPlayWithLabels", Selector = "notifyPlayWithLabels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyPauseWithPosition", Selector = "notifyPauseWithPosition:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyPauseWithPosition", Selector = "notifyPauseWithPosition:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyPauseWithLabels", Selector = "notifyPauseWithLabels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyEndWithPosition", Selector = "notifyEndWithPosition:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyEndWithPosition", Selector = "notifyEndWithPosition:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyEndWithLabels", Selector = "notifyEndWithLabels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyBufferStartWithPosition", Selector = "notifyBufferStartWithPosition:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyBufferStartWithPosition", Selector = "notifyBufferStartWithPosition:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyBufferStartWithLabels", Selector = "notifyBufferStartWithLabels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyBufferStopWithPosition", Selector = "notifyBufferStopWithPosition:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyBufferStopWithPosition", Selector = "notifyBufferStopWithPosition:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyBufferStopWithLabels", Selector = "notifyBufferStopWithLabels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyLoadWithPosition", Selector = "notifyLoadWithPosition:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyLoadWithPosition", Selector = "notifyLoadWithPosition:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyLoadWithLabels", Selector = "notifyLoadWithLabels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyEngageWithPosition", Selector = "notifyEngageWithPosition:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyEngageWithPosition", Selector = "notifyEngageWithPosition:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyEngageWithLabels", Selector = "notifyEngageWithLabels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifySeekStartWithPosition", Selector = "notifySeekStartWithPosition:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifySeekStartWithPosition", Selector = "notifySeekStartWithPosition:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifySeekStartWithLabels", Selector = "notifySeekStartWithLabels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifySkipAdWithPosition", Selector = "notifySkipAdWithPosition:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifySkipAdWithPosition", Selector = "notifySkipAdWithPosition:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifySkipAdWithLabels", Selector = "notifySkipAdWithLabels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyCustomEventWithPosition", Selector = "notifyCustomEventWithPosition:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyCustomEventWithPosition", Selector = "notifyCustomEventWithPosition:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyCustomEventWithLabels", Selector = "notifyCustomEventWithLabels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyCallToActionWithPosition", Selector = "notifyCallToActionWithPosition:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyCallToActionWithPosition", Selector = "notifyCallToActionWithPosition:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyCallToActionWithLabels", Selector = "notifyCallToActionWithLabels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyErrorWithPosition", Selector = "notifyErrorWithPosition:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyErrorWithPosition", Selector = "notifyErrorWithPosition:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyErrorWithLabels", Selector = "notifyErrorWithLabels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyTransferPlaybackWithPosition", Selector = "notifyTransferPlaybackWithPosition:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyTransferPlaybackWithPosition", Selector = "notifyTransferPlaybackWithPosition:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyTransferPlaybackWithLabels", Selector = "notifyTransferPlaybackWithLabels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyDRMFailWithPosition", Selector = "notifyDRMFailWithPosition:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyDRMFailWithPosition", Selector = "notifyDRMFailWithPosition:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyDRMFailWithLabels", Selector = "notifyDRMFailWithLabels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyDRMApproveWithPosition", Selector = "notifyDRMApproveWithPosition:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyDRMApproveWithPosition", Selector = "notifyDRMApproveWithPosition:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyDRMApproveWithLabels", Selector = "notifyDRMApproveWithLabels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyDRMDenyWithPosition", Selector = "notifyDRMDenyWithPosition:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyDRMDenyWithPosition", Selector = "notifyDRMDenyWithPosition:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyDRMDenyWithLabels", Selector = "notifyDRMDenyWithLabels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangeBitrate", Selector = "notifyChangeBitrate:position:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint), typeof (nint), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangeBitrate", Selector = "notifyChangeBitrate:position:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint), typeof (nint) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangeBitrate", Selector = "notifyChangeBitrate:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangeBitrate", Selector = "notifyChangeBitrate:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangePlaybackRate", Selector = "notifyChangePlaybackRate:withPosition:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint), typeof (nint), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangePlaybackRate", Selector = "notifyChangePlaybackRate:position:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint), typeof (nint) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangePlaybackRate", Selector = "notifyChangePlaybackRate:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangePlaybackRate", Selector = "notifyChangePlaybackRate:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangeVolume", Selector = "notifyChangeVolume:withPosition:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint), typeof (nint), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangeVolume", Selector = "notifyChangeVolume:position:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint), typeof (nint) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangeVolume", Selector = "notifyChangeVolume:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangeVolume", Selector = "notifyChangeVolume:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangeWindowState", Selector = "notifyChangeWindowState:withPosition:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string), typeof (nint), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangeWindowState", Selector = "notifyChangeWindowState:position:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string), typeof (nint) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangeWindowState", Selector = "notifyChangeWindowState:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangeWindowState", Selector = "notifyChangeWindowState:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangeAudioTrack", Selector = "notifyChangeAudioTrack:withPosition:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string), typeof (nint), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangeAudioTrack", Selector = "notifyChangeAudioTrack:position:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string), typeof (nint) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangeAudioTrack", Selector = "notifyChangeAudioTrack:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangeAudioTrack", Selector = "notifyChangeAudioTrack:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangeVideoTrack", Selector = "notifyChangeVideoTrack:withPosition:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string), typeof (nint), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangeVideoTrack", Selector = "notifyChangeVideoTrack:position:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string), typeof (nint) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangeVideoTrack", Selector = "notifyChangeVideoTrack:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangeVideoTrack", Selector = "notifyChangeVideoTrack:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangeSubtitleTrack", Selector = "notifyChangeSubtitleTrack:withPosition:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string), typeof (nint), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangeSubtitleTrack", Selector = "notifyChangeSubtitleTrack:position:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string), typeof (nint) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangeSubtitleTrack", Selector = "notifyChangeSubtitleTrack:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangeSubtitleTrack", Selector = "notifyChangeSubtitleTrack:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangeCDN", Selector = "notifyChangeCDN:withPosition:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string), typeof (nint), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangeCDN", Selector = "notifyChangeCDN:position:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string), typeof (nint) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangeCDN", Selector = "notifyChangeCDN:labels:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string), typeof (NSDictionary) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyChangeCDN", Selector = "notifyChangeCDN:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetLabelWithName", Selector = "setLabelWithName:value:", ParameterType = new Type [] { typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetLabels", Selector = "setLabels:", ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ValueForLabel", Selector = "valueForLabel:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ContainsLabel", Selector = "containsLabel:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Labels", Selector = "labels", PropertyType = typeof (NSDictionary), GetterSelector = "labels", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PlaybackSession", Selector = "playbackSession", PropertyType = typeof (SCORStreamingPlaybackSession), GetterSelector = "playbackSession", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "NotifyPlay", Selector = "notifyPlay", PropertyType = typeof (bool), GetterSelector = "notifyPlay", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "NotifyPause", Selector = "notifyPause", PropertyType = typeof (bool), GetterSelector = "notifyPause", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "NotifyEnd", Selector = "notifyEnd", PropertyType = typeof (bool), GetterSelector = "notifyEnd", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "NotifyBufferStart", Selector = "notifyBufferStart", PropertyType = typeof (bool), GetterSelector = "notifyBufferStart", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "NotifyBufferStop", Selector = "notifyBufferStop", PropertyType = typeof (bool), GetterSelector = "notifyBufferStop", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "NotifyLoad", Selector = "notifyLoad", PropertyType = typeof (bool), GetterSelector = "notifyLoad", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "NotifyEngage", Selector = "notifyEngage", PropertyType = typeof (bool), GetterSelector = "notifyEngage", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "NotifySeekStart", Selector = "notifySeekStart", PropertyType = typeof (bool), GetterSelector = "notifySeekStart", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "NotifySkipAd", Selector = "notifySkipAd", PropertyType = typeof (bool), GetterSelector = "notifySkipAd", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "NotifyCustomEvent", Selector = "notifyCustomEvent", PropertyType = typeof (bool), GetterSelector = "notifyCustomEvent", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "NotifyCallToAction", Selector = "notifyCallToAction", PropertyType = typeof (bool), GetterSelector = "notifyCallToAction", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "NotifyError", Selector = "notifyError", PropertyType = typeof (bool), GetterSelector = "notifyError", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "NotifyTransferPlayback", Selector = "notifyTransferPlayback", PropertyType = typeof (bool), GetterSelector = "notifyTransferPlayback", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "NotifyDRMFail", Selector = "notifyDRMFail", PropertyType = typeof (bool), GetterSelector = "notifyDRMFail", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "NotifyDRMApprove", Selector = "notifyDRMApprove", PropertyType = typeof (bool), GetterSelector = "notifyDRMApprove", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "NotifyDRMDeny", Selector = "notifyDRMDeny", PropertyType = typeof (bool), GetterSelector = "notifyDRMDeny", ArgumentSemantic = ArgumentSemantic.None)]
public interface ISCORStreamingAnalyticsProtocol : INativeObject, IDisposable
{
	[CompilerGenerated]
	[Export ("notifyPlayWithPosition:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyPlayWithPosition (global::System.nint position, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyPlayWithPosition:")]
	[Preserve (Conditional = true)]
	bool NotifyPlayWithPosition (global::System.nint position);
	
	[CompilerGenerated]
	[Export ("notifyPlayWithLabels:")]
	[Preserve (Conditional = true)]
	bool NotifyPlayWithLabels (NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyPauseWithPosition:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyPauseWithPosition (global::System.nint position, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyPauseWithPosition:")]
	[Preserve (Conditional = true)]
	bool NotifyPauseWithPosition (global::System.nint position);
	
	[CompilerGenerated]
	[Export ("notifyPauseWithLabels:")]
	[Preserve (Conditional = true)]
	bool NotifyPauseWithLabels (NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyEndWithPosition:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyEndWithPosition (global::System.nint position, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyEndWithPosition:")]
	[Preserve (Conditional = true)]
	bool NotifyEndWithPosition (global::System.nint position);
	
	[CompilerGenerated]
	[Export ("notifyEndWithLabels:")]
	[Preserve (Conditional = true)]
	bool NotifyEndWithLabels (NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyBufferStartWithPosition:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyBufferStartWithPosition (global::System.nint position, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyBufferStartWithPosition:")]
	[Preserve (Conditional = true)]
	bool NotifyBufferStartWithPosition (global::System.nint position);
	
	[CompilerGenerated]
	[Export ("notifyBufferStartWithLabels:")]
	[Preserve (Conditional = true)]
	bool NotifyBufferStartWithLabels (NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyBufferStopWithPosition:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyBufferStopWithPosition (global::System.nint position, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyBufferStopWithPosition:")]
	[Preserve (Conditional = true)]
	bool NotifyBufferStopWithPosition (global::System.nint position);
	
	[CompilerGenerated]
	[Export ("notifyBufferStopWithLabels:")]
	[Preserve (Conditional = true)]
	bool NotifyBufferStopWithLabels (NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyLoadWithPosition:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyLoadWithPosition (global::System.nint position, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyLoadWithPosition:")]
	[Preserve (Conditional = true)]
	bool NotifyLoadWithPosition (global::System.nint position);
	
	[CompilerGenerated]
	[Export ("notifyLoadWithLabels:")]
	[Preserve (Conditional = true)]
	bool NotifyLoadWithLabels (NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyEngageWithPosition:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyEngageWithPosition (global::System.nint position, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyEngageWithPosition:")]
	[Preserve (Conditional = true)]
	bool NotifyEngageWithPosition (global::System.nint position);
	
	[CompilerGenerated]
	[Export ("notifyEngageWithLabels:")]
	[Preserve (Conditional = true)]
	bool NotifyEngageWithLabels (NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifySeekStartWithPosition:labels:")]
	[Preserve (Conditional = true)]
	bool NotifySeekStartWithPosition (global::System.nint position, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifySeekStartWithPosition:")]
	[Preserve (Conditional = true)]
	bool NotifySeekStartWithPosition (global::System.nint position);
	
	[CompilerGenerated]
	[Export ("notifySeekStartWithLabels:")]
	[Preserve (Conditional = true)]
	bool NotifySeekStartWithLabels (NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifySkipAdWithPosition:labels:")]
	[Preserve (Conditional = true)]
	bool NotifySkipAdWithPosition (global::System.nint position, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifySkipAdWithPosition:")]
	[Preserve (Conditional = true)]
	bool NotifySkipAdWithPosition (global::System.nint position);
	
	[CompilerGenerated]
	[Export ("notifySkipAdWithLabels:")]
	[Preserve (Conditional = true)]
	bool NotifySkipAdWithLabels (NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyCustomEventWithPosition:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyCustomEventWithPosition (global::System.nint position, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyCustomEventWithPosition:")]
	[Preserve (Conditional = true)]
	bool NotifyCustomEventWithPosition (global::System.nint position);
	
	[CompilerGenerated]
	[Export ("notifyCustomEventWithLabels:")]
	[Preserve (Conditional = true)]
	bool NotifyCustomEventWithLabels (NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyCallToActionWithPosition:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyCallToActionWithPosition (global::System.nint position, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyCallToActionWithPosition:")]
	[Preserve (Conditional = true)]
	bool NotifyCallToActionWithPosition (global::System.nint position);
	
	[CompilerGenerated]
	[Export ("notifyCallToActionWithLabels:")]
	[Preserve (Conditional = true)]
	bool NotifyCallToActionWithLabels (NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyErrorWithPosition:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyErrorWithPosition (global::System.nint position, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyErrorWithPosition:")]
	[Preserve (Conditional = true)]
	bool NotifyErrorWithPosition (global::System.nint position);
	
	[CompilerGenerated]
	[Export ("notifyErrorWithLabels:")]
	[Preserve (Conditional = true)]
	bool NotifyErrorWithLabels (NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyTransferPlaybackWithPosition:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyTransferPlaybackWithPosition (global::System.nint position, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyTransferPlaybackWithPosition:")]
	[Preserve (Conditional = true)]
	bool NotifyTransferPlaybackWithPosition (global::System.nint position);
	
	[CompilerGenerated]
	[Export ("notifyTransferPlaybackWithLabels:")]
	[Preserve (Conditional = true)]
	bool NotifyTransferPlaybackWithLabels (NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyDRMFailWithPosition:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyDRMFailWithPosition (global::System.nint position, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyDRMFailWithPosition:")]
	[Preserve (Conditional = true)]
	bool NotifyDRMFailWithPosition (global::System.nint position);
	
	[CompilerGenerated]
	[Export ("notifyDRMFailWithLabels:")]
	[Preserve (Conditional = true)]
	bool NotifyDRMFailWithLabels (NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyDRMApproveWithPosition:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyDRMApproveWithPosition (global::System.nint position, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyDRMApproveWithPosition:")]
	[Preserve (Conditional = true)]
	bool NotifyDRMApproveWithPosition (global::System.nint position);
	
	[CompilerGenerated]
	[Export ("notifyDRMApproveWithLabels:")]
	[Preserve (Conditional = true)]
	bool NotifyDRMApproveWithLabels (NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyDRMDenyWithPosition:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyDRMDenyWithPosition (global::System.nint position, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyDRMDenyWithPosition:")]
	[Preserve (Conditional = true)]
	bool NotifyDRMDenyWithPosition (global::System.nint position);
	
	[CompilerGenerated]
	[Export ("notifyDRMDenyWithLabels:")]
	[Preserve (Conditional = true)]
	bool NotifyDRMDenyWithLabels (NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyChangeBitrate:position:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyChangeBitrate (global::System.nint newBitrate, global::System.nint position, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyChangeBitrate:position:")]
	[Preserve (Conditional = true)]
	bool NotifyChangeBitrate (global::System.nint newBitrate, global::System.nint position);
	
	[CompilerGenerated]
	[Export ("notifyChangeBitrate:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyChangeBitrate (global::System.nint newBitrate, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyChangeBitrate:")]
	[Preserve (Conditional = true)]
	bool NotifyChangeBitrate (global::System.nint newBitrate);
	
	[CompilerGenerated]
	[Export ("notifyChangePlaybackRate:withPosition:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyChangePlaybackRate (global::System.nint newPlaybackRate, global::System.nint position, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyChangePlaybackRate:position:")]
	[Preserve (Conditional = true)]
	bool NotifyChangePlaybackRate (global::System.nint newPlaybackRate, global::System.nint position);
	
	[CompilerGenerated]
	[Export ("notifyChangePlaybackRate:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyChangePlaybackRate (global::System.nint newPlaybackRate, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyChangePlaybackRate:")]
	[Preserve (Conditional = true)]
	bool NotifyChangePlaybackRate (global::System.nint newRate);
	
	[CompilerGenerated]
	[Export ("notifyChangeVolume:withPosition:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyChangeVolume (global::System.nint newVolume, global::System.nint position, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyChangeVolume:position:")]
	[Preserve (Conditional = true)]
	bool NotifyChangeVolume (global::System.nint newVolume, global::System.nint position);
	
	[CompilerGenerated]
	[Export ("notifyChangeVolume:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyChangeVolume (global::System.nint newVolume, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyChangeVolume:")]
	[Preserve (Conditional = true)]
	bool NotifyChangeVolume (global::System.nint newVolume);
	
	[CompilerGenerated]
	[Export ("notifyChangeWindowState:withPosition:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyChangeWindowState (string newState, global::System.nint position, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyChangeWindowState:position:")]
	[Preserve (Conditional = true)]
	bool NotifyChangeWindowState (string newState, global::System.nint position);
	
	[CompilerGenerated]
	[Export ("notifyChangeWindowState:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyChangeWindowState (string newState, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyChangeWindowState:")]
	[Preserve (Conditional = true)]
	bool NotifyChangeWindowState (string newState);
	
	[CompilerGenerated]
	[Export ("notifyChangeAudioTrack:withPosition:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyChangeAudioTrack (string newAudioTrack, global::System.nint position, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyChangeAudioTrack:position:")]
	[Preserve (Conditional = true)]
	bool NotifyChangeAudioTrack (string newAudioTrack, global::System.nint position);
	
	[CompilerGenerated]
	[Export ("notifyChangeAudioTrack:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyChangeAudioTrack (string newAudioTrack, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyChangeAudioTrack:")]
	[Preserve (Conditional = true)]
	bool NotifyChangeAudioTrack (string newAudioTrack);
	
	[CompilerGenerated]
	[Export ("notifyChangeVideoTrack:withPosition:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyChangeVideoTrack (string newVideoTrack, global::System.nint position, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyChangeVideoTrack:position:")]
	[Preserve (Conditional = true)]
	bool NotifyChangeVideoTrack (string newVideoTrack, global::System.nint position);
	
	[CompilerGenerated]
	[Export ("notifyChangeVideoTrack:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyChangeVideoTrack (string newVideoTrack, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyChangeVideoTrack:")]
	[Preserve (Conditional = true)]
	bool NotifyChangeVideoTrack (string newVideoTrack);
	
	[CompilerGenerated]
	[Export ("notifyChangeSubtitleTrack:withPosition:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyChangeSubtitleTrack (string newSubtitle, global::System.nint position, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyChangeSubtitleTrack:position:")]
	[Preserve (Conditional = true)]
	bool NotifyChangeSubtitleTrack (string newSubtitle, global::System.nint position);
	
	[CompilerGenerated]
	[Export ("notifyChangeSubtitleTrack:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyChangeSubtitleTrack (string newSubtitle, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyChangeSubtitleTrack:")]
	[Preserve (Conditional = true)]
	bool NotifyChangeSubtitleTrack (string newSubtitle);
	
	[CompilerGenerated]
	[Export ("notifyChangeCDN:withPosition:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyChangeCDN (string newCDN, global::System.nint position, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyChangeCDN:position:")]
	[Preserve (Conditional = true)]
	bool NotifyChangeCDN (string newCDN, global::System.nint position);
	
	[CompilerGenerated]
	[Export ("notifyChangeCDN:labels:")]
	[Preserve (Conditional = true)]
	bool NotifyChangeCDN (string newCDN, NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("notifyChangeCDN:")]
	[Preserve (Conditional = true)]
	bool NotifyChangeCDN (string newCDN);
	
	[CompilerGenerated]
	[Export ("setLabelWithName:value:")]
	[Preserve (Conditional = true)]
	void SetLabelWithName (string name, string value);
	
	[CompilerGenerated]
	[Export ("setLabels:")]
	[Preserve (Conditional = true)]
	void SetLabels (NSDictionary labels);
	
	[CompilerGenerated]
	[Export ("valueForLabel:")]
	[Preserve (Conditional = true)]
	string ValueForLabel (string name);
	
	[CompilerGenerated]
	[Export ("containsLabel:")]
	[Preserve (Conditional = true)]
	bool ContainsLabel (string labelName);
	
	[Preserve (Conditional = true)]
	NSDictionary Labels {
		[Export ("labels")]
		get;
	}
	
	[Preserve (Conditional = true)]
	global::SCORStreamingPlaybackSession PlaybackSession {
		[Export ("playbackSession")]
		get;
	}
	
	[Preserve (Conditional = true)]
	bool NotifyPlay {
		[Export ("notifyPlay")]
		get;
	}
	
	[Preserve (Conditional = true)]
	bool NotifyPause {
		[Export ("notifyPause")]
		get;
	}
	
	[Preserve (Conditional = true)]
	bool NotifyEnd {
		[Export ("notifyEnd")]
		get;
	}
	
	[Preserve (Conditional = true)]
	bool NotifyBufferStart {
		[Export ("notifyBufferStart")]
		get;
	}
	
	[Preserve (Conditional = true)]
	bool NotifyBufferStop {
		[Export ("notifyBufferStop")]
		get;
	}
	
	[Preserve (Conditional = true)]
	bool NotifyLoad {
		[Export ("notifyLoad")]
		get;
	}
	
	[Preserve (Conditional = true)]
	bool NotifyEngage {
		[Export ("notifyEngage")]
		get;
	}
	
	[Preserve (Conditional = true)]
	bool NotifySeekStart {
		[Export ("notifySeekStart")]
		get;
	}
	
	[Preserve (Conditional = true)]
	bool NotifySkipAd {
		[Export ("notifySkipAd")]
		get;
	}
	
	[Preserve (Conditional = true)]
	bool NotifyCustomEvent {
		[Export ("notifyCustomEvent")]
		get;
	}
	
	[Preserve (Conditional = true)]
	bool NotifyCallToAction {
		[Export ("notifyCallToAction")]
		get;
	}
	
	[Preserve (Conditional = true)]
	bool NotifyError {
		[Export ("notifyError")]
		get;
	}
	
	[Preserve (Conditional = true)]
	bool NotifyTransferPlayback {
		[Export ("notifyTransferPlayback")]
		get;
	}
	
	[Preserve (Conditional = true)]
	bool NotifyDRMFail {
		[Export ("notifyDRMFail")]
		get;
	}
	
	[Preserve (Conditional = true)]
	bool NotifyDRMApprove {
		[Export ("notifyDRMApprove")]
		get;
	}
	
	[Preserve (Conditional = true)]
	bool NotifyDRMDeny {
		[Export ("notifyDRMDeny")]
		get;
	}
	
}

internal sealed class SCORStreamingAnalyticsProtocolWrapper : BaseWrapper, ISCORStreamingAnalyticsProtocol {
	[Preserve (Conditional = true)]
	public SCORStreamingAnalyticsProtocolWrapper (IntPtr handle, bool owns)
		: base (handle, owns)
	{
	}
	
	[Export ("notifyPlayWithPosition:labels:")]
	[CompilerGenerated]
	public bool NotifyPlayWithPosition (global::System.nint position, NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint_IntPtr (this.Handle, Selector.GetHandle ("notifyPlayWithPosition:labels:"), position, labels.Handle);
	}
	
	[Export ("notifyPlayWithPosition:")]
	[CompilerGenerated]
	public bool NotifyPlayWithPosition (global::System.nint position)
	{
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint (this.Handle, Selector.GetHandle ("notifyPlayWithPosition:"), position);
	}
	
	[Export ("notifyPlayWithLabels:")]
	[CompilerGenerated]
	public bool NotifyPlayWithLabels (NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("notifyPlayWithLabels:"), labels.Handle);
	}
	
	[Export ("notifyPauseWithPosition:labels:")]
	[CompilerGenerated]
	public bool NotifyPauseWithPosition (global::System.nint position, NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint_IntPtr (this.Handle, Selector.GetHandle ("notifyPauseWithPosition:labels:"), position, labels.Handle);
	}
	
	[Export ("notifyPauseWithPosition:")]
	[CompilerGenerated]
	public bool NotifyPauseWithPosition (global::System.nint position)
	{
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint (this.Handle, Selector.GetHandle ("notifyPauseWithPosition:"), position);
	}
	
	[Export ("notifyPauseWithLabels:")]
	[CompilerGenerated]
	public bool NotifyPauseWithLabels (NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("notifyPauseWithLabels:"), labels.Handle);
	}
	
	[Export ("notifyEndWithPosition:labels:")]
	[CompilerGenerated]
	public bool NotifyEndWithPosition (global::System.nint position, NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint_IntPtr (this.Handle, Selector.GetHandle ("notifyEndWithPosition:labels:"), position, labels.Handle);
	}
	
	[Export ("notifyEndWithPosition:")]
	[CompilerGenerated]
	public bool NotifyEndWithPosition (global::System.nint position)
	{
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint (this.Handle, Selector.GetHandle ("notifyEndWithPosition:"), position);
	}
	
	[Export ("notifyEndWithLabels:")]
	[CompilerGenerated]
	public bool NotifyEndWithLabels (NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("notifyEndWithLabels:"), labels.Handle);
	}
	
	[Export ("notifyBufferStartWithPosition:labels:")]
	[CompilerGenerated]
	public bool NotifyBufferStartWithPosition (global::System.nint position, NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint_IntPtr (this.Handle, Selector.GetHandle ("notifyBufferStartWithPosition:labels:"), position, labels.Handle);
	}
	
	[Export ("notifyBufferStartWithPosition:")]
	[CompilerGenerated]
	public bool NotifyBufferStartWithPosition (global::System.nint position)
	{
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint (this.Handle, Selector.GetHandle ("notifyBufferStartWithPosition:"), position);
	}
	
	[Export ("notifyBufferStartWithLabels:")]
	[CompilerGenerated]
	public bool NotifyBufferStartWithLabels (NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("notifyBufferStartWithLabels:"), labels.Handle);
	}
	
	[Export ("notifyBufferStopWithPosition:labels:")]
	[CompilerGenerated]
	public bool NotifyBufferStopWithPosition (global::System.nint position, NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint_IntPtr (this.Handle, Selector.GetHandle ("notifyBufferStopWithPosition:labels:"), position, labels.Handle);
	}
	
	[Export ("notifyBufferStopWithPosition:")]
	[CompilerGenerated]
	public bool NotifyBufferStopWithPosition (global::System.nint position)
	{
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint (this.Handle, Selector.GetHandle ("notifyBufferStopWithPosition:"), position);
	}
	
	[Export ("notifyBufferStopWithLabels:")]
	[CompilerGenerated]
	public bool NotifyBufferStopWithLabels (NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("notifyBufferStopWithLabels:"), labels.Handle);
	}
	
	[Export ("notifyLoadWithPosition:labels:")]
	[CompilerGenerated]
	public bool NotifyLoadWithPosition (global::System.nint position, NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint_IntPtr (this.Handle, Selector.GetHandle ("notifyLoadWithPosition:labels:"), position, labels.Handle);
	}
	
	[Export ("notifyLoadWithPosition:")]
	[CompilerGenerated]
	public bool NotifyLoadWithPosition (global::System.nint position)
	{
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint (this.Handle, Selector.GetHandle ("notifyLoadWithPosition:"), position);
	}
	
	[Export ("notifyLoadWithLabels:")]
	[CompilerGenerated]
	public bool NotifyLoadWithLabels (NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("notifyLoadWithLabels:"), labels.Handle);
	}
	
	[Export ("notifyEngageWithPosition:labels:")]
	[CompilerGenerated]
	public bool NotifyEngageWithPosition (global::System.nint position, NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint_IntPtr (this.Handle, Selector.GetHandle ("notifyEngageWithPosition:labels:"), position, labels.Handle);
	}
	
	[Export ("notifyEngageWithPosition:")]
	[CompilerGenerated]
	public bool NotifyEngageWithPosition (global::System.nint position)
	{
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint (this.Handle, Selector.GetHandle ("notifyEngageWithPosition:"), position);
	}
	
	[Export ("notifyEngageWithLabels:")]
	[CompilerGenerated]
	public bool NotifyEngageWithLabels (NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("notifyEngageWithLabels:"), labels.Handle);
	}
	
	[Export ("notifySeekStartWithPosition:labels:")]
	[CompilerGenerated]
	public bool NotifySeekStartWithPosition (global::System.nint position, NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint_IntPtr (this.Handle, Selector.GetHandle ("notifySeekStartWithPosition:labels:"), position, labels.Handle);
	}
	
	[Export ("notifySeekStartWithPosition:")]
	[CompilerGenerated]
	public bool NotifySeekStartWithPosition (global::System.nint position)
	{
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint (this.Handle, Selector.GetHandle ("notifySeekStartWithPosition:"), position);
	}
	
	[Export ("notifySeekStartWithLabels:")]
	[CompilerGenerated]
	public bool NotifySeekStartWithLabels (NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("notifySeekStartWithLabels:"), labels.Handle);
	}
	
	[Export ("notifySkipAdWithPosition:labels:")]
	[CompilerGenerated]
	public bool NotifySkipAdWithPosition (global::System.nint position, NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint_IntPtr (this.Handle, Selector.GetHandle ("notifySkipAdWithPosition:labels:"), position, labels.Handle);
	}
	
	[Export ("notifySkipAdWithPosition:")]
	[CompilerGenerated]
	public bool NotifySkipAdWithPosition (global::System.nint position)
	{
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint (this.Handle, Selector.GetHandle ("notifySkipAdWithPosition:"), position);
	}
	
	[Export ("notifySkipAdWithLabels:")]
	[CompilerGenerated]
	public bool NotifySkipAdWithLabels (NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("notifySkipAdWithLabels:"), labels.Handle);
	}
	
	[Export ("notifyCustomEventWithPosition:labels:")]
	[CompilerGenerated]
	public bool NotifyCustomEventWithPosition (global::System.nint position, NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint_IntPtr (this.Handle, Selector.GetHandle ("notifyCustomEventWithPosition:labels:"), position, labels.Handle);
	}
	
	[Export ("notifyCustomEventWithPosition:")]
	[CompilerGenerated]
	public bool NotifyCustomEventWithPosition (global::System.nint position)
	{
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint (this.Handle, Selector.GetHandle ("notifyCustomEventWithPosition:"), position);
	}
	
	[Export ("notifyCustomEventWithLabels:")]
	[CompilerGenerated]
	public bool NotifyCustomEventWithLabels (NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("notifyCustomEventWithLabels:"), labels.Handle);
	}
	
	[Export ("notifyCallToActionWithPosition:labels:")]
	[CompilerGenerated]
	public bool NotifyCallToActionWithPosition (global::System.nint position, NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint_IntPtr (this.Handle, Selector.GetHandle ("notifyCallToActionWithPosition:labels:"), position, labels.Handle);
	}
	
	[Export ("notifyCallToActionWithPosition:")]
	[CompilerGenerated]
	public bool NotifyCallToActionWithPosition (global::System.nint position)
	{
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint (this.Handle, Selector.GetHandle ("notifyCallToActionWithPosition:"), position);
	}
	
	[Export ("notifyCallToActionWithLabels:")]
	[CompilerGenerated]
	public bool NotifyCallToActionWithLabels (NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("notifyCallToActionWithLabels:"), labels.Handle);
	}
	
	[Export ("notifyErrorWithPosition:labels:")]
	[CompilerGenerated]
	public bool NotifyErrorWithPosition (global::System.nint position, NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint_IntPtr (this.Handle, Selector.GetHandle ("notifyErrorWithPosition:labels:"), position, labels.Handle);
	}
	
	[Export ("notifyErrorWithPosition:")]
	[CompilerGenerated]
	public bool NotifyErrorWithPosition (global::System.nint position)
	{
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint (this.Handle, Selector.GetHandle ("notifyErrorWithPosition:"), position);
	}
	
	[Export ("notifyErrorWithLabels:")]
	[CompilerGenerated]
	public bool NotifyErrorWithLabels (NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("notifyErrorWithLabels:"), labels.Handle);
	}
	
	[Export ("notifyTransferPlaybackWithPosition:labels:")]
	[CompilerGenerated]
	public bool NotifyTransferPlaybackWithPosition (global::System.nint position, NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint_IntPtr (this.Handle, Selector.GetHandle ("notifyTransferPlaybackWithPosition:labels:"), position, labels.Handle);
	}
	
	[Export ("notifyTransferPlaybackWithPosition:")]
	[CompilerGenerated]
	public bool NotifyTransferPlaybackWithPosition (global::System.nint position)
	{
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint (this.Handle, Selector.GetHandle ("notifyTransferPlaybackWithPosition:"), position);
	}
	
	[Export ("notifyTransferPlaybackWithLabels:")]
	[CompilerGenerated]
	public bool NotifyTransferPlaybackWithLabels (NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("notifyTransferPlaybackWithLabels:"), labels.Handle);
	}
	
	[Export ("notifyDRMFailWithPosition:labels:")]
	[CompilerGenerated]
	public bool NotifyDRMFailWithPosition (global::System.nint position, NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint_IntPtr (this.Handle, Selector.GetHandle ("notifyDRMFailWithPosition:labels:"), position, labels.Handle);
	}
	
	[Export ("notifyDRMFailWithPosition:")]
	[CompilerGenerated]
	public bool NotifyDRMFailWithPosition (global::System.nint position)
	{
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint (this.Handle, Selector.GetHandle ("notifyDRMFailWithPosition:"), position);
	}
	
	[Export ("notifyDRMFailWithLabels:")]
	[CompilerGenerated]
	public bool NotifyDRMFailWithLabels (NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("notifyDRMFailWithLabels:"), labels.Handle);
	}
	
	[Export ("notifyDRMApproveWithPosition:labels:")]
	[CompilerGenerated]
	public bool NotifyDRMApproveWithPosition (global::System.nint position, NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint_IntPtr (this.Handle, Selector.GetHandle ("notifyDRMApproveWithPosition:labels:"), position, labels.Handle);
	}
	
	[Export ("notifyDRMApproveWithPosition:")]
	[CompilerGenerated]
	public bool NotifyDRMApproveWithPosition (global::System.nint position)
	{
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint (this.Handle, Selector.GetHandle ("notifyDRMApproveWithPosition:"), position);
	}
	
	[Export ("notifyDRMApproveWithLabels:")]
	[CompilerGenerated]
	public bool NotifyDRMApproveWithLabels (NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("notifyDRMApproveWithLabels:"), labels.Handle);
	}
	
	[Export ("notifyDRMDenyWithPosition:labels:")]
	[CompilerGenerated]
	public bool NotifyDRMDenyWithPosition (global::System.nint position, NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint_IntPtr (this.Handle, Selector.GetHandle ("notifyDRMDenyWithPosition:labels:"), position, labels.Handle);
	}
	
	[Export ("notifyDRMDenyWithPosition:")]
	[CompilerGenerated]
	public bool NotifyDRMDenyWithPosition (global::System.nint position)
	{
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint (this.Handle, Selector.GetHandle ("notifyDRMDenyWithPosition:"), position);
	}
	
	[Export ("notifyDRMDenyWithLabels:")]
	[CompilerGenerated]
	public bool NotifyDRMDenyWithLabels (NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("notifyDRMDenyWithLabels:"), labels.Handle);
	}
	
	[Export ("notifyChangeBitrate:position:labels:")]
	[CompilerGenerated]
	public bool NotifyChangeBitrate (global::System.nint newBitrate, global::System.nint position, NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint_nint_IntPtr (this.Handle, Selector.GetHandle ("notifyChangeBitrate:position:labels:"), newBitrate, position, labels.Handle);
	}
	
	[Export ("notifyChangeBitrate:position:")]
	[CompilerGenerated]
	public bool NotifyChangeBitrate (global::System.nint newBitrate, global::System.nint position)
	{
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint_nint (this.Handle, Selector.GetHandle ("notifyChangeBitrate:position:"), newBitrate, position);
	}
	
	[Export ("notifyChangeBitrate:labels:")]
	[CompilerGenerated]
	public bool NotifyChangeBitrate (global::System.nint newBitrate, NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint_IntPtr (this.Handle, Selector.GetHandle ("notifyChangeBitrate:labels:"), newBitrate, labels.Handle);
	}
	
	[Export ("notifyChangeBitrate:")]
	[CompilerGenerated]
	public bool NotifyChangeBitrate (global::System.nint newBitrate)
	{
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint (this.Handle, Selector.GetHandle ("notifyChangeBitrate:"), newBitrate);
	}
	
	[Export ("notifyChangePlaybackRate:withPosition:labels:")]
	[CompilerGenerated]
	public bool NotifyChangePlaybackRate (global::System.nint newPlaybackRate, global::System.nint position, NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint_nint_IntPtr (this.Handle, Selector.GetHandle ("notifyChangePlaybackRate:withPosition:labels:"), newPlaybackRate, position, labels.Handle);
	}
	
	[Export ("notifyChangePlaybackRate:position:")]
	[CompilerGenerated]
	public bool NotifyChangePlaybackRate (global::System.nint newPlaybackRate, global::System.nint position)
	{
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint_nint (this.Handle, Selector.GetHandle ("notifyChangePlaybackRate:position:"), newPlaybackRate, position);
	}
	
	[Export ("notifyChangePlaybackRate:labels:")]
	[CompilerGenerated]
	public bool NotifyChangePlaybackRate (global::System.nint newPlaybackRate, NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint_IntPtr (this.Handle, Selector.GetHandle ("notifyChangePlaybackRate:labels:"), newPlaybackRate, labels.Handle);
	}
	
	[Export ("notifyChangePlaybackRate:")]
	[CompilerGenerated]
	public bool NotifyChangePlaybackRate (global::System.nint newRate)
	{
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint (this.Handle, Selector.GetHandle ("notifyChangePlaybackRate:"), newRate);
	}
	
	[Export ("notifyChangeVolume:withPosition:labels:")]
	[CompilerGenerated]
	public bool NotifyChangeVolume (global::System.nint newVolume, global::System.nint position, NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint_nint_IntPtr (this.Handle, Selector.GetHandle ("notifyChangeVolume:withPosition:labels:"), newVolume, position, labels.Handle);
	}
	
	[Export ("notifyChangeVolume:position:")]
	[CompilerGenerated]
	public bool NotifyChangeVolume (global::System.nint newVolume, global::System.nint position)
	{
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint_nint (this.Handle, Selector.GetHandle ("notifyChangeVolume:position:"), newVolume, position);
	}
	
	[Export ("notifyChangeVolume:labels:")]
	[CompilerGenerated]
	public bool NotifyChangeVolume (global::System.nint newVolume, NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint_IntPtr (this.Handle, Selector.GetHandle ("notifyChangeVolume:labels:"), newVolume, labels.Handle);
	}
	
	[Export ("notifyChangeVolume:")]
	[CompilerGenerated]
	public bool NotifyChangeVolume (global::System.nint newVolume)
	{
		return global::ApiDefinition.Messaging.bool_objc_msgSend_nint (this.Handle, Selector.GetHandle ("notifyChangeVolume:"), newVolume);
	}
	
	[Export ("notifyChangeWindowState:withPosition:labels:")]
	[CompilerGenerated]
	public bool NotifyChangeWindowState (string newState, global::System.nint position, NSDictionary labels)
	{
		if (newState == null)
			throw new ArgumentNullException ("newState");
		if (labels == null)
			throw new ArgumentNullException ("labels");
		var nsnewState = NSString.CreateNative (newState);
		
		bool ret;
		ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_nint_IntPtr (this.Handle, Selector.GetHandle ("notifyChangeWindowState:withPosition:labels:"), nsnewState, position, labels.Handle);
		NSString.ReleaseNative (nsnewState);
		
		return ret;
	}
	
	[Export ("notifyChangeWindowState:position:")]
	[CompilerGenerated]
	public bool NotifyChangeWindowState (string newState, global::System.nint position)
	{
		if (newState == null)
			throw new ArgumentNullException ("newState");
		var nsnewState = NSString.CreateNative (newState);
		
		bool ret;
		ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_nint (this.Handle, Selector.GetHandle ("notifyChangeWindowState:position:"), nsnewState, position);
		NSString.ReleaseNative (nsnewState);
		
		return ret;
	}
	
	[Export ("notifyChangeWindowState:labels:")]
	[CompilerGenerated]
	public bool NotifyChangeWindowState (string newState, NSDictionary labels)
	{
		if (newState == null)
			throw new ArgumentNullException ("newState");
		if (labels == null)
			throw new ArgumentNullException ("labels");
		var nsnewState = NSString.CreateNative (newState);
		
		bool ret;
		ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("notifyChangeWindowState:labels:"), nsnewState, labels.Handle);
		NSString.ReleaseNative (nsnewState);
		
		return ret;
	}
	
	[Export ("notifyChangeWindowState:")]
	[CompilerGenerated]
	public bool NotifyChangeWindowState (string newState)
	{
		if (newState == null)
			throw new ArgumentNullException ("newState");
		var nsnewState = NSString.CreateNative (newState);
		
		bool ret;
		ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("notifyChangeWindowState:"), nsnewState);
		NSString.ReleaseNative (nsnewState);
		
		return ret;
	}
	
	[Export ("notifyChangeAudioTrack:withPosition:labels:")]
	[CompilerGenerated]
	public bool NotifyChangeAudioTrack (string newAudioTrack, global::System.nint position, NSDictionary labels)
	{
		if (newAudioTrack == null)
			throw new ArgumentNullException ("newAudioTrack");
		if (labels == null)
			throw new ArgumentNullException ("labels");
		var nsnewAudioTrack = NSString.CreateNative (newAudioTrack);
		
		bool ret;
		ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_nint_IntPtr (this.Handle, Selector.GetHandle ("notifyChangeAudioTrack:withPosition:labels:"), nsnewAudioTrack, position, labels.Handle);
		NSString.ReleaseNative (nsnewAudioTrack);
		
		return ret;
	}
	
	[Export ("notifyChangeAudioTrack:position:")]
	[CompilerGenerated]
	public bool NotifyChangeAudioTrack (string newAudioTrack, global::System.nint position)
	{
		if (newAudioTrack == null)
			throw new ArgumentNullException ("newAudioTrack");
		var nsnewAudioTrack = NSString.CreateNative (newAudioTrack);
		
		bool ret;
		ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_nint (this.Handle, Selector.GetHandle ("notifyChangeAudioTrack:position:"), nsnewAudioTrack, position);
		NSString.ReleaseNative (nsnewAudioTrack);
		
		return ret;
	}
	
	[Export ("notifyChangeAudioTrack:labels:")]
	[CompilerGenerated]
	public bool NotifyChangeAudioTrack (string newAudioTrack, NSDictionary labels)
	{
		if (newAudioTrack == null)
			throw new ArgumentNullException ("newAudioTrack");
		if (labels == null)
			throw new ArgumentNullException ("labels");
		var nsnewAudioTrack = NSString.CreateNative (newAudioTrack);
		
		bool ret;
		ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("notifyChangeAudioTrack:labels:"), nsnewAudioTrack, labels.Handle);
		NSString.ReleaseNative (nsnewAudioTrack);
		
		return ret;
	}
	
	[Export ("notifyChangeAudioTrack:")]
	[CompilerGenerated]
	public bool NotifyChangeAudioTrack (string newAudioTrack)
	{
		if (newAudioTrack == null)
			throw new ArgumentNullException ("newAudioTrack");
		var nsnewAudioTrack = NSString.CreateNative (newAudioTrack);
		
		bool ret;
		ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("notifyChangeAudioTrack:"), nsnewAudioTrack);
		NSString.ReleaseNative (nsnewAudioTrack);
		
		return ret;
	}
	
	[Export ("notifyChangeVideoTrack:withPosition:labels:")]
	[CompilerGenerated]
	public bool NotifyChangeVideoTrack (string newVideoTrack, global::System.nint position, NSDictionary labels)
	{
		if (newVideoTrack == null)
			throw new ArgumentNullException ("newVideoTrack");
		if (labels == null)
			throw new ArgumentNullException ("labels");
		var nsnewVideoTrack = NSString.CreateNative (newVideoTrack);
		
		bool ret;
		ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_nint_IntPtr (this.Handle, Selector.GetHandle ("notifyChangeVideoTrack:withPosition:labels:"), nsnewVideoTrack, position, labels.Handle);
		NSString.ReleaseNative (nsnewVideoTrack);
		
		return ret;
	}
	
	[Export ("notifyChangeVideoTrack:position:")]
	[CompilerGenerated]
	public bool NotifyChangeVideoTrack (string newVideoTrack, global::System.nint position)
	{
		if (newVideoTrack == null)
			throw new ArgumentNullException ("newVideoTrack");
		var nsnewVideoTrack = NSString.CreateNative (newVideoTrack);
		
		bool ret;
		ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_nint (this.Handle, Selector.GetHandle ("notifyChangeVideoTrack:position:"), nsnewVideoTrack, position);
		NSString.ReleaseNative (nsnewVideoTrack);
		
		return ret;
	}
	
	[Export ("notifyChangeVideoTrack:labels:")]
	[CompilerGenerated]
	public bool NotifyChangeVideoTrack (string newVideoTrack, NSDictionary labels)
	{
		if (newVideoTrack == null)
			throw new ArgumentNullException ("newVideoTrack");
		if (labels == null)
			throw new ArgumentNullException ("labels");
		var nsnewVideoTrack = NSString.CreateNative (newVideoTrack);
		
		bool ret;
		ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("notifyChangeVideoTrack:labels:"), nsnewVideoTrack, labels.Handle);
		NSString.ReleaseNative (nsnewVideoTrack);
		
		return ret;
	}
	
	[Export ("notifyChangeVideoTrack:")]
	[CompilerGenerated]
	public bool NotifyChangeVideoTrack (string newVideoTrack)
	{
		if (newVideoTrack == null)
			throw new ArgumentNullException ("newVideoTrack");
		var nsnewVideoTrack = NSString.CreateNative (newVideoTrack);
		
		bool ret;
		ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("notifyChangeVideoTrack:"), nsnewVideoTrack);
		NSString.ReleaseNative (nsnewVideoTrack);
		
		return ret;
	}
	
	[Export ("notifyChangeSubtitleTrack:withPosition:labels:")]
	[CompilerGenerated]
	public bool NotifyChangeSubtitleTrack (string newSubtitle, global::System.nint position, NSDictionary labels)
	{
		if (newSubtitle == null)
			throw new ArgumentNullException ("newSubtitle");
		if (labels == null)
			throw new ArgumentNullException ("labels");
		var nsnewSubtitle = NSString.CreateNative (newSubtitle);
		
		bool ret;
		ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_nint_IntPtr (this.Handle, Selector.GetHandle ("notifyChangeSubtitleTrack:withPosition:labels:"), nsnewSubtitle, position, labels.Handle);
		NSString.ReleaseNative (nsnewSubtitle);
		
		return ret;
	}
	
	[Export ("notifyChangeSubtitleTrack:position:")]
	[CompilerGenerated]
	public bool NotifyChangeSubtitleTrack (string newSubtitle, global::System.nint position)
	{
		if (newSubtitle == null)
			throw new ArgumentNullException ("newSubtitle");
		var nsnewSubtitle = NSString.CreateNative (newSubtitle);
		
		bool ret;
		ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_nint (this.Handle, Selector.GetHandle ("notifyChangeSubtitleTrack:position:"), nsnewSubtitle, position);
		NSString.ReleaseNative (nsnewSubtitle);
		
		return ret;
	}
	
	[Export ("notifyChangeSubtitleTrack:labels:")]
	[CompilerGenerated]
	public bool NotifyChangeSubtitleTrack (string newSubtitle, NSDictionary labels)
	{
		if (newSubtitle == null)
			throw new ArgumentNullException ("newSubtitle");
		if (labels == null)
			throw new ArgumentNullException ("labels");
		var nsnewSubtitle = NSString.CreateNative (newSubtitle);
		
		bool ret;
		ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("notifyChangeSubtitleTrack:labels:"), nsnewSubtitle, labels.Handle);
		NSString.ReleaseNative (nsnewSubtitle);
		
		return ret;
	}
	
	[Export ("notifyChangeSubtitleTrack:")]
	[CompilerGenerated]
	public bool NotifyChangeSubtitleTrack (string newSubtitle)
	{
		if (newSubtitle == null)
			throw new ArgumentNullException ("newSubtitle");
		var nsnewSubtitle = NSString.CreateNative (newSubtitle);
		
		bool ret;
		ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("notifyChangeSubtitleTrack:"), nsnewSubtitle);
		NSString.ReleaseNative (nsnewSubtitle);
		
		return ret;
	}
	
	[Export ("notifyChangeCDN:withPosition:labels:")]
	[CompilerGenerated]
	public bool NotifyChangeCDN (string newCDN, global::System.nint position, NSDictionary labels)
	{
		if (newCDN == null)
			throw new ArgumentNullException ("newCDN");
		if (labels == null)
			throw new ArgumentNullException ("labels");
		var nsnewCDN = NSString.CreateNative (newCDN);
		
		bool ret;
		ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_nint_IntPtr (this.Handle, Selector.GetHandle ("notifyChangeCDN:withPosition:labels:"), nsnewCDN, position, labels.Handle);
		NSString.ReleaseNative (nsnewCDN);
		
		return ret;
	}
	
	[Export ("notifyChangeCDN:position:")]
	[CompilerGenerated]
	public bool NotifyChangeCDN (string newCDN, global::System.nint position)
	{
		if (newCDN == null)
			throw new ArgumentNullException ("newCDN");
		var nsnewCDN = NSString.CreateNative (newCDN);
		
		bool ret;
		ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_nint (this.Handle, Selector.GetHandle ("notifyChangeCDN:position:"), nsnewCDN, position);
		NSString.ReleaseNative (nsnewCDN);
		
		return ret;
	}
	
	[Export ("notifyChangeCDN:labels:")]
	[CompilerGenerated]
	public bool NotifyChangeCDN (string newCDN, NSDictionary labels)
	{
		if (newCDN == null)
			throw new ArgumentNullException ("newCDN");
		if (labels == null)
			throw new ArgumentNullException ("labels");
		var nsnewCDN = NSString.CreateNative (newCDN);
		
		bool ret;
		ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("notifyChangeCDN:labels:"), nsnewCDN, labels.Handle);
		NSString.ReleaseNative (nsnewCDN);
		
		return ret;
	}
	
	[Export ("notifyChangeCDN:")]
	[CompilerGenerated]
	public bool NotifyChangeCDN (string newCDN)
	{
		if (newCDN == null)
			throw new ArgumentNullException ("newCDN");
		var nsnewCDN = NSString.CreateNative (newCDN);
		
		bool ret;
		ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("notifyChangeCDN:"), nsnewCDN);
		NSString.ReleaseNative (nsnewCDN);
		
		return ret;
	}
	
	[Export ("setLabelWithName:value:")]
	[CompilerGenerated]
	public void SetLabelWithName (string name, string value)
	{
		if (name == null)
			throw new ArgumentNullException ("name");
		if (value == null)
			throw new ArgumentNullException ("value");
		var nsname = NSString.CreateNative (name);
		var nsvalue = NSString.CreateNative (value);
		
		global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setLabelWithName:value:"), nsname, nsvalue);
		NSString.ReleaseNative (nsname);
		NSString.ReleaseNative (nsvalue);
		
	}
	
	[Export ("setLabels:")]
	[CompilerGenerated]
	public void SetLabels (NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLabels:"), labels.Handle);
	}
	
	[Export ("valueForLabel:")]
	[CompilerGenerated]
	public string ValueForLabel (string name)
	{
		if (name == null)
			throw new ArgumentNullException ("name");
		var nsname = NSString.CreateNative (name);
		
		string ret;
		ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("valueForLabel:"), nsname));
		NSString.ReleaseNative (nsname);
		
		return ret;
	}
	
	[Export ("containsLabel:")]
	[CompilerGenerated]
	public bool ContainsLabel (string labelName)
	{
		if (labelName == null)
			throw new ArgumentNullException ("labelName");
		var nslabelName = NSString.CreateNative (labelName);
		
		bool ret;
		ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("containsLabel:"), nslabelName);
		NSString.ReleaseNative (nslabelName);
		
		return ret;
	}
	
	[CompilerGenerated]
	public NSDictionary Labels {
		[Export ("labels")]
		get {
			return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("labels")));
		}
		
	}
	
	[CompilerGenerated]
	public global::SCORStreamingPlaybackSession PlaybackSession {
		[Export ("playbackSession")]
		get {
			return  Runtime.GetNSObject<global::SCORStreamingPlaybackSession> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("playbackSession")));
		}
		
	}
	
	[CompilerGenerated]
	public bool NotifyPlay {
		[Export ("notifyPlay")]
		get {
			return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("notifyPlay"));
		}
		
	}
	
	[CompilerGenerated]
	public bool NotifyPause {
		[Export ("notifyPause")]
		get {
			return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("notifyPause"));
		}
		
	}
	
	[CompilerGenerated]
	public bool NotifyEnd {
		[Export ("notifyEnd")]
		get {
			return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("notifyEnd"));
		}
		
	}
	
	[CompilerGenerated]
	public bool NotifyBufferStart {
		[Export ("notifyBufferStart")]
		get {
			return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("notifyBufferStart"));
		}
		
	}
	
	[CompilerGenerated]
	public bool NotifyBufferStop {
		[Export ("notifyBufferStop")]
		get {
			return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("notifyBufferStop"));
		}
		
	}
	
	[CompilerGenerated]
	public bool NotifyLoad {
		[Export ("notifyLoad")]
		get {
			return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("notifyLoad"));
		}
		
	}
	
	[CompilerGenerated]
	public bool NotifyEngage {
		[Export ("notifyEngage")]
		get {
			return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("notifyEngage"));
		}
		
	}
	
	[CompilerGenerated]
	public bool NotifySeekStart {
		[Export ("notifySeekStart")]
		get {
			return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("notifySeekStart"));
		}
		
	}
	
	[CompilerGenerated]
	public bool NotifySkipAd {
		[Export ("notifySkipAd")]
		get {
			return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("notifySkipAd"));
		}
		
	}
	
	[CompilerGenerated]
	public bool NotifyCustomEvent {
		[Export ("notifyCustomEvent")]
		get {
			return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("notifyCustomEvent"));
		}
		
	}
	
	[CompilerGenerated]
	public bool NotifyCallToAction {
		[Export ("notifyCallToAction")]
		get {
			return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("notifyCallToAction"));
		}
		
	}
	
	[CompilerGenerated]
	public bool NotifyError {
		[Export ("notifyError")]
		get {
			return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("notifyError"));
		}
		
	}
	
	[CompilerGenerated]
	public bool NotifyTransferPlayback {
		[Export ("notifyTransferPlayback")]
		get {
			return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("notifyTransferPlayback"));
		}
		
	}
	
	[CompilerGenerated]
	public bool NotifyDRMFail {
		[Export ("notifyDRMFail")]
		get {
			return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("notifyDRMFail"));
		}
		
	}
	
	[CompilerGenerated]
	public bool NotifyDRMApprove {
		[Export ("notifyDRMApprove")]
		get {
			return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("notifyDRMApprove"));
		}
		
	}
	
	[CompilerGenerated]
	public bool NotifyDRMDeny {
		[Export ("notifyDRMDeny")]
		get {
			return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("notifyDRMDeny"));
		}
		
	}
	
}
[Protocol]
[Register("SCORStreamingAnalyticsProtocol", false)]
[Model]
public unsafe abstract partial class SCORStreamingAnalyticsProtocol : NSObject, ISCORStreamingAnalyticsProtocol {
	
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected SCORStreamingAnalyticsProtocol () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SCORStreamingAnalyticsProtocol (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SCORStreamingAnalyticsProtocol (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

	[Export ("containsLabel:")]
	[CompilerGenerated]
	public abstract bool ContainsLabel (string labelName);
	[Export ("notifyBufferStartWithLabels:")]
	[CompilerGenerated]
	public abstract bool NotifyBufferStartWithLabels (NSDictionary labels);
	[Export ("notifyBufferStartWithPosition:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyBufferStartWithPosition (global::System.nint position, NSDictionary labels);
	[Export ("notifyBufferStartWithPosition:")]
	[CompilerGenerated]
	public abstract bool NotifyBufferStartWithPosition (global::System.nint position);
	[Export ("notifyBufferStopWithLabels:")]
	[CompilerGenerated]
	public abstract bool NotifyBufferStopWithLabels (NSDictionary labels);
	[Export ("notifyBufferStopWithPosition:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyBufferStopWithPosition (global::System.nint position, NSDictionary labels);
	[Export ("notifyBufferStopWithPosition:")]
	[CompilerGenerated]
	public abstract bool NotifyBufferStopWithPosition (global::System.nint position);
	[Export ("notifyCallToActionWithLabels:")]
	[CompilerGenerated]
	public abstract bool NotifyCallToActionWithLabels (NSDictionary labels);
	[Export ("notifyCallToActionWithPosition:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyCallToActionWithPosition (global::System.nint position, NSDictionary labels);
	[Export ("notifyCallToActionWithPosition:")]
	[CompilerGenerated]
	public abstract bool NotifyCallToActionWithPosition (global::System.nint position);
	[Export ("notifyChangeAudioTrack:withPosition:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyChangeAudioTrack (string newAudioTrack, global::System.nint position, NSDictionary labels);
	[Export ("notifyChangeAudioTrack:position:")]
	[CompilerGenerated]
	public abstract bool NotifyChangeAudioTrack (string newAudioTrack, global::System.nint position);
	[Export ("notifyChangeAudioTrack:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyChangeAudioTrack (string newAudioTrack, NSDictionary labels);
	[Export ("notifyChangeAudioTrack:")]
	[CompilerGenerated]
	public abstract bool NotifyChangeAudioTrack (string newAudioTrack);
	[Export ("notifyChangeBitrate:position:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyChangeBitrate (global::System.nint newBitrate, global::System.nint position, NSDictionary labels);
	[Export ("notifyChangeBitrate:position:")]
	[CompilerGenerated]
	public abstract bool NotifyChangeBitrate (global::System.nint newBitrate, global::System.nint position);
	[Export ("notifyChangeBitrate:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyChangeBitrate (global::System.nint newBitrate, NSDictionary labels);
	[Export ("notifyChangeBitrate:")]
	[CompilerGenerated]
	public abstract bool NotifyChangeBitrate (global::System.nint newBitrate);
	[Export ("notifyChangeCDN:withPosition:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyChangeCDN (string newCDN, global::System.nint position, NSDictionary labels);
	[Export ("notifyChangeCDN:position:")]
	[CompilerGenerated]
	public abstract bool NotifyChangeCDN (string newCDN, global::System.nint position);
	[Export ("notifyChangeCDN:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyChangeCDN (string newCDN, NSDictionary labels);
	[Export ("notifyChangeCDN:")]
	[CompilerGenerated]
	public abstract bool NotifyChangeCDN (string newCDN);
	[Export ("notifyChangePlaybackRate:withPosition:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyChangePlaybackRate (global::System.nint newPlaybackRate, global::System.nint position, NSDictionary labels);
	[Export ("notifyChangePlaybackRate:position:")]
	[CompilerGenerated]
	public abstract bool NotifyChangePlaybackRate (global::System.nint newPlaybackRate, global::System.nint position);
	[Export ("notifyChangePlaybackRate:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyChangePlaybackRate (global::System.nint newPlaybackRate, NSDictionary labels);
	[Export ("notifyChangePlaybackRate:")]
	[CompilerGenerated]
	public abstract bool NotifyChangePlaybackRate (global::System.nint newRate);
	[Export ("notifyChangeSubtitleTrack:withPosition:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyChangeSubtitleTrack (string newSubtitle, global::System.nint position, NSDictionary labels);
	[Export ("notifyChangeSubtitleTrack:position:")]
	[CompilerGenerated]
	public abstract bool NotifyChangeSubtitleTrack (string newSubtitle, global::System.nint position);
	[Export ("notifyChangeSubtitleTrack:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyChangeSubtitleTrack (string newSubtitle, NSDictionary labels);
	[Export ("notifyChangeSubtitleTrack:")]
	[CompilerGenerated]
	public abstract bool NotifyChangeSubtitleTrack (string newSubtitle);
	[Export ("notifyChangeVideoTrack:withPosition:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyChangeVideoTrack (string newVideoTrack, global::System.nint position, NSDictionary labels);
	[Export ("notifyChangeVideoTrack:position:")]
	[CompilerGenerated]
	public abstract bool NotifyChangeVideoTrack (string newVideoTrack, global::System.nint position);
	[Export ("notifyChangeVideoTrack:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyChangeVideoTrack (string newVideoTrack, NSDictionary labels);
	[Export ("notifyChangeVideoTrack:")]
	[CompilerGenerated]
	public abstract bool NotifyChangeVideoTrack (string newVideoTrack);
	[Export ("notifyChangeVolume:withPosition:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyChangeVolume (global::System.nint newVolume, global::System.nint position, NSDictionary labels);
	[Export ("notifyChangeVolume:position:")]
	[CompilerGenerated]
	public abstract bool NotifyChangeVolume (global::System.nint newVolume, global::System.nint position);
	[Export ("notifyChangeVolume:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyChangeVolume (global::System.nint newVolume, NSDictionary labels);
	[Export ("notifyChangeVolume:")]
	[CompilerGenerated]
	public abstract bool NotifyChangeVolume (global::System.nint newVolume);
	[Export ("notifyChangeWindowState:withPosition:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyChangeWindowState (string newState, global::System.nint position, NSDictionary labels);
	[Export ("notifyChangeWindowState:position:")]
	[CompilerGenerated]
	public abstract bool NotifyChangeWindowState (string newState, global::System.nint position);
	[Export ("notifyChangeWindowState:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyChangeWindowState (string newState, NSDictionary labels);
	[Export ("notifyChangeWindowState:")]
	[CompilerGenerated]
	public abstract bool NotifyChangeWindowState (string newState);
	[Export ("notifyCustomEventWithLabels:")]
	[CompilerGenerated]
	public abstract bool NotifyCustomEventWithLabels (NSDictionary labels);
	[Export ("notifyCustomEventWithPosition:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyCustomEventWithPosition (global::System.nint position, NSDictionary labels);
	[Export ("notifyCustomEventWithPosition:")]
	[CompilerGenerated]
	public abstract bool NotifyCustomEventWithPosition (global::System.nint position);
	[Export ("notifyDRMApproveWithLabels:")]
	[CompilerGenerated]
	public abstract bool NotifyDRMApproveWithLabels (NSDictionary labels);
	[Export ("notifyDRMApproveWithPosition:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyDRMApproveWithPosition (global::System.nint position, NSDictionary labels);
	[Export ("notifyDRMApproveWithPosition:")]
	[CompilerGenerated]
	public abstract bool NotifyDRMApproveWithPosition (global::System.nint position);
	[Export ("notifyDRMDenyWithLabels:")]
	[CompilerGenerated]
	public abstract bool NotifyDRMDenyWithLabels (NSDictionary labels);
	[Export ("notifyDRMDenyWithPosition:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyDRMDenyWithPosition (global::System.nint position, NSDictionary labels);
	[Export ("notifyDRMDenyWithPosition:")]
	[CompilerGenerated]
	public abstract bool NotifyDRMDenyWithPosition (global::System.nint position);
	[Export ("notifyDRMFailWithLabels:")]
	[CompilerGenerated]
	public abstract bool NotifyDRMFailWithLabels (NSDictionary labels);
	[Export ("notifyDRMFailWithPosition:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyDRMFailWithPosition (global::System.nint position, NSDictionary labels);
	[Export ("notifyDRMFailWithPosition:")]
	[CompilerGenerated]
	public abstract bool NotifyDRMFailWithPosition (global::System.nint position);
	[Export ("notifyEndWithLabels:")]
	[CompilerGenerated]
	public abstract bool NotifyEndWithLabels (NSDictionary labels);
	[Export ("notifyEndWithPosition:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyEndWithPosition (global::System.nint position, NSDictionary labels);
	[Export ("notifyEndWithPosition:")]
	[CompilerGenerated]
	public abstract bool NotifyEndWithPosition (global::System.nint position);
	[Export ("notifyEngageWithLabels:")]
	[CompilerGenerated]
	public abstract bool NotifyEngageWithLabels (NSDictionary labels);
	[Export ("notifyEngageWithPosition:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyEngageWithPosition (global::System.nint position, NSDictionary labels);
	[Export ("notifyEngageWithPosition:")]
	[CompilerGenerated]
	public abstract bool NotifyEngageWithPosition (global::System.nint position);
	[Export ("notifyErrorWithLabels:")]
	[CompilerGenerated]
	public abstract bool NotifyErrorWithLabels (NSDictionary labels);
	[Export ("notifyErrorWithPosition:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyErrorWithPosition (global::System.nint position, NSDictionary labels);
	[Export ("notifyErrorWithPosition:")]
	[CompilerGenerated]
	public abstract bool NotifyErrorWithPosition (global::System.nint position);
	[Export ("notifyLoadWithLabels:")]
	[CompilerGenerated]
	public abstract bool NotifyLoadWithLabels (NSDictionary labels);
	[Export ("notifyLoadWithPosition:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyLoadWithPosition (global::System.nint position, NSDictionary labels);
	[Export ("notifyLoadWithPosition:")]
	[CompilerGenerated]
	public abstract bool NotifyLoadWithPosition (global::System.nint position);
	[Export ("notifyPauseWithLabels:")]
	[CompilerGenerated]
	public abstract bool NotifyPauseWithLabels (NSDictionary labels);
	[Export ("notifyPauseWithPosition:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyPauseWithPosition (global::System.nint position, NSDictionary labels);
	[Export ("notifyPauseWithPosition:")]
	[CompilerGenerated]
	public abstract bool NotifyPauseWithPosition (global::System.nint position);
	[Export ("notifyPlayWithLabels:")]
	[CompilerGenerated]
	public abstract bool NotifyPlayWithLabels (NSDictionary labels);
	[Export ("notifyPlayWithPosition:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyPlayWithPosition (global::System.nint position, NSDictionary labels);
	[Export ("notifyPlayWithPosition:")]
	[CompilerGenerated]
	public abstract bool NotifyPlayWithPosition (global::System.nint position);
	[Export ("notifySeekStartWithLabels:")]
	[CompilerGenerated]
	public abstract bool NotifySeekStartWithLabels (NSDictionary labels);
	[Export ("notifySeekStartWithPosition:labels:")]
	[CompilerGenerated]
	public abstract bool NotifySeekStartWithPosition (global::System.nint position, NSDictionary labels);
	[Export ("notifySeekStartWithPosition:")]
	[CompilerGenerated]
	public abstract bool NotifySeekStartWithPosition (global::System.nint position);
	[Export ("notifySkipAdWithLabels:")]
	[CompilerGenerated]
	public abstract bool NotifySkipAdWithLabels (NSDictionary labels);
	[Export ("notifySkipAdWithPosition:labels:")]
	[CompilerGenerated]
	public abstract bool NotifySkipAdWithPosition (global::System.nint position, NSDictionary labels);
	[Export ("notifySkipAdWithPosition:")]
	[CompilerGenerated]
	public abstract bool NotifySkipAdWithPosition (global::System.nint position);
	[Export ("notifyTransferPlaybackWithLabels:")]
	[CompilerGenerated]
	public abstract bool NotifyTransferPlaybackWithLabels (NSDictionary labels);
	[Export ("notifyTransferPlaybackWithPosition:labels:")]
	[CompilerGenerated]
	public abstract bool NotifyTransferPlaybackWithPosition (global::System.nint position, NSDictionary labels);
	[Export ("notifyTransferPlaybackWithPosition:")]
	[CompilerGenerated]
	public abstract bool NotifyTransferPlaybackWithPosition (global::System.nint position);
	[Export ("setLabelWithName:value:")]
	[CompilerGenerated]
	public abstract void SetLabelWithName (string name, string value);
	[Export ("setLabels:")]
	[CompilerGenerated]
	public abstract void SetLabels (NSDictionary labels);
	[Export ("valueForLabel:")]
	[CompilerGenerated]
	public abstract string ValueForLabel (string name);
	[CompilerGenerated]
	public abstract NSDictionary Labels {
		[Export ("labels")]
		get; 
	}
	
	[CompilerGenerated]
	public abstract bool NotifyBufferStart {
		[Export ("notifyBufferStart")]
		get; 
	}
	
	[CompilerGenerated]
	public abstract bool NotifyBufferStop {
		[Export ("notifyBufferStop")]
		get; 
	}
	
	[CompilerGenerated]
	public abstract bool NotifyCallToAction {
		[Export ("notifyCallToAction")]
		get; 
	}
	
	[CompilerGenerated]
	public abstract bool NotifyCustomEvent {
		[Export ("notifyCustomEvent")]
		get; 
	}
	
	[CompilerGenerated]
	public abstract bool NotifyDRMApprove {
		[Export ("notifyDRMApprove")]
		get; 
	}
	
	[CompilerGenerated]
	public abstract bool NotifyDRMDeny {
		[Export ("notifyDRMDeny")]
		get; 
	}
	
	[CompilerGenerated]
	public abstract bool NotifyDRMFail {
		[Export ("notifyDRMFail")]
		get; 
	}
	
	[CompilerGenerated]
	public abstract bool NotifyEnd {
		[Export ("notifyEnd")]
		get; 
	}
	
	[CompilerGenerated]
	public abstract bool NotifyEngage {
		[Export ("notifyEngage")]
		get; 
	}
	
	[CompilerGenerated]
	public abstract bool NotifyError {
		[Export ("notifyError")]
		get; 
	}
	
	[CompilerGenerated]
	public abstract bool NotifyLoad {
		[Export ("notifyLoad")]
		get; 
	}
	
	[CompilerGenerated]
	public abstract bool NotifyPause {
		[Export ("notifyPause")]
		get; 
	}
	
	[CompilerGenerated]
	public abstract bool NotifyPlay {
		[Export ("notifyPlay")]
		get; 
	}
	
	[CompilerGenerated]
	public abstract bool NotifySeekStart {
		[Export ("notifySeekStart")]
		get; 
	}
	
	[CompilerGenerated]
	public abstract bool NotifySkipAd {
		[Export ("notifySkipAd")]
		get; 
	}
	
	[CompilerGenerated]
	public abstract bool NotifyTransferPlayback {
		[Export ("notifyTransferPlayback")]
		get; 
	}
	
	[CompilerGenerated]
	public abstract global::SCORStreamingPlaybackSession PlaybackSession {
		[Export ("playbackSession")]
		get; 
	}
	
} /* class SCORStreamingAnalyticsProtocol */
