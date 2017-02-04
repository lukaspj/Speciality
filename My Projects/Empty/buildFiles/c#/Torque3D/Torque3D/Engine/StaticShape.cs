using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class StaticShape : ShapeBase
	{
		public StaticShape(bool pRegister = false)
			: base(pRegister)
		{
		}

		public StaticShape(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public StaticShape(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public StaticShape(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public StaticShape(SimObject pObj) : base(pObj)
		{
		}

		public StaticShape(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.StaticShape_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setPoweredState(IntPtr thisPtr, bool isPowered);
         private static _setPoweredState _setPoweredStateFunc;
         internal static void setPoweredState(IntPtr thisPtr, bool isPowered)
         {
         	if (_setPoweredStateFunc == null)
         	{
         		_setPoweredStateFunc =
         			(_setPoweredState)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnStaticShape_setPoweredState"), typeof(_setPoweredState));
         	}
         
         	 _setPoweredStateFunc(thisPtr, isPowered);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getPoweredState(IntPtr thisPtr);
         private static _getPoweredState _getPoweredStateFunc;
         internal static bool getPoweredState(IntPtr thisPtr)
         {
         	if (_getPoweredStateFunc == null)
         	{
         		_getPoweredStateFunc =
         			(_getPoweredState)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnStaticShape_getPoweredState"), typeof(_getPoweredState));
         	}
         
         	return  _getPoweredStateFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _StaticShape_create();
         private static _StaticShape_create _StaticShape_createFunc;
         internal static IntPtr StaticShape_create()
         {
         	if (_StaticShape_createFunc == null)
         	{
         		_StaticShape_createFunc =
         			(_StaticShape_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_StaticShape_create"), typeof(_StaticShape_create));
         	}
         
         	return  _StaticShape_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setPoweredState(bool isPowered)
         {
            InternalUnsafeMethods.setPoweredState(ObjectPtr, isPowered);
         }
      
         public virtual bool getPoweredState()
         {
            return InternalUnsafeMethods.getPoweredState(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}