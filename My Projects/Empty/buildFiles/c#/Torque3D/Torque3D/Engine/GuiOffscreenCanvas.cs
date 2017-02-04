using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiOffscreenCanvas : GuiCanvas
	{
		public GuiOffscreenCanvas(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiOffscreenCanvas(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiOffscreenCanvas(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiOffscreenCanvas(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiOffscreenCanvas(SimObject pObj) : base(pObj)
		{
		}

		public GuiOffscreenCanvas(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiOffscreenCanvas_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _resetTarget(IntPtr thisPtr);
         private static _resetTarget _resetTargetFunc;
         internal static void resetTarget(IntPtr thisPtr)
         {
         	if (_resetTargetFunc == null)
         	{
         		_resetTargetFunc =
         			(_resetTarget)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiOffscreenCanvas_resetTarget"), typeof(_resetTarget));
         	}
         
         	 _resetTargetFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _markDirty(IntPtr thisPtr);
         private static _markDirty _markDirtyFunc;
         internal static void markDirty(IntPtr thisPtr)
         {
         	if (_markDirtyFunc == null)
         	{
         		_markDirtyFunc =
         			(_markDirty)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiOffscreenCanvas_markDirty"), typeof(_markDirty));
         	}
         
         	 _markDirtyFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiOffscreenCanvas_create();
         private static _GuiOffscreenCanvas_create _GuiOffscreenCanvas_createFunc;
         internal static IntPtr GuiOffscreenCanvas_create()
         {
         	if (_GuiOffscreenCanvas_createFunc == null)
         	{
         		_GuiOffscreenCanvas_createFunc =
         			(_GuiOffscreenCanvas_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiOffscreenCanvas_create"), typeof(_GuiOffscreenCanvas_create));
         	}
         
         	return  _GuiOffscreenCanvas_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void resetTarget()
         {
            InternalUnsafeMethods.resetTarget(ObjectPtr);
         }
      
         public virtual void markDirty()
         {
            InternalUnsafeMethods.markDirty(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public Point2I TargetSize
         {
         	get { return new Point2I(getFieldValue("TargetSize")); }
         	set { setFieldValue("TargetSize", value.ToString()); }
         }
      
         public GFXFormat TargetFormat
         {
         	get { return (GFXFormat)Enum.Parse(typeof(GFXFormat), getFieldValue("TargetFormat"), true); }
         	set { setFieldValue("TargetFormat", value.ToString()); }
         }
      
         public string TargetName
         {
         	get { return getFieldValue("TargetName"); }
         	set { setFieldValue("TargetName", value); }
         }
      
         public bool DynamicTarget
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("DynamicTarget")); }
         	set { setFieldValue("DynamicTarget", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}