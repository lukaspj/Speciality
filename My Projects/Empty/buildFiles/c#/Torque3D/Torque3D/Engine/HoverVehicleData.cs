using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class HoverVehicleData : VehicleData
	{
		public HoverVehicleData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public HoverVehicleData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public HoverVehicleData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public HoverVehicleData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public HoverVehicleData(SimObject pObj) : base(pObj)
		{
		}

		public HoverVehicleData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.HoverVehicleData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _HoverVehicleData_create();
         private static _HoverVehicleData_create _HoverVehicleData_createFunc;
         internal static IntPtr HoverVehicleData_create()
         {
         	if (_HoverVehicleData_createFunc == null)
         	{
         		_HoverVehicleData_createFunc =
         			(_HoverVehicleData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_HoverVehicleData_create"), typeof(_HoverVehicleData_create));
         	}
         
         	return  _HoverVehicleData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float DragForce
         {
         	get { return float.Parse(getFieldValue("DragForce")); }
         	set { setFieldValue("DragForce", value.ToString()); }
         }
      
         public float VertFactor
         {
         	get { return float.Parse(getFieldValue("VertFactor")); }
         	set { setFieldValue("VertFactor", value.ToString()); }
         }
      
         public float FloatingThrustFactor
         {
         	get { return float.Parse(getFieldValue("FloatingThrustFactor")); }
         	set { setFieldValue("FloatingThrustFactor", value.ToString()); }
         }
      
         public float MainThrustForce
         {
         	get { return float.Parse(getFieldValue("MainThrustForce")); }
         	set { setFieldValue("MainThrustForce", value.ToString()); }
         }
      
         public float ReverseThrustForce
         {
         	get { return float.Parse(getFieldValue("ReverseThrustForce")); }
         	set { setFieldValue("ReverseThrustForce", value.ToString()); }
         }
      
         public float StrafeThrustForce
         {
         	get { return float.Parse(getFieldValue("StrafeThrustForce")); }
         	set { setFieldValue("StrafeThrustForce", value.ToString()); }
         }
      
         public float TurboFactor
         {
         	get { return float.Parse(getFieldValue("TurboFactor")); }
         	set { setFieldValue("TurboFactor", value.ToString()); }
         }
      
         public float StabLenMin
         {
         	get { return float.Parse(getFieldValue("StabLenMin")); }
         	set { setFieldValue("StabLenMin", value.ToString()); }
         }
      
         public float StabLenMax
         {
         	get { return float.Parse(getFieldValue("StabLenMax")); }
         	set { setFieldValue("StabLenMax", value.ToString()); }
         }
      
         public float StabSpringConstant
         {
         	get { return float.Parse(getFieldValue("StabSpringConstant")); }
         	set { setFieldValue("StabSpringConstant", value.ToString()); }
         }
      
         public float StabDampingConstant
         {
         	get { return float.Parse(getFieldValue("StabDampingConstant")); }
         	set { setFieldValue("StabDampingConstant", value.ToString()); }
         }
      
         public float GyroDrag
         {
         	get { return float.Parse(getFieldValue("GyroDrag")); }
         	set { setFieldValue("GyroDrag", value.ToString()); }
         }
      
         public float NormalForce
         {
         	get { return float.Parse(getFieldValue("NormalForce")); }
         	set { setFieldValue("NormalForce", value.ToString()); }
         }
      
         public float RestorativeForce
         {
         	get { return float.Parse(getFieldValue("RestorativeForce")); }
         	set { setFieldValue("RestorativeForce", value.ToString()); }
         }
      
         public float SteeringForce
         {
         	get { return float.Parse(getFieldValue("SteeringForce")); }
         	set { setFieldValue("SteeringForce", value.ToString()); }
         }
      
         public float RollForce
         {
         	get { return float.Parse(getFieldValue("RollForce")); }
         	set { setFieldValue("RollForce", value.ToString()); }
         }
      
         public float PitchForce
         {
         	get { return float.Parse(getFieldValue("PitchForce")); }
         	set { setFieldValue("PitchForce", value.ToString()); }
         }
      
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
      
         public SFXProfile FloatSound
         {
         	get { return Sim.FindObject<SFXProfile>(getFieldValue("FloatSound")); }
         	set { setFieldValue("FloatSound", value.getId().ToString()); }
         }
      
         public ParticleEmitterData DustTrailEmitter
         {
         	get { return Sim.FindObject<ParticleEmitterData>(getFieldValue("DustTrailEmitter")); }
         	set { setFieldValue("DustTrailEmitter", value.getId().ToString()); }
         }
      
         public Point3F DustTrailOffset
         {
         	get { return new Point3F(getFieldValue("DustTrailOffset")); }
         	set { setFieldValue("DustTrailOffset", value.ToString()); }
         }
      
         public float TriggerTrailHeight
         {
         	get { return float.Parse(getFieldValue("TriggerTrailHeight")); }
         	set { setFieldValue("TriggerTrailHeight", value.ToString()); }
         }
      
         public float DustTrailFreqMod
         {
         	get { return float.Parse(getFieldValue("DustTrailFreqMod")); }
         	set { setFieldValue("DustTrailFreqMod", value.ToString()); }
         }
      
         public float FloatingGravMag
         {
         	get { return float.Parse(getFieldValue("FloatingGravMag")); }
         	set { setFieldValue("FloatingGravMag", value.ToString()); }
         }
      
         public float BrakingForce
         {
         	get { return float.Parse(getFieldValue("BrakingForce")); }
         	set { setFieldValue("BrakingForce", value.ToString()); }
         }
      
         public float BrakingActivationSpeed
         {
         	get { return float.Parse(getFieldValue("BrakingActivationSpeed")); }
         	set { setFieldValue("BrakingActivationSpeed", value.ToString()); }
         }
      
         public ParticleEmitterData ForwardJetEmitter
         {
         	get { return Sim.FindObject<ParticleEmitterData>(getFieldValue("ForwardJetEmitter")); }
         	set { setFieldValue("ForwardJetEmitter", value.getId().ToString()); }
         }
      
      
      #endregion

	}
}