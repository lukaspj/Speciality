using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class MissionMarker : ShapeBase
	{
		public MissionMarker(bool pRegister = false)
			: base(pRegister)
		{
		}

		public MissionMarker(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public MissionMarker(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public MissionMarker(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public MissionMarker(SimObject pObj) : base(pObj)
		{
		}

		public MissionMarker(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.MissionMarker_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _MissionMarker_create();
         private static _MissionMarker_create _MissionMarker_createFunc;
         internal static IntPtr MissionMarker_create()
         {
         	if (_MissionMarker_createFunc == null)
         	{
         		_MissionMarker_createFunc =
         			(_MissionMarker_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_MissionMarker_create"), typeof(_MissionMarker_create));
         	}
         
         	return  _MissionMarker_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}