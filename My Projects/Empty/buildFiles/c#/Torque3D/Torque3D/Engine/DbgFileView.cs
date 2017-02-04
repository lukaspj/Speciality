using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class DbgFileView : GuiArrayCtrl
	{
		public DbgFileView(bool pRegister = false)
			: base(pRegister)
		{
		}

		public DbgFileView(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public DbgFileView(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public DbgFileView(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public DbgFileView(SimObject pObj) : base(pObj)
		{
		}

		public DbgFileView(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.DbgFileView_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setCurrentLine(IntPtr thisPtr, int line, bool selected);
         private static _setCurrentLine _setCurrentLineFunc;
         internal static void setCurrentLine(IntPtr thisPtr, int line, bool selected)
         {
         	if (_setCurrentLineFunc == null)
         	{
         		_setCurrentLineFunc =
         			(_setCurrentLine)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnDbgFileView_setCurrentLine"), typeof(_setCurrentLine));
         	}
         
         	 _setCurrentLineFunc(thisPtr, line, selected);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getCurrentLine(IntPtr thisPtr);
         private static _getCurrentLine _getCurrentLineFunc;
         internal static IntPtr getCurrentLine(IntPtr thisPtr)
         {
         	if (_getCurrentLineFunc == null)
         	{
         		_getCurrentLineFunc =
         			(_getCurrentLine)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnDbgFileView_getCurrentLine"), typeof(_getCurrentLine));
         	}
         
         	return  _getCurrentLineFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _open(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename);
         private static _open _openFunc;
         internal static bool open(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename)
         {
         	if (_openFunc == null)
         	{
         		_openFunc =
         			(_open)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnDbgFileView_open"), typeof(_open));
         	}
         
         	return  _openFunc(thisPtr, filename);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearBreakPositions(IntPtr thisPtr);
         private static _clearBreakPositions _clearBreakPositionsFunc;
         internal static void clearBreakPositions(IntPtr thisPtr)
         {
         	if (_clearBreakPositionsFunc == null)
         	{
         		_clearBreakPositionsFunc =
         			(_clearBreakPositions)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnDbgFileView_clearBreakPositions"), typeof(_clearBreakPositions));
         	}
         
         	 _clearBreakPositionsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setBreakPosition(IntPtr thisPtr, uint line);
         private static _setBreakPosition _setBreakPositionFunc;
         internal static void setBreakPosition(IntPtr thisPtr, uint line)
         {
         	if (_setBreakPositionFunc == null)
         	{
         		_setBreakPositionFunc =
         			(_setBreakPosition)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnDbgFileView_setBreakPosition"), typeof(_setBreakPosition));
         	}
         
         	 _setBreakPositionFunc(thisPtr, line);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setBreak(IntPtr thisPtr, uint line);
         private static _setBreak _setBreakFunc;
         internal static void setBreak(IntPtr thisPtr, uint line)
         {
         	if (_setBreakFunc == null)
         	{
         		_setBreakFunc =
         			(_setBreak)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnDbgFileView_setBreak"), typeof(_setBreak));
         	}
         
         	 _setBreakFunc(thisPtr, line);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeBreak(IntPtr thisPtr, uint line);
         private static _removeBreak _removeBreakFunc;
         internal static void removeBreak(IntPtr thisPtr, uint line)
         {
         	if (_removeBreakFunc == null)
         	{
         		_removeBreakFunc =
         			(_removeBreak)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnDbgFileView_removeBreak"), typeof(_removeBreak));
         	}
         
         	 _removeBreakFunc(thisPtr, line);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _findString(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string findThis);
         private static _findString _findStringFunc;
         internal static bool findString(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string findThis)
         {
         	if (_findStringFunc == null)
         	{
         		_findStringFunc =
         			(_findString)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnDbgFileView_findString"), typeof(_findString));
         	}
         
         	return  _findStringFunc(thisPtr, findThis);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _DbgFileView_create();
         private static _DbgFileView_create _DbgFileView_createFunc;
         internal static IntPtr DbgFileView_create()
         {
         	if (_DbgFileView_createFunc == null)
         	{
         		_DbgFileView_createFunc =
         			(_DbgFileView_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_DbgFileView_create"), typeof(_DbgFileView_create));
         	}
         
         	return  _DbgFileView_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setCurrentLine(int line, bool selected)
         {
            InternalUnsafeMethods.setCurrentLine(ObjectPtr, line, selected);
         }
      
         public virtual string getCurrentLine()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getCurrentLine(ObjectPtr));
         }
      
         public virtual bool open(string filename)
         {
            return InternalUnsafeMethods.open(ObjectPtr, filename);
         }
      
         public virtual void clearBreakPositions()
         {
            InternalUnsafeMethods.clearBreakPositions(ObjectPtr);
         }
      
         public virtual void setBreakPosition(uint line)
         {
            InternalUnsafeMethods.setBreakPosition(ObjectPtr, line);
         }
      
         public virtual void setBreak(uint line)
         {
            InternalUnsafeMethods.setBreak(ObjectPtr, line);
         }
      
         public virtual void removeBreak(uint line)
         {
            InternalUnsafeMethods.removeBreak(ObjectPtr, line);
         }
      
         public virtual bool findString(string findThis)
         {
            return InternalUnsafeMethods.findString(ObjectPtr, findThis);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}