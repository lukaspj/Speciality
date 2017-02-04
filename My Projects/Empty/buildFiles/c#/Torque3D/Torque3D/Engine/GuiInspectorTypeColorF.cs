using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorTypeColorF : GuiInspectorTypeColor
	{
		public GuiInspectorTypeColorF(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorTypeColorF(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorTypeColorF(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorTypeColorF(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorTypeColorF(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorTypeColorF(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorTypeColorF_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeColorF_create();
         private static _GuiInspectorTypeColorF_create _GuiInspectorTypeColorF_createFunc;
         internal static IntPtr GuiInspectorTypeColorF_create()
         {
         	if (_GuiInspectorTypeColorF_createFunc == null)
         	{
         		_GuiInspectorTypeColorF_createFunc =
         			(_GuiInspectorTypeColorF_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorTypeColorF_create"), typeof(_GuiInspectorTypeColorF_create));
         	}
         
         	return  _GuiInspectorTypeColorF_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}