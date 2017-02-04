using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class NavPath : SceneObject
	{
		public NavPath(bool pRegister = false)
			: base(pRegister)
		{
		}

		public NavPath(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public NavPath(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public NavPath(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public NavPath(SimObject pObj) : base(pObj)
		{
		}

		public NavPath(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.NavPath_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _plan(IntPtr thisPtr);
         private static _plan _planFunc;
         internal static bool plan(IntPtr thisPtr)
         {
         	if (_planFunc == null)
         	{
         		_planFunc =
         			(_plan)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNavPath_plan"), typeof(_plan));
         	}
         
         	return  _planFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _onNavMeshUpdate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string data);
         private static _onNavMeshUpdate _onNavMeshUpdateFunc;
         internal static void onNavMeshUpdate(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string data)
         {
         	if (_onNavMeshUpdateFunc == null)
         	{
         		_onNavMeshUpdateFunc =
         			(_onNavMeshUpdate)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNavPath_onNavMeshUpdate"), typeof(_onNavMeshUpdate));
         	}
         
         	 _onNavMeshUpdateFunc(thisPtr, data);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _onNavMeshUpdateBox(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string data);
         private static _onNavMeshUpdateBox _onNavMeshUpdateBoxFunc;
         internal static void onNavMeshUpdateBox(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string data)
         {
         	if (_onNavMeshUpdateBoxFunc == null)
         	{
         		_onNavMeshUpdateBoxFunc =
         			(_onNavMeshUpdateBox)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNavPath_onNavMeshUpdateBox"), typeof(_onNavMeshUpdateBox));
         	}
         
         	 _onNavMeshUpdateBoxFunc(thisPtr, data);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _size(IntPtr thisPtr);
         private static _size _sizeFunc;
         internal static int size(IntPtr thisPtr)
         {
         	if (_sizeFunc == null)
         	{
         		_sizeFunc =
         			(_size)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNavPath_size"), typeof(_size));
         	}
         
         	return  _sizeFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getNode(IntPtr thisPtr, int idx);
         private static _getNode _getNodeFunc;
         internal static InternalPoint3FStruct getNode(IntPtr thisPtr, int idx)
         {
         	if (_getNodeFunc == null)
         	{
         		_getNodeFunc =
         			(_getNode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNavPath_getNode"), typeof(_getNode));
         	}
         
         	return  _getNodeFunc(thisPtr, idx);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getFlags(IntPtr thisPtr, int idx);
         private static _getFlags _getFlagsFunc;
         internal static int getFlags(IntPtr thisPtr, int idx)
         {
         	if (_getFlagsFunc == null)
         	{
         		_getFlagsFunc =
         			(_getFlags)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNavPath_getFlags"), typeof(_getFlags));
         	}
         
         	return  _getFlagsFunc(thisPtr, idx);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getLength(IntPtr thisPtr);
         private static _getLength _getLengthFunc;
         internal static float getLength(IntPtr thisPtr)
         {
         	if (_getLengthFunc == null)
         	{
         		_getLengthFunc =
         			(_getLength)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNavPath_getLength"), typeof(_getLength));
         	}
         
         	return  _getLengthFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _NavPath_create();
         private static _NavPath_create _NavPath_createFunc;
         internal static IntPtr NavPath_create()
         {
         	if (_NavPath_createFunc == null)
         	{
         		_NavPath_createFunc =
         			(_NavPath_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_NavPath_create"), typeof(_NavPath_create));
         	}
         
         	return  _NavPath_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool plan()
         {
            return InternalUnsafeMethods.plan(ObjectPtr);
         }
      
         public virtual void onNavMeshUpdate(string data)
         {
            InternalUnsafeMethods.onNavMeshUpdate(ObjectPtr, data);
         }
      
         public virtual void onNavMeshUpdateBox(string data)
         {
            InternalUnsafeMethods.onNavMeshUpdateBox(ObjectPtr, data);
         }
      
         public virtual int size()
         {
            return InternalUnsafeMethods.size(ObjectPtr);
         }
      
         public virtual Point3F getNode(int idx)
         {
            return new Point3F(InternalUnsafeMethods.getNode(ObjectPtr, idx));
         }
      
         public virtual int getFlags(int idx)
         {
            return InternalUnsafeMethods.getFlags(ObjectPtr, idx);
         }
      
         public virtual float getLength()
         {
            return InternalUnsafeMethods.getLength(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public Point3F From
         {
         	get { return new Point3F(getFieldValue("From")); }
         	set { setFieldValue("From", value.ToString()); }
         }
      
         public Point3F To
         {
         	get { return new Point3F(getFieldValue("To")); }
         	set { setFieldValue("To", value.ToString()); }
         }
      
         public string Mesh
         {
         	get { return getFieldValue("Mesh"); }
         	set { setFieldValue("Mesh", value); }
         }
      
         public Path Waypoints
         {
         	get { return Sim.FindObject<Path>(getFieldValue("Waypoints")); }
         	set { setFieldValue("Waypoints", value.getId().ToString()); }
         }
      
         public bool IsLooping
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsLooping")); }
         	set { setFieldValue("IsLooping", value ? "1" : "0"); }
         }
      
         public bool IsSliced
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsSliced")); }
         	set { setFieldValue("IsSliced", value ? "1" : "0"); }
         }
      
         public int MaxIterations
         {
         	get { return int.Parse(getFieldValue("MaxIterations")); }
         	set { setFieldValue("MaxIterations", value.ToString()); }
         }
      
         public bool AutoUpdate
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AutoUpdate")); }
         	set { setFieldValue("AutoUpdate", value ? "1" : "0"); }
         }
      
         public bool AllowWalk
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AllowWalk")); }
         	set { setFieldValue("AllowWalk", value ? "1" : "0"); }
         }
      
         public bool AllowJump
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AllowJump")); }
         	set { setFieldValue("AllowJump", value ? "1" : "0"); }
         }
      
         public bool AllowDrop
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AllowDrop")); }
         	set { setFieldValue("AllowDrop", value ? "1" : "0"); }
         }
      
         public bool AllowSwim
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AllowSwim")); }
         	set { setFieldValue("AllowSwim", value ? "1" : "0"); }
         }
      
         public bool AllowLedge
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AllowLedge")); }
         	set { setFieldValue("AllowLedge", value ? "1" : "0"); }
         }
      
         public bool AllowClimb
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AllowClimb")); }
         	set { setFieldValue("AllowClimb", value ? "1" : "0"); }
         }
      
         public bool AllowTeleport
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AllowTeleport")); }
         	set { setFieldValue("AllowTeleport", value ? "1" : "0"); }
         }
      
         public bool AlwaysRender
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AlwaysRender")); }
         	set { setFieldValue("AlwaysRender", value ? "1" : "0"); }
         }
      
         public bool Xray
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Xray")); }
         	set { setFieldValue("Xray", value ? "1" : "0"); }
         }
      
         public bool RenderSearch
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RenderSearch")); }
         	set { setFieldValue("RenderSearch", value ? "1" : "0"); }
         }
      
      
      #endregion

	}
}