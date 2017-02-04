using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class SFXEmitter : SceneObject
	{
		public SFXEmitter(bool pRegister = false)
			: base(pRegister)
		{
		}

		public SFXEmitter(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public SFXEmitter(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public SFXEmitter(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public SFXEmitter(SimObject pObj) : base(pObj)
		{
		}

		public SFXEmitter(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.SFXEmitter_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _play(IntPtr thisPtr);
         private static _play _playFunc;
         internal static void play(IntPtr thisPtr)
         {
         	if (_playFunc == null)
         	{
         		_playFunc =
         			(_play)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXEmitter_play"), typeof(_play));
         	}
         
         	 _playFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _stop(IntPtr thisPtr);
         private static _stop _stopFunc;
         internal static void stop(IntPtr thisPtr)
         {
         	if (_stopFunc == null)
         	{
         		_stopFunc =
         			(_stop)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXEmitter_stop"), typeof(_stop));
         	}
         
         	 _stopFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getSource(IntPtr thisPtr);
         private static _getSource _getSourceFunc;
         internal static IntPtr getSource(IntPtr thisPtr)
         {
         	if (_getSourceFunc == null)
         	{
         		_getSourceFunc =
         			(_getSource)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXEmitter_getSource"), typeof(_getSource));
         	}
         
         	return  _getSourceFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SFXEmitter_create();
         private static _SFXEmitter_create _SFXEmitter_createFunc;
         internal static IntPtr SFXEmitter_create()
         {
         	if (_SFXEmitter_createFunc == null)
         	{
         		_SFXEmitter_createFunc =
         			(_SFXEmitter_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_SFXEmitter_create"), typeof(_SFXEmitter_create));
         	}
         
         	return  _SFXEmitter_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void play()
         {
            InternalUnsafeMethods.play(ObjectPtr);
         }
      
         public virtual void stop()
         {
            InternalUnsafeMethods.stop(ObjectPtr);
         }
      
         public virtual SFXSource getSource()
         {
            return new SFXSource(InternalUnsafeMethods.getSource(ObjectPtr));
         }
      
      
      #endregion


      #region Properties
      
      
         public SFXTrack Track
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("Track")); }
         	set { setFieldValue("Track", value.getId().ToString()); }
         }
      
         public string FileName
         {
         	get { return getFieldValue("FileName"); }
         	set { setFieldValue("FileName", value); }
         }
      
         public bool PlayOnAdd
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("PlayOnAdd")); }
         	set { setFieldValue("PlayOnAdd", value ? "1" : "0"); }
         }
      
         public bool UseTrackDescriptionOnly
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseTrackDescriptionOnly")); }
         	set { setFieldValue("UseTrackDescriptionOnly", value ? "1" : "0"); }
         }
      
         public bool IsLooping
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsLooping")); }
         	set { setFieldValue("IsLooping", value ? "1" : "0"); }
         }
      
         public bool IsStreaming
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsStreaming")); }
         	set { setFieldValue("IsStreaming", value ? "1" : "0"); }
         }
      
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
      
      
      #endregion

	}
}