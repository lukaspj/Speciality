using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class ConvexShape : SceneObject
	{
		public ConvexShape(bool pRegister = false)
			: base(pRegister)
		{
		}

		public ConvexShape(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public ConvexShape(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public ConvexShape(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public ConvexShape(SimObject pObj) : base(pObj)
		{
		}

		public ConvexShape(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.ConvexShape_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ConvexShape_create();
         private static _ConvexShape_create _ConvexShape_createFunc;
         internal static IntPtr ConvexShape_create()
         {
         	if (_ConvexShape_createFunc == null)
         	{
         		_ConvexShape_createFunc =
         			(_ConvexShape_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ConvexShape_create"), typeof(_ConvexShape_create));
         	}
         
         	return  _ConvexShape_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string Material
         {
         	get { return getFieldValue("Material"); }
         	set { setFieldValue("Material", value); }
         }
      
         public string Surface
         {
         	get { return getFieldValue("Surface"); }
         	set { setFieldValue("Surface", value); }
         }
      
      
      #endregion

	}
}