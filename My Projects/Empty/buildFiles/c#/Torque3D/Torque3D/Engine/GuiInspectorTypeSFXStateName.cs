using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorTypeSFXStateName : GuiInspectorTypeMenuBase
	{
		public GuiInspectorTypeSFXStateName(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorTypeSFXStateName(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorTypeSFXStateName(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorTypeSFXStateName(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorTypeSFXStateName(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorTypeSFXStateName(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorTypeSFXStateName_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeSFXStateName_create();
         private static _GuiInspectorTypeSFXStateName_create _GuiInspectorTypeSFXStateName_createFunc;
         internal static IntPtr GuiInspectorTypeSFXStateName_create()
         {
         	if (_GuiInspectorTypeSFXStateName_createFunc == null)
         	{
         		_GuiInspectorTypeSFXStateName_createFunc =
         			(_GuiInspectorTypeSFXStateName_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorTypeSFXStateName_create"), typeof(_GuiInspectorTypeSFXStateName_create));
         	}
         
         	return  _GuiInspectorTypeSFXStateName_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}