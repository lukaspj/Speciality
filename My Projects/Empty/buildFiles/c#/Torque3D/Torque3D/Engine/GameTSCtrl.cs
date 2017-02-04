using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GameTSCtrl : GuiTSCtrl
	{
		public GameTSCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GameTSCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GameTSCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GameTSCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GameTSCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GameTSCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GameTSCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GameTSCtrl_create();
         private static _GameTSCtrl_create _GameTSCtrl_createFunc;
         internal static IntPtr GameTSCtrl_create()
         {
         	if (_GameTSCtrl_createFunc == null)
         	{
         		_GameTSCtrl_createFunc =
         			(_GameTSCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameTSCtrl_create"), typeof(_GameTSCtrl_create));
         	}
         
         	return  _GameTSCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}