using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class Portal : Zone
	{
		public Portal(bool pRegister = false)
			: base(pRegister)
		{
		}

		public Portal(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public Portal(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public Portal(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public Portal(SimObject pObj) : base(pObj)
		{
		}

		public Portal(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Portal_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isInteriorPortal(IntPtr thisPtr);
         private static _isInteriorPortal _isInteriorPortalFunc;
         internal static bool isInteriorPortal(IntPtr thisPtr)
         {
         	if (_isInteriorPortalFunc == null)
         	{
         		_isInteriorPortalFunc =
         			(_isInteriorPortal)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPortal_isInteriorPortal"), typeof(_isInteriorPortal));
         	}
         
         	return  _isInteriorPortalFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isExteriorPortal(IntPtr thisPtr);
         private static _isExteriorPortal _isExteriorPortalFunc;
         internal static bool isExteriorPortal(IntPtr thisPtr)
         {
         	if (_isExteriorPortalFunc == null)
         	{
         		_isExteriorPortalFunc =
         			(_isExteriorPortal)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPortal_isExteriorPortal"), typeof(_isExteriorPortal));
         	}
         
         	return  _isExteriorPortalFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Portal_create();
         private static _Portal_create _Portal_createFunc;
         internal static IntPtr Portal_create()
         {
         	if (_Portal_createFunc == null)
         	{
         		_Portal_createFunc =
         			(_Portal_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Portal_create"), typeof(_Portal_create));
         	}
         
         	return  _Portal_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool isInteriorPortal()
         {
            return InternalUnsafeMethods.isInteriorPortal(ObjectPtr);
         }
      
         public virtual bool isExteriorPortal()
         {
            return InternalUnsafeMethods.isExteriorPortal(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public bool FrontSidePassable
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("FrontSidePassable")); }
         	set { setFieldValue("FrontSidePassable", value ? "1" : "0"); }
         }
      
         public bool BackSidePassable
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("BackSidePassable")); }
         	set { setFieldValue("BackSidePassable", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}