using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GizmoProfile : SimObject
	{
		public GizmoProfile(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GizmoProfile(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GizmoProfile(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GizmoProfile(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GizmoProfile(SimObject pObj) : base(pObj)
		{
		}

		public GizmoProfile(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GizmoProfile_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GizmoProfile_create();
         private static _GizmoProfile_create _GizmoProfile_createFunc;
         internal static IntPtr GizmoProfile_create()
         {
         	if (_GizmoProfile_createFunc == null)
         	{
         		_GizmoProfile_createFunc =
         			(_GizmoProfile_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GizmoProfile_create"), typeof(_GizmoProfile_create));
         	}
         
         	return  _GizmoProfile_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public GizmoAlignment Alignment
         {
         	get { return (GizmoAlignment)Enum.Parse(typeof(GizmoAlignment), getFieldValue("Alignment"), true); }
         	set { setFieldValue("Alignment", value.ToString()); }
         }
      
         public GizmoMode Mode
         {
         	get { return (GizmoMode)Enum.Parse(typeof(GizmoMode), getFieldValue("Mode"), true); }
         	set { setFieldValue("Mode", value.ToString()); }
         }
      
         public bool SnapToGrid
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("SnapToGrid")); }
         	set { setFieldValue("SnapToGrid", value ? "1" : "0"); }
         }
      
         public bool AllowSnapRotations
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AllowSnapRotations")); }
         	set { setFieldValue("AllowSnapRotations", value ? "1" : "0"); }
         }
      
         public float RotationSnap
         {
         	get { return float.Parse(getFieldValue("RotationSnap")); }
         	set { setFieldValue("RotationSnap", value.ToString()); }
         }
      
         public bool AllowSnapScale
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AllowSnapScale")); }
         	set { setFieldValue("AllowSnapScale", value ? "1" : "0"); }
         }
      
         public float ScaleSnap
         {
         	get { return float.Parse(getFieldValue("ScaleSnap")); }
         	set { setFieldValue("ScaleSnap", value.ToString()); }
         }
      
         public bool RenderWhenUsed
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderWhenUsed")); }
         	set { setFieldValue("RenderWhenUsed", value ? "1" : "0"); }
         }
      
         public bool RenderInfoText
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderInfoText")); }
         	set { setFieldValue("RenderInfoText", value ? "1" : "0"); }
         }
      
         public bool RenderPlane
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderPlane")); }
         	set { setFieldValue("RenderPlane", value ? "1" : "0"); }
         }
      
         public bool RenderPlaneHashes
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderPlaneHashes")); }
         	set { setFieldValue("RenderPlaneHashes", value ? "1" : "0"); }
         }
      
         public bool RenderSolid
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderSolid")); }
         	set { setFieldValue("RenderSolid", value ? "1" : "0"); }
         }
      
         public bool RenderMoveGrid
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderMoveGrid")); }
         	set { setFieldValue("RenderMoveGrid", value ? "1" : "0"); }
         }
      
         public ColorI GridColor
         {
         	get { return new ColorI(getFieldValue("GridColor")); }
         	set { setFieldValue("GridColor", value.ToString()); }
         }
      
         public float PlaneDim
         {
         	get { return float.Parse(getFieldValue("PlaneDim")); }
         	set { setFieldValue("PlaneDim", value.ToString()); }
         }
      
         public Point3F GridSize
         {
         	get { return new Point3F(getFieldValue("GridSize")); }
         	set { setFieldValue("GridSize", value.ToString()); }
         }
      
         public int ScreenLength
         {
         	get { return int.Parse(getFieldValue("ScreenLength")); }
         	set { setFieldValue("ScreenLength", value.ToString()); }
         }
      
         public float RotateScalar
         {
         	get { return float.Parse(getFieldValue("RotateScalar")); }
         	set { setFieldValue("RotateScalar", value.ToString()); }
         }
      
         public float ScaleScalar
         {
         	get { return float.Parse(getFieldValue("ScaleScalar")); }
         	set { setFieldValue("ScaleScalar", value.ToString()); }
         }
      
         public int Flags
         {
         	get { return int.Parse(getFieldValue("Flags")); }
         	set { setFieldValue("Flags", value.ToString()); }
         }
      
      
      #endregion

	}
}