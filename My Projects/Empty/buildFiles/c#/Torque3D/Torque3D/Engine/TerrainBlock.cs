using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class TerrainBlock : SceneObject
	{
		public TerrainBlock(bool pRegister = false)
			: base(pRegister)
		{
		}

		public TerrainBlock(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public TerrainBlock(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public TerrainBlock(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public TerrainBlock(SimObject pObj) : base(pObj)
		{
		}

		public TerrainBlock(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.TerrainBlock_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _save(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fileName);
         private static _save _saveFunc;
         internal static bool save(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fileName)
         {
         	if (_saveFunc == null)
         	{
         		_saveFunc =
         			(_save)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainBlock_save"), typeof(_save));
         	}
         
         	return  _saveFunc(thisPtr, fileName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _exportHeightMap(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fileNameStr, [MarshalAs(UnmanagedType.LPWStr)]string format);
         private static _exportHeightMap _exportHeightMapFunc;
         internal static bool exportHeightMap(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string fileNameStr, [MarshalAs(UnmanagedType.LPWStr)]string format)
         {
         	if (_exportHeightMapFunc == null)
         	{
         		_exportHeightMapFunc =
         			(_exportHeightMap)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainBlock_exportHeightMap"), typeof(_exportHeightMap));
         	}
         
         	return  _exportHeightMapFunc(thisPtr, fileNameStr, format);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _exportLayerMaps(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filePrefixStr, [MarshalAs(UnmanagedType.LPWStr)]string format);
         private static _exportLayerMaps _exportLayerMapsFunc;
         internal static bool exportLayerMaps(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string filePrefixStr, [MarshalAs(UnmanagedType.LPWStr)]string format)
         {
         	if (_exportLayerMapsFunc == null)
         	{
         		_exportLayerMapsFunc =
         			(_exportLayerMaps)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainBlock_exportLayerMaps"), typeof(_exportLayerMaps));
         	}
         
         	return  _exportLayerMapsFunc(thisPtr, filePrefixStr, format);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _createNew(IntPtr thisPtr, int argc, string[] argv);
         private static _createNew _createNewFunc;
         internal static int createNew(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_createNewFunc == null)
         	{
         		_createNewFunc =
         			(_createNew)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainBlock_createNew"), typeof(_createNew));
         	}
         
         	return  _createNewFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _import(IntPtr thisPtr, int argc, string[] argv);
         private static _import _importFunc;
         internal static int import(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_importFunc == null)
         	{
         		_importFunc =
         			(_import)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnTerrainBlock_import"), typeof(_import));
         	}
         
         	return  _importFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _TerrainBlock_create();
         private static _TerrainBlock_create _TerrainBlock_createFunc;
         internal static IntPtr TerrainBlock_create()
         {
         	if (_TerrainBlock_createFunc == null)
         	{
         		_TerrainBlock_createFunc =
         			(_TerrainBlock_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_TerrainBlock_create"), typeof(_TerrainBlock_create));
         	}
         
         	return  _TerrainBlock_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual bool save(string fileName)
         {
            return InternalUnsafeMethods.save(ObjectPtr, fileName);
         }
      
         public virtual bool exportHeightMap(string fileNameStr, string format = "png")
         {
            return InternalUnsafeMethods.exportHeightMap(ObjectPtr, fileNameStr, format);
         }
      
         public virtual bool exportLayerMaps(string filePrefixStr, string format = "png")
         {
            return InternalUnsafeMethods.exportLayerMaps(ObjectPtr, filePrefixStr, format);
         }
      
         public virtual int createNew()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  return InternalUnsafeMethods.createNew(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public virtual int import(string terrainName, string heightMap, float metersPerPixel, float heightScale, string materials, string opacityLayers, bool flipYAxis = true)
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  tmp_arg_list.Add(terrainName.ToString());
                  tmp_arg_list.Add(heightMap.ToString());
                  tmp_arg_list.Add(metersPerPixel.ToString());
                  tmp_arg_list.Add(heightScale.ToString());
                  tmp_arg_list.Add(materials.ToString());
                  tmp_arg_list.Add(opacityLayers.ToString());
                  tmp_arg_list.Add(flipYAxis.ToString());
                  return InternalUnsafeMethods.import(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
      
      #endregion


      #region Properties
      
      
         public string TerrainFile
         {
         	get { return getFieldValue("TerrainFile"); }
         	set { setFieldValue("TerrainFile", value); }
         }
      
         public bool CastShadows
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("CastShadows")); }
         	set { setFieldValue("CastShadows", value ? "1" : "0"); }
         }
      
         public float SquareSize
         {
         	get { return float.Parse(getFieldValue("SquareSize")); }
         	set { setFieldValue("SquareSize", value.ToString()); }
         }
      
         public int BaseTexSize
         {
         	get { return int.Parse(getFieldValue("BaseTexSize")); }
         	set { setFieldValue("BaseTexSize", value.ToString()); }
         }
      
         public baseTexFormat BaseTexFormat
         {
         	get { return (baseTexFormat)Enum.Parse(typeof(baseTexFormat), getFieldValue("BaseTexFormat"), true); }
         	set { setFieldValue("BaseTexFormat", value.ToString()); }
         }
      
         public int LightMapSize
         {
         	get { return int.Parse(getFieldValue("LightMapSize")); }
         	set { setFieldValue("LightMapSize", value.ToString()); }
         }
      
         public int ScreenError
         {
         	get { return int.Parse(getFieldValue("ScreenError")); }
         	set { setFieldValue("ScreenError", value.ToString()); }
         }
      
      
      #endregion

	}
}