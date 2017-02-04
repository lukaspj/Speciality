using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class Debris : GameBase
	{
		public Debris(bool pRegister = false)
			: base(pRegister)
		{
		}

		public Debris(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public Debris(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public Debris(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public Debris(SimObject pObj) : base(pObj)
		{
		}

		public Debris(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Debris_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _init(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string inputPosition, [MarshalAs(UnmanagedType.LPWStr)]string inputVelocity);
         private static _init _initFunc;
         internal static bool init(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string inputPosition, [MarshalAs(UnmanagedType.LPWStr)]string inputVelocity)
         {
         	if (_initFunc == null)
         	{
         		_initFunc =
         			(_init)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnDebris_init"), typeof(_init));
         	}
         
         	return  _initFunc(thisPtr, inputPosition, inputVelocity);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Debris_create();
         private static _Debris_create _Debris_createFunc;
         internal static IntPtr Debris_create()
         {
         	if (_Debris_createFunc == null)
         	{
         		_Debris_createFunc =
         			(_Debris_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Debris_create"), typeof(_Debris_create));
         	}
         
         	return  _Debris_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool init(string inputPosition = "1.0 1.0 1.0", string inputVelocity = "1.0 0.0 0.0")
         {
            return InternalUnsafeMethods.init(ObjectPtr, inputPosition, inputVelocity);
         }
      
      
      #endregion


      #region Properties
      
      
         public float Lifetime
         {
         	get { return float.Parse(getFieldValue("Lifetime")); }
         	set { setFieldValue("Lifetime", value.ToString()); }
         }
      
      
      #endregion

	}
}