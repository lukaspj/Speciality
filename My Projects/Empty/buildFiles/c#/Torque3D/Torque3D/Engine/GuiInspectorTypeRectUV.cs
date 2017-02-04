using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorTypeRectUV : GuiInspectorField
	{
		public GuiInspectorTypeRectUV(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorTypeRectUV(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorTypeRectUV(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorTypeRectUV(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorTypeRectUV(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorTypeRectUV(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorTypeRectUV_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeRectUV_create();
         private static _GuiInspectorTypeRectUV_create _GuiInspectorTypeRectUV_createFunc;
         internal static IntPtr GuiInspectorTypeRectUV_create()
         {
         	if (_GuiInspectorTypeRectUV_createFunc == null)
         	{
         		_GuiInspectorTypeRectUV_createFunc =
         			(_GuiInspectorTypeRectUV_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorTypeRectUV_create"), typeof(_GuiInspectorTypeRectUV_create));
         	}
         
         	return  _GuiInspectorTypeRectUV_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}