using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class SFXPlayList : SFXTrack
	{
		public SFXPlayList(bool pRegister = false)
			: base(pRegister)
		{
		}

		public SFXPlayList(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public SFXPlayList(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public SFXPlayList(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public SFXPlayList(SimObject pObj) : base(pObj)
		{
		}

		public SFXPlayList(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.SFXPlayList_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SFXPlayList_create();
         private static _SFXPlayList_create _SFXPlayList_createFunc;
         internal static IntPtr SFXPlayList_create()
         {
         	if (_SFXPlayList_createFunc == null)
         	{
         		_SFXPlayList_createFunc =
         			(_SFXPlayList_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_SFXPlayList_create"), typeof(_SFXPlayList_create));
         	}
         
         	return  _SFXPlayList_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public SFXPlayListRandomMode Random
         {
         	get { return (SFXPlayListRandomMode)Enum.Parse(typeof(SFXPlayListRandomMode), getFieldValue("Random"), true); }
         	set { setFieldValue("Random", value.ToString()); }
         }
      
         public SFXPlayListLoopMode LoopMode
         {
         	get { return (SFXPlayListLoopMode)Enum.Parse(typeof(SFXPlayListLoopMode), getFieldValue("LoopMode"), true); }
         	set { setFieldValue("LoopMode", value.ToString()); }
         }
      
         public int NumSlotsToPlay
         {
         	get { return int.Parse(getFieldValue("NumSlotsToPlay")); }
         	set { setFieldValue("NumSlotsToPlay", value.ToString()); }
         }
      
         public DynamicFieldVector<SFXTrack> Track
         {
         	get { return new DynamicFieldVector<SFXTrack>(this, "Track", 16, val => Sim.FindObject<SFXTrack>(val), obj => obj.getId().ToString()); }
         }
      
         public DynamicFieldVector<SFXPlayListReplayMode> Replay
         {
         	get { return new DynamicFieldVector<SFXPlayListReplayMode>(this, "Replay", 16, val => (SFXPlayListReplayMode)Enum.Parse(typeof(SFXPlayListReplayMode), val, true), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<SFXPlayListTransitionMode> TransitionIn
         {
         	get { return new DynamicFieldVector<SFXPlayListTransitionMode>(this, "TransitionIn", 16, val => (SFXPlayListTransitionMode)Enum.Parse(typeof(SFXPlayListTransitionMode), val, true), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<SFXPlayListTransitionMode> TransitionOut
         {
         	get { return new DynamicFieldVector<SFXPlayListTransitionMode>(this, "TransitionOut", 16, val => (SFXPlayListTransitionMode)Enum.Parse(typeof(SFXPlayListTransitionMode), val, true), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> DelayTimeIn
         {
         	get { return new DynamicFieldVector<float>(this, "DelayTimeIn", 16, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<Point2F> DelayTimeInVariance
         {
         	get { return new DynamicFieldVector<Point2F>(this, "DelayTimeInVariance", 16, val => new Point2F(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> DelayTimeOut
         {
         	get { return new DynamicFieldVector<float>(this, "DelayTimeOut", 16, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<Point2F> DelayTimeOutVariance
         {
         	get { return new DynamicFieldVector<Point2F>(this, "DelayTimeOutVariance", 16, val => new Point2F(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> FadeTimeIn
         {
         	get { return new DynamicFieldVector<float>(this, "FadeTimeIn", 16, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<Point2F> FadeTimeInVariance
         {
         	get { return new DynamicFieldVector<Point2F>(this, "FadeTimeInVariance", 16, val => new Point2F(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> FadeTimeOut
         {
         	get { return new DynamicFieldVector<float>(this, "FadeTimeOut", 16, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<Point2F> FadeTimeOutVariance
         {
         	get { return new DynamicFieldVector<Point2F>(this, "FadeTimeOutVariance", 16, val => new Point2F(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> ReferenceDistance
         {
         	get { return new DynamicFieldVector<float>(this, "ReferenceDistance", 16, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<Point2F> ReferenceDistanceVariance
         {
         	get { return new DynamicFieldVector<Point2F>(this, "ReferenceDistanceVariance", 16, val => new Point2F(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> MaxDistance
         {
         	get { return new DynamicFieldVector<float>(this, "MaxDistance", 16, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<Point2F> MaxDistanceVariance
         {
         	get { return new DynamicFieldVector<Point2F>(this, "MaxDistanceVariance", 16, val => new Point2F(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> VolumeScale
         {
         	get { return new DynamicFieldVector<float>(this, "VolumeScale", 16, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<Point2F> VolumeScaleVariance
         {
         	get { return new DynamicFieldVector<Point2F>(this, "VolumeScaleVariance", 16, val => new Point2F(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> PitchScale
         {
         	get { return new DynamicFieldVector<float>(this, "PitchScale", 16, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<Point2F> PitchScaleVariance
         {
         	get { return new DynamicFieldVector<Point2F>(this, "PitchScaleVariance", 16, val => new Point2F(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<int> RepeatCount
         {
         	get { return new DynamicFieldVector<int>(this, "RepeatCount", 16, val => int.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<SFXState> State
         {
         	get { return new DynamicFieldVector<SFXState>(this, "State", 16, val => Sim.FindObject<SFXState>(val), obj => obj.getId().ToString()); }
         }
      
         public DynamicFieldVector<SFXPlayListStateMode> StateMode
         {
         	get { return new DynamicFieldVector<SFXPlayListStateMode>(this, "StateMode", 16, val => (SFXPlayListStateMode)Enum.Parse(typeof(SFXPlayListStateMode), val, true), obj => obj.ToString()); }
         }
      
         public bool Trace
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Trace")); }
         	set { setFieldValue("Trace", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}