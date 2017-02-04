using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiContainer : GuiControl
	{
		public GuiContainer(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiContainer(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiContainer(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiContainer(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiContainer(SimObject pObj) : base(pObj)
		{
		}

		public GuiContainer(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiContainer_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiContainer_create();
         private static _GuiContainer_create _GuiContainer_createFunc;
         internal static IntPtr GuiContainer_create()
         {
         	if (_GuiContainer_createFunc == null)
         	{
         		_GuiContainer_createFunc =
         			(_GuiContainer_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiContainer_create"), typeof(_GuiContainer_create));
         	}
         
         	return  _GuiContainer_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public GuiDockingType Docking
         {
         	get { return (GuiDockingType)Enum.Parse(typeof(GuiDockingType), getFieldValue("Docking"), true); }
         	set { setFieldValue("Docking", value.ToString()); }
         }
      
         public RectSpacingI Margin
         {
         	get { return new RectSpacingI(getFieldValue("Margin")); }
         	set { setFieldValue("Margin", value.ToString()); }
         }
      
         public RectSpacingI Padding
         {
         	get { return new RectSpacingI(getFieldValue("Padding")); }
         	set { setFieldValue("Padding", value.ToString()); }
         }
      
         public bool AnchorTop
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AnchorTop")); }
         	set { setFieldValue("AnchorTop", value ? "1" : "0"); }
         }
      
         public bool AnchorBottom
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AnchorBottom")); }
         	set { setFieldValue("AnchorBottom", value ? "1" : "0"); }
         }
      
         public bool AnchorLeft
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AnchorLeft")); }
         	set { setFieldValue("AnchorLeft", value ? "1" : "0"); }
         }
      
         public bool AnchorRight
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AnchorRight")); }
         	set { setFieldValue("AnchorRight", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}