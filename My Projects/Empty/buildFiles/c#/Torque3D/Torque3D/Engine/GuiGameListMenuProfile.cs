using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiGameListMenuProfile : GuiControlProfile
	{
		public GuiGameListMenuProfile(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiGameListMenuProfile(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiGameListMenuProfile(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiGameListMenuProfile(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiGameListMenuProfile(SimObject pObj) : base(pObj)
		{
		}

		public GuiGameListMenuProfile(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiGameListMenuProfile_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiGameListMenuProfile_create();
         private static _GuiGameListMenuProfile_create _GuiGameListMenuProfile_createFunc;
         internal static IntPtr GuiGameListMenuProfile_create()
         {
         	if (_GuiGameListMenuProfile_createFunc == null)
         	{
         		_GuiGameListMenuProfile_createFunc =
         			(_GuiGameListMenuProfile_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiGameListMenuProfile_create"), typeof(_GuiGameListMenuProfile_create));
         	}
         
         	return  _GuiGameListMenuProfile_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public Point2I HitAreaUpperLeft
         {
         	get { return new Point2I(getFieldValue("HitAreaUpperLeft")); }
         	set { setFieldValue("HitAreaUpperLeft", value.ToString()); }
         }
      
         public Point2I HitAreaLowerRight
         {
         	get { return new Point2I(getFieldValue("HitAreaLowerRight")); }
         	set { setFieldValue("HitAreaLowerRight", value.ToString()); }
         }
      
         public Point2I IconOffset
         {
         	get { return new Point2I(getFieldValue("IconOffset")); }
         	set { setFieldValue("IconOffset", value.ToString()); }
         }
      
         public Point2I RowSize
         {
         	get { return new Point2I(getFieldValue("RowSize")); }
         	set { setFieldValue("RowSize", value.ToString()); }
         }
      
      
      #endregion

	}
}