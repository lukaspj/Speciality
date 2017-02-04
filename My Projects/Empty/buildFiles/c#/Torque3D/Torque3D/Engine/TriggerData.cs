using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class TriggerData : GameBaseData
	{
		public TriggerData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public TriggerData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public TriggerData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public TriggerData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public TriggerData(SimObject pObj) : base(pObj)
		{
		}

		public TriggerData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.TriggerData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _TriggerData_create();
         private static _TriggerData_create _TriggerData_createFunc;
         internal static IntPtr TriggerData_create()
         {
         	if (_TriggerData_createFunc == null)
         	{
         		_TriggerData_createFunc =
         			(_TriggerData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_TriggerData_create"), typeof(_TriggerData_create));
         	}
         
         	return  _TriggerData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public int TickPeriodMS
         {
         	get { return int.Parse(getFieldValue("TickPeriodMS")); }
         	set { setFieldValue("TickPeriodMS", value.ToString()); }
         }
      
         public bool ClientSide
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ClientSide")); }
         	set { setFieldValue("ClientSide", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}