using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ForestBrushElement : SimObject
	{
		public ForestBrushElement(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ForestBrushElement(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ForestBrushElement(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ForestBrushElement(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ForestBrushElement(SimObject pObj) : base(pObj)
		{
		}

		public ForestBrushElement(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ForestBrushElement_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ForestBrushElement_create();
         private static _ForestBrushElement_create _ForestBrushElement_createFunc;
         internal static IntPtr ForestBrushElement_create()
         {
         	if (_ForestBrushElement_createFunc == null)
         	{
         		_ForestBrushElement_createFunc =
         			(_ForestBrushElement_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ForestBrushElement_create"), typeof(_ForestBrushElement_create));
         	}
         
         	return  _ForestBrushElement_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public ForestItemData ForestItemData
         {
         	get { return Sim.FindObject<ForestItemData>(getFieldValue("ForestItemData")); }
         	set { setFieldValue("ForestItemData", value.getId().ToString()); }
         }
      
         public float Probability
         {
         	get { return float.Parse(getFieldValue("Probability")); }
         	set { setFieldValue("Probability", value.ToString()); }
         }
      
         public float RotationRange
         {
         	get { return float.Parse(getFieldValue("RotationRange")); }
         	set { setFieldValue("RotationRange", value.ToString()); }
         }
      
         public float ScaleMin
         {
         	get { return float.Parse(getFieldValue("ScaleMin")); }
         	set { setFieldValue("ScaleMin", value.ToString()); }
         }
      
         public float ScaleMax
         {
         	get { return float.Parse(getFieldValue("ScaleMax")); }
         	set { setFieldValue("ScaleMax", value.ToString()); }
         }
      
         public float ScaleExponent
         {
         	get { return float.Parse(getFieldValue("ScaleExponent")); }
         	set { setFieldValue("ScaleExponent", value.ToString()); }
         }
      
         public float SinkMin
         {
         	get { return float.Parse(getFieldValue("SinkMin")); }
         	set { setFieldValue("SinkMin", value.ToString()); }
         }
      
         public float SinkMax
         {
         	get { return float.Parse(getFieldValue("SinkMax")); }
         	set { setFieldValue("SinkMax", value.ToString()); }
         }
      
         public float SinkRadius
         {
         	get { return float.Parse(getFieldValue("SinkRadius")); }
         	set { setFieldValue("SinkRadius", value.ToString()); }
         }
      
         public float SlopeMin
         {
         	get { return float.Parse(getFieldValue("SlopeMin")); }
         	set { setFieldValue("SlopeMin", value.ToString()); }
         }
      
         public float SlopeMax
         {
         	get { return float.Parse(getFieldValue("SlopeMax")); }
         	set { setFieldValue("SlopeMax", value.ToString()); }
         }
      
         public float ElevationMin
         {
         	get { return float.Parse(getFieldValue("ElevationMin")); }
         	set { setFieldValue("ElevationMin", value.ToString()); }
         }
      
         public float ElevationMax
         {
         	get { return float.Parse(getFieldValue("ElevationMax")); }
         	set { setFieldValue("ElevationMax", value.ToString()); }
         }
      
      
      #endregion

	}
}