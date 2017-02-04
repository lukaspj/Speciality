using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ScriptMsgListener : SimObject
	{
		public ScriptMsgListener(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ScriptMsgListener(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ScriptMsgListener(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ScriptMsgListener(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ScriptMsgListener(SimObject pObj) : base(pObj)
		{
		}

		public ScriptMsgListener(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ScriptMsgListener_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ScriptMsgListener_create();
         private static _ScriptMsgListener_create _ScriptMsgListener_createFunc;
         internal static IntPtr ScriptMsgListener_create()
         {
         	if (_ScriptMsgListener_createFunc == null)
         	{
         		_ScriptMsgListener_createFunc =
         			(_ScriptMsgListener_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ScriptMsgListener_create"), typeof(_ScriptMsgListener_create));
         	}
         
         	return  _ScriptMsgListener_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}