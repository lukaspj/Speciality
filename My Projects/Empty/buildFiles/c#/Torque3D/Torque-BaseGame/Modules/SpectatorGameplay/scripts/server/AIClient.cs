using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Torque3D;
using Torque3D.Engine.Util.Enums;
using Torque3D.Util;
using ZeroMQ;

namespace Game.Modules.SpectatorGameplay.scripts.server {
   public class AIClient {
      private static ZSocket socket = null;

      public static void Connect() {
         socket = new ZSocket(ZSocketType.REQ);
         socket.Connect($"tcp://127.0.0.1:{Globals.GetString("SShooter::AIPort")}");
         JObject sendMsg = new JObject { ["type"] = "connect", ["success"] = true };
         socket.Send(new ZFrame(sendMsg.ToString(Formatting.None)));
         socket.ReceiveFrame();
      }

      public static JObject SendResult(string result) {
         if (socket == null)
            Connect();
         socket.Send(new ZFrame(new JObject {
            ["type"] = "event",
            ["message"] = "game_end",
            ["result"] = result
         }.ToString(Formatting.None)));
         return JObject.Parse(socket.ReceiveFrame().ReadString());
      }

      public static JObject SendMessage(string type, string message) {
         if (socket == null)
            Connect();
         socket.Send(new ZFrame(new JObject {
            ["type"] = type,
            ["message"] = message
         }.ToString(Formatting.None)));
         return JObject.Parse(socket.ReceiveFrame().ReadString());
      }

      public static JObject SendMessage(string type) {
         if (socket == null)
            Connect();
         socket.Send(new ZFrame(new JObject {
            ["type"] = type
         }.ToString(Formatting.None)));
         string frameString = socket.ReceiveFrame().ReadString();
         return JObject.Parse(frameString);
      }

      public static JObject WaitForInstructions() {
         if (socket == null)
            Connect();
         socket.SendFrame(new ZFrame(new JObject {
            ["type"] = "instruction"
         }.ToString(Formatting.None)));
         ZFrame frame = socket.ReceiveFrame();
         JObject msg = JObject.Parse(frame.ReadString());
         return msg;
      }

      [ConsoleFunction]
      public static PlayerAction RL_AIClient_Think(FeatureVector vector) {
         if(socket == null) Connect();
         socket.Send(new ZFrame(new JObject {
            ["type"] = "think",
            ["feature_vector"] = JsonConvert.SerializeObject(vector)
         }.ToString(Formatting.None)));
            
         return JsonConvert.DeserializeObject<PlayerAction>(socket.ReceiveFrame().ReadString());
      }
   }
}
