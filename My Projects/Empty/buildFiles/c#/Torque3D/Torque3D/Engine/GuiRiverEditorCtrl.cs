using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiRiverEditorCtrl : EditTSCtrl
	{
		public GuiRiverEditorCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiRiverEditorCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiRiverEditorCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiRiverEditorCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiRiverEditorCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiRiverEditorCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiRiverEditorCtrl_create();
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
         				"fnGuiRiverEditorCtrl_deleteNode"), typeof(_deleteNode));
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
         				"fnGuiRiverEditorCtrl_getMode"), typeof(_getMode));
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
         				"fnGuiRiverEditorCtrl_setMode"), typeof(_setMode));
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
         				"fnGuiRiverEditorCtrl_getNodeWidth"), typeof(_getNodeWidth));
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
         				"fnGuiRiverEditorCtrl_setNodeWidth"), typeof(_setNodeWidth));
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
         				"fnGuiRiverEditorCtrl_getNodeDepth"), typeof(_getNodeDepth));
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
         				"fnGuiRiverEditorCtrl_setNodeDepth"), typeof(_setNodeDepth));
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
         				"fnGuiRiverEditorCtrl_getNodePosition"), typeof(_getNodePosition));
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
         				"fnGuiRiverEditorCtrl_setNodePosition"), typeof(_setNodePosition));
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
         				"fnGuiRiverEditorCtrl_getNodeNormal"), typeof(_getNodeNormal));
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
         				"fnGuiRiverEditorCtrl_setNodeNormal"), typeof(_setNodeNormal));
         	}
         
         	 _setNodeNormalFunc(thisPtr, normal);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setSelectedRiver(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string objName);
         private static _setSelectedRiver _setSelectedRiverFunc;
         internal static void setSelectedRiver(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string objName)
         {
         	if (_setSelectedRiverFunc == null)
         	{
         		_setSelectedRiverFunc =
         			(_setSelectedRiver)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiRiverEditorCtrl_setSelectedRiver"), typeof(_setSelectedRiver));
         	}
         
         	 _setSelectedRiverFunc(thisPtr, objName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getSelectedRiver(IntPtr thisPtr);
         private static _getSelectedRiver _getSelectedRiverFunc;
         internal static int getSelectedRiver(IntPtr thisPtr)
         {
         	if (_getSelectedRiverFunc == null)
         	{
         		_getSelectedRiverFunc =
         			(_getSelectedRiver)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiRiverEditorCtrl_getSelectedRiver"), typeof(_getSelectedRiver));
         	}
         
         	return  _getSelectedRiverFunc(thisPtr);
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
         				"fnGuiRiverEditorCtrl_regenerate"), typeof(_regenerate));
         	}
         
         	 _regenerateFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiRiverEditorCtrl_create();
         private static _GuiRiverEditorCtrl_create _GuiRiverEditorCtrl_createFunc;
         internal static IntPtr GuiRiverEditorCtrl_create()
         {
         	if (_GuiRiverEditorCtrl_createFunc == null)
         	{
         		_GuiRiverEditorCtrl_createFunc =
         			(_GuiRiverEditorCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiRiverEditorCtrl_create"), typeof(_GuiRiverEditorCtrl_create));
         	}
         
         	return  _GuiRiverEditorCtrl_createFunc();
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
      
         public virtual void setSelectedRiver(string objName = "")
         {
            InternalUnsafeMethods.setSelectedRiver(ObjectPtr, objName);
         }
      
         public virtual int getSelectedRiver()
         {
            return InternalUnsafeMethods.getSelectedRiver(ObjectPtr);
         }
      
         public virtual void regenerate()
         {
            InternalUnsafeMethods.regenerate(ObjectPtr);
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
      
      
      #endregion

	}
}