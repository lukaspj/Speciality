using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class FlyingVehicleData : VehicleData
	{
		public FlyingVehicleData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public FlyingVehicleData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public FlyingVehicleData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public FlyingVehicleData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public FlyingVehicleData(SimObject pObj) : base(pObj)
		{
		}

		public FlyingVehicleData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.FlyingVehicleData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _FlyingVehicleData_create();
         private static _FlyingVehicleData_create _FlyingVehicleData_createFunc;
         internal static IntPtr FlyingVehicleData_create()
         {
         	if (_FlyingVehicleData_createFunc == null)
         	{
         		_FlyingVehicleData_createFunc =
         			(_FlyingVehicleData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_FlyingVehicleData_create"), typeof(_FlyingVehicleData_create));
         	}
         
         	return  _FlyingVehicleData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public SFXProfile JetSound
         {
         	get { return Sim.FindObject<SFXProfile>(getFieldValue("JetSound")); }
         	set { setFieldValue("JetSound", value.getId().ToString()); }
         }
      
         public SFXProfile EngineSound
         {
         	get { return Sim.FindObject<SFXProfile>(getFieldValue("EngineSound")); }
         	set { setFieldValue("EngineSound", value.getId().ToString()); }
         }
      
         public float ManeuveringForce
         {
         	get { return float.Parse(getFieldValue("ManeuveringForce")); }
         	set { setFieldValue("ManeuveringForce", value.ToString()); }
         }
      
         public float HorizontalSurfaceForce
         {
         	get { return float.Parse(getFieldValue("HorizontalSurfaceForce")); }
         	set { setFieldValue("HorizontalSurfaceForce", value.ToString()); }
         }
      
         public float VerticalSurfaceForce
         {
         	get { return float.Parse(getFieldValue("VerticalSurfaceForce")); }
         	set { setFieldValue("VerticalSurfaceForce", value.ToString()); }
         }
      
         public float VertThrustMultiple
         {
         	get { return float.Parse(getFieldValue("VertThrustMultiple")); }
         	set { setFieldValue("VertThrustMultiple", value.ToString()); }
         }
      
         public float SteeringForce
         {
         	get { return float.Parse(getFieldValue("SteeringForce")); }
         	set { setFieldValue("SteeringForce", value.ToString()); }
         }
      
         public float SteeringRollForce
         {
         	get { return float.Parse(getFieldValue("SteeringRollForce")); }
         	set { setFieldValue("SteeringRollForce", value.ToString()); }
         }
      
         public float RollForce
         {
         	get { return float.Parse(getFieldValue("RollForce")); }
         	set { setFieldValue("RollForce", value.ToString()); }
         }
      
         public float RotationalDrag
         {
         	get { return float.Parse(getFieldValue("RotationalDrag")); }
         	set { setFieldValue("RotationalDrag", value.ToString()); }
         }
      
         public float MaxAutoSpeed
         {
         	get { return float.Parse(getFieldValue("MaxAutoSpeed")); }
         	set { setFieldValue("MaxAutoSpeed", value.ToString()); }
         }
      
         public float AutoInputDamping
         {
         	get { return float.Parse(getFieldValue("AutoInputDamping")); }
         	set { setFieldValue("AutoInputDamping", value.ToString()); }
         }
      
         public float AutoLinearForce
         {
         	get { return float.Parse(getFieldValue("AutoLinearForce")); }
         	set { setFieldValue("AutoLinearForce", value.ToString()); }
         }
      
         public float AutoAngularForce
         {
         	get { return float.Parse(getFieldValue("AutoAngularForce")); }
         	set { setFieldValue("AutoAngularForce", value.ToString()); }
         }
      
         public float HoverHeight
         {
         	get { return float.Parse(getFieldValue("HoverHeight")); }
         	set { setFieldValue("HoverHeight", value.ToString()); }
         }
      
         public float CreateHoverHeight
         {
         	get { return float.Parse(getFieldValue("CreateHoverHeight")); }
         	set { setFieldValue("CreateHoverHeight", value.ToString()); }
         }
      
         public ParticleEmitterData ForwardJetEmitter
         {
         	get { return Sim.FindObject<ParticleEmitterData>(getFieldValue("ForwardJetEmitter")); }
         	set { setFieldValue("ForwardJetEmitter", value.getId().ToString()); }
         }
      
         public ParticleEmitterData BackwardJetEmitter
         {
         	get { return Sim.FindObject<ParticleEmitterData>(getFieldValue("BackwardJetEmitter")); }
         	set { setFieldValue("BackwardJetEmitter", value.getId().ToString()); }
         }
      
         public ParticleEmitterData DownJetEmitter
         {
         	get { return Sim.FindObject<ParticleEmitterData>(getFieldValue("DownJetEmitter")); }
         	set { setFieldValue("DownJetEmitter", value.getId().ToString()); }
         }
      
         public ParticleEmitterData TrailEmitter
         {
         	get { return Sim.FindObject<ParticleEmitterData>(getFieldValue("TrailEmitter")); }
         	set { setFieldValue("TrailEmitter", value.getId().ToString()); }
         }
      
         public float MinTrailSpeed
         {
         	get { return float.Parse(getFieldValue("MinTrailSpeed")); }
         	set { setFieldValue("MinTrailSpeed", value.ToString()); }
         }
      
      
      #endregion

	}
}