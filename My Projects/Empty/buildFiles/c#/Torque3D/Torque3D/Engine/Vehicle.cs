using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class Vehicle : ShapeBase
	{
		public Vehicle(bool pRegister = false)
			: base(pRegister)
		{
		}

		public Vehicle(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public Vehicle(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public Vehicle(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public Vehicle(SimObject pObj) : base(pObj)
		{
		}

		public Vehicle(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Vehicle_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Vehicle_create();
         private static _Vehicle_create _Vehicle_createFunc;
         internal static IntPtr Vehicle_create()
         {
         	if (_Vehicle_createFunc == null)
         	{
         		_Vehicle_createFunc =
         			(_Vehicle_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Vehicle_create"), typeof(_Vehicle_create));
         	}
         
         	return  _Vehicle_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public bool DisableMove
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("DisableMove")); }
         	set { setFieldValue("DisableMove", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}