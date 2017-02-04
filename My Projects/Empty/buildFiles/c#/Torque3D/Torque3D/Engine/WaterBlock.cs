using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class WaterBlock : WaterObject
	{
		public WaterBlock(bool pRegister = false)
			: base(pRegister)
		{
		}

		public WaterBlock(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public WaterBlock(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public WaterBlock(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public WaterBlock(SimObject pObj) : base(pObj)
		{
		}

		public WaterBlock(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.WaterBlock_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _WaterBlock_create();
         private static _WaterBlock_create _WaterBlock_createFunc;
         internal static IntPtr WaterBlock_create()
         {
         	if (_WaterBlock_createFunc == null)
         	{
         		_WaterBlock_createFunc =
         			(_WaterBlock_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_WaterBlock_create"), typeof(_WaterBlock_create));
         	}
         
         	return  _WaterBlock_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float GridElementSize
         {
         	get { return float.Parse(getFieldValue("GridElementSize")); }
         	set { setFieldValue("GridElementSize", value.ToString()); }
         }
      
         public float GridSize
         {
         	get { return float.Parse(getFieldValue("GridSize")); }
         	set { setFieldValue("GridSize", value.ToString()); }
         }
      
      
      #endregion

	}
}