using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Engine;
using Torque3D.Util;

namespace Torque3D
{
	public unsafe class GuiControlProfile : SimObject
	{
		public GuiControlProfile(bool pRegister = false)
			: base(pRegister)
		{
		}

		public GuiControlProfile(string pName, bool pRegister = false)
			: this(false)
		{
			Name = pName;
			if (pRegister) registerObject();
		}

		public GuiControlProfile(string pName, string pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(Sim.FindObject<SimObject>(pParent));
		}

		public GuiControlProfile(string pName, SimObject pParent, bool pRegister = false)
         : this(pName, pRegister)
		{
			CopyFrom(pParent);
		}

		public GuiControlProfile(SimObject pObj) : base(pObj)
		{
		}

		public GuiControlProfile(IntPtr pObjPtr) : base(pObjPtr)
		{
		}

		protected override void CreateSimObjectPtr()
		{
			ObjectPtr = InternalUnsafeMethods.GuiControlProfile_create();
		}

      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getStringWidth(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string _string);
         private static _getStringWidth _getStringWidthFunc;
         internal static int getStringWidth(IntPtr thisPtr, [MarshalAs(UnmanagedType.LPWStr)]string _string)
         {
         	if (_getStringWidthFunc == null)
         	{
         		_getStringWidthFunc =
         			(_getStringWidth)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fnGuiControlProfile_getStringWidth"), typeof(_getStringWidth));
         	}
         
         	return  _getStringWidthFunc(thisPtr, _string);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _GuiControlProfile_create();
         private static _GuiControlProfile_create _GuiControlProfile_createFunc;
         internal static IntPtr GuiControlProfile_create()
         {
         	if (_GuiControlProfile_createFunc == null)
         	{
         		_GuiControlProfile_createFunc =
         			(_GuiControlProfile_create)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GuiControlProfile_create"), typeof(_GuiControlProfile_create));
         	}
         
         	return  _GuiControlProfile_createFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
      
         public virtual int getStringWidth(string _string)
         {
            return InternalUnsafeMethods.getStringWidth(ObjectPtr, _string);
         }
      
      
      #endregion


      #region Properties
      
      
         public bool Tab
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Tab")); }
         	set { setFieldValue("Tab", value ? "1" : "0"); }
         }
      
         public bool CanKeyFocus
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("CanKeyFocus")); }
         	set { setFieldValue("CanKeyFocus", value ? "1" : "0"); }
         }
      
         public bool MouseOverSelected
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("MouseOverSelected")); }
         	set { setFieldValue("MouseOverSelected", value ? "1" : "0"); }
         }
      
         public bool Modal
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Modal")); }
         	set { setFieldValue("Modal", value ? "1" : "0"); }
         }
      
         public bool Opaque
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("Opaque")); }
         	set { setFieldValue("Opaque", value ? "1" : "0"); }
         }
      
         public ColorI FillColor
         {
         	get { return new ColorI(getFieldValue("FillColor")); }
         	set { setFieldValue("FillColor", value.ToString()); }
         }
      
         public ColorI FillColorHL
         {
         	get { return new ColorI(getFieldValue("FillColorHL")); }
         	set { setFieldValue("FillColorHL", value.ToString()); }
         }
      
         public ColorI FillColorNA
         {
         	get { return new ColorI(getFieldValue("FillColorNA")); }
         	set { setFieldValue("FillColorNA", value.ToString()); }
         }
      
         public ColorI FillColorERR
         {
         	get { return new ColorI(getFieldValue("FillColorERR")); }
         	set { setFieldValue("FillColorERR", value.ToString()); }
         }
      
         public ColorI FillColorSEL
         {
         	get { return new ColorI(getFieldValue("FillColorSEL")); }
         	set { setFieldValue("FillColorSEL", value.ToString()); }
         }
      
         public int Border
         {
         	get { return int.Parse(getFieldValue("Border")); }
         	set { setFieldValue("Border", value.ToString()); }
         }
      
         public int BorderThickness
         {
         	get { return int.Parse(getFieldValue("BorderThickness")); }
         	set { setFieldValue("BorderThickness", value.ToString()); }
         }
      
         public ColorI BorderColor
         {
         	get { return new ColorI(getFieldValue("BorderColor")); }
         	set { setFieldValue("BorderColor", value.ToString()); }
         }
      
         public ColorI BorderColorHL
         {
         	get { return new ColorI(getFieldValue("BorderColorHL")); }
         	set { setFieldValue("BorderColorHL", value.ToString()); }
         }
      
         public ColorI BorderColorNA
         {
         	get { return new ColorI(getFieldValue("BorderColorNA")); }
         	set { setFieldValue("BorderColorNA", value.ToString()); }
         }
      
         public ColorI BevelColorHL
         {
         	get { return new ColorI(getFieldValue("BevelColorHL")); }
         	set { setFieldValue("BevelColorHL", value.ToString()); }
         }
      
         public ColorI BevelColorLL
         {
         	get { return new ColorI(getFieldValue("BevelColorLL")); }
         	set { setFieldValue("BevelColorLL", value.ToString()); }
         }
      
         public string FontType
         {
         	get { return getFieldValue("FontType"); }
         	set { setFieldValue("FontType", value); }
         }
      
         public int FontSize
         {
         	get { return int.Parse(getFieldValue("FontSize")); }
         	set { setFieldValue("FontSize", value.ToString()); }
         }
      
         public GuiFontCharset FontCharset
         {
         	get { return (GuiFontCharset)Enum.Parse(typeof(GuiFontCharset), getFieldValue("FontCharset"), true); }
         	set { setFieldValue("FontCharset", value.ToString()); }
         }
      
         public DynamicFieldVector<ColorI> FontColors
         {
         	get { return new DynamicFieldVector<ColorI>(this, "FontColors", 10, val => new ColorI(val), obj => obj.ToString()); }
         }
      
         public ColorI FontColor
         {
         	get { return new ColorI(getFieldValue("FontColor")); }
         	set { setFieldValue("FontColor", value.ToString()); }
         }
      
         public ColorI FontColorHL
         {
         	get { return new ColorI(getFieldValue("FontColorHL")); }
         	set { setFieldValue("FontColorHL", value.ToString()); }
         }
      
         public ColorI FontColorNA
         {
         	get { return new ColorI(getFieldValue("FontColorNA")); }
         	set { setFieldValue("FontColorNA", value.ToString()); }
         }
      
         public ColorI FontColorSEL
         {
         	get { return new ColorI(getFieldValue("FontColorSEL")); }
         	set { setFieldValue("FontColorSEL", value.ToString()); }
         }
      
         public ColorI FontColorLink
         {
         	get { return new ColorI(getFieldValue("FontColorLink")); }
         	set { setFieldValue("FontColorLink", value.ToString()); }
         }
      
         public ColorI FontColorLinkHL
         {
         	get { return new ColorI(getFieldValue("FontColorLinkHL")); }
         	set { setFieldValue("FontColorLinkHL", value.ToString()); }
         }
      
         public GuiAlignmentType Justify
         {
         	get { return (GuiAlignmentType)Enum.Parse(typeof(GuiAlignmentType), getFieldValue("Justify"), true); }
         	set { setFieldValue("Justify", value.ToString()); }
         }
      
         public Point2I TextOffset
         {
         	get { return new Point2I(getFieldValue("TextOffset")); }
         	set { setFieldValue("TextOffset", value.ToString()); }
         }
      
         public bool AutoSizeWidth
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AutoSizeWidth")); }
         	set { setFieldValue("AutoSizeWidth", value ? "1" : "0"); }
         }
      
         public bool AutoSizeHeight
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("AutoSizeHeight")); }
         	set { setFieldValue("AutoSizeHeight", value ? "1" : "0"); }
         }
      
         public bool ReturnTab
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("ReturnTab")); }
         	set { setFieldValue("ReturnTab", value ? "1" : "0"); }
         }
      
         public bool NumbersOnly
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("NumbersOnly")); }
         	set { setFieldValue("NumbersOnly", value ? "1" : "0"); }
         }
      
         public ColorI CursorColor
         {
         	get { return new ColorI(getFieldValue("CursorColor")); }
         	set { setFieldValue("CursorColor", value.ToString()); }
         }
      
         public string Bitmap
         {
         	get { return getFieldValue("Bitmap"); }
         	set { setFieldValue("Bitmap", value); }
         }
      
         public bool HasBitmapArray
         {
         	get { return GenericMarshal.StringToBool(getFieldValue("HasBitmapArray")); }
         	set { setFieldValue("HasBitmapArray", value ? "1" : "0"); }
         }
      
         public SFXTrack SoundButtonDown
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("SoundButtonDown")); }
         	set { setFieldValue("SoundButtonDown", value.getId().ToString()); }
         }
      
         public SFXTrack SoundButtonOver
         {
         	get { return Sim.FindObject<SFXTrack>(getFieldValue("SoundButtonOver")); }
         	set { setFieldValue("SoundButtonOver", value.getId().ToString()); }
         }
      
         public string ProfileForChildren
         {
         	get { return getFieldValue("ProfileForChildren"); }
         	set { setFieldValue("ProfileForChildren", value); }
         }
      
         public string Category
         {
         	get { return getFieldValue("Category"); }
         	set { setFieldValue("Category", value); }
         }
      
      
      #endregion

	}
}