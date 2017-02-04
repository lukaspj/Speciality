using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorTypeEnum : GuiInspectorTypeMenuBase
	{
		public GuiInspectorTypeEnum(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorTypeEnum(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorTypeEnum(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorTypeEnum(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorTypeEnum(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorTypeEnum(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorTypeEnum_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeEnum_create();
         private static _GuiInspectorTypeEnum_create _GuiInspectorTypeEnum_createFunc;
         internal static IntPtr GuiInspectorTypeEnum_create()
         {
         	if (_GuiInspectorTypeEnum_createFunc == null)
         	{
         		_GuiInspectorTypeEnum_createFunc =
         			(_GuiInspectorTypeEnum_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorTypeEnum_create"), typeof(_GuiInspectorTypeEnum_create));
         	}
         
         	return  _GuiInspectorTypeEnum_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}