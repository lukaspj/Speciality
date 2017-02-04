using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiTSCtrl : GuiContainer
	{
		public GuiTSCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiTSCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiTSCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiTSCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiTSCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiTSCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiTSCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _unproject(IntPtr thisPtr, InternalPoint3FStruct screenPosition);
         private static _unproject _unprojectFunc;
         internal static InternalPoint3FStruct unproject(IntPtr thisPtr, InternalPoint3FStruct screenPosition)
         {
         	if (_unprojectFunc == null)
         	{
         		_unprojectFunc =
         			(_unproject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTSCtrl_unproject"), typeof(_unproject));
         	}
         
         	return  _unprojectFunc(thisPtr, screenPosition);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _project(IntPtr thisPtr, InternalPoint3FStruct worldPosition);
         private static _project _projectFunc;
         internal static InternalPoint3FStruct project(IntPtr thisPtr, InternalPoint3FStruct worldPosition)
         {
         	if (_projectFunc == null)
         	{
         		_projectFunc =
         			(_project)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTSCtrl_project"), typeof(_project));
         	}
         
         	return  _projectFunc(thisPtr, worldPosition);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint2FStruct _getWorldToScreenScale(IntPtr thisPtr);
         private static _getWorldToScreenScale _getWorldToScreenScaleFunc;
         internal static InternalPoint2FStruct getWorldToScreenScale(IntPtr thisPtr)
         {
         	if (_getWorldToScreenScaleFunc == null)
         	{
         		_getWorldToScreenScaleFunc =
         			(_getWorldToScreenScale)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTSCtrl_getWorldToScreenScale"), typeof(_getWorldToScreenScale));
         	}
         
         	return  _getWorldToScreenScaleFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _calculateViewDistance(IntPtr thisPtr, float radius);
         private static _calculateViewDistance _calculateViewDistanceFunc;
         internal static float calculateViewDistance(IntPtr thisPtr, float radius)
         {
         	if (_calculateViewDistanceFunc == null)
         	{
         		_calculateViewDistanceFunc =
         			(_calculateViewDistance)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTSCtrl_calculateViewDistance"), typeof(_calculateViewDistance));
         	}
         
         	return  _calculateViewDistanceFunc(thisPtr, radius);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setStereoGui(IntPtr thisPtr, IntPtr canvas);
         private static _setStereoGui _setStereoGuiFunc;
         internal static void setStereoGui(IntPtr thisPtr, IntPtr canvas)
         {
         	if (_setStereoGuiFunc == null)
         	{
         		_setStereoGuiFunc =
         			(_setStereoGui)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiTSCtrl_setStereoGui"), typeof(_setStereoGui));
         	}
         
         	 _setStereoGuiFunc(thisPtr, canvas);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiTSCtrl_create();
         private static _GuiTSCtrl_create _GuiTSCtrl_createFunc;
         internal static IntPtr GuiTSCtrl_create()
         {
         	if (_GuiTSCtrl_createFunc == null)
         	{
         		_GuiTSCtrl_createFunc =
         			(_GuiTSCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiTSCtrl_create"), typeof(_GuiTSCtrl_create));
         	}
         
         	return  _GuiTSCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual Point3F unproject(Point3F screenPosition)
         {
            return new Point3F(InternalUnsafeMethods.unproject(ObjectPtr, screenPosition.ToStruct()));
         }
      
         public virtual Point3F project(Point3F worldPosition)
         {
            return new Point3F(InternalUnsafeMethods.project(ObjectPtr, worldPosition.ToStruct()));
         }
      
         public virtual Point2F getWorldToScreenScale()
         {
            return new Point2F(InternalUnsafeMethods.getWorldToScreenScale(ObjectPtr));
         }
      
         public virtual float calculateViewDistance(float radius)
         {
            return InternalUnsafeMethods.calculateViewDistance(ObjectPtr, radius);
         }
      
         public virtual void setStereoGui(GuiOffscreenCanvas canvas)
         {
            InternalUnsafeMethods.setStereoGui(ObjectPtr, canvas.ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public float CameraZRot
         {
         	get { return float.Parse(getFieldValue("CameraZRot")); }
         	set { setFieldValue("CameraZRot", value.ToString()); }
         }
      
         public float ForceFOV
         {
         	get { return float.Parse(getFieldValue("ForceFOV")); }
         	set { setFieldValue("ForceFOV", value.ToString()); }
         }
      
         public float ReflectPriority
         {
         	get { return float.Parse(getFieldValue("ReflectPriority")); }
         	set { setFieldValue("ReflectPriority", value.ToString()); }
         }
      
         public GuiTSRenderStyles RenderStyle
         {
         	get { return (GuiTSRenderStyles)Enum.Parse(typeof(GuiTSRenderStyles), getFieldValue("RenderStyle"), true); }
         	set { setFieldValue("RenderStyle", value.ToString()); }
         }
      
      
      #endregion

	}
}