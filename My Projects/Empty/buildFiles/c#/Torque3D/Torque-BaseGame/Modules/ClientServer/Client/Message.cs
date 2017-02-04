using System.Collections.Generic;
using Torque3D;
using Torque3D.Engine.Util;

namespace Game.Modules.ClientServer.Client
{
   class Message
   {
      public static void Init()
      {
         // Register that default message handler now.
         addMessageCallback("", "defaultMessageCallback");
      }

      //-----------------------------------------------------------------------------
      // Functions that process commands sent from the server.

      // Game event descriptions, which may or may not include text messages, can be
      // sent using the message* functions in core/scripts/server/message.cs.  Those
      // functions do commandToClient with the tag ServerMessage, which invokes the
      // function below.

      // For ServerMessage messages, the client can install callbacks that will be
      // run, according to the "type" of the message.

      [ConsoleFunction]
      public static void clientCmdServerMessage(string msgType, string msgString = "", params string[] args)
      {
         // Get the message type; terminates at any whitespace.
         string tag = Global.getWord(msgType, 0);

         // First see if there is a callback installed that doesn't have a type;
         // if so, that callback is always executed when a message arrives.
         string func;
         for (int i = 0; !string.IsNullOrEmpty(func = Globals.GetString($"MSGCB[\"\", {i}]")); i++)
         {
            List<string> argList = new List<string>(args);
            argList.Insert(0, msgType);
            argList.Insert(1, msgString);
            Global.call(func, argList.ToArray());
         }


         // Next look for a callback for this particular type of ServerMessage.
         if (!string.IsNullOrEmpty(tag))
         {
            for (int i = 0; !string.IsNullOrEmpty(func = Globals.GetString($"MSGCB[\"{tag}\", {i}]")); i++)
            {
               List<string> argList = new List<string>(args);
               argList.Insert(0, msgType);
               argList.Insert(1, msgString);
               Global.call(func, argList.ToArray());
            }
         }
      }

      // Called by the client to install a callback for a particular type of
      // ServerMessage.
      public static void addMessageCallback(string msgType, string func)
      {
         string afunc;
         int i = 0;
         for (; !string.IsNullOrEmpty(afunc = Globals.GetString($"MSGCB[\"{msgType}\", {i}]")); i++)
         {
            // If it already exists as a callback for this type,
            // nothing to do.
            if (afunc.Equals(func))
            {
               return;
            }
         }

         // Set it up.
         Globals.SetString($"MSGCB[{msgType}, {i}]", func);
      }

      // The following is the callback that will be executed for every ServerMessage,
      // because we're going to install it without a specified type.  Any type-
      // specific callbacks will be executed afterward.

      // This just invokes onServerMessage, which can be overridden by the game
      public static void onServerMessage(params string[] message)
      {
         Global.echo("onServerMessage: ");
         for (int i = 0; i < message.Length; i++)
         {
            string s = message[i];
            Global.echo($"  +- {i}: {s}");
         }
      }

      public static void defaultMessageCallback(string msgType, string msgString, params string[] message)
      {
         onServerMessage(msgString.Detag());
      }
   }
}