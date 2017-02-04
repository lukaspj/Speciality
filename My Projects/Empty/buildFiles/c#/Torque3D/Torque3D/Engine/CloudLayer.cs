using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class CloudLayer : SceneObject
	{
		public CloudLayer(bool pRegister = false)
			: base(pRegister)
		{
		}

		public CloudLayer(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public CloudLayer(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public CloudLayer(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public CloudLayer(SimObject pObj) : base(pObj)
		{
		}

		public CloudLayer(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.CloudLayer_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _CloudLayer_create();
         private static _CloudLayer_create _CloudLayer_createFunc;
         internal static IntPtr CloudLayer_create()
         {
         	if (_CloudLayer_createFunc == null)
         	{
         		_CloudLayer_createFunc =
         			(_CloudLayer_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CloudLayer_create"), typeof(_CloudLayer_create));
         	}
         
         	return  _CloudLayer_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string Texture
         {
         	get { return getFieldValue("Texture"); }
         	set { setFieldValue("Texture", value); }
         }
      
         public DynamicFieldVector<float> TexScale
         {
         	get { return new DynamicFieldVector<float>(this, "TexScale", 3, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<Point2F> TexDirection
         {
         	get { return new DynamicFieldVector<Point2F>(this, "TexDirection", 3, val => new Point2F(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> TexSpeed
         {
         	get { return new DynamicFieldVector<float>(this, "TexSpeed", 3, val => float.Parse(val), obj => obj.ToString()); }
         }
      
         public ColorF BaseColor
         {
         	get { return new ColorF(getFieldValue("BaseColor")); }
         	set { setFieldValue("BaseColor", value.ToString()); }
         }
      
         public float Exposure
         {
         	get { return float.Parse(getFieldValue("Exposure")); }
         	set { setFieldValue("Exposure", value.ToString()); }
         }
      
         public float Coverage
         {
         	get { return float.Parse(getFieldValue("Coverage")); }
         	set { setFieldValue("Coverage", value.ToString()); }
         }
      
         public float WindSpeed
         {
         	get { return float.Parse(getFieldValue("WindSpeed")); }
         	set { setFieldValue("WindSpeed", value.ToString()); }
         }
      
         public float Height
         {
         	get { return float.Parse(getFieldValue("Height")); }
         	set { setFieldValue("Height", value.ToString()); }
         }
      
      
      #endregion

	}
}