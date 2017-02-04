using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ForestBrush : SimGroup
	{
		public ForestBrush(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ForestBrush(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ForestBrush(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ForestBrush(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ForestBrush(SimObject pObj) : base(pObj)
		{
		}

		public ForestBrush(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ForestBrush_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _containsItemData(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string obj);
         private static _containsItemData _containsItemDataFunc;
         internal static bool containsItemData(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string obj)
         {
         	if (_containsItemDataFunc == null)
         	{
         		_containsItemDataFunc =
         			(_containsItemData)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnForestBrush_containsItemData"), typeof(_containsItemData));
         	}
         
         	return  _containsItemDataFunc(thisPtr, obj);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ForestBrush_create();
         private static _ForestBrush_create _ForestBrush_createFunc;
         internal static IntPtr ForestBrush_create()
         {
         	if (_ForestBrush_createFunc == null)
         	{
         		_ForestBrush_createFunc =
         			(_ForestBrush_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ForestBrush_create"), typeof(_ForestBrush_create));
         	}
         
         	return  _ForestBrush_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool containsItemData(string obj)
         {
            return InternalUnsafeMethods.containsItemData(ObjectPtr, obj);
         }
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}