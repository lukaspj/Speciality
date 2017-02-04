using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiCursor : SimObject
	{
		public GuiCursor(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiCursor(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiCursor(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiCursor(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiCursor(SimObject pObj) : base(pObj)
		{
		}

		public GuiCursor(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiCursor_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiCursor_create();
         private static _GuiCursor_create _GuiCursor_createFunc;
         internal static IntPtr GuiCursor_create()
         {
         	if (_GuiCursor_createFunc == null)
         	{
         		_GuiCursor_createFunc =
         			(_GuiCursor_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiCursor_create"), typeof(_GuiCursor_create));
         	}
         
         	return  _GuiCursor_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public Point2I HotSpot
         {
         	get { return new Point2I(getFieldValue("HotSpot")); }
         	set { setFieldValue("HotSpot", value.ToString()); }
         }
      
         public Point2F RenderOffset
         {
         	get { return new Point2F(getFieldValue("RenderOffset")); }
         	set { setFieldValue("RenderOffset", value.ToString()); }
         }
      
         public string BitmapName
         {
         	get { return getFieldValue("BitmapName"); }
         	set { setFieldValue("BitmapName", value); }
         }
      
      
      #endregion

	}
}