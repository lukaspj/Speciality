using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class LightningData : GameBaseData
	{
		public LightningData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public LightningData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public LightningData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public LightningData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public LightningData(SimObject pObj) : base(pObj)
		{
		}

		public LightningData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.LightningData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _LightningData_create();
         private static _LightningData_create _LightningData_createFunc;
         internal static IntPtr LightningData_create()
         {
         	if (_LightningData_createFunc == null)
         	{
         		_LightningData_createFunc =
         			(_LightningData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_LightningData_create"), typeof(_LightningData_create));
         	}
         
         	return  _LightningData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public SFXTrack StrikeSound
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("StrikeSound")); }
         	set { setFieldValue("StrikeSound", value.getId().ToString()); }
         }
      
         public DynamicFieldVector<SFXTrack> ThunderSounds
         {
         	get { return new DynamicFieldVector<SFXTrack>(this, "ThunderSounds", 8, val => Sim.FindObject<SFXTrack>(val), obj => obj.getId().ToString()); }
         }
      
         public DynamicFieldVector<string> StrikeTextures
         {
         	get { return new DynamicFieldVector<string>(this, "StrikeTextures", 8, val => val, obj => obj); }
         }
      
      
      #endregion

	}
}