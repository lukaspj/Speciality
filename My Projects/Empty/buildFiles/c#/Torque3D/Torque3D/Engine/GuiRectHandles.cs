using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiRectHandles : GuiControl
	{
		public GuiRectHandles(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiRectHandles(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiRectHandles(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiRectHandles(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiRectHandles(SimObject pObj) : base(pObj)
		{
		}

		public GuiRectHandles(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiRectHandles_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiRectHandles_create();
         private static _GuiRectHandles_create _GuiRectHandles_createFunc;
         internal static IntPtr GuiRectHandles_create()
         {
         	if (_GuiRectHandles_createFunc == null)
         	{
         		_GuiRectHandles_createFunc =
         			(_GuiRectHandles_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiRectHandles_create"), typeof(_GuiRectHandles_create));
         	}
         
         	return  _GuiRectHandles_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public RectF HandleRect
         {
         	get { return new RectF(getFieldValue("HandleRect")); }
         	set { setFieldValue("HandleRect", value.ToString()); }
         }
      
         public int HandleSize
         {
         	get { return int.Parse(getFieldValue("HandleSize")); }
         	set { setFieldValue("HandleSize", value.ToString()); }
         }
      
         public bool UseCustomColor
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("UseCustomColor")); }
         	set { setFieldValue("UseCustomColor", value ? "1" : "0"); }
         }
      
         public ColorI HandleColor
         {
         	get { return new ColorI(getFieldValue("HandleColor")); }
         	set { setFieldValue("HandleColor", value.ToString()); }
         }
      
      
      #endregion

	}
}