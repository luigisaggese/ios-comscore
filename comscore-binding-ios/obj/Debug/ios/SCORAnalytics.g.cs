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

[Register("SCORAnalytics", true)]
public unsafe partial class SCORAnalytics : NSObject {
	
	[CompilerGenerated]
	static readonly IntPtr class_ptr = Class.GetHandle ("SCORAnalytics");
	
	public override IntPtr ClassHandle { get { return class_ptr; } }
	
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SCORAnalytics () : base (NSObjectFlag.Empty)
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
		protected SCORAnalytics (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SCORAnalytics (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

	[Export ("aggregateWithEventInfo:")]
	[CompilerGenerated]
	public static void AggregateWithEventInfo (global::SCOREventInfo eventInfo)
	{
		if (eventInfo == null)
			throw new ArgumentNullException ("eventInfo");
		global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("aggregateWithEventInfo:"), eventInfo.Handle);
	}
	
	[Export ("aggregateWithLabels:")]
	[CompilerGenerated]
	public static void AggregateWithLabels (NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("aggregateWithLabels:"), labels.Handle);
	}
	
	[Export ("clearInternalData")]
	[CompilerGenerated]
	public static void ClearInternalData ()
	{
		global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("clearInternalData"));
	}
	
	[Export ("clearOfflineCache")]
	[CompilerGenerated]
	public static void ClearOfflineCache ()
	{
		global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("clearOfflineCache"));
	}
	
	[Export ("configuration")]
	[CompilerGenerated]
	public static global::SCORConfiguration Configuration ()
	{
		return  Runtime.GetNSObject<global::SCORConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("configuration")));
	}
	
	[Export ("flushOfflineCache")]
	[CompilerGenerated]
	public static void FlushOfflineCache ()
	{
		global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("flushOfflineCache"));
	}
	
	[Export ("getActivationCategoriesWithKey:url:publisherConfiguration:block:")]
	[CompilerGenerated]
	public unsafe static void GetActivationCategoriesWithKey (string key, string url, global::SCORPublisherConfiguration publisherConfiguration, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSArray> callback)
	{
		if (key == null)
			throw new ArgumentNullException ("key");
		if (url == null)
			throw new ArgumentNullException ("url");
		if (publisherConfiguration == null)
			throw new ArgumentNullException ("publisherConfiguration");
		if (callback == null)
			throw new ArgumentNullException ("callback");
		var nskey = NSString.CreateNative (key);
		var nsurl = NSString.CreateNative (url);
		BlockLiteral *block_ptr_callback;
		BlockLiteral block_callback;
		block_callback = new BlockLiteral ();
		block_ptr_callback = &block_callback;
		block_callback.SetupBlock (Trampolines.SDActionArity1V0.Handler, callback);
		
		global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("getActivationCategoriesWithKey:url:publisherConfiguration:block:"), nskey, nsurl, publisherConfiguration.Handle, (IntPtr) block_ptr_callback);
		NSString.ReleaseNative (nskey);
		NSString.ReleaseNative (nsurl);
		block_ptr_callback->CleanupBlock ();
		
	}
	
	[Export ("notifyEnterForeground")]
	[CompilerGenerated]
	public static void NotifyEnterForeground ()
	{
		global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("notifyEnterForeground"));
	}
	
	[Export ("notifyExitForeground")]
	[CompilerGenerated]
	public static void NotifyExitForeground ()
	{
		global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("notifyExitForeground"));
	}
	
	[Export ("notifyHiddenEvent")]
	[CompilerGenerated]
	public static void NotifyHiddenEvent ()
	{
		global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("notifyHiddenEvent"));
	}
	
	[Export ("notifyHiddenEventWithEventInfo:")]
	[CompilerGenerated]
	public static void NotifyHiddenEventWithEventInfo (global::SCOREventInfo eventInfo)
	{
		if (eventInfo == null)
			throw new ArgumentNullException ("eventInfo");
		global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("notifyHiddenEventWithEventInfo:"), eventInfo.Handle);
	}
	
	[Export ("notifyHiddenEventWithLabels:")]
	[CompilerGenerated]
	public static void NotifyHiddenEventWithLabels (NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("notifyHiddenEventWithLabels:"), labels.Handle);
	}
	
	[Export ("notifyUserInteraction")]
	[CompilerGenerated]
	public static void NotifyUserInteraction ()
	{
		global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("notifyUserInteraction"));
	}
	
	[Export ("notifyUxActive")]
	[CompilerGenerated]
	public static void NotifyUxActive ()
	{
		global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("notifyUxActive"));
	}
	
	[Export ("notifyUxInactive")]
	[CompilerGenerated]
	public static void NotifyUxInactive ()
	{
		global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("notifyUxInactive"));
	}
	
	[Export ("notifyViewEvent")]
	[CompilerGenerated]
	public static void NotifyViewEvent ()
	{
		global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("notifyViewEvent"));
	}
	
	[Export ("notifyViewEventWithEventInfo:")]
	[CompilerGenerated]
	public static void NotifyViewEventWithEventInfo (global::SCOREventInfo eventInfo)
	{
		if (eventInfo == null)
			throw new ArgumentNullException ("eventInfo");
		global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("notifyViewEventWithEventInfo:"), eventInfo.Handle);
	}
	
	[Export ("notifyViewEventWithLabels:")]
	[CompilerGenerated]
	public static void NotifyViewEventWithLabels (NSDictionary labels)
	{
		if (labels == null)
			throw new ArgumentNullException ("labels");
		global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("notifyViewEventWithLabels:"), labels.Handle);
	}
	
	[Export ("start")]
	[CompilerGenerated]
	public static void Start ()
	{
		global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("start"));
	}
	
	[Export ("trackingProperties")]
	[CompilerGenerated]
	public static NSDictionary TrackingProperties ()
	{
		return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("trackingProperties")));
	}
	
	[Export ("updateUsageProperties")]
	[CompilerGenerated]
	public static void UpdateUsageProperties ()
	{
		global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("updateUsageProperties"));
	}
	
	[CompilerGenerated]
	public static global::SCORLogLevel LogLevel {
		[Export ("logLevel")]
		get {
			global::SCORLogLevel ret;
			if (IntPtr.Size == 8) {
				ret = (global::SCORLogLevel) global::ApiDefinition.Messaging.UInt64_objc_msgSend (class_ptr, Selector.GetHandle ("logLevel"));
			} else {
				ret = (global::SCORLogLevel) global::ApiDefinition.Messaging.UInt32_objc_msgSend (class_ptr, Selector.GetHandle ("logLevel"));
			}
			return ret;
		}
		
		[Export ("setLogLevel:")]
		set {
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (class_ptr, Selector.GetHandle ("setLogLevel:"), (UInt64)value);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (class_ptr, Selector.GetHandle ("setLogLevel:"), (UInt32)value);
			}
		}
	}
	
	[CompilerGenerated]
	public static string Version {
		[Export ("version")]
		get {
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("version")));
		}
		
	}
	
} /* class SCORAnalytics */
