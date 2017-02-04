using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorTypeTerrainMaterialName : GuiInspectorTypeMaterialName
	{
		public GuiInspectorTypeTerrainMaterialName(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorTypeTerrainMaterialName(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorTypeTerrainMaterialName(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorTypeTerrainMaterialName(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorTypeTerrainMaterialName(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorTypeTerrainMaterialName(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorTypeTerrainMaterialName_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeTerrainMaterialName_create();
         private static _GuiInspectorTypeTerrainMaterialName_create _GuiInspectorTypeTerrainMaterialName_createFunc;
         internal static IntPtr GuiInspectorTypeTerrainMaterialName_create()
         {
         	if (_GuiInspectorTypeTerrainMaterialName_createFunc == null)
         	{
         		_GuiInspectorTypeTerrainMaterialName_createFunc =
         			(_GuiInspectorTypeTerrainMaterialName_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorTypeTerrainMaterialName_create"), typeof(_GuiInspectorTypeTerrainMaterialName_create));
         	}
         
         	return  _GuiInspectorTypeTerrainMaterialName_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}