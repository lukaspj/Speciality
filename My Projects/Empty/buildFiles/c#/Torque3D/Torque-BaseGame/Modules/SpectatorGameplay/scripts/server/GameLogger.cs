using System;
using System.Collections.Generic;
using System.IO;
using Torque3D;
using Torque3D.Engine.Util.Enums;
using Torque3D.Util;

namespace Game.Modules.SpectatorGameplay.scripts.server
{
   class GameLogger
   {
      public static string LogPath = "gameLogs/";
      private static Dictionary<string, int> _playerIndexDictionary;

      [ConsoleFunction]
      public static void LogGameStart(SimplePlayer[] players)
      {
         _playerIndexDictionary = new Dictionary<string, int>();
         string playerNamesLine = "";
         for (int index = 0; index < players.Length; index++) {
            SimplePlayer simplePlayer = players[index];
            _playerIndexDictionary[simplePlayer.Name] = index;
            playerNamesLine += $"{index}:{simplePlayer.ThinkFunction}|";
         }

         GetLogger().WriteLine(playerNamesLine.Substring(0, playerNamesLine.Length - 1));

         //GetLogger().WriteLine("GAME START");
         /*
         string playerVsText = $"{players[0].Name}::{players[0].ThinkFunction}";
         for (int i = 1; i < players.Length; i++)
         {
            playerVsText += $" vs {players[i].Name}::{players[i].ThinkFunction}";
         }

         GetLogger().WriteLine($"INIT: {playerVsText}");*/
      }

      [ConsoleFunction]
      public static void LogPlayerAction(SimplePlayer player, FeatureVector vector, PlayerAction action)
      {
         //GetLogger().WriteLine($"ACTION: {player.Name} | {vector} -> {action}");
         GetLogger().WriteLine($"A:{_playerIndexDictionary[player.Name]}:{vector}:{action}");
      }

      [ConsoleFunction]
      public static void LogDamageEvent(SimplePlayer victim, float damage)
      {
         //GetLogger().WriteLine($"DAMAGE: {victim.Name} took {damage} damage, now at {victim.Health}");
         GetLogger().WriteLine($"D:{_playerIndexDictionary[victim.Name]}:{damage}:{victim.Health}");
      }

      [ConsoleFunction]
      public static void LogGameResult(SimplePlayer winner) {
         string res = "-1";
         if (winner != null)
            res = _playerIndexDictionary[winner.Name].ToString();
         GetLogger().WriteLine($"R:{res}");
         //GetLogger().WriteLine($"RESULT: {winner?.Name} won");
         //GetLogger().WriteLine("GAME END");
         _streamWriter.Close();
         _streamWriter.Dispose();
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
