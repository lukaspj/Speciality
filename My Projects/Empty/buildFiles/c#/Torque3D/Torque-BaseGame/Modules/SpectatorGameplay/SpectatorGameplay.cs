using Game.Core;
using Torque3D;
using Torque3D.Engine;

namespace Game.Modules.ClientServer
{
   // The general flow of a gane - server's creation, loading and hosting clients, and then destruction is as follows:

   // First, a client will always create a server in the event that they want to host a single player
   // game. Torque3D treats even single player connections as a soft multiplayer game, with some stuff
   // in the networking short-circuited to sidestep around lag and packet transmission times.

   // initServer() is called, loading the default server scripts.
   // After that, if this is a dedicated server session, initDedicated() is called, otherwise initClient is called
   // to prep a playable client session.

   // When a local game is started - a listen server - via calling StartGame() a server is created and then the client is
   // connected to it via createAndConnectToLocalServer().

   [ConsoleClass]
   internal class SpectatorGameplay : SimSet
   {
      public void create()
      {
         //server scripts
         //Global.exec("data/SpectatorGameplay/scripts/server/camera.cs");
         //Global.exec("data/SpectatorGameplay/scripts/server/DefaultGame.cs");
         Global.exec("data/SpectatorGameplay/scripts/server/VolumetricFog.cs");
         

         //add DBs
         if (Global.isObject("DatablockFilesList"))
         {
            var DatablockFilesList = Sim.FindObject<ArrayObject>("DatablockFilesList");

            DatablockFilesList.add("data/spectatorGameplay/scripts/datablocks/camera.cs");
            DatablockFilesList.add("data/spectatorGameplay/scripts/datablocks/defaultParticle.cs");
            DatablockFilesList.add("data/spectatorGameplay/scripts/datablocks/lights.cs");
            DatablockFilesList.add("data/spectatorGameplay/scripts/datablocks/managedDatablocks.cs");
            DatablockFilesList.add("data/spectatorGameplay/scripts/datablocks/managedDecalData.cs");
            DatablockFilesList.add("data/spectatorGameplay/scripts/datablocks/managedForestItemData.cs");
            DatablockFilesList.add("data/spectatorGameplay/scripts/datablocks/managedParticleData.cs");
            DatablockFilesList.add("data/spectatorGameplay/scripts/datablocks/managedParticleEmitterData.cs");
            DatablockFilesList.add("data/spectatorGameplay/scripts/datablocks/markers.cs");
            DatablockFilesList.add("data/spectatorGameplay/scripts/datablocks/ribbons.cs");
            DatablockFilesList.add("data/spectatorGameplay/scripts/datablocks/sounds.cs");
            DatablockFilesList.add("data/SpectatorGameplay/scripts/datablocks/player.cs");
         }

         if (Global.isObject("LevelFilesList"))
            for (var file = Global.findFirstFile("data/spectatorGameplay/levels/*.mis");
               !string.IsNullOrEmpty(file);
               file = Global.findNextFile("data/spectatorGameplay/levels/*.mis"))
               Sim.FindObject<ArrayObject>("LevelFilesList").add(file);

         if (!Globals.GetBool("Server::Dedicated"))
         {
            //client scripts
            Globals.SetString("KeybindPath", "data/spectatorGameplay/scripts/client/default.keybinds.cs");
            Global.exec(Globals.GetString("KeybindPath"));


            var prefPath = HelperFunctions.getPrefpath();
            if (Global.isFile(prefPath + "/keybinds.cs"))
               Global.exec(prefPath + "/keybinds.cs");

            Global.exec("data/spectatorGameplay/scripts/client/inputCommands.cs");

            //guis
            Global.exec("data/SpectatorGameplay/scripts/gui/playGui.gui");
            Global.exec("data/SpectatorGameplay/scripts/gui/playGui.cs");
         }
      }

      public void destroy()
      {
      }
   }
}