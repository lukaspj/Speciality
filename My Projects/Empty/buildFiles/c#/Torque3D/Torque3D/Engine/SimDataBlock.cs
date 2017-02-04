using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class SimDataBlock : SimObject
	{
		public SimDataBlock(bool pRegister = false)
			: base(pRegister)
		{
		}

		public SimDataBlock(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public SimDataBlock(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public SimDataBlock(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public SimDataBlock(SimObject pObj) : base(pObj)
		{
		}

		public SimDataBlock(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.SimDataBlock_create();
		}

		public override bool registerObject()
      {
         AssignId();
         bool res = base.registerObject();
			if (res)
			{
				Preload();
			}
			return res;
		}

		public override bool registerSingleton()
      {
         bool res = base.registerObject();
			if (res)
			{
				Preload();
			}
			return res;
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _reloadOnLocalClient(IntPtr thisPtr);
         private static _reloadOnLocalClient _reloadOnLocalClientFunc;
         internal static void reloadOnLocalClient(IntPtr thisPtr)
         {
         	if (_reloadOnLocalClientFunc == null)
         	{
         		_reloadOnLocalClientFunc =
         			(_reloadOnLocalClient)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimDataBlock_reloadOnLocalClient"), typeof(_reloadOnLocalClient));
         	}
         
         	 _reloadOnLocalClientFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SimDataBlock_create();
         private static _SimDataBlock_create _SimDataBlock_createFunc;
         internal static IntPtr SimDataBlock_create()
         {
         	if (_SimDataBlock_createFunc == null)
         	{
         		_SimDataBlock_createFunc =
         			(_SimDataBlock_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_SimDataBlock_create"), typeof(_SimDataBlock_create));
         	}
         
         	return  _SimDataBlock_createFunc();
         }
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _AssignId(IntPtr thisPtr);
         private static _AssignId _AssignIdFunc;
         internal static void AssignId(IntPtr thisPtr)
         {
         	if (_AssignIdFunc == null)
         	{
         		_AssignIdFunc =
         			(_AssignId)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimDataBlock_AssignId"), typeof(_AssignId));
         	}
         
         	 _AssignIdFunc(thisPtr);
         }
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Preload(IntPtr thisPtr);
         private static _Preload _PreloadFunc;
         internal static void Preload(IntPtr thisPtr)
         {
         	if (_PreloadFunc == null)
         	{
         		_PreloadFunc =
         			(_Preload)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSimDataBlock_Preload"), typeof(_Preload));
         	}
         
         	 _PreloadFunc(thisPtr);
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void reloadOnLocalClient()
         {
            InternalUnsafeMethods.reloadOnLocalClient(ObjectPtr);
         }
      
         public virtual void AssignId()
         {
            InternalUnsafeMethods.AssignId(ObjectPtr);
         }
      
         public virtual void Preload()
         {
            InternalUnsafeMethods.Preload(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}