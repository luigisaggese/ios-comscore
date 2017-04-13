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
	[Register("SCORReducedRequirementsStreamingAnalytics", true)]
	public unsafe partial class SCORReducedRequirementsStreamingAnalytics : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("SCORReducedRequirementsStreamingAnalytics");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SCORReducedRequirementsStreamingAnalytics () : base (NSObjectFlag.Empty)
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
		protected SCORReducedRequirementsStreamingAnalytics (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SCORReducedRequirementsStreamingAnalytics (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("playAudioAdvertisementWithMetadata:andMediaType:")]
		[CompilerGenerated]
		public virtual void PlayAudioAdvertisementWithMetadata (NSDictionary metadata, global::SCORAdType mediaType)
		{
			if (metadata == null)
				throw new ArgumentNullException ("metadata");
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt64 (this.Handle, Selector.GetHandle ("playAudioAdvertisementWithMetadata:andMediaType:"), metadata.Handle, (UInt64)mediaType);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32 (this.Handle, Selector.GetHandle ("playAudioAdvertisementWithMetadata:andMediaType:"), metadata.Handle, (UInt32)mediaType);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_UInt64 (this.SuperHandle, Selector.GetHandle ("playAudioAdvertisementWithMetadata:andMediaType:"), metadata.Handle, (UInt64)mediaType);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_UInt32 (this.SuperHandle, Selector.GetHandle ("playAudioAdvertisementWithMetadata:andMediaType:"), metadata.Handle, (UInt32)mediaType);
				}
			}
		}
		
		[Export ("playAudioContentPartWithMetadata:andMediaType:")]
		[CompilerGenerated]
		public virtual void PlayAudioContentPartWithMetadata (NSDictionary metadata, global::SCORContentType mediaType)
		{
			if (metadata == null)
				throw new ArgumentNullException ("metadata");
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt64 (this.Handle, Selector.GetHandle ("playAudioContentPartWithMetadata:andMediaType:"), metadata.Handle, (UInt64)mediaType);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32 (this.Handle, Selector.GetHandle ("playAudioContentPartWithMetadata:andMediaType:"), metadata.Handle, (UInt32)mediaType);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_UInt64 (this.SuperHandle, Selector.GetHandle ("playAudioContentPartWithMetadata:andMediaType:"), metadata.Handle, (UInt64)mediaType);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_UInt32 (this.SuperHandle, Selector.GetHandle ("playAudioContentPartWithMetadata:andMediaType:"), metadata.Handle, (UInt32)mediaType);
				}
			}
		}
		
		[Export ("playVideoAdvertisementWithMetadata:andMediaType:")]
		[CompilerGenerated]
		public virtual void PlayVideoAdvertisementWithMetadata (NSDictionary metadata, global::SCORAdType mediaType)
		{
			if (metadata == null)
				throw new ArgumentNullException ("metadata");
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt64 (this.Handle, Selector.GetHandle ("playVideoAdvertisementWithMetadata:andMediaType:"), metadata.Handle, (UInt64)mediaType);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32 (this.Handle, Selector.GetHandle ("playVideoAdvertisementWithMetadata:andMediaType:"), metadata.Handle, (UInt32)mediaType);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_UInt64 (this.SuperHandle, Selector.GetHandle ("playVideoAdvertisementWithMetadata:andMediaType:"), metadata.Handle, (UInt64)mediaType);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_UInt32 (this.SuperHandle, Selector.GetHandle ("playVideoAdvertisementWithMetadata:andMediaType:"), metadata.Handle, (UInt32)mediaType);
				}
			}
		}
		
		[Export ("playVideoContentPartWithMetadata:andMediaType:")]
		[CompilerGenerated]
		public virtual void PlayVideoContentPartWithMetadata (NSDictionary metadata, global::SCORContentType mediaType)
		{
			if (metadata == null)
				throw new ArgumentNullException ("metadata");
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt64 (this.Handle, Selector.GetHandle ("playVideoContentPartWithMetadata:andMediaType:"), metadata.Handle, (UInt64)mediaType);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32 (this.Handle, Selector.GetHandle ("playVideoContentPartWithMetadata:andMediaType:"), metadata.Handle, (UInt32)mediaType);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_UInt64 (this.SuperHandle, Selector.GetHandle ("playVideoContentPartWithMetadata:andMediaType:"), metadata.Handle, (UInt64)mediaType);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_UInt32 (this.SuperHandle, Selector.GetHandle ("playVideoContentPartWithMetadata:andMediaType:"), metadata.Handle, (UInt32)mediaType);
				}
			}
		}
		
		[Export ("stop")]
		[CompilerGenerated]
		public virtual void Stop ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("stop"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stop"));
			}
		}
		
	} /* class SCORReducedRequirementsStreamingAnalytics */
}
