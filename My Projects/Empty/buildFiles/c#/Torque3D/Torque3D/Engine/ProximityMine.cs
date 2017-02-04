using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ProximityMine : Item
	{
		public ProximityMine(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ProximityMine(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ProximityMine(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ProximityMine(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ProximityMine(SimObject pObj) : base(pObj)
		{
		}

		public ProximityMine(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ProximityMine_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _explode(IntPtr thisPtr);
         private static _explode _explodeFunc;
         internal static void explode(IntPtr thisPtr)
         {
         	if (_explodeFunc == null)
         	{
         		_explodeFunc =
         			(_explode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnProximityMine_explode"), typeof(_explode));
         	}
         
         	 _explodeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ProximityMine_create();
         private static _ProximityMine_create _ProximityMine_createFunc;
         internal static IntPtr ProximityMine_create()
         {
         	if (_ProximityMine_createFunc == null)
         	{
         		_ProximityMine_createFunc =
         			(_ProximityMine_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ProximityMine_create"), typeof(_ProximityMine_create));
         	}
         
         	return  _ProximityMine_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void explode()
         {
            InternalUnsafeMethods.explode(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}