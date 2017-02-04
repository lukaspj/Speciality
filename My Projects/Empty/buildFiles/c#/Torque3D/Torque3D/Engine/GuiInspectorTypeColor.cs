using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorTypeColor : GuiInspectorField
	{
		public GuiInspectorTypeColor(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorTypeColor(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorTypeColor(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorTypeColor(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorTypeColor(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorTypeColor(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorTypeColor_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeColor_create();
         private static _GuiInspectorTypeColor_create _GuiInspectorTypeColor_createFunc;
         internal static IntPtr GuiInspectorTypeColor_create()
         {
         	if (_GuiInspectorTypeColor_createFunc == null)
         	{
         		_GuiInspectorTypeColor_createFunc =
         			(_GuiInspectorTypeColor_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorTypeColor_create"), typeof(_GuiInspectorTypeColor_create));
         	}
         
         	return  _GuiInspectorTypeColor_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}