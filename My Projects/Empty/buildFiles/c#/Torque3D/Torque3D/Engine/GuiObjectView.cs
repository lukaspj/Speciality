using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiObjectView : GuiTSCtrl
	{
		public GuiObjectView(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiObjectView(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiObjectView(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiObjectView(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiObjectView(SimObject pObj) : base(pObj)
		{
		}

		public GuiObjectView(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiObjectView_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getModel(IntPtr thisPtr);
         private static _getModel _getModelFunc;
         internal static IntPtr getModel(IntPtr thisPtr)
         {
         	if (_getModelFunc == null)
         	{
         		_getModelFunc =
         			(_getModel)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiObjectView_getModel"), typeof(_getModel));
         	}
         
         	return  _getModelFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setModel(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string shapeName);
         private static _setModel _setModelFunc;
         internal static void setModel(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string shapeName)
         {
         	if (_setModelFunc == null)
         	{
         		_setModelFunc =
         			(_setModel)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiObjectView_setModel"), typeof(_setModel));
         	}
         
         	 _setModelFunc(thisPtr, shapeName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getMountedModel(IntPtr thisPtr);
         private static _getMountedModel _getMountedModelFunc;
         internal static IntPtr getMountedModel(IntPtr thisPtr)
         {
         	if (_getMountedModelFunc == null)
         	{
         		_getMountedModelFunc =
         			(_getMountedModel)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiObjectView_getMountedModel"), typeof(_getMountedModel));
         	}
         
         	return  _getMountedModelFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMountedModel(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string shapeName);
         private static _setMountedModel _setMountedModelFunc;
         internal static void setMountedModel(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string shapeName)
         {
         	if (_setMountedModelFunc == null)
         	{
         		_setMountedModelFunc =
         			(_setMountedModel)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiObjectView_setMountedModel"), typeof(_setMountedModel));
         	}
         
         	 _setMountedModelFunc(thisPtr, shapeName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getSkin(IntPtr thisPtr);
         private static _getSkin _getSkinFunc;
         internal static IntPtr getSkin(IntPtr thisPtr)
         {
         	if (_getSkinFunc == null)
         	{
         		_getSkinFunc =
         			(_getSkin)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiObjectView_getSkin"), typeof(_getSkin));
         	}
         
         	return  _getSkinFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setSkin(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string skinName);
         private static _setSkin _setSkinFunc;
         internal static void setSkin(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string skinName)
         {
         	if (_setSkinFunc == null)
         	{
         		_setSkinFunc =
         			(_setSkin)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiObjectView_setSkin"), typeof(_setSkin));
         	}
         
         	 _setSkinFunc(thisPtr, skinName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getMountSkin(IntPtr thisPtr, int param1, int param2);
         private static _getMountSkin _getMountSkinFunc;
         internal static IntPtr getMountSkin(IntPtr thisPtr, int param1, int param2)
         {
         	if (_getMountSkinFunc == null)
         	{
         		_getMountSkinFunc =
         			(_getMountSkin)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiObjectView_getMountSkin"), typeof(_getMountSkin));
         	}
         
         	return  _getMountSkinFunc(thisPtr, param1, param2);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMountSkin(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string skinName);
         private static _setMountSkin _setMountSkinFunc;
         internal static void setMountSkin(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string skinName)
         {
         	if (_setMountSkinFunc == null)
         	{
         		_setMountSkinFunc =
         			(_setMountSkin)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiObjectView_setMountSkin"), typeof(_setMountSkin));
         	}
         
         	 _setMountSkinFunc(thisPtr, skinName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setSeq(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string indexOrName);
         private static _setSeq _setSeqFunc;
         internal static void setSeq(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string indexOrName)
         {
         	if (_setSeqFunc == null)
         	{
         		_setSeqFunc =
         			(_setSeq)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiObjectView_setSeq"), typeof(_setSeq));
         	}
         
         	 _setSeqFunc(thisPtr, indexOrName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMount(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string shapeName, [MarshalAs(UnmanagedType.LPWStr)]string mountNodeIndexOrName);
         private static _setMount _setMountFunc;
         internal static void setMount(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string shapeName, [MarshalAs(UnmanagedType.LPWStr)]string mountNodeIndexOrName)
         {
         	if (_setMountFunc == null)
         	{
         		_setMountFunc =
         			(_setMount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiObjectView_setMount"), typeof(_setMount));
         	}
         
         	 _setMountFunc(thisPtr, shapeName, mountNodeIndexOrName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getOrbitDistance(IntPtr thisPtr);
         private static _getOrbitDistance _getOrbitDistanceFunc;
         internal static float getOrbitDistance(IntPtr thisPtr)
         {
         	if (_getOrbitDistanceFunc == null)
         	{
         		_getOrbitDistanceFunc =
         			(_getOrbitDistance)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiObjectView_getOrbitDistance"), typeof(_getOrbitDistance));
         	}
         
         	return  _getOrbitDistanceFunc(thisPtr);
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
         				"fnGuiObjectView_setOrbitDistance"), typeof(_setOrbitDistance));
         	}
         
         	 _setOrbitDistanceFunc(thisPtr, distance);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getCameraSpeed(IntPtr thisPtr);
         private static _getCameraSpeed _getCameraSpeedFunc;
         internal static float getCameraSpeed(IntPtr thisPtr)
         {
         	if (_getCameraSpeedFunc == null)
         	{
         		_getCameraSpeedFunc =
         			(_getCameraSpeed)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiObjectView_getCameraSpeed"), typeof(_getCameraSpeed));
         	}
         
         	return  _getCameraSpeedFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setCameraSpeed(IntPtr thisPtr, float factor);
         private static _setCameraSpeed _setCameraSpeedFunc;
         internal static void setCameraSpeed(IntPtr thisPtr, float factor)
         {
         	if (_setCameraSpeedFunc == null)
         	{
         		_setCameraSpeedFunc =
         			(_setCameraSpeed)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiObjectView_setCameraSpeed"), typeof(_setCameraSpeed));
         	}
         
         	 _setCameraSpeedFunc(thisPtr, factor);
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
         				"fnGuiObjectView_setLightColor"), typeof(_setLightColor));
         	}
         
         	 _setLightColorFunc(thisPtr, color);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setLightAmbient(IntPtr thisPtr, InternalColorFStruct color);
         private static _setLightAmbient _setLightAmbientFunc;
         internal static void setLightAmbient(IntPtr thisPtr, InternalColorFStruct color)
         {
         	if (_setLightAmbientFunc == null)
         	{
         		_setLightAmbientFunc =
         			(_setLightAmbient)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiObjectView_setLightAmbient"), typeof(_setLightAmbient));
         	}
         
         	 _setLightAmbientFunc(thisPtr, color);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setLightDirection(IntPtr thisPtr, InternalPoint3FStruct direction);
         private static _setLightDirection _setLightDirectionFunc;
         internal static void setLightDirection(IntPtr thisPtr, InternalPoint3FStruct direction)
         {
         	if (_setLightDirectionFunc == null)
         	{
         		_setLightDirectionFunc =
         			(_setLightDirection)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiObjectView_setLightDirection"), typeof(_setLightDirection));
         	}
         
         	 _setLightDirectionFunc(thisPtr, direction);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiObjectView_create();
         private static _GuiObjectView_create _GuiObjectView_createFunc;
         internal static IntPtr GuiObjectView_create()
         {
         	if (_GuiObjectView_createFunc == null)
         	{
         		_GuiObjectView_createFunc =
         			(_GuiObjectView_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiObjectView_create"), typeof(_GuiObjectView_create));
         	}
         
         	return  _GuiObjectView_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual string getModel()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getModel(ObjectPtr));
         }
      
         public virtual void setModel(string shapeName)
         {
            InternalUnsafeMethods.setModel(ObjectPtr, shapeName);
         }
      
         public virtual string getMountedModel()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getMountedModel(ObjectPtr));
         }
      
         public virtual void setMountedModel(string shapeName)
         {
            InternalUnsafeMethods.setMountedModel(ObjectPtr, shapeName);
         }
      
         public virtual string getSkin()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getSkin(ObjectPtr));
         }
      
         public virtual void setSkin(string skinName)
         {
            InternalUnsafeMethods.setSkin(ObjectPtr, skinName);
         }
      
         public virtual string getMountSkin(int param1, int param2)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getMountSkin(ObjectPtr, param1, param2));
         }
      
         public virtual void setMountSkin(string skinName)
         {
            InternalUnsafeMethods.setMountSkin(ObjectPtr, skinName);
         }
      
         public virtual void setSeq(string indexOrName)
         {
            InternalUnsafeMethods.setSeq(ObjectPtr, indexOrName);
         }
      
         public virtual void setMount(string shapeName, string mountNodeIndexOrName)
         {
            InternalUnsafeMethods.setMount(ObjectPtr, shapeName, mountNodeIndexOrName);
         }
      
         public virtual float getOrbitDistance()
         {
            return InternalUnsafeMethods.getOrbitDistance(ObjectPtr);
         }
      
         public virtual void setOrbitDistance(float distance)
         {
            InternalUnsafeMethods.setOrbitDistance(ObjectPtr, distance);
         }
      
         public virtual float getCameraSpeed()
         {
            return InternalUnsafeMethods.getCameraSpeed(ObjectPtr);
         }
      
         public virtual void setCameraSpeed(float factor)
         {
            InternalUnsafeMethods.setCameraSpeed(ObjectPtr, factor);
         }
      
         public virtual void setLightColor(ColorF color)
         {
            InternalUnsafeMethods.setLightColor(ObjectPtr, color.ToStruct());
         }
      
         public virtual void setLightAmbient(ColorF color)
         {
            InternalUnsafeMethods.setLightAmbient(ObjectPtr, color.ToStruct());
         }
      
         public virtual void setLightDirection(Point3F direction)
         {
            InternalUnsafeMethods.setLightDirection(ObjectPtr, direction.ToStruct());
         }
      
      
      #endregion


      #region Properties
      
      
         public string ShapeFile
         {
         	get { return getFieldValue("ShapeFile"); }
         	set { setFieldValue("ShapeFile", value); }
         }
      
         public string Skin
         {
         	get { return getFieldValue("Skin"); }
         	set { setFieldValue("Skin", value); }
         }
      
         public string AnimSequence
         {
         	get { return getFieldValue("AnimSequence"); }
         	set { setFieldValue("AnimSequence", value); }
         }
      
         public string MountedShapeFile
         {
         	get { return getFieldValue("MountedShapeFile"); }
         	set { setFieldValue("MountedShapeFile", value); }
         }
      
         public string MountedSkin
         {
         	get { return getFieldValue("MountedSkin"); }
         	set { setFieldValue("MountedSkin", value); }
         }
      
         public string MountedNode
         {
         	get { return getFieldValue("MountedNode"); }
         	set { setFieldValue("MountedNode", value); }
         }
      
         public ColorF LightColor
         {
         	get { return new ColorF(getFieldValue("LightColor")); }
         	set { setFieldValue("LightColor", value.ToString()); }
         }
      
         public ColorF LightAmbient
         {
         	get { return new ColorF(getFieldValue("LightAmbient")); }
         	set { setFieldValue("LightAmbient", value.ToString()); }
         }
      
         public Point3F LightDirection
         {
         	get { return new Point3F(getFieldValue("LightDirection")); }
         	set { setFieldValue("LightDirection", value.ToString()); }
         }
      
         public float OrbitDiststance
         {
         	get { return float.Parse(getFieldValue("OrbitDiststance")); }
         	set { setFieldValue("OrbitDiststance", value.ToString()); }
         }
      
         public float MinOrbitDiststance
         {
         	get { return float.Parse(getFieldValue("MinOrbitDiststance")); }
         	set { setFieldValue("MinOrbitDiststance", value.ToString()); }
         }
      
         public float MaxOrbitDiststance
         {
         	get { return float.Parse(getFieldValue("MaxOrbitDiststance")); }
         	set { setFieldValue("MaxOrbitDiststance", value.ToString()); }
         }
      
         public float CameraSpeed
         {
         	get { return float.Parse(getFieldValue("CameraSpeed")); }
         	set { setFieldValue("CameraSpeed", value.ToString()); }
         }
      
         public Point3F CameraRotation
         {
         	get { return new Point3F(getFieldValue("CameraRotation")); }
         	set { setFieldValue("CameraRotation", value.ToString()); }
         }
      
      
      #endregion

	}
}