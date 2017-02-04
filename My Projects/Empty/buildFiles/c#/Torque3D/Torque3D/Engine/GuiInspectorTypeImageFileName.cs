using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorTypeImageFileName : GuiInspectorTypeFileName
	{
		public GuiInspectorTypeImageFileName(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorTypeImageFileName(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorTypeImageFileName(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorTypeImageFileName(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorTypeImageFileName(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorTypeImageFileName(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorTypeImageFileName_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeImageFileName_create();
         private static _GuiInspectorTypeImageFileName_create _GuiInspectorTypeImageFileName_createFunc;
         internal static IntPtr GuiInspectorTypeImageFileName_create()
         {
         	if (_GuiInspectorTypeImageFileName_createFunc == null)
         	{
         		_GuiInspectorTypeImageFileName_createFunc =
         			(_GuiInspectorTypeImageFileName_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorTypeImageFileName_create"), typeof(_GuiInspectorTypeImageFileName_create));
         	}
         
         	return  _GuiInspectorTypeImageFileName_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}