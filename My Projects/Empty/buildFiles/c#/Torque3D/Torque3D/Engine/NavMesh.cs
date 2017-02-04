using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class NavMesh : SceneObject
	{
		public NavMesh(bool pRegister = false)
			: base(pRegister)
		{
		}

		public NavMesh(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public NavMesh(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public NavMesh(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public NavMesh(SimObject pObj) : base(pObj)
		{
		}

		public NavMesh(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.NavMesh_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _addLink(IntPtr thisPtr, InternalPoint3FStruct from, InternalPoint3FStruct to, uint flags);
         private static _addLink _addLinkFunc;
         internal static int addLink(IntPtr thisPtr, InternalPoint3FStruct from, InternalPoint3FStruct to, uint flags)
         {
         	if (_addLinkFunc == null)
         	{
         		_addLinkFunc =
         			(_addLink)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNavMesh_addLink"), typeof(_addLink));
         	}
         
         	return  _addLinkFunc(thisPtr, from, to, flags);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getLink(IntPtr thisPtr, InternalPoint3FStruct pos);
         private static _getLink _getLinkFunc;
         internal static int getLink(IntPtr thisPtr, InternalPoint3FStruct pos)
         {
         	if (_getLinkFunc == null)
         	{
         		_getLinkFunc =
         			(_getLink)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNavMesh_getLink"), typeof(_getLink));
         	}
         
         	return  _getLinkFunc(thisPtr, pos);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getLinkCount(IntPtr thisPtr);
         private static _getLinkCount _getLinkCountFunc;
         internal static int getLinkCount(IntPtr thisPtr)
         {
         	if (_getLinkCountFunc == null)
         	{
         		_getLinkCountFunc =
         			(_getLinkCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNavMesh_getLinkCount"), typeof(_getLinkCount));
         	}
         
         	return  _getLinkCountFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getLinkFlags(IntPtr thisPtr, uint id);
         private static _getLinkFlags _getLinkFlagsFunc;
         internal static int getLinkFlags(IntPtr thisPtr, uint id)
         {
         	if (_getLinkFlagsFunc == null)
         	{
         		_getLinkFlagsFunc =
         			(_getLinkFlags)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNavMesh_getLinkFlags"), typeof(_getLinkFlags));
         	}
         
         	return  _getLinkFlagsFunc(thisPtr, id);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setLinkFlags(IntPtr thisPtr, uint id, uint flags);
         private static _setLinkFlags _setLinkFlagsFunc;
         internal static void setLinkFlags(IntPtr thisPtr, uint id, uint flags)
         {
         	if (_setLinkFlagsFunc == null)
         	{
         		_setLinkFlagsFunc =
         			(_setLinkFlags)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNavMesh_setLinkFlags"), typeof(_setLinkFlags));
         	}
         
         	 _setLinkFlagsFunc(thisPtr, id, flags);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getLinkStart(IntPtr thisPtr, uint id);
         private static _getLinkStart _getLinkStartFunc;
         internal static InternalPoint3FStruct getLinkStart(IntPtr thisPtr, uint id)
         {
         	if (_getLinkStartFunc == null)
         	{
         		_getLinkStartFunc =
         			(_getLinkStart)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNavMesh_getLinkStart"), typeof(_getLinkStart));
         	}
         
         	return  _getLinkStartFunc(thisPtr, id);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getLinkEnd(IntPtr thisPtr, uint id);
         private static _getLinkEnd _getLinkEndFunc;
         internal static InternalPoint3FStruct getLinkEnd(IntPtr thisPtr, uint id)
         {
         	if (_getLinkEndFunc == null)
         	{
         		_getLinkEndFunc =
         			(_getLinkEnd)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNavMesh_getLinkEnd"), typeof(_getLinkEnd));
         	}
         
         	return  _getLinkEndFunc(thisPtr, id);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _deleteLink(IntPtr thisPtr, uint id);
         private static _deleteLink _deleteLinkFunc;
         internal static void deleteLink(IntPtr thisPtr, uint id)
         {
         	if (_deleteLinkFunc == null)
         	{
         		_deleteLinkFunc =
         			(_deleteLink)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNavMesh_deleteLink"), typeof(_deleteLink));
         	}
         
         	 _deleteLinkFunc(thisPtr, id);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _deleteLinks(IntPtr thisPtr);
         private static _deleteLinks _deleteLinksFunc;
         internal static void deleteLinks(IntPtr thisPtr)
         {
         	if (_deleteLinksFunc == null)
         	{
         		_deleteLinksFunc =
         			(_deleteLinks)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNavMesh_deleteLinks"), typeof(_deleteLinks));
         	}
         
         	 _deleteLinksFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _build(IntPtr thisPtr, bool background, bool save);
         private static _build _buildFunc;
         internal static bool build(IntPtr thisPtr, bool background, bool save)
         {
         	if (_buildFunc == null)
         	{
         		_buildFunc =
         			(_build)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNavMesh_build"), typeof(_build));
         	}
         
         	return  _buildFunc(thisPtr, background, save);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _cancelBuild(IntPtr thisPtr);
         private static _cancelBuild _cancelBuildFunc;
         internal static void cancelBuild(IntPtr thisPtr)
         {
         	if (_cancelBuildFunc == null)
         	{
         		_cancelBuildFunc =
         			(_cancelBuild)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNavMesh_cancelBuild"), typeof(_cancelBuild));
         	}
         
         	 _cancelBuildFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _buildTiles(IntPtr thisPtr, InternalBox3FStruct box);
         private static _buildTiles _buildTilesFunc;
         internal static void buildTiles(IntPtr thisPtr, InternalBox3FStruct box)
         {
         	if (_buildTilesFunc == null)
         	{
         		_buildTilesFunc =
         			(_buildTiles)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNavMesh_buildTiles"), typeof(_buildTiles));
         	}
         
         	 _buildTilesFunc(thisPtr, box);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _buildLinks(IntPtr thisPtr);
         private static _buildLinks _buildLinksFunc;
         internal static void buildLinks(IntPtr thisPtr)
         {
         	if (_buildLinksFunc == null)
         	{
         		_buildLinksFunc =
         			(_buildLinks)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNavMesh_buildLinks"), typeof(_buildLinks));
         	}
         
         	 _buildLinksFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _deleteCoverPoints(IntPtr thisPtr);
         private static _deleteCoverPoints _deleteCoverPointsFunc;
         internal static void deleteCoverPoints(IntPtr thisPtr)
         {
         	if (_deleteCoverPointsFunc == null)
         	{
         		_deleteCoverPointsFunc =
         			(_deleteCoverPoints)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNavMesh_deleteCoverPoints"), typeof(_deleteCoverPoints));
         	}
         
         	 _deleteCoverPointsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _createCoverPoints(IntPtr thisPtr);
         private static _createCoverPoints _createCoverPointsFunc;
         internal static bool createCoverPoints(IntPtr thisPtr)
         {
         	if (_createCoverPointsFunc == null)
         	{
         		_createCoverPointsFunc =
         			(_createCoverPoints)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNavMesh_createCoverPoints"), typeof(_createCoverPoints));
         	}
         
         	return  _createCoverPointsFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _load(IntPtr thisPtr);
         private static _load _loadFunc;
         internal static bool load(IntPtr thisPtr)
         {
         	if (_loadFunc == null)
         	{
         		_loadFunc =
         			(_load)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNavMesh_load"), typeof(_load));
         	}
         
         	return  _loadFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _save(IntPtr thisPtr);
         private static _save _saveFunc;
         internal static void save(IntPtr thisPtr)
         {
         	if (_saveFunc == null)
         	{
         		_saveFunc =
         			(_save)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnNavMesh_save"), typeof(_save));
         	}
         
         	 _saveFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _NavMesh_create();
         private static _NavMesh_create _NavMesh_createFunc;
         internal static IntPtr NavMesh_create()
         {
         	if (_NavMesh_createFunc == null)
         	{
         		_NavMesh_createFunc =
         			(_NavMesh_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_NavMesh_create"), typeof(_NavMesh_create));
         	}
         
         	return  _NavMesh_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual int addLink(Point3F from, Point3F to, uint flags = 0)
         {
            return InternalUnsafeMethods.addLink(ObjectPtr, from.ToStruct(), to.ToStruct(), flags);
         }
      
         public virtual int getLink(Point3F pos)
         {
            return InternalUnsafeMethods.getLink(ObjectPtr, pos.ToStruct());
         }
      
         public virtual int getLinkCount()
         {
            return InternalUnsafeMethods.getLinkCount(ObjectPtr);
         }
      
         public virtual int getLinkFlags(uint id)
         {
            return InternalUnsafeMethods.getLinkFlags(ObjectPtr, id);
         }
      
         public virtual void setLinkFlags(uint id, uint flags)
         {
            InternalUnsafeMethods.setLinkFlags(ObjectPtr, id, flags);
         }
      
         public virtual Point3F getLinkStart(uint id)
         {
            return new Point3F(InternalUnsafeMethods.getLinkStart(ObjectPtr, id));
         }
      
         public virtual Point3F getLinkEnd(uint id)
         {
            return new Point3F(InternalUnsafeMethods.getLinkEnd(ObjectPtr, id));
         }
      
         public virtual void deleteLink(uint id)
         {
            InternalUnsafeMethods.deleteLink(ObjectPtr, id);
         }
      
         public virtual void deleteLinks()
         {
            InternalUnsafeMethods.deleteLinks(ObjectPtr);
         }
      
         public virtual bool build(bool background = true, bool save = false)
         {
            return InternalUnsafeMethods.build(ObjectPtr, background, save);
         }
      
         public virtual void cancelBuild()
         {
            InternalUnsafeMethods.cancelBuild(ObjectPtr);
         }
      
         public virtual void buildTiles(Box3F box)
         {
            InternalUnsafeMethods.buildTiles(ObjectPtr, box.ToStruct());
         }
      
         public virtual void buildLinks()
         {
            InternalUnsafeMethods.buildLinks(ObjectPtr);
         }
      
         public virtual void deleteCoverPoints()
         {
            InternalUnsafeMethods.deleteCoverPoints(ObjectPtr);
         }
      
         public virtual bool createCoverPoints()
         {
            return InternalUnsafeMethods.createCoverPoints(ObjectPtr);
         }
      
         public virtual bool load()
         {
            return InternalUnsafeMethods.load(ObjectPtr);
         }
      
         public virtual void save()
         {
            InternalUnsafeMethods.save(ObjectPtr);
         }
      
      
      #endregion


      #region Properties
      
      
         public string FileName
         {
         	get { return getFieldValue("FileName"); }
         	set { setFieldValue("FileName", value); }
         }
      
         public NavMeshWaterMethod WaterMethod
         {
         	get { return (NavMeshWaterMethod)Enum.Parse(typeof(NavMeshWaterMethod), getFieldValue("WaterMethod"), true); }
         	set { setFieldValue("WaterMethod", value.ToString()); }
         }
      
         public float CellSize
         {
         	get { return float.Parse(getFieldValue("CellSize")); }
         	set { setFieldValue("CellSize", value.ToString()); }
         }
      
         public float CellHeight
         {
         	get { return float.Parse(getFieldValue("CellHeight")); }
         	set { setFieldValue("CellHeight", value.ToString()); }
         }
      
         public float TileSize
         {
         	get { return float.Parse(getFieldValue("TileSize")); }
         	set { setFieldValue("TileSize", value.ToString()); }
         }
      
         public float ActorHeight
         {
         	get { return float.Parse(getFieldValue("ActorHeight")); }
         	set { setFieldValue("ActorHeight", value.ToString()); }
         }
      
         public float ActorClimb
         {
         	get { return float.Parse(getFieldValue("ActorClimb")); }
         	set { setFieldValue("ActorClimb", value.ToString()); }
         }
      
         public float ActorRadius
         {
         	get { return float.Parse(getFieldValue("ActorRadius")); }
         	set { setFieldValue("ActorRadius", value.ToString()); }
         }
      
         public float WalkableSlope
         {
         	get { return float.Parse(getFieldValue("WalkableSlope")); }
         	set { setFieldValue("WalkableSlope", value.ToString()); }
         }
      
         public bool SmallCharacters
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("SmallCharacters")); }
         	set { setFieldValue("SmallCharacters", value ? "1" : "0"); }
         }
      
         public bool RegularCharacters
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("RegularCharacters")); }
         	set { setFieldValue("RegularCharacters", value ? "1" : "0"); }
         }
      
         public bool LargeCharacters
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("LargeCharacters")); }
         	set { setFieldValue("LargeCharacters", value ? "1" : "0"); }
         }
      
         public bool Vehicles
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Vehicles")); }
         	set { setFieldValue("Vehicles", value ? "1" : "0"); }
         }
      
         public string CoverGroup
         {
         	get { return getFieldValue("CoverGroup"); }
         	set { setFieldValue("CoverGroup", value); }
         }
      
         public bool InnerCover
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("InnerCover")); }
         	set { setFieldValue("InnerCover", value ? "1" : "0"); }
         }
      
         public float CoverDist
         {
         	get { return float.Parse(getFieldValue("CoverDist")); }
         	set { setFieldValue("CoverDist", value.ToString()); }
         }
      
         public float PeekDist
         {
         	get { return float.Parse(getFieldValue("PeekDist")); }
         	set { setFieldValue("PeekDist", value.ToString()); }
         }
      
         public bool AlwaysRender
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AlwaysRender")); }
         	set { setFieldValue("AlwaysRender", value ? "1" : "0"); }
         }
      
         public int BorderSize
         {
         	get { return int.Parse(getFieldValue("BorderSize")); }
         	set { setFieldValue("BorderSize", value.ToString()); }
         }
      
         public float DetailSampleDist
         {
         	get { return float.Parse(getFieldValue("DetailSampleDist")); }
         	set { setFieldValue("DetailSampleDist", value.ToString()); }
         }
      
         public float DetailSampleError
         {
         	get { return float.Parse(getFieldValue("DetailSampleError")); }
         	set { setFieldValue("DetailSampleError", value.ToString()); }
         }
      
         public int MaxEdgeLen
         {
         	get { return int.Parse(getFieldValue("MaxEdgeLen")); }
         	set { setFieldValue("MaxEdgeLen", value.ToString()); }
         }
      
         public float SimplificationError
         {
         	get { return float.Parse(getFieldValue("SimplificationError")); }
         	set { setFieldValue("SimplificationError", value.ToString()); }
         }
      
         public int MinRegionArea
         {
         	get { return int.Parse(getFieldValue("MinRegionArea")); }
         	set { setFieldValue("MinRegionArea", value.ToString()); }
         }
      
         public int MergeRegionArea
         {
         	get { return int.Parse(getFieldValue("MergeRegionArea")); }
         	set { setFieldValue("MergeRegionArea", value.ToString()); }
         }
      
         public int MaxPolysPerTile
         {
         	get { return int.Parse(getFieldValue("MaxPolysPerTile")); }
         	set { setFieldValue("MaxPolysPerTile", value.ToString()); }
         }
      
      
      #endregion

	}
}