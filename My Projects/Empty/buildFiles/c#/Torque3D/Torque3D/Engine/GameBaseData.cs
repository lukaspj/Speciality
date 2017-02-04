using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GameBaseData : SimDataBlock
	{
		public GameBaseData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GameBaseData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GameBaseData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GameBaseData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GameBaseData(SimObject pObj) : base(pObj)
		{
		}

		public GameBaseData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GameBaseData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GameBaseData_create();
         private static _GameBaseData_create _GameBaseData_createFunc;
         internal static IntPtr GameBaseData_create()
         {
         	if (_GameBaseData_createFunc == null)
         	{
         		_GameBaseData_createFunc =
         			(_GameBaseData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GameBaseData_create"), typeof(_GameBaseData_create));
         	}
         
         	return  _GameBaseData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string Category
         {
         	get { return getFieldValue("Category"); }
         	set { setFieldValue("Category", value); }
         }
      
      
      #endregion

	}
}