using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiCanvas : GuiControl
	{
		public GuiCanvas(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiCanvas(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiCanvas(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiCanvas(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiCanvas(SimObject pObj) : base(pObj)
		{
		}

		public GuiCanvas(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiCanvas_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getContent(IntPtr thisPtr);
         private static _getContent _getContentFunc;
         internal static int getContent(IntPtr thisPtr)
         {
         	if (_getContentFunc == null)
         	{
         		_getContentFunc =
         			(_getContent)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_getContent"), typeof(_getContent));
         	}
         
         	return  _getContentFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setContent(IntPtr thisPtr, IntPtr ctrl);
         private static _setContent _setContentFunc;
         internal static void setContent(IntPtr thisPtr, IntPtr ctrl)
         {
         	if (_setContentFunc == null)
         	{
         		_setContentFunc =
         			(_setContent)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_setContent"), typeof(_setContent));
         	}
         
         	 _setContentFunc(thisPtr, ctrl);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _pushDialog(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string ctrlName, int layer, bool center);
         private static _pushDialog _pushDialogFunc;
         internal static void pushDialog(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string ctrlName, int layer, bool center)
         {
         	if (_pushDialogFunc == null)
         	{
         		_pushDialogFunc =
         			(_pushDialog)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_pushDialog"), typeof(_pushDialog));
         	}
         
         	 _pushDialogFunc(thisPtr, ctrlName, layer, center);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _popDialog(IntPtr thisPtr, IntPtr gui);
         private static _popDialog _popDialogFunc;
         internal static void popDialog(IntPtr thisPtr, IntPtr gui)
         {
         	if (_popDialogFunc == null)
         	{
         		_popDialogFunc =
         			(_popDialog)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_popDialog"), typeof(_popDialog));
         	}
         
         	 _popDialogFunc(thisPtr, gui);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _popLayer(IntPtr thisPtr, int layer);
         private static _popLayer _popLayerFunc;
         internal static void popLayer(IntPtr thisPtr, int layer)
         {
         	if (_popLayerFunc == null)
         	{
         		_popLayerFunc =
         			(_popLayer)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_popLayer"), typeof(_popLayer));
         	}
         
         	 _popLayerFunc(thisPtr, layer);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _cursorOn(IntPtr thisPtr);
         private static _cursorOn _cursorOnFunc;
         internal static void cursorOn(IntPtr thisPtr)
         {
         	if (_cursorOnFunc == null)
         	{
         		_cursorOnFunc =
         			(_cursorOn)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_cursorOn"), typeof(_cursorOn));
         	}
         
         	 _cursorOnFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _cursorOff(IntPtr thisPtr);
         private static _cursorOff _cursorOffFunc;
         internal static void cursorOff(IntPtr thisPtr)
         {
         	if (_cursorOffFunc == null)
         	{
         		_cursorOffFunc =
         			(_cursorOff)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_cursorOff"), typeof(_cursorOff));
         	}
         
         	 _cursorOffFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setCursor(IntPtr thisPtr, IntPtr cursor);
         private static _setCursor _setCursorFunc;
         internal static void setCursor(IntPtr thisPtr, IntPtr cursor)
         {
         	if (_setCursorFunc == null)
         	{
         		_setCursorFunc =
         			(_setCursor)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_setCursor"), typeof(_setCursor));
         	}
         
         	 _setCursorFunc(thisPtr, cursor);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _renderFront(IntPtr thisPtr, bool enable);
         private static _renderFront _renderFrontFunc;
         internal static void renderFront(IntPtr thisPtr, bool enable)
         {
         	if (_renderFrontFunc == null)
         	{
         		_renderFrontFunc =
         			(_renderFront)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_renderFront"), typeof(_renderFront));
         	}
         
         	 _renderFrontFunc(thisPtr, enable);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _showCursor(IntPtr thisPtr);
         private static _showCursor _showCursorFunc;
         internal static void showCursor(IntPtr thisPtr)
         {
         	if (_showCursorFunc == null)
         	{
         		_showCursorFunc =
         			(_showCursor)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_showCursor"), typeof(_showCursor));
         	}
         
         	 _showCursorFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _hideCursor(IntPtr thisPtr);
         private static _hideCursor _hideCursorFunc;
         internal static void hideCursor(IntPtr thisPtr)
         {
         	if (_hideCursorFunc == null)
         	{
         		_hideCursorFunc =
         			(_hideCursor)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_hideCursor"), typeof(_hideCursor));
         	}
         
         	 _hideCursorFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isCursorOn(IntPtr thisPtr);
         private static _isCursorOn _isCursorOnFunc;
         internal static bool isCursorOn(IntPtr thisPtr)
         {
         	if (_isCursorOnFunc == null)
         	{
         		_isCursorOnFunc =
         			(_isCursorOn)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_isCursorOn"), typeof(_isCursorOn));
         	}
         
         	return  _isCursorOnFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isCursorShown(IntPtr thisPtr);
         private static _isCursorShown _isCursorShownFunc;
         internal static bool isCursorShown(IntPtr thisPtr)
         {
         	if (_isCursorShownFunc == null)
         	{
         		_isCursorShownFunc =
         			(_isCursorShown)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_isCursorShown"), typeof(_isCursorShown));
         	}
         
         	return  _isCursorShownFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _repaint(IntPtr thisPtr, int elapsedMS);
         private static _repaint _repaintFunc;
         internal static void repaint(IntPtr thisPtr, int elapsedMS)
         {
         	if (_repaintFunc == null)
         	{
         		_repaintFunc =
         			(_repaint)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_repaint"), typeof(_repaint));
         	}
         
         	 _repaintFunc(thisPtr, elapsedMS);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _reset(IntPtr thisPtr);
         private static _reset _resetFunc;
         internal static void reset(IntPtr thisPtr)
         {
         	if (_resetFunc == null)
         	{
         		_resetFunc =
         			(_reset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_reset"), typeof(_reset));
         	}
         
         	 _resetFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int[] _getCursorPos(IntPtr thisPtr);
         private static _getCursorPos _getCursorPosFunc;
         internal static int[] getCursorPos(IntPtr thisPtr)
         {
         	if (_getCursorPosFunc == null)
         	{
         		_getCursorPosFunc =
         			(_getCursorPos)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_getCursorPos"), typeof(_getCursorPos));
         	}
         
         	return  _getCursorPosFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setCursorPos(IntPtr thisPtr, int[] pos);
         private static _setCursorPos _setCursorPosFunc;
         internal static void setCursorPos(IntPtr thisPtr, int[] pos)
         {
         	if (_setCursorPosFunc == null)
         	{
         		_setCursorPosFunc =
         			(_setCursorPos)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_setCursorPos"), typeof(_setCursorPos));
         	}
         
         	 _setCursorPosFunc(thisPtr, pos);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getMouseControl(IntPtr thisPtr);
         private static _getMouseControl _getMouseControlFunc;
         internal static int getMouseControl(IntPtr thisPtr)
         {
         	if (_getMouseControlFunc == null)
         	{
         		_getMouseControlFunc =
         			(_getMouseControl)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_getMouseControl"), typeof(_getMouseControl));
         	}
         
         	return  _getMouseControlFunc(thisPtr);
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
         				"fnGuiCanvas_getExtent"), typeof(_getExtent));
         	}
         
         	return  _getExtentFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setWindowTitle(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string newTitle);
         private static _setWindowTitle _setWindowTitleFunc;
         internal static void setWindowTitle(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string newTitle)
         {
         	if (_setWindowTitleFunc == null)
         	{
         		_setWindowTitleFunc =
         			(_setWindowTitle)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_setWindowTitle"), typeof(_setWindowTitle));
         	}
         
         	 _setWindowTitleFunc(thisPtr, newTitle);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _findFirstMatchingMonitor(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _findFirstMatchingMonitor _findFirstMatchingMonitorFunc;
         internal static int findFirstMatchingMonitor(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_findFirstMatchingMonitorFunc == null)
         	{
         		_findFirstMatchingMonitorFunc =
         			(_findFirstMatchingMonitor)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_findFirstMatchingMonitor"), typeof(_findFirstMatchingMonitor));
         	}
         
         	return  _findFirstMatchingMonitorFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getMonitorCount(IntPtr thisPtr);
         private static _getMonitorCount _getMonitorCountFunc;
         internal static int getMonitorCount(IntPtr thisPtr)
         {
         	if (_getMonitorCountFunc == null)
         	{
         		_getMonitorCountFunc =
         			(_getMonitorCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_getMonitorCount"), typeof(_getMonitorCount));
         	}
         
         	return  _getMonitorCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getMonitorName(IntPtr thisPtr, int index);
         private static _getMonitorName _getMonitorNameFunc;
         internal static IntPtr getMonitorName(IntPtr thisPtr, int index)
         {
         	if (_getMonitorNameFunc == null)
         	{
         		_getMonitorNameFunc =
         			(_getMonitorName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_getMonitorName"), typeof(_getMonitorName));
         	}
         
         	return  _getMonitorNameFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalRectIStruct _getMonitorRect(IntPtr thisPtr, int index);
         private static _getMonitorRect _getMonitorRectFunc;
         internal static InternalRectIStruct getMonitorRect(IntPtr thisPtr, int index)
         {
         	if (_getMonitorRectFunc == null)
         	{
         		_getMonitorRectFunc =
         			(_getMonitorRect)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_getMonitorRect"), typeof(_getMonitorRect));
         	}
         
         	return  _getMonitorRectFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getVideoMode(IntPtr thisPtr);
         private static _getVideoMode _getVideoModeFunc;
         internal static IntPtr getVideoMode(IntPtr thisPtr)
         {
         	if (_getVideoModeFunc == null)
         	{
         		_getVideoModeFunc =
         			(_getVideoMode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_getVideoMode"), typeof(_getVideoMode));
         	}
         
         	return  _getVideoModeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getModeCount(IntPtr thisPtr);
         private static _getModeCount _getModeCountFunc;
         internal static int getModeCount(IntPtr thisPtr)
         {
         	if (_getModeCountFunc == null)
         	{
         		_getModeCountFunc =
         			(_getModeCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_getModeCount"), typeof(_getModeCount));
         	}
         
         	return  _getModeCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getMode(IntPtr thisPtr, int modeId);
         private static _getMode _getModeFunc;
         internal static IntPtr getMode(IntPtr thisPtr, int modeId)
         {
         	if (_getModeFunc == null)
         	{
         		_getModeFunc =
         			(_getMode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_getMode"), typeof(_getMode));
         	}
         
         	return  _getModeFunc(thisPtr, modeId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _toggleFullscreen(IntPtr thisPtr);
         private static _toggleFullscreen _toggleFullscreenFunc;
         internal static void toggleFullscreen(IntPtr thisPtr)
         {
         	if (_toggleFullscreenFunc == null)
         	{
         		_toggleFullscreenFunc =
         			(_toggleFullscreen)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_toggleFullscreen"), typeof(_toggleFullscreen));
         	}
         
         	 _toggleFullscreenFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int[] _clientToScreen(IntPtr thisPtr, int[] coordinate);
         private static _clientToScreen _clientToScreenFunc;
         internal static int[] clientToScreen(IntPtr thisPtr, int[] coordinate)
         {
         	if (_clientToScreenFunc == null)
         	{
         		_clientToScreenFunc =
         			(_clientToScreen)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_clientToScreen"), typeof(_clientToScreen));
         	}
         
         	return  _clientToScreenFunc(thisPtr, coordinate);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int[] _screenToClient(IntPtr thisPtr, int[] coordinate);
         private static _screenToClient _screenToClientFunc;
         internal static int[] screenToClient(IntPtr thisPtr, int[] coordinate)
         {
         	if (_screenToClientFunc == null)
         	{
         		_screenToClientFunc =
         			(_screenToClient)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_screenToClient"), typeof(_screenToClient));
         	}
         
         	return  _screenToClientFunc(thisPtr, coordinate);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int[] _getWindowPosition(IntPtr thisPtr);
         private static _getWindowPosition _getWindowPositionFunc;
         internal static int[] getWindowPosition(IntPtr thisPtr)
         {
         	if (_getWindowPositionFunc == null)
         	{
         		_getWindowPositionFunc =
         			(_getWindowPosition)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_getWindowPosition"), typeof(_getWindowPosition));
         	}
         
         	return  _getWindowPositionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setWindowPosition(IntPtr thisPtr, int[] position);
         private static _setWindowPosition _setWindowPositionFunc;
         internal static void setWindowPosition(IntPtr thisPtr, int[] position)
         {
         	if (_setWindowPositionFunc == null)
         	{
         		_setWindowPositionFunc =
         			(_setWindowPosition)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_setWindowPosition"), typeof(_setWindowPosition));
         	}
         
         	 _setWindowPositionFunc(thisPtr, position);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isFullscreen(IntPtr thisPtr);
         private static _isFullscreen _isFullscreenFunc;
         internal static bool isFullscreen(IntPtr thisPtr)
         {
         	if (_isFullscreenFunc == null)
         	{
         		_isFullscreenFunc =
         			(_isFullscreen)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_isFullscreen"), typeof(_isFullscreen));
         	}
         
         	return  _isFullscreenFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _minimizeWindow(IntPtr thisPtr);
         private static _minimizeWindow _minimizeWindowFunc;
         internal static void minimizeWindow(IntPtr thisPtr)
         {
         	if (_minimizeWindowFunc == null)
         	{
         		_minimizeWindowFunc =
         			(_minimizeWindow)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_minimizeWindow"), typeof(_minimizeWindow));
         	}
         
         	 _minimizeWindowFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isMinimized(IntPtr thisPtr);
         private static _isMinimized _isMinimizedFunc;
         internal static bool isMinimized(IntPtr thisPtr)
         {
         	if (_isMinimizedFunc == null)
         	{
         		_isMinimizedFunc =
         			(_isMinimized)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_isMinimized"), typeof(_isMinimized));
         	}
         
         	return  _isMinimizedFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isMaximized(IntPtr thisPtr);
         private static _isMaximized _isMaximizedFunc;
         internal static bool isMaximized(IntPtr thisPtr)
         {
         	if (_isMaximizedFunc == null)
         	{
         		_isMaximizedFunc =
         			(_isMaximized)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_isMaximized"), typeof(_isMaximized));
         	}
         
         	return  _isMaximizedFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _maximizeWindow(IntPtr thisPtr);
         private static _maximizeWindow _maximizeWindowFunc;
         internal static void maximizeWindow(IntPtr thisPtr)
         {
         	if (_maximizeWindowFunc == null)
         	{
         		_maximizeWindowFunc =
         			(_maximizeWindow)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_maximizeWindow"), typeof(_maximizeWindow));
         	}
         
         	 _maximizeWindowFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _restoreWindow(IntPtr thisPtr);
         private static _restoreWindow _restoreWindowFunc;
         internal static void restoreWindow(IntPtr thisPtr)
         {
         	if (_restoreWindowFunc == null)
         	{
         		_restoreWindowFunc =
         			(_restoreWindow)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_restoreWindow"), typeof(_restoreWindow));
         	}
         
         	 _restoreWindowFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setFocus(IntPtr thisPtr);
         private static _setFocus _setFocusFunc;
         internal static void setFocus(IntPtr thisPtr)
         {
         	if (_setFocusFunc == null)
         	{
         		_setFocusFunc =
         			(_setFocus)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_setFocus"), typeof(_setFocus));
         	}
         
         	 _setFocusFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMenuBar(IntPtr thisPtr, IntPtr menu);
         private static _setMenuBar _setMenuBarFunc;
         internal static void setMenuBar(IntPtr thisPtr, IntPtr menu)
         {
         	if (_setMenuBarFunc == null)
         	{
         		_setMenuBarFunc =
         			(_setMenuBar)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_setMenuBar"), typeof(_setMenuBar));
         	}
         
         	 _setMenuBarFunc(thisPtr, menu);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setVideoMode(IntPtr thisPtr, uint width, uint height, bool fullscreen, uint bitDepth, uint refreshRate, uint antialiasLevel);
         private static _setVideoMode _setVideoModeFunc;
         internal static void setVideoMode(IntPtr thisPtr, uint width, uint height, bool fullscreen, uint bitDepth, uint refreshRate, uint antialiasLevel)
         {
         	if (_setVideoModeFunc == null)
         	{
         		_setVideoModeFunc =
         			(_setVideoMode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_setVideoMode"), typeof(_setVideoMode));
         	}
         
         	 _setVideoModeFunc(thisPtr, width, height, fullscreen, bitDepth, refreshRate, antialiasLevel);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _showWindow(IntPtr thisPtr, int argc, string[] argv);
         private static _showWindow _showWindowFunc;
         internal static void showWindow(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_showWindowFunc == null)
         	{
         		_showWindowFunc =
         			(_showWindow)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_showWindow"), typeof(_showWindow));
         	}
         
         	 _showWindowFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _hideWindow(IntPtr thisPtr, int argc, string[] argv);
         private static _hideWindow _hideWindowFunc;
         internal static void hideWindow(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_hideWindowFunc == null)
         	{
         		_hideWindowFunc =
         			(_hideWindow)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_hideWindow"), typeof(_hideWindow));
         	}
         
         	 _hideWindowFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _cursorClick(IntPtr thisPtr, int argc, string[] argv);
         private static _cursorClick _cursorClickFunc;
         internal static void cursorClick(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_cursorClickFunc == null)
         	{
         		_cursorClickFunc =
         			(_cursorClick)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_cursorClick"), typeof(_cursorClick));
         	}
         
         	 _cursorClickFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _cursorNudge(IntPtr thisPtr, int argc, string[] argv);
         private static _cursorNudge _cursorNudgeFunc;
         internal static void cursorNudge(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_cursorNudgeFunc == null)
         	{
         		_cursorNudgeFunc =
         			(_cursorNudge)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiCanvas_cursorNudge"), typeof(_cursorNudge));
         	}
         
         	 _cursorNudgeFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiCanvas_create();
         private static _GuiCanvas_create _GuiCanvas_createFunc;
         internal static IntPtr GuiCanvas_create()
         {
         	if (_GuiCanvas_createFunc == null)
         	{
         		_GuiCanvas_createFunc =
         			(_GuiCanvas_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiCanvas_create"), typeof(_GuiCanvas_create));
         	}
         
         	return  _GuiCanvas_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual int getContent()
         {
            return InternalUnsafeMethods.getContent(ObjectPtr);
         }
      
         public virtual void setContent(GuiControl ctrl)
         {
            InternalUnsafeMethods.setContent(ObjectPtr, ctrl.ObjectPtr);
         }
      
         public virtual void pushDialog(string ctrlName, int layer = 0, bool center = false)
         {
            InternalUnsafeMethods.pushDialog(ObjectPtr, ctrlName, layer, center);
         }
      
         public virtual void popDialog(GuiControl gui = null)
         {
            InternalUnsafeMethods.popDialog(ObjectPtr, gui == null ? IntPtr.Zero : gui.ObjectPtr );
         }
      
         public virtual void popLayer(int layer = 0)
         {
            InternalUnsafeMethods.popLayer(ObjectPtr, layer);
         }
      
         public virtual void cursorOn()
         {
            InternalUnsafeMethods.cursorOn(ObjectPtr);
         }
      
         public virtual void cursorOff()
         {
            InternalUnsafeMethods.cursorOff(ObjectPtr);
         }
      
         public virtual void setCursor(GuiCursor cursor)
         {
            InternalUnsafeMethods.setCursor(ObjectPtr, cursor.ObjectPtr);
         }
      
         public virtual void renderFront(bool enable)
         {
            InternalUnsafeMethods.renderFront(ObjectPtr, enable);
         }
      
         public virtual void showCursor()
         {
            InternalUnsafeMethods.showCursor(ObjectPtr);
         }
      
         public virtual void hideCursor()
         {
            InternalUnsafeMethods.hideCursor(ObjectPtr);
         }
      
         public virtual bool isCursorOn()
         {
            return InternalUnsafeMethods.isCursorOn(ObjectPtr);
         }
      
         public virtual bool isCursorShown()
         {
            return InternalUnsafeMethods.isCursorShown(ObjectPtr);
         }
      
         public virtual void repaint(int elapsedMS = 0)
         {
            InternalUnsafeMethods.repaint(ObjectPtr, elapsedMS);
         }
      
         public virtual void reset()
         {
            InternalUnsafeMethods.reset(ObjectPtr);
         }
      
         public virtual Point2I getCursorPos()
         {
            return new Point2I(InternalUnsafeMethods.getCursorPos(ObjectPtr));
         }
      
         public virtual void setCursorPos(Point2I pos)
         {
            InternalUnsafeMethods.setCursorPos(ObjectPtr, pos.ToArray());
         }
      
         public virtual int getMouseControl()
         {
            return InternalUnsafeMethods.getMouseControl(ObjectPtr);
         }
      
         public virtual Point2I getExtent()
         {
            return new Point2I(InternalUnsafeMethods.getExtent(ObjectPtr));
         }
      
         public virtual void setWindowTitle(string newTitle)
         {
            InternalUnsafeMethods.setWindowTitle(ObjectPtr, newTitle);
         }
      
         public virtual int findFirstMatchingMonitor(string name)
         {
            return InternalUnsafeMethods.findFirstMatchingMonitor(ObjectPtr, name);
         }
      
         public virtual int getMonitorCount()
         {
            return InternalUnsafeMethods.getMonitorCount(ObjectPtr);
         }
      
         public virtual string getMonitorName(int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getMonitorName(ObjectPtr, index));
         }
      
         public virtual RectI getMonitorRect(int index)
         {
            return new RectI(InternalUnsafeMethods.getMonitorRect(ObjectPtr, index));
         }
      
         public virtual string getVideoMode()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getVideoMode(ObjectPtr));
         }
      
         public virtual int getModeCount()
         {
            return InternalUnsafeMethods.getModeCount(ObjectPtr);
         }
      
         public virtual string getMode(int modeId)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getMode(ObjectPtr, modeId));
         }
      
         public virtual void toggleFullscreen()
         {
            InternalUnsafeMethods.toggleFullscreen(ObjectPtr);
         }
      
         public virtual Point2I clientToScreen(Point2I coordinate)
         {
            return new Point2I(InternalUnsafeMethods.clientToScreen(ObjectPtr, coordinate.ToArray()));
         }
      
         public virtual Point2I screenToClient(Point2I coordinate)
         {
            return new Point2I(InternalUnsafeMethods.screenToClient(ObjectPtr, coordinate.ToArray()));
         }
      
         public virtual Point2I getWindowPosition()
         {
            return new Point2I(InternalUnsafeMethods.getWindowPosition(ObjectPtr));
         }
      
         public virtual void setWindowPosition(Point2I position)
         {
            InternalUnsafeMethods.setWindowPosition(ObjectPtr, position.ToArray());
         }
      
         public virtual bool isFullscreen()
         {
            return InternalUnsafeMethods.isFullscreen(ObjectPtr);
         }
      
         public virtual void minimizeWindow()
         {
            InternalUnsafeMethods.minimizeWindow(ObjectPtr);
         }
      
         public virtual bool isMinimized()
         {
            return InternalUnsafeMethods.isMinimized(ObjectPtr);
         }
      
         public virtual bool isMaximized()
         {
            return InternalUnsafeMethods.isMaximized(ObjectPtr);
         }
      
         public virtual void maximizeWindow()
         {
            InternalUnsafeMethods.maximizeWindow(ObjectPtr);
         }
      
         public virtual void restoreWindow()
         {
            InternalUnsafeMethods.restoreWindow(ObjectPtr);
         }
      
         public virtual void setFocus()
         {
            InternalUnsafeMethods.setFocus(ObjectPtr);
         }
      
         public virtual void setMenuBar(GuiControl menu)
         {
            InternalUnsafeMethods.setMenuBar(ObjectPtr, menu.ObjectPtr);
         }
      
         public virtual void setVideoMode(uint width, uint height, bool fullscreen = false, uint bitDepth = 0, uint refreshRate = 0, uint antialiasLevel = 0)
         {
            InternalUnsafeMethods.setVideoMode(ObjectPtr, width, height, fullscreen, bitDepth, refreshRate, antialiasLevel);
         }
      
         public virtual void showWindow()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  InternalUnsafeMethods.showWindow(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual void hideWindow()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  InternalUnsafeMethods.hideWindow(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual void cursorClick()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  InternalUnsafeMethods.cursorClick(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual void cursorNudge()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  InternalUnsafeMethods.cursorNudge(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
      
      #endregion


      #region Properties
      
      
         public bool AlwaysHandleMouseButtons
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AlwaysHandleMouseButtons")); }
         	set { setFieldValue("AlwaysHandleMouseButtons", value ? "1" : "0"); }
         }
      
         public int NumFences
         {
         	get { return int.Parse(getFieldValue("NumFences")); }
         	set { setFieldValue("NumFences", value.ToString()); }
         }
      
         public bool DisplayWindow
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("DisplayWindow")); }
         	set { setFieldValue("DisplayWindow", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}