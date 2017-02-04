using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class UndoScriptAction : UndoAction
	{
		public UndoScriptAction(bool pRegister = false)
			: base(pRegister)
		{
		}

		public UndoScriptAction(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public UndoScriptAction(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public UndoScriptAction(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public UndoScriptAction(SimObject pObj) : base(pObj)
		{
		}

		public UndoScriptAction(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.UndoScriptAction_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _UndoScriptAction_create();
         private static _UndoScriptAction_create _UndoScriptAction_createFunc;
         internal static IntPtr UndoScriptAction_create()
         {
         	if (_UndoScriptAction_createFunc == null)
         	{
         		_UndoScriptAction_createFunc =
         			(_UndoScriptAction_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_UndoScriptAction_create"), typeof(_UndoScriptAction_create));
         	}
         
         	return  _UndoScriptAction_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}