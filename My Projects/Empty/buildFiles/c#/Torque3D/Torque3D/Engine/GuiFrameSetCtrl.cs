using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiFrameSetCtrl : GuiContainer
	{
		public GuiFrameSetCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiFrameSetCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiFrameSetCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiFrameSetCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiFrameSetCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiFrameSetCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiFrameSetCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _frameBorder(IntPtr thisPtr, int index, [MarshalAs(UnmanagedType.LPWStr)]string state);
         private static _frameBorder _frameBorderFunc;
         internal static void frameBorder(IntPtr thisPtr, int index, [MarshalAs(UnmanagedType.LPWStr)]string state)
         {
         	if (_frameBorderFunc == null)
         	{
         		_frameBorderFunc =
         			(_frameBorder)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiFrameSetCtrl_frameBorder"), typeof(_frameBorder));
         	}
         
         	 _frameBorderFunc(thisPtr, index, state);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _frameMovable(IntPtr thisPtr, int index, [MarshalAs(UnmanagedType.LPWStr)]string state);
         private static _frameMovable _frameMovableFunc;
         internal static void frameMovable(IntPtr thisPtr, int index, [MarshalAs(UnmanagedType.LPWStr)]string state)
         {
         	if (_frameMovableFunc == null)
         	{
         		_frameMovableFunc =
         			(_frameMovable)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiFrameSetCtrl_frameMovable"), typeof(_frameMovable));
         	}
         
         	 _frameMovableFunc(thisPtr, index, state);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _frameMinExtent(IntPtr thisPtr, int index, int width, int height);
         private static _frameMinExtent _frameMinExtentFunc;
         internal static void frameMinExtent(IntPtr thisPtr, int index, int width, int height)
         {
         	if (_frameMinExtentFunc == null)
         	{
         		_frameMinExtentFunc =
         			(_frameMinExtent)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiFrameSetCtrl_frameMinExtent"), typeof(_frameMinExtent));
         	}
         
         	 _frameMinExtentFunc(thisPtr, index, width, height);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _framePadding(IntPtr thisPtr, int index, InternalRectSpacingIStruct padding);
         private static _framePadding _framePaddingFunc;
         internal static void framePadding(IntPtr thisPtr, int index, InternalRectSpacingIStruct padding)
         {
         	if (_framePaddingFunc == null)
         	{
         		_framePaddingFunc =
         			(_framePadding)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiFrameSetCtrl_framePadding"), typeof(_framePadding));
         	}
         
         	 _framePaddingFunc(thisPtr, index, padding);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalRectSpacingIStruct _getFramePadding(IntPtr thisPtr, int index);
         private static _getFramePadding _getFramePaddingFunc;
         internal static InternalRectSpacingIStruct getFramePadding(IntPtr thisPtr, int index)
         {
         	if (_getFramePaddingFunc == null)
         	{
         		_getFramePaddingFunc =
         			(_getFramePadding)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiFrameSetCtrl_getFramePadding"), typeof(_getFramePadding));
         	}
         
         	return  _getFramePaddingFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addColumn(IntPtr thisPtr);
         private static _addColumn _addColumnFunc;
         internal static void addColumn(IntPtr thisPtr)
         {
         	if (_addColumnFunc == null)
         	{
         		_addColumnFunc =
         			(_addColumn)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiFrameSetCtrl_addColumn"), typeof(_addColumn));
         	}
         
         	 _addColumnFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addRow(IntPtr thisPtr);
         private static _addRow _addRowFunc;
         internal static void addRow(IntPtr thisPtr)
         {
         	if (_addRowFunc == null)
         	{
         		_addRowFunc =
         			(_addRow)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiFrameSetCtrl_addRow"), typeof(_addRow));
         	}
         
         	 _addRowFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeColumn(IntPtr thisPtr);
         private static _removeColumn _removeColumnFunc;
         internal static void removeColumn(IntPtr thisPtr)
         {
         	if (_removeColumnFunc == null)
         	{
         		_removeColumnFunc =
         			(_removeColumn)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiFrameSetCtrl_removeColumn"), typeof(_removeColumn));
         	}
         
         	 _removeColumnFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeRow(IntPtr thisPtr);
         private static _removeRow _removeRowFunc;
         internal static void removeRow(IntPtr thisPtr)
         {
         	if (_removeRowFunc == null)
         	{
         		_removeRowFunc =
         			(_removeRow)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiFrameSetCtrl_removeRow"), typeof(_removeRow));
         	}
         
         	 _removeRowFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getColumnCount(IntPtr thisPtr);
         private static _getColumnCount _getColumnCountFunc;
         internal static int getColumnCount(IntPtr thisPtr)
         {
         	if (_getColumnCountFunc == null)
         	{
         		_getColumnCountFunc =
         			(_getColumnCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiFrameSetCtrl_getColumnCount"), typeof(_getColumnCount));
         	}
         
         	return  _getColumnCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getRowCount(IntPtr thisPtr);
         private static _getRowCount _getRowCountFunc;
         internal static int getRowCount(IntPtr thisPtr)
         {
         	if (_getRowCountFunc == null)
         	{
         		_getRowCountFunc =
         			(_getRowCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiFrameSetCtrl_getRowCount"), typeof(_getRowCount));
         	}
         
         	return  _getRowCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getColumnOffset(IntPtr thisPtr, int index);
         private static _getColumnOffset _getColumnOffsetFunc;
         internal static int getColumnOffset(IntPtr thisPtr, int index)
         {
         	if (_getColumnOffsetFunc == null)
         	{
         		_getColumnOffsetFunc =
         			(_getColumnOffset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiFrameSetCtrl_getColumnOffset"), typeof(_getColumnOffset));
         	}
         
         	return  _getColumnOffsetFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getRowOffset(IntPtr thisPtr, int index);
         private static _getRowOffset _getRowOffsetFunc;
         internal static int getRowOffset(IntPtr thisPtr, int index)
         {
         	if (_getRowOffsetFunc == null)
         	{
         		_getRowOffsetFunc =
         			(_getRowOffset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiFrameSetCtrl_getRowOffset"), typeof(_getRowOffset));
         	}
         
         	return  _getRowOffsetFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setColumnOffset(IntPtr thisPtr, int index, int offset);
         private static _setColumnOffset _setColumnOffsetFunc;
         internal static void setColumnOffset(IntPtr thisPtr, int index, int offset)
         {
         	if (_setColumnOffsetFunc == null)
         	{
         		_setColumnOffsetFunc =
         			(_setColumnOffset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiFrameSetCtrl_setColumnOffset"), typeof(_setColumnOffset));
         	}
         
         	 _setColumnOffsetFunc(thisPtr, index, offset);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setRowOffset(IntPtr thisPtr, int index, int offset);
         private static _setRowOffset _setRowOffsetFunc;
         internal static void setRowOffset(IntPtr thisPtr, int index, int offset)
         {
         	if (_setRowOffsetFunc == null)
         	{
         		_setRowOffsetFunc =
         			(_setRowOffset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiFrameSetCtrl_setRowOffset"), typeof(_setRowOffset));
         	}
         
         	 _setRowOffsetFunc(thisPtr, index, offset);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _updateSizes(IntPtr thisPtr);
         private static _updateSizes _updateSizesFunc;
         internal static void updateSizes(IntPtr thisPtr)
         {
         	if (_updateSizesFunc == null)
         	{
         		_updateSizesFunc =
         			(_updateSizes)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiFrameSetCtrl_updateSizes"), typeof(_updateSizes));
         	}
         
         	 _updateSizesFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiFrameSetCtrl_create();
         private static _GuiFrameSetCtrl_create _GuiFrameSetCtrl_createFunc;
         internal static IntPtr GuiFrameSetCtrl_create()
         {
         	if (_GuiFrameSetCtrl_createFunc == null)
         	{
         		_GuiFrameSetCtrl_createFunc =
         			(_GuiFrameSetCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiFrameSetCtrl_create"), typeof(_GuiFrameSetCtrl_create));
         	}
         
         	return  _GuiFrameSetCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void frameBorder(int index, string state = "dynamic")
         {
            InternalUnsafeMethods.frameBorder(ObjectPtr, index, state);
         }
      
         public virtual void frameMovable(int index, string state = "dynamic")
         {
            InternalUnsafeMethods.frameMovable(ObjectPtr, index, state);
         }
      
         public virtual void frameMinExtent(int index, int width, int height)
         {
            InternalUnsafeMethods.frameMinExtent(ObjectPtr, index, width, height);
         }
      
         public virtual void framePadding(int index, RectSpacingI padding)
         {
            InternalUnsafeMethods.framePadding(ObjectPtr, index, padding.ToStruct());
         }
      
         public virtual RectSpacingI getFramePadding(int index)
         {
            return new RectSpacingI(InternalUnsafeMethods.getFramePadding(ObjectPtr, index));
         }
      
         public virtual void addColumn()
         {
            InternalUnsafeMethods.addColumn(ObjectPtr);
         }
      
         public virtual void addRow()
         {
            InternalUnsafeMethods.addRow(ObjectPtr);
         }
      
         public virtual void removeColumn()
         {
            InternalUnsafeMethods.removeColumn(ObjectPtr);
         }
      
         public virtual void removeRow()
         {
            InternalUnsafeMethods.removeRow(ObjectPtr);
         }
      
         public virtual int getColumnCount()
         {
            return InternalUnsafeMethods.getColumnCount(ObjectPtr);
         }
      
         public virtual int getRowCount()
         {
            return InternalUnsafeMethods.getRowCount(ObjectPtr);
         }
      
         public virtual int getColumnOffset(int index)
         {
            return InternalUnsafeMethods.getColumnOffset(ObjectPtr, index);
         }
      
         public virtual int getRowOffset(int index)
         {
            return InternalUnsafeMethods.getRowOffset(ObjectPtr, index);
         }
      
         public virtual void setColumnOffset(int index, int offset)
         {
            InternalUnsafeMethods.setColumnOffset(ObjectPtr, index, offset);
         }
      
         public virtual void setRowOffset(int index, int offset)
         {
            InternalUnsafeMethods.setRowOffset(ObjectPtr, index, offset);
         }
      
         public virtual void updateSizes()
         {
            InternalUnsafeMethods.updateSizes(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public string Columns
         {
         	get { return getFieldValue("Columns"); }
         	set { setFieldValue("Columns", value); }
         }
      
         public string Rows
         {
         	get { return getFieldValue("Rows"); }
         	set { setFieldValue("Rows", value); }
         }
      
         public int BorderWidth
         {
         	get { return int.Parse(getFieldValue("BorderWidth")); }
         	set { setFieldValue("BorderWidth", value.ToString()); }
         }
      
         public ColorI BorderColor
         {
         	get { return new ColorI(getFieldValue("BorderColor")); }
         	set { setFieldValue("BorderColor", value.ToString()); }
         }
      
         public GuiFrameState BorderEnable
         {
         	get { return (GuiFrameState)Enum.Parse(typeof(GuiFrameState), getFieldValue("BorderEnable"), true); }
         	set { setFieldValue("BorderEnable", value.ToString()); }
         }
      
         public GuiFrameState BorderMovable
         {
         	get { return (GuiFrameState)Enum.Parse(typeof(GuiFrameState), getFieldValue("BorderMovable"), true); }
         	set { setFieldValue("BorderMovable", value.ToString()); }
         }
      
         public bool AutoBalance
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AutoBalance")); }
         	set { setFieldValue("AutoBalance", value ? "1" : "0"); }
         }
      
         public int FudgeFactor
         {
         	get { return int.Parse(getFieldValue("FudgeFactor")); }
         	set { setFieldValue("FudgeFactor", value.ToString()); }
         }
      
      
      #endregion

	}
}