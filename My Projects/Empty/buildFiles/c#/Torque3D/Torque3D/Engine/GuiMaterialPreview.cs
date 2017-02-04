using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiMaterialPreview : GuiTSCtrl
	{
		public GuiMaterialPreview(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiMaterialPreview(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiMaterialPreview(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiMaterialPreview(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiMaterialPreview(SimObject pObj) : base(pObj)
		{
		}

		public GuiMaterialPreview(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiMaterialPreview_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setModel(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string shapeName);
         private static _setModel _setModelFunc;
         internal static void setModel(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string shapeName)
         {
         	if (_setModelFunc == null)
         	{
         		_setModelFunc =
         			(_setModel)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMaterialPreview_setModel"), typeof(_setModel));
         	}
         
         	 _setModelFunc(thisPtr, shapeName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _deleteModel(IntPtr thisPtr);
         private static _deleteModel _deleteModelFunc;
         internal static void deleteModel(IntPtr thisPtr)
         {
         	if (_deleteModelFunc == null)
         	{
         		_deleteModelFunc =
         			(_deleteModel)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMaterialPreview_deleteModel"), typeof(_deleteModel));
         	}
         
         	 _deleteModelFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setOrbitDistance(IntPtr thisPtr, float distance);
         private static _setOrbitDistance _setOrbitDistanceFunc;
         internal static void setOrbitDistance(IntPtr thisPtr, float distance)
         {
         	if (_setOrbitDistanceFunc == null)
         	{
         		_setOrbitDistanceFunc =
         			(_setOrbitDistance)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMaterialPreview_setOrbitDistance"), typeof(_setOrbitDistance));
         	}
         
         	 _setOrbitDistanceFunc(thisPtr, distance);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _reset(IntPtr thisPtr);
         private static _reset _resetFunc;
         internal static void reset(IntPtr thisPtr)
         {
         	if (_resetFunc == null)
         	{
         		_resetFunc =
         			(_reset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMaterialPreview_reset"), typeof(_reset));
         	}
         
         	 _resetFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setLightColor(IntPtr thisPtr, InternalColorFStruct color);
         private static _setLightColor _setLightColorFunc;
         internal static void setLightColor(IntPtr thisPtr, InternalColorFStruct color)
         {
         	if (_setLightColorFunc == null)
         	{
         		_setLightColorFunc =
         			(_setLightColor)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMaterialPreview_setLightColor"), typeof(_setLightColor));
         	}
         
         	 _setLightColorFunc(thisPtr, color);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setAmbientLightColor(IntPtr thisPtr, InternalColorFStruct color);
         private static _setAmbientLightColor _setAmbientLightColorFunc;
         internal static void setAmbientLightColor(IntPtr thisPtr, InternalColorFStruct color)
         {
         	if (_setAmbientLightColorFunc == null)
         	{
         		_setAmbientLightColorFunc =
         			(_setAmbientLightColor)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMaterialPreview_setAmbientLightColor"), typeof(_setAmbientLightColor));
         	}
         
         	 _setAmbientLightColorFunc(thisPtr, color);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiMaterialPreview_create();
         private static _GuiMaterialPreview_create _GuiMaterialPreview_createFunc;
         internal static IntPtr GuiMaterialPreview_create()
         {
         	if (_GuiMaterialPreview_createFunc == null)
         	{
         		_GuiMaterialPreview_createFunc =
         			(_GuiMaterialPreview_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiMaterialPreview_create"), typeof(_GuiMaterialPreview_create));
         	}
         
         	return  _GuiMaterialPreview_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setModel(string shapeName)
         {
            InternalUnsafeMethods.setModel(ObjectPtr, shapeName);
         }
      
         public virtual void deleteModel()
         {
            InternalUnsafeMethods.deleteModel(ObjectPtr);
         }
      
         public virtual void setOrbitDistance(float distance)
         {
            InternalUnsafeMethods.setOrbitDistance(ObjectPtr, distance);
         }
      
         public virtual void reset()
         {
            InternalUnsafeMethods.reset(ObjectPtr);
         }
      
         public virtual void setLightColor(ColorF color)
         {
            InternalUnsafeMethods.setLightColor(ObjectPtr, color.ToStruct());
         }
      
         public virtual void setAmbientLightColor(ColorF color)
         {
            InternalUnsafeMethods.setAmbientLightColor(ObjectPtr, color.ToStruct());
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}