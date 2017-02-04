using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ParticleEmitterData : GameBaseData
	{
		public ParticleEmitterData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ParticleEmitterData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ParticleEmitterData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ParticleEmitterData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ParticleEmitterData(SimObject pObj) : base(pObj)
		{
		}

		public ParticleEmitterData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ParticleEmitterData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _reload(IntPtr thisPtr);
         private static _reload _reloadFunc;
         internal static void reload(IntPtr thisPtr)
         {
         	if (_reloadFunc == null)
         	{
         		_reloadFunc =
         			(_reload)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnParticleEmitterData_reload"), typeof(_reload));
         	}
         
         	 _reloadFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ParticleEmitterData_create();
         private static _ParticleEmitterData_create _ParticleEmitterData_createFunc;
         internal static IntPtr ParticleEmitterData_create()
         {
         	if (_ParticleEmitterData_createFunc == null)
         	{
         		_ParticleEmitterData_createFunc =
         			(_ParticleEmitterData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ParticleEmitterData_create"), typeof(_ParticleEmitterData_create));
         	}
         
         	return  _ParticleEmitterData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void reload()
         {
            InternalUnsafeMethods.reload(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public int EjectionPeriodMS
         {
         	get { return int.Parse(getFieldValue("EjectionPeriodMS")); }
         	set { setFieldValue("EjectionPeriodMS", value.ToString()); }
         }
      
         public int PeriodVarianceMS
         {
         	get { return int.Parse(getFieldValue("PeriodVarianceMS")); }
         	set { setFieldValue("PeriodVarianceMS", value.ToString()); }
         }
      
         public float EjectionVelocity
         {
         	get { return float.Parse(getFieldValue("EjectionVelocity")); }
         	set { setFieldValue("EjectionVelocity", value.ToString()); }
         }
      
         public float VelocityVariance
         {
         	get { return float.Parse(getFieldValue("VelocityVariance")); }
         	set { setFieldValue("VelocityVariance", value.ToString()); }
         }
      
         public float EjectionOffset
         {
         	get { return float.Parse(getFieldValue("EjectionOffset")); }
         	set { setFieldValue("EjectionOffset", value.ToString()); }
         }
      
         public float EjectionOffsetVariance
         {
         	get { return float.Parse(getFieldValue("EjectionOffsetVariance")); }
         	set { setFieldValue("EjectionOffsetVariance", value.ToString()); }
         }
      
         public float ThetaMin
         {
         	get { return float.Parse(getFieldValue("ThetaMin")); }
         	set { setFieldValue("ThetaMin", value.ToString()); }
         }
      
         public float ThetaMax
         {
         	get { return float.Parse(getFieldValue("ThetaMax")); }
         	set { setFieldValue("ThetaMax", value.ToString()); }
         }
      
         public float PhiReferenceVel
         {
         	get { return float.Parse(getFieldValue("PhiReferenceVel")); }
         	set { setFieldValue("PhiReferenceVel", value.ToString()); }
         }
      
         public float PhiVariance
         {
         	get { return float.Parse(getFieldValue("PhiVariance")); }
         	set { setFieldValue("PhiVariance", value.ToString()); }
         }
      
         public float SoftnessDistance
         {
         	get { return float.Parse(getFieldValue("SoftnessDistance")); }
         	set { setFieldValue("SoftnessDistance", value.ToString()); }
         }
      
         public float AmbientFactor
         {
         	get { return float.Parse(getFieldValue("AmbientFactor")); }
         	set { setFieldValue("AmbientFactor", value.ToString()); }
         }
      
         public bool OverrideAdvance
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("OverrideAdvance")); }
         	set { setFieldValue("OverrideAdvance", value ? "1" : "0"); }
         }
      
         public bool OrientParticles
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("OrientParticles")); }
         	set { setFieldValue("OrientParticles", value ? "1" : "0"); }
         }
      
         public bool OrientOnVelocity
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("OrientOnVelocity")); }
         	set { setFieldValue("OrientOnVelocity", value ? "1" : "0"); }
         }
      
         public string Particles
         {
         	get { return getFieldValue("Particles"); }
         	set { setFieldValue("Particles", value); }
         }
      
         public int LifetimeMS
         {
         	get { return int.Parse(getFieldValue("LifetimeMS")); }
         	set { setFieldValue("LifetimeMS", value.ToString()); }
         }
      
         public int LifetimeVarianceMS
         {
         	get { return int.Parse(getFieldValue("LifetimeVarianceMS")); }
         	set { setFieldValue("LifetimeVarianceMS", value.ToString()); }
         }
      
         public bool UseEmitterSizes
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseEmitterSizes")); }
         	set { setFieldValue("UseEmitterSizes", value ? "1" : "0"); }
         }
      
         public bool UseEmitterColors
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseEmitterColors")); }
         	set { setFieldValue("UseEmitterColors", value ? "1" : "0"); }
         }
      
         public ParticleBlendStyle BlendStyle
         {
         	get { return (ParticleBlendStyle)Enum.Parse(typeof(ParticleBlendStyle), getFieldValue("BlendStyle"), true); }
         	set { setFieldValue("BlendStyle", value.ToString()); }
         }
      
         public bool SortParticles
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("SortParticles")); }
         	set { setFieldValue("SortParticles", value ? "1" : "0"); }
         }
      
         public bool ReverseOrder
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ReverseOrder")); }
         	set { setFieldValue("ReverseOrder", value ? "1" : "0"); }
         }
      
         public string TextureName
         {
         	get { return getFieldValue("TextureName"); }
         	set { setFieldValue("TextureName", value); }
         }
      
         public bool AlignParticles
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AlignParticles")); }
         	set { setFieldValue("AlignParticles", value ? "1" : "0"); }
         }
      
         public Point3F AlignDirection
         {
         	get { return new Point3F(getFieldValue("AlignDirection")); }
         	set { setFieldValue("AlignDirection", value.ToString()); }
         }
      
         public bool HighResOnly
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("HighResOnly")); }
         	set { setFieldValue("HighResOnly", value ? "1" : "0"); }
         }
      
         public bool RenderReflection
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderReflection")); }
         	set { setFieldValue("RenderReflection", value ? "1" : "0"); }
         }
      
         public bool Glow
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Glow")); }
         	set { setFieldValue("Glow", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}