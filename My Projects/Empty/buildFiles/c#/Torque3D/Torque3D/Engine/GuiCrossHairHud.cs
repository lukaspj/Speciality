using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiCrossHairHud : GuiBitmapCtrl
	{
		public GuiCrossHairHud(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiCrossHairHud(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiCrossHairHud(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiCrossHairHud(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiCrossHairHud(SimObject pObj) : base(pObj)
		{
		}

		public GuiCrossHairHud(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiCrossHairHud_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiCrossHairHud_create();
         private static _GuiCrossHairHud_create _GuiCrossHairHud_createFunc;
         internal static IntPtr GuiCrossHairHud_create()
         {
         	if (_GuiCrossHairHud_createFunc == null)
         	{
         		_GuiCrossHairHud_createFunc =
         			(_GuiCrossHairHud_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiCrossHairHud_create"), typeof(_GuiCrossHairHud_create));
         	}
         
         	return  _GuiCrossHairHud_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public ColorF DamageFillColor
         {
         	get { return new ColorF(getFieldValue("DamageFillColor")); }
         	set { setFieldValue("DamageFillColor", value.ToString()); }
         }
      
         public ColorF DamageFrameColor
         {
         	get { return new ColorF(getFieldValue("DamageFrameColor")); }
         	set { setFieldValue("DamageFrameColor", value.ToString()); }
         }
      
         public Point2I DamageRect
         {
         	get { return new Point2I(getFieldValue("DamageRect")); }
         	set { setFieldValue("DamageRect", value.ToString()); }
         }
      
         public Point2I DamageOffset
         {
         	get { return new Point2I(getFieldValue("DamageOffset")); }
         	set { setFieldValue("DamageOffset", value.ToString()); }
         }
      
      
      #endregion

	}
}