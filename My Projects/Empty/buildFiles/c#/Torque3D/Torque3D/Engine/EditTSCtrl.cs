using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class EditTSCtrl : GuiTSCtrl
	{
		public EditTSCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public EditTSCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public EditTSCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public EditTSCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public EditTSCtrl(SimObject pObj) : base(pObj)
		{
		}

		public EditTSCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.EditTSCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getDisplayType(IntPtr thisPtr);
         private static _getDisplayType _getDisplayTypeFunc;
         internal static int getDisplayType(IntPtr thisPtr)
         {
         	if (_getDisplayTypeFunc == null)
         	{
         		_getDisplayTypeFunc =
         			(_getDisplayType)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnEditTSCtrl_getDisplayType"), typeof(_getDisplayType));
         	}
         
         	return  _getDisplayTypeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setDisplayType(IntPtr thisPtr, int displayType);
         private static _setDisplayType _setDisplayTypeFunc;
         internal static void setDisplayType(IntPtr thisPtr, int displayType)
         {
         	if (_setDisplayTypeFunc == null)
         	{
         		_setDisplayTypeFunc =
         			(_setDisplayType)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnEditTSCtrl_setDisplayType"), typeof(_setDisplayType));
         	}
         
         	 _setDisplayTypeFunc(thisPtr, displayType);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getOrthoFOV(IntPtr thisPtr);
         private static _getOrthoFOV _getOrthoFOVFunc;
         internal static float getOrthoFOV(IntPtr thisPtr)
         {
         	if (_getOrthoFOVFunc == null)
         	{
         		_getOrthoFOVFunc =
         			(_getOrthoFOV)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnEditTSCtrl_getOrthoFOV"), typeof(_getOrthoFOV));
         	}
         
         	return  _getOrthoFOVFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setOrthoFOV(IntPtr thisPtr, float fov);
         private static _setOrthoFOV _setOrthoFOVFunc;
         internal static void setOrthoFOV(IntPtr thisPtr, float fov)
         {
         	if (_setOrthoFOVFunc == null)
         	{
         		_setOrthoFOVFunc =
         			(_setOrthoFOV)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnEditTSCtrl_setOrthoFOV"), typeof(_setOrthoFOV));
         	}
         
         	 _setOrthoFOVFunc(thisPtr, fov);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _renderBox(IntPtr thisPtr, InternalPoint3FStruct pos, InternalPoint3FStruct size);
         private static _renderBox _renderBoxFunc;
         internal static void renderBox(IntPtr thisPtr, InternalPoint3FStruct pos, InternalPoint3FStruct size)
         {
         	if (_renderBoxFunc == null)
         	{
         		_renderBoxFunc =
         			(_renderBox)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnEditTSCtrl_renderBox"), typeof(_renderBox));
         	}
         
         	 _renderBoxFunc(thisPtr, pos, size);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _renderSphere(IntPtr thisPtr, InternalPoint3FStruct pos, float radius, int sphereLevel);
         private static _renderSphere _renderSphereFunc;
         internal static void renderSphere(IntPtr thisPtr, InternalPoint3FStruct pos, float radius, int sphereLevel)
         {
         	if (_renderSphereFunc == null)
         	{
         		_renderSphereFunc =
         			(_renderSphere)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnEditTSCtrl_renderSphere"), typeof(_renderSphere));
         	}
         
         	 _renderSphereFunc(thisPtr, pos, radius, sphereLevel);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _renderCircle(IntPtr thisPtr, InternalPoint3FStruct pos, InternalPoint3FStruct normal, float radius, int segments);
         private static _renderCircle _renderCircleFunc;
         internal static void renderCircle(IntPtr thisPtr, InternalPoint3FStruct pos, InternalPoint3FStruct normal, float radius, int segments)
         {
         	if (_renderCircleFunc == null)
         	{
         		_renderCircleFunc =
         			(_renderCircle)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnEditTSCtrl_renderCircle"), typeof(_renderCircle));
         	}
         
         	 _renderCircleFunc(thisPtr, pos, normal, radius, segments);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _renderTriangle(IntPtr thisPtr, InternalPoint3FStruct a, InternalPoint3FStruct b, InternalPoint3FStruct c);
         private static _renderTriangle _renderTriangleFunc;
         internal static void renderTriangle(IntPtr thisPtr, InternalPoint3FStruct a, InternalPoint3FStruct b, InternalPoint3FStruct c)
         {
         	if (_renderTriangleFunc == null)
         	{
         		_renderTriangleFunc =
         			(_renderTriangle)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnEditTSCtrl_renderTriangle"), typeof(_renderTriangle));
         	}
         
         	 _renderTriangleFunc(thisPtr, a, b, c);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _renderLine(IntPtr thisPtr, InternalPoint3FStruct start, InternalPoint3FStruct end, float lineWidth);
         private static _renderLine _renderLineFunc;
         internal static void renderLine(IntPtr thisPtr, InternalPoint3FStruct start, InternalPoint3FStruct end, float lineWidth)
         {
         	if (_renderLineFunc == null)
         	{
         		_renderLineFunc =
         			(_renderLine)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnEditTSCtrl_renderLine"), typeof(_renderLine));
         	}
         
         	 _renderLineFunc(thisPtr, start, end, lineWidth);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getGizmo(IntPtr thisPtr);
         private static _getGizmo _getGizmoFunc;
         internal static int getGizmo(IntPtr thisPtr)
         {
         	if (_getGizmoFunc == null)
         	{
         		_getGizmoFunc =
         			(_getGizmo)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnEditTSCtrl_getGizmo"), typeof(_getGizmo));
         	}
         
         	return  _getGizmoFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isMiddleMouseDown(IntPtr thisPtr);
         private static _isMiddleMouseDown _isMiddleMouseDownFunc;
         internal static bool isMiddleMouseDown(IntPtr thisPtr)
         {
         	if (_isMiddleMouseDownFunc == null)
         	{
         		_isMiddleMouseDownFunc =
         			(_isMiddleMouseDown)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnEditTSCtrl_isMiddleMouseDown"), typeof(_isMiddleMouseDown));
         	}
         
         	return  _isMiddleMouseDownFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _EditTSCtrl_create();
         private static _EditTSCtrl_create _EditTSCtrl_createFunc;
         internal static IntPtr EditTSCtrl_create()
         {
         	if (_EditTSCtrl_createFunc == null)
         	{
         		_EditTSCtrl_createFunc =
         			(_EditTSCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_EditTSCtrl_create"), typeof(_EditTSCtrl_create));
         	}
         
         	return  _EditTSCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual int getDisplayType()
         {
            return InternalUnsafeMethods.getDisplayType(ObjectPtr);
         }
      
         public virtual void setDisplayType(int displayType)
         {
            InternalUnsafeMethods.setDisplayType(ObjectPtr, displayType);
         }
      
         public virtual float getOrthoFOV()
         {
            return InternalUnsafeMethods.getOrthoFOV(ObjectPtr);
         }
      
         public virtual void setOrthoFOV(float fov)
         {
            InternalUnsafeMethods.setOrthoFOV(ObjectPtr, fov);
         }
      
         public virtual void renderBox(Point3F pos, Point3F size)
         {
            InternalUnsafeMethods.renderBox(ObjectPtr, pos.ToStruct(), size.ToStruct());
         }
      
         public virtual void renderSphere(Point3F pos, float radius, int sphereLevel = 0)
         {
            InternalUnsafeMethods.renderSphere(ObjectPtr, pos.ToStruct(), radius, sphereLevel);
         }
      
         public virtual void renderCircle(Point3F pos, Point3F normal, float radius, int segments = 0)
         {
            InternalUnsafeMethods.renderCircle(ObjectPtr, pos.ToStruct(), normal.ToStruct(), radius, segments);
         }
      
         public virtual void renderTriangle(Point3F a, Point3F b, Point3F c)
         {
            InternalUnsafeMethods.renderTriangle(ObjectPtr, a.ToStruct(), b.ToStruct(), c.ToStruct());
         }
      
         public virtual void renderLine(Point3F start, Point3F end, float lineWidth = 0)
         {
            InternalUnsafeMethods.renderLine(ObjectPtr, start.ToStruct(), end.ToStruct(), lineWidth);
         }
      
         public virtual int getGizmo()
         {
            return InternalUnsafeMethods.getGizmo(ObjectPtr);
         }
      
         public virtual bool isMiddleMouseDown()
         {
            return InternalUnsafeMethods.isMiddleMouseDown(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public float GridSize
         {
         	get { return float.Parse(getFieldValue("GridSize")); }
         	set { setFieldValue("GridSize", value.ToString()); }
         }
      
         public ColorI GridColor
         {
         	get { return new ColorI(getFieldValue("GridColor")); }
         	set { setFieldValue("GridColor", value.ToString()); }
         }
      
         public ColorI GridOriginColor
         {
         	get { return new ColorI(getFieldValue("GridOriginColor")); }
         	set { setFieldValue("GridOriginColor", value.ToString()); }
         }
      
         public ColorI GridMinorTickColor
         {
         	get { return new ColorI(getFieldValue("GridMinorTickColor")); }
         	set { setFieldValue("GridMinorTickColor", value.ToString()); }
         }
      
         public bool RenderOrthoGrid
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderOrthoGrid")); }
         	set { setFieldValue("RenderOrthoGrid", value ? "1" : "0"); }
         }
      
         public float RenderOrthoGridPixelBias
         {
         	get { return float.Parse(getFieldValue("RenderOrthoGridPixelBias")); }
         	set { setFieldValue("RenderOrthoGridPixelBias", value.ToString()); }
         }
      
         public bool RenderMissionArea
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderMissionArea")); }
         	set { setFieldValue("RenderMissionArea", value ? "1" : "0"); }
         }
      
         public ColorI MissionAreaFillColor
         {
         	get { return new ColorI(getFieldValue("MissionAreaFillColor")); }
         	set { setFieldValue("MissionAreaFillColor", value.ToString()); }
         }
      
         public ColorI MissionAreaFrameColor
         {
         	get { return new ColorI(getFieldValue("MissionAreaFrameColor")); }
         	set { setFieldValue("MissionAreaFrameColor", value.ToString()); }
         }
      
         public float MissionAreaHeightAdjust
         {
         	get { return float.Parse(getFieldValue("MissionAreaHeightAdjust")); }
         	set { setFieldValue("MissionAreaHeightAdjust", value.ToString()); }
         }
      
         public bool AllowBorderMove
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AllowBorderMove")); }
         	set { setFieldValue("AllowBorderMove", value ? "1" : "0"); }
         }
      
         public int BorderMovePixelSize
         {
         	get { return int.Parse(getFieldValue("BorderMovePixelSize")); }
         	set { setFieldValue("BorderMovePixelSize", value.ToString()); }
         }
      
         public float BorderMoveSpeed
         {
         	get { return float.Parse(getFieldValue("BorderMoveSpeed")); }
         	set { setFieldValue("BorderMoveSpeed", value.ToString()); }
         }
      
         public ColorI ConsoleFrameColor
         {
         	get { return new ColorI(getFieldValue("ConsoleFrameColor")); }
         	set { setFieldValue("ConsoleFrameColor", value.ToString()); }
         }
      
         public ColorI ConsoleFillColor
         {
         	get { return new ColorI(getFieldValue("ConsoleFillColor")); }
         	set { setFieldValue("ConsoleFillColor", value.ToString()); }
         }
      
         public int ConsoleSphereLevel
         {
         	get { return int.Parse(getFieldValue("ConsoleSphereLevel")); }
         	set { setFieldValue("ConsoleSphereLevel", value.ToString()); }
         }
      
         public int ConsoleCircleSegments
         {
         	get { return int.Parse(getFieldValue("ConsoleCircleSegments")); }
         	set { setFieldValue("ConsoleCircleSegments", value.ToString()); }
         }
      
         public int ConsoleLineWidth
         {
         	get { return int.Parse(getFieldValue("ConsoleLineWidth")); }
         	set { setFieldValue("ConsoleLineWidth", value.ToString()); }
         }
      
         public GizmoProfile GizmoProfile
         {
         	get { return Sim.FindObject<GizmoProfile>(getFieldValue("GizmoProfile")); }
         	set { setFieldValue("GizmoProfile", value.getId().ToString()); }
         }
      
      
      #endregion

	}
}