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

[Protocol (Name = "SCORConfigurationDelegate", WrapperType = typeof (SCORConfigurationDelegateWrapper))]
[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ConfigurationChangedWithConfigurationType", Selector = "configurationChangedWithConfigurationType:", ParameterType = new Type [] { typeof (SCORConfigurationType) }, ParameterByRef = new bool [] { false })]
public interface ISCORConfigurationDelegate : INativeObject, IDisposable
{
	[CompilerGenerated]
	[Export ("configurationChangedWithConfigurationType:")]
	[Preserve (Conditional = true)]
	void ConfigurationChangedWithConfigurationType (global::SCORConfigurationType configurationType);
	
}

internal sealed class SCORConfigurationDelegateWrapper : BaseWrapper, ISCORConfigurationDelegate {
	[Preserve (Conditional = true)]
	public SCORConfigurationDelegateWrapper (IntPtr handle, bool owns)
		: base (handle, owns)
	{
	}
	
	[Export ("configurationChangedWithConfigurationType:")]
	[CompilerGenerated]
	public void ConfigurationChangedWithConfigurationType (global::SCORConfigurationType configurationType)
	{
		if (IntPtr.Size == 8) {
			global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("configurationChangedWithConfigurationType:"), (UInt64)configurationType);
		} else {
			global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("configurationChangedWithConfigurationType:"), (UInt32)configurationType);
		}
	}
	
}
[Protocol]
[Register("SCORConfigurationDelegate", false)]
[Model]
public unsafe abstract partial class SCORConfigurationDelegate : NSObject, ISCORConfigurationDelegate {
	
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected SCORConfigurationDelegate () : base (NSObjectFlag.Empty)
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
		protected SCORConfigurationDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SCORConfigurationDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

	[Export ("configurationChangedWithConfigurationType:")]
	[CompilerGenerated]
	public abstract void ConfigurationChangedWithConfigurationType (global::SCORConfigurationType configurationType);
} /* class SCORConfigurationDelegate */
