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

[Register("SCORStreamingConfiguration", true)]
public unsafe partial class SCORStreamingConfiguration : NSObject {
	
	[CompilerGenerated]
	static readonly IntPtr class_ptr = Class.GetHandle ("SCORStreamingConfiguration");
	
	public override IntPtr ClassHandle { get { return class_ptr; } }
	
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SCORStreamingConfiguration () : base (NSObjectFlag.Empty)
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
		protected SCORStreamingConfiguration (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SCORStreamingConfiguration (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

	[Export ("initWithBuilder:")]
	[CompilerGenerated]
	public SCORStreamingConfiguration (global::SCORStreamingConfigurationBuilder builder)
		: base (NSObjectFlag.Empty)
	{
		if (builder == null)
			throw new ArgumentNullException ("builder");
		IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		if (IsDirectBinding) {
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithBuilder:"), builder.Handle), "initWithBuilder:");
		} else {
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithBuilder:"), builder.Handle), "initWithBuilder:");
		}
	}
	
	[Export ("streamingConfigurationWithBuilderBlock:")]
	[CompilerGenerated]
	public unsafe static global::SCORStreamingConfiguration StreamingConfigurationWithBuilderBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V3))]global::System.Action<global::SCORStreamingConfigurationBuilder> block)
	{
		if (block == null)
			throw new ArgumentNullException ("block");
		BlockLiteral *block_ptr_block;
		BlockLiteral block_block;
		block_block = new BlockLiteral ();
		block_ptr_block = &block_block;
		block_block.SetupBlock (Trampolines.SDActionArity1V3.Handler, block);
		
		global::SCORStreamingConfiguration ret;
		ret =  Runtime.GetNSObject<global::SCORStreamingConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("streamingConfigurationWithBuilderBlock:"), (IntPtr) block_ptr_block));
		block_ptr_block->CleanupBlock ();
		
		return ret;
	}
	
	[CompilerGenerated]
	public virtual NSObject[] RestrictedPublishersList {
		[Export ("restrictedPublishersList")]
		get {
			NSObject[] ret;
			if (IsDirectBinding) {
				ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("restrictedPublishersList")));
			} else {
				ret = NSArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("restrictedPublishersList")));
			}
			return ret;
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
		
	}
	
} /* class SCORStreamingConfiguration */
