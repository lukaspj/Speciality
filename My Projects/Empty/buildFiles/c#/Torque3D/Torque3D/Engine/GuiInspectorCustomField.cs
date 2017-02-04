using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorCustomField : GuiInspectorField
	{
		public GuiInspectorCustomField(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorCustomField(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorCustomField(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorCustomField(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorCustomField(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorCustomField(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorCustomField_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorCustomField_create();
         private static _GuiInspectorCustomField_create _GuiInspectorCustomField_createFunc;
         internal static IntPtr GuiInspectorCustomField_create()
         {
         	if (_GuiInspectorCustomField_createFunc == null)
         	{
         		_GuiInspectorCustomField_createFunc =
         			(_GuiInspectorCustomField_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorCustomField_create"), typeof(_GuiInspectorCustomField_create));
         	}
         
         	return  _GuiInspectorCustomField_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}