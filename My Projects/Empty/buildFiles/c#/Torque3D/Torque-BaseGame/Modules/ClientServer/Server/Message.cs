using System.Collections.Generic;
using Torque3D;
using Torque3D.Engine;
using Torque3D.Engine.Util;

namespace Game.Modules.ClientServer.Server
{
   class Message
   {
      public static void Init()
      {
      }

      //-----------------------------------------------------------------------------
      public static void messageClient(GameConnectionToClient client, string msgType, string msgString, params string[] args)
      {
         List<string> argList = new List<string>(args);
         argList.Insert(0, msgType);
         argList.Insert(1, msgString);
         Global.commandToClient(client, "ServerMessage".Tag(), argList.ToArray());
      }

      public static void messageAll(string msgType, string msgString, params string[] args)
      {
         SimSet ClientGroup = Sim.FindObject<SimSet>("ClientGroup");
         for (uint i = 0; i < ClientGroup.getCount(); i++)
         {
            GameConnectionToClient client = ClientGroup.getObject(i).As<GameConnectionToClient>();
            messageClient(client, msgType, msgString, args);
         }
      }

      public static void messageAllExcept(GameConnectionToClient client, string team, string msgType, string msgString, params string[] args)
      {
         //can exclude a client, a team or both. A -1 value in either field will ignore that exclusion, so
         //messageAllExcept(-1, -1, $Mesblah, 'Blah!'); will message everyone (since there shouldn't be a client -1 or client on team -1).
         SimSet ClientGroup = Sim.FindObject<SimSet>("ClientGroup");
         for (uint i = 0; i < ClientGroup.getCount(); i++)
         {
            GameConnectionToClient recipient = ClientGroup.getObject(i).As<GameConnectionToClient>();
            if (recipient.getId() != client.getId() && !recipient.getFieldValue("team").Equals(team))
            {
               messageClient(recipient, msgType, msgString, args);
            }
         }
      }

      public static void messageAllExcept(string team, string msgType, string msgString, params string[] args)
      {
         //can exclude a client, a team or both. A -1 value in either field will ignore that exclusion, so
         //messageAllExcept(-1, -1, $Mesblah, 'Blah!'); will message everyone (since there shouldn't be a client -1 or client on team -1).
         SimSet ClientGroup = Sim.FindObject<SimSet>("ClientGroup");
         for (uint i = 0; i < ClientGroup.getCount(); i++)
         {
            GameConnectionToClient recipient = ClientGroup.getObject(i).As<GameConnectionToClient>();
            if (!recipient.getFieldValue("team").Equals(team))
            {
               messageClient(recipient, msgType, msgString, args);
            }
         }
      }

      public static void messageAllExcept(GameConnectionToClient client, string msgType, string msgString, params string[] args)
      {
         //can exclude a client, a team or both. A -1 value in either field will ignore that exclusion, so
         //messageAllExcept(-1, -1, $Mesblah, 'Blah!'); will message everyone (since there shouldn't be a client -1 or client on team -1).
         SimSet ClientGroup = Sim.FindObject<SimSet>("ClientGroup");
         for (uint i = 0; i < ClientGroup.getCount(); i++)
         {
            GameConnectionToClient recipient = ClientGroup.getObject(i).As<GameConnectionToClient>();
            if (recipient.getId() != client.getId())
            {
               messageClient(recipient, msgType, msgString, args);
            }
         }
      }
   }
}
