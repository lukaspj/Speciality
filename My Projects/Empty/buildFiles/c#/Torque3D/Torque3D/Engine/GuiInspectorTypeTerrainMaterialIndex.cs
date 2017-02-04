using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorTypeTerrainMaterialIndex : GuiInspectorTypeMaterialName
	{
		public GuiInspectorTypeTerrainMaterialIndex(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorTypeTerrainMaterialIndex(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorTypeTerrainMaterialIndex(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorTypeTerrainMaterialIndex(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorTypeTerrainMaterialIndex(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorTypeTerrainMaterialIndex(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorTypeTerrainMaterialIndex_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeTerrainMaterialIndex_create();
         private static _GuiInspectorTypeTerrainMaterialIndex_create _GuiInspectorTypeTerrainMaterialIndex_createFunc;
         internal static IntPtr GuiInspectorTypeTerrainMaterialIndex_create()
         {
         	if (_GuiInspectorTypeTerrainMaterialIndex_createFunc == null)
         	{
         		_GuiInspectorTypeTerrainMaterialIndex_createFunc =
         			(_GuiInspectorTypeTerrainMaterialIndex_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorTypeTerrainMaterialIndex_create"), typeof(_GuiInspectorTypeTerrainMaterialIndex_create));
         	}
         
         	return  _GuiInspectorTypeTerrainMaterialIndex_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}