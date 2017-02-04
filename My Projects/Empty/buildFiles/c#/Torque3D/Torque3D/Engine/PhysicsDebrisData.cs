using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class PhysicsDebrisData : GameBaseData
	{
		public PhysicsDebrisData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public PhysicsDebrisData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public PhysicsDebrisData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public PhysicsDebrisData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public PhysicsDebrisData(SimObject pObj) : base(pObj)
		{
		}

		public PhysicsDebrisData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.PhysicsDebrisData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _preload(IntPtr thisPtr);
         private static _preload _preloadFunc;
         internal static void preload(IntPtr thisPtr)
         {
         	if (_preloadFunc == null)
         	{
         		_preloadFunc =
         			(_preload)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPhysicsDebrisData_preload"), typeof(_preload));
         	}
         
         	 _preloadFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _PhysicsDebrisData_create();
         private static _PhysicsDebrisData_create _PhysicsDebrisData_createFunc;
         internal static IntPtr PhysicsDebrisData_create()
         {
         	if (_PhysicsDebrisData_createFunc == null)
         	{
         		_PhysicsDebrisData_createFunc =
         			(_PhysicsDebrisData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_PhysicsDebrisData_create"), typeof(_PhysicsDebrisData_create));
         	}
         
         	return  _PhysicsDebrisData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void preload()
         {
            InternalUnsafeMethods.preload(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public string ShapeFile
         {
         	get { return getFieldValue("ShapeFile"); }
         	set { setFieldValue("ShapeFile", value); }
         }
      
         public bool CastShadows
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("CastShadows")); }
         	set { setFieldValue("CastShadows", value ? "1" : "0"); }
         }
      
         public float Lifetime
         {
         	get { return float.Parse(getFieldValue("Lifetime")); }
         	set { setFieldValue("Lifetime", value.ToString()); }
         }
      
         public float LifetimeVariance
         {
         	get { return float.Parse(getFieldValue("LifetimeVariance")); }
         	set { setFieldValue("LifetimeVariance", value.ToString()); }
         }
      
         public float Mass
         {
         	get { return float.Parse(getFieldValue("Mass")); }
         	set { setFieldValue("Mass", value.ToString()); }
         }
      
         public float Friction
         {
         	get { return float.Parse(getFieldValue("Friction")); }
         	set { setFieldValue("Friction", value.ToString()); }
         }
      
         public float StaticFriction
         {
         	get { return float.Parse(getFieldValue("StaticFriction")); }
         	set { setFieldValue("StaticFriction", value.ToString()); }
         }
      
         public float Restitution
         {
         	get { return float.Parse(getFieldValue("Restitution")); }
         	set { setFieldValue("Restitution", value.ToString()); }
         }
      
         public float LinearDamping
         {
         	get { return float.Parse(getFieldValue("LinearDamping")); }
         	set { setFieldValue("LinearDamping", value.ToString()); }
         }
      
         public float AngularDamping
         {
         	get { return float.Parse(getFieldValue("AngularDamping")); }
         	set { setFieldValue("AngularDamping", value.ToString()); }
         }
      
         public float LinearSleepThreshold
         {
         	get { return float.Parse(getFieldValue("LinearSleepThreshold")); }
         	set { setFieldValue("LinearSleepThreshold", value.ToString()); }
         }
      
         public float AngularSleepThreshold
         {
         	get { return float.Parse(getFieldValue("AngularSleepThreshold")); }
         	set { setFieldValue("AngularSleepThreshold", value.ToString()); }
         }
      
         public float WaterDampingScale
         {
         	get { return float.Parse(getFieldValue("WaterDampingScale")); }
         	set { setFieldValue("WaterDampingScale", value.ToString()); }
         }
      
         public float BuoyancyDensity
         {
         	get { return float.Parse(getFieldValue("BuoyancyDensity")); }
         	set { setFieldValue("BuoyancyDensity", value.ToString()); }
         }
      
      
      #endregion

	}
}