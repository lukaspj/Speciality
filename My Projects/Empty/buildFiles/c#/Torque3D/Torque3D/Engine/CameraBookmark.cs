using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class CameraBookmark : MissionMarker
	{
		public CameraBookmark(bool pRegister = false)
			: base(pRegister)
		{
		}

		public CameraBookmark(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public CameraBookmark(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public CameraBookmark(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public CameraBookmark(SimObject pObj) : base(pObj)
		{
		}

		public CameraBookmark(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.CameraBookmark_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _CameraBookmark_create();
         private static _CameraBookmark_create _CameraBookmark_createFunc;
         internal static IntPtr CameraBookmark_create()
         {
         	if (_CameraBookmark_createFunc == null)
         	{
         		_CameraBookmark_createFunc =
         			(_CameraBookmark_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CameraBookmark_create"), typeof(_CameraBookmark_create));
         	}
         
         	return  _CameraBookmark_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}