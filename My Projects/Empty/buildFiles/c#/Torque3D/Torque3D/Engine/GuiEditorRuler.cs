using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiEditorRuler : GuiControl
	{
		public GuiEditorRuler(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiEditorRuler(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiEditorRuler(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiEditorRuler(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiEditorRuler(SimObject pObj) : base(pObj)
		{
		}

		public GuiEditorRuler(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiEditorRuler_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiEditorRuler_create();
         private static _GuiEditorRuler_create _GuiEditorRuler_createFunc;
         internal static IntPtr GuiEditorRuler_create()
         {
         	if (_GuiEditorRuler_createFunc == null)
         	{
         		_GuiEditorRuler_createFunc =
         			(_GuiEditorRuler_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiEditorRuler_create"), typeof(_GuiEditorRuler_create));
         	}
         
         	return  _GuiEditorRuler_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string RefCtrl
         {
         	get { return getFieldValue("RefCtrl"); }
         	set { setFieldValue("RefCtrl", value); }
         }
      
         public string EditCtrl
         {
         	get { return getFieldValue("EditCtrl"); }
         	set { setFieldValue("EditCtrl", value); }
         }
      
      
      #endregion

	}
}