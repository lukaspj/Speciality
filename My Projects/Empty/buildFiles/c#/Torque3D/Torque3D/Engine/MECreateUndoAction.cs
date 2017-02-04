using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class MECreateUndoAction : UndoAction
	{
		public MECreateUndoAction(bool pRegister = false)
			: base(pRegister)
		{
		}

		public MECreateUndoAction(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public MECreateUndoAction(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public MECreateUndoAction(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public MECreateUndoAction(SimObject pObj) : base(pObj)
		{
		}

		public MECreateUndoAction(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.MECreateUndoAction_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addObject(IntPtr thisPtr, IntPtr obj);
         private static _addObject _addObjectFunc;
         internal static void addObject(IntPtr thisPtr, IntPtr obj)
         {
         	if (_addObjectFunc == null)
         	{
         		_addObjectFunc =
         			(_addObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnMECreateUndoAction_addObject"), typeof(_addObject));
         	}
         
         	 _addObjectFunc(thisPtr, obj);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _MECreateUndoAction_create();
         private static _MECreateUndoAction_create _MECreateUndoAction_createFunc;
         internal static IntPtr MECreateUndoAction_create()
         {
         	if (_MECreateUndoAction_createFunc == null)
         	{
         		_MECreateUndoAction_createFunc =
         			(_MECreateUndoAction_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_MECreateUndoAction_create"), typeof(_MECreateUndoAction_create));
         	}
         
         	return  _MECreateUndoAction_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void addObject(SimObject obj)
         {
            InternalUnsafeMethods.addObject(ObjectPtr, obj.ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}