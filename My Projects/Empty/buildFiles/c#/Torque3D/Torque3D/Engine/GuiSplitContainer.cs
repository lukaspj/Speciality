using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiSplitContainer : GuiContainer
	{
		public GuiSplitContainer(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiSplitContainer(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiSplitContainer(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiSplitContainer(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiSplitContainer(SimObject pObj) : base(pObj)
		{
		}

		public GuiSplitContainer(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiSplitContainer_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiSplitContainer_create();
         private static _GuiSplitContainer_create _GuiSplitContainer_createFunc;
         internal static IntPtr GuiSplitContainer_create()
         {
         	if (_GuiSplitContainer_createFunc == null)
         	{
         		_GuiSplitContainer_createFunc =
         			(_GuiSplitContainer_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiSplitContainer_create"), typeof(_GuiSplitContainer_create));
         	}
         
         	return  _GuiSplitContainer_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public GuiSplitOrientation Orientation
         {
         	get { return (GuiSplitOrientation)Enum.Parse(typeof(GuiSplitOrientation), getFieldValue("Orientation"), true); }
         	set { setFieldValue("Orientation", value.ToString()); }
         }
      
         public int SplitterSize
         {
         	get { return int.Parse(getFieldValue("SplitterSize")); }
         	set { setFieldValue("SplitterSize", value.ToString()); }
         }
      
         public Point2I SplitPoint
         {
         	get { return new Point2I(getFieldValue("SplitPoint")); }
         	set { setFieldValue("SplitPoint", value.ToString()); }
         }
      
         public GuiSplitFixedPanel FixedPanel
         {
         	get { return (GuiSplitFixedPanel)Enum.Parse(typeof(GuiSplitFixedPanel), getFieldValue("FixedPanel"), true); }
         	set { setFieldValue("FixedPanel", value.ToString()); }
         }
      
         public int FixedSize
         {
         	get { return int.Parse(getFieldValue("FixedSize")); }
         	set { setFieldValue("FixedSize", value.ToString()); }
         }
      
      
      #endregion

	}
}