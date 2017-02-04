using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class SimpleNetObject : NetObject
	{
		public SimpleNetObject(bool pRegister = false)
			: base(pRegister)
		{
		}

		public SimpleNetObject(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public SimpleNetObject(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public SimpleNetObject(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public SimpleNetObject(SimObject pObj) : base(pObj)
		{
		}

		public SimpleNetObject(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.SimpleNetObject_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMessage(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string msg);
         private static _setMessage _setMessageFunc;
         internal static void setMessage(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string msg)
         {
         	if (_setMessageFunc == null)
         	{
         		_setMessageFunc =
         			(_setMessage)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimpleNetObject_setMessage"), typeof(_setMessage));
         	}
         
         	 _setMessageFunc(thisPtr, msg);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimpleNetObject_create();
         private static _SimpleNetObject_create _SimpleNetObject_createFunc;
         internal static IntPtr SimpleNetObject_create()
         {
         	if (_SimpleNetObject_createFunc == null)
         	{
         		_SimpleNetObject_createFunc =
         			(_SimpleNetObject_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_SimpleNetObject_create"), typeof(_SimpleNetObject_create));
         	}
         
         	return  _SimpleNetObject_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setMessage(string msg)
         {
            InternalUnsafeMethods.setMessage(ObjectPtr, msg);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}