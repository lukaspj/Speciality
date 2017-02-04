using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class FileDialog : SimObject
	{
		public FileDialog(bool pRegister = false)
			: base(pRegister)
		{
		}

		public FileDialog(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public FileDialog(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public FileDialog(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public FileDialog(SimObject pObj) : base(pObj)
		{
		}

		public FileDialog(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.FileDialog_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _Execute(IntPtr thisPtr);
         private static _Execute _ExecuteFunc;
         internal static bool Execute(IntPtr thisPtr)
         {
         	if (_ExecuteFunc == null)
         	{
         		_ExecuteFunc =
         			(_Execute)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnFileDialog_Execute"), typeof(_Execute));
         	}
         
         	return  _ExecuteFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _FileDialog_create();
         private static _FileDialog_create _FileDialog_createFunc;
         internal static IntPtr FileDialog_create()
         {
         	if (_FileDialog_createFunc == null)
         	{
         		_FileDialog_createFunc =
         			(_FileDialog_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_FileDialog_create"), typeof(_FileDialog_create));
         	}
         
         	return  _FileDialog_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool Execute()
         {
            return InternalUnsafeMethods.Execute(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public string DefaultPath
         {
         	get { return getFieldValue("DefaultPath"); }
         	set { setFieldValue("DefaultPath", value); }
         }
      
         public string DefaultFile
         {
         	get { return getFieldValue("DefaultFile"); }
         	set { setFieldValue("DefaultFile", value); }
         }
      
         public string FileName
         {
         	get { return getFieldValue("FileName"); }
         	set { setFieldValue("FileName", value); }
         }
      
         public string Filters
         {
         	get { return getFieldValue("Filters"); }
         	set { setFieldValue("Filters", value); }
         }
      
         public string Title
         {
         	get { return getFieldValue("Title"); }
         	set { setFieldValue("Title", value); }
         }
      
         public bool ChangePath
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ChangePath")); }
         	set { setFieldValue("ChangePath", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}