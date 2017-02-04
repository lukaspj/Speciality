namespace Torque3D.Util
{
   public enum GFXFormat
   {
      // when adding formats make sure to place
      // them in the correct group!
      //
      // if displacing the first entry in the group
      // make sure to update the GFXFormat_xBIT entries!

      // 8 bit texture formats...
      GFXFormatA8 = 0,// first in group...
      GFXFormatL8,
      GFXFormatA4L4,

      // 16 bit texture formats...
      GFXFormatR5G6B5,// first in group...
      GFXFormatR5G5B5A1,
      GFXFormatR5G5B5X1,
      GFXFormatA8L8,
      GFXFormatL16,
      GFXFormatR16F,
      GFXFormatD16,

      // 24 bit texture formats...
      GFXFormatR8G8B8,// first in group...

      // 32 bit texture formats...
      GFXFormatR8G8B8A8,// first in group...
      GFXFormatR8G8B8X8,
      GFXFormatB8G8R8A8,
      GFXFormatR32F,
      GFXFormatR16G16,
      GFXFormatR16G16F,
      GFXFormatR10G10B10A2,
      GFXFormatD32,
      GFXFormatD24X8,
      GFXFormatD24S8,
      GFXFormatD24FS8,

      // sRGB formats
      GFXFormatR8G8B8A8_SRGB,

      // Guaranteed RGBA8 (for apis which really dont like bgr)
      GFXFormatR8G8B8A8_LINEAR_FORCE,

      // 64 bit texture formats...
      GFXFormatR16G16B16A16,// first in group...
      GFXFormatR16G16B16A16F,

      // 128 bit texture formats...
      GFXFormatR32G32B32A32F,// first in group...

      // unknown size...
      GFXFormatDXT1,// first in group...
      GFXFormatDXT2,
      GFXFormatDXT3,
      GFXFormatDXT4,
      GFXFormatDXT5,

      GFXFormat_8BIT = GFXFormatA8,
      GFXFormat_16BIT = GFXFormatR5G6B5,
      GFXFormat_24BIT = GFXFormatR8G8B8,
      GFXFormat_32BIT = GFXFormatR8G8B8A8,
      GFXFormat_64BIT = GFXFormatR16G16B16A16,
      GFXFormat_128BIT = GFXFormatR32G32B32A32F,
      GFXFormatUNKNOWNSIZE = GFXFormatDXT1
   }

   public enum GFXAdapterType
   {
      OpenGL,
      Direct3D11,
      Direct3D9,
      NullDevice,
      Direct3D_360
   }

   public enum GFXBlend
   {
      GFXBlendZero,
      GFXBlendOne,
      GFXBlendSrcColor,
      GFXBlendInvSrcColor,
      GFXBlendSrcAlpha,
      GFXBlendInvSrcAlpha,
      GFXBlendDestAlpha,
      GFXBlendInvDestAlpha,
      GFXBlendDestColor,
      GFXBlendInvDestColor,
      GFXBlendSrcAlphaSat
   }

   public enum GFXCmpFunc
   {
      GFXCmpNever,
      GFXCmpLess,
      GFXCmpEqual,
      GFXCmpLessEqual,
      GFXCmpGreater,
      GFXCmpNotEqual,
      GFXCmpGreaterEqual,
      GFXCmpAlways
   }

   public enum GFXTextureAddressMode
   {
      GFXAddressWrap,
      GFXAddressMirror,
      GFXAddressClamp,
      GFXAddressBorder,
      GFXAddressMirrorOnce
   }

   public enum GFXTextureFilterType
   {
      GFXTextureFilterNone,
      GFXTextureFilterPoint,
      GFXTextureFilterLinear,
      GFXTextureFilterAnisotropic,
      GFXTextureFilterPyramidalQuad,
      GFXTextureFilterGaussianQuad
   }

   public enum GFXTextureOp
   {
      GFXTOPDisable,
      GFXTOPSelectARG1,
      GFXTOPSelectARG2,
      GFXTOPModulate,
      GFXTOPModulate2X,
      GFXTOPModulate4X,
      GFXTOPAdd,
      GFXTOPAddSigned,
      GFXTOPAddSigned2X,
      GFXTOPSubtract,
      GFXTOPAddSmooth,
      GFXTOPBlendDiffuseAlpha,
      GFXTOPBlendTextureAlpha,
      GFXTOPBlendFactorAlpha,
      GFXTOPBlendTectureAlphaPM,
      GFXTOPBlendCurrentAlpha,
      GFXTOPPreModulate,
      GFXTOPModulateAlphaAddColor,
      GFXTOPModulateColorAddAlpha,
      GFXTOPModulateInvAlphaAddColor,
      GFXTOPModulateInvColorAddAlpha,
      GFXTOPBumpEnvMap,
      GFXTOPBumpEnvMapLuminance,
      GFXTOPDotProduct3,
      GFXTOPTopLerp
   }

   public enum GFXTextureArgument
   {
      GFXTADiffuse,
      GFXTACurrent,
      GFXTATexture,
      GFXTAFactor,
      GFXTASpecular,
      GFXTATemp,
      GFXTAConstant,
      GFXTAOneMinus,
      GFXTAAlphaReplicate
   }

   public enum GFXTextureTransformFlags
   {
      GFXTTFFDisable,
      GFXTTFFCoord1D,
      GFXTTFFCoord2D,
      GFXTTFFCoord3D,
      GFXTTFFCoord4D,
      GFXTTFFProjected
   }

   public enum GFXCullMode
   {
      GFXCullNone,
      GFXCullCW,
      GFXCullCCW
   }

   public enum GFXStencilOp
   {
      GFXStencilOpKeep = 0,
      GFXStencilOpZero,
      GFXStencilOpReplace,
      GFXStencilOpIncrSat,
      GFXStencilOpDecrSat,
      GFXStencilOpInvert,
      GFXStencilOpIncr,
      GFXStencilOpDecr,
   }

   public enum GFXBlendOp
   {
      GFXBlendOpAdd = 0,
      GFXBlendOpSubtract,
      GFXBlendOpRevSubtract,
      GFXBlendOpMin,
      GFXBlendOpMax
   }
}
