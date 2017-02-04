using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorTypeMaterialName : GuiInspectorField
	{
		public GuiInspectorTypeMaterialName(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorTypeMaterialName(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorTypeMaterialName(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorTypeMaterialName(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorTypeMaterialName(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorTypeMaterialName(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorTypeMaterialName_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeMaterialName_create();
         private static _GuiInspectorTypeMaterialName_create _GuiInspectorTypeMaterialName_createFunc;
         internal static IntPtr GuiInspectorTypeMaterialName_create()
         {
         	if (_GuiInspectorTypeMaterialName_createFunc == null)
         	{
         		_GuiInspectorTypeMaterialName_createFunc =
         			(_GuiInspectorTypeMaterialName_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorTypeMaterialName_create"), typeof(_GuiInspectorTypeMaterialName_create));
         	}
         
         	return  _GuiInspectorTypeMaterialName_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}