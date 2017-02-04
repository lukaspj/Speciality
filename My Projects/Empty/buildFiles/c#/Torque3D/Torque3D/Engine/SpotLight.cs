using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class SpotLight : LightBase
	{
		public SpotLight(bool pRegister = false)
			: base(pRegister)
		{
		}

		public SpotLight(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public SpotLight(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public SpotLight(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public SpotLight(SimObject pObj) : base(pObj)
		{
		}

		public SpotLight(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.SpotLight_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SpotLight_create();
         private static _SpotLight_create _SpotLight_createFunc;
         internal static IntPtr SpotLight_create()
         {
         	if (_SpotLight_createFunc == null)
         	{
         		_SpotLight_createFunc =
         			(_SpotLight_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_SpotLight_create"), typeof(_SpotLight_create));
         	}
         
         	return  _SpotLight_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float Range
         {
         	get { return float.Parse(getFieldValue("Range")); }
         	set { setFieldValue("Range", value.ToString()); }
         }
      
         public float InnerAngle
         {
         	get { return float.Parse(getFieldValue("InnerAngle")); }
         	set { setFieldValue("InnerAngle", value.ToString()); }
         }
      
         public float OuterAngle
         {
         	get { return float.Parse(getFieldValue("OuterAngle")); }
         	set { setFieldValue("OuterAngle", value.ToString()); }
         }
      
      
      #endregion

	}
}