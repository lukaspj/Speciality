using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class Forest : SceneObject
	{
		public Forest(bool pRegister = false)
			: base(pRegister)
		{
		}

		public Forest(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public Forest(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public Forest(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public Forest(SimObject pObj) : base(pObj)
		{
		}

		public Forest(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.Forest_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _saveDataFile(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string path);
         private static _saveDataFile _saveDataFileFunc;
         internal static void saveDataFile(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string path)
         {
         	if (_saveDataFileFunc == null)
         	{
         		_saveDataFileFunc =
         			(_saveDataFile)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnForest_saveDataFile"), typeof(_saveDataFile));
         	}
         
         	 _saveDataFileFunc(thisPtr, path);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isDirty(IntPtr thisPtr);
         private static _isDirty _isDirtyFunc;
         internal static bool isDirty(IntPtr thisPtr)
         {
         	if (_isDirtyFunc == null)
         	{
         		_isDirtyFunc =
         			(_isDirty)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnForest_isDirty"), typeof(_isDirty));
         	}
         
         	return  _isDirtyFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _regenCells(IntPtr thisPtr);
         private static _regenCells _regenCellsFunc;
         internal static void regenCells(IntPtr thisPtr)
         {
         	if (_regenCellsFunc == null)
         	{
         		_regenCellsFunc =
         			(_regenCells)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnForest_regenCells"), typeof(_regenCells));
         	}
         
         	 _regenCellsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clear(IntPtr thisPtr);
         private static _clear _clearFunc;
         internal static void clear(IntPtr thisPtr)
         {
         	if (_clearFunc == null)
         	{
         		_clearFunc =
         			(_clear)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnForest_clear"), typeof(_clear));
         	}
         
         	 _clearFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _Forest_create();
         private static _Forest_create _Forest_createFunc;
         internal static IntPtr Forest_create()
         {
         	if (_Forest_createFunc == null)
         	{
         		_Forest_createFunc =
         			(_Forest_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Forest_create"), typeof(_Forest_create));
         	}
         
         	return  _Forest_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void saveDataFile(string path = "")
         {
            InternalUnsafeMethods.saveDataFile(ObjectPtr, path);
         }
      
         public virtual bool isDirty()
         {
            return InternalUnsafeMethods.isDirty(ObjectPtr);
         }
      
         public virtual void regenCells()
         {
            InternalUnsafeMethods.regenCells(ObjectPtr);
         }
      
         public virtual void clear()
         {
            InternalUnsafeMethods.clear(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public string DataFile
         {
         	get { return getFieldValue("DataFile"); }
         	set { setFieldValue("DataFile", value); }
         }
      
         public float LodReflectScalar
         {
         	get { return float.Parse(getFieldValue("LodReflectScalar")); }
         	set { setFieldValue("LodReflectScalar", value.ToString()); }
         }
      
      
      #endregion

	}
}