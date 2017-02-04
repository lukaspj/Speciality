using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class DebugDrawer : SimObject
	{
		public DebugDrawer(bool pRegister = false)
			: base(pRegister)
		{
		}

		public DebugDrawer(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public DebugDrawer(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public DebugDrawer(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public DebugDrawer(SimObject pObj) : base(pObj)
		{
		}

		public DebugDrawer(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.DebugDrawer_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _drawLine(IntPtr thisPtr, InternalPoint3FStruct a, InternalPoint3FStruct b, InternalColorFStruct color);
         private static _drawLine _drawLineFunc;
         internal static void drawLine(IntPtr thisPtr, InternalPoint3FStruct a, InternalPoint3FStruct b, InternalColorFStruct color)
         {
         	if (_drawLineFunc == null)
         	{
         		_drawLineFunc =
         			(_drawLine)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnDebugDrawer_drawLine"), typeof(_drawLine));
         	}
         
         	 _drawLineFunc(thisPtr, a, b, color);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _drawBox(IntPtr thisPtr, InternalPoint3FStruct a, InternalPoint3FStruct b, InternalColorFStruct color);
         private static _drawBox _drawBoxFunc;
         internal static void drawBox(IntPtr thisPtr, InternalPoint3FStruct a, InternalPoint3FStruct b, InternalColorFStruct color)
         {
         	if (_drawBoxFunc == null)
         	{
         		_drawBoxFunc =
         			(_drawBox)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnDebugDrawer_drawBox"), typeof(_drawBox));
         	}
         
         	 _drawBoxFunc(thisPtr, a, b, color);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setLastTTL(IntPtr thisPtr, uint ms);
         private static _setLastTTL _setLastTTLFunc;
         internal static void setLastTTL(IntPtr thisPtr, uint ms)
         {
         	if (_setLastTTLFunc == null)
         	{
         		_setLastTTLFunc =
         			(_setLastTTL)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnDebugDrawer_setLastTTL"), typeof(_setLastTTL));
         	}
         
         	 _setLastTTLFunc(thisPtr, ms);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setLastZTest(IntPtr thisPtr, bool enabled);
         private static _setLastZTest _setLastZTestFunc;
         internal static void setLastZTest(IntPtr thisPtr, bool enabled)
         {
         	if (_setLastZTestFunc == null)
         	{
         		_setLastZTestFunc =
         			(_setLastZTest)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnDebugDrawer_setLastZTest"), typeof(_setLastZTest));
         	}
         
         	 _setLastZTestFunc(thisPtr, enabled);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _toggleFreeze(IntPtr thisPtr);
         private static _toggleFreeze _toggleFreezeFunc;
         internal static void toggleFreeze(IntPtr thisPtr)
         {
         	if (_toggleFreezeFunc == null)
         	{
         		_toggleFreezeFunc =
         			(_toggleFreeze)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnDebugDrawer_toggleFreeze"), typeof(_toggleFreeze));
         	}
         
         	 _toggleFreezeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _toggleDrawing(IntPtr thisPtr);
         private static _toggleDrawing _toggleDrawingFunc;
         internal static void toggleDrawing(IntPtr thisPtr)
         {
         	if (_toggleDrawingFunc == null)
         	{
         		_toggleDrawingFunc =
         			(_toggleDrawing)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnDebugDrawer_toggleDrawing"), typeof(_toggleDrawing));
         	}
         
         	 _toggleDrawingFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _DebugDrawer_create();
         private static _DebugDrawer_create _DebugDrawer_createFunc;
         internal static IntPtr DebugDrawer_create()
         {
         	if (_DebugDrawer_createFunc == null)
         	{
         		_DebugDrawer_createFunc =
         			(_DebugDrawer_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_DebugDrawer_create"), typeof(_DebugDrawer_create));
         	}
         
         	return  _DebugDrawer_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void drawLine(Point3F a, Point3F b, ColorF color = null)
         {
            if (color == null) color = ColorF.WHITE;
                  InternalUnsafeMethods.drawLine(ObjectPtr, a.ToStruct(), b.ToStruct(), color.ToStruct());
         }
      
         public virtual void drawBox(Point3F a, Point3F b, ColorF color = null)
         {
            if (color == null) color = ColorF.WHITE;
                  InternalUnsafeMethods.drawBox(ObjectPtr, a.ToStruct(), b.ToStruct(), color.ToStruct());
         }
      
         public virtual void setLastTTL(uint ms)
         {
            InternalUnsafeMethods.setLastTTL(ObjectPtr, ms);
         }
      
         public virtual void setLastZTest(bool enabled)
         {
            InternalUnsafeMethods.setLastZTest(ObjectPtr, enabled);
         }
      
         public virtual void toggleFreeze()
         {
            InternalUnsafeMethods.toggleFreeze(ObjectPtr);
         }
      
         public virtual void toggleDrawing()
         {
            InternalUnsafeMethods.toggleDrawing(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}