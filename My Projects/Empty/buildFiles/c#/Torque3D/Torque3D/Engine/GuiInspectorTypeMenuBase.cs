using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorTypeMenuBase : GuiInspectorField
	{
		public GuiInspectorTypeMenuBase(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorTypeMenuBase(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorTypeMenuBase(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorTypeMenuBase(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorTypeMenuBase(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorTypeMenuBase(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorTypeMenuBase_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeMenuBase_create();
         private static _GuiInspectorTypeMenuBase_create _GuiInspectorTypeMenuBase_createFunc;
         internal static IntPtr GuiInspectorTypeMenuBase_create()
         {
         	if (_GuiInspectorTypeMenuBase_createFunc == null)
         	{
         		_GuiInspectorTypeMenuBase_createFunc =
         			(_GuiInspectorTypeMenuBase_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorTypeMenuBase_create"), typeof(_GuiInspectorTypeMenuBase_create));
         	}
         
         	return  _GuiInspectorTypeMenuBase_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}