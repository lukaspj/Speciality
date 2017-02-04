using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ConsoleLogger : SimObject
	{
		public ConsoleLogger(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ConsoleLogger(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ConsoleLogger(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ConsoleLogger(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ConsoleLogger(SimObject pObj) : base(pObj)
		{
		}

		public ConsoleLogger(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ConsoleLogger_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _attach(IntPtr thisPtr);
         private static _attach _attachFunc;
         internal static bool attach(IntPtr thisPtr)
         {
         	if (_attachFunc == null)
         	{
         		_attachFunc =
         			(_attach)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnConsoleLogger_attach"), typeof(_attach));
         	}
         
         	return  _attachFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _detach(IntPtr thisPtr);
         private static _detach _detachFunc;
         internal static bool detach(IntPtr thisPtr)
         {
         	if (_detachFunc == null)
         	{
         		_detachFunc =
         			(_detach)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnConsoleLogger_detach"), typeof(_detach));
         	}
         
         	return  _detachFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ConsoleLogger_create();
         private static _ConsoleLogger_create _ConsoleLogger_createFunc;
         internal static IntPtr ConsoleLogger_create()
         {
         	if (_ConsoleLogger_createFunc == null)
         	{
         		_ConsoleLogger_createFunc =
         			(_ConsoleLogger_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ConsoleLogger_create"), typeof(_ConsoleLogger_create));
         	}
         
         	return  _ConsoleLogger_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool attach()
         {
            return InternalUnsafeMethods.attach(ObjectPtr);
         }
      
         public virtual bool detach()
         {
            return InternalUnsafeMethods.detach(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public LogLevel Level
         {
         	get { return (LogLevel)Enum.Parse(typeof(LogLevel), getFieldValue("Level"), true); }
         	set { setFieldValue("Level", value.ToString()); }
         }
      
      
      #endregion

	}
}