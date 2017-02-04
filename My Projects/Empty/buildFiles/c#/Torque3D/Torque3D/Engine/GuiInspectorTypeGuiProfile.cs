using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorTypeGuiProfile : GuiInspectorTypeMenuBase
	{
		public GuiInspectorTypeGuiProfile(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorTypeGuiProfile(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorTypeGuiProfile(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorTypeGuiProfile(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorTypeGuiProfile(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorTypeGuiProfile(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorTypeGuiProfile_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeGuiProfile_create();
         private static _GuiInspectorTypeGuiProfile_create _GuiInspectorTypeGuiProfile_createFunc;
         internal static IntPtr GuiInspectorTypeGuiProfile_create()
         {
         	if (_GuiInspectorTypeGuiProfile_createFunc == null)
         	{
         		_GuiInspectorTypeGuiProfile_createFunc =
         			(_GuiInspectorTypeGuiProfile_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorTypeGuiProfile_create"), typeof(_GuiInspectorTypeGuiProfile_create));
         	}
         
         	return  _GuiInspectorTypeGuiProfile_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}