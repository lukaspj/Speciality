using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class CubemapData : SimObject
	{
		public CubemapData(bool pRegister = false)
			: base(pRegister)
		{
		}

		public CubemapData(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public CubemapData(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public CubemapData(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public CubemapData(SimObject pObj) : base(pObj)
		{
		}

		public CubemapData(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.CubemapData_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _updateFaces(IntPtr thisPtr);
         private static _updateFaces _updateFacesFunc;
         internal static void updateFaces(IntPtr thisPtr)
         {
         	if (_updateFacesFunc == null)
         	{
         		_updateFacesFunc =
         			(_updateFaces)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCubemapData_updateFaces"), typeof(_updateFaces));
         	}
         
         	 _updateFacesFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getFilename(IntPtr thisPtr);
         private static _getFilename _getFilenameFunc;
         internal static IntPtr getFilename(IntPtr thisPtr)
         {
         	if (_getFilenameFunc == null)
         	{
         		_getFilenameFunc =
         			(_getFilename)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnCubemapData_getFilename"), typeof(_getFilename));
         	}
         
         	return  _getFilenameFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _CubemapData_create();
         private static _CubemapData_create _CubemapData_createFunc;
         internal static IntPtr CubemapData_create()
         {
         	if (_CubemapData_createFunc == null)
         	{
         		_CubemapData_createFunc =
         			(_CubemapData_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CubemapData_create"), typeof(_CubemapData_create));
         	}
         
         	return  _CubemapData_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void updateFaces()
         {
            InternalUnsafeMethods.updateFaces(ObjectPtr);
         }
      
         public virtual string getFilename()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getFilename(ObjectPtr));
         }
      
      
      #endregion


      #region Properties
      
      
         public DynamicFieldVector<string> CubeFace
         {
         	get { return new DynamicFieldVector<string>(this, "CubeFace", 6, val => val, obj => obj); }
         }
      
      
      #endregion

	}
}