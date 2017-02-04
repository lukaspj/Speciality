using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class AITurretShapeData : TurretShapeData
	{
		public AITurretShapeData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public AITurretShapeData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public AITurretShapeData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public AITurretShapeData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public AITurretShapeData(SimObject pObj) : base(pObj)
		{
		}

		public AITurretShapeData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.AITurretShapeData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AITurretShapeData_create();
         private static _AITurretShapeData_create _AITurretShapeData_createFunc;
         internal static IntPtr AITurretShapeData_create()
         {
         	if (_AITurretShapeData_createFunc == null)
         	{
         		_AITurretShapeData_createFunc =
         			(_AITurretShapeData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_AITurretShapeData_create"), typeof(_AITurretShapeData_create));
         	}
         
         	return  _AITurretShapeData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float MaxScanHeading
         {
         	get { return float.Parse(getFieldValue("MaxScanHeading")); }
         	set { setFieldValue("MaxScanHeading", value.ToString()); }
         }
      
         public float MaxScanPitch
         {
         	get { return float.Parse(getFieldValue("MaxScanPitch")); }
         	set { setFieldValue("MaxScanPitch", value.ToString()); }
         }
      
         public float MaxScanDistance
         {
         	get { return float.Parse(getFieldValue("MaxScanDistance")); }
         	set { setFieldValue("MaxScanDistance", value.ToString()); }
         }
      
         public int ScanTickFrequency
         {
         	get { return int.Parse(getFieldValue("ScanTickFrequency")); }
         	set { setFieldValue("ScanTickFrequency", value.ToString()); }
         }
      
         public int ScanTickFrequencyVariance
         {
         	get { return int.Parse(getFieldValue("ScanTickFrequencyVariance")); }
         	set { setFieldValue("ScanTickFrequencyVariance", value.ToString()); }
         }
      
         public float TrackLostTargetTime
         {
         	get { return float.Parse(getFieldValue("TrackLostTargetTime")); }
         	set { setFieldValue("TrackLostTargetTime", value.ToString()); }
         }
      
         public float MaxWeaponRange
         {
         	get { return float.Parse(getFieldValue("MaxWeaponRange")); }
         	set { setFieldValue("MaxWeaponRange", value.ToString()); }
         }
      
         public float WeaponLeadVelocity
         {
         	get { return float.Parse(getFieldValue("WeaponLeadVelocity")); }
         	set { setFieldValue("WeaponLeadVelocity", value.ToString()); }
         }
      
         public DynamicFieldVector<string> StateName
         {
         	get { return new DynamicFieldVector<string>(this, "StateName", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionOnAtRest
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionOnAtRest", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionOnNotAtRest
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionOnNotAtRest", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionOnTarget
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionOnTarget", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionOnNoTarget
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionOnNoTarget", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionOnActivated
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionOnActivated", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionOnDeactivated
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionOnDeactivated", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<string> StateTransitionOnTimeout
         {
         	get { return new DynamicFieldVector<string>(this, "StateTransitionOnTimeout", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<float> StateTimeoutValue
         {
         	get { return new DynamicFieldVector<float>(this, "StateTimeoutValue", 31, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<bool> StateWaitForTimeout
         {
         	get { return new DynamicFieldVector<bool>(this, "StateWaitForTimeout", 31, val => GenericMarshal.StringToBool(val), obj => obj ? "1" : "0"); }
         }
      
         public DynamicFieldVector<bool> StateFire
         {
         	get { return new DynamicFieldVector<bool>(this, "StateFire", 31, val => GenericMarshal.StringToBool(val), obj => obj ? "1" : "0"); }
         }
      
         public DynamicFieldVector<bool> StateScan
         {
         	get { return new DynamicFieldVector<bool>(this, "StateScan", 31, val => GenericMarshal.StringToBool(val), obj => obj ? "1" : "0"); }
         }
      
         public DynamicFieldVector<bool> StateDirection
         {
         	get { return new DynamicFieldVector<bool>(this, "StateDirection", 31, val => GenericMarshal.StringToBool(val), obj => obj ? "1" : "0"); }
         }
      
         public DynamicFieldVector<string> StateSequence
         {
         	get { return new DynamicFieldVector<string>(this, "StateSequence", 31, val => val, obj => obj); }
         }
      
         public DynamicFieldVector<bool> StateScaleAnimation
         {
         	get { return new DynamicFieldVector<bool>(this, "StateScaleAnimation", 31, val => GenericMarshal.StringToBool(val), obj => obj ? "1" : "0"); }
         }
      
         public DynamicFieldVector<string> StateScript
         {
         	get { return new DynamicFieldVector<string>(this, "StateScript", 31, val => val, obj => obj); }
         }
      
      
      #endregion

	}
}