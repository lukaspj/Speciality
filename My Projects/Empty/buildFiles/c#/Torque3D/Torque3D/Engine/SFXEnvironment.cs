using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class SFXEnvironment : SimDataBlock
	{
		public SFXEnvironment(bool pRegister = false)
			: base(pRegister)
		{
		}

		public SFXEnvironment(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public SFXEnvironment(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public SFXEnvironment(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public SFXEnvironment(SimObject pObj) : base(pObj)
		{
		}

		public SFXEnvironment(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.SFXEnvironment_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SFXEnvironment_create();
         private static _SFXEnvironment_create _SFXEnvironment_createFunc;
         internal static IntPtr SFXEnvironment_create()
         {
         	if (_SFXEnvironment_createFunc == null)
         	{
         		_SFXEnvironment_createFunc =
         			(_SFXEnvironment_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_SFXEnvironment_create"), typeof(_SFXEnvironment_create));
         	}
         
         	return  _SFXEnvironment_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float EnvSize
         {
         	get { return float.Parse(getFieldValue("EnvSize")); }
         	set { setFieldValue("EnvSize", value.ToString()); }
         }
      
         public float EnvDiffusion
         {
         	get { return float.Parse(getFieldValue("EnvDiffusion")); }
         	set { setFieldValue("EnvDiffusion", value.ToString()); }
         }
      
         public int Room
         {
         	get { return int.Parse(getFieldValue("Room")); }
         	set { setFieldValue("Room", value.ToString()); }
         }
      
         public int RoomHF
         {
         	get { return int.Parse(getFieldValue("RoomHF")); }
         	set { setFieldValue("RoomHF", value.ToString()); }
         }
      
         public int RoomLF
         {
         	get { return int.Parse(getFieldValue("RoomLF")); }
         	set { setFieldValue("RoomLF", value.ToString()); }
         }
      
         public float DecayTime
         {
         	get { return float.Parse(getFieldValue("DecayTime")); }
         	set { setFieldValue("DecayTime", value.ToString()); }
         }
      
         public float DecayHFRatio
         {
         	get { return float.Parse(getFieldValue("DecayHFRatio")); }
         	set { setFieldValue("DecayHFRatio", value.ToString()); }
         }
      
         public float DecayLFRatio
         {
         	get { return float.Parse(getFieldValue("DecayLFRatio")); }
         	set { setFieldValue("DecayLFRatio", value.ToString()); }
         }
      
         public int Reflections
         {
         	get { return int.Parse(getFieldValue("Reflections")); }
         	set { setFieldValue("Reflections", value.ToString()); }
         }
      
         public float ReflectionsDelay
         {
         	get { return float.Parse(getFieldValue("ReflectionsDelay")); }
         	set { setFieldValue("ReflectionsDelay", value.ToString()); }
         }
      
         public DynamicFieldVector<float> ReflectionsPan
         {
         	get { return new DynamicFieldVector<float>(this, "ReflectionsPan", 3, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public int Reverb
         {
         	get { return int.Parse(getFieldValue("Reverb")); }
         	set { setFieldValue("Reverb", value.ToString()); }
         }
      
         public float ReverbDelay
         {
         	get { return float.Parse(getFieldValue("ReverbDelay")); }
         	set { setFieldValue("ReverbDelay", value.ToString()); }
         }
      
         public DynamicFieldVector<float> ReverbPan
         {
         	get { return new DynamicFieldVector<float>(this, "ReverbPan", 3, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public float EchoTime
         {
         	get { return float.Parse(getFieldValue("EchoTime")); }
         	set { setFieldValue("EchoTime", value.ToString()); }
         }
      
         public float EchoDepth
         {
         	get { return float.Parse(getFieldValue("EchoDepth")); }
         	set { setFieldValue("EchoDepth", value.ToString()); }
         }
      
         public float ModulationTime
         {
         	get { return float.Parse(getFieldValue("ModulationTime")); }
         	set { setFieldValue("ModulationTime", value.ToString()); }
         }
      
         public float ModulationDepth
         {
         	get { return float.Parse(getFieldValue("ModulationDepth")); }
         	set { setFieldValue("ModulationDepth", value.ToString()); }
         }
      
         public float AirAbsorptionHF
         {
         	get { return float.Parse(getFieldValue("AirAbsorptionHF")); }
         	set { setFieldValue("AirAbsorptionHF", value.ToString()); }
         }
      
         public float HFReference
         {
         	get { return float.Parse(getFieldValue("HFReference")); }
         	set { setFieldValue("HFReference", value.ToString()); }
         }
      
         public float LFReference
         {
         	get { return float.Parse(getFieldValue("LFReference")); }
         	set { setFieldValue("LFReference", value.ToString()); }
         }
      
         public float RoomRolloffFactor
         {
         	get { return float.Parse(getFieldValue("RoomRolloffFactor")); }
         	set { setFieldValue("RoomRolloffFactor", value.ToString()); }
         }
      
         public float Diffusion
         {
         	get { return float.Parse(getFieldValue("Diffusion")); }
         	set { setFieldValue("Diffusion", value.ToString()); }
         }
      
         public float Density
         {
         	get { return float.Parse(getFieldValue("Density")); }
         	set { setFieldValue("Density", value.ToString()); }
         }
      
         public int Flags
         {
         	get { return int.Parse(getFieldValue("Flags")); }
         	set { setFieldValue("Flags", value.ToString()); }
         }
      
      
      #endregion

	}
}