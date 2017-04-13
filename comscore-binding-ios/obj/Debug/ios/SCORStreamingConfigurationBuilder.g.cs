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

[Register("SCORStreamingConfigurationBuilder", true)]
public unsafe partial class SCORStreamingConfigurationBuilder : NSObject {
	
	[CompilerGenerated]
	static readonly IntPtr class_ptr = Class.GetHandle ("SCORStreamingConfigurationBuilder");
	
	public override IntPtr ClassHandle { get { return class_ptr; } }
	
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SCORStreamingConfigurationBuilder () : base (NSObjectFlag.Empty)
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
		protected SCORStreamingConfigurationBuilder (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SCORStreamingConfigurationBuilder (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

	[CompilerGenerated]
	public virtual global::SCORStreamingConfiguration Build {
		[Export ("build")]
		get {
			global::SCORStreamingConfiguration ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::SCORStreamingConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("build")));
			} else {
				ret =  Runtime.GetNSObject<global::SCORStreamingConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("build")));
			}
			return ret;
		}
		
	}
	
	[CompilerGenerated]
	public virtual NSObject[] RestrictedPublishersList {
		[Export ("restrictedPublishersList", ArgumentSemantic.Copy)]
		get {
			NSObject[] ret;
			if (IsDirectBinding) {
				ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("restrictedPublishersList")));
			} else {
				ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("restrictedPublishersList")));
			}
			return ret;
		}
		
		[Export ("setRestrictedPublishersList:", ArgumentSemantic.Copy)]
		set {
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsa_value = NSArray.FromNSObjects (value);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRestrictedPublishersList:"), nsa_value.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRestrictedPublishersList:"), nsa_value.Handle);
			}
			nsa_value.Dispose ();
			
		}
	}
	
	[CompilerGenerated]
	public virtual bool SystemClockJumpDetection {
		[Export ("systemClockJumpDetection")]
		get {
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("systemClockJumpDetection"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("systemClockJumpDetection"));
			}
		}
		
		[Export ("setSystemClockJumpDetection:")]
		set {
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSystemClockJumpDetection:"), value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setSystemClockJumpDetection:"), value);
			}
		}
	}
	
} /* class SCORStreamingConfigurationBuilder */
