using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiMissionAreaCtrl : GuiBitmapCtrl
	{
		public GuiMissionAreaCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiMissionAreaCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiMissionAreaCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiMissionAreaCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiMissionAreaCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiMissionAreaCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiMissionAreaCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMissionArea(IntPtr thisPtr, IntPtr area);
         private static _setMissionArea _setMissionAreaFunc;
         internal static void setMissionArea(IntPtr thisPtr, IntPtr area)
         {
         	if (_setMissionAreaFunc == null)
         	{
         		_setMissionAreaFunc =
         			(_setMissionArea)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMissionAreaCtrl_setMissionArea"), typeof(_setMissionArea));
         	}
         
         	 _setMissionAreaFunc(thisPtr, area);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _updateTerrain(IntPtr thisPtr);
         private static _updateTerrain _updateTerrainFunc;
         internal static void updateTerrain(IntPtr thisPtr)
         {
         	if (_updateTerrainFunc == null)
         	{
         		_updateTerrainFunc =
         			(_updateTerrain)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMissionAreaCtrl_updateTerrain"), typeof(_updateTerrain));
         	}
         
         	 _updateTerrainFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiMissionAreaCtrl_create();
         private static _GuiMissionAreaCtrl_create _GuiMissionAreaCtrl_createFunc;
         internal static IntPtr GuiMissionAreaCtrl_create()
         {
         	if (_GuiMissionAreaCtrl_createFunc == null)
         	{
         		_GuiMissionAreaCtrl_createFunc =
         			(_GuiMissionAreaCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiMissionAreaCtrl_create"), typeof(_GuiMissionAreaCtrl_create));
         	}
         
         	return  _GuiMissionAreaCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setMissionArea(MissionArea area)
         {
            InternalUnsafeMethods.setMissionArea(ObjectPtr, area.ObjectPtr);
         }
      
         public virtual void updateTerrain()
         {
            InternalUnsafeMethods.updateTerrain(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public bool SquareBitmap
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("SquareBitmap")); }
         	set { setFieldValue("SquareBitmap", value ? "1" : "0"); }
         }
      
         public string HandleBitmap
         {
         	get { return getFieldValue("HandleBitmap"); }
         	set { setFieldValue("HandleBitmap", value); }
         }
      
         public ColorI MissionBoundsColor
         {
         	get { return new ColorI(getFieldValue("MissionBoundsColor")); }
         	set { setFieldValue("MissionBoundsColor", value.ToString()); }
         }
      
         public ColorI CameraColor
         {
         	get { return new ColorI(getFieldValue("CameraColor")); }
         	set { setFieldValue("CameraColor", value.ToString()); }
         }
      
      
      #endregion

	}
}