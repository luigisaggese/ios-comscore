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

[Register("SCORPartnerConfiguration", true)]
public unsafe partial class SCORPartnerConfiguration : global::SCORClientConfiguration {
	
	[CompilerGenerated]
	static readonly IntPtr class_ptr = Class.GetHandle ("SCORPartnerConfiguration");
	
	public override IntPtr ClassHandle { get { return class_ptr; } }
	
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SCORPartnerConfiguration () : base (NSObjectFlag.Empty)
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
		protected SCORPartnerConfiguration (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SCORPartnerConfiguration (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

	[Export ("initWithBuilder:")]
	[CompilerGenerated]
	public SCORPartnerConfiguration (global::SCORPartnerConfigurationBuilder builder)
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
	
	[Export ("partnerConfigurationWithBuilderBlock:")]
	[CompilerGenerated]
	public unsafe static global::SCORPartnerConfiguration PartnerConfigurationWithBuilderBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<global::SCORPartnerConfigurationBuilder> block)
	{
		if (block == null)
			throw new ArgumentNullException ("block");
		BlockLiteral *block_ptr_block;
		BlockLiteral block_block;
		block_block = new BlockLiteral ();
		block_ptr_block = &block_block;
		block_block.SetupBlock (Trampolines.SDActionArity1V1.Handler, block);
		
		global::SCORPartnerConfiguration ret;
		ret =  Runtime.GetNSObject<global::SCORPartnerConfiguration> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("partnerConfigurationWithBuilderBlock:"), (IntPtr) block_ptr_block));
		block_ptr_block->CleanupBlock ();
		
		return ret;
	}
	
	[CompilerGenerated]
	public virtual string ExternalClientId {
		[Export ("externalClientId")]
		get {
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("externalClientId")));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("externalClientId")));
			}
		}
		
	}
	
	[CompilerGenerated]
	public virtual string PartnerId {
		[Export ("partnerId")]
		get {
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("partnerId")));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("partnerId")));
			}
		}
		
	}
	
} /* class SCORPartnerConfiguration */
