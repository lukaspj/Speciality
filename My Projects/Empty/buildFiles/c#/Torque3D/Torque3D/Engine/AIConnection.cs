using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class AIConnection : GameConnection
	{
		public AIConnection(bool pRegister = false)
			: base(pRegister)
		{
		}

		public AIConnection(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public AIConnection(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public AIConnection(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public AIConnection(SimObject pObj) : base(pObj)
		{
		}

		public AIConnection(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.AIConnection_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMove(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string field, float value);
         private static _setMove _setMoveFunc;
         internal static void setMove(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string field, float value)
         {
         	if (_setMoveFunc == null)
         	{
         		_setMoveFunc =
         			(_setMove)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIConnection_setMove"), typeof(_setMove));
         	}
         
         	 _setMoveFunc(thisPtr, field, value);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getMove(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string field);
         private static _getMove _getMoveFunc;
         internal static float getMove(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string field)
         {
         	if (_getMoveFunc == null)
         	{
         		_getMoveFunc =
         			(_getMove)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIConnection_getMove"), typeof(_getMove));
         	}
         
         	return  _getMoveFunc(thisPtr, field);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setFreeLook(IntPtr thisPtr, bool isFreeLook);
         private static _setFreeLook _setFreeLookFunc;
         internal static void setFreeLook(IntPtr thisPtr, bool isFreeLook)
         {
         	if (_setFreeLookFunc == null)
         	{
         		_setFreeLookFunc =
         			(_setFreeLook)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIConnection_setFreeLook"), typeof(_setFreeLook));
         	}
         
         	 _setFreeLookFunc(thisPtr, isFreeLook);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getFreeLook(IntPtr thisPtr);
         private static _getFreeLook _getFreeLookFunc;
         internal static bool getFreeLook(IntPtr thisPtr)
         {
         	if (_getFreeLookFunc == null)
         	{
         		_getFreeLookFunc =
         			(_getFreeLook)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIConnection_getFreeLook"), typeof(_getFreeLook));
         	}
         
         	return  _getFreeLookFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setTrigger(IntPtr thisPtr, int idx, bool set);
         private static _setTrigger _setTriggerFunc;
         internal static void setTrigger(IntPtr thisPtr, int idx, bool set)
         {
         	if (_setTriggerFunc == null)
         	{
         		_setTriggerFunc =
         			(_setTrigger)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIConnection_setTrigger"), typeof(_setTrigger));
         	}
         
         	 _setTriggerFunc(thisPtr, idx, set);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getTrigger(IntPtr thisPtr, int idx);
         private static _getTrigger _getTriggerFunc;
         internal static bool getTrigger(IntPtr thisPtr, int idx)
         {
         	if (_getTriggerFunc == null)
         	{
         		_getTriggerFunc =
         			(_getTrigger)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIConnection_getTrigger"), typeof(_getTrigger));
         	}
         
         	return  _getTriggerFunc(thisPtr, idx);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getAddress(IntPtr thisPtr);
         private static _getAddress _getAddressFunc;
         internal static IntPtr getAddress(IntPtr thisPtr)
         {
         	if (_getAddressFunc == null)
         	{
         		_getAddressFunc =
         			(_getAddress)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnAIConnection_getAddress"), typeof(_getAddress));
         	}
         
         	return  _getAddressFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _AIConnection_create();
         private static _AIConnection_create _AIConnection_createFunc;
         internal static IntPtr AIConnection_create()
         {
         	if (_AIConnection_createFunc == null)
         	{
         		_AIConnection_createFunc =
         			(_AIConnection_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_AIConnection_create"), typeof(_AIConnection_create));
         	}
         
         	return  _AIConnection_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setMove(string field, float value)
         {
            InternalUnsafeMethods.setMove(ObjectPtr, field, value);
         }
      
         public virtual float getMove(string field)
         {
            return InternalUnsafeMethods.getMove(ObjectPtr, field);
         }
      
         public virtual void setFreeLook(bool isFreeLook)
         {
            InternalUnsafeMethods.setFreeLook(ObjectPtr, isFreeLook);
         }
      
         public virtual bool getFreeLook()
         {
            return InternalUnsafeMethods.getFreeLook(ObjectPtr);
         }
      
         public virtual void setTrigger(int idx, bool set)
         {
            InternalUnsafeMethods.setTrigger(ObjectPtr, idx, set);
         }
      
         public virtual bool getTrigger(int idx)
         {
            return InternalUnsafeMethods.getTrigger(ObjectPtr, idx);
         }
      
         public virtual string getAddress()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getAddress(ObjectPtr));
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}