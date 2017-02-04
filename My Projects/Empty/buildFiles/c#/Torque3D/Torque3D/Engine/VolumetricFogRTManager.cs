using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class VolumetricFogRTManager : SceneObject
	{
		public VolumetricFogRTManager(bool pRegister = false)
			: base(pRegister)
		{
		}

		public VolumetricFogRTManager(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public VolumetricFogRTManager(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public VolumetricFogRTManager(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public VolumetricFogRTManager(SimObject pObj) : base(pObj)
		{
		}

		public VolumetricFogRTManager(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.VolumetricFogRTManager_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _VolumetricFogRTManager_create();
         private static _VolumetricFogRTManager_create _VolumetricFogRTManager_createFunc;
         internal static IntPtr VolumetricFogRTManager_create()
         {
         	if (_VolumetricFogRTManager_createFunc == null)
         	{
         		_VolumetricFogRTManager_createFunc =
         			(_VolumetricFogRTManager_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_VolumetricFogRTManager_create"), typeof(_VolumetricFogRTManager_create));
         	}
         
         	return  _VolumetricFogRTManager_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}