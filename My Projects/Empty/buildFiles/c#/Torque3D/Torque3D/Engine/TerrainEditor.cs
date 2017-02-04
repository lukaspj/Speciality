using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class TerrainEditor : EditTSCtrl
	{
		public TerrainEditor(bool pRegister = false)
			: base(pRegister)
		{
		}

		public TerrainEditor(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public TerrainEditor(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public TerrainEditor(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public TerrainEditor(SimObject pObj) : base(pObj)
		{
		}

		public TerrainEditor(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.TerrainEditor_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _attachTerrain(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string terrain);
         private static _attachTerrain _attachTerrainFunc;
         internal static void attachTerrain(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string terrain)
         {
         	if (_attachTerrainFunc == null)
         	{
         		_attachTerrainFunc =
         			(_attachTerrain)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_attachTerrain"), typeof(_attachTerrain));
         	}
         
         	 _attachTerrainFunc(thisPtr, terrain);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getTerrainBlockCount(IntPtr thisPtr);
         private static _getTerrainBlockCount _getTerrainBlockCountFunc;
         internal static int getTerrainBlockCount(IntPtr thisPtr)
         {
         	if (_getTerrainBlockCountFunc == null)
         	{
         		_getTerrainBlockCountFunc =
         			(_getTerrainBlockCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_getTerrainBlockCount"), typeof(_getTerrainBlockCount));
         	}
         
         	return  _getTerrainBlockCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getTerrainBlock(IntPtr thisPtr, int index);
         private static _getTerrainBlock _getTerrainBlockFunc;
         internal static int getTerrainBlock(IntPtr thisPtr, int index)
         {
         	if (_getTerrainBlockFunc == null)
         	{
         		_getTerrainBlockFunc =
         			(_getTerrainBlock)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_getTerrainBlock"), typeof(_getTerrainBlock));
         	}
         
         	return  _getTerrainBlockFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getTerrainBlocksMaterialList(IntPtr thisPtr);
         private static _getTerrainBlocksMaterialList _getTerrainBlocksMaterialListFunc;
         internal static IntPtr getTerrainBlocksMaterialList(IntPtr thisPtr)
         {
         	if (_getTerrainBlocksMaterialListFunc == null)
         	{
         		_getTerrainBlocksMaterialListFunc =
         			(_getTerrainBlocksMaterialList)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_getTerrainBlocksMaterialList"), typeof(_getTerrainBlocksMaterialList));
         	}
         
         	return  _getTerrainBlocksMaterialListFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setBrushType(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string type);
         private static _setBrushType _setBrushTypeFunc;
         internal static void setBrushType(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string type)
         {
         	if (_setBrushTypeFunc == null)
         	{
         		_setBrushTypeFunc =
         			(_setBrushType)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_setBrushType"), typeof(_setBrushType));
         	}
         
         	 _setBrushTypeFunc(thisPtr, type);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getBrushType(IntPtr thisPtr);
         private static _getBrushType _getBrushTypeFunc;
         internal static IntPtr getBrushType(IntPtr thisPtr)
         {
         	if (_getBrushTypeFunc == null)
         	{
         		_getBrushTypeFunc =
         			(_getBrushType)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_getBrushType"), typeof(_getBrushType));
         	}
         
         	return  _getBrushTypeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setBrushSize(IntPtr thisPtr, int w, int h);
         private static _setBrushSize _setBrushSizeFunc;
         internal static void setBrushSize(IntPtr thisPtr, int w, int h)
         {
         	if (_setBrushSizeFunc == null)
         	{
         		_setBrushSizeFunc =
         			(_setBrushSize)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_setBrushSize"), typeof(_setBrushSize));
         	}
         
         	 _setBrushSizeFunc(thisPtr, w, h);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getBrushSize(IntPtr thisPtr);
         private static _getBrushSize _getBrushSizeFunc;
         internal static IntPtr getBrushSize(IntPtr thisPtr)
         {
         	if (_getBrushSizeFunc == null)
         	{
         		_getBrushSizeFunc =
         			(_getBrushSize)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_getBrushSize"), typeof(_getBrushSize));
         	}
         
         	return  _getBrushSizeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setBrushPressure(IntPtr thisPtr, float pressure);
         private static _setBrushPressure _setBrushPressureFunc;
         internal static void setBrushPressure(IntPtr thisPtr, float pressure)
         {
         	if (_setBrushPressureFunc == null)
         	{
         		_setBrushPressureFunc =
         			(_setBrushPressure)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_setBrushPressure"), typeof(_setBrushPressure));
         	}
         
         	 _setBrushPressureFunc(thisPtr, pressure);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getBrushPressure(IntPtr thisPtr);
         private static _getBrushPressure _getBrushPressureFunc;
         internal static float getBrushPressure(IntPtr thisPtr)
         {
         	if (_getBrushPressureFunc == null)
         	{
         		_getBrushPressureFunc =
         			(_getBrushPressure)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_getBrushPressure"), typeof(_getBrushPressure));
         	}
         
         	return  _getBrushPressureFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setBrushSoftness(IntPtr thisPtr, float softness);
         private static _setBrushSoftness _setBrushSoftnessFunc;
         internal static void setBrushSoftness(IntPtr thisPtr, float softness)
         {
         	if (_setBrushSoftnessFunc == null)
         	{
         		_setBrushSoftnessFunc =
         			(_setBrushSoftness)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_setBrushSoftness"), typeof(_setBrushSoftness));
         	}
         
         	 _setBrushSoftnessFunc(thisPtr, softness);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getBrushSoftness(IntPtr thisPtr);
         private static _getBrushSoftness _getBrushSoftnessFunc;
         internal static float getBrushSoftness(IntPtr thisPtr)
         {
         	if (_getBrushSoftnessFunc == null)
         	{
         		_getBrushSoftnessFunc =
         			(_getBrushSoftness)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_getBrushSoftness"), typeof(_getBrushSoftness));
         	}
         
         	return  _getBrushSoftnessFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getBrushPos(IntPtr thisPtr);
         private static _getBrushPos _getBrushPosFunc;
         internal static IntPtr getBrushPos(IntPtr thisPtr)
         {
         	if (_getBrushPosFunc == null)
         	{
         		_getBrushPosFunc =
         			(_getBrushPos)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_getBrushPos"), typeof(_getBrushPos));
         	}
         
         	return  _getBrushPosFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setBrushPos(IntPtr thisPtr, int[] pos);
         private static _setBrushPos _setBrushPosFunc;
         internal static void setBrushPos(IntPtr thisPtr, int[] pos)
         {
         	if (_setBrushPosFunc == null)
         	{
         		_setBrushPosFunc =
         			(_setBrushPos)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_setBrushPos"), typeof(_setBrushPos));
         	}
         
         	 _setBrushPosFunc(thisPtr, pos);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setAction(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string action_name);
         private static _setAction _setActionFunc;
         internal static void setAction(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string action_name)
         {
         	if (_setActionFunc == null)
         	{
         		_setActionFunc =
         			(_setAction)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_setAction"), typeof(_setAction));
         	}
         
         	 _setActionFunc(thisPtr, action_name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getActionName(IntPtr thisPtr, uint index);
         private static _getActionName _getActionNameFunc;
         internal static IntPtr getActionName(IntPtr thisPtr, uint index)
         {
         	if (_getActionNameFunc == null)
         	{
         		_getActionNameFunc =
         			(_getActionName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_getActionName"), typeof(_getActionName));
         	}
         
         	return  _getActionNameFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getNumActions(IntPtr thisPtr);
         private static _getNumActions _getNumActionsFunc;
         internal static int getNumActions(IntPtr thisPtr)
         {
         	if (_getNumActionsFunc == null)
         	{
         		_getNumActionsFunc =
         			(_getNumActions)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_getNumActions"), typeof(_getNumActions));
         	}
         
         	return  _getNumActionsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getCurrentAction(IntPtr thisPtr);
         private static _getCurrentAction _getCurrentActionFunc;
         internal static IntPtr getCurrentAction(IntPtr thisPtr)
         {
         	if (_getCurrentActionFunc == null)
         	{
         		_getCurrentActionFunc =
         			(_getCurrentAction)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_getCurrentAction"), typeof(_getCurrentAction));
         	}
         
         	return  _getCurrentActionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _resetSelWeights(IntPtr thisPtr, bool clear);
         private static _resetSelWeights _resetSelWeightsFunc;
         internal static void resetSelWeights(IntPtr thisPtr, bool clear)
         {
         	if (_resetSelWeightsFunc == null)
         	{
         		_resetSelWeightsFunc =
         			(_resetSelWeights)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_resetSelWeights"), typeof(_resetSelWeights));
         	}
         
         	 _resetSelWeightsFunc(thisPtr, clear);
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
         				"fnTerrainEditor_clearSelection"), typeof(_clearSelection));
         	}
         
         	 _clearSelectionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _processAction(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string action);
         private static _processAction _processActionFunc;
         internal static void processAction(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string action)
         {
         	if (_processActionFunc == null)
         	{
         		_processActionFunc =
         			(_processAction)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_processAction"), typeof(_processAction));
         	}
         
         	 _processActionFunc(thisPtr, action);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getActiveTerrain(IntPtr thisPtr);
         private static _getActiveTerrain _getActiveTerrainFunc;
         internal static int getActiveTerrain(IntPtr thisPtr)
         {
         	if (_getActiveTerrainFunc == null)
         	{
         		_getActiveTerrainFunc =
         			(_getActiveTerrain)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_getActiveTerrain"), typeof(_getActiveTerrain));
         	}
         
         	return  _getActiveTerrainFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getNumTextures(IntPtr thisPtr);
         private static _getNumTextures _getNumTexturesFunc;
         internal static int getNumTextures(IntPtr thisPtr)
         {
         	if (_getNumTexturesFunc == null)
         	{
         		_getNumTexturesFunc =
         			(_getNumTextures)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_getNumTextures"), typeof(_getNumTextures));
         	}
         
         	return  _getNumTexturesFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _markEmptySquares(IntPtr thisPtr);
         private static _markEmptySquares _markEmptySquaresFunc;
         internal static void markEmptySquares(IntPtr thisPtr)
         {
         	if (_markEmptySquaresFunc == null)
         	{
         		_markEmptySquaresFunc =
         			(_markEmptySquares)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_markEmptySquares"), typeof(_markEmptySquares));
         	}
         
         	 _markEmptySquaresFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _mirrorTerrain(IntPtr thisPtr, int mirrorIndex);
         private static _mirrorTerrain _mirrorTerrainFunc;
         internal static void mirrorTerrain(IntPtr thisPtr, int mirrorIndex)
         {
         	if (_mirrorTerrainFunc == null)
         	{
         		_mirrorTerrainFunc =
         			(_mirrorTerrain)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_mirrorTerrain"), typeof(_mirrorTerrain));
         	}
         
         	 _mirrorTerrainFunc(thisPtr, mirrorIndex);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setTerraformOverlay(IntPtr thisPtr, bool overlayEnable);
         private static _setTerraformOverlay _setTerraformOverlayFunc;
         internal static void setTerraformOverlay(IntPtr thisPtr, bool overlayEnable)
         {
         	if (_setTerraformOverlayFunc == null)
         	{
         		_setTerraformOverlayFunc =
         			(_setTerraformOverlay)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_setTerraformOverlay"), typeof(_setTerraformOverlay));
         	}
         
         	 _setTerraformOverlayFunc(thisPtr, overlayEnable);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _updateMaterial(IntPtr thisPtr, uint index, [MarshalAs(UnmanagedType.LPWStr)]string matName);
         private static _updateMaterial _updateMaterialFunc;
         internal static bool updateMaterial(IntPtr thisPtr, uint index, [MarshalAs(UnmanagedType.LPWStr)]string matName)
         {
         	if (_updateMaterialFunc == null)
         	{
         		_updateMaterialFunc =
         			(_updateMaterial)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_updateMaterial"), typeof(_updateMaterial));
         	}
         
         	return  _updateMaterialFunc(thisPtr, index, matName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _addMaterial(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string matName);
         private static _addMaterial _addMaterialFunc;
         internal static int addMaterial(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string matName)
         {
         	if (_addMaterialFunc == null)
         	{
         		_addMaterialFunc =
         			(_addMaterial)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_addMaterial"), typeof(_addMaterial));
         	}
         
         	return  _addMaterialFunc(thisPtr, matName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeMaterial(IntPtr thisPtr, int index);
         private static _removeMaterial _removeMaterialFunc;
         internal static void removeMaterial(IntPtr thisPtr, int index)
         {
         	if (_removeMaterialFunc == null)
         	{
         		_removeMaterialFunc =
         			(_removeMaterial)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_removeMaterial"), typeof(_removeMaterial));
         	}
         
         	 _removeMaterialFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getMaterialCount(IntPtr thisPtr);
         private static _getMaterialCount _getMaterialCountFunc;
         internal static int getMaterialCount(IntPtr thisPtr)
         {
         	if (_getMaterialCountFunc == null)
         	{
         		_getMaterialCountFunc =
         			(_getMaterialCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_getMaterialCount"), typeof(_getMaterialCount));
         	}
         
         	return  _getMaterialCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getMaterials(IntPtr thisPtr);
         private static _getMaterials _getMaterialsFunc;
         internal static IntPtr getMaterials(IntPtr thisPtr)
         {
         	if (_getMaterialsFunc == null)
         	{
         		_getMaterialsFunc =
         			(_getMaterials)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_getMaterials"), typeof(_getMaterials));
         	}
         
         	return  _getMaterialsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getMaterialName(IntPtr thisPtr, int index);
         private static _getMaterialName _getMaterialNameFunc;
         internal static IntPtr getMaterialName(IntPtr thisPtr, int index)
         {
         	if (_getMaterialNameFunc == null)
         	{
         		_getMaterialNameFunc =
         			(_getMaterialName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_getMaterialName"), typeof(_getMaterialName));
         	}
         
         	return  _getMaterialNameFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getMaterialIndex(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _getMaterialIndex _getMaterialIndexFunc;
         internal static int getMaterialIndex(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_getMaterialIndexFunc == null)
         	{
         		_getMaterialIndexFunc =
         			(_getMaterialIndex)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_getMaterialIndex"), typeof(_getMaterialIndex));
         	}
         
         	return  _getMaterialIndexFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _reorderMaterial(IntPtr thisPtr, int index, int orderPos);
         private static _reorderMaterial _reorderMaterialFunc;
         internal static void reorderMaterial(IntPtr thisPtr, int index, int orderPos)
         {
         	if (_reorderMaterialFunc == null)
         	{
         		_reorderMaterialFunc =
         			(_reorderMaterial)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_reorderMaterial"), typeof(_reorderMaterial));
         	}
         
         	 _reorderMaterialFunc(thisPtr, index, orderPos);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getTerrainUnderWorldPoint(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string ptOrX, [MarshalAs(UnmanagedType.LPWStr)]string Y, [MarshalAs(UnmanagedType.LPWStr)]string Z);
         private static _getTerrainUnderWorldPoint _getTerrainUnderWorldPointFunc;
         internal static int getTerrainUnderWorldPoint(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string ptOrX, [MarshalAs(UnmanagedType.LPWStr)]string Y, [MarshalAs(UnmanagedType.LPWStr)]string Z)
         {
         	if (_getTerrainUnderWorldPointFunc == null)
         	{
         		_getTerrainUnderWorldPointFunc =
         			(_getTerrainUnderWorldPoint)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_getTerrainUnderWorldPoint"), typeof(_getTerrainUnderWorldPoint));
         	}
         
         	return  _getTerrainUnderWorldPointFunc(thisPtr, ptOrX, Y, Z);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getSlopeLimitMinAngle(IntPtr thisPtr);
         private static _getSlopeLimitMinAngle _getSlopeLimitMinAngleFunc;
         internal static float getSlopeLimitMinAngle(IntPtr thisPtr)
         {
         	if (_getSlopeLimitMinAngleFunc == null)
         	{
         		_getSlopeLimitMinAngleFunc =
         			(_getSlopeLimitMinAngle)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_getSlopeLimitMinAngle"), typeof(_getSlopeLimitMinAngle));
         	}
         
         	return  _getSlopeLimitMinAngleFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _setSlopeLimitMinAngle(IntPtr thisPtr, float angle);
         private static _setSlopeLimitMinAngle _setSlopeLimitMinAngleFunc;
         internal static float setSlopeLimitMinAngle(IntPtr thisPtr, float angle)
         {
         	if (_setSlopeLimitMinAngleFunc == null)
         	{
         		_setSlopeLimitMinAngleFunc =
         			(_setSlopeLimitMinAngle)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_setSlopeLimitMinAngle"), typeof(_setSlopeLimitMinAngle));
         	}
         
         	return  _setSlopeLimitMinAngleFunc(thisPtr, angle);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getSlopeLimitMaxAngle(IntPtr thisPtr);
         private static _getSlopeLimitMaxAngle _getSlopeLimitMaxAngleFunc;
         internal static float getSlopeLimitMaxAngle(IntPtr thisPtr)
         {
         	if (_getSlopeLimitMaxAngleFunc == null)
         	{
         		_getSlopeLimitMaxAngleFunc =
         			(_getSlopeLimitMaxAngle)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_getSlopeLimitMaxAngle"), typeof(_getSlopeLimitMaxAngle));
         	}
         
         	return  _getSlopeLimitMaxAngleFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _setSlopeLimitMaxAngle(IntPtr thisPtr, float angle);
         private static _setSlopeLimitMaxAngle _setSlopeLimitMaxAngleFunc;
         internal static float setSlopeLimitMaxAngle(IntPtr thisPtr, float angle)
         {
         	if (_setSlopeLimitMaxAngleFunc == null)
         	{
         		_setSlopeLimitMaxAngleFunc =
         			(_setSlopeLimitMaxAngle)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_setSlopeLimitMaxAngle"), typeof(_setSlopeLimitMaxAngle));
         	}
         
         	return  _setSlopeLimitMaxAngleFunc(thisPtr, angle);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _autoMaterialLayer(IntPtr thisPtr, float minHeight, float maxHeight, float minSlope, float maxSlope, float coverage);
         private static _autoMaterialLayer _autoMaterialLayerFunc;
         internal static void autoMaterialLayer(IntPtr thisPtr, float minHeight, float maxHeight, float minSlope, float maxSlope, float coverage)
         {
         	if (_autoMaterialLayerFunc == null)
         	{
         		_autoMaterialLayerFunc =
         			(_autoMaterialLayer)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainEditor_autoMaterialLayer"), typeof(_autoMaterialLayer));
         	}
         
         	 _autoMaterialLayerFunc(thisPtr, minHeight, maxHeight, minSlope, maxSlope, coverage);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _TerrainEditor_create();
         private static _TerrainEditor_create _TerrainEditor_createFunc;
         internal static IntPtr TerrainEditor_create()
         {
         	if (_TerrainEditor_createFunc == null)
         	{
         		_TerrainEditor_createFunc =
         			(_TerrainEditor_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_TerrainEditor_create"), typeof(_TerrainEditor_create));
         	}
         
         	return  _TerrainEditor_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void attachTerrain(string terrain = "")
         {
            InternalUnsafeMethods.attachTerrain(ObjectPtr, terrain);
         }
      
         public virtual int getTerrainBlockCount()
         {
            return InternalUnsafeMethods.getTerrainBlockCount(ObjectPtr);
         }
      
         public virtual int getTerrainBlock(int index)
         {
            return InternalUnsafeMethods.getTerrainBlock(ObjectPtr, index);
         }
      
         public virtual string getTerrainBlocksMaterialList()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getTerrainBlocksMaterialList(ObjectPtr));
         }
      
         public virtual void setBrushType(string type)
         {
            InternalUnsafeMethods.setBrushType(ObjectPtr, type);
         }
      
         public virtual string getBrushType()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getBrushType(ObjectPtr));
         }
      
         public virtual void setBrushSize(int w, int h = 0)
         {
            InternalUnsafeMethods.setBrushSize(ObjectPtr, w, h);
         }
      
         public virtual string getBrushSize()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getBrushSize(ObjectPtr));
         }
      
         public virtual void setBrushPressure(float pressure)
         {
            InternalUnsafeMethods.setBrushPressure(ObjectPtr, pressure);
         }
      
         public virtual float getBrushPressure()
         {
            return InternalUnsafeMethods.getBrushPressure(ObjectPtr);
         }
      
         public virtual void setBrushSoftness(float softness)
         {
            InternalUnsafeMethods.setBrushSoftness(ObjectPtr, softness);
         }
      
         public virtual float getBrushSoftness()
         {
            return InternalUnsafeMethods.getBrushSoftness(ObjectPtr);
         }
      
         public virtual string getBrushPos()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getBrushPos(ObjectPtr));
         }
      
         public virtual void setBrushPos(Point2I pos)
         {
            InternalUnsafeMethods.setBrushPos(ObjectPtr, pos.ToArray());
         }
      
         public virtual void setAction(string action_name)
         {
            InternalUnsafeMethods.setAction(ObjectPtr, action_name);
         }
      
         public virtual string getActionName(uint index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getActionName(ObjectPtr, index));
         }
      
         public virtual int getNumActions()
         {
            return InternalUnsafeMethods.getNumActions(ObjectPtr);
         }
      
         public virtual string getCurrentAction()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getCurrentAction(ObjectPtr));
         }
      
         public virtual void resetSelWeights(bool clear)
         {
            InternalUnsafeMethods.resetSelWeights(ObjectPtr, clear);
         }
      
         public virtual void clearSelection()
         {
            InternalUnsafeMethods.clearSelection(ObjectPtr);
         }
      
         public virtual void processAction(string action = "")
         {
            InternalUnsafeMethods.processAction(ObjectPtr, action);
         }
      
         public virtual int getActiveTerrain()
         {
            return InternalUnsafeMethods.getActiveTerrain(ObjectPtr);
         }
      
         public virtual int getNumTextures()
         {
            return InternalUnsafeMethods.getNumTextures(ObjectPtr);
         }
      
         public virtual void markEmptySquares()
         {
            InternalUnsafeMethods.markEmptySquares(ObjectPtr);
         }
      
         public virtual void mirrorTerrain(int mirrorIndex)
         {
            InternalUnsafeMethods.mirrorTerrain(ObjectPtr, mirrorIndex);
         }
      
         public virtual void setTerraformOverlay(bool overlayEnable)
         {
            InternalUnsafeMethods.setTerraformOverlay(ObjectPtr, overlayEnable);
         }
      
         public virtual bool updateMaterial(uint index, string matName)
         {
            return InternalUnsafeMethods.updateMaterial(ObjectPtr, index, matName);
         }
      
         public virtual int addMaterial(string matName)
         {
            return InternalUnsafeMethods.addMaterial(ObjectPtr, matName);
         }
      
         public virtual void removeMaterial(int index)
         {
            InternalUnsafeMethods.removeMaterial(ObjectPtr, index);
         }
      
         public virtual int getMaterialCount()
         {
            return InternalUnsafeMethods.getMaterialCount(ObjectPtr);
         }
      
         public virtual string getMaterials()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getMaterials(ObjectPtr));
         }
      
         public virtual string getMaterialName(int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getMaterialName(ObjectPtr, index));
         }
      
         public virtual int getMaterialIndex(string name)
         {
            return InternalUnsafeMethods.getMaterialIndex(ObjectPtr, name);
         }
      
         public virtual void reorderMaterial(int index, int orderPos)
         {
            InternalUnsafeMethods.reorderMaterial(ObjectPtr, index, orderPos);
         }
      
         public virtual int getTerrainUnderWorldPoint(string ptOrX = "", string Y = "", string Z = "")
         {
            return InternalUnsafeMethods.getTerrainUnderWorldPoint(ObjectPtr, ptOrX, Y, Z);
         }
      
         public virtual float getSlopeLimitMinAngle()
         {
            return InternalUnsafeMethods.getSlopeLimitMinAngle(ObjectPtr);
         }
      
         public virtual float setSlopeLimitMinAngle(float angle)
         {
            return InternalUnsafeMethods.setSlopeLimitMinAngle(ObjectPtr, angle);
         }
      
         public virtual float getSlopeLimitMaxAngle()
         {
            return InternalUnsafeMethods.getSlopeLimitMaxAngle(ObjectPtr);
         }
      
         public virtual float setSlopeLimitMaxAngle(float angle)
         {
            return InternalUnsafeMethods.setSlopeLimitMaxAngle(ObjectPtr, angle);
         }
      
         public virtual void autoMaterialLayer(float minHeight, float maxHeight, float minSlope, float maxSlope, float coverage)
         {
            InternalUnsafeMethods.autoMaterialLayer(ObjectPtr, minHeight, maxHeight, minSlope, maxSlope, coverage);
         }
      
      
      #endregion


      #region Properties
      
      
         public bool IsDirty
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsDirty")); }
         	set { setFieldValue("IsDirty", value ? "1" : "0"); }
         }
      
         public bool IsMissionDirty
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsMissionDirty")); }
         	set { setFieldValue("IsMissionDirty", value ? "1" : "0"); }
         }
      
         public bool RenderBorder
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderBorder")); }
         	set { setFieldValue("RenderBorder", value ? "1" : "0"); }
         }
      
         public float BorderHeight
         {
         	get { return float.Parse(getFieldValue("BorderHeight")); }
         	set { setFieldValue("BorderHeight", value.ToString()); }
         }
      
         public ColorI BorderFillColor
         {
         	get { return new ColorI(getFieldValue("BorderFillColor")); }
         	set { setFieldValue("BorderFillColor", value.ToString()); }
         }
      
         public ColorI BorderFrameColor
         {
         	get { return new ColorI(getFieldValue("BorderFrameColor")); }
         	set { setFieldValue("BorderFrameColor", value.ToString()); }
         }
      
         public bool BorderLineMode
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("BorderLineMode")); }
         	set { setFieldValue("BorderLineMode", value ? "1" : "0"); }
         }
      
         public bool SelectionHidden
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("SelectionHidden")); }
         	set { setFieldValue("SelectionHidden", value ? "1" : "0"); }
         }
      
         public bool RenderVertexSelection
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderVertexSelection")); }
         	set { setFieldValue("RenderVertexSelection", value ? "1" : "0"); }
         }
      
         public bool RenderSolidBrush
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderSolidBrush")); }
         	set { setFieldValue("RenderSolidBrush", value ? "1" : "0"); }
         }
      
         public bool ProcessUsesBrush
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ProcessUsesBrush")); }
         	set { setFieldValue("ProcessUsesBrush", value ? "1" : "0"); }
         }
      
         public Point2I MaxBrushSize
         {
         	get { return new Point2I(getFieldValue("MaxBrushSize")); }
         	set { setFieldValue("MaxBrushSize", value.ToString()); }
         }
      
         public float AdjustHeightVal
         {
         	get { return float.Parse(getFieldValue("AdjustHeightVal")); }
         	set { setFieldValue("AdjustHeightVal", value.ToString()); }
         }
      
         public float SetHeightVal
         {
         	get { return float.Parse(getFieldValue("SetHeightVal")); }
         	set { setFieldValue("SetHeightVal", value.ToString()); }
         }
      
         public float ScaleVal
         {
         	get { return float.Parse(getFieldValue("ScaleVal")); }
         	set { setFieldValue("ScaleVal", value.ToString()); }
         }
      
         public float SmoothFactor
         {
         	get { return float.Parse(getFieldValue("SmoothFactor")); }
         	set { setFieldValue("SmoothFactor", value.ToString()); }
         }
      
         public float NoiseFactor
         {
         	get { return float.Parse(getFieldValue("NoiseFactor")); }
         	set { setFieldValue("NoiseFactor", value.ToString()); }
         }
      
         public int MaterialGroup
         {
         	get { return int.Parse(getFieldValue("MaterialGroup")); }
         	set { setFieldValue("MaterialGroup", value.ToString()); }
         }
      
         public float SoftSelectRadius
         {
         	get { return float.Parse(getFieldValue("SoftSelectRadius")); }
         	set { setFieldValue("SoftSelectRadius", value.ToString()); }
         }
      
         public string SoftSelectFilter
         {
         	get { return getFieldValue("SoftSelectFilter"); }
         	set { setFieldValue("SoftSelectFilter", value); }
         }
      
         public string SoftSelectDefaultFilter
         {
         	get { return getFieldValue("SoftSelectDefaultFilter"); }
         	set { setFieldValue("SoftSelectDefaultFilter", value); }
         }
      
         public float AdjustHeightMouseScale
         {
         	get { return float.Parse(getFieldValue("AdjustHeightMouseScale")); }
         	set { setFieldValue("AdjustHeightMouseScale", value.ToString()); }
         }
      
         public int PaintIndex
         {
         	get { return int.Parse(getFieldValue("PaintIndex")); }
         	set { setFieldValue("PaintIndex", value.ToString()); }
         }
      
      
      #endregion

	}
}