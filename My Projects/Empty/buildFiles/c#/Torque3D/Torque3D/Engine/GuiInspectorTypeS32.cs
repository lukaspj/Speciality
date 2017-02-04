using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorTypeS32 : GuiInspectorField
	{
		public GuiInspectorTypeS32(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorTypeS32(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorTypeS32(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorTypeS32(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorTypeS32(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorTypeS32(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorTypeS32_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeS32_create();
         private static _GuiInspectorTypeS32_create _GuiInspectorTypeS32_createFunc;
         internal static IntPtr GuiInspectorTypeS32_create()
         {
         	if (_GuiInspectorTypeS32_createFunc == null)
         	{
         		_GuiInspectorTypeS32_createFunc =
         			(_GuiInspectorTypeS32_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorTypeS32_create"), typeof(_GuiInspectorTypeS32_create));
         	}
         
         	return  _GuiInspectorTypeS32_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}