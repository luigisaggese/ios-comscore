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
	[Register("SCORVCE", true)]
	public unsafe partial class SCORVCE : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SCORVCE");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SCORVCE () : base (NSObjectFlag.Empty)
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
		protected SCORVCE (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SCORVCE (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addPartnerID:")]
		[CompilerGenerated]
		public virtual void AddPartnerID (string partnerID)
		{
			if (partnerID == null)
				throw new ArgumentNullException ("partnerID");
			var nspartnerID = NSString.CreateNative (partnerID);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addPartnerID:"), nspartnerID);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addPartnerID:"), nspartnerID);
			}
			NSString.ReleaseNative (nspartnerID);
			
		}
		
		[Export ("addPublisherID:")]
		[CompilerGenerated]
		public virtual void AddPublisherID (string publisherID)
		{
			if (publisherID == null)
				throw new ArgumentNullException ("publisherID");
			var nspublisherID = NSString.CreateNative (publisherID);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addPublisherID:"), nspublisherID);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addPublisherID:"), nspublisherID);
			}
			NSString.ReleaseNative (nspublisherID);
			
		}
		
		[Export ("disable")]
		[CompilerGenerated]
		public static void Disable ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("disable"));
		}
		
		[Export ("discoverAndTrackAdClassNames:")]
		[CompilerGenerated]
		public virtual void DiscoverAndTrackAdClassNames (NSObject[] classNamesArray)
		{
			if (classNamesArray == null)
				throw new ArgumentNullException ("classNamesArray");
			var nsa_classNamesArray = NSArray.FromNSObjects (classNamesArray);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("discoverAndTrackAdClassNames:"), nsa_classNamesArray.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("discoverAndTrackAdClassNames:"), nsa_classNamesArray.Handle);
			}
			nsa_classNamesArray.Dispose ();
			
		}
		
		[Export ("discoverAndTrackAds")]
		[CompilerGenerated]
		public virtual void DiscoverAndTrackAds ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("discoverAndTrackAds"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("discoverAndTrackAds"));
			}
		}
		
		[Export ("manualTrack")]
		[CompilerGenerated]
		public virtual void ManualTrack ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("manualTrack"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("manualTrack"));
			}
		}
		
		[Export ("nativeTrack")]
		[CompilerGenerated]
		public virtual void NativeTrack ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("nativeTrack"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("nativeTrack"));
			}
		}
		
		[Export ("sharedInstance")]
		[CompilerGenerated]
		public static SCORVCE SharedInstance ()
		{
			return  Runtime.GetNSObject<SCORVCE> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedInstance")));
		}
		
		[Export ("stopTrackingNativeView:")]
		[CompilerGenerated]
		public virtual void StopTrackingNativeView (global::UIKit.UIView nativeView)
		{
			if (nativeView == null)
				throw new ArgumentNullException ("nativeView");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("stopTrackingNativeView:"), nativeView.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("stopTrackingNativeView:"), nativeView.Handle);
			}
		}
		
		[Export ("trackAdView:")]
		[CompilerGenerated]
		public virtual void TrackAdView (global::UIKit.UIView adView)
		{
			if (adView == null)
				throw new ArgumentNullException ("adView");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("trackAdView:"), adView.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("trackAdView:"), adView.Handle);
			}
		}
		
		[Export ("trackAdViewArray:")]
		[CompilerGenerated]
		public virtual void TrackAdViewArray (NSObject[] adViewArray)
		{
			if (adViewArray == null)
				throw new ArgumentNullException ("adViewArray");
			var nsa_adViewArray = NSArray.FromNSObjects (adViewArray);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("trackAdViewArray:"), nsa_adViewArray.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("trackAdViewArray:"), nsa_adViewArray.Handle);
			}
			nsa_adViewArray.Dispose ();
			
		}
		
		[Export ("trackNativeView:withTrackingURL:")]
		[CompilerGenerated]
		public virtual void TrackNativeView (global::UIKit.UIView nativeDisplayView, NSUrl displayImpressionURL)
		{
			if (nativeDisplayView == null)
				throw new ArgumentNullException ("nativeDisplayView");
			if (displayImpressionURL == null)
				throw new ArgumentNullException ("displayImpressionURL");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("trackNativeView:withTrackingURL:"), nativeDisplayView.Handle, displayImpressionURL.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("trackNativeView:withTrackingURL:"), nativeDisplayView.Handle, displayImpressionURL.Handle);
			}
		}
		
		[Export ("trackNativeView:forEventName:withEventURL:withParamsDict:")]
		[CompilerGenerated]
		public virtual void TrackNativeView (global::UIKit.UIView nativeView, string videoEventName, NSUrl url, NSDictionary dict)
		{
			if (nativeView == null)
				throw new ArgumentNullException ("nativeView");
			if (videoEventName == null)
				throw new ArgumentNullException ("videoEventName");
			if (url == null)
				throw new ArgumentNullException ("url");
			if (dict == null)
				throw new ArgumentNullException ("dict");
			var nsvideoEventName = NSString.CreateNative (videoEventName);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("trackNativeView:forEventName:withEventURL:withParamsDict:"), nativeView.Handle, nsvideoEventName, url.Handle, dict.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("trackNativeView:forEventName:withEventURL:withParamsDict:"), nativeView.Handle, nsvideoEventName, url.Handle, dict.Handle);
			}
			NSString.ReleaseNative (nsvideoEventName);
			
		}
		
		[CompilerGenerated]
		public static bool Enabled {
			[Export ("enabled")]
			get {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (class_ptr, Selector.GetHandle ("enabled"));
			}
			
		}
		
		[CompilerGenerated]
		public static string SdkVersion {
			[Export ("sdkVersion")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sdkVersion")));
			}
			
		}
		
	} /* class SCORVCE */
}
