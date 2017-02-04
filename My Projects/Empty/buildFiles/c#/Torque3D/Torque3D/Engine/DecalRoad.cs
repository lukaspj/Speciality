using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class DecalRoad : SceneObject
	{
		public DecalRoad(bool pRegister = false)
			: base(pRegister)
		{
		}

		public DecalRoad(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public DecalRoad(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public DecalRoad(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public DecalRoad(SimObject pObj) : base(pObj)
		{
		}

		public DecalRoad(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.DecalRoad_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _regenerate(IntPtr thisPtr);
         private static _regenerate _regenerateFunc;
         internal static void regenerate(IntPtr thisPtr)
         {
         	if (_regenerateFunc == null)
         	{
         		_regenerateFunc =
         			(_regenerate)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnDecalRoad_regenerate"), typeof(_regenerate));
         	}
         
         	 _regenerateFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _postApply(IntPtr thisPtr);
         private static _postApply _postApplyFunc;
         internal static void postApply(IntPtr thisPtr)
         {
         	if (_postApplyFunc == null)
         	{
         		_postApplyFunc =
         			(_postApply)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnDecalRoad_postApply"), typeof(_postApply));
         	}
         
         	 _postApplyFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _DecalRoad_create();
         private static _DecalRoad_create _DecalRoad_createFunc;
         internal static IntPtr DecalRoad_create()
         {
         	if (_DecalRoad_createFunc == null)
         	{
         		_DecalRoad_createFunc =
         			(_DecalRoad_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_DecalRoad_create"), typeof(_DecalRoad_create));
         	}
         
         	return  _DecalRoad_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void regenerate()
         {
            InternalUnsafeMethods.regenerate(ObjectPtr);
         }
      
         public virtual void postApply()
         {
            InternalUnsafeMethods.postApply(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public string Material
         {
         	get { return getFieldValue("Material"); }
         	set { setFieldValue("Material", value); }
         }
      
         public float TextureLength
         {
         	get { return float.Parse(getFieldValue("TextureLength")); }
         	set { setFieldValue("TextureLength", value.ToString()); }
         }
      
         public float BreakAngle
         {
         	get { return float.Parse(getFieldValue("BreakAngle")); }
         	set { setFieldValue("BreakAngle", value.ToString()); }
         }
      
         public int RenderPriority
         {
         	get { return int.Parse(getFieldValue("RenderPriority")); }
         	set { setFieldValue("RenderPriority", value.ToString()); }
         }
      
         public string Node
         {
         	get { return getFieldValue("Node"); }
         	set { setFieldValue("Node", value); }
         }
      
      
      #endregion

	}
}