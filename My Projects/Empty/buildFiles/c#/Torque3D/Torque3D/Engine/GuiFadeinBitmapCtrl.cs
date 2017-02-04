using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiFadeinBitmapCtrl : GuiBitmapCtrl
	{
		public GuiFadeinBitmapCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiFadeinBitmapCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiFadeinBitmapCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiFadeinBitmapCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiFadeinBitmapCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiFadeinBitmapCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiFadeinBitmapCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiFadeinBitmapCtrl_create();
         private static _GuiFadeinBitmapCtrl_create _GuiFadeinBitmapCtrl_createFunc;
         internal static IntPtr GuiFadeinBitmapCtrl_create()
         {
         	if (_GuiFadeinBitmapCtrl_createFunc == null)
         	{
         		_GuiFadeinBitmapCtrl_createFunc =
         			(_GuiFadeinBitmapCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiFadeinBitmapCtrl_create"), typeof(_GuiFadeinBitmapCtrl_create));
         	}
         
         	return  _GuiFadeinBitmapCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public ColorF FadeColor
         {
         	get { return new ColorF(getFieldValue("FadeColor")); }
         	set { setFieldValue("FadeColor", value.ToString()); }
         }
      
         public int FadeInTime
         {
         	get { return int.Parse(getFieldValue("FadeInTime")); }
         	set { setFieldValue("FadeInTime", value.ToString()); }
         }
      
         public int WaitTime
         {
         	get { return int.Parse(getFieldValue("WaitTime")); }
         	set { setFieldValue("WaitTime", value.ToString()); }
         }
      
         public int FadeOutTime
         {
         	get { return int.Parse(getFieldValue("FadeOutTime")); }
         	set { setFieldValue("FadeOutTime", value.ToString()); }
         }
      
         public EaseF FadeInEase
         {
         	get { return new EaseF(getFieldValue("FadeInEase")); }
         	set { setFieldValue("FadeInEase", value.ToString()); }
         }
      
         public EaseF FadeOutEase
         {
         	get { return new EaseF(getFieldValue("FadeOutEase")); }
         	set { setFieldValue("FadeOutEase", value.ToString()); }
         }
      
         public bool Done
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Done")); }
         	set { setFieldValue("Done", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}