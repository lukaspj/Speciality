using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class MeshRoad : SceneObject
	{
		public MeshRoad(bool pRegister = false)
			: base(pRegister)
		{
		}

		public MeshRoad(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public MeshRoad(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public MeshRoad(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public MeshRoad(SimObject pObj) : base(pObj)
		{
		}

		public MeshRoad(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.MeshRoad_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setNodeDepth(IntPtr thisPtr, int idx, float meters);
         private static _setNodeDepth _setNodeDepthFunc;
         internal static void setNodeDepth(IntPtr thisPtr, int idx, float meters)
         {
         	if (_setNodeDepthFunc == null)
         	{
         		_setNodeDepthFunc =
         			(_setNodeDepth)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnMeshRoad_setNodeDepth"), typeof(_setNodeDepth));
         	}
         
         	 _setNodeDepthFunc(thisPtr, idx, meters);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _regenerate(IntPtr thisPtr);
         private static _regenerate _regenerateFunc;
         internal static void regenerate(IntPtr thisPtr)
         {
         	if (_regenerateFunc == null)
         	{
         		_regenerateFunc =
         			(_regenerate)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnMeshRoad_regenerate"), typeof(_regenerate));
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
         				"fnMeshRoad_postApply"), typeof(_postApply));
         	}
         
         	 _postApplyFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _MeshRoad_create();
         private static _MeshRoad_create _MeshRoad_createFunc;
         internal static IntPtr MeshRoad_create()
         {
         	if (_MeshRoad_createFunc == null)
         	{
         		_MeshRoad_createFunc =
         			(_MeshRoad_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_MeshRoad_create"), typeof(_MeshRoad_create));
         	}
         
         	return  _MeshRoad_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void setNodeDepth(int idx, float meters)
         {
            InternalUnsafeMethods.setNodeDepth(ObjectPtr, idx, meters);
         }
      
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
      
      
         public string TopMaterial
         {
         	get { return getFieldValue("TopMaterial"); }
         	set { setFieldValue("TopMaterial", value); }
         }
      
         public string BottomMaterial
         {
         	get { return getFieldValue("BottomMaterial"); }
         	set { setFieldValue("BottomMaterial", value); }
         }
      
         public string SideMaterial
         {
         	get { return getFieldValue("SideMaterial"); }
         	set { setFieldValue("SideMaterial", value); }
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
      
         public int WidthSubdivisions
         {
         	get { return int.Parse(getFieldValue("WidthSubdivisions")); }
         	set { setFieldValue("WidthSubdivisions", value.ToString()); }
         }
      
         public string Node
         {
         	get { return getFieldValue("Node"); }
         	set { setFieldValue("Node", value); }
         }
      
      
      #endregion

	}
}