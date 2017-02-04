using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class BasicClouds : SceneObject
	{
		public BasicClouds(bool pRegister = false)
			: base(pRegister)
		{
		}

		public BasicClouds(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public BasicClouds(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public BasicClouds(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public BasicClouds(SimObject pObj) : base(pObj)
		{
		}

		public BasicClouds(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.BasicClouds_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _BasicClouds_create();
         private static _BasicClouds_create _BasicClouds_createFunc;
         internal static IntPtr BasicClouds_create()
         {
         	if (_BasicClouds_createFunc == null)
         	{
         		_BasicClouds_createFunc =
         			(_BasicClouds_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_BasicClouds_create"), typeof(_BasicClouds_create));
         	}
         
         	return  _BasicClouds_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public DynamicFieldVector<bool> LayerEnabled
         {
         	get { return new DynamicFieldVector<bool>(this, "LayerEnabled", 3, val => GenericMarshal.StringToBool(val), obj => obj ? "1" : "0"); }
         }
      
         public DynamicFieldVector<string> Texture
         {
         	get { return new DynamicFieldVector<string>(this, "Texture", 3, val => val, obj => obj); }
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
      
         public DynamicFieldVector<Point2F> TexOffset
         {
         	get { return new DynamicFieldVector<Point2F>(this, "TexOffset", 3, val => new Point2F(val), obj => obj.ToString()); }
         }
      
         public DynamicFieldVector<float> Height
         {
         	get { return new DynamicFieldVector<float>(this, "Height", 3, val => float.Parse(val), obj => obj.ToString()); }
         }
      
      
      #endregion

	}
}