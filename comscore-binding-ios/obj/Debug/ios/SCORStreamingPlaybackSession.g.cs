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

[Register("SCORStreamingPlaybackSession", true)]
public unsafe partial class SCORStreamingPlaybackSession : NSObject {
	
	[CompilerGenerated]
	static readonly IntPtr class_ptr = Class.GetHandle ("SCORStreamingPlaybackSession");
	
	public override IntPtr ClassHandle { get { return class_ptr; } }
	
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SCORStreamingPlaybackSession () : base (NSObjectFlag.Empty)
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
		protected SCORStreamingPlaybackSession (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SCORStreamingPlaybackSession (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

	[Export ("containsLabel:")]
	[CompilerGenerated]
	public virtual bool ContainsLabel (string labelName)
	{
		if (labelName == null)
			throw new ArgumentNullException ("labelName");
		var nslabelName = NSString.CreateNative (labelName);
		
		bool ret;
		if (IsDirectBinding) {
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("containsLabel:"), nslabelName);
		} else {
			ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("containsLabel:"), nslabelName);
		}
		NSString.ReleaseNative (nslabelName);
		
		return ret;
	}
	
	[Export ("label:")]
	[CompilerGenerated]
	public virtual string Label (string labelName)
	{
		if (labelName == null)
			throw new ArgumentNullException ("labelName");
		var nslabelName = NSString.CreateNative (labelName);
		
		string ret;
		if (IsDirectBinding) {
			ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("label:"), nslabelName));
		} else {
			ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("label:"), nslabelName));
		}
		NSString.ReleaseNative (nslabelName);
		
		return ret;
	}
	
	[Export ("removeLabelWithName:")]
	[CompilerGenerated]
	public virtual void RemoveLabelWithName (string name)
	{
		if (name == null)
			throw new ArgumentNullException ("name");
		var nsname = NSString.CreateNative (name);
		
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeLabelWithName:"), nsname);
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeLabelWithName:"), nsname);
		}
		NSString.ReleaseNative (nsname);
		
	}
	
	[Export ("setAssetWithLabels:")]
	[CompilerGenerated]
	public virtual void SetAssetWithLabels (NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAssetWithLabels:"), labels.Handle);
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAssetWithLabels:"), labels.Handle);
		}
	}
	
	[Export ("setAssetWithLabels:loop:")]
	[CompilerGenerated]
	public virtual void SetAssetWithLabels (NSDictionary labels, bool loop)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("setAssetWithLabels:loop:"), labels.Handle, loop);
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("setAssetWithLabels:loop:"), labels.Handle, loop);
		}
	}
	
	[Export ("setLabelWithName:value:")]
	[CompilerGenerated]
	public virtual void SetLabelWithName (string labelName, string value)
	{
		if (labelName == null)
			throw new ArgumentNullException ("labelName");
		if (value == null)
			throw new ArgumentNullException ("value");
		var nslabelName = NSString.CreateNative (labelName);
		var nsvalue = NSString.CreateNative (value);
		
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setLabelWithName:value:"), nslabelName, nsvalue);
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("setLabelWithName:value:"), nslabelName, nsvalue);
		}
		NSString.ReleaseNative (nslabelName);
		NSString.ReleaseNative (nsvalue);
		
	}
	
	[Export ("setLabels:")]
	[CompilerGenerated]
	public virtual void SetLabels (NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLabels:"), labels.Handle);
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLabels:"), labels.Handle);
		}
	}
	
	[CompilerGenerated]
	public virtual global::SCORStreamingAsset Asset {
		[Export ("asset")]
		get {
			global::SCORStreamingAsset ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::SCORStreamingAsset> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("asset")));
			} else {
				ret =  Runtime.GetNSObject<global::SCORStreamingAsset> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("asset")));
			}
			return ret;
		}
		
	}
	
	[CompilerGenerated]
	public virtual NSDictionary Labels {
		[Export ("labels")]
		get {
			NSDictionary ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("labels")));
			} else {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("labels")));
			}
			return ret;
		}
		
	}
	
	[CompilerGenerated]
	public virtual string PlaybackSessionID {
		[Export ("playbackSessionID")]
		get {
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("playbackSessionID")));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("playbackSessionID")));
			}
		}
		
	}
	
} /* class SCORStreamingPlaybackSession */
