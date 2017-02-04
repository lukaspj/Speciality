using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class Trigger : GameBase
	{
		public Trigger(bool pRegister = false)
			: base(pRegister)
		{
		}

		public Trigger(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public Trigger(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public Trigger(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public Trigger(SimObject pObj) : base(pObj)
		{
		}

		public Trigger(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Trigger_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getNumObjects(IntPtr thisPtr);
         private static _getNumObjects _getNumObjectsFunc;
         internal static int getNumObjects(IntPtr thisPtr)
         {
         	if (_getNumObjectsFunc == null)
         	{
         		_getNumObjectsFunc =
         			(_getNumObjects)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTrigger_getNumObjects"), typeof(_getNumObjects));
         	}
         
         	return  _getNumObjectsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getObject(IntPtr thisPtr, int index);
         private static _getObject _getObjectFunc;
         internal static int getObject(IntPtr thisPtr, int index)
         {
         	if (_getObjectFunc == null)
         	{
         		_getObjectFunc =
         			(_getObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTrigger_getObject"), typeof(_getObject));
         	}
         
         	return  _getObjectFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Trigger_create();
         private static _Trigger_create _Trigger_createFunc;
         internal static IntPtr Trigger_create()
         {
         	if (_Trigger_createFunc == null)
         	{
         		_Trigger_createFunc =
         			(_Trigger_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Trigger_create"), typeof(_Trigger_create));
         	}
         
         	return  _Trigger_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual int getNumObjects()
         {
            return InternalUnsafeMethods.getNumObjects(ObjectPtr);
         }
      
         public virtual int getObject(int index)
         {
            return InternalUnsafeMethods.getObject(ObjectPtr, index);
         }
      
      
      #endregion


      #region Properties
      
      
         public string Polyhedron
         {
         	get { return getFieldValue("Polyhedron"); }
         	set { setFieldValue("Polyhedron", value); }
         }
      
         public string EnterCommand
         {
         	get { return getFieldValue("EnterCommand"); }
         	set { setFieldValue("EnterCommand", value); }
         }
      
         public string LeaveCommand
         {
         	get { return getFieldValue("LeaveCommand"); }
         	set { setFieldValue("LeaveCommand", value); }
         }
      
         public string TickCommand
         {
         	get { return getFieldValue("TickCommand"); }
         	set { setFieldValue("TickCommand", value); }
         }
      
      
      #endregion

	}
}