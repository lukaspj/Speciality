using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorTypeName : GuiInspectorField
	{
		public GuiInspectorTypeName(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorTypeName(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorTypeName(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorTypeName(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorTypeName(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorTypeName(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorTypeName_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeName_create();
         private static _GuiInspectorTypeName_create _GuiInspectorTypeName_createFunc;
         internal static IntPtr GuiInspectorTypeName_create()
         {
         	if (_GuiInspectorTypeName_createFunc == null)
         	{
         		_GuiInspectorTypeName_createFunc =
         			(_GuiInspectorTypeName_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorTypeName_create"), typeof(_GuiInspectorTypeName_create));
         	}
         
         	return  _GuiInspectorTypeName_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}