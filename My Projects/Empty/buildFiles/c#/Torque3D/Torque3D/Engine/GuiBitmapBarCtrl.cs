using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiBitmapBarCtrl : GuiBitmapCtrl
	{
		public GuiBitmapBarCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiBitmapBarCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiBitmapBarCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiBitmapBarCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiBitmapBarCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiBitmapBarCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiBitmapBarCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiBitmapBarCtrl_create();
         private static _GuiBitmapBarCtrl_create _GuiBitmapBarCtrl_createFunc;
         internal static IntPtr GuiBitmapBarCtrl_create()
         {
         	if (_GuiBitmapBarCtrl_createFunc == null)
         	{
         		_GuiBitmapBarCtrl_createFunc =
         			(_GuiBitmapBarCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiBitmapBarCtrl_create"), typeof(_GuiBitmapBarCtrl_create));
         	}
         
         	return  _GuiBitmapBarCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float Percent
         {
         	get { return float.Parse(getFieldValue("Percent")); }
         	set { setFieldValue("Percent", value.ToString()); }
         }
      
         public bool Vertical
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Vertical")); }
         	set { setFieldValue("Vertical", value ? "1" : "0"); }
         }
      
         public bool FlipClip
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("FlipClip")); }
         	set { setFieldValue("FlipClip", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}