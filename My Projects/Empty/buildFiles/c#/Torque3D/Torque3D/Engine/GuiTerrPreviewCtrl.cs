using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiTerrPreviewCtrl : GuiControl
	{
		public GuiTerrPreviewCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiTerrPreviewCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiTerrPreviewCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiTerrPreviewCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiTerrPreviewCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiTerrPreviewCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiTerrPreviewCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _reset(IntPtr thisPtr);
         private static _reset _resetFunc;
         internal static void reset(IntPtr thisPtr)
         {
         	if (_resetFunc == null)
         	{
         		_resetFunc =
         			(_reset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTerrPreviewCtrl_reset"), typeof(_reset));
         	}
         
         	 _resetFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setRoot(IntPtr thisPtr);
         private static _setRoot _setRootFunc;
         internal static void setRoot(IntPtr thisPtr)
         {
         	if (_setRootFunc == null)
         	{
         		_setRootFunc =
         			(_setRoot)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTerrPreviewCtrl_setRoot"), typeof(_setRoot));
         	}
         
         	 _setRootFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint2FStruct _getRoot(IntPtr thisPtr);
         private static _getRoot _getRootFunc;
         internal static InternalPoint2FStruct getRoot(IntPtr thisPtr)
         {
         	if (_getRootFunc == null)
         	{
         		_getRootFunc =
         			(_getRoot)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTerrPreviewCtrl_getRoot"), typeof(_getRoot));
         	}
         
         	return  _getRootFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setOrigin(IntPtr thisPtr, InternalPoint2FStruct pos);
         private static _setOrigin _setOriginFunc;
         internal static void setOrigin(IntPtr thisPtr, InternalPoint2FStruct pos)
         {
         	if (_setOriginFunc == null)
         	{
         		_setOriginFunc =
         			(_setOrigin)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTerrPreviewCtrl_setOrigin"), typeof(_setOrigin));
         	}
         
         	 _setOriginFunc(thisPtr, pos);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint2FStruct _getOrigin(IntPtr thisPtr);
         private static _getOrigin _getOriginFunc;
         internal static InternalPoint2FStruct getOrigin(IntPtr thisPtr)
         {
         	if (_getOriginFunc == null)
         	{
         		_getOriginFunc =
         			(_getOrigin)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTerrPreviewCtrl_getOrigin"), typeof(_getOrigin));
         	}
         
         	return  _getOriginFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getValue(IntPtr thisPtr);
         private static _getValue _getValueFunc;
         internal static IntPtr getValue(IntPtr thisPtr)
         {
         	if (_getValueFunc == null)
         	{
         		_getValueFunc =
         			(_getValue)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTerrPreviewCtrl_getValue"), typeof(_getValue));
         	}
         
         	return  _getValueFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setValue(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string tuple);
         private static _setValue _setValueFunc;
         internal static void setValue(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string tuple)
         {
         	if (_setValueFunc == null)
         	{
         		_setValueFunc =
         			(_setValue)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTerrPreviewCtrl_setValue"), typeof(_setValue));
         	}
         
         	 _setValueFunc(thisPtr, tuple);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTerrPreviewCtrl_create();
         private static _GuiTerrPreviewCtrl_create _GuiTerrPreviewCtrl_createFunc;
         internal static IntPtr GuiTerrPreviewCtrl_create()
         {
         	if (_GuiTerrPreviewCtrl_createFunc == null)
         	{
         		_GuiTerrPreviewCtrl_createFunc =
         			(_GuiTerrPreviewCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiTerrPreviewCtrl_create"), typeof(_GuiTerrPreviewCtrl_create));
         	}
         
         	return  _GuiTerrPreviewCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void reset()
         {
            InternalUnsafeMethods.reset(ObjectPtr);
         }
      
         public virtual void setRoot()
         {
            InternalUnsafeMethods.setRoot(ObjectPtr);
         }
      
         public virtual Point2F getRoot()
         {
            return new Point2F(InternalUnsafeMethods.getRoot(ObjectPtr));
         }
      
         public virtual void setOrigin(Point2F pos)
         {
            InternalUnsafeMethods.setOrigin(ObjectPtr, pos.ToStruct());
         }
      
         public virtual Point2F getOrigin()
         {
            return new Point2F(InternalUnsafeMethods.getOrigin(ObjectPtr));
         }
      
         public virtual string getValue()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getValue(ObjectPtr));
         }
      
         public virtual void setValue(string tuple)
         {
            InternalUnsafeMethods.setValue(ObjectPtr, tuple);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}