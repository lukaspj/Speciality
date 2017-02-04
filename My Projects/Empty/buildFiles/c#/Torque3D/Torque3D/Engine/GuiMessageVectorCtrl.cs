using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiMessageVectorCtrl : GuiControl
	{
		public GuiMessageVectorCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiMessageVectorCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiMessageVectorCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiMessageVectorCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiMessageVectorCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiMessageVectorCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiMessageVectorCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _attach(IntPtr thisPtr, IntPtr item);
         private static _attach _attachFunc;
         internal static bool attach(IntPtr thisPtr, IntPtr item)
         {
         	if (_attachFunc == null)
         	{
         		_attachFunc =
         			(_attach)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMessageVectorCtrl_attach"), typeof(_attach));
         	}
         
         	return  _attachFunc(thisPtr, item);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _detach(IntPtr thisPtr);
         private static _detach _detachFunc;
         internal static void detach(IntPtr thisPtr)
         {
         	if (_detachFunc == null)
         	{
         		_detachFunc =
         			(_detach)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMessageVectorCtrl_detach"), typeof(_detach));
         	}
         
         	 _detachFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiMessageVectorCtrl_create();
         private static _GuiMessageVectorCtrl_create _GuiMessageVectorCtrl_createFunc;
         internal static IntPtr GuiMessageVectorCtrl_create()
         {
         	if (_GuiMessageVectorCtrl_createFunc == null)
         	{
         		_GuiMessageVectorCtrl_createFunc =
         			(_GuiMessageVectorCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiMessageVectorCtrl_create"), typeof(_GuiMessageVectorCtrl_create));
         	}
         
         	return  _GuiMessageVectorCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool attach(MessageVector item)
         {
            return InternalUnsafeMethods.attach(ObjectPtr, item.ObjectPtr);
         }
      
         public virtual void detach()
         {
            InternalUnsafeMethods.detach(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public int LineSpacing
         {
         	get { return int.Parse(getFieldValue("LineSpacing")); }
         	set { setFieldValue("LineSpacing", value.ToString()); }
         }
      
         public int LineContinuedIndex
         {
         	get { return int.Parse(getFieldValue("LineContinuedIndex")); }
         	set { setFieldValue("LineContinuedIndex", value.ToString()); }
         }
      
         public DynamicFieldVector<string> AllowedMatches
         {
         	get { return new DynamicFieldVector<string>(this, "AllowedMatches", 16, val => val, obj => obj); }
         }
      
         public ColorI MatchColor
         {
         	get { return new ColorI(getFieldValue("MatchColor")); }
         	set { setFieldValue("MatchColor", value.ToString()); }
         }
      
         public int MaxColorIndex
         {
         	get { return int.Parse(getFieldValue("MaxColorIndex")); }
         	set { setFieldValue("MaxColorIndex", value.ToString()); }
         }
      
      
      #endregion

	}
}