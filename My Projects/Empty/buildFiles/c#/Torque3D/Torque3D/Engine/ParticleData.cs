using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ParticleData : SimDataBlock
	{
		public ParticleData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ParticleData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ParticleData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ParticleData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ParticleData(SimObject pObj) : base(pObj)
		{
		}

		public ParticleData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ParticleData_create();
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
         				"fnParticleData_reload"), typeof(_reload));
         	}
         
         	 _reloadFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ParticleData_create();
         private static _ParticleData_create _ParticleData_createFunc;
         internal static IntPtr ParticleData_create()
         {
         	if (_ParticleData_createFunc == null)
         	{
         		_ParticleData_createFunc =
         			(_ParticleData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ParticleData_create"), typeof(_ParticleData_create));
         	}
         
         	return  _ParticleData_createFunc();
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
      
      
         public float DragCoefficient
         {
         	get { return float.Parse(getFieldValue("DragCoefficient")); }
         	set { setFieldValue("DragCoefficient", value.ToString()); }
         }
      
         public float WindCoefficient
         {
         	get { return float.Parse(getFieldValue("WindCoefficient")); }
         	set { setFieldValue("WindCoefficient", value.ToString()); }
         }
      
         public float GravityCoefficient
         {
         	get { return float.Parse(getFieldValue("GravityCoefficient")); }
         	set { setFieldValue("GravityCoefficient", value.ToString()); }
         }
      
         public float InheritedVelFactor
         {
         	get { return float.Parse(getFieldValue("InheritedVelFactor")); }
         	set { setFieldValue("InheritedVelFactor", value.ToString()); }
         }
      
         public float ConstantAcceleration
         {
         	get { return float.Parse(getFieldValue("ConstantAcceleration")); }
         	set { setFieldValue("ConstantAcceleration", value.ToString()); }
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
      
         public float SpinSpeed
         {
         	get { return float.Parse(getFieldValue("SpinSpeed")); }
         	set { setFieldValue("SpinSpeed", value.ToString()); }
         }
      
         public float SpinRandomMin
         {
         	get { return float.Parse(getFieldValue("SpinRandomMin")); }
         	set { setFieldValue("SpinRandomMin", value.ToString()); }
         }
      
         public float SpinRandomMax
         {
         	get { return float.Parse(getFieldValue("SpinRandomMax")); }
         	set { setFieldValue("SpinRandomMax", value.ToString()); }
         }
      
         public bool UseInvAlpha
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseInvAlpha")); }
         	set { setFieldValue("UseInvAlpha", value ? "1" : "0"); }
         }
      
         public bool AnimateTexture
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AnimateTexture")); }
         	set { setFieldValue("AnimateTexture", value ? "1" : "0"); }
         }
      
         public int FramesPerSec
         {
         	get { return int.Parse(getFieldValue("FramesPerSec")); }
         	set { setFieldValue("FramesPerSec", value.ToString()); }
         }
      
         public DynamicFieldVector<Point2F> TextureCoords
         {
         	get { return new DynamicFieldVector<Point2F>(this, "TextureCoords", 4, val => new Point2F(val), obj => obj.ToString()); }
         }
      
         public Point2I AnimTexTiling
         {
         	get { return new Point2I(getFieldValue("AnimTexTiling")); }
         	set { setFieldValue("AnimTexTiling", value.ToString()); }
         }
      
         public string AnimTexFrames
         {
         	get { return getFieldValue("AnimTexFrames"); }
         	set { setFieldValue("AnimTexFrames", value); }
         }
      
         public string TextureName
         {
         	get { return getFieldValue("TextureName"); }
         	set { setFieldValue("TextureName", value); }
         }
      
         public string AnimTexName
         {
         	get { return getFieldValue("AnimTexName"); }
         	set { setFieldValue("AnimTexName", value); }
         }
      
         public DynamicFieldVector<ColorF> Colors
         {
         	get { return new DynamicFieldVector<ColorF>(this, "Colors", 4, val => new ColorF(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> Sizes
         {
         	get { return new DynamicFieldVector<float>(this, "Sizes", 4, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> Times
         {
         	get { return new DynamicFieldVector<float>(this, "Times", 4, val => float.Parse(val), obj => obj.ToString()); }
         }
      
      
      #endregion

	}
}