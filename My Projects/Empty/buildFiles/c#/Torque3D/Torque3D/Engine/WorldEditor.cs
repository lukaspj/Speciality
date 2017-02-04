using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class WorldEditor : EditTSCtrl
	{
		public WorldEditor(bool pRegister = false)
			: base(pRegister)
		{
		}

		public WorldEditor(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public WorldEditor(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public WorldEditor(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public WorldEditor(SimObject pObj) : base(pObj)
		{
		}

		public WorldEditor(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.WorldEditor_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ignoreObjClass(IntPtr thisPtr, int argc, string[] argv);
         private static _ignoreObjClass _ignoreObjClassFunc;
         internal static void ignoreObjClass(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_ignoreObjClassFunc == null)
         	{
         		_ignoreObjClassFunc =
         			(_ignoreObjClass)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_ignoreObjClass"), typeof(_ignoreObjClass));
         	}
         
         	 _ignoreObjClassFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearIgnoreList(IntPtr thisPtr);
         private static _clearIgnoreList _clearIgnoreListFunc;
         internal static void clearIgnoreList(IntPtr thisPtr)
         {
         	if (_clearIgnoreListFunc == null)
         	{
         		_clearIgnoreListFunc =
         			(_clearIgnoreList)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_clearIgnoreList"), typeof(_clearIgnoreList));
         	}
         
         	 _clearIgnoreListFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearSelection(IntPtr thisPtr);
         private static _clearSelection _clearSelectionFunc;
         internal static void clearSelection(IntPtr thisPtr)
         {
         	if (_clearSelectionFunc == null)
         	{
         		_clearSelectionFunc =
         			(_clearSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_clearSelection"), typeof(_clearSelection));
         	}
         
         	 _clearSelectionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getActiveSelection(IntPtr thisPtr);
         private static _getActiveSelection _getActiveSelectionFunc;
         internal static int getActiveSelection(IntPtr thisPtr)
         {
         	if (_getActiveSelectionFunc == null)
         	{
         		_getActiveSelectionFunc =
         			(_getActiveSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_getActiveSelection"), typeof(_getActiveSelection));
         	}
         
         	return  _getActiveSelectionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setActiveSelection(IntPtr thisPtr, IntPtr selection);
         private static _setActiveSelection _setActiveSelectionFunc;
         internal static void setActiveSelection(IntPtr thisPtr, IntPtr selection)
         {
         	if (_setActiveSelectionFunc == null)
         	{
         		_setActiveSelectionFunc =
         			(_setActiveSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_setActiveSelection"), typeof(_setActiveSelection));
         	}
         
         	 _setActiveSelectionFunc(thisPtr, selection);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _selectObject(IntPtr thisPtr, IntPtr obj);
         private static _selectObject _selectObjectFunc;
         internal static void selectObject(IntPtr thisPtr, IntPtr obj)
         {
         	if (_selectObjectFunc == null)
         	{
         		_selectObjectFunc =
         			(_selectObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_selectObject"), typeof(_selectObject));
         	}
         
         	 _selectObjectFunc(thisPtr, obj);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _unselectObject(IntPtr thisPtr, IntPtr obj);
         private static _unselectObject _unselectObjectFunc;
         internal static void unselectObject(IntPtr thisPtr, IntPtr obj)
         {
         	if (_unselectObjectFunc == null)
         	{
         		_unselectObjectFunc =
         			(_unselectObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_unselectObject"), typeof(_unselectObject));
         	}
         
         	 _unselectObjectFunc(thisPtr, obj);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _invalidateSelectionCentroid(IntPtr thisPtr);
         private static _invalidateSelectionCentroid _invalidateSelectionCentroidFunc;
         internal static void invalidateSelectionCentroid(IntPtr thisPtr)
         {
         	if (_invalidateSelectionCentroidFunc == null)
         	{
         		_invalidateSelectionCentroidFunc =
         			(_invalidateSelectionCentroid)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_invalidateSelectionCentroid"), typeof(_invalidateSelectionCentroid));
         	}
         
         	 _invalidateSelectionCentroidFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getSelectionSize(IntPtr thisPtr);
         private static _getSelectionSize _getSelectionSizeFunc;
         internal static int getSelectionSize(IntPtr thisPtr)
         {
         	if (_getSelectionSizeFunc == null)
         	{
         		_getSelectionSizeFunc =
         			(_getSelectionSize)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_getSelectionSize"), typeof(_getSelectionSize));
         	}
         
         	return  _getSelectionSizeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getSelectedObject(IntPtr thisPtr, int index);
         private static _getSelectedObject _getSelectedObjectFunc;
         internal static int getSelectedObject(IntPtr thisPtr, int index)
         {
         	if (_getSelectedObjectFunc == null)
         	{
         		_getSelectedObjectFunc =
         			(_getSelectedObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_getSelectedObject"), typeof(_getSelectedObject));
         	}
         
         	return  _getSelectedObjectFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getSelectionRadius(IntPtr thisPtr);
         private static _getSelectionRadius _getSelectionRadiusFunc;
         internal static float getSelectionRadius(IntPtr thisPtr)
         {
         	if (_getSelectionRadiusFunc == null)
         	{
         		_getSelectionRadiusFunc =
         			(_getSelectionRadius)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_getSelectionRadius"), typeof(_getSelectionRadius));
         	}
         
         	return  _getSelectionRadiusFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getSelectionCentroid(IntPtr thisPtr);
         private static _getSelectionCentroid _getSelectionCentroidFunc;
         internal static InternalPoint3FStruct getSelectionCentroid(IntPtr thisPtr)
         {
         	if (_getSelectionCentroidFunc == null)
         	{
         		_getSelectionCentroidFunc =
         			(_getSelectionCentroid)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_getSelectionCentroid"), typeof(_getSelectionCentroid));
         	}
         
         	return  _getSelectionCentroidFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getSelectionExtent(IntPtr thisPtr);
         private static _getSelectionExtent _getSelectionExtentFunc;
         internal static InternalPoint3FStruct getSelectionExtent(IntPtr thisPtr)
         {
         	if (_getSelectionExtentFunc == null)
         	{
         		_getSelectionExtentFunc =
         			(_getSelectionExtent)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_getSelectionExtent"), typeof(_getSelectionExtent));
         	}
         
         	return  _getSelectionExtentFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _dropSelection(IntPtr thisPtr, bool skipUndo);
         private static _dropSelection _dropSelectionFunc;
         internal static void dropSelection(IntPtr thisPtr, bool skipUndo)
         {
         	if (_dropSelectionFunc == null)
         	{
         		_dropSelectionFunc =
         			(_dropSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_dropSelection"), typeof(_dropSelection));
         	}
         
         	 _dropSelectionFunc(thisPtr, skipUndo);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _cutSelection(IntPtr thisPtr);
         private static _cutSelection _cutSelectionFunc;
         internal static void cutSelection(IntPtr thisPtr)
         {
         	if (_cutSelectionFunc == null)
         	{
         		_cutSelectionFunc =
         			(_cutSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_cutSelection"), typeof(_cutSelection));
         	}
         
         	 _cutSelectionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _copySelection(IntPtr thisPtr);
         private static _copySelection _copySelectionFunc;
         internal static void copySelection(IntPtr thisPtr)
         {
         	if (_copySelectionFunc == null)
         	{
         		_copySelectionFunc =
         			(_copySelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_copySelection"), typeof(_copySelection));
         	}
         
         	 _copySelectionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _pasteSelection(IntPtr thisPtr);
         private static _pasteSelection _pasteSelectionFunc;
         internal static void pasteSelection(IntPtr thisPtr)
         {
         	if (_pasteSelectionFunc == null)
         	{
         		_pasteSelectionFunc =
         			(_pasteSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_pasteSelection"), typeof(_pasteSelection));
         	}
         
         	 _pasteSelectionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _canPasteSelection(IntPtr thisPtr);
         private static _canPasteSelection _canPasteSelectionFunc;
         internal static bool canPasteSelection(IntPtr thisPtr)
         {
         	if (_canPasteSelectionFunc == null)
         	{
         		_canPasteSelectionFunc =
         			(_canPasteSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_canPasteSelection"), typeof(_canPasteSelection));
         	}
         
         	return  _canPasteSelectionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _hideObject(IntPtr thisPtr, IntPtr obj, bool hide);
         private static _hideObject _hideObjectFunc;
         internal static void hideObject(IntPtr thisPtr, IntPtr obj, bool hide)
         {
         	if (_hideObjectFunc == null)
         	{
         		_hideObjectFunc =
         			(_hideObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_hideObject"), typeof(_hideObject));
         	}
         
         	 _hideObjectFunc(thisPtr, obj, hide);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _hideSelection(IntPtr thisPtr, bool hide);
         private static _hideSelection _hideSelectionFunc;
         internal static void hideSelection(IntPtr thisPtr, bool hide)
         {
         	if (_hideSelectionFunc == null)
         	{
         		_hideSelectionFunc =
         			(_hideSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_hideSelection"), typeof(_hideSelection));
         	}
         
         	 _hideSelectionFunc(thisPtr, hide);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _lockSelection(IntPtr thisPtr, bool _lock);
         private static _lockSelection _lockSelectionFunc;
         internal static void lockSelection(IntPtr thisPtr, bool _lock)
         {
         	if (_lockSelectionFunc == null)
         	{
         		_lockSelectionFunc =
         			(_lockSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_lockSelection"), typeof(_lockSelection));
         	}
         
         	 _lockSelectionFunc(thisPtr, _lock);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _alignByBounds(IntPtr thisPtr, int boundsAxis);
         private static _alignByBounds _alignByBoundsFunc;
         internal static void alignByBounds(IntPtr thisPtr, int boundsAxis)
         {
         	if (_alignByBoundsFunc == null)
         	{
         		_alignByBoundsFunc =
         			(_alignByBounds)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_alignByBounds"), typeof(_alignByBounds));
         	}
         
         	 _alignByBoundsFunc(thisPtr, boundsAxis);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _alignByAxis(IntPtr thisPtr, int axis);
         private static _alignByAxis _alignByAxisFunc;
         internal static void alignByAxis(IntPtr thisPtr, int axis)
         {
         	if (_alignByAxisFunc == null)
         	{
         		_alignByAxisFunc =
         			(_alignByAxis)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_alignByAxis"), typeof(_alignByAxis));
         	}
         
         	 _alignByAxisFunc(thisPtr, axis);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _resetSelectedRotation(IntPtr thisPtr);
         private static _resetSelectedRotation _resetSelectedRotationFunc;
         internal static void resetSelectedRotation(IntPtr thisPtr)
         {
         	if (_resetSelectedRotationFunc == null)
         	{
         		_resetSelectedRotationFunc =
         			(_resetSelectedRotation)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_resetSelectedRotation"), typeof(_resetSelectedRotation));
         	}
         
         	 _resetSelectedRotationFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _resetSelectedScale(IntPtr thisPtr);
         private static _resetSelectedScale _resetSelectedScaleFunc;
         internal static void resetSelectedScale(IntPtr thisPtr)
         {
         	if (_resetSelectedScaleFunc == null)
         	{
         		_resetSelectedScaleFunc =
         			(_resetSelectedScale)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_resetSelectedScale"), typeof(_resetSelectedScale));
         	}
         
         	 _resetSelectedScaleFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _redirectConsole(IntPtr thisPtr, int objID);
         private static _redirectConsole _redirectConsoleFunc;
         internal static void redirectConsole(IntPtr thisPtr, int objID)
         {
         	if (_redirectConsoleFunc == null)
         	{
         		_redirectConsoleFunc =
         			(_redirectConsole)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_redirectConsole"), typeof(_redirectConsole));
         	}
         
         	 _redirectConsoleFunc(thisPtr, objID);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addUndoState(IntPtr thisPtr);
         private static _addUndoState _addUndoStateFunc;
         internal static void addUndoState(IntPtr thisPtr)
         {
         	if (_addUndoStateFunc == null)
         	{
         		_addUndoStateFunc =
         			(_addUndoState)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_addUndoState"), typeof(_addUndoState));
         	}
         
         	 _addUndoStateFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getSoftSnap(IntPtr thisPtr);
         private static _getSoftSnap _getSoftSnapFunc;
         internal static bool getSoftSnap(IntPtr thisPtr)
         {
         	if (_getSoftSnapFunc == null)
         	{
         		_getSoftSnapFunc =
         			(_getSoftSnap)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_getSoftSnap"), typeof(_getSoftSnap));
         	}
         
         	return  _getSoftSnapFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setSoftSnap(IntPtr thisPtr, bool softSnap);
         private static _setSoftSnap _setSoftSnapFunc;
         internal static void setSoftSnap(IntPtr thisPtr, bool softSnap)
         {
         	if (_setSoftSnapFunc == null)
         	{
         		_setSoftSnapFunc =
         			(_setSoftSnap)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_setSoftSnap"), typeof(_setSoftSnap));
         	}
         
         	 _setSoftSnapFunc(thisPtr, softSnap);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getSoftSnapSize(IntPtr thisPtr);
         private static _getSoftSnapSize _getSoftSnapSizeFunc;
         internal static float getSoftSnapSize(IntPtr thisPtr)
         {
         	if (_getSoftSnapSizeFunc == null)
         	{
         		_getSoftSnapSizeFunc =
         			(_getSoftSnapSize)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_getSoftSnapSize"), typeof(_getSoftSnapSize));
         	}
         
         	return  _getSoftSnapSizeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setSoftSnapSize(IntPtr thisPtr, float size);
         private static _setSoftSnapSize _setSoftSnapSizeFunc;
         internal static void setSoftSnapSize(IntPtr thisPtr, float size)
         {
         	if (_setSoftSnapSizeFunc == null)
         	{
         		_setSoftSnapSizeFunc =
         			(_setSoftSnapSize)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_setSoftSnapSize"), typeof(_setSoftSnapSize));
         	}
         
         	 _setSoftSnapSizeFunc(thisPtr, size);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate AlignmentType _getSoftSnapAlignment(IntPtr thisPtr);
         private static _getSoftSnapAlignment _getSoftSnapAlignmentFunc;
         internal static AlignmentType getSoftSnapAlignment(IntPtr thisPtr)
         {
         	if (_getSoftSnapAlignmentFunc == null)
         	{
         		_getSoftSnapAlignmentFunc =
         			(_getSoftSnapAlignment)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_getSoftSnapAlignment"), typeof(_getSoftSnapAlignment));
         	}
         
         	return  _getSoftSnapAlignmentFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setSoftSnapAlignment(IntPtr thisPtr, AlignmentType type);
         private static _setSoftSnapAlignment _setSoftSnapAlignmentFunc;
         internal static void setSoftSnapAlignment(IntPtr thisPtr, AlignmentType type)
         {
         	if (_setSoftSnapAlignmentFunc == null)
         	{
         		_setSoftSnapAlignmentFunc =
         			(_setSoftSnapAlignment)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_setSoftSnapAlignment"), typeof(_setSoftSnapAlignment));
         	}
         
         	 _setSoftSnapAlignmentFunc(thisPtr, type);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _softSnapSizeByBounds(IntPtr thisPtr, bool useBounds);
         private static _softSnapSizeByBounds _softSnapSizeByBoundsFunc;
         internal static void softSnapSizeByBounds(IntPtr thisPtr, bool useBounds)
         {
         	if (_softSnapSizeByBoundsFunc == null)
         	{
         		_softSnapSizeByBoundsFunc =
         			(_softSnapSizeByBounds)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_softSnapSizeByBounds"), typeof(_softSnapSizeByBounds));
         	}
         
         	 _softSnapSizeByBoundsFunc(thisPtr, useBounds);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getSoftSnapBackfaceTolerance(IntPtr thisPtr);
         private static _getSoftSnapBackfaceTolerance _getSoftSnapBackfaceToleranceFunc;
         internal static float getSoftSnapBackfaceTolerance(IntPtr thisPtr)
         {
         	if (_getSoftSnapBackfaceToleranceFunc == null)
         	{
         		_getSoftSnapBackfaceToleranceFunc =
         			(_getSoftSnapBackfaceTolerance)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_getSoftSnapBackfaceTolerance"), typeof(_getSoftSnapBackfaceTolerance));
         	}
         
         	return  _getSoftSnapBackfaceToleranceFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setSoftSnapBackfaceTolerance(IntPtr thisPtr, float tolerance);
         private static _setSoftSnapBackfaceTolerance _setSoftSnapBackfaceToleranceFunc;
         internal static void setSoftSnapBackfaceTolerance(IntPtr thisPtr, float tolerance)
         {
         	if (_setSoftSnapBackfaceToleranceFunc == null)
         	{
         		_setSoftSnapBackfaceToleranceFunc =
         			(_setSoftSnapBackfaceTolerance)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_setSoftSnapBackfaceTolerance"), typeof(_setSoftSnapBackfaceTolerance));
         	}
         
         	 _setSoftSnapBackfaceToleranceFunc(thisPtr, tolerance);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _softSnapRender(IntPtr thisPtr, float render);
         private static _softSnapRender _softSnapRenderFunc;
         internal static void softSnapRender(IntPtr thisPtr, float render)
         {
         	if (_softSnapRenderFunc == null)
         	{
         		_softSnapRenderFunc =
         			(_softSnapRender)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_softSnapRender"), typeof(_softSnapRender));
         	}
         
         	 _softSnapRenderFunc(thisPtr, render);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _softSnapRenderTriangle(IntPtr thisPtr, float renderTriangle);
         private static _softSnapRenderTriangle _softSnapRenderTriangleFunc;
         internal static void softSnapRenderTriangle(IntPtr thisPtr, float renderTriangle)
         {
         	if (_softSnapRenderTriangleFunc == null)
         	{
         		_softSnapRenderTriangleFunc =
         			(_softSnapRenderTriangle)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_softSnapRenderTriangle"), typeof(_softSnapRenderTriangle));
         	}
         
         	 _softSnapRenderTriangleFunc(thisPtr, renderTriangle);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _softSnapDebugRender(IntPtr thisPtr, float debugRender);
         private static _softSnapDebugRender _softSnapDebugRenderFunc;
         internal static void softSnapDebugRender(IntPtr thisPtr, float debugRender)
         {
         	if (_softSnapDebugRenderFunc == null)
         	{
         		_softSnapDebugRenderFunc =
         			(_softSnapDebugRender)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_softSnapDebugRender"), typeof(_softSnapDebugRender));
         	}
         
         	 _softSnapDebugRenderFunc(thisPtr, debugRender);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate AlignmentType _getTerrainSnapAlignment(IntPtr thisPtr);
         private static _getTerrainSnapAlignment _getTerrainSnapAlignmentFunc;
         internal static AlignmentType getTerrainSnapAlignment(IntPtr thisPtr)
         {
         	if (_getTerrainSnapAlignmentFunc == null)
         	{
         		_getTerrainSnapAlignmentFunc =
         			(_getTerrainSnapAlignment)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_getTerrainSnapAlignment"), typeof(_getTerrainSnapAlignment));
         	}
         
         	return  _getTerrainSnapAlignmentFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setTerrainSnapAlignment(IntPtr thisPtr, AlignmentType alignment);
         private static _setTerrainSnapAlignment _setTerrainSnapAlignmentFunc;
         internal static void setTerrainSnapAlignment(IntPtr thisPtr, AlignmentType alignment)
         {
         	if (_setTerrainSnapAlignmentFunc == null)
         	{
         		_setTerrainSnapAlignmentFunc =
         			(_setTerrainSnapAlignment)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_setTerrainSnapAlignment"), typeof(_setTerrainSnapAlignment));
         	}
         
         	 _setTerrainSnapAlignmentFunc(thisPtr, alignment);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _transformSelection(IntPtr thisPtr, bool position, InternalPoint3FStruct point, bool relativePos, bool rotate, InternalPoint3FStruct rotation, bool relativeRot, bool rotLocal, int scaleType, InternalPoint3FStruct scale, bool sRelative, bool sLocal);
         private static _transformSelection _transformSelectionFunc;
         internal static void transformSelection(IntPtr thisPtr, bool position, InternalPoint3FStruct point, bool relativePos, bool rotate, InternalPoint3FStruct rotation, bool relativeRot, bool rotLocal, int scaleType, InternalPoint3FStruct scale, bool sRelative, bool sLocal)
         {
         	if (_transformSelectionFunc == null)
         	{
         		_transformSelectionFunc =
         			(_transformSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_transformSelection"), typeof(_transformSelection));
         	}
         
         	 _transformSelectionFunc(thisPtr, position, point, relativePos, rotate, rotation, relativeRot, rotLocal, scaleType, scale, sRelative, sLocal);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _colladaExportSelection(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string path);
         private static _colladaExportSelection _colladaExportSelectionFunc;
         internal static void colladaExportSelection(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string path)
         {
         	if (_colladaExportSelectionFunc == null)
         	{
         		_colladaExportSelectionFunc =
         			(_colladaExportSelection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_colladaExportSelection"), typeof(_colladaExportSelection));
         	}
         
         	 _colladaExportSelectionFunc(thisPtr, path);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _makeSelectionPrefab(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename);
         private static _makeSelectionPrefab _makeSelectionPrefabFunc;
         internal static void makeSelectionPrefab(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename)
         {
         	if (_makeSelectionPrefabFunc == null)
         	{
         		_makeSelectionPrefabFunc =
         			(_makeSelectionPrefab)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_makeSelectionPrefab"), typeof(_makeSelectionPrefab));
         	}
         
         	 _makeSelectionPrefabFunc(thisPtr, filename);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _explodeSelectedPrefab(IntPtr thisPtr);
         private static _explodeSelectedPrefab _explodeSelectedPrefabFunc;
         internal static void explodeSelectedPrefab(IntPtr thisPtr)
         {
         	if (_explodeSelectedPrefabFunc == null)
         	{
         		_explodeSelectedPrefabFunc =
         			(_explodeSelectedPrefab)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_explodeSelectedPrefab"), typeof(_explodeSelectedPrefab));
         	}
         
         	 _explodeSelectedPrefabFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _mountRelative(IntPtr thisPtr, IntPtr objA, IntPtr objB);
         private static _mountRelative _mountRelativeFunc;
         internal static void mountRelative(IntPtr thisPtr, IntPtr objA, IntPtr objB)
         {
         	if (_mountRelativeFunc == null)
         	{
         		_mountRelativeFunc =
         			(_mountRelative)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_mountRelative"), typeof(_mountRelative));
         	}
         
         	 _mountRelativeFunc(thisPtr, objA, objB);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _createPolyhedralObject(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string className, IntPtr geometryProvider);
         private static _createPolyhedralObject _createPolyhedralObjectFunc;
         internal static IntPtr createPolyhedralObject(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string className, IntPtr geometryProvider)
         {
         	if (_createPolyhedralObjectFunc == null)
         	{
         		_createPolyhedralObjectFunc =
         			(_createPolyhedralObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_createPolyhedralObject"), typeof(_createPolyhedralObject));
         	}
         
         	return  _createPolyhedralObjectFunc(thisPtr, className, geometryProvider);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _createConvexShapeFrom(IntPtr thisPtr, IntPtr polyObject);
         private static _createConvexShapeFrom _createConvexShapeFromFunc;
         internal static IntPtr createConvexShapeFrom(IntPtr thisPtr, IntPtr polyObject)
         {
         	if (_createConvexShapeFromFunc == null)
         	{
         		_createConvexShapeFromFunc =
         			(_createConvexShapeFrom)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnWorldEditor_createConvexShapeFrom"), typeof(_createConvexShapeFrom));
         	}
         
         	return  _createConvexShapeFromFunc(thisPtr, polyObject);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _WorldEditor_create();
         private static _WorldEditor_create _WorldEditor_createFunc;
         internal static IntPtr WorldEditor_create()
         {
         	if (_WorldEditor_createFunc == null)
         	{
         		_WorldEditor_createFunc =
         			(_WorldEditor_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_WorldEditor_create"), typeof(_WorldEditor_create));
         	}
         
         	return  _WorldEditor_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void ignoreObjClass(string class_name)
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  tmp_arg_list.Add(class_name.ToString());
                  InternalUnsafeMethods.ignoreObjClass(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual void clearIgnoreList()
         {
            InternalUnsafeMethods.clearIgnoreList(ObjectPtr);
         }
      
         public virtual void clearSelection()
         {
            InternalUnsafeMethods.clearSelection(ObjectPtr);
         }
      
         public virtual int getActiveSelection()
         {
            return InternalUnsafeMethods.getActiveSelection(ObjectPtr);
         }
      
         public virtual void setActiveSelection(WorldEditorSelection selection)
         {
            InternalUnsafeMethods.setActiveSelection(ObjectPtr, selection.ObjectPtr);
         }
      
         public virtual void selectObject(SimObject obj)
         {
            InternalUnsafeMethods.selectObject(ObjectPtr, obj.ObjectPtr);
         }
      
         public virtual void unselectObject(SimObject obj)
         {
            InternalUnsafeMethods.unselectObject(ObjectPtr, obj.ObjectPtr);
         }
      
         public virtual void invalidateSelectionCentroid()
         {
            InternalUnsafeMethods.invalidateSelectionCentroid(ObjectPtr);
         }
      
         public virtual int getSelectionSize()
         {
            return InternalUnsafeMethods.getSelectionSize(ObjectPtr);
         }
      
         public virtual int getSelectedObject(int index)
         {
            return InternalUnsafeMethods.getSelectedObject(ObjectPtr, index);
         }
      
         public virtual float getSelectionRadius()
         {
            return InternalUnsafeMethods.getSelectionRadius(ObjectPtr);
         }
      
         public virtual Point3F getSelectionCentroid()
         {
            return new Point3F(InternalUnsafeMethods.getSelectionCentroid(ObjectPtr));
         }
      
         public virtual Point3F getSelectionExtent()
         {
            return new Point3F(InternalUnsafeMethods.getSelectionExtent(ObjectPtr));
         }
      
         public virtual void dropSelection(bool skipUndo = false)
         {
            InternalUnsafeMethods.dropSelection(ObjectPtr, skipUndo);
         }
      
         public virtual void cutSelection()
         {
            InternalUnsafeMethods.cutSelection(ObjectPtr);
         }
      
         public virtual void copySelection()
         {
            InternalUnsafeMethods.copySelection(ObjectPtr);
         }
      
         public virtual void pasteSelection()
         {
            InternalUnsafeMethods.pasteSelection(ObjectPtr);
         }
      
         public virtual bool canPasteSelection()
         {
            return InternalUnsafeMethods.canPasteSelection(ObjectPtr);
         }
      
         public virtual void hideObject(SceneObject obj, bool hide)
         {
            InternalUnsafeMethods.hideObject(ObjectPtr, obj.ObjectPtr, hide);
         }
      
         public virtual void hideSelection(bool hide)
         {
            InternalUnsafeMethods.hideSelection(ObjectPtr, hide);
         }
      
         public virtual void lockSelection(bool _lock)
         {
            InternalUnsafeMethods.lockSelection(ObjectPtr, _lock);
         }
      
         public virtual void alignByBounds(int boundsAxis)
         {
            InternalUnsafeMethods.alignByBounds(ObjectPtr, boundsAxis);
         }
      
         public virtual void alignByAxis(int axis)
         {
            InternalUnsafeMethods.alignByAxis(ObjectPtr, axis);
         }
      
         public virtual void resetSelectedRotation()
         {
            InternalUnsafeMethods.resetSelectedRotation(ObjectPtr);
         }
      
         public virtual void resetSelectedScale()
         {
            InternalUnsafeMethods.resetSelectedScale(ObjectPtr);
         }
      
         public virtual void redirectConsole(int objID)
         {
            InternalUnsafeMethods.redirectConsole(ObjectPtr, objID);
         }
      
         public virtual void addUndoState()
         {
            InternalUnsafeMethods.addUndoState(ObjectPtr);
         }
      
         public virtual bool getSoftSnap()
         {
            return InternalUnsafeMethods.getSoftSnap(ObjectPtr);
         }
      
         public virtual void setSoftSnap(bool softSnap)
         {
            InternalUnsafeMethods.setSoftSnap(ObjectPtr, softSnap);
         }
      
         public virtual float getSoftSnapSize()
         {
            return InternalUnsafeMethods.getSoftSnapSize(ObjectPtr);
         }
      
         public virtual void setSoftSnapSize(float size)
         {
            InternalUnsafeMethods.setSoftSnapSize(ObjectPtr, size);
         }
      
         public virtual AlignmentType getSoftSnapAlignment()
         {
            return InternalUnsafeMethods.getSoftSnapAlignment(ObjectPtr);
         }
      
         public virtual void setSoftSnapAlignment(AlignmentType type)
         {
            InternalUnsafeMethods.setSoftSnapAlignment(ObjectPtr, type);
         }
      
         public virtual void softSnapSizeByBounds(bool useBounds)
         {
            InternalUnsafeMethods.softSnapSizeByBounds(ObjectPtr, useBounds);
         }
      
         public virtual float getSoftSnapBackfaceTolerance()
         {
            return InternalUnsafeMethods.getSoftSnapBackfaceTolerance(ObjectPtr);
         }
      
         public virtual void setSoftSnapBackfaceTolerance(float tolerance)
         {
            InternalUnsafeMethods.setSoftSnapBackfaceTolerance(ObjectPtr, tolerance);
         }
      
         public virtual void softSnapRender(float render)
         {
            InternalUnsafeMethods.softSnapRender(ObjectPtr, render);
         }
      
         public virtual void softSnapRenderTriangle(float renderTriangle)
         {
            InternalUnsafeMethods.softSnapRenderTriangle(ObjectPtr, renderTriangle);
         }
      
         public virtual void softSnapDebugRender(float debugRender)
         {
            InternalUnsafeMethods.softSnapDebugRender(ObjectPtr, debugRender);
         }
      
         public virtual AlignmentType getTerrainSnapAlignment()
         {
            return InternalUnsafeMethods.getTerrainSnapAlignment(ObjectPtr);
         }
      
         public virtual void setTerrainSnapAlignment(AlignmentType alignment)
         {
            InternalUnsafeMethods.setTerrainSnapAlignment(ObjectPtr, alignment);
         }
      
         public virtual void transformSelection(bool position, Point3F point, bool relativePos, bool rotate, Point3F rotation, bool relativeRot, bool rotLocal, int scaleType, Point3F scale, bool sRelative, bool sLocal)
         {
            InternalUnsafeMethods.transformSelection(ObjectPtr, position, point.ToStruct(), relativePos, rotate, rotation.ToStruct(), relativeRot, rotLocal, scaleType, scale.ToStruct(), sRelative, sLocal);
         }
      
         public virtual void colladaExportSelection(string path)
         {
            InternalUnsafeMethods.colladaExportSelection(ObjectPtr, path);
         }
      
         public virtual void makeSelectionPrefab(string filename)
         {
            InternalUnsafeMethods.makeSelectionPrefab(ObjectPtr, filename);
         }
      
         public virtual void explodeSelectedPrefab()
         {
            InternalUnsafeMethods.explodeSelectedPrefab(ObjectPtr);
         }
      
         public virtual void mountRelative(SceneObject objA, SceneObject objB)
         {
            InternalUnsafeMethods.mountRelative(ObjectPtr, objA.ObjectPtr, objB.ObjectPtr);
         }
      
         public virtual SceneObject createPolyhedralObject(string className, SceneObject geometryProvider)
         {
            return new SceneObject(InternalUnsafeMethods.createPolyhedralObject(ObjectPtr, className, geometryProvider.ObjectPtr));
         }
      
         public virtual ConvexShape createConvexShapeFrom(SceneObject polyObject)
         {
            return new ConvexShape(InternalUnsafeMethods.createConvexShapeFrom(ObjectPtr, polyObject.ObjectPtr));
         }
      
      
      #endregion


      #region Properties
      
      
         public bool GridSnap
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("GridSnap")); }
         	set { setFieldValue("GridSnap", value ? "1" : "0"); }
         }
      
         public bool DropAtBounds
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("DropAtBounds")); }
         	set { setFieldValue("DropAtBounds", value ? "1" : "0"); }
         }
      
         public float DropBelowCameraOffset
         {
         	get { return float.Parse(getFieldValue("DropBelowCameraOffset")); }
         	set { setFieldValue("DropBelowCameraOffset", value.ToString()); }
         }
      
         public float DropAtScreenCenterScalar
         {
         	get { return float.Parse(getFieldValue("DropAtScreenCenterScalar")); }
         	set { setFieldValue("DropAtScreenCenterScalar", value.ToString()); }
         }
      
         public float DropAtScreenCenterMax
         {
         	get { return float.Parse(getFieldValue("DropAtScreenCenterMax")); }
         	set { setFieldValue("DropAtScreenCenterMax", value.ToString()); }
         }
      
         public WorldEditorDropType DropType
         {
         	get { return (WorldEditorDropType)Enum.Parse(typeof(WorldEditorDropType), getFieldValue("DropType"), true); }
         	set { setFieldValue("DropType", value.ToString()); }
         }
      
         public ColorI PopupBackgroundColor
         {
         	get { return new ColorI(getFieldValue("PopupBackgroundColor")); }
         	set { setFieldValue("PopupBackgroundColor", value.ToString()); }
         }
      
         public ColorI PopupTextColor
         {
         	get { return new ColorI(getFieldValue("PopupTextColor")); }
         	set { setFieldValue("PopupTextColor", value.ToString()); }
         }
      
         public ColorI ObjectTextColor
         {
         	get { return new ColorI(getFieldValue("ObjectTextColor")); }
         	set { setFieldValue("ObjectTextColor", value.ToString()); }
         }
      
         public ColorI SelectionBoxColor
         {
         	get { return new ColorI(getFieldValue("SelectionBoxColor")); }
         	set { setFieldValue("SelectionBoxColor", value.ToString()); }
         }
      
         public ColorI ObjSelectColor
         {
         	get { return new ColorI(getFieldValue("ObjSelectColor")); }
         	set { setFieldValue("ObjSelectColor", value.ToString()); }
         }
      
         public ColorI ObjMouseOverSelectColor
         {
         	get { return new ColorI(getFieldValue("ObjMouseOverSelectColor")); }
         	set { setFieldValue("ObjMouseOverSelectColor", value.ToString()); }
         }
      
         public ColorI ObjMouseOverColor
         {
         	get { return new ColorI(getFieldValue("ObjMouseOverColor")); }
         	set { setFieldValue("ObjMouseOverColor", value.ToString()); }
         }
      
         public ColorI DragRectColor
         {
         	get { return new ColorI(getFieldValue("DragRectColor")); }
         	set { setFieldValue("DragRectColor", value.ToString()); }
         }
      
         public ColorI FaceSelectColor
         {
         	get { return new ColorI(getFieldValue("FaceSelectColor")); }
         	set { setFieldValue("FaceSelectColor", value.ToString()); }
         }
      
         public bool BoundingBoxCollision
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("BoundingBoxCollision")); }
         	set { setFieldValue("BoundingBoxCollision", value ? "1" : "0"); }
         }
      
         public bool ObjectMeshCollision
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ObjectMeshCollision")); }
         	set { setFieldValue("ObjectMeshCollision", value ? "1" : "0"); }
         }
      
         public bool SelectionLocked
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("SelectionLocked")); }
         	set { setFieldValue("SelectionLocked", value ? "1" : "0"); }
         }
      
         public bool ObjectsUseBoxCenter
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ObjectsUseBoxCenter")); }
         	set { setFieldValue("ObjectsUseBoxCenter", value ? "1" : "0"); }
         }
      
         public string ObjTextFormat
         {
         	get { return getFieldValue("ObjTextFormat"); }
         	set { setFieldValue("ObjTextFormat", value); }
         }
      
         public bool RenderPopupBackground
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderPopupBackground")); }
         	set { setFieldValue("RenderPopupBackground", value ? "1" : "0"); }
         }
      
         public bool ShowMousePopupInfo
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ShowMousePopupInfo")); }
         	set { setFieldValue("ShowMousePopupInfo", value ? "1" : "0"); }
         }
      
         public bool RenderObjText
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderObjText")); }
         	set { setFieldValue("RenderObjText", value ? "1" : "0"); }
         }
      
         public bool RenderObjHandle
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderObjHandle")); }
         	set { setFieldValue("RenderObjHandle", value ? "1" : "0"); }
         }
      
         public bool RenderSelectionBox
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderSelectionBox")); }
         	set { setFieldValue("RenderSelectionBox", value ? "1" : "0"); }
         }
      
         public string SelectHandle
         {
         	get { return getFieldValue("SelectHandle"); }
         	set { setFieldValue("SelectHandle", value); }
         }
      
         public string DefaultHandle
         {
         	get { return getFieldValue("DefaultHandle"); }
         	set { setFieldValue("DefaultHandle", value); }
         }
      
         public string LockedHandle
         {
         	get { return getFieldValue("LockedHandle"); }
         	set { setFieldValue("LockedHandle", value); }
         }
      
         public bool FadeIcons
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("FadeIcons")); }
         	set { setFieldValue("FadeIcons", value ? "1" : "0"); }
         }
      
         public float FadeIconsDist
         {
         	get { return float.Parse(getFieldValue("FadeIconsDist")); }
         	set { setFieldValue("FadeIconsDist", value.ToString()); }
         }
      
         public bool IsDirty
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsDirty")); }
         	set { setFieldValue("IsDirty", value ? "1" : "0"); }
         }
      
         public bool StickToGround
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("StickToGround")); }
         	set { setFieldValue("StickToGround", value ? "1" : "0"); }
         }
      
         public bool ToggleIgnoreList
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ToggleIgnoreList")); }
         	set { setFieldValue("ToggleIgnoreList", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}