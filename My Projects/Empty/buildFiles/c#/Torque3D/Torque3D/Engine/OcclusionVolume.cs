using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class OcclusionVolume : SceneObject
	{
		public OcclusionVolume(bool pRegister = false)
			: base(pRegister)
		{
		}

		public OcclusionVolume(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public OcclusionVolume(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public OcclusionVolume(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public OcclusionVolume(SimObject pObj) : base(pObj)
		{
		}

		public OcclusionVolume(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.OcclusionVolume_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _OcclusionVolume_create();
         private static _OcclusionVolume_create _OcclusionVolume_createFunc;
         internal static IntPtr OcclusionVolume_create()
         {
         	if (_OcclusionVolume_createFunc == null)
         	{
         		_OcclusionVolume_createFunc =
         			(_OcclusionVolume_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_OcclusionVolume_create"), typeof(_OcclusionVolume_create));
         	}
         
         	return  _OcclusionVolume_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
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