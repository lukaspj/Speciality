using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorTypePrefabFilename : GuiInspectorTypeFileName
	{
		public GuiInspectorTypePrefabFilename(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorTypePrefabFilename(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorTypePrefabFilename(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorTypePrefabFilename(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorTypePrefabFilename(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorTypePrefabFilename(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorTypePrefabFilename_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypePrefabFilename_create();
         private static _GuiInspectorTypePrefabFilename_create _GuiInspectorTypePrefabFilename_createFunc;
         internal static IntPtr GuiInspectorTypePrefabFilename_create()
         {
         	if (_GuiInspectorTypePrefabFilename_createFunc == null)
         	{
         		_GuiInspectorTypePrefabFilename_createFunc =
         			(_GuiInspectorTypePrefabFilename_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorTypePrefabFilename_create"), typeof(_GuiInspectorTypePrefabFilename_create));
         	}
         
         	return  _GuiInspectorTypePrefabFilename_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}