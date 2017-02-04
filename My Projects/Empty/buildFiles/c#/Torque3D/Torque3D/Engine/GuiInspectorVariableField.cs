using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorVariableField : GuiInspectorField
	{
		public GuiInspectorVariableField(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorVariableField(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorVariableField(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorVariableField(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorVariableField(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorVariableField(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorVariableField_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorVariableField_create();
         private static _GuiInspectorVariableField_create _GuiInspectorVariableField_createFunc;
         internal static IntPtr GuiInspectorVariableField_create()
         {
         	if (_GuiInspectorVariableField_createFunc == null)
         	{
         		_GuiInspectorVariableField_createFunc =
         			(_GuiInspectorVariableField_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorVariableField_create"), typeof(_GuiInspectorVariableField_create));
         	}
         
         	return  _GuiInspectorVariableField_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}