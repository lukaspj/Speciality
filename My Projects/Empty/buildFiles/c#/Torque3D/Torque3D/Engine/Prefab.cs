using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class Prefab : SceneObject
	{
		public Prefab(bool pRegister = false)
			: base(pRegister)
		{
		}

		public Prefab(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public Prefab(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public Prefab(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public Prefab(SimObject pObj) : base(pObj)
		{
		}

		public Prefab(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Prefab_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Prefab_create();
         private static _Prefab_create _Prefab_createFunc;
         internal static IntPtr Prefab_create()
         {
         	if (_Prefab_createFunc == null)
         	{
         		_Prefab_createFunc =
         			(_Prefab_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Prefab_create"), typeof(_Prefab_create));
         	}
         
         	return  _Prefab_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string FileName
         {
         	get { return getFieldValue("FileName"); }
         	set { setFieldValue("FileName", value); }
         }
      
      
      #endregion

	}
}