using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class PathCameraData : ShapeBaseData
	{
		public PathCameraData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public PathCameraData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public PathCameraData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public PathCameraData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public PathCameraData(SimObject pObj) : base(pObj)
		{
		}

		public PathCameraData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.PathCameraData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _PathCameraData_create();
         private static _PathCameraData_create _PathCameraData_createFunc;
         internal static IntPtr PathCameraData_create()
         {
         	if (_PathCameraData_createFunc == null)
         	{
         		_PathCameraData_createFunc =
         			(_PathCameraData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_PathCameraData_create"), typeof(_PathCameraData_create));
         	}
         
         	return  _PathCameraData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}