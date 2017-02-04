using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GameObjectAsset : AssetBase
	{
		public GameObjectAsset(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GameObjectAsset(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GameObjectAsset(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GameObjectAsset(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GameObjectAsset(SimObject pObj) : base(pObj)
		{
		}

		public GameObjectAsset(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GameObjectAsset_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GameObjectAsset_create();
         private static _GameObjectAsset_create _GameObjectAsset_createFunc;
         internal static IntPtr GameObjectAsset_create()
         {
         	if (_GameObjectAsset_createFunc == null)
         	{
         		_GameObjectAsset_createFunc =
         			(_GameObjectAsset_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameObjectAsset_create"), typeof(_GameObjectAsset_create));
         	}
         
         	return  _GameObjectAsset_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string GameObjectName
         {
         	get { return getFieldValue("GameObjectName"); }
         	set { setFieldValue("GameObjectName", value); }
         }
      
         public string ScriptFilePath
         {
         	get { return getFieldValue("ScriptFilePath"); }
         	set { setFieldValue("ScriptFilePath", value); }
         }
      
         public string TAMLFilePath
         {
         	get { return getFieldValue("TAMLFilePath"); }
         	set { setFieldValue("TAMLFilePath", value); }
         }
      
      
      #endregion

	}
}