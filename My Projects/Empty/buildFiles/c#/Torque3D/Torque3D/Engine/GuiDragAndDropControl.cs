using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiDragAndDropControl : GuiControl
	{
		public GuiDragAndDropControl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiDragAndDropControl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiDragAndDropControl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiDragAndDropControl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiDragAndDropControl(SimObject pObj) : base(pObj)
		{
		}

		public GuiDragAndDropControl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiDragAndDropControl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _startDragging(IntPtr thisPtr, int x, int y);
         private static _startDragging _startDraggingFunc;
         internal static void startDragging(IntPtr thisPtr, int x, int y)
         {
         	if (_startDraggingFunc == null)
         	{
         		_startDraggingFunc =
         			(_startDragging)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiDragAndDropControl_startDragging"), typeof(_startDragging));
         	}
         
         	 _startDraggingFunc(thisPtr, x, y);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiDragAndDropControl_create();
         private static _GuiDragAndDropControl_create _GuiDragAndDropControl_createFunc;
         internal static IntPtr GuiDragAndDropControl_create()
         {
         	if (_GuiDragAndDropControl_createFunc == null)
         	{
         		_GuiDragAndDropControl_createFunc =
         			(_GuiDragAndDropControl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiDragAndDropControl_create"), typeof(_GuiDragAndDropControl_create));
         	}
         
         	return  _GuiDragAndDropControl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void startDragging(int x = 0, int y = 0)
         {
            InternalUnsafeMethods.startDragging(ObjectPtr, x, y);
         }
      
      
      #endregion


      #region Properties
      
      
         public bool DeleteOnMouseUp
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("DeleteOnMouseUp")); }
         	set { setFieldValue("DeleteOnMouseUp", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}