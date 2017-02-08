﻿using System;
using Game.Modules.ClientServer.Server;
using Torque3D;
using Torque3D.Engine;
using Torque3D.Engine.Util.Enums;
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

      private GameBord bord;

      //-----------------------------------------------------------------------------
      // What kind of "player" is spawned is either controlled directly by the
      // SpawnSphere or it defaults back to the values set here. This also controls
      // which SimGroups to attempt to select the spawn sphere's from by walking down
      // the list of SpawnGroups till it finds a valid spawn object.
      // These override the values set in core/scripts/server/spawn.cs
      //-----------------------------------------------------------------------------
      public void initGameVars()
      {

         bord = new GameBord(100,100);
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
         
         SimplePlayer player = new SimplePlayer()
         {
<<<<<<< HEAD
            DataBlock = Sim.FindObject<PlayerData>("BoxPlayer"),
            Position = new Point3F(0,0,0)
=======
            DataBlock = Sim.FindObject<SimplePlayerData>("SPD"),
            Position = new Point3F(0,0,1),
            ThinkFunction = "SPThink"
>>>>>>> 777c4b121f6ad92fb9088bff70cb40f34773f7da
         };

         SimplePlayer player2 = new SimplePlayer()
         {
<<<<<<< HEAD
            DataBlock = Sim.FindObject<PlayerData>("BoxPlayer"),
            Position = new Point3F(50,0,0)
=======
            DataBlock = Sim.FindObject<SimplePlayerData>("SPD"),
            Position = new Point3F(50,0,1),
            ThinkFunction = "SPThink"
>>>>>>> 777c4b121f6ad92fb9088bff70cb40f34773f7da
         };
         SimplePlayer player3 = new SimplePlayer()
         {
<<<<<<< HEAD
            DataBlock = Sim.FindObject<PlayerData>("BoxPlayer"),
            Position = new Point3F(-50, 0,0)
=======
            DataBlock = Sim.FindObject<SimplePlayerData>("SPD"),
            Position = new Point3F(-50, 0,1),
            ThinkFunction = "SPThink"
>>>>>>> 777c4b121f6ad92fb9088bff70cb40f34773f7da
         };
         SimplePlayer player4 = new SimplePlayer()
         {
<<<<<<< HEAD
            DataBlock = Sim.FindObject<PlayerData>("BoxPlayer"),
            Position = new Point3F(0,50,0)
=======
            DataBlock = Sim.FindObject<SimplePlayerData>("SPD"),
            Position = new Point3F(0,50,1),
            ThinkFunction = "SPThink"
>>>>>>> 777c4b121f6ad92fb9088bff70cb40f34773f7da
         };
         SimplePlayer player5 = new SimplePlayer()
         {
<<<<<<< HEAD
            DataBlock = Sim.FindObject<PlayerData>("BoxPlayer"),
            Position = new Point3F(0,-50,0)
=======
            DataBlock = Sim.FindObject<SimplePlayerData>("SPD"),
            Position = new Point3F(0,-50,1),
            ThinkFunction = "SPThink"
>>>>>>> 777c4b121f6ad92fb9088bff70cb40f34773f7da
         };

         player.registerObject();
         player2.registerObject();
         player3.registerObject();
         player4.registerObject();
         player5.registerObject();
         SimplePlayerData.searchForPlayers(player,bord);
         client.setFieldValue("player", player.getId().ToString());
         //player.setSkinName("PlayerMaterial");
         client.setControlObject(player);

         // Spawn a camera for this client using the found %spawnPoint

         spawnCamera(cameraSpawnPoint, client);
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
         bord.CreateBoundingBox();
         bord.GenerateRandomObstacles(50);
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
               camera.setTransform(new TransformF(spawnPoint.Position + new Point3F(0,0,50), spawnPoint.Orientation));
            }
         }
      }

      private static int c = 0;

      [ConsoleFunction]
      public static PlayerAction SPThink(SimplePlayer player)
      {
         c++;
         player.MovingLeft = false;
         player.MovingRight = false;
         player.MovingForward = false;
         player.MovingBackward = false;
         if (c < 150) return PlayerAction.MoveForward;
         if (c < 300) return PlayerAction.MoveLeft;
         if (c < 450) return PlayerAction.MoveBackward;
         if (c < 600) return PlayerAction.MoveRight;
         if (c < 750) return PlayerAction.TurnRight;
         c %= 750;

         return PlayerAction.None;
      }
   }
}