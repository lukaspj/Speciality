using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ScriptTickObject : ScriptObject
	{
		public ScriptTickObject(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ScriptTickObject(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ScriptTickObject(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ScriptTickObject(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ScriptTickObject(SimObject pObj) : base(pObj)
		{
		}

		public ScriptTickObject(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ScriptTickObject_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setProcessTicks(IntPtr thisPtr, bool tick);
         private static _setProcessTicks _setProcessTicksFunc;
         internal static void setProcessTicks(IntPtr thisPtr, bool tick)
         {
         	if (_setProcessTicksFunc == null)
         	{
         		_setProcessTicksFunc =
         			(_setProcessTicks)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnScriptTickObject_setProcessTicks"), typeof(_setProcessTicks));
         	}
         
         	 _setProcessTicksFunc(thisPtr, tick);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isProcessingTicks(IntPtr thisPtr);
         private static _isProcessingTicks _isProcessingTicksFunc;
         internal static bool isProcessingTicks(IntPtr thisPtr)
         {
         	if (_isProcessingTicksFunc == null)
         	{
         		_isProcessingTicksFunc =
         			(_isProcessingTicks)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnScriptTickObject_isProcessingTicks"), typeof(_isProcessingTicks));
         	}
         
         	return  _isProcessingTicksFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ScriptTickObject_create();
         private static _ScriptTickObject_create _ScriptTickObject_createFunc;
         internal static IntPtr ScriptTickObject_create()
         {
         	if (_ScriptTickObject_createFunc == null)
         	{
         		_ScriptTickObject_createFunc =
         			(_ScriptTickObject_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ScriptTickObject_create"), typeof(_ScriptTickObject_create));
         	}
         
         	return  _ScriptTickObject_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setProcessTicks(bool tick)
         {
            InternalUnsafeMethods.setProcessTicks(ObjectPtr, tick);
         }
      
         public virtual bool isProcessingTicks()
         {
            return InternalUnsafeMethods.isProcessingTicks(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public bool CallOnAdvanceTime
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("CallOnAdvanceTime")); }
         	set { setFieldValue("CallOnAdvanceTime", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}