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

[Register("SCORPublisherConfiguration", true)]
public unsafe partial class SCORPublisherConfiguration : global::SCORClientConfiguration {
	
	[CompilerGenerated]
	static readonly IntPtr class_ptr = Class.GetHandle ("SCORPublisherConfiguration");
	
	public override IntPtr ClassHandle { get { return class_ptr; } }
	
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SCORPublisherConfiguration () : base (NSObjectFlag.Empty)
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
		protected SCORPublisherConfiguration (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SCORPublisherConfiguration (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

	[Export ("initWithBuilder:")]
	[CompilerGenerated]
	public SCORPublisherConfiguration (global::SCORPublisherConfigurationBuilder builder)
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
	
	[Export ("publisherConfigurationWithBuilderBlock:")]
	[CompilerGenerated]
	public unsafe static global::SCORPublisherConfiguration PublisherConfigurationWithBuilderBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<global::SCORPublisherConfigurationBuilder> block)
	{
		if (block == null)
			throw new ArgumentNullException ("block");
		BlockLiteral *block_ptr_block;
		BlockLiteral block_block;
		block_block = new BlockLiteral ();
		block_ptr_block = &block_block;
		block_block.SetupBlock (Trampolines.SDActionArity1V2.Handler, block);
		
		global::SCORPublisherConfiguration ret;
		ret =  Runtime.GetNSObject<global::SCORPublisherConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("publisherConfigurationWithBuilderBlock:"), (IntPtr) block_ptr_block));
		block_ptr_block->CleanupBlock ();
		
		return ret;
	}
	
	[CompilerGenerated]
	public virtual string PublisherId {
		[Export ("publisherId")]
		get {
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("publisherId")));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("publisherId")));
			}
		}
		
	}
	
	[CompilerGenerated]
	public virtual string PublisherSecret {
		[Export ("publisherSecret")]
		get {
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("publisherSecret")));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("publisherSecret")));
			}
		}
		
	}
	
} /* class SCORPublisherConfiguration */
