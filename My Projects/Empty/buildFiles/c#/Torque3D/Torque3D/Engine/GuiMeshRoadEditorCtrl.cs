using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiMeshRoadEditorCtrl : EditTSCtrl
	{
		public GuiMeshRoadEditorCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiMeshRoadEditorCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiMeshRoadEditorCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiMeshRoadEditorCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiMeshRoadEditorCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiMeshRoadEditorCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiMeshRoadEditorCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _deleteNode(IntPtr thisPtr);
         private static _deleteNode _deleteNodeFunc;
         internal static void deleteNode(IntPtr thisPtr)
         {
         	if (_deleteNodeFunc == null)
         	{
         		_deleteNodeFunc =
         			(_deleteNode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMeshRoadEditorCtrl_deleteNode"), typeof(_deleteNode));
         	}
         
         	 _deleteNodeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getMode(IntPtr thisPtr);
         private static _getMode _getModeFunc;
         internal static IntPtr getMode(IntPtr thisPtr)
         {
         	if (_getModeFunc == null)
         	{
         		_getModeFunc =
         			(_getMode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMeshRoadEditorCtrl_getMode"), typeof(_getMode));
         	}
         
         	return  _getModeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMode(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string mode);
         private static _setMode _setModeFunc;
         internal static void setMode(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string mode)
         {
         	if (_setModeFunc == null)
         	{
         		_setModeFunc =
         			(_setMode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMeshRoadEditorCtrl_setMode"), typeof(_setMode));
         	}
         
         	 _setModeFunc(thisPtr, mode);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getNodeWidth(IntPtr thisPtr);
         private static _getNodeWidth _getNodeWidthFunc;
         internal static float getNodeWidth(IntPtr thisPtr)
         {
         	if (_getNodeWidthFunc == null)
         	{
         		_getNodeWidthFunc =
         			(_getNodeWidth)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMeshRoadEditorCtrl_getNodeWidth"), typeof(_getNodeWidth));
         	}
         
         	return  _getNodeWidthFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setNodeWidth(IntPtr thisPtr, float width);
         private static _setNodeWidth _setNodeWidthFunc;
         internal static void setNodeWidth(IntPtr thisPtr, float width)
         {
         	if (_setNodeWidthFunc == null)
         	{
         		_setNodeWidthFunc =
         			(_setNodeWidth)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMeshRoadEditorCtrl_setNodeWidth"), typeof(_setNodeWidth));
         	}
         
         	 _setNodeWidthFunc(thisPtr, width);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getNodeDepth(IntPtr thisPtr);
         private static _getNodeDepth _getNodeDepthFunc;
         internal static float getNodeDepth(IntPtr thisPtr)
         {
         	if (_getNodeDepthFunc == null)
         	{
         		_getNodeDepthFunc =
         			(_getNodeDepth)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMeshRoadEditorCtrl_getNodeDepth"), typeof(_getNodeDepth));
         	}
         
         	return  _getNodeDepthFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setNodeDepth(IntPtr thisPtr, float depth);
         private static _setNodeDepth _setNodeDepthFunc;
         internal static void setNodeDepth(IntPtr thisPtr, float depth)
         {
         	if (_setNodeDepthFunc == null)
         	{
         		_setNodeDepthFunc =
         			(_setNodeDepth)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMeshRoadEditorCtrl_setNodeDepth"), typeof(_setNodeDepth));
         	}
         
         	 _setNodeDepthFunc(thisPtr, depth);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getNodePosition(IntPtr thisPtr);
         private static _getNodePosition _getNodePositionFunc;
         internal static InternalPoint3FStruct getNodePosition(IntPtr thisPtr)
         {
         	if (_getNodePositionFunc == null)
         	{
         		_getNodePositionFunc =
         			(_getNodePosition)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMeshRoadEditorCtrl_getNodePosition"), typeof(_getNodePosition));
         	}
         
         	return  _getNodePositionFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setNodePosition(IntPtr thisPtr, InternalPoint3FStruct pos);
         private static _setNodePosition _setNodePositionFunc;
         internal static void setNodePosition(IntPtr thisPtr, InternalPoint3FStruct pos)
         {
         	if (_setNodePositionFunc == null)
         	{
         		_setNodePositionFunc =
         			(_setNodePosition)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMeshRoadEditorCtrl_setNodePosition"), typeof(_setNodePosition));
         	}
         
         	 _setNodePositionFunc(thisPtr, pos);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getNodeNormal(IntPtr thisPtr);
         private static _getNodeNormal _getNodeNormalFunc;
         internal static InternalPoint3FStruct getNodeNormal(IntPtr thisPtr)
         {
         	if (_getNodeNormalFunc == null)
         	{
         		_getNodeNormalFunc =
         			(_getNodeNormal)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMeshRoadEditorCtrl_getNodeNormal"), typeof(_getNodeNormal));
         	}
         
         	return  _getNodeNormalFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setNodeNormal(IntPtr thisPtr, InternalPoint3FStruct normal);
         private static _setNodeNormal _setNodeNormalFunc;
         internal static void setNodeNormal(IntPtr thisPtr, InternalPoint3FStruct normal)
         {
         	if (_setNodeNormalFunc == null)
         	{
         		_setNodeNormalFunc =
         			(_setNodeNormal)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMeshRoadEditorCtrl_setNodeNormal"), typeof(_setNodeNormal));
         	}
         
         	 _setNodeNormalFunc(thisPtr, normal);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setSelectedRoad(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string objName);
         private static _setSelectedRoad _setSelectedRoadFunc;
         internal static void setSelectedRoad(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string objName)
         {
         	if (_setSelectedRoadFunc == null)
         	{
         		_setSelectedRoadFunc =
         			(_setSelectedRoad)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMeshRoadEditorCtrl_setSelectedRoad"), typeof(_setSelectedRoad));
         	}
         
         	 _setSelectedRoadFunc(thisPtr, objName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getSelectedRoad(IntPtr thisPtr);
         private static _getSelectedRoad _getSelectedRoadFunc;
         internal static int getSelectedRoad(IntPtr thisPtr)
         {
         	if (_getSelectedRoadFunc == null)
         	{
         		_getSelectedRoadFunc =
         			(_getSelectedRoad)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMeshRoadEditorCtrl_getSelectedRoad"), typeof(_getSelectedRoad));
         	}
         
         	return  _getSelectedRoadFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _regenerate(IntPtr thisPtr);
         private static _regenerate _regenerateFunc;
         internal static void regenerate(IntPtr thisPtr)
         {
         	if (_regenerateFunc == null)
         	{
         		_regenerateFunc =
         			(_regenerate)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMeshRoadEditorCtrl_regenerate"), typeof(_regenerate));
         	}
         
         	 _regenerateFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _matchTerrainToRoad(IntPtr thisPtr);
         private static _matchTerrainToRoad _matchTerrainToRoadFunc;
         internal static void matchTerrainToRoad(IntPtr thisPtr)
         {
         	if (_matchTerrainToRoadFunc == null)
         	{
         		_matchTerrainToRoadFunc =
         			(_matchTerrainToRoad)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMeshRoadEditorCtrl_matchTerrainToRoad"), typeof(_matchTerrainToRoad));
         	}
         
         	 _matchTerrainToRoadFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiMeshRoadEditorCtrl_create();
         private static _GuiMeshRoadEditorCtrl_create _GuiMeshRoadEditorCtrl_createFunc;
         internal static IntPtr GuiMeshRoadEditorCtrl_create()
         {
         	if (_GuiMeshRoadEditorCtrl_createFunc == null)
         	{
         		_GuiMeshRoadEditorCtrl_createFunc =
         			(_GuiMeshRoadEditorCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiMeshRoadEditorCtrl_create"), typeof(_GuiMeshRoadEditorCtrl_create));
         	}
         
         	return  _GuiMeshRoadEditorCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void deleteNode()
         {
            InternalUnsafeMethods.deleteNode(ObjectPtr);
         }
      
         public virtual string getMode()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getMode(ObjectPtr));
         }
      
         public virtual void setMode(string mode)
         {
            InternalUnsafeMethods.setMode(ObjectPtr, mode);
         }
      
         public virtual float getNodeWidth()
         {
            return InternalUnsafeMethods.getNodeWidth(ObjectPtr);
         }
      
         public virtual void setNodeWidth(float width)
         {
            InternalUnsafeMethods.setNodeWidth(ObjectPtr, width);
         }
      
         public virtual float getNodeDepth()
         {
            return InternalUnsafeMethods.getNodeDepth(ObjectPtr);
         }
      
         public virtual void setNodeDepth(float depth)
         {
            InternalUnsafeMethods.setNodeDepth(ObjectPtr, depth);
         }
      
         public virtual Point3F getNodePosition()
         {
            return new Point3F(InternalUnsafeMethods.getNodePosition(ObjectPtr));
         }
      
         public virtual void setNodePosition(Point3F pos)
         {
            InternalUnsafeMethods.setNodePosition(ObjectPtr, pos.ToStruct());
         }
      
         public virtual Point3F getNodeNormal()
         {
            return new Point3F(InternalUnsafeMethods.getNodeNormal(ObjectPtr));
         }
      
         public virtual void setNodeNormal(Point3F normal)
         {
            InternalUnsafeMethods.setNodeNormal(ObjectPtr, normal.ToStruct());
         }
      
         public virtual void setSelectedRoad(string objName = "")
         {
            InternalUnsafeMethods.setSelectedRoad(ObjectPtr, objName);
         }
      
         public virtual int getSelectedRoad()
         {
            return InternalUnsafeMethods.getSelectedRoad(ObjectPtr);
         }
      
         public virtual void regenerate()
         {
            InternalUnsafeMethods.regenerate(ObjectPtr);
         }
      
         public virtual void matchTerrainToRoad()
         {
            InternalUnsafeMethods.matchTerrainToRoad(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public float DefaultWidth
         {
         	get { return float.Parse(getFieldValue("DefaultWidth")); }
         	set { setFieldValue("DefaultWidth", value.ToString()); }
         }
      
         public float DefaultDepth
         {
         	get { return float.Parse(getFieldValue("DefaultDepth")); }
         	set { setFieldValue("DefaultDepth", value.ToString()); }
         }
      
         public Point3F DefaultNormal
         {
         	get { return new Point3F(getFieldValue("DefaultNormal")); }
         	set { setFieldValue("DefaultNormal", value.ToString()); }
         }
      
         public ColorI HoverSplineColor
         {
         	get { return new ColorI(getFieldValue("HoverSplineColor")); }
         	set { setFieldValue("HoverSplineColor", value.ToString()); }
         }
      
         public ColorI SelectedSplineColor
         {
         	get { return new ColorI(getFieldValue("SelectedSplineColor")); }
         	set { setFieldValue("SelectedSplineColor", value.ToString()); }
         }
      
         public ColorI HoverNodeColor
         {
         	get { return new ColorI(getFieldValue("HoverNodeColor")); }
         	set { setFieldValue("HoverNodeColor", value.ToString()); }
         }
      
         public bool IsDirty
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsDirty")); }
         	set { setFieldValue("IsDirty", value ? "1" : "0"); }
         }
      
         public string TopMaterialName
         {
         	get { return getFieldValue("TopMaterialName"); }
         	set { setFieldValue("TopMaterialName", value); }
         }
      
         public string BottomMaterialName
         {
         	get { return getFieldValue("BottomMaterialName"); }
         	set { setFieldValue("BottomMaterialName", value); }
         }
      
         public string SideMaterialName
         {
         	get { return getFieldValue("SideMaterialName"); }
         	set { setFieldValue("SideMaterialName", value); }
         }
      
      
      #endregion

	}
}