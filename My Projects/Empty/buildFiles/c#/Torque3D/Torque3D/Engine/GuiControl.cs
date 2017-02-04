using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiControl : SimGroup
	{
		public GuiControl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiControl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiControl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiControl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiControl(SimObject pObj) : base(pObj)
		{
		}

		public GuiControl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiControl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _findHitControl(IntPtr thisPtr, int x, int y);
         private static _findHitControl _findHitControlFunc;
         internal static IntPtr findHitControl(IntPtr thisPtr, int x, int y)
         {
         	if (_findHitControlFunc == null)
         	{
         		_findHitControlFunc =
         			(_findHitControl)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_findHitControl"), typeof(_findHitControl));
         	}
         
         	return  _findHitControlFunc(thisPtr, x, y);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _findHitControls(IntPtr thisPtr, int x, int y, int width, int height);
         private static _findHitControls _findHitControlsFunc;
         internal static IntPtr findHitControls(IntPtr thisPtr, int x, int y, int width, int height)
         {
         	if (_findHitControlsFunc == null)
         	{
         		_findHitControlsFunc =
         			(_findHitControls)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_findHitControls"), typeof(_findHitControls));
         	}
         
         	return  _findHitControlsFunc(thisPtr, x, y, width, height);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _controlIsChild(IntPtr thisPtr, IntPtr control);
         private static _controlIsChild _controlIsChildFunc;
         internal static bool controlIsChild(IntPtr thisPtr, IntPtr control)
         {
         	if (_controlIsChildFunc == null)
         	{
         		_controlIsChildFunc =
         			(_controlIsChild)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_controlIsChild"), typeof(_controlIsChild));
         	}
         
         	return  _controlIsChildFunc(thisPtr, control);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isFirstResponder(IntPtr thisPtr);
         private static _isFirstResponder _isFirstResponderFunc;
         internal static bool isFirstResponder(IntPtr thisPtr)
         {
         	if (_isFirstResponderFunc == null)
         	{
         		_isFirstResponderFunc =
         			(_isFirstResponder)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_isFirstResponder"), typeof(_isFirstResponder));
         	}
         
         	return  _isFirstResponderFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setFirstResponder(IntPtr thisPtr);
         private static _setFirstResponder _setFirstResponderFunc;
         internal static void setFirstResponder(IntPtr thisPtr)
         {
         	if (_setFirstResponderFunc == null)
         	{
         		_setFirstResponderFunc =
         			(_setFirstResponder)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_setFirstResponder"), typeof(_setFirstResponder));
         	}
         
         	 _setFirstResponderFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getFirstResponder(IntPtr thisPtr);
         private static _getFirstResponder _getFirstResponderFunc;
         internal static IntPtr getFirstResponder(IntPtr thisPtr)
         {
         	if (_getFirstResponderFunc == null)
         	{
         		_getFirstResponderFunc =
         			(_getFirstResponder)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_getFirstResponder"), typeof(_getFirstResponder));
         	}
         
         	return  _getFirstResponderFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearFirstResponder(IntPtr thisPtr, bool ignored);
         private static _clearFirstResponder _clearFirstResponderFunc;
         internal static void clearFirstResponder(IntPtr thisPtr, bool ignored)
         {
         	if (_clearFirstResponderFunc == null)
         	{
         		_clearFirstResponderFunc =
         			(_clearFirstResponder)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_clearFirstResponder"), typeof(_clearFirstResponder));
         	}
         
         	 _clearFirstResponderFunc(thisPtr, ignored);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _pointInControl(IntPtr thisPtr, int x, int y);
         private static _pointInControl _pointInControlFunc;
         internal static bool pointInControl(IntPtr thisPtr, int x, int y)
         {
         	if (_pointInControlFunc == null)
         	{
         		_pointInControlFunc =
         			(_pointInControl)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_pointInControl"), typeof(_pointInControl));
         	}
         
         	return  _pointInControlFunc(thisPtr, x, y);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addGuiControl(IntPtr thisPtr, IntPtr control);
         private static _addGuiControl _addGuiControlFunc;
         internal static void addGuiControl(IntPtr thisPtr, IntPtr control)
         {
         	if (_addGuiControlFunc == null)
         	{
         		_addGuiControlFunc =
         			(_addGuiControl)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_addGuiControl"), typeof(_addGuiControl));
         	}
         
         	 _addGuiControlFunc(thisPtr, control);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getRoot(IntPtr thisPtr);
         private static _getRoot _getRootFunc;
         internal static IntPtr getRoot(IntPtr thisPtr)
         {
         	if (_getRootFunc == null)
         	{
         		_getRootFunc =
         			(_getRoot)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_getRoot"), typeof(_getRoot));
         	}
         
         	return  _getRootFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getParent(IntPtr thisPtr);
         private static _getParent _getParentFunc;
         internal static IntPtr getParent(IntPtr thisPtr)
         {
         	if (_getParentFunc == null)
         	{
         		_getParentFunc =
         			(_getParent)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_getParent"), typeof(_getParent));
         	}
         
         	return  _getParentFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isMouseLocked(IntPtr thisPtr);
         private static _isMouseLocked _isMouseLockedFunc;
         internal static bool isMouseLocked(IntPtr thisPtr)
         {
         	if (_isMouseLockedFunc == null)
         	{
         		_isMouseLockedFunc =
         			(_isMouseLocked)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_isMouseLocked"), typeof(_isMouseLocked));
         	}
         
         	return  _isMouseLockedFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setValue(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string value);
         private static _setValue _setValueFunc;
         internal static void setValue(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string value)
         {
         	if (_setValueFunc == null)
         	{
         		_setValueFunc =
         			(_setValue)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_setValue"), typeof(_setValue));
         	}
         
         	 _setValueFunc(thisPtr, value);
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
         				"fnGuiControl_getValue"), typeof(_getValue));
         	}
         
         	return  _getValueFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _makeFirstResponder(IntPtr thisPtr, bool isFirst);
         private static _makeFirstResponder _makeFirstResponderFunc;
         internal static void makeFirstResponder(IntPtr thisPtr, bool isFirst)
         {
         	if (_makeFirstResponderFunc == null)
         	{
         		_makeFirstResponderFunc =
         			(_makeFirstResponder)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_makeFirstResponder"), typeof(_makeFirstResponder));
         	}
         
         	 _makeFirstResponderFunc(thisPtr, isFirst);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isActive(IntPtr thisPtr);
         private static _isActive _isActiveFunc;
         internal static bool isActive(IntPtr thisPtr)
         {
         	if (_isActiveFunc == null)
         	{
         		_isActiveFunc =
         			(_isActive)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_isActive"), typeof(_isActive));
         	}
         
         	return  _isActiveFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setActive(IntPtr thisPtr, bool state);
         private static _setActive _setActiveFunc;
         internal static void setActive(IntPtr thisPtr, bool state)
         {
         	if (_setActiveFunc == null)
         	{
         		_setActiveFunc =
         			(_setActive)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_setActive"), typeof(_setActive));
         	}
         
         	 _setActiveFunc(thisPtr, state);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isVisible(IntPtr thisPtr);
         private static _isVisible _isVisibleFunc;
         internal static bool isVisible(IntPtr thisPtr)
         {
         	if (_isVisibleFunc == null)
         	{
         		_isVisibleFunc =
         			(_isVisible)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_isVisible"), typeof(_isVisible));
         	}
         
         	return  _isVisibleFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setVisible(IntPtr thisPtr, bool state);
         private static _setVisible _setVisibleFunc;
         internal static void setVisible(IntPtr thisPtr, bool state)
         {
         	if (_setVisibleFunc == null)
         	{
         		_setVisibleFunc =
         			(_setVisible)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_setVisible"), typeof(_setVisible));
         	}
         
         	 _setVisibleFunc(thisPtr, state);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isAwake(IntPtr thisPtr);
         private static _isAwake _isAwakeFunc;
         internal static bool isAwake(IntPtr thisPtr)
         {
         	if (_isAwakeFunc == null)
         	{
         		_isAwakeFunc =
         			(_isAwake)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_isAwake"), typeof(_isAwake));
         	}
         
         	return  _isAwakeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setProfile(IntPtr thisPtr, IntPtr profile);
         private static _setProfile _setProfileFunc;
         internal static void setProfile(IntPtr thisPtr, IntPtr profile)
         {
         	if (_setProfileFunc == null)
         	{
         		_setProfileFunc =
         			(_setProfile)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_setProfile"), typeof(_setProfile));
         	}
         
         	 _setProfileFunc(thisPtr, profile);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _resize(IntPtr thisPtr, int x, int y, int width, int height);
         private static _resize _resizeFunc;
         internal static void resize(IntPtr thisPtr, int x, int y, int width, int height)
         {
         	if (_resizeFunc == null)
         	{
         		_resizeFunc =
         			(_resize)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_resize"), typeof(_resize));
         	}
         
         	 _resizeFunc(thisPtr, x, y, width, height);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int[] _getPosition(IntPtr thisPtr);
         private static _getPosition _getPositionFunc;
         internal static int[] getPosition(IntPtr thisPtr)
         {
         	if (_getPositionFunc == null)
         	{
         		_getPositionFunc =
         			(_getPosition)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_getPosition"), typeof(_getPosition));
         	}
         
         	return  _getPositionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int[] _getCenter(IntPtr thisPtr);
         private static _getCenter _getCenterFunc;
         internal static int[] getCenter(IntPtr thisPtr)
         {
         	if (_getCenterFunc == null)
         	{
         		_getCenterFunc =
         			(_getCenter)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_getCenter"), typeof(_getCenter));
         	}
         
         	return  _getCenterFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setCenter(IntPtr thisPtr, int x, int y);
         private static _setCenter _setCenterFunc;
         internal static void setCenter(IntPtr thisPtr, int x, int y)
         {
         	if (_setCenterFunc == null)
         	{
         		_setCenterFunc =
         			(_setCenter)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_setCenter"), typeof(_setCenter));
         	}
         
         	 _setCenterFunc(thisPtr, x, y);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int[] _getGlobalCenter(IntPtr thisPtr);
         private static _getGlobalCenter _getGlobalCenterFunc;
         internal static int[] getGlobalCenter(IntPtr thisPtr)
         {
         	if (_getGlobalCenterFunc == null)
         	{
         		_getGlobalCenterFunc =
         			(_getGlobalCenter)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_getGlobalCenter"), typeof(_getGlobalCenter));
         	}
         
         	return  _getGlobalCenterFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int[] _getGlobalPosition(IntPtr thisPtr);
         private static _getGlobalPosition _getGlobalPositionFunc;
         internal static int[] getGlobalPosition(IntPtr thisPtr)
         {
         	if (_getGlobalPositionFunc == null)
         	{
         		_getGlobalPositionFunc =
         			(_getGlobalPosition)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_getGlobalPosition"), typeof(_getGlobalPosition));
         	}
         
         	return  _getGlobalPositionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setPositionGlobal(IntPtr thisPtr, int x, int y);
         private static _setPositionGlobal _setPositionGlobalFunc;
         internal static void setPositionGlobal(IntPtr thisPtr, int x, int y)
         {
         	if (_setPositionGlobalFunc == null)
         	{
         		_setPositionGlobalFunc =
         			(_setPositionGlobal)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_setPositionGlobal"), typeof(_setPositionGlobal));
         	}
         
         	 _setPositionGlobalFunc(thisPtr, x, y);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setPosition(IntPtr thisPtr, int x, int y);
         private static _setPosition _setPositionFunc;
         internal static void setPosition(IntPtr thisPtr, int x, int y)
         {
         	if (_setPositionFunc == null)
         	{
         		_setPositionFunc =
         			(_setPosition)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_setPosition"), typeof(_setPosition));
         	}
         
         	 _setPositionFunc(thisPtr, x, y);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int[] _getExtent(IntPtr thisPtr);
         private static _getExtent _getExtentFunc;
         internal static int[] getExtent(IntPtr thisPtr)
         {
         	if (_getExtentFunc == null)
         	{
         		_getExtentFunc =
         			(_getExtent)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_getExtent"), typeof(_getExtent));
         	}
         
         	return  _getExtentFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setExtent(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string extOrX, [MarshalAs(UnmanagedType.LPWStr)]string y);
         private static _setExtent _setExtentFunc;
         internal static void setExtent(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string extOrX, [MarshalAs(UnmanagedType.LPWStr)]string y)
         {
         	if (_setExtentFunc == null)
         	{
         		_setExtentFunc =
         			(_setExtent)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_setExtent"), typeof(_setExtent));
         	}
         
         	 _setExtentFunc(thisPtr, extOrX, y);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int[] _getMinExtent(IntPtr thisPtr);
         private static _getMinExtent _getMinExtentFunc;
         internal static int[] getMinExtent(IntPtr thisPtr)
         {
         	if (_getMinExtentFunc == null)
         	{
         		_getMinExtentFunc =
         			(_getMinExtent)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_getMinExtent"), typeof(_getMinExtent));
         	}
         
         	return  _getMinExtentFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getAspect(IntPtr thisPtr);
         private static _getAspect _getAspectFunc;
         internal static float getAspect(IntPtr thisPtr)
         {
         	if (_getAspectFunc == null)
         	{
         		_getAspectFunc =
         			(_getAspect)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControl_getAspect"), typeof(_getAspect));
         	}
         
         	return  _getAspectFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiControl_create();
         private static _GuiControl_create _GuiControl_createFunc;
         internal static IntPtr GuiControl_create()
         {
         	if (_GuiControl_createFunc == null)
         	{
         		_GuiControl_createFunc =
         			(_GuiControl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiControl_create"), typeof(_GuiControl_create));
         	}
         
         	return  _GuiControl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual GuiControl findHitControl(int x, int y)
         {
            return new GuiControl(InternalUnsafeMethods.findHitControl(ObjectPtr, x, y));
         }
      
         public virtual string findHitControls(int x, int y, int width, int height)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.findHitControls(ObjectPtr, x, y, width, height));
         }
      
         public virtual bool controlIsChild(GuiControl control)
         {
            return InternalUnsafeMethods.controlIsChild(ObjectPtr, control.ObjectPtr);
         }
      
         public virtual bool isFirstResponder()
         {
            return InternalUnsafeMethods.isFirstResponder(ObjectPtr);
         }
      
         public virtual void setFirstResponder()
         {
            InternalUnsafeMethods.setFirstResponder(ObjectPtr);
         }
      
         public virtual GuiControl getFirstResponder()
         {
            return new GuiControl(InternalUnsafeMethods.getFirstResponder(ObjectPtr));
         }
      
         public virtual void clearFirstResponder(bool ignored = false)
         {
            InternalUnsafeMethods.clearFirstResponder(ObjectPtr, ignored);
         }
      
         public virtual bool pointInControl(int x, int y)
         {
            return InternalUnsafeMethods.pointInControl(ObjectPtr, x, y);
         }
      
         public virtual void addGuiControl(GuiControl control)
         {
            InternalUnsafeMethods.addGuiControl(ObjectPtr, control.ObjectPtr);
         }
      
         public virtual GuiCanvas getRoot()
         {
            return new GuiCanvas(InternalUnsafeMethods.getRoot(ObjectPtr));
         }
      
         public virtual GuiControl getParent()
         {
            return new GuiControl(InternalUnsafeMethods.getParent(ObjectPtr));
         }
      
         public virtual bool isMouseLocked()
         {
            return InternalUnsafeMethods.isMouseLocked(ObjectPtr);
         }
      
         public virtual void setValue(string value)
         {
            InternalUnsafeMethods.setValue(ObjectPtr, value);
         }
      
         public virtual string getValue()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getValue(ObjectPtr));
         }
      
         public virtual void makeFirstResponder(bool isFirst)
         {
            InternalUnsafeMethods.makeFirstResponder(ObjectPtr, isFirst);
         }
      
         public virtual bool isActive()
         {
            return InternalUnsafeMethods.isActive(ObjectPtr);
         }
      
         public virtual void setActive(bool state = true)
         {
            InternalUnsafeMethods.setActive(ObjectPtr, state);
         }
      
         public virtual bool isVisible()
         {
            return InternalUnsafeMethods.isVisible(ObjectPtr);
         }
      
         public virtual void setVisible(bool state = true)
         {
            InternalUnsafeMethods.setVisible(ObjectPtr, state);
         }
      
         public virtual bool isAwake()
         {
            return InternalUnsafeMethods.isAwake(ObjectPtr);
         }
      
         public virtual void setProfile(GuiControlProfile profile)
         {
            InternalUnsafeMethods.setProfile(ObjectPtr, profile.ObjectPtr);
         }
      
         public virtual void resize(int x, int y, int width, int height)
         {
            InternalUnsafeMethods.resize(ObjectPtr, x, y, width, height);
         }
      
         public virtual Point2I getPosition()
         {
            return new Point2I(InternalUnsafeMethods.getPosition(ObjectPtr));
         }
      
         public virtual Point2I getCenter()
         {
            return new Point2I(InternalUnsafeMethods.getCenter(ObjectPtr));
         }
      
         public virtual void setCenter(int x, int y)
         {
            InternalUnsafeMethods.setCenter(ObjectPtr, x, y);
         }
      
         public virtual Point2I getGlobalCenter()
         {
            return new Point2I(InternalUnsafeMethods.getGlobalCenter(ObjectPtr));
         }
      
         public virtual Point2I getGlobalPosition()
         {
            return new Point2I(InternalUnsafeMethods.getGlobalPosition(ObjectPtr));
         }
      
         public virtual void setPositionGlobal(int x, int y)
         {
            InternalUnsafeMethods.setPositionGlobal(ObjectPtr, x, y);
         }
      
         public virtual void setPosition(int x, int y)
         {
            InternalUnsafeMethods.setPosition(ObjectPtr, x, y);
         }
      
         public virtual Point2I getExtent()
         {
            return new Point2I(InternalUnsafeMethods.getExtent(ObjectPtr));
         }
      
         public virtual void setExtent(string extOrX, string y = "")
         {
            InternalUnsafeMethods.setExtent(ObjectPtr, extOrX, y);
         }
      
         public virtual Point2I getMinExtent()
         {
            return new Point2I(InternalUnsafeMethods.getMinExtent(ObjectPtr));
         }
      
         public virtual float getAspect()
         {
            return InternalUnsafeMethods.getAspect(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public Point2I Position
         {
         	get { return new Point2I(getFieldValue("Position")); }
         	set { setFieldValue("Position", value.ToString()); }
         }
      
         public Point2I Extent
         {
         	get { return new Point2I(getFieldValue("Extent")); }
         	set { setFieldValue("Extent", value.ToString()); }
         }
      
         public Point2I MinExtent
         {
         	get { return new Point2I(getFieldValue("MinExtent")); }
         	set { setFieldValue("MinExtent", value.ToString()); }
         }
      
         public GuiHorizontalSizing HorizSizing
         {
         	get { return (GuiHorizontalSizing)Enum.Parse(typeof(GuiHorizontalSizing), getFieldValue("HorizSizing"), true); }
         	set { setFieldValue("HorizSizing", value.ToString()); }
         }
      
         public GuiVerticalSizing VertSizing
         {
         	get { return (GuiVerticalSizing)Enum.Parse(typeof(GuiVerticalSizing), getFieldValue("VertSizing"), true); }
         	set { setFieldValue("VertSizing", value.ToString()); }
         }
      
         public GuiControlProfile Profile
         {
         	get { return Sim.FindObject<GuiControlProfile>(getFieldValue("Profile")); }
         	set { setFieldValue("Profile", value.getId().ToString()); }
         }
      
         public bool Visible
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Visible")); }
         	set { setFieldValue("Visible", value ? "1" : "0"); }
         }
      
         public bool Active
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Active")); }
         	set { setFieldValue("Active", value ? "1" : "0"); }
         }
      
      
      
         public string Variable
         {
         	get { return getFieldValue("Variable"); }
         	set { setFieldValue("Variable", value); }
         }
      
         public string Command
         {
         	get { return getFieldValue("Command"); }
         	set { setFieldValue("Command", value); }
         }
      
         public string AltCommand
         {
         	get { return getFieldValue("AltCommand"); }
         	set { setFieldValue("AltCommand", value); }
         }
      
         public string Accelerator
         {
         	get { return getFieldValue("Accelerator"); }
         	set { setFieldValue("Accelerator", value); }
         }
      
         public GuiControlProfile TooltipProfile
         {
         	get { return Sim.FindObject<GuiControlProfile>(getFieldValue("TooltipProfile")); }
         	set { setFieldValue("TooltipProfile", value.getId().ToString()); }
         }
      
         public string Tooltip
         {
         	get { return getFieldValue("Tooltip"); }
         	set { setFieldValue("Tooltip", value); }
         }
      
         public int Hovertime
         {
         	get { return int.Parse(getFieldValue("Hovertime")); }
         	set { setFieldValue("Hovertime", value.ToString()); }
         }
      
         public bool IsContainer
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsContainer")); }
         	set { setFieldValue("IsContainer", value ? "1" : "0"); }
         }
      
         public string LangTableMod
         {
         	get { return getFieldValue("LangTableMod"); }
         	set { setFieldValue("LangTableMod", value); }
         }
      
      
      #endregion

	}
}