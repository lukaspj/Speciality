using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiRoadEditorCtrl : EditTSCtrl
	{
		public GuiRoadEditorCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiRoadEditorCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiRoadEditorCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiRoadEditorCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiRoadEditorCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiRoadEditorCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiRoadEditorCtrl_create();
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
         				"fnGuiRoadEditorCtrl_deleteNode"), typeof(_deleteNode));
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
         				"fnGuiRoadEditorCtrl_getMode"), typeof(_getMode));
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
         				"fnGuiRoadEditorCtrl_setMode"), typeof(_setMode));
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
         				"fnGuiRoadEditorCtrl_getNodeWidth"), typeof(_getNodeWidth));
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
         				"fnGuiRoadEditorCtrl_setNodeWidth"), typeof(_setNodeWidth));
         	}
         
         	 _setNodeWidthFunc(thisPtr, width);
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
         				"fnGuiRoadEditorCtrl_getNodePosition"), typeof(_getNodePosition));
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
         				"fnGuiRoadEditorCtrl_setNodePosition"), typeof(_setNodePosition));
         	}
         
         	 _setNodePositionFunc(thisPtr, pos);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setSelectedRoad(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pathRoad);
         private static _setSelectedRoad _setSelectedRoadFunc;
         internal static void setSelectedRoad(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string pathRoad)
         {
         	if (_setSelectedRoadFunc == null)
         	{
         		_setSelectedRoadFunc =
         			(_setSelectedRoad)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiRoadEditorCtrl_setSelectedRoad"), typeof(_setSelectedRoad));
         	}
         
         	 _setSelectedRoadFunc(thisPtr, pathRoad);
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
         				"fnGuiRoadEditorCtrl_getSelectedRoad"), typeof(_getSelectedRoad));
         	}
         
         	return  _getSelectedRoadFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getSelectedNode(IntPtr thisPtr);
         private static _getSelectedNode _getSelectedNodeFunc;
         internal static int getSelectedNode(IntPtr thisPtr)
         {
         	if (_getSelectedNodeFunc == null)
         	{
         		_getSelectedNodeFunc =
         			(_getSelectedNode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiRoadEditorCtrl_getSelectedNode"), typeof(_getSelectedNode));
         	}
         
         	return  _getSelectedNodeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _deleteRoad(IntPtr thisPtr);
         private static _deleteRoad _deleteRoadFunc;
         internal static void deleteRoad(IntPtr thisPtr)
         {
         	if (_deleteRoadFunc == null)
         	{
         		_deleteRoadFunc =
         			(_deleteRoad)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiRoadEditorCtrl_deleteRoad"), typeof(_deleteRoad));
         	}
         
         	 _deleteRoadFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiRoadEditorCtrl_create();
         private static _GuiRoadEditorCtrl_create _GuiRoadEditorCtrl_createFunc;
         internal static IntPtr GuiRoadEditorCtrl_create()
         {
         	if (_GuiRoadEditorCtrl_createFunc == null)
         	{
         		_GuiRoadEditorCtrl_createFunc =
         			(_GuiRoadEditorCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiRoadEditorCtrl_create"), typeof(_GuiRoadEditorCtrl_create));
         	}
         
         	return  _GuiRoadEditorCtrl_createFunc();
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
      
         public virtual Point3F getNodePosition()
         {
            return new Point3F(InternalUnsafeMethods.getNodePosition(ObjectPtr));
         }
      
         public virtual void setNodePosition(Point3F pos)
         {
            InternalUnsafeMethods.setNodePosition(ObjectPtr, pos.ToStruct());
         }
      
         public virtual void setSelectedRoad(string pathRoad = "")
         {
            InternalUnsafeMethods.setSelectedRoad(ObjectPtr, pathRoad);
         }
      
         public virtual int getSelectedRoad()
         {
            return InternalUnsafeMethods.getSelectedRoad(ObjectPtr);
         }
      
         public virtual int getSelectedNode()
         {
            return InternalUnsafeMethods.getSelectedNode(ObjectPtr);
         }
      
         public virtual void deleteRoad()
         {
            InternalUnsafeMethods.deleteRoad(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public float DefaultWidth
         {
         	get { return float.Parse(getFieldValue("DefaultWidth")); }
         	set { setFieldValue("DefaultWidth", value.ToString()); }
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
      
         public string MaterialName
         {
         	get { return getFieldValue("MaterialName"); }
         	set { setFieldValue("MaterialName", value); }
         }
      
      
      #endregion

	}
}