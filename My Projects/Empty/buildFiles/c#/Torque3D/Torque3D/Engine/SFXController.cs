using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class SFXController : SFXSource
	{
		public SFXController(bool pRegister = false)
			: base(pRegister)
		{
		}

		public SFXController(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public SFXController(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public SFXController(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public SFXController(SimObject pObj) : base(pObj)
		{
		}

		public SFXController(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.SFXController_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getCurrentSlot(IntPtr thisPtr);
         private static _getCurrentSlot _getCurrentSlotFunc;
         internal static int getCurrentSlot(IntPtr thisPtr)
         {
         	if (_getCurrentSlotFunc == null)
         	{
         		_getCurrentSlotFunc =
         			(_getCurrentSlot)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXController_getCurrentSlot"), typeof(_getCurrentSlot));
         	}
         
         	return  _getCurrentSlotFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setCurrentSlot(IntPtr thisPtr, int index);
         private static _setCurrentSlot _setCurrentSlotFunc;
         internal static void setCurrentSlot(IntPtr thisPtr, int index)
         {
         	if (_setCurrentSlotFunc == null)
         	{
         		_setCurrentSlotFunc =
         			(_setCurrentSlot)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnSFXController_setCurrentSlot"), typeof(_setCurrentSlot));
         	}
         
         	 _setCurrentSlotFunc(thisPtr, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _SFXController_create();
         private static _SFXController_create _SFXController_createFunc;
         internal static IntPtr SFXController_create()
         {
         	if (_SFXController_createFunc == null)
         	{
         		_SFXController_createFunc =
         			(_SFXController_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_SFXController_create"), typeof(_SFXController_create));
         	}
         
         	return  _SFXController_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual int getCurrentSlot()
         {
            return InternalUnsafeMethods.getCurrentSlot(ObjectPtr);
         }
      
         public virtual void setCurrentSlot(int index)
         {
            InternalUnsafeMethods.setCurrentSlot(ObjectPtr, index);
         }
      
      
      #endregion


      #region Properties
      
      
         public bool Trace
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Trace")); }
         	set { setFieldValue("Trace", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}