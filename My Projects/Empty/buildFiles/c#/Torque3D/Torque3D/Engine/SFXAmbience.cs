using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class SFXAmbience : SimDataBlock
	{
		public SFXAmbience(bool pRegister = false)
			: base(pRegister)
		{
		}

		public SFXAmbience(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public SFXAmbience(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public SFXAmbience(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public SFXAmbience(SimObject pObj) : base(pObj)
		{
		}

		public SFXAmbience(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.SFXAmbience_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SFXAmbience_create();
         private static _SFXAmbience_create _SFXAmbience_createFunc;
         internal static IntPtr SFXAmbience_create()
         {
         	if (_SFXAmbience_createFunc == null)
         	{
         		_SFXAmbience_createFunc =
         			(_SFXAmbience_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_SFXAmbience_create"), typeof(_SFXAmbience_create));
         	}
         
         	return  _SFXAmbience_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public SFXEnvironment Environment
         {
         	get { return Sim.FindObject<SFXEnvironment>(getFieldValue("Environment")); }
         	set { setFieldValue("Environment", value.getId().ToString()); }
         }
      
         public SFXTrack SoundTrack
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("SoundTrack")); }
         	set { setFieldValue("SoundTrack", value.getId().ToString()); }
         }
      
         public float RolloffFactor
         {
         	get { return float.Parse(getFieldValue("RolloffFactor")); }
         	set { setFieldValue("RolloffFactor", value.ToString()); }
         }
      
         public float DopplerFactor
         {
         	get { return float.Parse(getFieldValue("DopplerFactor")); }
         	set { setFieldValue("DopplerFactor", value.ToString()); }
         }
      
         public DynamicFieldVector<SFXState> States
         {
         	get { return new DynamicFieldVector<SFXState>(this, "States", 4, val => Sim.FindObject<SFXState>(val), obj => obj.getId().ToString()); }
         }
      
      
      #endregion

	}
}