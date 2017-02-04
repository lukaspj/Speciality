using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GroundPlane : SceneObject
	{
		public GroundPlane(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GroundPlane(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GroundPlane(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GroundPlane(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GroundPlane(SimObject pObj) : base(pObj)
		{
		}

		public GroundPlane(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GroundPlane_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _postApply(IntPtr thisPtr);
         private static _postApply _postApplyFunc;
         internal static void postApply(IntPtr thisPtr)
         {
         	if (_postApplyFunc == null)
         	{
         		_postApplyFunc =
         			(_postApply)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGroundPlane_postApply"), typeof(_postApply));
         	}
         
         	 _postApplyFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GroundPlane_create();
         private static _GroundPlane_create _GroundPlane_createFunc;
         internal static IntPtr GroundPlane_create()
         {
         	if (_GroundPlane_createFunc == null)
         	{
         		_GroundPlane_createFunc =
         			(_GroundPlane_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GroundPlane_create"), typeof(_GroundPlane_create));
         	}
         
         	return  _GroundPlane_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void postApply()
         {
            InternalUnsafeMethods.postApply(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public float SquareSize
         {
         	get { return float.Parse(getFieldValue("SquareSize")); }
         	set { setFieldValue("SquareSize", value.ToString()); }
         }
      
         public float ScaleU
         {
         	get { return float.Parse(getFieldValue("ScaleU")); }
         	set { setFieldValue("ScaleU", value.ToString()); }
         }
      
         public float ScaleV
         {
         	get { return float.Parse(getFieldValue("ScaleV")); }
         	set { setFieldValue("ScaleV", value.ToString()); }
         }
      
         public string Material
         {
         	get { return getFieldValue("Material"); }
         	set { setFieldValue("Material", value); }
         }
      
      
      #endregion

	}
}