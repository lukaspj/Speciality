using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class HTTPObject : TCPObject
	{
		public HTTPObject(bool pRegister = false)
			: base(pRegister)
		{
		}

		public HTTPObject(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public HTTPObject(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public HTTPObject(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public HTTPObject(SimObject pObj) : base(pObj)
		{
		}

		public HTTPObject(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.HTTPObject_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _get(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string Address, [MarshalAs(UnmanagedType.LPWStr)]string requirstURI, [MarshalAs(UnmanagedType.LPWStr)]string query);
         private static _get _getFunc;
         internal static void get(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string Address, [MarshalAs(UnmanagedType.LPWStr)]string requirstURI, [MarshalAs(UnmanagedType.LPWStr)]string query)
         {
         	if (_getFunc == null)
         	{
         		_getFunc =
         			(_get)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnHTTPObject_get"), typeof(_get));
         	}
         
         	 _getFunc(thisPtr, Address, requirstURI, query);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _post(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string Address, [MarshalAs(UnmanagedType.LPWStr)]string requirstURI, [MarshalAs(UnmanagedType.LPWStr)]string query, [MarshalAs(UnmanagedType.LPWStr)]string post);
         private static _post _postFunc;
         internal static void post(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string Address, [MarshalAs(UnmanagedType.LPWStr)]string requirstURI, [MarshalAs(UnmanagedType.LPWStr)]string query, [MarshalAs(UnmanagedType.LPWStr)]string post)
         {
         	if (_postFunc == null)
         	{
         		_postFunc =
         			(_post)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnHTTPObject_post"), typeof(_post));
         	}
         
         	 _postFunc(thisPtr, Address, requirstURI, query, post);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _HTTPObject_create();
         private static _HTTPObject_create _HTTPObject_createFunc;
         internal static IntPtr HTTPObject_create()
         {
         	if (_HTTPObject_createFunc == null)
         	{
         		_HTTPObject_createFunc =
         			(_HTTPObject_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_HTTPObject_create"), typeof(_HTTPObject_create));
         	}
         
         	return  _HTTPObject_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void get(string Address, string requirstURI, string query = "")
         {
            InternalUnsafeMethods.get(ObjectPtr, Address, requirstURI, query);
         }
      
         public virtual void post(string Address, string requirstURI, string query, string post)
         {
            InternalUnsafeMethods.post(ObjectPtr, Address, requirstURI, query, post);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}