using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class RenderPassStateToken : SimObject
	{
		public RenderPassStateToken(bool pRegister = false)
			: base(pRegister)
		{
		}

		public RenderPassStateToken(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public RenderPassStateToken(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public RenderPassStateToken(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public RenderPassStateToken(SimObject pObj) : base(pObj)
		{
		}

		public RenderPassStateToken(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.RenderPassStateToken_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _enable(IntPtr thisPtr);
         private static _enable _enableFunc;
         internal static void enable(IntPtr thisPtr)
         {
         	if (_enableFunc == null)
         	{
         		_enableFunc =
         			(_enable)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnRenderPassStateToken_enable"), typeof(_enable));
         	}
         
         	 _enableFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _disable(IntPtr thisPtr);
         private static _disable _disableFunc;
         internal static void disable(IntPtr thisPtr)
         {
         	if (_disableFunc == null)
         	{
         		_disableFunc =
         			(_disable)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnRenderPassStateToken_disable"), typeof(_disable));
         	}
         
         	 _disableFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _toggle(IntPtr thisPtr);
         private static _toggle _toggleFunc;
         internal static void toggle(IntPtr thisPtr)
         {
         	if (_toggleFunc == null)
         	{
         		_toggleFunc =
         			(_toggle)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnRenderPassStateToken_toggle"), typeof(_toggle));
         	}
         
         	 _toggleFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _RenderPassStateToken_create();
         private static _RenderPassStateToken_create _RenderPassStateToken_createFunc;
         internal static IntPtr RenderPassStateToken_create()
         {
         	if (_RenderPassStateToken_createFunc == null)
         	{
         		_RenderPassStateToken_createFunc =
         			(_RenderPassStateToken_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_RenderPassStateToken_create"), typeof(_RenderPassStateToken_create));
         	}
         
         	return  _RenderPassStateToken_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void enable()
         {
            InternalUnsafeMethods.enable(ObjectPtr);
         }
      
         public virtual void disable()
         {
            InternalUnsafeMethods.disable(ObjectPtr);
         }
      
         public virtual void toggle()
         {
            InternalUnsafeMethods.toggle(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public bool Enabled
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Enabled")); }
         	set { setFieldValue("Enabled", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}