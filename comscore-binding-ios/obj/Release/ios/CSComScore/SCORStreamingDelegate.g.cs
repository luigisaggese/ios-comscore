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
	[Protocol (Name = "SCORStreamingDelegate", WrapperType = typeof (SCORStreamingDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "NewState", Selector = "onStateChanged:newState:eventLabels:timeDelta:", ParameterType = new Type [] { typeof (SCORStreamingState), typeof (SCORStreamingState), typeof (NSDictionary), typeof (double) }, ParameterByRef = new bool [] { false, false, false, false })]
	public interface ISCORStreamingDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class SCORStreamingDelegate_Extensions {
		[CompilerGenerated]
		public static void NewState (this ISCORStreamingDelegate This, global::SCORStreamingState oldState, global::SCORStreamingState newState, NSDictionary eventLabels, global::System.Double timeDelta)
		{
			if (eventLabels == null)
				throw new ArgumentNullException ("eventLabels");
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt64_UInt64_IntPtr_Double (This.Handle, Selector.GetHandle ("onStateChanged:newState:eventLabels:timeDelta:"), (UInt64)oldState, (UInt64)newState, eventLabels.Handle, timeDelta);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt32_UInt32_IntPtr_Double (This.Handle, Selector.GetHandle ("onStateChanged:newState:eventLabels:timeDelta:"), (UInt32)oldState, (UInt32)newState, eventLabels.Handle, timeDelta);
			}
		}
		
	}
	
	internal sealed class SCORStreamingDelegateWrapper : BaseWrapper, ISCORStreamingDelegate {
		[Preserve (Conditional = true)]
		public SCORStreamingDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace CSComScore {
	[Protocol]
	[Register("SCORStreamingDelegate", false)]
	[Model]
	public unsafe partial class SCORStreamingDelegate : NSObject, ISCORStreamingDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SCORStreamingDelegate () : base (NSObjectFlag.Empty)
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
		protected SCORStreamingDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SCORStreamingDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("onStateChanged:newState:eventLabels:timeDelta:")]
		[CompilerGenerated]
		public virtual void NewState (global::SCORStreamingState oldState, global::SCORStreamingState newState, NSDictionary eventLabels, global::System.Double timeDelta)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class SCORStreamingDelegate */
}
