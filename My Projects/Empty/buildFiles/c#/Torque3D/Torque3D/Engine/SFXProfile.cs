using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class SFXProfile : SFXTrack
	{
		public SFXProfile(bool pRegister = false)
			: base(pRegister)
		{
		}

		public SFXProfile(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public SFXProfile(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public SFXProfile(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public SFXProfile(SimObject pObj) : base(pObj)
		{
		}

		public SFXProfile(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.SFXProfile_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getSoundDuration(IntPtr thisPtr);
         private static _getSoundDuration _getSoundDurationFunc;
         internal static float getSoundDuration(IntPtr thisPtr)
         {
         	if (_getSoundDurationFunc == null)
         	{
         		_getSoundDurationFunc =
         			(_getSoundDuration)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXProfile_getSoundDuration"), typeof(_getSoundDuration));
         	}
         
         	return  _getSoundDurationFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SFXProfile_create();
         private static _SFXProfile_create _SFXProfile_createFunc;
         internal static IntPtr SFXProfile_create()
         {
         	if (_SFXProfile_createFunc == null)
         	{
         		_SFXProfile_createFunc =
         			(_SFXProfile_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_SFXProfile_create"), typeof(_SFXProfile_create));
         	}
         
         	return  _SFXProfile_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual float getSoundDuration()
         {
            return InternalUnsafeMethods.getSoundDuration(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public string FileName
         {
         	get { return getFieldValue("FileName"); }
         	set { setFieldValue("FileName", value); }
         }
      
         public bool Preload
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Preload")); }
         	set { setFieldValue("Preload", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}