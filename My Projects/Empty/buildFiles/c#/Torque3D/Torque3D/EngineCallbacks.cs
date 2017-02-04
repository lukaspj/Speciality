using System;
using System.Collections.Generic;
using System.Reflection;

namespace Torque3D
{
   internal class EngineCallbacks
   {
      private static readonly Dictionary<string, Type> ClassTypeDictionary = new Dictionary<string, Type>();
      private static readonly Dictionary<string, MethodInfo> FunctionDictionary = new Dictionary<string, MethodInfo>();

      public static void RegisterType(string className, Type classType)
      {
         ClassTypeDictionary.Add(className, classType);
      }

      public static void RegisterFunction(string functionName, MethodInfo methodInfo)
      {
         FunctionDictionary.Add(functionName, methodInfo);
      }

      public static void Clear()
      {
         ClassTypeDictionary.Clear();
         FunctionDictionary.Clear();
      }

      public static string CallScriptFunction(string pFunctionNamespace, string pFunctionName, object[] args, out bool found)
      {
         if (pFunctionNamespace != null)
         {
            Type type;
            SimObject obj = SimDictionary.Find(pFunctionNamespace);

            string objectName = pFunctionNamespace;
            if (objectName != null && ClassTypeDictionary.ContainsKey(objectName))
            {
               type = ClassTypeDictionary[objectName];
            }
            else if(obj != null)
            {
               type = obj.GetType();
            }
            else
            {
               //todo throw exception?
               found = false;
               return null;
            }

            return CallNamespaceMethod(type, obj, pFunctionName, args, out found);
         }
         if (!FunctionDictionary.ContainsKey(pFunctionName))
         {
            found = false;
            return null;
         }
         found = true;
         MethodInfo methodInfo = FunctionDictionary[pFunctionName];

         ParameterInfo[] parameterInfos = methodInfo.GetParameters();
         object[] _args = new object[parameterInfos.Length];
         for (int i = 0; i < _args.Length; i++)
         {
            if (parameterInfos[i].GetCustomAttributes(typeof(ParamArrayAttribute), false).Length > 0)
            {
               string[] parms = new string[Math.Max(args.Length - i, 0)];
               for (int j = 0; j < args.Length - i; j++)
               {
                  parms[j] = (string)args[i + j];
               }
               _args[i] = parms;
               break;
            }
            if (i < args.Length) _args[i] = args[i];
            else if (parameterInfos[i].HasDefaultValue) _args[i] = parameterInfos[i].DefaultValue;
            else throw new ArgumentException("Not enough arguments provided");
         }

         if (methodInfo.ReturnType == typeof(bool))
            return (bool)methodInfo.Invoke(null, _args) ? "1" : "0";
         if (methodInfo.ReturnType == typeof(string))
            return (string)methodInfo.Invoke(null, _args);
         methodInfo.Invoke(null, _args);
         return null;
      }

      public static string CallScriptMethod(string className, string classNamespace, SimObject objectWrapper, string methodName, object[] args, out bool found)
      {
         Type type;
         string objectName = objectWrapper.getName();
         if (objectName != null && ClassTypeDictionary.ContainsKey(objectName))
         {
            type = ClassTypeDictionary[objectName];
         }
         else if (classNamespace != null &&ClassTypeDictionary.ContainsKey(classNamespace))
         {
            type = ClassTypeDictionary[classNamespace];
         }
         else if (ClassTypeDictionary.ContainsKey(className))
         {
            type = ClassTypeDictionary[className];
         }
         else if (SimDictionary.Find(objectWrapper.getId()) != null)
         {
            type = SimDictionary.Find(objectWrapper.getId()).GetType();
         }
         else
         {
            if (ClassTypeDictionary.ContainsKey(objectWrapper.GetType().Name))
               type = ClassTypeDictionary[objectWrapper.GetType().Name];
            else
            {
               found = false;
               return null;
            }
         }
         return CallNamespaceMethod(type, objectWrapper, methodName, args, out found);
      }

      private static string CallNamespaceMethod(Type namespaceClass, SimObject objectWrapper, string methodName, object[] args, out bool found)
      {
         MethodInfo callbackMethod = namespaceClass.GetMethod(methodName);
         if (callbackMethod != null)
         {
            foreach (ParameterInfo parameterInfo in callbackMethod.GetParameters())
            {
               if ((parameterInfo.ParameterType.IsArray && parameterInfo.ParameterType.GetElementType() != typeof(string)) || parameterInfo.ParameterType != typeof(string))
               {
                  found = false;
                  return null;
               }
            }
            found = true;

            ParameterInfo[] parameterInfos = callbackMethod.GetParameters();
            object[] _args = new object[parameterInfos.Length];
            for (int i = 0; i < _args.Length; i++)
            {
               if (parameterInfos[i].GetCustomAttributes(typeof(ParamArrayAttribute), false).Length > 0)
               {
                  string[] parms = new string[Math.Max(args.Length - i, 0)];
                  for (int j = 0; j < args.Length - i; j++)
                  {
                     parms[j] = (string)args[i + j];
                  }
                  _args[i] = parms;
                  break;
               }
               if (i < args.Length) _args[i] = args[i];
               else if (parameterInfos[i].HasDefaultValue) _args[i] = parameterInfos[i].DefaultValue;
               else throw new ArgumentException("Not enough arguments provided");
            }

            object simObj = null;
            if (!callbackMethod.IsStatic)
               simObj = SimDictionary.CreateInstance(namespaceClass, objectWrapper);
            if (callbackMethod.ReturnType == typeof(bool))
               return (bool)callbackMethod.Invoke(simObj, _args) ? "1" : "0";
            if (callbackMethod.ReturnType == typeof(string))
               return (string)callbackMethod.Invoke(simObj, _args);
            else if(callbackMethod.ReturnType != typeof(void))
               return callbackMethod.Invoke(simObj, _args).ToString();
            callbackMethod.Invoke(simObj, _args);
            return null;
         }
         found = false;
         return null;
      }

      public static bool IsMethod(string className, string methodName)
      {
         if (className == null)
            return FunctionDictionary.ContainsKey(methodName);
         if (!ClassTypeDictionary.ContainsKey(className))
            return false;
         return ClassTypeDictionary[className].GetMethod(methodName) != null;
      }
   }
}
