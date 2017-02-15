using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;
using Torque3D;

namespace Game
{
   class Program
   {
      static void Main(string[] args)
      {
         CultureInfo customCulture =
            (CultureInfo) Thread.CurrentThread.CurrentCulture.Clone();
         customCulture.NumberFormat.NumberDecimalSeparator = ".";

         Thread.CurrentThread.CurrentCulture = customCulture;

         Initializer.InitializeTypeDictionaries(Assembly.GetExecutingAssembly().GetTypes());

         string[] dlls = Directory.GetFiles("aiLibs", "*.dll");
         foreach (string dll in dlls)
         {
            Initializer.InitializeTypeDictionaries(dll);
         }

         Torque3D.Torque3D.Libraries libraries = new Torque3D.Torque3D.Libraries
         {
            Windows32bit = "Empty_DEBUG.dll",
            Windows64bit = "Empty_DEBUG.dll"
         };

         Torque3D.Torque3D.Initialize(args, libraries);
      }
   }
}