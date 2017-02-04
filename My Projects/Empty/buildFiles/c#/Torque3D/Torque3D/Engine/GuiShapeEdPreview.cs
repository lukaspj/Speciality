using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiShapeEdPreview : EditTSCtrl
	{
		public GuiShapeEdPreview(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiShapeEdPreview(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiShapeEdPreview(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiShapeEdPreview(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiShapeEdPreview(SimObject pObj) : base(pObj)
		{
		}

		public GuiShapeEdPreview(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiShapeEdPreview_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setOrbitPos(IntPtr thisPtr, InternalPoint3FStruct pos);
         private static _setOrbitPos _setOrbitPosFunc;
         internal static void setOrbitPos(IntPtr thisPtr, InternalPoint3FStruct pos)
         {
         	if (_setOrbitPosFunc == null)
         	{
         		_setOrbitPosFunc =
         			(_setOrbitPos)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiShapeEdPreview_setOrbitPos"), typeof(_setOrbitPos));
         	}
         
         	 _setOrbitPosFunc(thisPtr, pos);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setModel(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string shapePath);
         private static _setModel _setModelFunc;
         internal static bool setModel(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string shapePath)
         {
         	if (_setModelFunc == null)
         	{
         		_setModelFunc =
         			(_setModel)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiShapeEdPreview_setModel"), typeof(_setModel));
         	}
         
         	return  _setModelFunc(thisPtr, shapePath);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _fitToShape(IntPtr thisPtr);
         private static _fitToShape _fitToShapeFunc;
         internal static void fitToShape(IntPtr thisPtr)
         {
         	if (_fitToShapeFunc == null)
         	{
         		_fitToShapeFunc =
         			(_fitToShape)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiShapeEdPreview_fitToShape"), typeof(_fitToShape));
         	}
         
         	 _fitToShapeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _refreshShape(IntPtr thisPtr);
         private static _refreshShape _refreshShapeFunc;
         internal static void refreshShape(IntPtr thisPtr)
         {
         	if (_refreshShapeFunc == null)
         	{
         		_refreshShapeFunc =
         			(_refreshShape)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiShapeEdPreview_refreshShape"), typeof(_refreshShape));
         	}
         
         	 _refreshShapeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _updateNodeTransforms(IntPtr thisPtr);
         private static _updateNodeTransforms _updateNodeTransformsFunc;
         internal static void updateNodeTransforms(IntPtr thisPtr)
         {
         	if (_updateNodeTransformsFunc == null)
         	{
         		_updateNodeTransformsFunc =
         			(_updateNodeTransforms)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiShapeEdPreview_updateNodeTransforms"), typeof(_updateNodeTransforms));
         	}
         
         	 _updateNodeTransformsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalBox3FStruct _computeShapeBounds(IntPtr thisPtr);
         private static _computeShapeBounds _computeShapeBoundsFunc;
         internal static InternalBox3FStruct computeShapeBounds(IntPtr thisPtr)
         {
         	if (_computeShapeBoundsFunc == null)
         	{
         		_computeShapeBoundsFunc =
         			(_computeShapeBounds)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiShapeEdPreview_computeShapeBounds"), typeof(_computeShapeBounds));
         	}
         
         	return  _computeShapeBoundsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getMeshHidden(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _getMeshHidden _getMeshHiddenFunc;
         internal static bool getMeshHidden(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_getMeshHiddenFunc == null)
         	{
         		_getMeshHiddenFunc =
         			(_getMeshHidden)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiShapeEdPreview_getMeshHidden"), typeof(_getMeshHidden));
         	}
         
         	return  _getMeshHiddenFunc(thisPtr, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMeshHidden(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, bool hidden);
         private static _setMeshHidden _setMeshHiddenFunc;
         internal static void setMeshHidden(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, bool hidden)
         {
         	if (_setMeshHiddenFunc == null)
         	{
         		_setMeshHiddenFunc =
         			(_setMeshHidden)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiShapeEdPreview_setMeshHidden"), typeof(_setMeshHidden));
         	}
         
         	 _setMeshHiddenFunc(thisPtr, name, hidden);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setAllMeshesHidden(IntPtr thisPtr, bool hidden);
         private static _setAllMeshesHidden _setAllMeshesHiddenFunc;
         internal static void setAllMeshesHidden(IntPtr thisPtr, bool hidden)
         {
         	if (_setAllMeshesHiddenFunc == null)
         	{
         		_setAllMeshesHiddenFunc =
         			(_setAllMeshesHidden)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiShapeEdPreview_setAllMeshesHidden"), typeof(_setAllMeshesHidden));
         	}
         
         	 _setAllMeshesHiddenFunc(thisPtr, hidden);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _exportToCollada(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string path);
         private static _exportToCollada _exportToColladaFunc;
         internal static void exportToCollada(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string path)
         {
         	if (_exportToColladaFunc == null)
         	{
         		_exportToColladaFunc =
         			(_exportToCollada)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiShapeEdPreview_exportToCollada"), typeof(_exportToCollada));
         	}
         
         	 _exportToColladaFunc(thisPtr, path);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addThread(IntPtr thisPtr);
         private static _addThread _addThreadFunc;
         internal static void addThread(IntPtr thisPtr)
         {
         	if (_addThreadFunc == null)
         	{
         		_addThreadFunc =
         			(_addThread)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiShapeEdPreview_addThread"), typeof(_addThread));
         	}
         
         	 _addThreadFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeThread(IntPtr thisPtr, int slot);
         private static _removeThread _removeThreadFunc;
         internal static void removeThread(IntPtr thisPtr, int slot)
         {
         	if (_removeThreadFunc == null)
         	{
         		_removeThreadFunc =
         			(_removeThread)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiShapeEdPreview_removeThread"), typeof(_removeThread));
         	}
         
         	 _removeThreadFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getThreadCount(IntPtr thisPtr);
         private static _getThreadCount _getThreadCountFunc;
         internal static int getThreadCount(IntPtr thisPtr)
         {
         	if (_getThreadCountFunc == null)
         	{
         		_getThreadCountFunc =
         			(_getThreadCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiShapeEdPreview_getThreadCount"), typeof(_getThreadCount));
         	}
         
         	return  _getThreadCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setTimeScale(IntPtr thisPtr, float scale);
         private static _setTimeScale _setTimeScaleFunc;
         internal static void setTimeScale(IntPtr thisPtr, float scale)
         {
         	if (_setTimeScaleFunc == null)
         	{
         		_setTimeScaleFunc =
         			(_setTimeScale)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiShapeEdPreview_setTimeScale"), typeof(_setTimeScale));
         	}
         
         	 _setTimeScaleFunc(thisPtr, scale);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setThreadSequence(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, float duration, float pos, bool play);
         private static _setThreadSequence _setThreadSequenceFunc;
         internal static void setThreadSequence(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string name, float duration, float pos, bool play)
         {
         	if (_setThreadSequenceFunc == null)
         	{
         		_setThreadSequenceFunc =
         			(_setThreadSequence)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiShapeEdPreview_setThreadSequence"), typeof(_setThreadSequence));
         	}
         
         	 _setThreadSequenceFunc(thisPtr, name, duration, pos, play);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getThreadSequence(IntPtr thisPtr);
         private static _getThreadSequence _getThreadSequenceFunc;
         internal static IntPtr getThreadSequence(IntPtr thisPtr)
         {
         	if (_getThreadSequenceFunc == null)
         	{
         		_getThreadSequenceFunc =
         			(_getThreadSequence)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiShapeEdPreview_getThreadSequence"), typeof(_getThreadSequence));
         	}
         
         	return  _getThreadSequenceFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _refreshThreadSequences(IntPtr thisPtr);
         private static _refreshThreadSequences _refreshThreadSequencesFunc;
         internal static void refreshThreadSequences(IntPtr thisPtr)
         {
         	if (_refreshThreadSequencesFunc == null)
         	{
         		_refreshThreadSequencesFunc =
         			(_refreshThreadSequences)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiShapeEdPreview_refreshThreadSequences"), typeof(_refreshThreadSequences));
         	}
         
         	 _refreshThreadSequencesFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _mountShape(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string shapePath, [MarshalAs(UnmanagedType.LPWStr)]string nodeName, [MarshalAs(UnmanagedType.LPWStr)]string type, int slot);
         private static _mountShape _mountShapeFunc;
         internal static bool mountShape(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string shapePath, [MarshalAs(UnmanagedType.LPWStr)]string nodeName, [MarshalAs(UnmanagedType.LPWStr)]string type, int slot)
         {
         	if (_mountShapeFunc == null)
         	{
         		_mountShapeFunc =
         			(_mountShape)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiShapeEdPreview_mountShape"), typeof(_mountShape));
         	}
         
         	return  _mountShapeFunc(thisPtr, shapePath, nodeName, type, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMountNode(IntPtr thisPtr, int slot, [MarshalAs(UnmanagedType.LPWStr)]string nodeName);
         private static _setMountNode _setMountNodeFunc;
         internal static void setMountNode(IntPtr thisPtr, int slot, [MarshalAs(UnmanagedType.LPWStr)]string nodeName)
         {
         	if (_setMountNodeFunc == null)
         	{
         		_setMountNodeFunc =
         			(_setMountNode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiShapeEdPreview_setMountNode"), typeof(_setMountNode));
         	}
         
         	 _setMountNodeFunc(thisPtr, slot, nodeName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getMountThreadSequence(IntPtr thisPtr, int slot);
         private static _getMountThreadSequence _getMountThreadSequenceFunc;
         internal static IntPtr getMountThreadSequence(IntPtr thisPtr, int slot)
         {
         	if (_getMountThreadSequenceFunc == null)
         	{
         		_getMountThreadSequenceFunc =
         			(_getMountThreadSequence)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiShapeEdPreview_getMountThreadSequence"), typeof(_getMountThreadSequence));
         	}
         
         	return  _getMountThreadSequenceFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMountThreadSequence(IntPtr thisPtr, int slot, [MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _setMountThreadSequence _setMountThreadSequenceFunc;
         internal static void setMountThreadSequence(IntPtr thisPtr, int slot, [MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_setMountThreadSequenceFunc == null)
         	{
         		_setMountThreadSequenceFunc =
         			(_setMountThreadSequence)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiShapeEdPreview_setMountThreadSequence"), typeof(_setMountThreadSequence));
         	}
         
         	 _setMountThreadSequenceFunc(thisPtr, slot, name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getMountThreadPos(IntPtr thisPtr, int slot);
         private static _getMountThreadPos _getMountThreadPosFunc;
         internal static float getMountThreadPos(IntPtr thisPtr, int slot)
         {
         	if (_getMountThreadPosFunc == null)
         	{
         		_getMountThreadPosFunc =
         			(_getMountThreadPos)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiShapeEdPreview_getMountThreadPos"), typeof(_getMountThreadPos));
         	}
         
         	return  _getMountThreadPosFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMountThreadPos(IntPtr thisPtr, int slot, float pos);
         private static _setMountThreadPos _setMountThreadPosFunc;
         internal static void setMountThreadPos(IntPtr thisPtr, int slot, float pos)
         {
         	if (_setMountThreadPosFunc == null)
         	{
         		_setMountThreadPosFunc =
         			(_setMountThreadPos)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiShapeEdPreview_setMountThreadPos"), typeof(_setMountThreadPos));
         	}
         
         	 _setMountThreadPosFunc(thisPtr, slot, pos);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getMountThreadDir(IntPtr thisPtr, int slot);
         private static _getMountThreadDir _getMountThreadDirFunc;
         internal static float getMountThreadDir(IntPtr thisPtr, int slot)
         {
         	if (_getMountThreadDirFunc == null)
         	{
         		_getMountThreadDirFunc =
         			(_getMountThreadDir)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiShapeEdPreview_getMountThreadDir"), typeof(_getMountThreadDir));
         	}
         
         	return  _getMountThreadDirFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMountThreadDir(IntPtr thisPtr, int slot, float dir);
         private static _setMountThreadDir _setMountThreadDirFunc;
         internal static void setMountThreadDir(IntPtr thisPtr, int slot, float dir)
         {
         	if (_setMountThreadDirFunc == null)
         	{
         		_setMountThreadDirFunc =
         			(_setMountThreadDir)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiShapeEdPreview_setMountThreadDir"), typeof(_setMountThreadDir));
         	}
         
         	 _setMountThreadDirFunc(thisPtr, slot, dir);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _unmountShape(IntPtr thisPtr, int slot);
         private static _unmountShape _unmountShapeFunc;
         internal static void unmountShape(IntPtr thisPtr, int slot)
         {
         	if (_unmountShapeFunc == null)
         	{
         		_unmountShapeFunc =
         			(_unmountShape)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiShapeEdPreview_unmountShape"), typeof(_unmountShape));
         	}
         
         	 _unmountShapeFunc(thisPtr, slot);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _unmountAll(IntPtr thisPtr);
         private static _unmountAll _unmountAllFunc;
         internal static void unmountAll(IntPtr thisPtr)
         {
         	if (_unmountAllFunc == null)
         	{
         		_unmountAllFunc =
         			(_unmountAll)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiShapeEdPreview_unmountAll"), typeof(_unmountAll));
         	}
         
         	 _unmountAllFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiShapeEdPreview_create();
         private static _GuiShapeEdPreview_create _GuiShapeEdPreview_createFunc;
         internal static IntPtr GuiShapeEdPreview_create()
         {
         	if (_GuiShapeEdPreview_createFunc == null)
         	{
         		_GuiShapeEdPreview_createFunc =
         			(_GuiShapeEdPreview_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiShapeEdPreview_create"), typeof(_GuiShapeEdPreview_create));
         	}
         
         	return  _GuiShapeEdPreview_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setOrbitPos(Point3F pos)
         {
            InternalUnsafeMethods.setOrbitPos(ObjectPtr, pos.ToStruct());
         }
      
         public virtual bool setModel(string shapePath)
         {
            return InternalUnsafeMethods.setModel(ObjectPtr, shapePath);
         }
      
         public virtual void fitToShape()
         {
            InternalUnsafeMethods.fitToShape(ObjectPtr);
         }
      
         public virtual void refreshShape()
         {
            InternalUnsafeMethods.refreshShape(ObjectPtr);
         }
      
         public virtual void updateNodeTransforms()
         {
            InternalUnsafeMethods.updateNodeTransforms(ObjectPtr);
         }
      
         public virtual Box3F computeShapeBounds()
         {
            return new Box3F(InternalUnsafeMethods.computeShapeBounds(ObjectPtr));
         }
      
         public virtual bool getMeshHidden(string name)
         {
            return InternalUnsafeMethods.getMeshHidden(ObjectPtr, name);
         }
      
         public virtual void setMeshHidden(string name, bool hidden)
         {
            InternalUnsafeMethods.setMeshHidden(ObjectPtr, name, hidden);
         }
      
         public virtual void setAllMeshesHidden(bool hidden)
         {
            InternalUnsafeMethods.setAllMeshesHidden(ObjectPtr, hidden);
         }
      
         public virtual void exportToCollada(string path)
         {
            InternalUnsafeMethods.exportToCollada(ObjectPtr, path);
         }
      
         public virtual void addThread()
         {
            InternalUnsafeMethods.addThread(ObjectPtr);
         }
      
         public virtual void removeThread(int slot)
         {
            InternalUnsafeMethods.removeThread(ObjectPtr, slot);
         }
      
         public virtual int getThreadCount()
         {
            return InternalUnsafeMethods.getThreadCount(ObjectPtr);
         }
      
         public virtual void setTimeScale(float scale)
         {
            InternalUnsafeMethods.setTimeScale(ObjectPtr, scale);
         }
      
         public virtual void setThreadSequence(string name, float duration = 0, float pos = 0, bool play = false)
         {
            InternalUnsafeMethods.setThreadSequence(ObjectPtr, name, duration, pos, play);
         }
      
         public virtual string getThreadSequence()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getThreadSequence(ObjectPtr));
         }
      
         public virtual void refreshThreadSequences()
         {
            InternalUnsafeMethods.refreshThreadSequences(ObjectPtr);
         }
      
         public virtual bool mountShape(string shapePath, string nodeName, string type, int slot)
         {
            return InternalUnsafeMethods.mountShape(ObjectPtr, shapePath, nodeName, type, slot);
         }
      
         public virtual void setMountNode(int slot, string nodeName)
         {
            InternalUnsafeMethods.setMountNode(ObjectPtr, slot, nodeName);
         }
      
         public virtual string getMountThreadSequence(int slot)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getMountThreadSequence(ObjectPtr, slot));
         }
      
         public virtual void setMountThreadSequence(int slot, string name)
         {
            InternalUnsafeMethods.setMountThreadSequence(ObjectPtr, slot, name);
         }
      
         public virtual float getMountThreadPos(int slot)
         {
            return InternalUnsafeMethods.getMountThreadPos(ObjectPtr, slot);
         }
      
         public virtual void setMountThreadPos(int slot, float pos)
         {
            InternalUnsafeMethods.setMountThreadPos(ObjectPtr, slot, pos);
         }
      
         public virtual float getMountThreadDir(int slot)
         {
            return InternalUnsafeMethods.getMountThreadDir(ObjectPtr, slot);
         }
      
         public virtual void setMountThreadDir(int slot, float dir)
         {
            InternalUnsafeMethods.setMountThreadDir(ObjectPtr, slot, dir);
         }
      
         public virtual void unmountShape(int slot)
         {
            InternalUnsafeMethods.unmountShape(ObjectPtr, slot);
         }
      
         public virtual void unmountAll()
         {
            InternalUnsafeMethods.unmountAll(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public bool EditSun
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("EditSun")); }
         	set { setFieldValue("EditSun", value ? "1" : "0"); }
         }
      
         public int SelectedNode
         {
         	get { return int.Parse(getFieldValue("SelectedNode")); }
         	set { setFieldValue("SelectedNode", value.ToString()); }
         }
      
         public int SelectedObject
         {
         	get { return int.Parse(getFieldValue("SelectedObject")); }
         	set { setFieldValue("SelectedObject", value.ToString()); }
         }
      
         public int SelectedObjDetail
         {
         	get { return int.Parse(getFieldValue("SelectedObjDetail")); }
         	set { setFieldValue("SelectedObjDetail", value.ToString()); }
         }
      
         public Point2I GridDimension
         {
         	get { return new Point2I(getFieldValue("GridDimension")); }
         	set { setFieldValue("GridDimension", value.ToString()); }
         }
      
         public bool RenderGrid
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderGrid")); }
         	set { setFieldValue("RenderGrid", value ? "1" : "0"); }
         }
      
         public bool RenderNodes
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderNodes")); }
         	set { setFieldValue("RenderNodes", value ? "1" : "0"); }
         }
      
         public bool RenderGhost
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderGhost")); }
         	set { setFieldValue("RenderGhost", value ? "1" : "0"); }
         }
      
         public bool RenderBounds
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderBounds")); }
         	set { setFieldValue("RenderBounds", value ? "1" : "0"); }
         }
      
         public bool RenderObjBox
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderObjBox")); }
         	set { setFieldValue("RenderObjBox", value ? "1" : "0"); }
         }
      
         public bool RenderColMeshes
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderColMeshes")); }
         	set { setFieldValue("RenderColMeshes", value ? "1" : "0"); }
         }
      
         public bool RenderMounts
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderMounts")); }
         	set { setFieldValue("RenderMounts", value ? "1" : "0"); }
         }
      
         public ColorI SunDiffuse
         {
         	get { return new ColorI(getFieldValue("SunDiffuse")); }
         	set { setFieldValue("SunDiffuse", value.ToString()); }
         }
      
         public ColorI SunAmbient
         {
         	get { return new ColorI(getFieldValue("SunAmbient")); }
         	set { setFieldValue("SunAmbient", value.ToString()); }
         }
      
         public float SunAngleX
         {
         	get { return float.Parse(getFieldValue("SunAngleX")); }
         	set { setFieldValue("SunAngleX", value.ToString()); }
         }
      
         public float SunAngleZ
         {
         	get { return float.Parse(getFieldValue("SunAngleZ")); }
         	set { setFieldValue("SunAngleZ", value.ToString()); }
         }
      
         public int ActiveThread
         {
         	get { return int.Parse(getFieldValue("ActiveThread")); }
         	set { setFieldValue("ActiveThread", value.ToString()); }
         }
      
         public float ThreadPos
         {
         	get { return float.Parse(getFieldValue("ThreadPos")); }
         	set { setFieldValue("ThreadPos", value.ToString()); }
         }
      
         public int ThreadDirection
         {
         	get { return int.Parse(getFieldValue("ThreadDirection")); }
         	set { setFieldValue("ThreadDirection", value.ToString()); }
         }
      
         public bool ThreadPingPong
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ThreadPingPong")); }
         	set { setFieldValue("ThreadPingPong", value ? "1" : "0"); }
         }
      
         public bool FixedDetail
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("FixedDetail")); }
         	set { setFieldValue("FixedDetail", value ? "1" : "0"); }
         }
      
         public float OrbitDist
         {
         	get { return float.Parse(getFieldValue("OrbitDist")); }
         	set { setFieldValue("OrbitDist", value.ToString()); }
         }
      
         public int CurrentDL
         {
         	get { return int.Parse(getFieldValue("CurrentDL")); }
         	set { setFieldValue("CurrentDL", value.ToString()); }
         }
      
         public int DetailSize
         {
         	get { return int.Parse(getFieldValue("DetailSize")); }
         	set { setFieldValue("DetailSize", value.ToString()); }
         }
      
         public int DetailPolys
         {
         	get { return int.Parse(getFieldValue("DetailPolys")); }
         	set { setFieldValue("DetailPolys", value.ToString()); }
         }
      
         public float PixelSize
         {
         	get { return float.Parse(getFieldValue("PixelSize")); }
         	set { setFieldValue("PixelSize", value.ToString()); }
         }
      
         public int NumMaterials
         {
         	get { return int.Parse(getFieldValue("NumMaterials")); }
         	set { setFieldValue("NumMaterials", value.ToString()); }
         }
      
         public int NumDrawCalls
         {
         	get { return int.Parse(getFieldValue("NumDrawCalls")); }
         	set { setFieldValue("NumDrawCalls", value.ToString()); }
         }
      
         public int NumBones
         {
         	get { return int.Parse(getFieldValue("NumBones")); }
         	set { setFieldValue("NumBones", value.ToString()); }
         }
      
         public int NumWeights
         {
         	get { return int.Parse(getFieldValue("NumWeights")); }
         	set { setFieldValue("NumWeights", value.ToString()); }
         }
      
         public int ColMeshes
         {
         	get { return int.Parse(getFieldValue("ColMeshes")); }
         	set { setFieldValue("ColMeshes", value.ToString()); }
         }
      
         public int ColPolys
         {
         	get { return int.Parse(getFieldValue("ColPolys")); }
         	set { setFieldValue("ColPolys", value.ToString()); }
         }
      
      
      #endregion

	}
}