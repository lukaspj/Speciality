using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiSpeedometerHud : GuiBitmapCtrl
	{
		public GuiSpeedometerHud(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiSpeedometerHud(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiSpeedometerHud(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiSpeedometerHud(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiSpeedometerHud(SimObject pObj) : base(pObj)
		{
		}

		public GuiSpeedometerHud(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiSpeedometerHud_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiSpeedometerHud_create();
         private static _GuiSpeedometerHud_create _GuiSpeedometerHud_createFunc;
         internal static IntPtr GuiSpeedometerHud_create()
         {
         	if (_GuiSpeedometerHud_createFunc == null)
         	{
         		_GuiSpeedometerHud_createFunc =
         			(_GuiSpeedometerHud_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiSpeedometerHud_create"), typeof(_GuiSpeedometerHud_create));
         	}
         
         	return  _GuiSpeedometerHud_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public float MaxSpeed
         {
         	get { return float.Parse(getFieldValue("MaxSpeed")); }
         	set { setFieldValue("MaxSpeed", value.ToString()); }
         }
      
         public float MinAngle
         {
         	get { return float.Parse(getFieldValue("MinAngle")); }
         	set { setFieldValue("MinAngle", value.ToString()); }
         }
      
         public float MaxAngle
         {
         	get { return float.Parse(getFieldValue("MaxAngle")); }
         	set { setFieldValue("MaxAngle", value.ToString()); }
         }
      
         public Point2F Center
         {
         	get { return new Point2F(getFieldValue("Center")); }
         	set { setFieldValue("Center", value.ToString()); }
         }
      
         public float Length
         {
         	get { return float.Parse(getFieldValue("Length")); }
         	set { setFieldValue("Length", value.ToString()); }
         }
      
         public float Width
         {
         	get { return float.Parse(getFieldValue("Width")); }
         	set { setFieldValue("Width", value.ToString()); }
         }
      
         public float Tail
         {
         	get { return float.Parse(getFieldValue("Tail")); }
         	set { setFieldValue("Tail", value.ToString()); }
         }
      
      
      #endregion

	}
}