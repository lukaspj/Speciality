using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiGameListOptionsProfile : GuiGameListMenuProfile
	{
		public GuiGameListOptionsProfile(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiGameListOptionsProfile(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiGameListOptionsProfile(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiGameListOptionsProfile(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiGameListOptionsProfile(SimObject pObj) : base(pObj)
		{
		}

		public GuiGameListOptionsProfile(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiGameListOptionsProfile_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiGameListOptionsProfile_create();
         private static _GuiGameListOptionsProfile_create _GuiGameListOptionsProfile_createFunc;
         internal static IntPtr GuiGameListOptionsProfile_create()
         {
         	if (_GuiGameListOptionsProfile_createFunc == null)
         	{
         		_GuiGameListOptionsProfile_createFunc =
         			(_GuiGameListOptionsProfile_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiGameListOptionsProfile_create"), typeof(_GuiGameListOptionsProfile_create));
         	}
         
         	return  _GuiGameListOptionsProfile_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public int ColumnSplit
         {
         	get { return int.Parse(getFieldValue("ColumnSplit")); }
         	set { setFieldValue("ColumnSplit", value.ToString()); }
         }
      
         public int RightPad
         {
         	get { return int.Parse(getFieldValue("RightPad")); }
         	set { setFieldValue("RightPad", value.ToString()); }
         }
      
      
      #endregion

	}
}