using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torque3D.Engine.Util.Enums
{
   [Flags]
   public enum ObjectTypes
   {
      /// Default value for type masks.
      DefaultObjectType = 0,

      /// @}

      /// @name Basic Engine Types
      /// @{

      /// Any kind of SceneObject that is not supposed to change transforms
      /// except during editing (or not at all).
      StaticObjectType =  1,

      /// Environment objects such as clouds, skies, forests, etc.
      EnvironmentObjectType = 1 << 1,

      /// A terrain object.
      /// @see TerrainBlock
      TerrainObjectType = 1 << 2,

      /// An object defining a water volume.
      /// @see WaterObject
      WaterObjectType = 1 << 3,

      /// An object defining an invisible trigger volume.
      /// @see Trigger
      TriggerObjectType = 1 << 4,

      /// An object defining an invisible marker.
      /// @see MissionMarker
      MarkerObjectType = 1 << 5,

      /// A light emitter.
      /// @see LightBase
      LightObjectType = 1 << 6,

      /// An object that manages zones.  This is automatically set by
      /// SceneZoneSpaceManager when a SceneZoneSpace registers zones.  Should
      /// not be manually set.
      ///
      /// @see SceneZoneSpace
      /// @see SceneZoneSpaceManager
      ZoneObjectType = 1 << 7,

      /// Any object that defines one or more solid, renderable static geometries that
      /// should be included in collision and raycasts.
      ///
      /// Use this mask to find objects that are part of the static level geometry.
      ///
      /// @note If you set this, you will also want to set StaticObjectType.
      StaticShapeObjectType = 1 << 8,

      /// Any object that defines one or more solid, renderable dynamic geometries that
      /// should be included in collision and raycasts.
      ///
      /// Use this mask to find objects that are part of the dynamic game geometry.
      DynamicShapeObjectType = 1 << 9,

      /// @}

      /// @name Game Types
      /// @{

      /// Any GameBase-derived object.
      /// @see GameBase
      GameBaseObjectType = 1 << 10,

      /// An object that uses hifi networking.
      GameBaseHiFiObjectType = 1 << 11,

      /// Any ShapeBase-derived object.
      /// @see ShapeBase
      ShapeBaseObjectType = 1 << 12,

      /// A camera object.
      /// @see Camera
      CameraObjectType = 1 << 13,

      /// A human or AI player object.
      /// @see Player
      PlayerObjectType = 1 << 14,

      /// An item pickup.
      /// @see Item
      ItemObjectType = 1 << 15,

      /// A vehicle.
      /// @see Vehicle
      VehicleObjectType = 1 << 16,

      /// An object that blocks vehicles.
      /// @see VehicleBlocker
      VehicleBlockerObjectType = 1 << 17,

      /// A weapon projectile.
      /// @see Projectile
      ProjectileObjectType = 1 << 18,

      /// An explosion object.
      /// @see Explosion
      ExplosionObjectType = 1 << 19,

      /// A dead player.  This is dynamically set and unset.
      /// @see Player
      CorpseObjectType = 1 << 20,

      /// A debris object.
      /// @see Debris
      DebrisObjectType = 1 << 21,

      /// A volume that asserts forces on player objects.
      /// @see PhysicalZone
      PhysicalZoneObjectType = 1 << 22,

      EntityObjectType = 1 << 23,
      /// @}
   }
}
