using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorTypeColorI : GuiInspectorTypeColor
	{
		public GuiInspectorTypeColorI(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorTypeColorI(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorTypeColorI(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorTypeColorI(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorTypeColorI(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorTypeColorI(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorTypeColorI_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeColorI_create();
         private static _GuiInspectorTypeColorI_create _GuiInspectorTypeColorI_createFunc;
         internal static IntPtr GuiInspectorTypeColorI_create()
         {
         	if (_GuiInspectorTypeColorI_createFunc == null)
         	{
         		_GuiInspectorTypeColorI_createFunc =
         			(_GuiInspectorTypeColorI_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorTypeColorI_create"), typeof(_GuiInspectorTypeColorI_create));
         	}
         
         	return  _GuiInspectorTypeColorI_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}