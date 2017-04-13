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

namespace CSComScore {
	[Register("SCORStreamingAsset", true)]
	public unsafe partial class SCORStreamingAsset : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SCORStreamingAsset");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SCORStreamingAsset () : base (NSObjectFlag.Empty)
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
		protected SCORStreamingAsset (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SCORStreamingAsset (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addStackWithPublisherId:labels:")]
		[CompilerGenerated]
		public virtual void AddStackWithPublisherId (string publisherId, NSDictionary labels)
		{
			if (publisherId == null)
				throw new ArgumentNullException ("publisherId");
			if (labels == null)
				throw new ArgumentNullException ("labels");
			var nspublisherId = NSString.CreateNative (publisherId);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("addStackWithPublisherId:labels:"), nspublisherId, labels.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("addStackWithPublisherId:labels:"), nspublisherId, labels.Handle);
			}
			NSString.ReleaseNative (nspublisherId);
			
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
		
		[Export ("removeStackWithPublisherId:")]
		[CompilerGenerated]
		public virtual void RemoveStackWithPublisherId (string publisherId)
		{
			if (publisherId == null)
				throw new ArgumentNullException ("publisherId");
			var nspublisherId = NSString.CreateNative (publisherId);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeStackWithPublisherId:"), nspublisherId);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeStackWithPublisherId:"), nspublisherId);
			}
			NSString.ReleaseNative (nspublisherId);
			
		}
		
		[Export ("setLabelWithName:withValue:")]
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
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setLabelWithName:withValue:"), nslabelName, nsvalue);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("setLabelWithName:withValue:"), nslabelName, nsvalue);
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
		public virtual bool AutoCalculatePositions {
			[Export ("autoCalculatePositions")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("autoCalculatePositions"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("autoCalculatePositions"));
				}
			}
			
			[Export ("setAutoCalculatePositions:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAutoCalculatePositions:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAutoCalculatePositions:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nint ClipNumber {
			[Export ("clipNumber")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("clipNumber"));
				} else {
					return global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clipNumber"));
				}
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
		
	} /* class SCORStreamingAsset */
}
