using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class RibbonNode : GameBase
	{
		public RibbonNode(bool pRegister = false)
			: base(pRegister)
		{
		}

		public RibbonNode(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public RibbonNode(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public RibbonNode(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public RibbonNode(SimObject pObj) : base(pObj)
		{
		}

		public RibbonNode(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.RibbonNode_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setRibbonDatablock(IntPtr thisPtr, IntPtr ribbonDatablock);
         private static _setRibbonDatablock _setRibbonDatablockFunc;
         internal static void setRibbonDatablock(IntPtr thisPtr, IntPtr ribbonDatablock)
         {
         	if (_setRibbonDatablockFunc == null)
         	{
         		_setRibbonDatablockFunc =
         			(_setRibbonDatablock)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnRibbonNode_setRibbonDatablock"), typeof(_setRibbonDatablock));
         	}
         
         	 _setRibbonDatablockFunc(thisPtr, ribbonDatablock);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setActive(IntPtr thisPtr, bool active);
         private static _setActive _setActiveFunc;
         internal static void setActive(IntPtr thisPtr, bool active)
         {
         	if (_setActiveFunc == null)
         	{
         		_setActiveFunc =
         			(_setActive)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnRibbonNode_setActive"), typeof(_setActive));
         	}
         
         	 _setActiveFunc(thisPtr, active);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _RibbonNode_create();
         private static _RibbonNode_create _RibbonNode_createFunc;
         internal static IntPtr RibbonNode_create()
         {
         	if (_RibbonNode_createFunc == null)
         	{
         		_RibbonNode_createFunc =
         			(_RibbonNode_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_RibbonNode_create"), typeof(_RibbonNode_create));
         	}
         
         	return  _RibbonNode_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setRibbonDatablock(RibbonData ribbonDatablock)
         {
            InternalUnsafeMethods.setRibbonDatablock(ObjectPtr, ribbonDatablock.ObjectPtr);
         }
      
         public virtual void setActive(bool active)
         {
            InternalUnsafeMethods.setActive(ObjectPtr, active);
         }
      
      
      #endregion


      #region Properties
      
      
         public bool Active
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Active")); }
         	set { setFieldValue("Active", value ? "1" : "0"); }
         }
      
         public RibbonData Ribbon
         {
         	get { return Sim.FindObject<RibbonData>(getFieldValue("Ribbon")); }
         	set { setFieldValue("Ribbon", value.getId().ToString()); }
         }
      
      
      #endregion

	}
}