using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class SFXTrack : SimDataBlock
	{
		public SFXTrack(bool pRegister = false)
			: base(pRegister)
		{
		}

		public SFXTrack(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public SFXTrack(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public SFXTrack(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public SFXTrack(SimObject pObj) : base(pObj)
		{
		}

		public SFXTrack(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.SFXTrack_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SFXTrack_create();
         private static _SFXTrack_create _SFXTrack_createFunc;
         internal static IntPtr SFXTrack_create()
         {
         	if (_SFXTrack_createFunc == null)
         	{
         		_SFXTrack_createFunc =
         			(_SFXTrack_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_SFXTrack_create"), typeof(_SFXTrack_create));
         	}
         
         	return  _SFXTrack_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public SFXDescription Description
         {
         	get { return Sim.FindObject<SFXDescription>(getFieldValue("Description")); }
         	set { setFieldValue("Description", value.getId().ToString()); }
         }
      
         public DynamicFieldVector<string> Parameters
         {
         	get { return new DynamicFieldVector<string>(this, "Parameters", 8, val => val, obj => obj); }
         }
      
      
      #endregion

	}
}