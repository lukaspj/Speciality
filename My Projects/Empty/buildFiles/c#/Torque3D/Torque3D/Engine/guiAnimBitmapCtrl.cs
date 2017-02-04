using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class guiAnimBitmapCtrl : GuiBitmapCtrl
	{
		public guiAnimBitmapCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public guiAnimBitmapCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public guiAnimBitmapCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public guiAnimBitmapCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public guiAnimBitmapCtrl(SimObject pObj) : base(pObj)
		{
		}

		public guiAnimBitmapCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.guiAnimBitmapCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _guiAnimBitmapCtrl_create();
         private static _guiAnimBitmapCtrl_create _guiAnimBitmapCtrl_createFunc;
         internal static IntPtr guiAnimBitmapCtrl_create()
         {
         	if (_guiAnimBitmapCtrl_createFunc == null)
         	{
         		_guiAnimBitmapCtrl_createFunc =
         			(_guiAnimBitmapCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_guiAnimBitmapCtrl_create"), typeof(_guiAnimBitmapCtrl_create));
         	}
         
         	return  _guiAnimBitmapCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public Point2I AnimTexTiling
         {
         	get { return new Point2I(getFieldValue("AnimTexTiling")); }
         	set { setFieldValue("AnimTexTiling", value.ToString()); }
         }
      
         public string AnimTexFrames
         {
         	get { return getFieldValue("AnimTexFrames"); }
         	set { setFieldValue("AnimTexFrames", value); }
         }
      
         public bool Loop
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Loop")); }
         	set { setFieldValue("Loop", value ? "1" : "0"); }
         }
      
         public bool Play
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Play")); }
         	set { setFieldValue("Play", value ? "1" : "0"); }
         }
      
         public bool Reverse
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Reverse")); }
         	set { setFieldValue("Reverse", value ? "1" : "0"); }
         }
      
         public int Fps
         {
         	get { return int.Parse(getFieldValue("Fps")); }
         	set { setFieldValue("Fps", value.ToString()); }
         }
      
         public int CurFrame
         {
         	get { return int.Parse(getFieldValue("CurFrame")); }
         	set { setFieldValue("CurFrame", value.ToString()); }
         }
      
      
      #endregion

	}
}