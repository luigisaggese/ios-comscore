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

[Register("SCOREventInfo", true)]
public unsafe partial class SCOREventInfo : NSObject {
	
	[CompilerGenerated]
	static readonly IntPtr class_ptr = Class.GetHandle ("SCOREventInfo");
	
	public override IntPtr ClassHandle { get { return class_ptr; } }
	
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SCOREventInfo () : base (NSObjectFlag.Empty)
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
		protected SCOREventInfo (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SCOREventInfo (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

	[Export ("dealloc")]
	[CompilerGenerated]
	public virtual void Dealloc ()
	{
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("dealloc"));
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dealloc"));
		}
	}
	
	[Export ("labelWithName:")]
	[CompilerGenerated]
	public virtual string LabelWithName (string name)
	{
		if (name == null)
			throw new ArgumentNullException ("name");
		var nsname = NSString.CreateNative (name);
		
		string ret;
		if (IsDirectBinding) {
			ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("labelWithName:"), nsname));
		} else {
			ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("labelWithName:"), nsname));
		}
		NSString.ReleaseNative (nsname);
		
		return ret;
	}
	
	[Export ("labelWithName:publisherId:")]
	[CompilerGenerated]
	public virtual string LabelWithName (string name, string publisherId)
	{
		if (name == null)
			throw new ArgumentNullException ("name");
		if (publisherId == null)
			throw new ArgumentNullException ("publisherId");
		var nsname = NSString.CreateNative (name);
		var nspublisherId = NSString.CreateNative (publisherId);
		
		string ret;
		if (IsDirectBinding) {
			ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("labelWithName:publisherId:"), nsname, nspublisherId));
		} else {
			ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("labelWithName:publisherId:"), nsname, nspublisherId));
		}
		NSString.ReleaseNative (nsname);
		NSString.ReleaseNative (nspublisherId);
		
		return ret;
	}
	
	[Export ("labelsWithPublisherId:")]
	[CompilerGenerated]
	public virtual NSDictionary LabelsWithPublisherId (string publisherId)
	{
		if (publisherId == null)
			throw new ArgumentNullException ("publisherId");
		var nspublisherId = NSString.CreateNative (publisherId);
		
		NSDictionary ret;
		if (IsDirectBinding) {
			ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("labelsWithPublisherId:"), nspublisherId));
		} else {
			ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("labelsWithPublisherId:"), nspublisherId));
		}
		NSString.ReleaseNative (nspublisherId);
		
		return ret;
	}
	
	[Export ("removeAllLabels")]
	[CompilerGenerated]
	public virtual void RemoveAllLabels ()
	{
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeAllLabels"));
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("removeAllLabels"));
		}
	}
	
	[Export ("removeAllLabelsWithPublisherId:")]
	[CompilerGenerated]
	public virtual void RemoveAllLabelsWithPublisherId (string publisherId)
	{
		if (publisherId == null)
			throw new ArgumentNullException ("publisherId");
		var nspublisherId = NSString.CreateNative (publisherId);
		
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeAllLabelsWithPublisherId:"), nspublisherId);
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeAllLabelsWithPublisherId:"), nspublisherId);
		}
		NSString.ReleaseNative (nspublisherId);
		
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
	
	[Export ("removeLabelWithName:publisherId:")]
	[CompilerGenerated]
	public virtual void RemoveLabelWithName (string name, string publisherId)
	{
		if (name == null)
			throw new ArgumentNullException ("name");
		if (publisherId == null)
			throw new ArgumentNullException ("publisherId");
		var nsname = NSString.CreateNative (name);
		var nspublisherId = NSString.CreateNative (publisherId);
		
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("removeLabelWithName:publisherId:"), nsname, nspublisherId);
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("removeLabelWithName:publisherId:"), nsname, nspublisherId);
		}
		NSString.ReleaseNative (nsname);
		NSString.ReleaseNative (nspublisherId);
		
	}
	
	[Export ("removePublisherWithId:")]
	[CompilerGenerated]
	public virtual void RemovePublisherWithId (string publisherId)
	{
		if (publisherId == null)
			throw new ArgumentNullException ("publisherId");
		var nspublisherId = NSString.CreateNative (publisherId);
		
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removePublisherWithId:"), nspublisherId);
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removePublisherWithId:"), nspublisherId);
		}
		NSString.ReleaseNative (nspublisherId);
		
	}
	
	[Export ("setLabelWithName:value:")]
	[CompilerGenerated]
	public virtual void SetLabelWithName (string name, string value)
	{
		if (name == null)
			throw new ArgumentNullException ("name");
		if (value == null)
			throw new ArgumentNullException ("value");
		var nsname = NSString.CreateNative (name);
		var nsvalue = NSString.CreateNative (value);
		
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setLabelWithName:value:"), nsname, nsvalue);
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("setLabelWithName:value:"), nsname, nsvalue);
		}
		NSString.ReleaseNative (nsname);
		NSString.ReleaseNative (nsvalue);
		
	}
	
	[Export ("setLabelWithName:value:publisherId:")]
	[CompilerGenerated]
	public virtual void SetLabelWithName (string name, string value, string publisherId)
	{
		if (name == null)
			throw new ArgumentNullException ("name");
		if (value == null)
			throw new ArgumentNullException ("value");
		if (publisherId == null)
			throw new ArgumentNullException ("publisherId");
		var nsname = NSString.CreateNative (name);
		var nsvalue = NSString.CreateNative (value);
		var nspublisherId = NSString.CreateNative (publisherId);
		
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setLabelWithName:value:publisherId:"), nsname, nsvalue, nspublisherId);
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("setLabelWithName:value:publisherId:"), nsname, nsvalue, nspublisherId);
		}
		NSString.ReleaseNative (nsname);
		NSString.ReleaseNative (nsvalue);
		NSString.ReleaseNative (nspublisherId);
		
	}
	
	[Export ("setLabels:publisherId:")]
	[CompilerGenerated]
	public virtual void SetLabels (NSDictionary labels, string publisherId)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		if (publisherId == null)
			throw new ArgumentNullException ("publisherId");
		var nspublisherId = NSString.CreateNative (publisherId);
		
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setLabels:publisherId:"), labels.Handle, nspublisherId);
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("setLabels:publisherId:"), labels.Handle, nspublisherId);
		}
		NSString.ReleaseNative (nspublisherId);
		
	}
	
	[Export ("setPublisherWithId:")]
	[CompilerGenerated]
	public virtual void SetPublisherWithId (string publisherId)
	{
		if (publisherId == null)
			throw new ArgumentNullException ("publisherId");
		var nspublisherId = NSString.CreateNative (publisherId);
		
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPublisherWithId:"), nspublisherId);
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPublisherWithId:"), nspublisherId);
		}
		NSString.ReleaseNative (nspublisherId);
		
	}
	
	[CompilerGenerated]
	public virtual global::SCOREventInfo Copy {
		[Export ("copy")]
		get {
			global::SCOREventInfo ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::SCOREventInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("copy")));
			} else {
				ret =  Runtime.GetNSObject<global::SCOREventInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("copy")));
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
		
		[Export ("setLabels:")]
		set {
			if (value == null)
				throw new ArgumentNullException ("value");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLabels:"), value.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLabels:"), value.Handle);
			}
		}
	}
	
} /* class SCOREventInfo */
