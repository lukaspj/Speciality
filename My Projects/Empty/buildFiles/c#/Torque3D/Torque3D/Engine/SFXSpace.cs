using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class SFXSpace : SceneObject
	{
		public SFXSpace(bool pRegister = false)
			: base(pRegister)
		{
		}

		public SFXSpace(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public SFXSpace(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public SFXSpace(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public SFXSpace(SimObject pObj) : base(pObj)
		{
		}

		public SFXSpace(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.SFXSpace_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SFXSpace_create();
         private static _SFXSpace_create _SFXSpace_createFunc;
         internal static IntPtr SFXSpace_create()
         {
         	if (_SFXSpace_createFunc == null)
         	{
         		_SFXSpace_createFunc =
         			(_SFXSpace_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_SFXSpace_create"), typeof(_SFXSpace_create));
         	}
         
         	return  _SFXSpace_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public SFXAmbience SoundAmbience
         {
         	get { return Sim.FindObject<SFXAmbience>(getFieldValue("SoundAmbience")); }
         	set { setFieldValue("SoundAmbience", value.getId().ToString()); }
         }
      
         public string Plane
         {
         	get { return getFieldValue("Plane"); }
         	set { setFieldValue("Plane", value); }
         }
      
         public string Point
         {
         	get { return getFieldValue("Point"); }
         	set { setFieldValue("Point", value); }
         }
      
         public string Edge
         {
         	get { return getFieldValue("Edge"); }
         	set { setFieldValue("Edge", value); }
         }
      
      
      #endregion

	}
}