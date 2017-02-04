using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiMissionAreaEditorCtrl : EditTSCtrl
	{
		public GuiMissionAreaEditorCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiMissionAreaEditorCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiMissionAreaEditorCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiMissionAreaEditorCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiMissionAreaEditorCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiMissionAreaEditorCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiMissionAreaEditorCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setSelectedMissionArea(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string missionAreaName);
         private static _setSelectedMissionArea _setSelectedMissionAreaFunc;
         internal static void setSelectedMissionArea(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string missionAreaName)
         {
         	if (_setSelectedMissionAreaFunc == null)
         	{
         		_setSelectedMissionAreaFunc =
         			(_setSelectedMissionArea)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMissionAreaEditorCtrl_setSelectedMissionArea"), typeof(_setSelectedMissionArea));
         	}
         
         	 _setSelectedMissionAreaFunc(thisPtr, missionAreaName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getSelectedMissionArea(IntPtr thisPtr);
         private static _getSelectedMissionArea _getSelectedMissionAreaFunc;
         internal static IntPtr getSelectedMissionArea(IntPtr thisPtr)
         {
         	if (_getSelectedMissionAreaFunc == null)
         	{
         		_getSelectedMissionAreaFunc =
         			(_getSelectedMissionArea)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMissionAreaEditorCtrl_getSelectedMissionArea"), typeof(_getSelectedMissionArea));
         	}
         
         	return  _getSelectedMissionAreaFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiMissionAreaEditorCtrl_create();
         private static _GuiMissionAreaEditorCtrl_create _GuiMissionAreaEditorCtrl_createFunc;
         internal static IntPtr GuiMissionAreaEditorCtrl_create()
         {
         	if (_GuiMissionAreaEditorCtrl_createFunc == null)
         	{
         		_GuiMissionAreaEditorCtrl_createFunc =
         			(_GuiMissionAreaEditorCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiMissionAreaEditorCtrl_create"), typeof(_GuiMissionAreaEditorCtrl_create));
         	}
         
         	return  _GuiMissionAreaEditorCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setSelectedMissionArea(string missionAreaName = "")
         {
            InternalUnsafeMethods.setSelectedMissionArea(ObjectPtr, missionAreaName);
         }
      
         public virtual string getSelectedMissionArea()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getSelectedMissionArea(ObjectPtr));
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}