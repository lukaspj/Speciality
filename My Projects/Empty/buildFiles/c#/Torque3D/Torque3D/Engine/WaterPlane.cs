using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class WaterPlane : WaterObject
	{
		public WaterPlane(bool pRegister = false)
			: base(pRegister)
		{
		}

		public WaterPlane(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public WaterPlane(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public WaterPlane(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public WaterPlane(SimObject pObj) : base(pObj)
		{
		}

		public WaterPlane(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.WaterPlane_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _WaterPlane_create();
         private static _WaterPlane_create _WaterPlane_createFunc;
         internal static IntPtr WaterPlane_create()
         {
         	if (_WaterPlane_createFunc == null)
         	{
         		_WaterPlane_createFunc =
         			(_WaterPlane_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_WaterPlane_create"), typeof(_WaterPlane_create));
         	}
         
         	return  _WaterPlane_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public int GridSize
         {
         	get { return int.Parse(getFieldValue("GridSize")); }
         	set { setFieldValue("GridSize", value.ToString()); }
         }
      
         public float GridElementSize
         {
         	get { return float.Parse(getFieldValue("GridElementSize")); }
         	set { setFieldValue("GridElementSize", value.ToString()); }
         }
      
      
      #endregion

	}
}