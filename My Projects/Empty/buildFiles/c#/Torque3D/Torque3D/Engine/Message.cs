using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class Message : SimObject
	{
		public Message(bool pRegister = false)
			: base(pRegister)
		{
		}

		public Message(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public Message(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public Message(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public Message(SimObject pObj) : base(pObj)
		{
		}

		public Message(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Message_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getType(IntPtr thisPtr);
         private static _getType _getTypeFunc;
         internal static IntPtr getType(IntPtr thisPtr)
         {
         	if (_getTypeFunc == null)
         	{
         		_getTypeFunc =
         			(_getType)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnMessage_getType"), typeof(_getType));
         	}
         
         	return  _getTypeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addReference(IntPtr thisPtr);
         private static _addReference _addReferenceFunc;
         internal static void addReference(IntPtr thisPtr)
         {
         	if (_addReferenceFunc == null)
         	{
         		_addReferenceFunc =
         			(_addReference)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnMessage_addReference"), typeof(_addReference));
         	}
         
         	 _addReferenceFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _freeReference(IntPtr thisPtr);
         private static _freeReference _freeReferenceFunc;
         internal static void freeReference(IntPtr thisPtr)
         {
         	if (_freeReferenceFunc == null)
         	{
         		_freeReferenceFunc =
         			(_freeReference)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnMessage_freeReference"), typeof(_freeReference));
         	}
         
         	 _freeReferenceFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Message_create();
         private static _Message_create _Message_createFunc;
         internal static IntPtr Message_create()
         {
         	if (_Message_createFunc == null)
         	{
         		_Message_createFunc =
         			(_Message_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Message_create"), typeof(_Message_create));
         	}
         
         	return  _Message_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual string getType()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getType(ObjectPtr));
         }
      
         public virtual void addReference()
         {
            InternalUnsafeMethods.addReference(ObjectPtr);
         }
      
         public virtual void freeReference()
         {
            InternalUnsafeMethods.freeReference(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}