using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiNavEditorCtrl : EditTSCtrl
	{
		public GuiNavEditorCtrl(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiNavEditorCtrl(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiNavEditorCtrl(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiNavEditorCtrl(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiNavEditorCtrl(SimObject pObj) : base(pObj)
		{
		}

		public GuiNavEditorCtrl(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiNavEditorCtrl_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _selectMesh(IntPtr thisPtr, int id);
         private static _selectMesh _selectMeshFunc;
         internal static void selectMesh(IntPtr thisPtr, int id)
         {
         	if (_selectMeshFunc == null)
         	{
         		_selectMeshFunc =
         			(_selectMesh)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiNavEditorCtrl_selectMesh"), typeof(_selectMesh));
         	}
         
         	 _selectMeshFunc(thisPtr, id);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getMesh(IntPtr thisPtr);
         private static _getMesh _getMeshFunc;
         internal static int getMesh(IntPtr thisPtr)
         {
         	if (_getMeshFunc == null)
         	{
         		_getMeshFunc =
         			(_getMesh)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiNavEditorCtrl_getMesh"), typeof(_getMesh));
         	}
         
         	return  _getMeshFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getPlayer(IntPtr thisPtr);
         private static _getPlayer _getPlayerFunc;
         internal static int getPlayer(IntPtr thisPtr)
         {
         	if (_getPlayerFunc == null)
         	{
         		_getPlayerFunc =
         			(_getPlayer)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiNavEditorCtrl_getPlayer"), typeof(_getPlayer));
         	}
         
         	return  _getPlayerFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _deselect(IntPtr thisPtr);
         private static _deselect _deselectFunc;
         internal static void deselect(IntPtr thisPtr)
         {
         	if (_deselectFunc == null)
         	{
         		_deselectFunc =
         			(_deselect)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiNavEditorCtrl_deselect"), typeof(_deselect));
         	}
         
         	 _deselectFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _deleteLink(IntPtr thisPtr);
         private static _deleteLink _deleteLinkFunc;
         internal static void deleteLink(IntPtr thisPtr)
         {
         	if (_deleteLinkFunc == null)
         	{
         		_deleteLinkFunc =
         			(_deleteLink)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiNavEditorCtrl_deleteLink"), typeof(_deleteLink));
         	}
         
         	 _deleteLinkFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setLinkFlags(IntPtr thisPtr, uint flags);
         private static _setLinkFlags _setLinkFlagsFunc;
         internal static void setLinkFlags(IntPtr thisPtr, uint flags)
         {
         	if (_setLinkFlagsFunc == null)
         	{
         		_setLinkFlagsFunc =
         			(_setLinkFlags)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiNavEditorCtrl_setLinkFlags"), typeof(_setLinkFlags));
         	}
         
         	 _setLinkFlagsFunc(thisPtr, flags);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _buildTile(IntPtr thisPtr);
         private static _buildTile _buildTileFunc;
         internal static void buildTile(IntPtr thisPtr)
         {
         	if (_buildTileFunc == null)
         	{
         		_buildTileFunc =
         			(_buildTile)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiNavEditorCtrl_buildTile"), typeof(_buildTile));
         	}
         
         	 _buildTileFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _spawnPlayer(IntPtr thisPtr);
         private static _spawnPlayer _spawnPlayerFunc;
         internal static void spawnPlayer(IntPtr thisPtr)
         {
         	if (_spawnPlayerFunc == null)
         	{
         		_spawnPlayerFunc =
         			(_spawnPlayer)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiNavEditorCtrl_spawnPlayer"), typeof(_spawnPlayer));
         	}
         
         	 _spawnPlayerFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getMode(IntPtr thisPtr, int argc, string[] argv);
         private static _getMode _getModeFunc;
         internal static IntPtr getMode(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_getModeFunc == null)
         	{
         		_getModeFunc =
         			(_getMode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiNavEditorCtrl_getMode"), typeof(_getMode));
         	}
         
         	return  _getModeFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMode(IntPtr thisPtr, int argc, string[] argv);
         private static _setMode _setModeFunc;
         internal static void setMode(IntPtr thisPtr, int argc, string[] argv)
         {
         	if (_setModeFunc == null)
         	{
         		_setModeFunc =
         			(_setMode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiNavEditorCtrl_setMode"), typeof(_setMode));
         	}
         
         	 _setModeFunc(thisPtr, argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiNavEditorCtrl_create();
         private static _GuiNavEditorCtrl_create _GuiNavEditorCtrl_createFunc;
         internal static IntPtr GuiNavEditorCtrl_create()
         {
         	if (_GuiNavEditorCtrl_createFunc == null)
         	{
         		_GuiNavEditorCtrl_createFunc =
         			(_GuiNavEditorCtrl_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiNavEditorCtrl_create"), typeof(_GuiNavEditorCtrl_create));
         	}
         
         	return  _GuiNavEditorCtrl_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void selectMesh(int id)
         {
            InternalUnsafeMethods.selectMesh(ObjectPtr, id);
         }
      
         public virtual int getMesh()
         {
            return InternalUnsafeMethods.getMesh(ObjectPtr);
         }
      
         public virtual int getPlayer()
         {
            return InternalUnsafeMethods.getPlayer(ObjectPtr);
         }
      
         public virtual void deselect()
         {
            InternalUnsafeMethods.deselect(ObjectPtr);
         }
      
         public virtual void deleteLink()
         {
            InternalUnsafeMethods.deleteLink(ObjectPtr);
         }
      
         public virtual void setLinkFlags(uint flags)
         {
            InternalUnsafeMethods.setLinkFlags(ObjectPtr, flags);
         }
      
         public virtual void buildTile()
         {
            InternalUnsafeMethods.buildTile(ObjectPtr);
         }
      
         public virtual void spawnPlayer()
         {
            InternalUnsafeMethods.spawnPlayer(ObjectPtr);
         }
      
         public virtual string getMode()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  return Marshal.PtrToStringUni(InternalUnsafeMethods.getMode(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray()));
         }
      
         public virtual void setMode()
         {
            List<string> tmp_arg_list = new List<string> {"",""};
                  InternalUnsafeMethods.setMode(ObjectPtr, tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
      
      #endregion


      #region Properties
      
      
         public bool IsDirty
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("IsDirty")); }
         	set { setFieldValue("IsDirty", value ? "1" : "0"); }
         }
      
         public string SpawnClass
         {
         	get { return getFieldValue("SpawnClass"); }
         	set { setFieldValue("SpawnClass", value); }
         }
      
         public string SpawnDatablock
         {
         	get { return getFieldValue("SpawnDatablock"); }
         	set { setFieldValue("SpawnDatablock", value); }
         }
      
      
      #endregion

	}
}