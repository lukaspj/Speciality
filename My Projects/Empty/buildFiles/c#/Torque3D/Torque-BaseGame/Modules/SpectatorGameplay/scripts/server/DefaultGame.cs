﻿using Game.Modules.ClientServer.Server;
using Torque3D;
using Torque3D.Engine;
using Torque3D.Util;

namespace Game.Modules.SpectatorGameplay.scripts.server
{
   [ConsoleClass]
   internal class DefaultGame : Torque3D.LevelInfo
   {
      public int duration { get; set; }

      public Camera camera { get; set; }
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
      public void onClientEnterGame(string client)
      {
         // This function currently relies on some helper functions defined in
         // core/scripts/spawn.cs. For custom spawn behaviors one can either
         // override the properties on the SpawnSphere's or directly override the
         // functions themselves.

         // Find a spawn point for the camera
         var cameraSpawnPoint = pickCameraSpawnPoint(Globals.GetString("Game::DefaultCameraSpawnGroups"));

         // Spawn a camera for this client using the found %spawnPoint
         spawnCamera(cameraSpawnPoint, Sim.FindObject<GameConnectionToClient>(client));
      }

      //-----------------------------------------------------------------------------
      // Clean up the client's control objects
      //-----------------------------------------------------------------------------
      public void onClientLeaveGame(string client)
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
         // Set the control object to the default camera
         if (!Global.isObject(client.getFieldValue("camera")))
         {
       int camObjId = Global.spawnObject("Camera", "Observer");
       client.setFieldValue("camera", camObjId.ToString());
         }

         string camera = client.getFieldValue("camera");

         // If we have a camera then set up some properties
         if (Global.isObject(camera))
         {
            Camera cameraObj = Sim.FindObject<Camera>(camera);
            Sim.FindObject<SimSet>("MissionCleanup").add(Sim.FindObject<Camera>(camera));
            cameraObj.scopeToClient(client);

            client.setControlObject(cameraObj);

            if (spawnPoint != null)
            {
               cameraObj.setTransform(spawnPoint);
            }
         }
      }
   }
}