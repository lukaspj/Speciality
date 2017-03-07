using Torque3D;
using Torque3D.Engine;

namespace Game.Modules.ClientServer.Server
{
   class LevelInfo
   {
      public static void Init()
      {
      }

      //------------------------------------------------------------------------------
      // Loading info is text displayed on the client side while the mission
      // is being loaded.  This information is extracted from the mission file
      // and sent to each the client as it joins.
      //------------------------------------------------------------------------------


      /// <summary>
      /// Clears the mission info stored
      /// </summary>
      public static void clearLoadInfo()
      {
         if (Global.isObject("TheLevelInfo"))
         {
            Sim.FindObject<Torque3D.LevelInfo>("TheLevelInfo").delete();
         }
      }
      
      /// <summary>
      /// Extract the map description from the .mis file
      /// </summary>
      /// <param name="mission"></param>
      public static void buildLoadInfo(string mission)
      {
         clearLoadInfo();

         string infoObject = "";
         FileObject file = new FileObject(true);

         if (file.openForRead(mission))
         {
            bool inInfoBlock = false;

            while (!file.isEOF())
            {
               string line = file.readLine().Trim();

               if (line.Equals("new ScriptObject(MissionInfo) {"))
                  inInfoBlock = true;
               else if (line.Equals("new LevelInfo(theLevelInfo) {"))
                  inInfoBlock = true;
               else if (inInfoBlock && line.Equals("};"))
               {
                  inInfoBlock = false;
                  infoObject = infoObject + line;
                  break;
               }

               if (inInfoBlock)
                  infoObject = infoObject + line + " ";
            }
            file.close();
         }
         else
         {
            Global.error("Level file " + mission + " not found.");
         }

         // Will create the object "MissionInfo"
         Global.eval(infoObject);
         file.delete();
      }

      /// <summary>
      /// Echo the mission information to the console
      /// </summary>
      /// <param name="mission"></param>
      public static void dumpLoadInfo()
      {
         Torque3D.LevelInfo theLevelInfo = Sim.FindObject<Torque3D.LevelInfo>("theLevelInfo");

         Global.echo("Level Name: " + theLevelInfo.Name);
         Global.echo("Level Description:");

         for (int i = 0; !string.IsNullOrEmpty(theLevelInfo.getFieldValue($"desc{i}")); i++ )
            Global.echo("   " + theLevelInfo.getFieldValue($"desc{i}"));
      }

      /// <summary>
      /// Sends mission description to the client
      /// </summary>
      /// <param name="client"></param>
      public static void sendLoadInfoToClient(GameConnectionToClient client)
      {
         Torque3D.LevelInfo theLevelInfo = Sim.FindObject<Torque3D.LevelInfo>("theLevelInfo");
         Message.messageClient(client, Global.addTaggedString("MsgLoadInfo"), "", theLevelInfo.getFieldValue("levelName"));

         for (int i = 0; !string.IsNullOrEmpty(theLevelInfo.getFieldValue($"desc{i}")); i++)
            Message.messageClient(client, Global.addTaggedString("MsgLoadDescription"), "", theLevelInfo.getFieldValue(
               $"desc{i}"));

         Message.messageClient(client, Global.addTaggedString("MsgLoadInfoDone"), "");
      }

      /// <summary>
      /// A function used in order to easily parse the MissionGroup for classes . I'm pretty 
      /// sure at this point the function can be easily modified to search the any group as well.
      /// </summary>
      /// <param name="className"></param>
      /// <param name="childGroup"></param>
      public static bool parseMissionGroup(string className, SimGroup childGroup = null)
      {
         if (childGroup == null)
            childGroup = Sim.FindObject<SimGroup>("MissionGroup");

         for (uint i = 0; i < childGroup.getCount(); i++)
         {
            if (childGroup.getObject(i).getClassName().Equals(className)) return true;

            if (childGroup.getObject(i).getClassName().Equals("SimGroup"))
            {
               if (parseMissionGroup(className, childGroup.getObject(i).As<SimGroup>())) return true;
            }
         }

         return false;
      }

      public static string parseMissionGroupForIds(string className, SimGroup childGroup = null)
      {
         if (childGroup == null)
            childGroup = Sim.FindObject<SimGroup>(Globals.GetString("Game::MissionGroup"));

         string classIds = "";

         for (uint i = 0; i < childGroup.getCount(); i++)
         {
            if (childGroup.getObject(i).getClassName().Equals(className))
               classIds += childGroup.getObject(i).getId() + " ";

            if (childGroup.getObject(i).getClassName().Equals("SimGroup"))
               classIds += parseMissionGroupForIds(className, childGroup.getObject(i).As<SimGroup>());
         }

         return classIds;
      }

      [ConsoleFunction]
      public static string getLevelInfo(string missionFile)
      {
         clearLoadInfo();

         FileObject file = new FileObject();

         string levelInfoObject = "";

         if (file.openForRead(missionFile))
         {
            bool inInfoBlock = false;

            while (!file.isEOF())
            {
               string line = file.readLine().Trim();

               if (line.Equals("new ScriptObject(LevelInfo) {")) inInfoBlock = true;
               else if (line.Equals("new LevelInfo(theLevelInfo) {")) inInfoBlock = true;
               else if (inInfoBlock && line.Equals("};"))
               {
                  inInfoBlock = false;
                  levelInfoObject += line;
                  break;
               }

               if (inInfoBlock)
                  levelInfoObject += line + " ";
            }
            file.close();
         }
         file.delete();

         if (!string.IsNullOrEmpty(levelInfoObject))
         {
            levelInfoObject = "%levelInfoObject = " + levelInfoObject;
            Global.eval(levelInfoObject);

            //todo really?
            return levelInfoObject;
         }

         // Didn't find our LevelInfo
         return null;
      }
   }
}
