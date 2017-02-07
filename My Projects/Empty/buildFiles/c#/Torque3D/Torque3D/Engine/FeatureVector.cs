using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class FeatureVector : ShapeBase
	{
      #region Constructors
      public FeatureVector(bool pRegister = false)
			: base(pRegister)
		{
		}

		public FeatureVector(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public FeatureVector(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public FeatureVector(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public FeatureVector(SimObject pObj) : base(pObj)
		{
		}

		public FeatureVector(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

      #endregion

      protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.FeatureVector_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _FeatureVector_create();
         private static _FeatureVector_create _FeatureVector_createFunc;
         internal static IntPtr FeatureVector_create()
         {
         	if (_FeatureVector_createFunc == null)
         	{
         		_FeatureVector_createFunc =
         			(_FeatureVector_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_FeatureVector_create"), typeof(_FeatureVector_create));
         	}
         
         	return  _FeatureVector_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      #endregion


      #region Properties
      
         public int TickCount
         {
         	get { return int.Parse(getFieldValue("TickCount")); }
         	set { setFieldValue("TickCount", value.ToString()); }
         }
      
      
      #endregion

	}
}