using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ForcedMaterialMeshMgr : RenderMeshMgr
	{
		public ForcedMaterialMeshMgr(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ForcedMaterialMeshMgr(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ForcedMaterialMeshMgr(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ForcedMaterialMeshMgr(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ForcedMaterialMeshMgr(SimObject pObj) : base(pObj)
		{
		}

		public ForcedMaterialMeshMgr(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ForcedMaterialMeshMgr_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ForcedMaterialMeshMgr_create();
         private static _ForcedMaterialMeshMgr_create _ForcedMaterialMeshMgr_createFunc;
         internal static IntPtr ForcedMaterialMeshMgr_create()
         {
         	if (_ForcedMaterialMeshMgr_createFunc == null)
         	{
         		_ForcedMaterialMeshMgr_createFunc =
         			(_ForcedMaterialMeshMgr_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ForcedMaterialMeshMgr_create"), typeof(_ForcedMaterialMeshMgr_create));
         	}
         
         	return  _ForcedMaterialMeshMgr_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public Material Material
         {
         	get { return Sim.FindObject<Material>(getFieldValue("Material")); }
         	set { setFieldValue("Material", value.getId().ToString()); }
         }
      
      
      #endregion

	}
}