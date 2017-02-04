using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class MissionMarkerData : ShapeBaseData
	{
		public MissionMarkerData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public MissionMarkerData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public MissionMarkerData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public MissionMarkerData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public MissionMarkerData(SimObject pObj) : base(pObj)
		{
		}

		public MissionMarkerData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.MissionMarkerData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _MissionMarkerData_create();
         private static _MissionMarkerData_create _MissionMarkerData_createFunc;
         internal static IntPtr MissionMarkerData_create()
         {
         	if (_MissionMarkerData_createFunc == null)
         	{
         		_MissionMarkerData_createFunc =
         			(_MissionMarkerData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_MissionMarkerData_create"), typeof(_MissionMarkerData_create));
         	}
         
         	return  _MissionMarkerData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}