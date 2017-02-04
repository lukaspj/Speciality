using Torque3D;
using Torque3D.Util;

namespace Game.Core.GfxData
{
   class CommonMaterialData
   {
      public static GFXSamplerStateData SamplerWrapPoint { get; set; }

      public static GFXSamplerStateData SamplerWrapLinear { get; set; }

      public static GFXSamplerStateData SamplerClampPoint { get; set; }

      public static GFXSamplerStateData SamplerClampLinear { get; set; }

      public static void Init()
      {
         //-----------------------------------------------------------------------------
         // Anim flag settings - must match material.h
         // These cannot be enumed through script becuase it cannot
         // handle the "|" operation for combining them together
         // ie. Scroll | Wave does not work.
         //-----------------------------------------------------------------------------
         Globals.SetInt("scroll", 1);
         Globals.SetInt("rotate", 2);
         Globals.SetInt("wave", 4);
         Globals.SetInt("scale", 8);
         Globals.SetInt("sequence", 16);

         // Common stateblock definitions
         SamplerClampLinear = new GFXSamplerStateData("SamplerClampLinear")
         {
            TextureColorOp = GFXTextureOp.GFXTOPModulate,
            AddressModeU = GFXTextureAddressMode.GFXAddressClamp,
            AddressModeV = GFXTextureAddressMode.GFXAddressClamp,
            AddressModeW = GFXTextureAddressMode.GFXAddressClamp,
            MagFilter = GFXTextureFilterType.GFXTextureFilterLinear,
            MinFilter = GFXTextureFilterType.GFXTextureFilterLinear,
            MipFilter = GFXTextureFilterType.GFXTextureFilterLinear
         };
         SamplerClampLinear.registerSingleton();

         SamplerClampPoint = new GFXSamplerStateData("SamplerClampPoint")
         {
            TextureColorOp = GFXTextureOp.GFXTOPModulate,
            AddressModeU = GFXTextureAddressMode.GFXAddressClamp,
            AddressModeV = GFXTextureAddressMode.GFXAddressClamp,
            AddressModeW = GFXTextureAddressMode.GFXAddressClamp,
            MagFilter = GFXTextureFilterType.GFXTextureFilterPoint,
            MinFilter = GFXTextureFilterType.GFXTextureFilterPoint,
            MipFilter = GFXTextureFilterType.GFXTextureFilterPoint
         };
         SamplerClampPoint.registerSingleton();

         SamplerWrapLinear = new GFXSamplerStateData("SamplerWrapLinear")
         {
            TextureColorOp = GFXTextureOp.GFXTOPModulate,
            AddressModeU = GFXTextureAddressMode.GFXAddressWrap,
            AddressModeV = GFXTextureAddressMode.GFXAddressWrap,
            AddressModeW = GFXTextureAddressMode.GFXAddressWrap,
            MagFilter = GFXTextureFilterType.GFXTextureFilterLinear,
            MinFilter = GFXTextureFilterType.GFXTextureFilterLinear,
            MipFilter = GFXTextureFilterType.GFXTextureFilterLinear
         };
         SamplerWrapLinear.registerSingleton();

         SamplerWrapPoint = new GFXSamplerStateData("SamplerWrapPoint")
         {
            TextureColorOp = GFXTextureOp.GFXTOPModulate,
            AddressModeU = GFXTextureAddressMode.GFXAddressWrap,
            AddressModeV = GFXTextureAddressMode.GFXAddressWrap,
            AddressModeW = GFXTextureAddressMode.GFXAddressWrap,
            MagFilter = GFXTextureFilterType.GFXTextureFilterPoint,
            MinFilter = GFXTextureFilterType.GFXTextureFilterPoint,
            MipFilter = GFXTextureFilterType.GFXTextureFilterPoint
         };
         SamplerWrapPoint.registerSingleton();
      }
   }
}