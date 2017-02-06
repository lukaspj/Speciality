using Torque3D;
using Torque3D.Engine;
using Torque3D.Engine.Util;

namespace Game.Modules.ClientServer.Server
{
   [ConsoleClass("LocalClientConnection")]
   class GameConnectionToClient : GameConnection
   {
      public GameConnectionToClient(string pName, bool pRegister = false) : base(pName, pRegister)
      {
      }

      public GameConnectionToClient(SimObject obj) : base(obj)
      {
      }

      public static void Init()
      {
      }

      public string CurrentPhase
      {
         get { return getFieldValue("currentPhase"); }
         set { setFieldValue("currentPhase", value); }
      }

      public string Guid
      {
         get { return getFieldValue("guid"); }
         set { setFieldValue("guid", value); }
      }

      public string SendGuid
      {
         get { return getFieldValue("sendGuid"); }
         set { setFieldValue("sendGuid", value); }
      }

      public string ConnectData
      {
         get { return getFieldValue("connectData"); }
         set { setFieldValue("connectData", value); }
      }

      public string NameBase
      {
         get { return getFieldValue("nameBase"); }
         set { setFieldValue("nameBase", value); }
      }

      public string PlayerName
      {
         get { return getFieldValue("playerName"); }
         set { setFieldValue("playerName", value); }
      }

      public bool IsAdmin
      {
         get { return GenericMarshal.StringToBool(getFieldValue("guid")); }
         set { setFieldValue("guid", value.ToString()); }
      }

      public bool IsSuperAdmin
      {
         get { return GenericMarshal.StringToBool(getFieldValue("guid")); }
         set { setFieldValue("guid", value.ToString()); }
      }

      //----------------------------------------------------------------------------
      // Phase 1 
      //----------------------------------------------------------------------------
      public void loadMission()
      {
         // Send over the information that will display the server info
         // when we learn it got there, we'll send the data blocks
         CurrentPhase = "0";

         if (isAIControlled())
         {
            Torque3D.LevelInfo TheLevelInfo = Sim.FindObject<Torque3D.LevelInfo>("TheLevelInfo");
            // Cut to the chase...
            TheLevelInfo.call("onEnterGame");
         }
         else
         {
            Global.commandToClient(this, 
               "MissionStartPhase1".Tag(), 
               Globals.GetString("missionSequence"), 
               Globals.GetString("Server::MissionFile"), 
               Sim.FindObject<SimGroup>("MissionGroup").getFieldValue("musicTrack")
               );
            Global.echo("*** Sending mission load to client: " + Globals.GetString("Server::MissionFile"));
         }
      }
      
      public void onDataBlocksDone(string missionSequence)
      {
         // Make sure to ignore calls from a previous mission load
         if (!missionSequence.Equals(Globals.GetString("missionSequence")) || CurrentPhase != "1")
            return;

         CurrentPhase = "1.5";

         // On to the next phase
         Global.commandToClient(this,
            "MissionStartPhase2".Tag(),
            Globals.GetString("missionSequence"),
            Globals.GetString("Server::MissionFile"));
      }

      //----------------------------------------------------------------------------
      // Phase 2
      //----------------------------------------------------------------------------
      public void clientWantsGhostAlwaysRetry()
      {
         if (Globals.GetBool("MissionRunning"))
         {
            activateGhosting();
         }
      }

      public void onGhostAlwaysFailed()
      {
      }

      [ConsoleFunction]
      public void onGhostAlwaysObjectsReceived()
      {
         // Ready for next phase.
         Global.commandToClient(this,
            "MissionStartPhase3".Tag(),
            Globals.GetString("missionSequence"),
            Globals.GetString("Server::MissionFile"));
      }

      //----------------------------------------------------------------------------
      // Phase 3
      //----------------------------------------------------------------------------

      //----------------------------------------------------------------------------
      // Ongoing
      //----------------------------------------------------------------------------
      /// <summary>
      /// This script function is called before a client connection
      /// is accepted.  Returning "" will accept the connection,
      /// anything else will be sent back as an error to the client.
      /// All the connect args are passed also to onConnectRequest
      /// </summary>
      /// <param name="client"></param>
      /// <param name="netAddress"></param>
      /// <param name="name"></param>
      public void onConnectRequest(string netAddress, string name)
      {
         
      }

      /// <summary>
      /// This script function is the first called on a client accept
      /// </summary>
      /// <param name="netAddress"></param>
      /// <param name="name"></param>
      public void onConnect(string clientData)
      {
         // Send down the connection error info, the client is responsible for
         // displaying this message if a connection error occurs.
         Message.messageClient(this, "MsgConnectionError".Tag(), "", Globals.GetString("Pref::Server::ConnectionError"));

         // Send mission information to the client
         LevelInfo.sendLoadInfoToClient(this);

         // Simulated client lag for testing...
         // %client.setSimulatedNetParams(0.1, 30);

         // Get the client's unique id:
         // %authInfo = %client.getAuthInfo();
         // %client.guid = getField(%authInfo, 3);
         Guid = "0";
         Server.addToServerGuidList(Guid);

         // Set admin status
         if (getAddress().Equals("local"))
         {
            IsAdmin = true;
            IsSuperAdmin = true;
         }
	      else
         {
            IsAdmin = false;
            IsSuperAdmin = false;
         }

         Global.echo("CADD: " + getId() + " " + getAddress());

         // If the mission is running, go ahead download it to the client
         if (Globals.GetBool("missionRunning"))
	      {
            loadMission();
         }
	      else if (!string.IsNullOrEmpty(Globals.GetString("Server::LoadFailMsg")))
	      {
            Message.messageClient(this, "MsgLoadFailed".Tag(), Globals.GetString("Server::LoadFailMsg"));
         }

         ConnectData = clientData;
	
	      Globals.Increment("Server::PlayerCount");
      }

      /// <summary>
      /// A player's name could be obtained from the auth server, but for
      /// now we use the one passed from the client.
      /// %realName = getField( %authInfo, 0 );
      /// </summary>
      /// <param name="name"></param>
      public void setPlayerName(string name)
      {
         SendGuid = "0";

         // Minimum length requirements
         name = Global.strToPlayerName(name).Trim();
         if (name.Length < 3) name = "Poser";

         // Make sure the alias is unique, we'll hit something eventually
         if (!isNameUnique(name))
         {
            string nameTry = name;
            bool isUnique = false;
            for (int suffix = 1; !isUnique; suffix++)
            {
               nameTry = name + "." + suffix;
               isUnique = isNameUnique(nameTry);
            }
            name = nameTry;
         }

         // Tag the name with the "smurf" color:
         NameBase = name;
         PlayerName = $"\\cp\\c8{name}\\co".ColorEscape().Tag();
      }

      private bool isNameUnique(string name)
      {
         SimGroup ClientGroup = Sim.FindObject<SimGroup>("ClientGroup");
         for (uint i = 0; i < ClientGroup.getCount(); i++)
         {
            GameConnectionToClient test = ClientGroup.getObject(i).As<GameConnectionToClient>();
            string rawName = Global.stripChars(Global.detag(test.PlayerName.Tag()),
               "\\cp\\co\\c6\\c7\\c8\\c9".ColorEscape());
            if (name.Equals(rawName)) return false;
         }
         return true;
      }

      /// <summary>
      /// This function is called when a client drops for any reason
      /// </summary>
      /// <param name="reason"></param>
      public void onDrop(string reason)
      {
         Torque3D.LevelInfo theLevelInfo = Sim.FindObject<Torque3D.LevelInfo>("TheLevelInfo");
         if (Globals.GetBool("missionRunning"))
            theLevelInfo.call("onClientLeaveGame", this.getId().ToString());

         Server.removeFromServerGuidList(Guid);

         Globals.Decrement("Server::PlayerCount");
      }

      public void startMission()
      {
         // Inform the client the mission starting
         Global.commandToClient(this, "MissionStart".Tag(), Globals.GetString("missionSequence"));
      }

      public void endMission()
      {
         // Inform the client the mission is done.  Note that if this is
         // called as part of the server destruction routine, the client will
         // actually never see this comment since the client connection will
         // be destroyed before another round of command processing occurs.
         // In this case, the client will only see the disconnect from the server
         // and should manually trigger a mission cleanup.
         Global.commandToClient(this, "MissionEnd".Tag(), Globals.GetString("missionSequence"));
      }
   }
}
