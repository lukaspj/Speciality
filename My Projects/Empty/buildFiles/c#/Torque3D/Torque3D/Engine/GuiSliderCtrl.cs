using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiSliderCtrl : GuiControl
	{
		public GuiSliderCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiSliderCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiSliderCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiSliderCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiSliderCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiSliderCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiSliderCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getValue(IntPtr thisPtr);
         private static _getValue _getValueFunc;
         internal static float getValue(IntPtr thisPtr)
         {
         	if (_getValueFunc == null)
         	{
         		_getValueFunc =
         			(_getValue)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiSliderCtrl_getValue"), typeof(_getValue));
         	}
         
         	return  _getValueFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setValue(IntPtr thisPtr, float pos, bool doCallback);
         private static _setValue _setValueFunc;
         internal static void setValue(IntPtr thisPtr, float pos, bool doCallback)
         {
         	if (_setValueFunc == null)
         	{
         		_setValueFunc =
         			(_setValue)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiSliderCtrl_setValue"), typeof(_setValue));
         	}
         
         	 _setValueFunc(thisPtr, pos, doCallback);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isThumbBeingDragged(IntPtr thisPtr);
         private static _isThumbBeingDragged _isThumbBeingDraggedFunc;
         internal static bool isThumbBeingDragged(IntPtr thisPtr)
         {
         	if (_isThumbBeingDraggedFunc == null)
         	{
         		_isThumbBeingDraggedFunc =
         			(_isThumbBeingDragged)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiSliderCtrl_isThumbBeingDragged"), typeof(_isThumbBeingDragged));
         	}
         
         	return  _isThumbBeingDraggedFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiSliderCtrl_create();
         private static _GuiSliderCtrl_create _GuiSliderCtrl_createFunc;
         internal static IntPtr GuiSliderCtrl_create()
         {
         	if (_GuiSliderCtrl_createFunc == null)
         	{
         		_GuiSliderCtrl_createFunc =
         			(_GuiSliderCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiSliderCtrl_create"), typeof(_GuiSliderCtrl_create));
         	}
         
         	return  _GuiSliderCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual float getValue()
         {
            return InternalUnsafeMethods.getValue(ObjectPtr);
         }
      
         public virtual void setValue(float pos, bool doCallback = false)
         {
            InternalUnsafeMethods.setValue(ObjectPtr, pos, doCallback);
         }
      
         public virtual bool isThumbBeingDragged()
         {
            return InternalUnsafeMethods.isThumbBeingDragged(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public Point2F Range
         {
         	get { return new Point2F(getFieldValue("Range")); }
         	set { setFieldValue("Range", value.ToString()); }
         }
      
         public int Ticks
         {
         	get { return int.Parse(getFieldValue("Ticks")); }
         	set { setFieldValue("Ticks", value.ToString()); }
         }
      
         public bool Snap
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Snap")); }
         	set { setFieldValue("Snap", value ? "1" : "0"); }
         }
      
         public float Value
         {
         	get { return float.Parse(getFieldValue("Value")); }
         	set { setFieldValue("Value", value.ToString()); }
         }
      
      
      #endregion

	}
}