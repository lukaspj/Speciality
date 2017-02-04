using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorTypeCheckBox : GuiInspectorField
	{
		public GuiInspectorTypeCheckBox(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorTypeCheckBox(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorTypeCheckBox(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorTypeCheckBox(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorTypeCheckBox(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorTypeCheckBox(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorTypeCheckBox_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeCheckBox_create();
         private static _GuiInspectorTypeCheckBox_create _GuiInspectorTypeCheckBox_createFunc;
         internal static IntPtr GuiInspectorTypeCheckBox_create()
         {
         	if (_GuiInspectorTypeCheckBox_createFunc == null)
         	{
         		_GuiInspectorTypeCheckBox_createFunc =
         			(_GuiInspectorTypeCheckBox_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorTypeCheckBox_create"), typeof(_GuiInspectorTypeCheckBox_create));
         	}
         
         	return  _GuiInspectorTypeCheckBox_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}