using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class SFXDescription : SimDataBlock
	{
		public SFXDescription(bool pRegister = false)
			: base(pRegister)
		{
		}

		public SFXDescription(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public SFXDescription(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public SFXDescription(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public SFXDescription(SimObject pObj) : base(pObj)
		{
		}

		public SFXDescription(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.SFXDescription_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SFXDescription_create();
         private static _SFXDescription_create _SFXDescription_createFunc;
         internal static IntPtr SFXDescription_create()
         {
         	if (_SFXDescription_createFunc == null)
         	{
         		_SFXDescription_createFunc =
         			(_SFXDescription_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_SFXDescription_create"), typeof(_SFXDescription_create));
         	}
         
         	return  _SFXDescription_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public SFXSource SourceGroup
         {
         	get { return Sim.FindObject<SFXSource>(getFieldValue("SourceGroup")); }
         	set { setFieldValue("SourceGroup", value.getId().ToString()); }
         }
      
         public float Volume
         {
         	get { return float.Parse(getFieldValue("Volume")); }
         	set { setFieldValue("Volume", value.ToString()); }
         }
      
         public float Pitch
         {
         	get { return float.Parse(getFieldValue("Pitch")); }
         	set { setFieldValue("Pitch", value.ToString()); }
         }
      
         public bool IsLooping
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsLooping")); }
         	set { setFieldValue("IsLooping", value ? "1" : "0"); }
         }
      
         public float Priority
         {
         	get { return float.Parse(getFieldValue("Priority")); }
         	set { setFieldValue("Priority", value.ToString()); }
         }
      
         public bool UseHardware
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseHardware")); }
         	set { setFieldValue("UseHardware", value ? "1" : "0"); }
         }
      
         public DynamicFieldVector<string> Parameters
         {
         	get { return new DynamicFieldVector<string>(this, "Parameters", 8, val => val, obj => obj); }
         }
      
         public float FadeInTime
         {
         	get { return float.Parse(getFieldValue("FadeInTime")); }
         	set { setFieldValue("FadeInTime", value.ToString()); }
         }
      
         public float FadeOutTime
         {
         	get { return float.Parse(getFieldValue("FadeOutTime")); }
         	set { setFieldValue("FadeOutTime", value.ToString()); }
         }
      
         public EaseF FadeInEase
         {
         	get { return new EaseF(getFieldValue("FadeInEase")); }
         	set { setFieldValue("FadeInEase", value.ToString()); }
         }
      
         public EaseF FadeOutEase
         {
         	get { return new EaseF(getFieldValue("FadeOutEase")); }
         	set { setFieldValue("FadeOutEase", value.ToString()); }
         }
      
         public bool FadeLoops
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("FadeLoops")); }
         	set { setFieldValue("FadeLoops", value ? "1" : "0"); }
         }
      
         public bool Is3D
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Is3D")); }
         	set { setFieldValue("Is3D", value ? "1" : "0"); }
         }
      
         public float ReferenceDistance
         {
         	get { return float.Parse(getFieldValue("ReferenceDistance")); }
         	set { setFieldValue("ReferenceDistance", value.ToString()); }
         }
      
         public float MaxDistance
         {
         	get { return float.Parse(getFieldValue("MaxDistance")); }
         	set { setFieldValue("MaxDistance", value.ToString()); }
         }
      
         public Point3F ScatterDistance
         {
         	get { return new Point3F(getFieldValue("ScatterDistance")); }
         	set { setFieldValue("ScatterDistance", value.ToString()); }
         }
      
         public int ConeInsideAngle
         {
         	get { return int.Parse(getFieldValue("ConeInsideAngle")); }
         	set { setFieldValue("ConeInsideAngle", value.ToString()); }
         }
      
         public int ConeOutsideAngle
         {
         	get { return int.Parse(getFieldValue("ConeOutsideAngle")); }
         	set { setFieldValue("ConeOutsideAngle", value.ToString()); }
         }
      
         public float ConeOutsideVolume
         {
         	get { return float.Parse(getFieldValue("ConeOutsideVolume")); }
         	set { setFieldValue("ConeOutsideVolume", value.ToString()); }
         }
      
         public float RolloffFactor
         {
         	get { return float.Parse(getFieldValue("RolloffFactor")); }
         	set { setFieldValue("RolloffFactor", value.ToString()); }
         }
      
         public bool IsStreaming
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsStreaming")); }
         	set { setFieldValue("IsStreaming", value ? "1" : "0"); }
         }
      
         public int StreamPacketSize
         {
         	get { return int.Parse(getFieldValue("StreamPacketSize")); }
         	set { setFieldValue("StreamPacketSize", value.ToString()); }
         }
      
         public int StreamReadAhead
         {
         	get { return int.Parse(getFieldValue("StreamReadAhead")); }
         	set { setFieldValue("StreamReadAhead", value.ToString()); }
         }
      
         public bool UseCustomReverb
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseCustomReverb")); }
         	set { setFieldValue("UseCustomReverb", value ? "1" : "0"); }
         }
      
         public int ReverbDirect
         {
         	get { return int.Parse(getFieldValue("ReverbDirect")); }
         	set { setFieldValue("ReverbDirect", value.ToString()); }
         }
      
         public int ReverbDirectHF
         {
         	get { return int.Parse(getFieldValue("ReverbDirectHF")); }
         	set { setFieldValue("ReverbDirectHF", value.ToString()); }
         }
      
         public int ReverbRoom
         {
         	get { return int.Parse(getFieldValue("ReverbRoom")); }
         	set { setFieldValue("ReverbRoom", value.ToString()); }
         }
      
         public int ReverbRoomHF
         {
         	get { return int.Parse(getFieldValue("ReverbRoomHF")); }
         	set { setFieldValue("ReverbRoomHF", value.ToString()); }
         }
      
         public int ReverbObstruction
         {
         	get { return int.Parse(getFieldValue("ReverbObstruction")); }
         	set { setFieldValue("ReverbObstruction", value.ToString()); }
         }
      
         public float ReverbObstructionLFRatio
         {
         	get { return float.Parse(getFieldValue("ReverbObstructionLFRatio")); }
         	set { setFieldValue("ReverbObstructionLFRatio", value.ToString()); }
         }
      
         public int ReverbOcclusion
         {
         	get { return int.Parse(getFieldValue("ReverbOcclusion")); }
         	set { setFieldValue("ReverbOcclusion", value.ToString()); }
         }
      
         public float ReverbOcclusionLFRatio
         {
         	get { return float.Parse(getFieldValue("ReverbOcclusionLFRatio")); }
         	set { setFieldValue("ReverbOcclusionLFRatio", value.ToString()); }
         }
      
         public float ReverbOcclusionRoomRatio
         {
         	get { return float.Parse(getFieldValue("ReverbOcclusionRoomRatio")); }
         	set { setFieldValue("ReverbOcclusionRoomRatio", value.ToString()); }
         }
      
         public float ReverbOcclusionDirectRatio
         {
         	get { return float.Parse(getFieldValue("ReverbOcclusionDirectRatio")); }
         	set { setFieldValue("ReverbOcclusionDirectRatio", value.ToString()); }
         }
      
         public int ReverbExclusion
         {
         	get { return int.Parse(getFieldValue("ReverbExclusion")); }
         	set { setFieldValue("ReverbExclusion", value.ToString()); }
         }
      
         public float ReverbExclusionLFRatio
         {
         	get { return float.Parse(getFieldValue("ReverbExclusionLFRatio")); }
         	set { setFieldValue("ReverbExclusionLFRatio", value.ToString()); }
         }
      
         public int ReverbOutsideVolumeHF
         {
         	get { return int.Parse(getFieldValue("ReverbOutsideVolumeHF")); }
         	set { setFieldValue("ReverbOutsideVolumeHF", value.ToString()); }
         }
      
         public float ReverbDopplerFactor
         {
         	get { return float.Parse(getFieldValue("ReverbDopplerFactor")); }
         	set { setFieldValue("ReverbDopplerFactor", value.ToString()); }
         }
      
         public float ReverbReverbRolloffFactor
         {
         	get { return float.Parse(getFieldValue("ReverbReverbRolloffFactor")); }
         	set { setFieldValue("ReverbReverbRolloffFactor", value.ToString()); }
         }
      
         public float ReverbRoomRolloffFactor
         {
         	get { return float.Parse(getFieldValue("ReverbRoomRolloffFactor")); }
         	set { setFieldValue("ReverbRoomRolloffFactor", value.ToString()); }
         }
      
         public float ReverbAirAbsorptionFactor
         {
         	get { return float.Parse(getFieldValue("ReverbAirAbsorptionFactor")); }
         	set { setFieldValue("ReverbAirAbsorptionFactor", value.ToString()); }
         }
      
         public int ReverbFlags
         {
         	get { return int.Parse(getFieldValue("ReverbFlags")); }
         	set { setFieldValue("ReverbFlags", value.ToString()); }
         }
      
      
      #endregion

	}
}