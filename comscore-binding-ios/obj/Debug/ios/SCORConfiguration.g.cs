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

[Register("SCORConfiguration", true)]
public unsafe partial class SCORConfiguration : NSObject {
	
	[CompilerGenerated]
	static readonly IntPtr class_ptr = Class.GetHandle ("SCORConfiguration");
	
	public override IntPtr ClassHandle { get { return class_ptr; } }
	
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SCORConfiguration () : base (NSObjectFlag.Empty)
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
		protected SCORConfiguration (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SCORConfiguration (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

	[Export ("addClientWithConfiguration:")]
	[CompilerGenerated]
	public virtual void AddClientWithConfiguration (global::SCORClientConfiguration clientConfiguration)
	{
		if (clientConfiguration == null)
			throw new ArgumentNullException ("clientConfiguration");
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addClientWithConfiguration:"), clientConfiguration.Handle);
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addClientWithConfiguration:"), clientConfiguration.Handle);
		}
	}
	
	[Export ("addDelegate:")]
	[CompilerGenerated]
	public virtual void AddDelegate (global::SCORConfigurationDelegate @delegate)
	{
		if (@delegate == null)
			throw new ArgumentNullException ("@delegate");
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addDelegate:"), @delegate.Handle);
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addDelegate:"), @delegate.Handle);
		}
	}
	
	[Export ("containsPersistentLabel:")]
	[CompilerGenerated]
	public virtual bool ContainsPersistentLabel (string labelName)
	{
		if (labelName == null)
			throw new ArgumentNullException ("labelName");
		var nslabelName = NSString.CreateNative (labelName);
		
		bool ret;
		if (IsDirectBinding) {
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("containsPersistentLabel:"), nslabelName);
		} else {
			ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("containsPersistentLabel:"), nslabelName);
		}
		NSString.ReleaseNative (nslabelName);
		
		return ret;
	}
	
	[Export ("disable")]
	[CompilerGenerated]
	public virtual void Disable ()
	{
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("disable"));
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("disable"));
		}
	}
	
	[Export ("partnerConfigurationWithPartnerId:")]
	[CompilerGenerated]
	public virtual global::SCORPartnerConfiguration PartnerConfigurationWithPartnerId (string partnerId)
	{
		if (partnerId == null)
			throw new ArgumentNullException ("partnerId");
		var nspartnerId = NSString.CreateNative (partnerId);
		
		global::SCORPartnerConfiguration ret;
		if (IsDirectBinding) {
			ret =  Runtime.GetNSObject<global::SCORPartnerConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("partnerConfigurationWithPartnerId:"), nspartnerId));
		} else {
			ret =  Runtime.GetNSObject<global::SCORPartnerConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("partnerConfigurationWithPartnerId:"), nspartnerId));
		}
		NSString.ReleaseNative (nspartnerId);
		
		return ret;
	}
	
	[Export ("persistentLabelWithName:")]
	[CompilerGenerated]
	public virtual string PersistentLabelWithName (string name)
	{
		if (name == null)
			throw new ArgumentNullException ("name");
		var nsname = NSString.CreateNative (name);
		
		string ret;
		if (IsDirectBinding) {
			ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("persistentLabelWithName:"), nsname));
		} else {
			ret = NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("persistentLabelWithName:"), nsname));
		}
		NSString.ReleaseNative (nsname);
		
		return ret;
	}
	
	[Export ("publisherConfigurationWithPublisherId:")]
	[CompilerGenerated]
	public virtual global::SCORPublisherConfiguration PublisherConfigurationWithPublisherId (string publisherId)
	{
		if (publisherId == null)
			throw new ArgumentNullException ("publisherId");
		var nspublisherId = NSString.CreateNative (publisherId);
		
		global::SCORPublisherConfiguration ret;
		if (IsDirectBinding) {
			ret =  Runtime.GetNSObject<global::SCORPublisherConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("publisherConfigurationWithPublisherId:"), nspublisherId));
		} else {
			ret =  Runtime.GetNSObject<global::SCORPublisherConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("publisherConfigurationWithPublisherId:"), nspublisherId));
		}
		NSString.ReleaseNative (nspublisherId);
		
		return ret;
	}
	
	[Export ("removeAllPersistentLabels")]
	[CompilerGenerated]
	public virtual void RemoveAllPersistentLabels ()
	{
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeAllPersistentLabels"));
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("removeAllPersistentLabels"));
		}
	}
	
	[Export ("removeDelegate:")]
	[CompilerGenerated]
	public virtual void RemoveDelegate (global::SCORConfigurationDelegate @delegate)
	{
		if (@delegate == null)
			throw new ArgumentNullException ("@delegate");
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeDelegate:"), @delegate.Handle);
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeDelegate:"), @delegate.Handle);
		}
	}
	
	[Export ("removePersistentLabelWithName:")]
	[CompilerGenerated]
	public virtual void RemovePersistentLabelWithName (string name)
	{
		if (name == null)
			throw new ArgumentNullException ("name");
		var nsname = NSString.CreateNative (name);
		
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removePersistentLabelWithName:"), nsname);
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removePersistentLabelWithName:"), nsname);
		}
		NSString.ReleaseNative (nsname);
		
	}
	
	[Export ("setPersistentLabelWithName:value:")]
	[CompilerGenerated]
	public virtual void SetPersistentLabelWithName (string name, string value)
	{
		if (name == null)
			throw new ArgumentNullException ("name");
		if (value == null)
			throw new ArgumentNullException ("value");
		var nsname = NSString.CreateNative (name);
		var nsvalue = NSString.CreateNative (value);
		
		if (IsDirectBinding) {
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setPersistentLabelWithName:value:"), nsname, nsvalue);
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("setPersistentLabelWithName:value:"), nsname, nsvalue);
		}
		NSString.ReleaseNative (nsname);
		NSString.ReleaseNative (nsvalue);
		
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
	public virtual bool Enabled {
		[Export ("enabled")]
		get {
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("enabled"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("enabled"));
			}
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
		[Export ("labelOrder")]
		get {
			NSObject[] ret;
			if (IsDirectBinding) {
				ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("labelOrder")));
			} else {
				ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("labelOrder")));
			}
			return ret;
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
	public virtual NSObject[] PartnerConfigurations {
		[Export ("partnerConfigurations")]
		get {
			NSObject[] ret;
			if (IsDirectBinding) {
				ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("partnerConfigurations")));
			} else {
				ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("partnerConfigurations")));
			}
			return ret;
		}
		
	}
	
	[CompilerGenerated]
	public virtual NSDictionary PersistentLabels {
		[Export ("persistentLabels")]
		get {
			NSDictionary ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("persistentLabels")));
			} else {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("persistentLabels")));
			}
			return ret;
		}
		
		[Export ("setPersistentLabels:")]
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
	public virtual NSObject[] PublisherConfigurations {
		[Export ("publisherConfigurations")]
		get {
			NSObject[] ret;
			if (IsDirectBinding) {
				ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("publisherConfigurations")));
			} else {
				ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("publisherConfigurations")));
			}
			return ret;
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
		
	}
	
	[CompilerGenerated]
	public virtual global::SCORUsagePropertiesAutoUpdateMode UsagePropertiesAutoUpdateMode {
		[Export ("usagePropertiesAutoUpdateMode")]
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
		
	}
	
} /* class SCORConfiguration */
