using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class RenderShapeExample : SceneObject
	{
		public RenderShapeExample(bool pRegister = false)
			: base(pRegister)
		{
		}

		public RenderShapeExample(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public RenderShapeExample(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public RenderShapeExample(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public RenderShapeExample(SimObject pObj) : base(pObj)
		{
		}

		public RenderShapeExample(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.RenderShapeExample_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _RenderShapeExample_create();
         private static _RenderShapeExample_create _RenderShapeExample_createFunc;
         internal static IntPtr RenderShapeExample_create()
         {
         	if (_RenderShapeExample_createFunc == null)
         	{
         		_RenderShapeExample_createFunc =
         			(_RenderShapeExample_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_RenderShapeExample_create"), typeof(_RenderShapeExample_create));
         	}
         
         	return  _RenderShapeExample_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
      
      #endregion


      #region Properties
      
      
         public string ShapeFile
         {
         	get { return getFieldValue("ShapeFile"); }
         	set { setFieldValue("ShapeFile", value); }
         }
      
      
      #endregion

	}
}