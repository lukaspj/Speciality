using Game.Modules.ClientServer.Server;
using Torque3D;
using Torque3D.Engine;
using Torque3D.Util;
using Torque3D.Engine.Util.Enums;
using System;

namespace Game.Modules.SpectatorGameplay.scripts.server
{
   [ConsoleClass]
   internal class DefaultGame : Torque3D.LevelInfo
   {
      public int duration { get; set; }

      public Camera camera { get; set; }

      private float GameSizeX = 100;
      private float GameSizeY = 100;
      //-----------------------------------------------------------------------------
      // What kind of "player" is spawned is either controlled directly by the
      // SpawnSphere or it defaults back to the values set here. This also controls
      // which SimGroups to attempt to select the spawn sphere's from by walking down
      // the list of SpawnGroups till it finds a valid spawn object.
      // These override the values set in core/scripts/server/spawn.cs
      //-----------------------------------------------------------------------------
      public void initGameVars()
      {
         // Leave $Game::defaultPlayerClass and $Game::defaultPlayerDataBlock as empty strings ("")
         // to spawn a the $Game::defaultCameraClass as the control object.
         Globals.SetString("Game::DefaultPlayerClass", "");
         Globals.SetString("Game::DefaultPlayerDataBlock", "");
         Globals.SetString("Game::DefaultPlayerSpawnGroups", "CameraSpawnPoints PlayerSpawnPoints PlayerDropPoints");

         //-----------------------------------------------------------------------------
         // What kind of "camera" is spawned is either controlled directly by the
         // SpawnSphere or it defaults back to the values set here. This also controls
         // which SimGroups to attempt to select the spawn sphere's from by walking down
         // the list of SpawnGroups till it finds a valid spawn object.
         // These override the values set in core/scripts/server/spawn.cs
         //-----------------------------------------------------------------------------
         Globals.SetString("Game::DefaultCameraClass", "Camera");
         Globals.SetString("Game::DefaultCameraDataBlock", "Observer");
         Globals.SetString("Game::DefaultCameraSpawnGroups", "CameraSpawnPoints PlayerSpawnPoints PlayerDropPoints");

         // Global movement speed that affects all Cameras
         Globals.SetInt("Camera::MovementSpeed", 30);
      }

      //-----------------------------------------------------------------------------
      // DefaultGame manages the communication between the server's world and the
      // client's simulation. These functions are responsible for maintaining the
      // client's camera and player objects.
      //-----------------------------------------------------------------------------

      //-----------------------------------------------------------------------------
      // This is the main entry point for spawning a control object for the client.
      // The control object is the actual game object that the client is responsible
      // for controlling in the client and server simulations. We also spawn a
      // convenient camera object for use as an alternate control object. We do not
      // have to spawn this camera object in order to function in the simulation.
      //
      // Called for each client after it's finished downloading the mission and is
      // ready to start playing.
      //-----------------------------------------------------------------------------
      public void onClientEnterGame(GameConnectionToClient client)
      {
         // This function currently relies on some helper functions defined in
         // core/scripts/spawn.cs. For custom spawn behaviors one can either
         // override the properties on the SpawnSphere's or directly override the
         // functions themselves.
         
         // Find a spawn point for the camera
         var cameraSpawnPoint = pickCameraSpawnPoint(Globals.GetString("Game::DefaultCameraSpawnGroups"));
         //Point3F playerpos = PlayerSpawnPoint();
         Player player = new Player()
         {
            DataBlock = Sim.FindObject<PlayerData>("BoxPlayer"),
            Position = new Point3F(0,0,0)
         };
         player.registerObject();
         client.setControlObject(player);

         // Spawn a camera for this client using the found %spawnPoint

         //spawnCamera(cameraSpawnPoint, client);
      }
      private Point3F PlayerSpawnPoint()
      {
         Random rand = new Random();
         rand.Next(-(int)GameSizeX / 2, (int)GameSizeX / 2);
         Point3F spawnPoint = new Point3F(rand.Next(-(int)(GameSizeX / 2), (int)(GameSizeX / 2)), rand.Next(-(int)(GameSizeY / 2), (int)(GameSizeY / 2)), 0);
                  
         /*Global.initContainerRadiusSearch(spawnPoint, 1, (uint)ObjectTypes.StaticShapeObjectType);
         while(Global.containerSearchNext() != null)
         {
            spawnPoint = new Point3F(rand.Next(-(int)GameSizeX / 2, (int)GameSizeX / 2), rand.Next(-(int)GameSizeY / 2, (int)GameSizeY / 2), 0);
            Global.initContainerRadiusSearch(spawnPoint, 1, (uint)ObjectTypes.StaticShapeObjectType);
         }*/
        
         return spawnPoint;
      }

      private void createBoundingBox(float x, float y)
      {
         float rightWallPos = x / 2;
         float leftWallPos = -x / 2;
         float frontWallpos = y / 2;
         float backWallPos = -y / 2;

         TSStatic RightWall = new TSStatic()
         {
            ShapeName = "data/spectatorGameplay/art/GameShapes/player.dts",
            Position = new Point3F(rightWallPos, 0, 1),
            CollisionType = TSMeshType.Bounds,
            Scale = new Point3F(1, y, 0.5f)
         };
         TSStatic LeftWall = new TSStatic()
         {
            ShapeName = "data/spectatorGameplay/art/GameShapes/player.dts",
            Position = new Point3F(leftWallPos, 0, 1),
            CollisionType = TSMeshType.Bounds,
            Scale = new Point3F(1, y, 0.5f)
         };
         TSStatic FrontWall = new TSStatic()
         {
            ShapeName = "data/spectatorGameplay/art/GameShapes/player.dts",
            Position = new Point3F(0, frontWallpos, 1),
            CollisionType = TSMeshType.Bounds,
            Scale = new Point3F(x, 1, 0.5f)
         };
         TSStatic BackWall = new TSStatic()
         {
            ShapeName = "data/spectatorGameplay/art/GameShapes/player.dts",
            Position = new Point3F(0, backWallPos, 1),
            CollisionType = TSMeshType.Bounds,
            Scale = new Point3F(x, 1, 0.5f)
         };
         RightWall.registerObject();
         LeftWall.registerObject();
         FrontWall.registerObject();
         BackWall.registerObject();

      }

      private void generateRandomObstacles(int count)
      {

         Random rand = new Random();
         for (int i = 0; i < count; i++)
         {
            float xpos = (float)rand.Next(-(int)(GameSizeX/2),(int)(GameSizeX/2));
            float ypos = (float)rand.Next(-(int)(GameSizeY/2), (int)(GameSizeY/2));
            float xscale = (float)rand.Next(0, 10);
            float yscale = (float)rand.Next(0, 10);
            TSStatic obstacle = new TSStatic()
            {
               ShapeName = "data/spectatorGameplay/art/GameShapes/player.dts",
               Position = new Point3F(xpos, ypos, 1),
               CollisionType = TSMeshType.Bounds,
               Scale = new Point3F(xscale, yscale, 0.5f)
            };
            obstacle.registerObject();
         }
      }

      //-----------------------------------------------------------------------------
      // Clean up the client's control objects
      //-----------------------------------------------------------------------------
      public void onClientLeaveGame(GameConnectionToClient client)
      {
         // Cleanup the camera
         camera?.delete();
      }

      //-----------------------------------------------------------------------------
      // The server has started up so do some game start up
      //-----------------------------------------------------------------------------
      public void onMissionStart()
      {
         //set up the game and game variables
         initGameVars();
         createBoundingBox(GameSizeX, GameSizeY);
         //generateRandomObstacles(10);
         Globals.SetInt("Game::Duration", duration);
      }

      public void onMissionEnded()
      {
         Global.cancel(Globals.GetInt("Game::Schedule"));
         Globals.SetBool("Game::Running", false);
         Globals.SetBool("Game::Cycling", false);
      }

      public void onMissionReset()
      {
         // Called by resetMission(), after all the temporary mission objects
         // have been deleted.
         initGameVars();

         Globals.SetInt("Game::Duration", duration);
      }

      //-----------------------------------------------------------------------------
      // Functions that implement game-play
      // These are here for backwards compatibilty only, games and/or mods should
      // really be overloading the server and mission functions listed above.
      //-----------------------------------------------------------------------------

      public SpawnSphere pickCameraSpawnPoint(string spawnGroups)
      {
         // Walk through the groups until we find a valid object
         for (var i = 0; i < Global.getWordCount(spawnGroups); i++)
         {
            var group = Global.getWord(spawnGroups, i);

            SpawnSphere spawnPoint = null;

            var count = Global.getWordCount(group);

            if (Global.isObject(group))
               spawnPoint = Sim.FindObject<SimSet>(group).getRandom().As<SpawnSphere>();

            if (spawnPoint != null)
               return spawnPoint;
         }

         // Didn't find a spawn point by looking for the groups
         // so let's return the "default" SpawnSphere
         // First create it if it doesn't already exist
         if (!Global.isObject("DefaultCameraSpawnSphere"))
         {
            var spawn = new SpawnSphere("DefaultCameraSpawnSphere")
            {
               DataBlock = Sim.FindObject<GameBaseData>("SpawnSphereMarker"),
               SpawnClass = Globals.GetString("Game::DefaultCameraClass"),
               SpawnDatablock = Globals.GetString("Game::DefaultCameraDataBlock")
            };

            // Add it to the MissionCleanup group so that it
            // doesn't get saved to the Mission (and gets cleaned
            // up of course)
            Sim.FindObject<SimSet>("MissionCleanup").add(spawn);
         }

         return Sim.FindObject<SpawnSphere>("DefaultCameraSpawnSphere");
      }

      public void spawnCamera(SpawnSphere spawnPoint, GameConnectionToClient client)
      {
         spawnCamera(new TransformF(spawnPoint.call("getTransform")), client);
      }

      public void spawnCamera(TransformF spawnPoint, GameConnectionToClient client)
      {
         Camera camera = null;
         // Set the control object to the default camera
         if (!Global.isObject(client.getFieldValue("camera")))
         {
           
            //client.setFieldValue("camera", id.ToString());

            camera = new Camera()
            {
               DataBlock = Sim.FindObject<Observer>("Observer")
            };
            camera.registerObject();

            client.setFieldValue("camera", camera.getId().ToString());

         }

         if(camera == null)
            camera = Sim.FindObject<Camera>(client.getFieldValue("camera"));

         // If we have a camera then set up some properties
         if (camera != null)
         {
            Sim.FindObject<SimSet>("MissionCleanup").add(camera);
            camera.scopeToClient(client);

            client.setControlObject(camera);

            if (spawnPoint != null)
            {
               camera.setTransform(spawnPoint);
            }
         }
      }
   }
}