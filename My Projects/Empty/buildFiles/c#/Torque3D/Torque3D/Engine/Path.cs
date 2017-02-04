using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class Path : SimGroup
	{
		public Path(bool pRegister = false)
			: base(pRegister)
		{
		}

		public Path(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public Path(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public Path(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public Path(SimObject pObj) : base(pObj)
		{
		}

		public Path(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Path_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getPathId(IntPtr thisPtr);
         private static _getPathId _getPathIdFunc;
         internal static int getPathId(IntPtr thisPtr)
         {
         	if (_getPathIdFunc == null)
         	{
         		_getPathIdFunc =
         			(_getPathId)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnPath_getPathId"), typeof(_getPathId));
         	}
         
         	return  _getPathIdFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Path_create();
         private static _Path_create _Path_createFunc;
         internal static IntPtr Path_create()
         {
         	if (_Path_createFunc == null)
         	{
         		_Path_createFunc =
         			(_Path_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Path_create"), typeof(_Path_create));
         	}
         
         	return  _Path_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual int getPathId()
         {
            return InternalUnsafeMethods.getPathId(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public bool IsLooping
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsLooping")); }
         	set { setFieldValue("IsLooping", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}