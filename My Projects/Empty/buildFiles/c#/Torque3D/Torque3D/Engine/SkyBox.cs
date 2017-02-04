using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class SkyBox : SceneObject
	{
		public SkyBox(bool pRegister = false)
			: base(pRegister)
		{
		}

		public SkyBox(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public SkyBox(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public SkyBox(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public SkyBox(SimObject pObj) : base(pObj)
		{
		}

		public SkyBox(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.SkyBox_create();
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
         				"fnSkyBox_postApply"), typeof(_postApply));
         	}
         
         	 _postApplyFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SkyBox_create();
         private static _SkyBox_create _SkyBox_createFunc;
         internal static IntPtr SkyBox_create()
         {
         	if (_SkyBox_createFunc == null)
         	{
         		_SkyBox_createFunc =
         			(_SkyBox_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_SkyBox_create"), typeof(_SkyBox_create));
         	}
         
         	return  _SkyBox_createFunc();
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
      
      
         public string Material
         {
         	get { return getFieldValue("Material"); }
         	set { setFieldValue("Material", value); }
         }
      
         public bool DrawBottom
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("DrawBottom")); }
         	set { setFieldValue("DrawBottom", value ? "1" : "0"); }
         }
      
         public float FogBandHeight
         {
         	get { return float.Parse(getFieldValue("FogBandHeight")); }
         	set { setFieldValue("FogBandHeight", value.ToString()); }
         }
      
      
      #endregion

	}
}