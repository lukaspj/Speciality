using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class RenderBinManager : SimObject
	{
		public RenderBinManager(bool pRegister = false)
			: base(pRegister)
		{
		}

		public RenderBinManager(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public RenderBinManager(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public RenderBinManager(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public RenderBinManager(SimObject pObj) : base(pObj)
		{
		}

		public RenderBinManager(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.RenderBinManager_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getBinType(IntPtr thisPtr);
         private static _getBinType _getBinTypeFunc;
         internal static IntPtr getBinType(IntPtr thisPtr)
         {
         	if (_getBinTypeFunc == null)
         	{
         		_getBinTypeFunc =
         			(_getBinType)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnRenderBinManager_getBinType"), typeof(_getBinType));
         	}
         
         	return  _getBinTypeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _RenderBinManager_create();
         private static _RenderBinManager_create _RenderBinManager_createFunc;
         internal static IntPtr RenderBinManager_create()
         {
         	if (_RenderBinManager_createFunc == null)
         	{
         		_RenderBinManager_createFunc =
         			(_RenderBinManager_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_RenderBinManager_create"), typeof(_RenderBinManager_create));
         	}
         
         	return  _RenderBinManager_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual string getBinType()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getBinType(ObjectPtr));
         }
      
      
      #endregion


      #region Properties
      
      
         public string BinType
         {
         	get { return getFieldValue("BinType"); }
         	set { setFieldValue("BinType", value); }
         }
      
         public float RenderOrder
         {
         	get { return float.Parse(getFieldValue("RenderOrder")); }
         	set { setFieldValue("RenderOrder", value.ToString()); }
         }
      
         public float ProcessAddOrder
         {
         	get { return float.Parse(getFieldValue("ProcessAddOrder")); }
         	set { setFieldValue("ProcessAddOrder", value.ToString()); }
         }
      
         public bool BasicOnly
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("BasicOnly")); }
         	set { setFieldValue("BasicOnly", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}