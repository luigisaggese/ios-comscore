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

namespace ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<NSArray>))]
		internal delegate void DActionArity1V0 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V0 {
			static internal readonly DActionArity1V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V0))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<NSArray>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSArray> (obj));
			}
		} /* class SDActionArity1V0 */
		
		internal class NIDActionArity1V0 {
			IntPtr blockPtr;
			DActionArity1V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<NSArray> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<NSArray>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSArray obj)
			{
				invoker (blockPtr, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDActionArity1V0 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<global::SCORPartnerConfigurationBuilder>))]
		internal delegate void DActionArity1V1 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V1 {
			static internal readonly DActionArity1V1 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V1))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::SCORPartnerConfigurationBuilder>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<SCORPartnerConfigurationBuilder> (obj));
			}
		} /* class SDActionArity1V1 */
		
		internal class NIDActionArity1V1 {
			IntPtr blockPtr;
			DActionArity1V1 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V1 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V1> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V1 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::SCORPartnerConfigurationBuilder> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::SCORPartnerConfigurationBuilder>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V1 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::SCORPartnerConfigurationBuilder obj)
			{
				invoker (blockPtr, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDActionArity1V1 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<global::SCORPublisherConfigurationBuilder>))]
		internal delegate void DActionArity1V2 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V2 {
			static internal readonly DActionArity1V2 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V2))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::SCORPublisherConfigurationBuilder>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<SCORPublisherConfigurationBuilder> (obj));
			}
		} /* class SDActionArity1V2 */
		
		internal class NIDActionArity1V2 {
			IntPtr blockPtr;
			DActionArity1V2 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V2 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V2> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V2 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::SCORPublisherConfigurationBuilder> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::SCORPublisherConfigurationBuilder>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V2 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::SCORPublisherConfigurationBuilder obj)
			{
				invoker (blockPtr, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDActionArity1V2 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<global::SCORStreamingConfigurationBuilder>))]
		internal delegate void DActionArity1V3 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V3 {
			static internal readonly DActionArity1V3 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V3))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::SCORStreamingConfigurationBuilder>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<SCORStreamingConfigurationBuilder> (obj));
			}
		} /* class SDActionArity1V3 */
		
		internal class NIDActionArity1V3 {
			IntPtr blockPtr;
			DActionArity1V3 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V3 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V3> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V3 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::SCORStreamingConfigurationBuilder> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::SCORStreamingConfigurationBuilder>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V3 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::SCORStreamingConfigurationBuilder obj)
			{
				invoker (blockPtr, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDActionArity1V3 */
	}
}
