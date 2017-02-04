using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiMenuBar : GuiTickCtrl
	{
		public GuiMenuBar(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiMenuBar(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiMenuBar(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiMenuBar(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiMenuBar(SimObject pObj) : base(pObj)
		{
		}

		public GuiMenuBar(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiMenuBar_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearMenus(IntPtr thisPtr);
         private static _clearMenus _clearMenusFunc;
         internal static void clearMenus(IntPtr thisPtr)
         {
         	if (_clearMenusFunc == null)
         	{
         		_clearMenusFunc =
         			(_clearMenus)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMenuBar_clearMenus"), typeof(_clearMenus));
         	}
         
         	 _clearMenusFunc(thisPtr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMenuMargins(IntPtr thisPtr, int horizontalMargin, int verticalMargin, int bitmapToTextSpacing);
         private static _setMenuMargins _setMenuMarginsFunc;
         internal static void setMenuMargins(IntPtr thisPtr, int horizontalMargin, int verticalMargin, int bitmapToTextSpacing)
         {
         	if (_setMenuMarginsFunc == null)
         	{
         		_setMenuMarginsFunc =
         			(_setMenuMargins)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMenuBar_setMenuMargins"), typeof(_setMenuMargins));
         	}
         
         	 _setMenuMarginsFunc(thisPtr, horizontalMargin, verticalMargin, bitmapToTextSpacing);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addMenu(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuText, int menuId);
         private static _addMenu _addMenuFunc;
         internal static void addMenu(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuText, int menuId)
         {
         	if (_addMenuFunc == null)
         	{
         		_addMenuFunc =
         			(_addMenu)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMenuBar_addMenu"), typeof(_addMenu));
         	}
         
         	 _addMenuFunc(thisPtr, menuText, menuId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addMenuItem(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string targetMenu, [MarshalAs(UnmanagedType.LPWStr)]string menuItemText, int menuItemId, [MarshalAs(UnmanagedType.LPWStr)]string accelerator, int checkGroup, [MarshalAs(UnmanagedType.LPWStr)]string cmd);
         private static _addMenuItem _addMenuItemFunc;
         internal static void addMenuItem(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string targetMenu, [MarshalAs(UnmanagedType.LPWStr)]string menuItemText, int menuItemId, [MarshalAs(UnmanagedType.LPWStr)]string accelerator, int checkGroup, [MarshalAs(UnmanagedType.LPWStr)]string cmd)
         {
         	if (_addMenuItemFunc == null)
         	{
         		_addMenuItemFunc =
         			(_addMenuItem)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMenuBar_addMenuItem"), typeof(_addMenuItem));
         	}
         
         	 _addMenuItemFunc(thisPtr, targetMenu, menuItemText, menuItemId, accelerator, checkGroup, cmd);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMenuItemEnable(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget, [MarshalAs(UnmanagedType.LPWStr)]string menuItemTarget, bool enabled);
         private static _setMenuItemEnable _setMenuItemEnableFunc;
         internal static void setMenuItemEnable(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget, [MarshalAs(UnmanagedType.LPWStr)]string menuItemTarget, bool enabled)
         {
         	if (_setMenuItemEnableFunc == null)
         	{
         		_setMenuItemEnableFunc =
         			(_setMenuItemEnable)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMenuBar_setMenuItemEnable"), typeof(_setMenuItemEnable));
         	}
         
         	 _setMenuItemEnableFunc(thisPtr, menuTarget, menuItemTarget, enabled);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setCheckmarkBitmapIndex(IntPtr thisPtr, int bitmapindex);
         private static _setCheckmarkBitmapIndex _setCheckmarkBitmapIndexFunc;
         internal static void setCheckmarkBitmapIndex(IntPtr thisPtr, int bitmapindex)
         {
         	if (_setCheckmarkBitmapIndexFunc == null)
         	{
         		_setCheckmarkBitmapIndexFunc =
         			(_setCheckmarkBitmapIndex)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMenuBar_setCheckmarkBitmapIndex"), typeof(_setCheckmarkBitmapIndex));
         	}
         
         	 _setCheckmarkBitmapIndexFunc(thisPtr, bitmapindex);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMenuItemChecked(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget, [MarshalAs(UnmanagedType.LPWStr)]string menuItemTarget, bool _checked);
         private static _setMenuItemChecked _setMenuItemCheckedFunc;
         internal static void setMenuItemChecked(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget, [MarshalAs(UnmanagedType.LPWStr)]string menuItemTarget, bool _checked)
         {
         	if (_setMenuItemCheckedFunc == null)
         	{
         		_setMenuItemCheckedFunc =
         			(_setMenuItemChecked)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMenuBar_setMenuItemChecked"), typeof(_setMenuItemChecked));
         	}
         
         	 _setMenuItemCheckedFunc(thisPtr, menuTarget, menuItemTarget, _checked);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMenuText(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget, [MarshalAs(UnmanagedType.LPWStr)]string newMenuText);
         private static _setMenuText _setMenuTextFunc;
         internal static void setMenuText(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget, [MarshalAs(UnmanagedType.LPWStr)]string newMenuText)
         {
         	if (_setMenuTextFunc == null)
         	{
         		_setMenuTextFunc =
         			(_setMenuText)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMenuBar_setMenuText"), typeof(_setMenuText));
         	}
         
         	 _setMenuTextFunc(thisPtr, menuTarget, newMenuText);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMenuBitmapIndex(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget, int bitmapindex, bool bitmaponly, bool drawborder);
         private static _setMenuBitmapIndex _setMenuBitmapIndexFunc;
         internal static void setMenuBitmapIndex(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget, int bitmapindex, bool bitmaponly, bool drawborder)
         {
         	if (_setMenuBitmapIndexFunc == null)
         	{
         		_setMenuBitmapIndexFunc =
         			(_setMenuBitmapIndex)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMenuBar_setMenuBitmapIndex"), typeof(_setMenuBitmapIndex));
         	}
         
         	 _setMenuBitmapIndexFunc(thisPtr, menuTarget, bitmapindex, bitmaponly, drawborder);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMenuVisible(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget, bool visible);
         private static _setMenuVisible _setMenuVisibleFunc;
         internal static void setMenuVisible(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget, bool visible)
         {
         	if (_setMenuVisibleFunc == null)
         	{
         		_setMenuVisibleFunc =
         			(_setMenuVisible)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMenuBar_setMenuVisible"), typeof(_setMenuVisible));
         	}
         
         	 _setMenuVisibleFunc(thisPtr, menuTarget, visible);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMenuItemText(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget, [MarshalAs(UnmanagedType.LPWStr)]string menuItemTarget, [MarshalAs(UnmanagedType.LPWStr)]string newMenuItemText);
         private static _setMenuItemText _setMenuItemTextFunc;
         internal static void setMenuItemText(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget, [MarshalAs(UnmanagedType.LPWStr)]string menuItemTarget, [MarshalAs(UnmanagedType.LPWStr)]string newMenuItemText)
         {
         	if (_setMenuItemTextFunc == null)
         	{
         		_setMenuItemTextFunc =
         			(_setMenuItemText)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMenuBar_setMenuItemText"), typeof(_setMenuItemText));
         	}
         
         	 _setMenuItemTextFunc(thisPtr, menuTarget, menuItemTarget, newMenuItemText);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMenuItemVisible(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget, [MarshalAs(UnmanagedType.LPWStr)]string menuItemTarget, bool isVisible);
         private static _setMenuItemVisible _setMenuItemVisibleFunc;
         internal static void setMenuItemVisible(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget, [MarshalAs(UnmanagedType.LPWStr)]string menuItemTarget, bool isVisible)
         {
         	if (_setMenuItemVisibleFunc == null)
         	{
         		_setMenuItemVisibleFunc =
         			(_setMenuItemVisible)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMenuBar_setMenuItemVisible"), typeof(_setMenuItemVisible));
         	}
         
         	 _setMenuItemVisibleFunc(thisPtr, menuTarget, menuItemTarget, isVisible);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMenuItemBitmap(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget, [MarshalAs(UnmanagedType.LPWStr)]string menuItemTarget, int bitmapIndex);
         private static _setMenuItemBitmap _setMenuItemBitmapFunc;
         internal static void setMenuItemBitmap(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget, [MarshalAs(UnmanagedType.LPWStr)]string menuItemTarget, int bitmapIndex)
         {
         	if (_setMenuItemBitmapFunc == null)
         	{
         		_setMenuItemBitmapFunc =
         			(_setMenuItemBitmap)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMenuBar_setMenuItemBitmap"), typeof(_setMenuItemBitmap));
         	}
         
         	 _setMenuItemBitmapFunc(thisPtr, menuTarget, menuItemTarget, bitmapIndex);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeMenuItem(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget, [MarshalAs(UnmanagedType.LPWStr)]string menuItemTarget);
         private static _removeMenuItem _removeMenuItemFunc;
         internal static void removeMenuItem(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget, [MarshalAs(UnmanagedType.LPWStr)]string menuItemTarget)
         {
         	if (_removeMenuItemFunc == null)
         	{
         		_removeMenuItemFunc =
         			(_removeMenuItem)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMenuBar_removeMenuItem"), typeof(_removeMenuItem));
         	}
         
         	 _removeMenuItemFunc(thisPtr, menuTarget, menuItemTarget);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearMenuItems(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget);
         private static _clearMenuItems _clearMenuItemsFunc;
         internal static void clearMenuItems(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget)
         {
         	if (_clearMenuItemsFunc == null)
         	{
         		_clearMenuItemsFunc =
         			(_clearMenuItems)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMenuBar_clearMenuItems"), typeof(_clearMenuItems));
         	}
         
         	 _clearMenuItemsFunc(thisPtr, menuTarget);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeMenu(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget);
         private static _removeMenu _removeMenuFunc;
         internal static void removeMenu(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget)
         {
         	if (_removeMenuFunc == null)
         	{
         		_removeMenuFunc =
         			(_removeMenu)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMenuBar_removeMenu"), typeof(_removeMenu));
         	}
         
         	 _removeMenuFunc(thisPtr, menuTarget);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMenuItemSubmenuState(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget, [MarshalAs(UnmanagedType.LPWStr)]string menuItem, bool isSubmenu);
         private static _setMenuItemSubmenuState _setMenuItemSubmenuStateFunc;
         internal static void setMenuItemSubmenuState(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget, [MarshalAs(UnmanagedType.LPWStr)]string menuItem, bool isSubmenu)
         {
         	if (_setMenuItemSubmenuStateFunc == null)
         	{
         		_setMenuItemSubmenuStateFunc =
         			(_setMenuItemSubmenuState)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMenuBar_setMenuItemSubmenuState"), typeof(_setMenuItemSubmenuState));
         	}
         
         	 _setMenuItemSubmenuStateFunc(thisPtr, menuTarget, menuItem, isSubmenu);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addSubmenuItem(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget, [MarshalAs(UnmanagedType.LPWStr)]string menuItem, [MarshalAs(UnmanagedType.LPWStr)]string submenuItemText, int submenuItemId, [MarshalAs(UnmanagedType.LPWStr)]string accelerator, int checkGroup);
         private static _addSubmenuItem _addSubmenuItemFunc;
         internal static void addSubmenuItem(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget, [MarshalAs(UnmanagedType.LPWStr)]string menuItem, [MarshalAs(UnmanagedType.LPWStr)]string submenuItemText, int submenuItemId, [MarshalAs(UnmanagedType.LPWStr)]string accelerator, int checkGroup)
         {
         	if (_addSubmenuItemFunc == null)
         	{
         		_addSubmenuItemFunc =
         			(_addSubmenuItem)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMenuBar_addSubmenuItem"), typeof(_addSubmenuItem));
         	}
         
         	 _addSubmenuItemFunc(thisPtr, menuTarget, menuItem, submenuItemText, submenuItemId, accelerator, checkGroup);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearSubmenuItems(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget, [MarshalAs(UnmanagedType.LPWStr)]string menuItem);
         private static _clearSubmenuItems _clearSubmenuItemsFunc;
         internal static void clearSubmenuItems(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget, [MarshalAs(UnmanagedType.LPWStr)]string menuItem)
         {
         	if (_clearSubmenuItemsFunc == null)
         	{
         		_clearSubmenuItemsFunc =
         			(_clearSubmenuItems)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMenuBar_clearSubmenuItems"), typeof(_clearSubmenuItems));
         	}
         
         	 _clearSubmenuItemsFunc(thisPtr, menuTarget, menuItem);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setSubmenuItemChecked(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget, [MarshalAs(UnmanagedType.LPWStr)]string menuItemTarget, [MarshalAs(UnmanagedType.LPWStr)]string submenuItemText, bool _checked);
         private static _setSubmenuItemChecked _setSubmenuItemCheckedFunc;
         internal static void setSubmenuItemChecked(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string menuTarget, [MarshalAs(UnmanagedType.LPWStr)]string menuItemTarget, [MarshalAs(UnmanagedType.LPWStr)]string submenuItemText, bool _checked)
         {
         	if (_setSubmenuItemCheckedFunc == null)
         	{
         		_setSubmenuItemCheckedFunc =
         			(_setSubmenuItemChecked)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiMenuBar_setSubmenuItemChecked"), typeof(_setSubmenuItemChecked));
         	}
         
         	 _setSubmenuItemCheckedFunc(thisPtr, menuTarget, menuItemTarget, submenuItemText, _checked);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiMenuBar_create();
         private static _GuiMenuBar_create _GuiMenuBar_createFunc;
         internal static IntPtr GuiMenuBar_create()
         {
         	if (_GuiMenuBar_createFunc == null)
         	{
         		_GuiMenuBar_createFunc =
         			(_GuiMenuBar_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiMenuBar_create"), typeof(_GuiMenuBar_create));
         	}
         
         	return  _GuiMenuBar_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual void clearMenus()
         {
            InternalUnsafeMethods.clearMenus(ObjectPtr);
         }
      
         public virtual void setMenuMargins(int horizontalMargin, int verticalMargin, int bitmapToTextSpacing)
         {
            InternalUnsafeMethods.setMenuMargins(ObjectPtr, horizontalMargin, verticalMargin, bitmapToTextSpacing);
         }
      
         public virtual void addMenu(string menuText, int menuId)
         {
            InternalUnsafeMethods.addMenu(ObjectPtr, menuText, menuId);
         }
      
         public virtual void addMenuItem(string targetMenu = "", string menuItemText = "", int menuItemId = 0, string accelerator = null, int checkGroup = -1, string cmd = "")
         {
            InternalUnsafeMethods.addMenuItem(ObjectPtr, targetMenu, menuItemText, menuItemId, accelerator, checkGroup, cmd);
         }
      
         public virtual void setMenuItemEnable(string menuTarget, string menuItemTarget, bool enabled)
         {
            InternalUnsafeMethods.setMenuItemEnable(ObjectPtr, menuTarget, menuItemTarget, enabled);
         }
      
         public virtual void setCheckmarkBitmapIndex(int bitmapindex)
         {
            InternalUnsafeMethods.setCheckmarkBitmapIndex(ObjectPtr, bitmapindex);
         }
      
         public virtual void setMenuItemChecked(string menuTarget, string menuItemTarget, bool _checked)
         {
            InternalUnsafeMethods.setMenuItemChecked(ObjectPtr, menuTarget, menuItemTarget, _checked);
         }
      
         public virtual void setMenuText(string menuTarget, string newMenuText)
         {
            InternalUnsafeMethods.setMenuText(ObjectPtr, menuTarget, newMenuText);
         }
      
         public virtual void setMenuBitmapIndex(string menuTarget, int bitmapindex, bool bitmaponly, bool drawborder)
         {
            InternalUnsafeMethods.setMenuBitmapIndex(ObjectPtr, menuTarget, bitmapindex, bitmaponly, drawborder);
         }
      
         public virtual void setMenuVisible(string menuTarget, bool visible)
         {
            InternalUnsafeMethods.setMenuVisible(ObjectPtr, menuTarget, visible);
         }
      
         public virtual void setMenuItemText(string menuTarget, string menuItemTarget, string newMenuItemText)
         {
            InternalUnsafeMethods.setMenuItemText(ObjectPtr, menuTarget, menuItemTarget, newMenuItemText);
         }
      
         public virtual void setMenuItemVisible(string menuTarget, string menuItemTarget, bool isVisible)
         {
            InternalUnsafeMethods.setMenuItemVisible(ObjectPtr, menuTarget, menuItemTarget, isVisible);
         }
      
         public virtual void setMenuItemBitmap(string menuTarget, string menuItemTarget, int bitmapIndex)
         {
            InternalUnsafeMethods.setMenuItemBitmap(ObjectPtr, menuTarget, menuItemTarget, bitmapIndex);
         }
      
         public virtual void removeMenuItem(string menuTarget, string menuItemTarget)
         {
            InternalUnsafeMethods.removeMenuItem(ObjectPtr, menuTarget, menuItemTarget);
         }
      
         public virtual void clearMenuItems(string menuTarget)
         {
            InternalUnsafeMethods.clearMenuItems(ObjectPtr, menuTarget);
         }
      
         public virtual void removeMenu(string menuTarget)
         {
            InternalUnsafeMethods.removeMenu(ObjectPtr, menuTarget);
         }
      
         public virtual void setMenuItemSubmenuState(string menuTarget, string menuItem, bool isSubmenu)
         {
            InternalUnsafeMethods.setMenuItemSubmenuState(ObjectPtr, menuTarget, menuItem, isSubmenu);
         }
      
         public virtual void addSubmenuItem(string menuTarget, string menuItem, string submenuItemText, int submenuItemId, string accelerator, int checkGroup)
         {
            InternalUnsafeMethods.addSubmenuItem(ObjectPtr, menuTarget, menuItem, submenuItemText, submenuItemId, accelerator, checkGroup);
         }
      
         public virtual void clearSubmenuItems(string menuTarget, string menuItem)
         {
            InternalUnsafeMethods.clearSubmenuItems(ObjectPtr, menuTarget, menuItem);
         }
      
         public virtual void setSubmenuItemChecked(string menuTarget, string menuItemTarget, string submenuItemText, bool _checked)
         {
            InternalUnsafeMethods.setSubmenuItemChecked(ObjectPtr, menuTarget, menuItemTarget, submenuItemText, _checked);
         }
      
      
      #endregion


      #region Properties
      
      
         public int Padding
         {
         	get { return int.Parse(getFieldValue("Padding")); }
         	set { setFieldValue("Padding", value.ToString()); }
         }
      
      
      #endregion

	}
}