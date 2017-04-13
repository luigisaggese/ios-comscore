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

[Register("SCORClientConfigurationBuilder", true)]
public unsafe partial class SCORClientConfigurationBuilder : NSObject {
	
	[CompilerGenerated]
	static readonly IntPtr class_ptr = Class.GetHandle ("SCORClientConfigurationBuilder");
	
	public override IntPtr ClassHandle { get { return class_ptr; } }
	
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SCORClientConfigurationBuilder () : base (NSObjectFlag.Empty)
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
		protected SCORClientConfigurationBuilder (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SCORClientConfigurationBuilder (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

	[CompilerGenerated]
	public virtual string ApplicationName {
		[Export ("applicationName")]
		get {
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("applicationName")));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("applicationName")));
			}
		}
		
		[Export ("setApplicationName:")]
		set {
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setApplicationName:"), nsvalue);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setApplicationName:"), nsvalue);
			}
			NSString.ReleaseNative (nsvalue);
			
		}
	}
	
	[CompilerGenerated]
	public virtual string ApplicationVersion {
		[Export ("applicationVersion")]
		get {
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("applicationVersion")));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("applicationVersion")));
			}
		}
		
		[Export ("setApplicationVersion:")]
		set {
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setApplicationVersion:"), nsvalue);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setApplicationVersion:"), nsvalue);
			}
			NSString.ReleaseNative (nsvalue);
			
		}
	}
	
	[CompilerGenerated]
	public virtual bool KeepAliveMeasurement {
		[Export ("keepAliveMeasurement")]
		get {
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("keepAliveMeasurement"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("keepAliveMeasurement"));
			}
		}
		
		[Export ("setKeepAliveMeasurement:")]
		set {
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setKeepAliveMeasurement:"), value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setKeepAliveMeasurement:"), value);
			}
		}
	}
	
	[CompilerGenerated]
	public virtual NSObject[] LabelOrder {
		[Export ("labelOrder", ArgumentSemantic.Copy)]
		get {
			NSObject[] ret;
			if (IsDirectBinding) {
				ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("labelOrder")));
			} else {
				ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("labelOrder")));
			}
			return ret;
		}
		
		[Export ("setLabelOrder:", ArgumentSemantic.Copy)]
		set {
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsa_value = NSArray.FromNSObjects (value);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLabelOrder:"), nsa_value.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLabelOrder:"), nsa_value.Handle);
			}
			nsa_value.Dispose ();
			
		}
	}
	
	[CompilerGenerated]
	public virtual string LiveEndpointURL {
		[Export ("liveEndpointURL")]
		get {
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("liveEndpointURL")));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("liveEndpointURL")));
			}
		}
		
		[Export ("setLiveEndpointURL:")]
		set {
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLiveEndpointURL:"), nsvalue);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLiveEndpointURL:"), nsvalue);
			}
			NSString.ReleaseNative (nsvalue);
			
		}
	}
	
	[CompilerGenerated]
	public virtual global::SCORLiveTransmissionMode LiveTransmissionMode {
		[Export ("liveTransmissionMode", ArgumentSemantic.UnsafeUnretained)]
		get {
			if (IsDirectBinding) {
				return (global::SCORLiveTransmissionMode) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("liveTransmissionMode"));
			} else {
				return (global::SCORLiveTransmissionMode) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("liveTransmissionMode"));
			}
		}
		
		[Export ("setLiveTransmissionMode:", ArgumentSemantic.UnsafeUnretained)]
		set {
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setLiveTransmissionMode:"), (UInt64)value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setLiveTransmissionMode:"), (UInt64)value);
			}
		}
	}
	
	[CompilerGenerated]
	public virtual NSDictionary PersistentLabels {
		[Export ("persistentLabels", ArgumentSemantic.Copy)]
		get {
			NSDictionary ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("persistentLabels")));
			} else {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("persistentLabels")));
			}
			return ret;
		}
		
		[Export ("setPersistentLabels:", ArgumentSemantic.Copy)]
		set {
			if (value == null)
				throw new ArgumentNullException ("value");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPersistentLabels:"), value.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPersistentLabels:"), value.Handle);
			}
		}
	}
	
	[CompilerGenerated]
	public virtual bool SecureTransmission {
		[Export ("secureTransmission")]
		get {
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("secureTransmission"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("secureTransmission"));
			}
		}
		
		[Export ("setSecureTransmission:")]
		set {
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSecureTransmission:"), value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setSecureTransmission:"), value);
			}
		}
	}
	
	[CompilerGenerated]
	public virtual NSDictionary StartLabels {
		[Export ("startLabels", ArgumentSemantic.Copy)]
		get {
			NSDictionary ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("startLabels")));
			} else {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("startLabels")));
			}
			return ret;
		}
		
		[Export ("setStartLabels:", ArgumentSemantic.Copy)]
		set {
			if (value == null)
				throw new ArgumentNullException ("value");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setStartLabels:"), value.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setStartLabels:"), value.Handle);
			}
		}
	}
	
	[CompilerGenerated]
	public virtual bool UncaughtExceptionTracking {
		[Export ("uncaughtExceptionTracking")]
		get {
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("uncaughtExceptionTracking"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("uncaughtExceptionTracking"));
			}
		}
		
		[Export ("setUncaughtExceptionTracking:")]
		set {
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setUncaughtExceptionTracking:"), value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setUncaughtExceptionTracking:"), value);
			}
		}
	}
	
	[CompilerGenerated]
	public virtual int UsagePropertiesAutoUpdateInterval {
		[Export ("usagePropertiesAutoUpdateInterval")]
		get {
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("usagePropertiesAutoUpdateInterval"));
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("usagePropertiesAutoUpdateInterval"));
			}
		}
		
		[Export ("setUsagePropertiesAutoUpdateInterval:")]
		set {
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setUsagePropertiesAutoUpdateInterval:"), value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setUsagePropertiesAutoUpdateInterval:"), value);
			}
		}
	}
	
	[CompilerGenerated]
	public virtual global::SCORUsagePropertiesAutoUpdateMode UsagePropertiesAutoUpdateMode {
		[Export ("usagePropertiesAutoUpdateMode", ArgumentSemantic.UnsafeUnretained)]
		get {
			global::SCORUsagePropertiesAutoUpdateMode ret;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					ret = (global::SCORUsagePropertiesAutoUpdateMode) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("usagePropertiesAutoUpdateMode"));
				} else {
					ret = (global::SCORUsagePropertiesAutoUpdateMode) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("usagePropertiesAutoUpdateMode"));
				}
			} else {
				if (IntPtr.Size == 8) {
					ret = (global::SCORUsagePropertiesAutoUpdateMode) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("usagePropertiesAutoUpdateMode"));
				} else {
					ret = (global::SCORUsagePropertiesAutoUpdateMode) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("usagePropertiesAutoUpdateMode"));
				}
			}
			return ret;
		}
		
		[Export ("setUsagePropertiesAutoUpdateMode:", ArgumentSemantic.UnsafeUnretained)]
		set {
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setUsagePropertiesAutoUpdateMode:"), (UInt64)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setUsagePropertiesAutoUpdateMode:"), (UInt32)value);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setUsagePropertiesAutoUpdateMode:"), (UInt64)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setUsagePropertiesAutoUpdateMode:"), (UInt32)value);
				}
			}
		}
	}
	
} /* class SCORClientConfigurationBuilder */
