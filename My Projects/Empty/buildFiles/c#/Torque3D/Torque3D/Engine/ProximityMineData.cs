using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ProximityMineData : ItemData
	{
		public ProximityMineData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ProximityMineData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ProximityMineData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ProximityMineData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ProximityMineData(SimObject pObj) : base(pObj)
		{
		}

		public ProximityMineData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ProximityMineData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ProximityMineData_create();
         private static _ProximityMineData_create _ProximityMineData_createFunc;
         internal static IntPtr ProximityMineData_create()
         {
         	if (_ProximityMineData_createFunc == null)
         	{
         		_ProximityMineData_createFunc =
         			(_ProximityMineData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ProximityMineData_create"), typeof(_ProximityMineData_create));
         	}
         
         	return  _ProximityMineData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float ArmingDelay
         {
         	get { return float.Parse(getFieldValue("ArmingDelay")); }
         	set { setFieldValue("ArmingDelay", value.ToString()); }
         }
      
         public SFXTrack ArmingSound
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("ArmingSound")); }
         	set { setFieldValue("ArmingSound", value.getId().ToString()); }
         }
      
         public float AutoTriggerDelay
         {
         	get { return float.Parse(getFieldValue("AutoTriggerDelay")); }
         	set { setFieldValue("AutoTriggerDelay", value.ToString()); }
         }
      
         public bool TriggerOnOwner
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("TriggerOnOwner")); }
         	set { setFieldValue("TriggerOnOwner", value ? "1" : "0"); }
         }
      
         public float TriggerRadius
         {
         	get { return float.Parse(getFieldValue("TriggerRadius")); }
         	set { setFieldValue("TriggerRadius", value.ToString()); }
         }
      
         public float TriggerSpeed
         {
         	get { return float.Parse(getFieldValue("TriggerSpeed")); }
         	set { setFieldValue("TriggerSpeed", value.ToString()); }
         }
      
         public float TriggerDelay
         {
         	get { return float.Parse(getFieldValue("TriggerDelay")); }
         	set { setFieldValue("TriggerDelay", value.ToString()); }
         }
      
         public SFXTrack TriggerSound
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("TriggerSound")); }
         	set { setFieldValue("TriggerSound", value.getId().ToString()); }
         }
      
         public float ExplosionOffset
         {
         	get { return float.Parse(getFieldValue("ExplosionOffset")); }
         	set { setFieldValue("ExplosionOffset", value.ToString()); }
         }
      
      
      #endregion

	}
}