using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class RenderPassManager : SimObject
	{
		public RenderPassManager(bool pRegister = false)
			: base(pRegister)
		{
		}

		public RenderPassManager(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public RenderPassManager(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public RenderPassManager(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public RenderPassManager(SimObject pObj) : base(pObj)
		{
		}

		public RenderPassManager(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.RenderPassManager_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getManagerCount(IntPtr thisPtr);
         private static _getManagerCount _getManagerCountFunc;
         internal static int getManagerCount(IntPtr thisPtr)
         {
         	if (_getManagerCountFunc == null)
         	{
         		_getManagerCountFunc =
         			(_getManagerCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnRenderPassManager_getManagerCount"), typeof(_getManagerCount));
         	}
         
         	return  _getManagerCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getManager(IntPtr thisPtr, int index);
         private static _getManager _getManagerFunc;
         internal static IntPtr getManager(IntPtr thisPtr, int index)
         {
         	if (_getManagerFunc == null)
         	{
         		_getManagerFunc =
         			(_getManager)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnRenderPassManager_getManager"), typeof(_getManager));
         	}
         
         	return  _getManagerFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addManager(IntPtr thisPtr, IntPtr renderBin);
         private static _addManager _addManagerFunc;
         internal static void addManager(IntPtr thisPtr, IntPtr renderBin)
         {
         	if (_addManagerFunc == null)
         	{
         		_addManagerFunc =
         			(_addManager)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnRenderPassManager_addManager"), typeof(_addManager));
         	}
         
         	 _addManagerFunc(thisPtr, renderBin);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeManager(IntPtr thisPtr, IntPtr renderBin);
         private static _removeManager _removeManagerFunc;
         internal static void removeManager(IntPtr thisPtr, IntPtr renderBin)
         {
         	if (_removeManagerFunc == null)
         	{
         		_removeManagerFunc =
         			(_removeManager)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnRenderPassManager_removeManager"), typeof(_removeManager));
         	}
         
         	 _removeManagerFunc(thisPtr, renderBin);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _RenderPassManager_create();
         private static _RenderPassManager_create _RenderPassManager_createFunc;
         internal static IntPtr RenderPassManager_create()
         {
         	if (_RenderPassManager_createFunc == null)
         	{
         		_RenderPassManager_createFunc =
         			(_RenderPassManager_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_RenderPassManager_create"), typeof(_RenderPassManager_create));
         	}
         
         	return  _RenderPassManager_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual int getManagerCount()
         {
            return InternalUnsafeMethods.getManagerCount(ObjectPtr);
         }
      
         public virtual RenderBinManager getManager(int index)
         {
            return new RenderBinManager(InternalUnsafeMethods.getManager(ObjectPtr, index));
         }
      
         public virtual void addManager(RenderBinManager renderBin)
         {
            InternalUnsafeMethods.addManager(ObjectPtr, renderBin.ObjectPtr);
         }
      
         public virtual void removeManager(RenderBinManager renderBin)
         {
            InternalUnsafeMethods.removeManager(ObjectPtr, renderBin.ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}