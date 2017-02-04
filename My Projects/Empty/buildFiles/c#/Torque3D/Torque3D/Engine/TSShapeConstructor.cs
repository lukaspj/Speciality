using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class TSShapeConstructor : SimObject
	{
		public TSShapeConstructor(bool pRegister = false)
			: base(pRegister)
		{
		}

		public TSShapeConstructor(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public TSShapeConstructor(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public TSShapeConstructor(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public TSShapeConstructor(SimObject pObj) : base(pObj)
		{
		}

		public TSShapeConstructor(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.TSShapeConstructor_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _addPrimitive(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string meshName, [MarshalAs(UnmanagedType.LPWStr)]string type, [MarshalAs(UnmanagedType.LPWStr)]string _params, InternalTransformFStruct txfm, [MarshalAs(UnmanagedType.LPWStr)]string nodeName);
         private static _addPrimitive _addPrimitiveFunc;
         internal static bool addPrimitive(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string meshName, [MarshalAs(UnmanagedType.LPWStr)]string type, [MarshalAs(UnmanagedType.LPWStr)]string _params, InternalTransformFStruct txfm, [MarshalAs(UnmanagedType.LPWStr)]string nodeName)
         {
         	if (_addPrimitiveFunc == null)
         	{
         		_addPrimitiveFunc =
         			(_addPrimitive)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_addPrimitive"), typeof(_addPrimitive));
         	}
         
         	return  _addPrimitiveFunc(thisPtr, meshName, type, _params, txfm, nodeName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _addCollisionDetail(IntPtr thisPtr, int size, [MarshalAs(UnmanagedType.LPWStr)]string type, [MarshalAs(UnmanagedType.LPWStr)]string target, int depth, float merge, float concavity, int maxVerts, float boxMaxError, float sphereMaxError, float capsuleMaxError);
         private static _addCollisionDetail _addCollisionDetailFunc;
         internal static bool addCollisionDetail(IntPtr thisPtr, int size, [MarshalAs(UnmanagedType.LPWStr)]string type, [MarshalAs(UnmanagedType.LPWStr)]string target, int depth, float merge, float concavity, int maxVerts, float boxMaxError, float sphereMaxError, float capsuleMaxError)
         {
         	if (_addCollisionDetailFunc == null)
         	{
         		_addCollisionDetailFunc =
         			(_addCollisionDetail)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_addCollisionDetail"), typeof(_addCollisionDetail));
         	}
         
         	return  _addCollisionDetailFunc(thisPtr, size, type, target, depth, merge, concavity, maxVerts, boxMaxError, sphereMaxError, capsuleMaxError);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _dumpShape(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename);
         private static _dumpShape _dumpShapeFunc;
         internal static void dumpShape(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename)
         {
         	if (_dumpShapeFunc == null)
         	{
         		_dumpShapeFunc =
         			(_dumpShape)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_dumpShape"), typeof(_dumpShape));
         	}
         
         	 _dumpShapeFunc(thisPtr, filename);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _saveShape(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename);
         private static _saveShape _saveShapeFunc;
         internal static void saveShape(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filename)
         {
         	if (_saveShapeFunc == null)
         	{
         		_saveShapeFunc =
         			(_saveShape)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_saveShape"), typeof(_saveShape));
         	}
         
         	 _saveShapeFunc(thisPtr, filename);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _writeChangeSet(IntPtr thisPtr);
         private static _writeChangeSet _writeChangeSetFunc;
         internal static void writeChangeSet(IntPtr thisPtr)
         {
         	if (_writeChangeSetFunc == null)
         	{
         		_writeChangeSetFunc =
         			(_writeChangeSet)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_writeChangeSet"), typeof(_writeChangeSet));
         	}
         
         	 _writeChangeSetFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _notifyShapeChanged(IntPtr thisPtr);
         private static _notifyShapeChanged _notifyShapeChangedFunc;
         internal static void notifyShapeChanged(IntPtr thisPtr)
         {
         	if (_notifyShapeChangedFunc == null)
         	{
         		_notifyShapeChangedFunc =
         			(_notifyShapeChanged)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_notifyShapeChanged"), typeof(_notifyShapeChanged));
         	}
         
         	 _notifyShapeChangedFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getNodeCount(IntPtr thisPtr);
         private static _getNodeCount _getNodeCountFunc;
         internal static int getNodeCount(IntPtr thisPtr)
         {
         	if (_getNodeCountFunc == null)
         	{
         		_getNodeCountFunc =
         			(_getNodeCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getNodeCount"), typeof(_getNodeCount));
         	}
         
         	return  _getNodeCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getNodeIndex(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _getNodeIndex _getNodeIndexFunc;
         internal static int getNodeIndex(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_getNodeIndexFunc == null)
         	{
         		_getNodeIndexFunc =
         			(_getNodeIndex)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getNodeIndex"), typeof(_getNodeIndex));
         	}
         
         	return  _getNodeIndexFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getNodeName(IntPtr thisPtr, int index);
         private static _getNodeName _getNodeNameFunc;
         internal static IntPtr getNodeName(IntPtr thisPtr, int index)
         {
         	if (_getNodeNameFunc == null)
         	{
         		_getNodeNameFunc =
         			(_getNodeName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getNodeName"), typeof(_getNodeName));
         	}
         
         	return  _getNodeNameFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getNodeParentName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _getNodeParentName _getNodeParentNameFunc;
         internal static IntPtr getNodeParentName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_getNodeParentNameFunc == null)
         	{
         		_getNodeParentNameFunc =
         			(_getNodeParentName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getNodeParentName"), typeof(_getNodeParentName));
         	}
         
         	return  _getNodeParentNameFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setNodeParent(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, [MarshalAs(UnmanagedType.LPWStr)]string parentName);
         private static _setNodeParent _setNodeParentFunc;
         internal static bool setNodeParent(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, [MarshalAs(UnmanagedType.LPWStr)]string parentName)
         {
         	if (_setNodeParentFunc == null)
         	{
         		_setNodeParentFunc =
         			(_setNodeParent)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_setNodeParent"), typeof(_setNodeParent));
         	}
         
         	return  _setNodeParentFunc(thisPtr, name, parentName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getNodeChildCount(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _getNodeChildCount _getNodeChildCountFunc;
         internal static int getNodeChildCount(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_getNodeChildCountFunc == null)
         	{
         		_getNodeChildCountFunc =
         			(_getNodeChildCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getNodeChildCount"), typeof(_getNodeChildCount));
         	}
         
         	return  _getNodeChildCountFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getNodeChildName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, int index);
         private static _getNodeChildName _getNodeChildNameFunc;
         internal static IntPtr getNodeChildName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, int index)
         {
         	if (_getNodeChildNameFunc == null)
         	{
         		_getNodeChildNameFunc =
         			(_getNodeChildName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getNodeChildName"), typeof(_getNodeChildName));
         	}
         
         	return  _getNodeChildNameFunc(thisPtr, name, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getNodeObjectCount(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _getNodeObjectCount _getNodeObjectCountFunc;
         internal static int getNodeObjectCount(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_getNodeObjectCountFunc == null)
         	{
         		_getNodeObjectCountFunc =
         			(_getNodeObjectCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getNodeObjectCount"), typeof(_getNodeObjectCount));
         	}
         
         	return  _getNodeObjectCountFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getNodeObjectName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, int index);
         private static _getNodeObjectName _getNodeObjectNameFunc;
         internal static IntPtr getNodeObjectName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, int index)
         {
         	if (_getNodeObjectNameFunc == null)
         	{
         		_getNodeObjectNameFunc =
         			(_getNodeObjectName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getNodeObjectName"), typeof(_getNodeObjectName));
         	}
         
         	return  _getNodeObjectNameFunc(thisPtr, name, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalTransformFStruct _getNodeTransform(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, bool isWorld);
         private static _getNodeTransform _getNodeTransformFunc;
         internal static InternalTransformFStruct getNodeTransform(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, bool isWorld)
         {
         	if (_getNodeTransformFunc == null)
         	{
         		_getNodeTransformFunc =
         			(_getNodeTransform)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getNodeTransform"), typeof(_getNodeTransform));
         	}
         
         	return  _getNodeTransformFunc(thisPtr, name, isWorld);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setNodeTransform(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, InternalTransformFStruct txfm, bool isWorld);
         private static _setNodeTransform _setNodeTransformFunc;
         internal static bool setNodeTransform(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, InternalTransformFStruct txfm, bool isWorld)
         {
         	if (_setNodeTransformFunc == null)
         	{
         		_setNodeTransformFunc =
         			(_setNodeTransform)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_setNodeTransform"), typeof(_setNodeTransform));
         	}
         
         	return  _setNodeTransformFunc(thisPtr, name, txfm, isWorld);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _renameNode(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string oldName, [MarshalAs(UnmanagedType.LPWStr)]string newName);
         private static _renameNode _renameNodeFunc;
         internal static bool renameNode(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string oldName, [MarshalAs(UnmanagedType.LPWStr)]string newName)
         {
         	if (_renameNodeFunc == null)
         	{
         		_renameNodeFunc =
         			(_renameNode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_renameNode"), typeof(_renameNode));
         	}
         
         	return  _renameNodeFunc(thisPtr, oldName, newName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _addNode(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, [MarshalAs(UnmanagedType.LPWStr)]string parentName, InternalTransformFStruct txfm, bool isWorld);
         private static _addNode _addNodeFunc;
         internal static bool addNode(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, [MarshalAs(UnmanagedType.LPWStr)]string parentName, InternalTransformFStruct txfm, bool isWorld)
         {
         	if (_addNodeFunc == null)
         	{
         		_addNodeFunc =
         			(_addNode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_addNode"), typeof(_addNode));
         	}
         
         	return  _addNodeFunc(thisPtr, name, parentName, txfm, isWorld);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _removeNode(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _removeNode _removeNodeFunc;
         internal static bool removeNode(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_removeNodeFunc == null)
         	{
         		_removeNodeFunc =
         			(_removeNode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_removeNode"), typeof(_removeNode));
         	}
         
         	return  _removeNodeFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getTargetCount(IntPtr thisPtr);
         private static _getTargetCount _getTargetCountFunc;
         internal static int getTargetCount(IntPtr thisPtr)
         {
         	if (_getTargetCountFunc == null)
         	{
         		_getTargetCountFunc =
         			(_getTargetCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getTargetCount"), typeof(_getTargetCount));
         	}
         
         	return  _getTargetCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getTargetName(IntPtr thisPtr, int index);
         private static _getTargetName _getTargetNameFunc;
         internal static IntPtr getTargetName(IntPtr thisPtr, int index)
         {
         	if (_getTargetNameFunc == null)
         	{
         		_getTargetNameFunc =
         			(_getTargetName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getTargetName"), typeof(_getTargetName));
         	}
         
         	return  _getTargetNameFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getObjectCount(IntPtr thisPtr);
         private static _getObjectCount _getObjectCountFunc;
         internal static int getObjectCount(IntPtr thisPtr)
         {
         	if (_getObjectCountFunc == null)
         	{
         		_getObjectCountFunc =
         			(_getObjectCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getObjectCount"), typeof(_getObjectCount));
         	}
         
         	return  _getObjectCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getObjectName(IntPtr thisPtr, int index);
         private static _getObjectName _getObjectNameFunc;
         internal static IntPtr getObjectName(IntPtr thisPtr, int index)
         {
         	if (_getObjectNameFunc == null)
         	{
         		_getObjectNameFunc =
         			(_getObjectName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getObjectName"), typeof(_getObjectName));
         	}
         
         	return  _getObjectNameFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getObjectIndex(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _getObjectIndex _getObjectIndexFunc;
         internal static int getObjectIndex(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_getObjectIndexFunc == null)
         	{
         		_getObjectIndexFunc =
         			(_getObjectIndex)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getObjectIndex"), typeof(_getObjectIndex));
         	}
         
         	return  _getObjectIndexFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getObjectNode(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _getObjectNode _getObjectNodeFunc;
         internal static IntPtr getObjectNode(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_getObjectNodeFunc == null)
         	{
         		_getObjectNodeFunc =
         			(_getObjectNode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getObjectNode"), typeof(_getObjectNode));
         	}
         
         	return  _getObjectNodeFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setObjectNode(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string objName, [MarshalAs(UnmanagedType.LPWStr)]string nodeName);
         private static _setObjectNode _setObjectNodeFunc;
         internal static bool setObjectNode(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string objName, [MarshalAs(UnmanagedType.LPWStr)]string nodeName)
         {
         	if (_setObjectNodeFunc == null)
         	{
         		_setObjectNodeFunc =
         			(_setObjectNode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_setObjectNode"), typeof(_setObjectNode));
         	}
         
         	return  _setObjectNodeFunc(thisPtr, objName, nodeName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _renameObject(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string oldName, [MarshalAs(UnmanagedType.LPWStr)]string newName);
         private static _renameObject _renameObjectFunc;
         internal static bool renameObject(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string oldName, [MarshalAs(UnmanagedType.LPWStr)]string newName)
         {
         	if (_renameObjectFunc == null)
         	{
         		_renameObjectFunc =
         			(_renameObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_renameObject"), typeof(_renameObject));
         	}
         
         	return  _renameObjectFunc(thisPtr, oldName, newName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _removeObject(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _removeObject _removeObjectFunc;
         internal static bool removeObject(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_removeObjectFunc == null)
         	{
         		_removeObjectFunc =
         			(_removeObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_removeObject"), typeof(_removeObject));
         	}
         
         	return  _removeObjectFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getMeshCount(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _getMeshCount _getMeshCountFunc;
         internal static int getMeshCount(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_getMeshCountFunc == null)
         	{
         		_getMeshCountFunc =
         			(_getMeshCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getMeshCount"), typeof(_getMeshCount));
         	}
         
         	return  _getMeshCountFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getMeshName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, int index);
         private static _getMeshName _getMeshNameFunc;
         internal static IntPtr getMeshName(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, int index)
         {
         	if (_getMeshNameFunc == null)
         	{
         		_getMeshNameFunc =
         			(_getMeshName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getMeshName"), typeof(_getMeshName));
         	}
         
         	return  _getMeshNameFunc(thisPtr, name, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getMeshSize(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, int index);
         private static _getMeshSize _getMeshSizeFunc;
         internal static int getMeshSize(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, int index)
         {
         	if (_getMeshSizeFunc == null)
         	{
         		_getMeshSizeFunc =
         			(_getMeshSize)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getMeshSize"), typeof(_getMeshSize));
         	}
         
         	return  _getMeshSizeFunc(thisPtr, name, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setMeshSize(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, int size);
         private static _setMeshSize _setMeshSizeFunc;
         internal static bool setMeshSize(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, int size)
         {
         	if (_setMeshSizeFunc == null)
         	{
         		_setMeshSizeFunc =
         			(_setMeshSize)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_setMeshSize"), typeof(_setMeshSize));
         	}
         
         	return  _setMeshSizeFunc(thisPtr, name, size);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getMeshType(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _getMeshType _getMeshTypeFunc;
         internal static IntPtr getMeshType(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_getMeshTypeFunc == null)
         	{
         		_getMeshTypeFunc =
         			(_getMeshType)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getMeshType"), typeof(_getMeshType));
         	}
         
         	return  _getMeshTypeFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setMeshType(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, [MarshalAs(UnmanagedType.LPWStr)]string type);
         private static _setMeshType _setMeshTypeFunc;
         internal static bool setMeshType(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, [MarshalAs(UnmanagedType.LPWStr)]string type)
         {
         	if (_setMeshTypeFunc == null)
         	{
         		_setMeshTypeFunc =
         			(_setMeshType)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_setMeshType"), typeof(_setMeshType));
         	}
         
         	return  _setMeshTypeFunc(thisPtr, name, type);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getMeshMaterial(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _getMeshMaterial _getMeshMaterialFunc;
         internal static IntPtr getMeshMaterial(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_getMeshMaterialFunc == null)
         	{
         		_getMeshMaterialFunc =
         			(_getMeshMaterial)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getMeshMaterial"), typeof(_getMeshMaterial));
         	}
         
         	return  _getMeshMaterialFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setMeshMaterial(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string meshName, [MarshalAs(UnmanagedType.LPWStr)]string matName);
         private static _setMeshMaterial _setMeshMaterialFunc;
         internal static bool setMeshMaterial(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string meshName, [MarshalAs(UnmanagedType.LPWStr)]string matName)
         {
         	if (_setMeshMaterialFunc == null)
         	{
         		_setMeshMaterialFunc =
         			(_setMeshMaterial)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_setMeshMaterial"), typeof(_setMeshMaterial));
         	}
         
         	return  _setMeshMaterialFunc(thisPtr, meshName, matName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _addMesh(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string meshName, [MarshalAs(UnmanagedType.LPWStr)]string srcShape, [MarshalAs(UnmanagedType.LPWStr)]string srcMesh);
         private static _addMesh _addMeshFunc;
         internal static bool addMesh(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string meshName, [MarshalAs(UnmanagedType.LPWStr)]string srcShape, [MarshalAs(UnmanagedType.LPWStr)]string srcMesh)
         {
         	if (_addMeshFunc == null)
         	{
         		_addMeshFunc =
         			(_addMesh)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_addMesh"), typeof(_addMesh));
         	}
         
         	return  _addMeshFunc(thisPtr, meshName, srcShape, srcMesh);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _removeMesh(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _removeMesh _removeMeshFunc;
         internal static bool removeMesh(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_removeMeshFunc == null)
         	{
         		_removeMeshFunc =
         			(_removeMesh)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_removeMesh"), typeof(_removeMesh));
         	}
         
         	return  _removeMeshFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalBox3FStruct _getBounds(IntPtr thisPtr);
         private static _getBounds _getBoundsFunc;
         internal static InternalBox3FStruct getBounds(IntPtr thisPtr)
         {
         	if (_getBoundsFunc == null)
         	{
         		_getBoundsFunc =
         			(_getBounds)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getBounds"), typeof(_getBounds));
         	}
         
         	return  _getBoundsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setBounds(IntPtr thisPtr, InternalBox3FStruct bbox);
         private static _setBounds _setBoundsFunc;
         internal static bool setBounds(IntPtr thisPtr, InternalBox3FStruct bbox)
         {
         	if (_setBoundsFunc == null)
         	{
         		_setBoundsFunc =
         			(_setBounds)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_setBounds"), typeof(_setBounds));
         	}
         
         	return  _setBoundsFunc(thisPtr, bbox);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getDetailLevelCount(IntPtr thisPtr);
         private static _getDetailLevelCount _getDetailLevelCountFunc;
         internal static int getDetailLevelCount(IntPtr thisPtr)
         {
         	if (_getDetailLevelCountFunc == null)
         	{
         		_getDetailLevelCountFunc =
         			(_getDetailLevelCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getDetailLevelCount"), typeof(_getDetailLevelCount));
         	}
         
         	return  _getDetailLevelCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getDetailLevelName(IntPtr thisPtr, int index);
         private static _getDetailLevelName _getDetailLevelNameFunc;
         internal static IntPtr getDetailLevelName(IntPtr thisPtr, int index)
         {
         	if (_getDetailLevelNameFunc == null)
         	{
         		_getDetailLevelNameFunc =
         			(_getDetailLevelName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getDetailLevelName"), typeof(_getDetailLevelName));
         	}
         
         	return  _getDetailLevelNameFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getDetailLevelSize(IntPtr thisPtr, int index);
         private static _getDetailLevelSize _getDetailLevelSizeFunc;
         internal static int getDetailLevelSize(IntPtr thisPtr, int index)
         {
         	if (_getDetailLevelSizeFunc == null)
         	{
         		_getDetailLevelSizeFunc =
         			(_getDetailLevelSize)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getDetailLevelSize"), typeof(_getDetailLevelSize));
         	}
         
         	return  _getDetailLevelSizeFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getDetailLevelIndex(IntPtr thisPtr, int size);
         private static _getDetailLevelIndex _getDetailLevelIndexFunc;
         internal static int getDetailLevelIndex(IntPtr thisPtr, int size)
         {
         	if (_getDetailLevelIndexFunc == null)
         	{
         		_getDetailLevelIndexFunc =
         			(_getDetailLevelIndex)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getDetailLevelIndex"), typeof(_getDetailLevelIndex));
         	}
         
         	return  _getDetailLevelIndexFunc(thisPtr, size);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _renameDetailLevel(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string oldName, [MarshalAs(UnmanagedType.LPWStr)]string newName);
         private static _renameDetailLevel _renameDetailLevelFunc;
         internal static bool renameDetailLevel(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string oldName, [MarshalAs(UnmanagedType.LPWStr)]string newName)
         {
         	if (_renameDetailLevelFunc == null)
         	{
         		_renameDetailLevelFunc =
         			(_renameDetailLevel)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_renameDetailLevel"), typeof(_renameDetailLevel));
         	}
         
         	return  _renameDetailLevelFunc(thisPtr, oldName, newName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _removeDetailLevel(IntPtr thisPtr, int index);
         private static _removeDetailLevel _removeDetailLevelFunc;
         internal static bool removeDetailLevel(IntPtr thisPtr, int index)
         {
         	if (_removeDetailLevelFunc == null)
         	{
         		_removeDetailLevelFunc =
         			(_removeDetailLevel)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_removeDetailLevel"), typeof(_removeDetailLevel));
         	}
         
         	return  _removeDetailLevelFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _setDetailLevelSize(IntPtr thisPtr, int index, int newSize);
         private static _setDetailLevelSize _setDetailLevelSizeFunc;
         internal static int setDetailLevelSize(IntPtr thisPtr, int index, int newSize)
         {
         	if (_setDetailLevelSizeFunc == null)
         	{
         		_setDetailLevelSizeFunc =
         			(_setDetailLevelSize)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_setDetailLevelSize"), typeof(_setDetailLevelSize));
         	}
         
         	return  _setDetailLevelSizeFunc(thisPtr, index, newSize);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getImposterDetailLevel(IntPtr thisPtr);
         private static _getImposterDetailLevel _getImposterDetailLevelFunc;
         internal static int getImposterDetailLevel(IntPtr thisPtr)
         {
         	if (_getImposterDetailLevelFunc == null)
         	{
         		_getImposterDetailLevelFunc =
         			(_getImposterDetailLevel)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getImposterDetailLevel"), typeof(_getImposterDetailLevel));
         	}
         
         	return  _getImposterDetailLevelFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getImposterSettings(IntPtr thisPtr, int index);
         private static _getImposterSettings _getImposterSettingsFunc;
         internal static IntPtr getImposterSettings(IntPtr thisPtr, int index)
         {
         	if (_getImposterSettingsFunc == null)
         	{
         		_getImposterSettingsFunc =
         			(_getImposterSettings)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getImposterSettings"), typeof(_getImposterSettings));
         	}
         
         	return  _getImposterSettingsFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _addImposter(IntPtr thisPtr, int size, int equatorSteps, int polarSteps, int dl, int dim, bool includePoles, float polarAngle);
         private static _addImposter _addImposterFunc;
         internal static int addImposter(IntPtr thisPtr, int size, int equatorSteps, int polarSteps, int dl, int dim, bool includePoles, float polarAngle)
         {
         	if (_addImposterFunc == null)
         	{
         		_addImposterFunc =
         			(_addImposter)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_addImposter"), typeof(_addImposter));
         	}
         
         	return  _addImposterFunc(thisPtr, size, equatorSteps, polarSteps, dl, dim, includePoles, polarAngle);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _removeImposter(IntPtr thisPtr);
         private static _removeImposter _removeImposterFunc;
         internal static bool removeImposter(IntPtr thisPtr)
         {
         	if (_removeImposterFunc == null)
         	{
         		_removeImposterFunc =
         			(_removeImposter)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_removeImposter"), typeof(_removeImposter));
         	}
         
         	return  _removeImposterFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getSequenceCount(IntPtr thisPtr);
         private static _getSequenceCount _getSequenceCountFunc;
         internal static int getSequenceCount(IntPtr thisPtr)
         {
         	if (_getSequenceCountFunc == null)
         	{
         		_getSequenceCountFunc =
         			(_getSequenceCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getSequenceCount"), typeof(_getSequenceCount));
         	}
         
         	return  _getSequenceCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getSequenceIndex(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _getSequenceIndex _getSequenceIndexFunc;
         internal static int getSequenceIndex(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_getSequenceIndexFunc == null)
         	{
         		_getSequenceIndexFunc =
         			(_getSequenceIndex)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getSequenceIndex"), typeof(_getSequenceIndex));
         	}
         
         	return  _getSequenceIndexFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getSequenceName(IntPtr thisPtr, int index);
         private static _getSequenceName _getSequenceNameFunc;
         internal static IntPtr getSequenceName(IntPtr thisPtr, int index)
         {
         	if (_getSequenceNameFunc == null)
         	{
         		_getSequenceNameFunc =
         			(_getSequenceName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getSequenceName"), typeof(_getSequenceName));
         	}
         
         	return  _getSequenceNameFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getSequenceSource(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _getSequenceSource _getSequenceSourceFunc;
         internal static IntPtr getSequenceSource(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_getSequenceSourceFunc == null)
         	{
         		_getSequenceSourceFunc =
         			(_getSequenceSource)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getSequenceSource"), typeof(_getSequenceSource));
         	}
         
         	return  _getSequenceSourceFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getSequenceFrameCount(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _getSequenceFrameCount _getSequenceFrameCountFunc;
         internal static int getSequenceFrameCount(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_getSequenceFrameCountFunc == null)
         	{
         		_getSequenceFrameCountFunc =
         			(_getSequenceFrameCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getSequenceFrameCount"), typeof(_getSequenceFrameCount));
         	}
         
         	return  _getSequenceFrameCountFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getSequencePriority(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _getSequencePriority _getSequencePriorityFunc;
         internal static float getSequencePriority(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_getSequencePriorityFunc == null)
         	{
         		_getSequencePriorityFunc =
         			(_getSequencePriority)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getSequencePriority"), typeof(_getSequencePriority));
         	}
         
         	return  _getSequencePriorityFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setSequencePriority(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, float priority);
         private static _setSequencePriority _setSequencePriorityFunc;
         internal static bool setSequencePriority(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, float priority)
         {
         	if (_setSequencePriorityFunc == null)
         	{
         		_setSequencePriorityFunc =
         			(_setSequencePriority)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_setSequencePriority"), typeof(_setSequencePriority));
         	}
         
         	return  _setSequencePriorityFunc(thisPtr, name, priority);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getSequenceGroundSpeed(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _getSequenceGroundSpeed _getSequenceGroundSpeedFunc;
         internal static IntPtr getSequenceGroundSpeed(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_getSequenceGroundSpeedFunc == null)
         	{
         		_getSequenceGroundSpeedFunc =
         			(_getSequenceGroundSpeed)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getSequenceGroundSpeed"), typeof(_getSequenceGroundSpeed));
         	}
         
         	return  _getSequenceGroundSpeedFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setSequenceGroundSpeed(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, InternalPoint3FStruct transSpeed, InternalPoint3FStruct rotSpeed);
         private static _setSequenceGroundSpeed _setSequenceGroundSpeedFunc;
         internal static bool setSequenceGroundSpeed(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, InternalPoint3FStruct transSpeed, InternalPoint3FStruct rotSpeed)
         {
         	if (_setSequenceGroundSpeedFunc == null)
         	{
         		_setSequenceGroundSpeedFunc =
         			(_setSequenceGroundSpeed)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_setSequenceGroundSpeed"), typeof(_setSequenceGroundSpeed));
         	}
         
         	return  _setSequenceGroundSpeedFunc(thisPtr, name, transSpeed, rotSpeed);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getSequenceCyclic(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _getSequenceCyclic _getSequenceCyclicFunc;
         internal static bool getSequenceCyclic(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_getSequenceCyclicFunc == null)
         	{
         		_getSequenceCyclicFunc =
         			(_getSequenceCyclic)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getSequenceCyclic"), typeof(_getSequenceCyclic));
         	}
         
         	return  _getSequenceCyclicFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setSequenceCyclic(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, bool cyclic);
         private static _setSequenceCyclic _setSequenceCyclicFunc;
         internal static bool setSequenceCyclic(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, bool cyclic)
         {
         	if (_setSequenceCyclicFunc == null)
         	{
         		_setSequenceCyclicFunc =
         			(_setSequenceCyclic)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_setSequenceCyclic"), typeof(_setSequenceCyclic));
         	}
         
         	return  _setSequenceCyclicFunc(thisPtr, name, cyclic);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getSequenceBlend(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _getSequenceBlend _getSequenceBlendFunc;
         internal static IntPtr getSequenceBlend(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_getSequenceBlendFunc == null)
         	{
         		_getSequenceBlendFunc =
         			(_getSequenceBlend)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getSequenceBlend"), typeof(_getSequenceBlend));
         	}
         
         	return  _getSequenceBlendFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setSequenceBlend(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, bool blend, [MarshalAs(UnmanagedType.LPWStr)]string blendSeq, int blendFrame);
         private static _setSequenceBlend _setSequenceBlendFunc;
         internal static bool setSequenceBlend(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, bool blend, [MarshalAs(UnmanagedType.LPWStr)]string blendSeq, int blendFrame)
         {
         	if (_setSequenceBlendFunc == null)
         	{
         		_setSequenceBlendFunc =
         			(_setSequenceBlend)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_setSequenceBlend"), typeof(_setSequenceBlend));
         	}
         
         	return  _setSequenceBlendFunc(thisPtr, name, blend, blendSeq, blendFrame);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _renameSequence(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string oldName, [MarshalAs(UnmanagedType.LPWStr)]string newName);
         private static _renameSequence _renameSequenceFunc;
         internal static bool renameSequence(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string oldName, [MarshalAs(UnmanagedType.LPWStr)]string newName)
         {
         	if (_renameSequenceFunc == null)
         	{
         		_renameSequenceFunc =
         			(_renameSequence)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_renameSequence"), typeof(_renameSequence));
         	}
         
         	return  _renameSequenceFunc(thisPtr, oldName, newName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _addSequence(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string source, [MarshalAs(UnmanagedType.LPWStr)]string name, int start, int end, bool padRot, bool padTrans);
         private static _addSequence _addSequenceFunc;
         internal static bool addSequence(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string source, [MarshalAs(UnmanagedType.LPWStr)]string name, int start, int end, bool padRot, bool padTrans)
         {
         	if (_addSequenceFunc == null)
         	{
         		_addSequenceFunc =
         			(_addSequence)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_addSequence"), typeof(_addSequence));
         	}
         
         	return  _addSequenceFunc(thisPtr, source, name, start, end, padRot, padTrans);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _removeSequence(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _removeSequence _removeSequenceFunc;
         internal static bool removeSequence(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_removeSequenceFunc == null)
         	{
         		_removeSequenceFunc =
         			(_removeSequence)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_removeSequence"), typeof(_removeSequence));
         	}
         
         	return  _removeSequenceFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getTriggerCount(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _getTriggerCount _getTriggerCountFunc;
         internal static int getTriggerCount(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_getTriggerCountFunc == null)
         	{
         		_getTriggerCountFunc =
         			(_getTriggerCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getTriggerCount"), typeof(_getTriggerCount));
         	}
         
         	return  _getTriggerCountFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getTrigger(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, int index);
         private static _getTrigger _getTriggerFunc;
         internal static IntPtr getTrigger(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, int index)
         {
         	if (_getTriggerFunc == null)
         	{
         		_getTriggerFunc =
         			(_getTrigger)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_getTrigger"), typeof(_getTrigger));
         	}
         
         	return  _getTriggerFunc(thisPtr, name, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _addTrigger(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, int keyframe, int state);
         private static _addTrigger _addTriggerFunc;
         internal static bool addTrigger(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, int keyframe, int state)
         {
         	if (_addTriggerFunc == null)
         	{
         		_addTriggerFunc =
         			(_addTrigger)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_addTrigger"), typeof(_addTrigger));
         	}
         
         	return  _addTriggerFunc(thisPtr, name, keyframe, state);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _removeTrigger(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, int keyframe, int state);
         private static _removeTrigger _removeTriggerFunc;
         internal static bool removeTrigger(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, int keyframe, int state)
         {
         	if (_removeTriggerFunc == null)
         	{
         		_removeTriggerFunc =
         			(_removeTrigger)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTSShapeConstructor_removeTrigger"), typeof(_removeTrigger));
         	}
         
         	return  _removeTriggerFunc(thisPtr, name, keyframe, state);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _TSShapeConstructor_create();
         private static _TSShapeConstructor_create _TSShapeConstructor_createFunc;
         internal static IntPtr TSShapeConstructor_create()
         {
         	if (_TSShapeConstructor_createFunc == null)
         	{
         		_TSShapeConstructor_createFunc =
         			(_TSShapeConstructor_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_TSShapeConstructor_create"), typeof(_TSShapeConstructor_create));
         	}
         
         	return  _TSShapeConstructor_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool addPrimitive(string meshName, string type, string _params, TransformF txfm, string nodeName)
         {
            return InternalUnsafeMethods.addPrimitive(ObjectPtr, meshName, type, _params, txfm.ToStruct(), nodeName);
         }
      
         public virtual bool addCollisionDetail(int size, string type, string target, int depth = 4, float merge = 30, float concavity = 30, int maxVerts = 32, float boxMaxError = 0, float sphereMaxError = 0, float capsuleMaxError = 0)
         {
            return InternalUnsafeMethods.addCollisionDetail(ObjectPtr, size, type, target, depth, merge, concavity, maxVerts, boxMaxError, sphereMaxError, capsuleMaxError);
         }
      
         public virtual void dumpShape(string filename = "")
         {
            InternalUnsafeMethods.dumpShape(ObjectPtr, filename);
         }
      
         public virtual void saveShape(string filename)
         {
            InternalUnsafeMethods.saveShape(ObjectPtr, filename);
         }
      
         public virtual void writeChangeSet()
         {
            InternalUnsafeMethods.writeChangeSet(ObjectPtr);
         }
      
         public virtual void notifyShapeChanged()
         {
            InternalUnsafeMethods.notifyShapeChanged(ObjectPtr);
         }
      
         public virtual int getNodeCount()
         {
            return InternalUnsafeMethods.getNodeCount(ObjectPtr);
         }
      
         public virtual int getNodeIndex(string name)
         {
            return InternalUnsafeMethods.getNodeIndex(ObjectPtr, name);
         }
      
         public virtual string getNodeName(int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getNodeName(ObjectPtr, index));
         }
      
         public virtual string getNodeParentName(string name)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getNodeParentName(ObjectPtr, name));
         }
      
         public virtual bool setNodeParent(string name, string parentName)
         {
            return InternalUnsafeMethods.setNodeParent(ObjectPtr, name, parentName);
         }
      
         public virtual int getNodeChildCount(string name)
         {
            return InternalUnsafeMethods.getNodeChildCount(ObjectPtr, name);
         }
      
         public virtual string getNodeChildName(string name, int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getNodeChildName(ObjectPtr, name, index));
         }
      
         public virtual int getNodeObjectCount(string name)
         {
            return InternalUnsafeMethods.getNodeObjectCount(ObjectPtr, name);
         }
      
         public virtual string getNodeObjectName(string name, int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getNodeObjectName(ObjectPtr, name, index));
         }
      
         public virtual TransformF getNodeTransform(string name, bool isWorld = false)
         {
            return new TransformF(InternalUnsafeMethods.getNodeTransform(ObjectPtr, name, isWorld));
         }
      
         public virtual bool setNodeTransform(string name, TransformF txfm, bool isWorld = false)
         {
            return InternalUnsafeMethods.setNodeTransform(ObjectPtr, name, txfm.ToStruct(), isWorld);
         }
      
         public virtual bool renameNode(string oldName, string newName)
         {
            return InternalUnsafeMethods.renameNode(ObjectPtr, oldName, newName);
         }
      
         public virtual bool addNode(string name, string parentName, TransformF txfm = null, bool isWorld = false)
         {
            if (txfm == null) txfm = TransformF.Identity;
                  return InternalUnsafeMethods.addNode(ObjectPtr, name, parentName, txfm.ToStruct(), isWorld);
         }
      
         public virtual bool removeNode(string name)
         {
            return InternalUnsafeMethods.removeNode(ObjectPtr, name);
         }
      
         public virtual int getTargetCount()
         {
            return InternalUnsafeMethods.getTargetCount(ObjectPtr);
         }
      
         public virtual string getTargetName(int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getTargetName(ObjectPtr, index));
         }
      
         public virtual int getObjectCount()
         {
            return InternalUnsafeMethods.getObjectCount(ObjectPtr);
         }
      
         public virtual string getObjectName(int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getObjectName(ObjectPtr, index));
         }
      
         public virtual int getObjectIndex(string name)
         {
            return InternalUnsafeMethods.getObjectIndex(ObjectPtr, name);
         }
      
         public virtual string getObjectNode(string name)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getObjectNode(ObjectPtr, name));
         }
      
         public virtual bool setObjectNode(string objName, string nodeName)
         {
            return InternalUnsafeMethods.setObjectNode(ObjectPtr, objName, nodeName);
         }
      
         public virtual bool renameObject(string oldName, string newName)
         {
            return InternalUnsafeMethods.renameObject(ObjectPtr, oldName, newName);
         }
      
         public virtual bool removeObject(string name)
         {
            return InternalUnsafeMethods.removeObject(ObjectPtr, name);
         }
      
         public virtual int getMeshCount(string name)
         {
            return InternalUnsafeMethods.getMeshCount(ObjectPtr, name);
         }
      
         public virtual string getMeshName(string name, int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getMeshName(ObjectPtr, name, index));
         }
      
         public virtual int getMeshSize(string name, int index)
         {
            return InternalUnsafeMethods.getMeshSize(ObjectPtr, name, index);
         }
      
         public virtual bool setMeshSize(string name, int size)
         {
            return InternalUnsafeMethods.setMeshSize(ObjectPtr, name, size);
         }
      
         public virtual string getMeshType(string name)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getMeshType(ObjectPtr, name));
         }
      
         public virtual bool setMeshType(string name, string type)
         {
            return InternalUnsafeMethods.setMeshType(ObjectPtr, name, type);
         }
      
         public virtual string getMeshMaterial(string name)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getMeshMaterial(ObjectPtr, name));
         }
      
         public virtual bool setMeshMaterial(string meshName, string matName)
         {
            return InternalUnsafeMethods.setMeshMaterial(ObjectPtr, meshName, matName);
         }
      
         public virtual bool addMesh(string meshName, string srcShape, string srcMesh)
         {
            return InternalUnsafeMethods.addMesh(ObjectPtr, meshName, srcShape, srcMesh);
         }
      
         public virtual bool removeMesh(string name)
         {
            return InternalUnsafeMethods.removeMesh(ObjectPtr, name);
         }
      
         public virtual Box3F getBounds()
         {
            return new Box3F(InternalUnsafeMethods.getBounds(ObjectPtr));
         }
      
         public virtual bool setBounds(Box3F bbox)
         {
            return InternalUnsafeMethods.setBounds(ObjectPtr, bbox.ToStruct());
         }
      
         public virtual int getDetailLevelCount()
         {
            return InternalUnsafeMethods.getDetailLevelCount(ObjectPtr);
         }
      
         public virtual string getDetailLevelName(int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getDetailLevelName(ObjectPtr, index));
         }
      
         public virtual int getDetailLevelSize(int index)
         {
            return InternalUnsafeMethods.getDetailLevelSize(ObjectPtr, index);
         }
      
         public virtual int getDetailLevelIndex(int size)
         {
            return InternalUnsafeMethods.getDetailLevelIndex(ObjectPtr, size);
         }
      
         public virtual bool renameDetailLevel(string oldName, string newName)
         {
            return InternalUnsafeMethods.renameDetailLevel(ObjectPtr, oldName, newName);
         }
      
         public virtual bool removeDetailLevel(int index)
         {
            return InternalUnsafeMethods.removeDetailLevel(ObjectPtr, index);
         }
      
         public virtual int setDetailLevelSize(int index, int newSize)
         {
            return InternalUnsafeMethods.setDetailLevelSize(ObjectPtr, index, newSize);
         }
      
         public virtual int getImposterDetailLevel()
         {
            return InternalUnsafeMethods.getImposterDetailLevel(ObjectPtr);
         }
      
         public virtual string getImposterSettings(int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getImposterSettings(ObjectPtr, index));
         }
      
         public virtual int addImposter(int size, int equatorSteps, int polarSteps, int dl, int dim, bool includePoles, float polarAngle)
         {
            return InternalUnsafeMethods.addImposter(ObjectPtr, size, equatorSteps, polarSteps, dl, dim, includePoles, polarAngle);
         }
      
         public virtual bool removeImposter()
         {
            return InternalUnsafeMethods.removeImposter(ObjectPtr);
         }
      
         public virtual int getSequenceCount()
         {
            return InternalUnsafeMethods.getSequenceCount(ObjectPtr);
         }
      
         public virtual int getSequenceIndex(string name)
         {
            return InternalUnsafeMethods.getSequenceIndex(ObjectPtr, name);
         }
      
         public virtual string getSequenceName(int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getSequenceName(ObjectPtr, index));
         }
      
         public virtual string getSequenceSource(string name)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getSequenceSource(ObjectPtr, name));
         }
      
         public virtual int getSequenceFrameCount(string name)
         {
            return InternalUnsafeMethods.getSequenceFrameCount(ObjectPtr, name);
         }
      
         public virtual float getSequencePriority(string name)
         {
            return InternalUnsafeMethods.getSequencePriority(ObjectPtr, name);
         }
      
         public virtual bool setSequencePriority(string name, float priority)
         {
            return InternalUnsafeMethods.setSequencePriority(ObjectPtr, name, priority);
         }
      
         public virtual string getSequenceGroundSpeed(string name)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getSequenceGroundSpeed(ObjectPtr, name));
         }
      
         public virtual bool setSequenceGroundSpeed(string name, Point3F transSpeed, Point3F rotSpeed = null)
         {
            if (rotSpeed == null) rotSpeed = Point3F.Zero;
                  return InternalUnsafeMethods.setSequenceGroundSpeed(ObjectPtr, name, transSpeed.ToStruct(), rotSpeed.ToStruct());
         }
      
         public virtual bool getSequenceCyclic(string name)
         {
            return InternalUnsafeMethods.getSequenceCyclic(ObjectPtr, name);
         }
      
         public virtual bool setSequenceCyclic(string name, bool cyclic)
         {
            return InternalUnsafeMethods.setSequenceCyclic(ObjectPtr, name, cyclic);
         }
      
         public virtual string getSequenceBlend(string name)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getSequenceBlend(ObjectPtr, name));
         }
      
         public virtual bool setSequenceBlend(string name, bool blend, string blendSeq, int blendFrame)
         {
            return InternalUnsafeMethods.setSequenceBlend(ObjectPtr, name, blend, blendSeq, blendFrame);
         }
      
         public virtual bool renameSequence(string oldName, string newName)
         {
            return InternalUnsafeMethods.renameSequence(ObjectPtr, oldName, newName);
         }
      
         public virtual bool addSequence(string source, string name, int start = 0, int end = -1, bool padRot = true, bool padTrans = false)
         {
            return InternalUnsafeMethods.addSequence(ObjectPtr, source, name, start, end, padRot, padTrans);
         }
      
         public virtual bool removeSequence(string name)
         {
            return InternalUnsafeMethods.removeSequence(ObjectPtr, name);
         }
      
         public virtual int getTriggerCount(string name)
         {
            return InternalUnsafeMethods.getTriggerCount(ObjectPtr, name);
         }
      
         public virtual string getTrigger(string name, int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getTrigger(ObjectPtr, name, index));
         }
      
         public virtual bool addTrigger(string name, int keyframe, int state)
         {
            return InternalUnsafeMethods.addTrigger(ObjectPtr, name, keyframe, state);
         }
      
         public virtual bool removeTrigger(string name, int keyframe, int state)
         {
            return InternalUnsafeMethods.removeTrigger(ObjectPtr, name, keyframe, state);
         }
      
      
      #endregion


      #region Properties
      
      
         public string BaseShape
         {
         	get { return getFieldValue("BaseShape"); }
         	set { setFieldValue("BaseShape", value); }
         }
      
         public TSShapeConstructorUpAxis UpAxis
         {
         	get { return (TSShapeConstructorUpAxis)Enum.Parse(typeof(TSShapeConstructorUpAxis), getFieldValue("UpAxis"), true); }
         	set { setFieldValue("UpAxis", value.ToString()); }
         }
      
         public float Unit
         {
         	get { return float.Parse(getFieldValue("Unit")); }
         	set { setFieldValue("Unit", value.ToString()); }
         }
      
         public TSShapeConstructorLodType LodType
         {
         	get { return (TSShapeConstructorLodType)Enum.Parse(typeof(TSShapeConstructorLodType), getFieldValue("LodType"), true); }
         	set { setFieldValue("LodType", value.ToString()); }
         }
      
         public int SingleDetailSize
         {
         	get { return int.Parse(getFieldValue("SingleDetailSize")); }
         	set { setFieldValue("SingleDetailSize", value.ToString()); }
         }
      
         public string MatNamePrefix
         {
         	get { return getFieldValue("MatNamePrefix"); }
         	set { setFieldValue("MatNamePrefix", value); }
         }
      
         public string AlwaysImport
         {
         	get { return getFieldValue("AlwaysImport"); }
         	set { setFieldValue("AlwaysImport", value); }
         }
      
         public string NeverImport
         {
         	get { return getFieldValue("NeverImport"); }
         	set { setFieldValue("NeverImport", value); }
         }
      
         public string AlwaysImportMesh
         {
         	get { return getFieldValue("AlwaysImportMesh"); }
         	set { setFieldValue("AlwaysImportMesh", value); }
         }
      
         public string NeverImportMesh
         {
         	get { return getFieldValue("NeverImportMesh"); }
         	set { setFieldValue("NeverImportMesh", value); }
         }
      
         public bool IgnoreNodeScale
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IgnoreNodeScale")); }
         	set { setFieldValue("IgnoreNodeScale", value ? "1" : "0"); }
         }
      
         public bool AdjustCenter
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AdjustCenter")); }
         	set { setFieldValue("AdjustCenter", value ? "1" : "0"); }
         }
      
         public bool AdjustFloor
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AdjustFloor")); }
         	set { setFieldValue("AdjustFloor", value ? "1" : "0"); }
         }
      
         public bool ForceUpdateMaterials
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ForceUpdateMaterials")); }
         	set { setFieldValue("ForceUpdateMaterials", value ? "1" : "0"); }
         }
      
         public string Sequence
         {
         	get { return getFieldValue("Sequence"); }
         	set { setFieldValue("Sequence", value); }
         }
      
      
      #endregion

	}
}