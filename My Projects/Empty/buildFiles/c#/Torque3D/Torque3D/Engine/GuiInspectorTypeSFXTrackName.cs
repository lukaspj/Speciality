using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiInspectorTypeSFXTrackName : GuiInspectorDatablockField
	{
		public GuiInspectorTypeSFXTrackName(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiInspectorTypeSFXTrackName(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiInspectorTypeSFXTrackName(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiInspectorTypeSFXTrackName(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiInspectorTypeSFXTrackName(SimObject pObj) : base(pObj)
		{
		}

		public GuiInspectorTypeSFXTrackName(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiInspectorTypeSFXTrackName_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiInspectorTypeSFXTrackName_create();
         private static _GuiInspectorTypeSFXTrackName_create _GuiInspectorTypeSFXTrackName_createFunc;
         internal static IntPtr GuiInspectorTypeSFXTrackName_create()
         {
         	if (_GuiInspectorTypeSFXTrackName_createFunc == null)
         	{
         		_GuiInspectorTypeSFXTrackName_createFunc =
         			(_GuiInspectorTypeSFXTrackName_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiInspectorTypeSFXTrackName_create"), typeof(_GuiInspectorTypeSFXTrackName_create));
         	}
         
         	return  _GuiInspectorTypeSFXTrackName_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}