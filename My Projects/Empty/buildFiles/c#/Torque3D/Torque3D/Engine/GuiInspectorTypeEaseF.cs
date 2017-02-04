using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorTypeEaseF : GuiInspectorField
	{
		public GuiInspectorTypeEaseF(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorTypeEaseF(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorTypeEaseF(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorTypeEaseF(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorTypeEaseF(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorTypeEaseF(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorTypeEaseF_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeEaseF_create();
         private static _GuiInspectorTypeEaseF_create _GuiInspectorTypeEaseF_createFunc;
         internal static IntPtr GuiInspectorTypeEaseF_create()
         {
         	if (_GuiInspectorTypeEaseF_createFunc == null)
         	{
         		_GuiInspectorTypeEaseF_createFunc =
         			(_GuiInspectorTypeEaseF_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorTypeEaseF_create"), typeof(_GuiInspectorTypeEaseF_create));
         	}
         
         	return  _GuiInspectorTypeEaseF_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}