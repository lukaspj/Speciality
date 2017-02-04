using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class RenderObjectExample : SceneObject
	{
		public RenderObjectExample(bool pRegister = false)
			: base(pRegister)
		{
		}

		public RenderObjectExample(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public RenderObjectExample(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public RenderObjectExample(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public RenderObjectExample(SimObject pObj) : base(pObj)
		{
		}

		public RenderObjectExample(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.RenderObjectExample_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _RenderObjectExample_create();
         private static _RenderObjectExample_create _RenderObjectExample_createFunc;
         internal static IntPtr RenderObjectExample_create()
         {
         	if (_RenderObjectExample_createFunc == null)
         	{
         		_RenderObjectExample_createFunc =
         			(_RenderObjectExample_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_RenderObjectExample_create"), typeof(_RenderObjectExample_create));
         	}
         
         	return  _RenderObjectExample_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
      
      #endregion

	}
}