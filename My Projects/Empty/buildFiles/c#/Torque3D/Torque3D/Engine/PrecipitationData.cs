using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class PrecipitationData : GameBaseData
	{
		public PrecipitationData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public PrecipitationData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public PrecipitationData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public PrecipitationData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public PrecipitationData(SimObject pObj) : base(pObj)
		{
		}

		public PrecipitationData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.PrecipitationData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _PrecipitationData_create();
         private static _PrecipitationData_create _PrecipitationData_createFunc;
         internal static IntPtr PrecipitationData_create()
         {
         	if (_PrecipitationData_createFunc == null)
         	{
         		_PrecipitationData_createFunc =
         			(_PrecipitationData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_PrecipitationData_create"), typeof(_PrecipitationData_create));
         	}
         
         	return  _PrecipitationData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public SFXTrack SoundProfile
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("SoundProfile")); }
         	set { setFieldValue("SoundProfile", value.getId().ToString()); }
         }
      
         public string DropTexture
         {
         	get { return getFieldValue("DropTexture"); }
         	set { setFieldValue("DropTexture", value); }
         }
      
         public string DropShader
         {
         	get { return getFieldValue("DropShader"); }
         	set { setFieldValue("DropShader", value); }
         }
      
         public string SplashTexture
         {
         	get { return getFieldValue("SplashTexture"); }
         	set { setFieldValue("SplashTexture", value); }
         }
      
         public string SplashShader
         {
         	get { return getFieldValue("SplashShader"); }
         	set { setFieldValue("SplashShader", value); }
         }
      
         public int DropsPerSide
         {
         	get { return int.Parse(getFieldValue("DropsPerSide")); }
         	set { setFieldValue("DropsPerSide", value.ToString()); }
         }
      
         public int SplashesPerSide
         {
         	get { return int.Parse(getFieldValue("SplashesPerSide")); }
         	set { setFieldValue("SplashesPerSide", value.ToString()); }
         }
      
      
      #endregion

	}
}