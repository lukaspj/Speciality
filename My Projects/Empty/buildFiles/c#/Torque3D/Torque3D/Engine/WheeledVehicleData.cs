using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class WheeledVehicleData : VehicleData
	{
		public WheeledVehicleData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public WheeledVehicleData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public WheeledVehicleData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public WheeledVehicleData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public WheeledVehicleData(SimObject pObj) : base(pObj)
		{
		}

		public WheeledVehicleData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.WheeledVehicleData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _WheeledVehicleData_create();
         private static _WheeledVehicleData_create _WheeledVehicleData_createFunc;
         internal static IntPtr WheeledVehicleData_create()
         {
         	if (_WheeledVehicleData_createFunc == null)
         	{
         		_WheeledVehicleData_createFunc =
         			(_WheeledVehicleData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_WheeledVehicleData_create"), typeof(_WheeledVehicleData_create));
         	}
         
         	return  _WheeledVehicleData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public SFXTrack JetSound
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("JetSound")); }
         	set { setFieldValue("JetSound", value.getId().ToString()); }
         }
      
         public SFXTrack EngineSound
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("EngineSound")); }
         	set { setFieldValue("EngineSound", value.getId().ToString()); }
         }
      
         public SFXTrack SquealSound
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("SquealSound")); }
         	set { setFieldValue("SquealSound", value.getId().ToString()); }
         }
      
         public SFXTrack WheelImpactSound
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("WheelImpactSound")); }
         	set { setFieldValue("WheelImpactSound", value.getId().ToString()); }
         }
      
         public ParticleEmitterData TireEmitter
         {
         	get { return Sim.FindObject<ParticleEmitterData>(getFieldValue("TireEmitter")); }
         	set { setFieldValue("TireEmitter", value.getId().ToString()); }
         }
      
         public float MaxWheelSpeed
         {
         	get { return float.Parse(getFieldValue("MaxWheelSpeed")); }
         	set { setFieldValue("MaxWheelSpeed", value.ToString()); }
         }
      
         public float EngineTorque
         {
         	get { return float.Parse(getFieldValue("EngineTorque")); }
         	set { setFieldValue("EngineTorque", value.ToString()); }
         }
      
         public float EngineBrake
         {
         	get { return float.Parse(getFieldValue("EngineBrake")); }
         	set { setFieldValue("EngineBrake", value.ToString()); }
         }
      
         public float BrakeTorque
         {
         	get { return float.Parse(getFieldValue("BrakeTorque")); }
         	set { setFieldValue("BrakeTorque", value.ToString()); }
         }
      
      
      #endregion

	}
}