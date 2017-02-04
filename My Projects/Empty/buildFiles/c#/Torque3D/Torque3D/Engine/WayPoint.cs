using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class WayPoint : MissionMarker
	{
		public WayPoint(bool pRegister = false)
			: base(pRegister)
		{
		}

		public WayPoint(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public WayPoint(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public WayPoint(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public WayPoint(SimObject pObj) : base(pObj)
		{
		}

		public WayPoint(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.WayPoint_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _WayPoint_create();
         private static _WayPoint_create _WayPoint_createFunc;
         internal static IntPtr WayPoint_create()
         {
         	if (_WayPoint_createFunc == null)
         	{
         		_WayPoint_createFunc =
         			(_WayPoint_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_WayPoint_create"), typeof(_WayPoint_create));
         	}
         
         	return  _WayPoint_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string MarkerName
         {
         	get { return getFieldValue("MarkerName"); }
         	set { setFieldValue("MarkerName", value); }
         }
      
      
      #endregion

	}
}