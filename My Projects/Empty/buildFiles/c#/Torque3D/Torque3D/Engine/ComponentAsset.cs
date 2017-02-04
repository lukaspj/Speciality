using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ComponentAsset : AssetBase
	{
		public ComponentAsset(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ComponentAsset(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ComponentAsset(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ComponentAsset(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ComponentAsset(SimObject pObj) : base(pObj)
		{
		}

		public ComponentAsset(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ComponentAsset_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ComponentAsset_create();
         private static _ComponentAsset_create _ComponentAsset_createFunc;
         internal static IntPtr ComponentAsset_create()
         {
         	if (_ComponentAsset_createFunc == null)
         	{
         		_ComponentAsset_createFunc =
         			(_ComponentAsset_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ComponentAsset_create"), typeof(_ComponentAsset_create));
         	}
         
         	return  _ComponentAsset_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string ComponentName
         {
         	get { return getFieldValue("ComponentName"); }
         	set { setFieldValue("ComponentName", value); }
         }
      
         public string ComponentClass
         {
         	get { return getFieldValue("ComponentClass"); }
         	set { setFieldValue("ComponentClass", value); }
         }
      
         public string FriendlyName
         {
         	get { return getFieldValue("FriendlyName"); }
         	set { setFieldValue("FriendlyName", value); }
         }
      
         public string ComponentType
         {
         	get { return getFieldValue("ComponentType"); }
         	set { setFieldValue("ComponentType", value); }
         }
      
         public string Description
         {
         	get { return getFieldValue("Description"); }
         	set { setFieldValue("Description", value); }
         }
      
      
      #endregion

	}
}