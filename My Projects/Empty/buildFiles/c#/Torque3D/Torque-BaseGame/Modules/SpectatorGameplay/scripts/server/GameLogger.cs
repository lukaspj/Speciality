using System;
using System.IO;
using Torque3D;
using Torque3D.Engine.Util.Enums;
using Torque3D.Util;

namespace Game.Modules.SpectatorGameplay.scripts.server
{
   class GameLogger
   {
      public static string LogPath = "gameLogs/";

      [ConsoleFunction]
      public static void LogGameStart(SimplePlayer[] players)
      {
         GetLogger().WriteLine("GAME START");

         string playerVsText = $"{players[0].Name}::{players[0].ThinkFunction}";
         for (int i = 1; i < players.Length; i++)
         {
            playerVsText += $" vs {players[i].Name}::{players[i].ThinkFunction}";
         }

         GetLogger().WriteLine($"INIT: {playerVsText}");
      }

      [ConsoleFunction]
      public static void LogPlayerAction(SimplePlayer player, FeatureVector vector, PlayerAction action)
      {
         GetLogger().WriteLine($"ACTION: {player.Name} | {vector} -> {action}");
      }

      [ConsoleFunction]
      public static void LogDamageEvent(SimplePlayer victim, float damage)
      {
         GetLogger().WriteLine($"DAMAGE: {victim.Name} took {damage} damage, now at {victim.Health}");
      }

      [ConsoleFunction]
      public static void LogGameResult(SimplePlayer winner)
      {
         GetLogger().WriteLine($"RESULT: {winner?.Name} won");
         GetLogger().WriteLine("GAME END");
         _streamWriter = null;
      }

      private static StreamWriter _streamWriter;
      private static StreamWriter GetLogger()
      {
         return _streamWriter ?? (_streamWriter = new StreamWriter(GetLogFileName()));
      }

      private static string GetLogFileName()
      {
         DateTime now = DateTime.Now;

         string prefix = now.Month + "_" + now.Day;

         int i = 0;
         while (File.Exists(LogPath + prefix + $"_{i}.dat"))
         {
            i++;
         }

         return LogPath + prefix + $"_{i}.dat";
      }
   }
}
