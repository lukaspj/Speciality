using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class DecalManager : SceneObject
	{
		public DecalManager(bool pRegister = false)
			: base(pRegister)
		{
		}

		public DecalManager(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public DecalManager(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public DecalManager(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public DecalManager(SimObject pObj) : base(pObj)
		{
		}

		public DecalManager(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.DecalManager_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _DecalManager_create();
         private static _DecalManager_create _DecalManager_createFunc;
         internal static IntPtr DecalManager_create()
         {
         	if (_DecalManager_createFunc == null)
         	{
         		_DecalManager_createFunc =
         			(_DecalManager_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_DecalManager_create"), typeof(_DecalManager_create));
         	}
         
         	return  _DecalManager_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}