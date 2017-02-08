using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Torque3D.Util;

namespace Torque3D
{
	public static unsafe class Global
	{
      #region UnsafeNativeMethods
      
      new internal struct InternalUnsafeMethods
      {
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _addBadWord([MarshalAs(UnmanagedType.LPWStr)]string badWord);
         private static _addBadWord _addBadWordFunc;
         internal static bool addBadWord([MarshalAs(UnmanagedType.LPWStr)]string badWord)
         {
         	if (_addBadWordFunc == null)
         	{
         		_addBadWordFunc =
         			(_addBadWord)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_addBadWord"), typeof(_addBadWord));
         	}
         
         	return  _addBadWordFunc(badWord);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _filterString([MarshalAs(UnmanagedType.LPWStr)]string baseString, [MarshalAs(UnmanagedType.LPWStr)]string replacementChars);
         private static _filterString _filterStringFunc;
         internal static IntPtr filterString([MarshalAs(UnmanagedType.LPWStr)]string baseString, [MarshalAs(UnmanagedType.LPWStr)]string replacementChars)
         {
         	if (_filterStringFunc == null)
         	{
         		_filterStringFunc =
         			(_filterString)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_filterString"), typeof(_filterString));
         	}
         
         	return  _filterStringFunc(baseString, replacementChars);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _containsBadWords([MarshalAs(UnmanagedType.LPWStr)]string text);
         private static _containsBadWords _containsBadWordsFunc;
         internal static bool containsBadWords([MarshalAs(UnmanagedType.LPWStr)]string text)
         {
         	if (_containsBadWordsFunc == null)
         	{
         		_containsBadWordsFunc =
         			(_containsBadWords)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_containsBadWords"), typeof(_containsBadWords));
         	}
         
         	return  _containsBadWordsFunc(text);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _deactivateDirectInput();
         private static _deactivateDirectInput _deactivateDirectInputFunc;
         internal static void deactivateDirectInput()
         {
         	if (_deactivateDirectInputFunc == null)
         	{
         		_deactivateDirectInputFunc =
         			(_deactivateDirectInput)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_deactivateDirectInput"), typeof(_deactivateDirectInput));
         	}
         
         	 _deactivateDirectInputFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _activateDirectInput();
         private static _activateDirectInput _activateDirectInputFunc;
         internal static void activateDirectInput()
         {
         	if (_activateDirectInputFunc == null)
         	{
         		_activateDirectInputFunc =
         			(_activateDirectInput)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_activateDirectInput"), typeof(_activateDirectInput));
         	}
         
         	 _activateDirectInputFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _strToPlayerName([MarshalAs(UnmanagedType.LPWStr)]string ptr);
         private static _strToPlayerName _strToPlayerNameFunc;
         internal static IntPtr strToPlayerName([MarshalAs(UnmanagedType.LPWStr)]string ptr)
         {
         	if (_strToPlayerNameFunc == null)
         	{
         		_strToPlayerNameFunc =
         			(_strToPlayerName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_strToPlayerName"), typeof(_strToPlayerName));
         	}
         
         	return  _strToPlayerNameFunc(ptr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _lockMouse(bool isLocked);
         private static _lockMouse _lockMouseFunc;
         internal static void lockMouse(bool isLocked)
         {
         	if (_lockMouseFunc == null)
         	{
         		_lockMouseFunc =
         			(_lockMouse)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_lockMouse"), typeof(_lockMouse));
         	}
         
         	 _lockMouseFunc(isLocked);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setNetPort(int port, bool bind);
         private static _setNetPort _setNetPortFunc;
         internal static bool setNetPort(int port, bool bind)
         {
         	if (_setNetPortFunc == null)
         	{
         		_setNetPortFunc =
         			(_setNetPort)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_setNetPort"), typeof(_setNetPort));
         	}
         
         	return  _setNetPortFunc(port, bind);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _closeNetPort();
         private static _closeNetPort _closeNetPortFunc;
         internal static void closeNetPort()
         {
         	if (_closeNetPortFunc == null)
         	{
         		_closeNetPortFunc =
         			(_closeNetPort)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_closeNetPort"), typeof(_closeNetPort));
         	}
         
         	 _closeNetPortFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _saveJournal([MarshalAs(UnmanagedType.LPWStr)]string filename);
         private static _saveJournal _saveJournalFunc;
         internal static void saveJournal([MarshalAs(UnmanagedType.LPWStr)]string filename)
         {
         	if (_saveJournalFunc == null)
         	{
         		_saveJournalFunc =
         			(_saveJournal)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_saveJournal"), typeof(_saveJournal));
         	}
         
         	 _saveJournalFunc(filename);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _playJournal([MarshalAs(UnmanagedType.LPWStr)]string filename);
         private static _playJournal _playJournalFunc;
         internal static void playJournal([MarshalAs(UnmanagedType.LPWStr)]string filename)
         {
         	if (_playJournalFunc == null)
         	{
         		_playJournalFunc =
         			(_playJournal)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_playJournal"), typeof(_playJournal));
         	}
         
         	 _playJournalFunc(filename);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getSimTime();
         private static _getSimTime _getSimTimeFunc;
         internal static int getSimTime()
         {
         	if (_getSimTimeFunc == null)
         	{
         		_getSimTimeFunc =
         			(_getSimTime)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getSimTime"), typeof(_getSimTime));
         	}
         
         	return  _getSimTimeFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getRealTime();
         private static _getRealTime _getRealTimeFunc;
         internal static int getRealTime()
         {
         	if (_getRealTimeFunc == null)
         	{
         		_getRealTimeFunc =
         			(_getRealTime)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getRealTime"), typeof(_getRealTime));
         	}
         
         	return  _getRealTimeFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getLocalTime(int argc, string[] argv);
         private static _getLocalTime _getLocalTimeFunc;
         internal static IntPtr getLocalTime(int argc, string[] argv)
         {
         	if (_getLocalTimeFunc == null)
         	{
         		_getLocalTimeFunc =
         			(_getLocalTime)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getLocalTime"), typeof(_getLocalTime));
         	}
         
         	return  _getLocalTimeFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _commandToServer(int argc, string[] argv);
         private static _commandToServer _commandToServerFunc;
         internal static void commandToServer(int argc, string[] argv)
         {
         	if (_commandToServerFunc == null)
         	{
         		_commandToServerFunc =
         			(_commandToServer)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_commandToServer"), typeof(_commandToServer));
         	}
         
         	 _commandToServerFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _commandToClient(int argc, string[] argv);
         private static _commandToClient _commandToClientFunc;
         internal static void commandToClient(int argc, string[] argv)
         {
         	if (_commandToClientFunc == null)
         	{
         		_commandToClientFunc =
         			(_commandToClient)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_commandToClient"), typeof(_commandToClient));
         	}
         
         	 _commandToClientFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeTaggedString(int tag);
         private static _removeTaggedString _removeTaggedStringFunc;
         internal static void removeTaggedString(int tag)
         {
         	if (_removeTaggedStringFunc == null)
         	{
         		_removeTaggedStringFunc =
         			(_removeTaggedString)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_removeTaggedString"), typeof(_removeTaggedString));
         	}
         
         	 _removeTaggedStringFunc(tag);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _addTaggedString([MarshalAs(UnmanagedType.LPWStr)]string str);
         private static _addTaggedString _addTaggedStringFunc;
         internal static IntPtr addTaggedString([MarshalAs(UnmanagedType.LPWStr)]string str)
         {
         	if (_addTaggedStringFunc == null)
         	{
         		_addTaggedStringFunc =
         			(_addTaggedString)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_addTaggedString"), typeof(_addTaggedString));
         	}
         
         	return  _addTaggedStringFunc(str);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getTaggedString([MarshalAs(UnmanagedType.LPWStr)]string tag);
         private static _getTaggedString _getTaggedStringFunc;
         internal static IntPtr getTaggedString([MarshalAs(UnmanagedType.LPWStr)]string tag)
         {
         	if (_getTaggedStringFunc == null)
         	{
         		_getTaggedStringFunc =
         			(_getTaggedString)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getTaggedString"), typeof(_getTaggedString));
         	}
         
         	return  _getTaggedStringFunc(tag);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _buildTaggedString(int argc, string[] argv);
         private static _buildTaggedString _buildTaggedStringFunc;
         internal static IntPtr buildTaggedString(int argc, string[] argv)
         {
         	if (_buildTaggedStringFunc == null)
         	{
         		_buildTaggedStringFunc =
         			(_buildTaggedString)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_buildTaggedString"), typeof(_buildTaggedString));
         	}
         
         	return  _buildTaggedStringFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _queryAllServers(uint lanPort, uint flags, [MarshalAs(UnmanagedType.LPWStr)]string gameType, [MarshalAs(UnmanagedType.LPWStr)]string missionType, uint minPlayers, uint maxPlayers, uint maxBots, uint regionMask, uint maxPing, uint minCPU, uint filterFlags);
         private static _queryAllServers _queryAllServersFunc;
         internal static void queryAllServers(uint lanPort, uint flags, [MarshalAs(UnmanagedType.LPWStr)]string gameType, [MarshalAs(UnmanagedType.LPWStr)]string missionType, uint minPlayers, uint maxPlayers, uint maxBots, uint regionMask, uint maxPing, uint minCPU, uint filterFlags)
         {
         	if (_queryAllServersFunc == null)
         	{
         		_queryAllServersFunc =
         			(_queryAllServers)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_queryAllServers"), typeof(_queryAllServers));
         	}
         
         	 _queryAllServersFunc(lanPort, flags, gameType, missionType, minPlayers, maxPlayers, maxBots, regionMask, maxPing, minCPU, filterFlags);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _queryLanServers(uint lanPort, uint flags, [MarshalAs(UnmanagedType.LPWStr)]string gameType, [MarshalAs(UnmanagedType.LPWStr)]string missionType, uint minPlayers, uint maxPlayers, uint maxBots, uint regionMask, uint maxPing, uint minCPU, uint filterFlags);
         private static _queryLanServers _queryLanServersFunc;
         internal static void queryLanServers(uint lanPort, uint flags, [MarshalAs(UnmanagedType.LPWStr)]string gameType, [MarshalAs(UnmanagedType.LPWStr)]string missionType, uint minPlayers, uint maxPlayers, uint maxBots, uint regionMask, uint maxPing, uint minCPU, uint filterFlags)
         {
         	if (_queryLanServersFunc == null)
         	{
         		_queryLanServersFunc =
         			(_queryLanServers)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_queryLanServers"), typeof(_queryLanServers));
         	}
         
         	 _queryLanServersFunc(lanPort, flags, gameType, missionType, minPlayers, maxPlayers, maxBots, regionMask, maxPing, minCPU, filterFlags);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _queryMasterServer(uint flags, [MarshalAs(UnmanagedType.LPWStr)]string gameType, [MarshalAs(UnmanagedType.LPWStr)]string missionType, uint minPlayers, uint maxPlayers, uint maxBots, uint regionMask, uint maxPing, uint minCPU, uint filterFlags);
         private static _queryMasterServer _queryMasterServerFunc;
         internal static void queryMasterServer(uint flags, [MarshalAs(UnmanagedType.LPWStr)]string gameType, [MarshalAs(UnmanagedType.LPWStr)]string missionType, uint minPlayers, uint maxPlayers, uint maxBots, uint regionMask, uint maxPing, uint minCPU, uint filterFlags)
         {
         	if (_queryMasterServerFunc == null)
         	{
         		_queryMasterServerFunc =
         			(_queryMasterServer)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_queryMasterServer"), typeof(_queryMasterServer));
         	}
         
         	 _queryMasterServerFunc(flags, gameType, missionType, minPlayers, maxPlayers, maxBots, regionMask, maxPing, minCPU, filterFlags);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _querySingleServer([MarshalAs(UnmanagedType.LPWStr)]string addrText, byte flags);
         private static _querySingleServer _querySingleServerFunc;
         internal static void querySingleServer([MarshalAs(UnmanagedType.LPWStr)]string addrText, byte flags)
         {
         	if (_querySingleServerFunc == null)
         	{
         		_querySingleServerFunc =
         			(_querySingleServer)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_querySingleServer"), typeof(_querySingleServer));
         	}
         
         	 _querySingleServerFunc(addrText, flags);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _cancelServerQuery();
         private static _cancelServerQuery _cancelServerQueryFunc;
         internal static void cancelServerQuery()
         {
         	if (_cancelServerQueryFunc == null)
         	{
         		_cancelServerQueryFunc =
         			(_cancelServerQuery)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_cancelServerQuery"), typeof(_cancelServerQuery));
         	}
         
         	 _cancelServerQueryFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _stopServerQuery();
         private static _stopServerQuery _stopServerQueryFunc;
         internal static void stopServerQuery()
         {
         	if (_stopServerQueryFunc == null)
         	{
         		_stopServerQueryFunc =
         			(_stopServerQuery)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_stopServerQuery"), typeof(_stopServerQuery));
         	}
         
         	 _stopServerQueryFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _startHeartbeat();
         private static _startHeartbeat _startHeartbeatFunc;
         internal static void startHeartbeat()
         {
         	if (_startHeartbeatFunc == null)
         	{
         		_startHeartbeatFunc =
         			(_startHeartbeat)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_startHeartbeat"), typeof(_startHeartbeat));
         	}
         
         	 _startHeartbeatFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _stopHeartbeat();
         private static _stopHeartbeat _stopHeartbeatFunc;
         internal static void stopHeartbeat()
         {
         	if (_stopHeartbeatFunc == null)
         	{
         		_stopHeartbeatFunc =
         			(_stopHeartbeat)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_stopHeartbeat"), typeof(_stopHeartbeat));
         	}
         
         	 _stopHeartbeatFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getServerCount();
         private static _getServerCount _getServerCountFunc;
         internal static int getServerCount()
         {
         	if (_getServerCountFunc == null)
         	{
         		_getServerCountFunc =
         			(_getServerCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getServerCount"), typeof(_getServerCount));
         	}
         
         	return  _getServerCountFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setServerInfo(uint index);
         private static _setServerInfo _setServerInfoFunc;
         internal static bool setServerInfo(uint index)
         {
         	if (_setServerInfoFunc == null)
         	{
         		_setServerInfoFunc =
         			(_setServerInfo)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_setServerInfo"), typeof(_setServerInfo));
         	}
         
         	return  _setServerInfoFunc(index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getVersionNumber();
         private static _getVersionNumber _getVersionNumberFunc;
         internal static int getVersionNumber()
         {
         	if (_getVersionNumberFunc == null)
         	{
         		_getVersionNumberFunc =
         			(_getVersionNumber)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getVersionNumber"), typeof(_getVersionNumber));
         	}
         
         	return  _getVersionNumberFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getAppVersionNumber();
         private static _getAppVersionNumber _getAppVersionNumberFunc;
         internal static int getAppVersionNumber()
         {
         	if (_getAppVersionNumberFunc == null)
         	{
         		_getAppVersionNumberFunc =
         			(_getAppVersionNumber)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getAppVersionNumber"), typeof(_getAppVersionNumber));
         	}
         
         	return  _getAppVersionNumberFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getVersionString();
         private static _getVersionString _getVersionStringFunc;
         internal static IntPtr getVersionString()
         {
         	if (_getVersionStringFunc == null)
         	{
         		_getVersionStringFunc =
         			(_getVersionString)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getVersionString"), typeof(_getVersionString));
         	}
         
         	return  _getVersionStringFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getAppVersionString();
         private static _getAppVersionString _getAppVersionStringFunc;
         internal static IntPtr getAppVersionString()
         {
         	if (_getAppVersionStringFunc == null)
         	{
         		_getAppVersionStringFunc =
         			(_getAppVersionString)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getAppVersionString"), typeof(_getAppVersionString));
         	}
         
         	return  _getAppVersionStringFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getEngineName();
         private static _getEngineName _getEngineNameFunc;
         internal static IntPtr getEngineName()
         {
         	if (_getEngineNameFunc == null)
         	{
         		_getEngineNameFunc =
         			(_getEngineName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getEngineName"), typeof(_getEngineName));
         	}
         
         	return  _getEngineNameFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getCompileTimeString();
         private static _getCompileTimeString _getCompileTimeStringFunc;
         internal static IntPtr getCompileTimeString()
         {
         	if (_getCompileTimeStringFunc == null)
         	{
         		_getCompileTimeStringFunc =
         			(_getCompileTimeString)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getCompileTimeString"), typeof(_getCompileTimeString));
         	}
         
         	return  _getCompileTimeStringFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getBuildString();
         private static _getBuildString _getBuildStringFunc;
         internal static IntPtr getBuildString()
         {
         	if (_getBuildStringFunc == null)
         	{
         		_getBuildStringFunc =
         			(_getBuildString)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getBuildString"), typeof(_getBuildString));
         	}
         
         	return  _getBuildStringFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _sfxGetActiveStates();
         private static _sfxGetActiveStates _sfxGetActiveStatesFunc;
         internal static IntPtr sfxGetActiveStates()
         {
         	if (_sfxGetActiveStatesFunc == null)
         	{
         		_sfxGetActiveStatesFunc =
         			(_sfxGetActiveStates)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_sfxGetActiveStates"), typeof(_sfxGetActiveStates));
         	}
         
         	return  _sfxGetActiveStatesFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _sfxGetAvailableDevices();
         private static _sfxGetAvailableDevices _sfxGetAvailableDevicesFunc;
         internal static IntPtr sfxGetAvailableDevices()
         {
         	if (_sfxGetAvailableDevicesFunc == null)
         	{
         		_sfxGetAvailableDevicesFunc =
         			(_sfxGetAvailableDevices)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_sfxGetAvailableDevices"), typeof(_sfxGetAvailableDevices));
         	}
         
         	return  _sfxGetAvailableDevicesFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _sfxCreateDevice([MarshalAs(UnmanagedType.LPWStr)]string provider, [MarshalAs(UnmanagedType.LPWStr)]string device, bool useHardware, int maxBuffers);
         private static _sfxCreateDevice _sfxCreateDeviceFunc;
         internal static bool sfxCreateDevice([MarshalAs(UnmanagedType.LPWStr)]string provider, [MarshalAs(UnmanagedType.LPWStr)]string device, bool useHardware, int maxBuffers)
         {
         	if (_sfxCreateDeviceFunc == null)
         	{
         		_sfxCreateDeviceFunc =
         			(_sfxCreateDevice)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_sfxCreateDevice"), typeof(_sfxCreateDevice));
         	}
         
         	return  _sfxCreateDeviceFunc(provider, device, useHardware, maxBuffers);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sfxDeleteDevice();
         private static _sfxDeleteDevice _sfxDeleteDeviceFunc;
         internal static void sfxDeleteDevice()
         {
         	if (_sfxDeleteDeviceFunc == null)
         	{
         		_sfxDeleteDeviceFunc =
         			(_sfxDeleteDevice)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_sfxDeleteDevice"), typeof(_sfxDeleteDevice));
         	}
         
         	 _sfxDeleteDeviceFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _sfxGetDeviceInfo();
         private static _sfxGetDeviceInfo _sfxGetDeviceInfoFunc;
         internal static IntPtr sfxGetDeviceInfo()
         {
         	if (_sfxGetDeviceInfoFunc == null)
         	{
         		_sfxGetDeviceInfoFunc =
         			(_sfxGetDeviceInfo)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_sfxGetDeviceInfo"), typeof(_sfxGetDeviceInfo));
         	}
         
         	return  _sfxGetDeviceInfoFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _sfxCreateSource([MarshalAs(UnmanagedType.LPWStr)]string sfxType, [MarshalAs(UnmanagedType.LPWStr)]string arg0, [MarshalAs(UnmanagedType.LPWStr)]string arg1, [MarshalAs(UnmanagedType.LPWStr)]string arg2, [MarshalAs(UnmanagedType.LPWStr)]string arg3);
         private static _sfxCreateSource _sfxCreateSourceFunc;
         internal static int sfxCreateSource([MarshalAs(UnmanagedType.LPWStr)]string sfxType, [MarshalAs(UnmanagedType.LPWStr)]string arg0, [MarshalAs(UnmanagedType.LPWStr)]string arg1, [MarshalAs(UnmanagedType.LPWStr)]string arg2, [MarshalAs(UnmanagedType.LPWStr)]string arg3)
         {
         	if (_sfxCreateSourceFunc == null)
         	{
         		_sfxCreateSourceFunc =
         			(_sfxCreateSource)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_sfxCreateSource"), typeof(_sfxCreateSource));
         	}
         
         	return  _sfxCreateSourceFunc(sfxType, arg0, arg1, arg2, arg3);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _sfxPlay([MarshalAs(UnmanagedType.LPWStr)]string trackName, [MarshalAs(UnmanagedType.LPWStr)]string pointOrX, [MarshalAs(UnmanagedType.LPWStr)]string y, [MarshalAs(UnmanagedType.LPWStr)]string z);
         private static _sfxPlay _sfxPlayFunc;
         internal static int sfxPlay([MarshalAs(UnmanagedType.LPWStr)]string trackName, [MarshalAs(UnmanagedType.LPWStr)]string pointOrX, [MarshalAs(UnmanagedType.LPWStr)]string y, [MarshalAs(UnmanagedType.LPWStr)]string z)
         {
         	if (_sfxPlayFunc == null)
         	{
         		_sfxPlayFunc =
         			(_sfxPlay)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_sfxPlay"), typeof(_sfxPlay));
         	}
         
         	return  _sfxPlayFunc(trackName, pointOrX, y, z);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _sfxPlayOnce([MarshalAs(UnmanagedType.LPWStr)]string sfxType, [MarshalAs(UnmanagedType.LPWStr)]string arg0, [MarshalAs(UnmanagedType.LPWStr)]string arg1, [MarshalAs(UnmanagedType.LPWStr)]string arg2, [MarshalAs(UnmanagedType.LPWStr)]string arg3, [MarshalAs(UnmanagedType.LPWStr)]string arg4);
         private static _sfxPlayOnce _sfxPlayOnceFunc;
         internal static int sfxPlayOnce([MarshalAs(UnmanagedType.LPWStr)]string sfxType, [MarshalAs(UnmanagedType.LPWStr)]string arg0, [MarshalAs(UnmanagedType.LPWStr)]string arg1, [MarshalAs(UnmanagedType.LPWStr)]string arg2, [MarshalAs(UnmanagedType.LPWStr)]string arg3, [MarshalAs(UnmanagedType.LPWStr)]string arg4)
         {
         	if (_sfxPlayOnceFunc == null)
         	{
         		_sfxPlayOnceFunc =
         			(_sfxPlayOnce)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_sfxPlayOnce"), typeof(_sfxPlayOnce));
         	}
         
         	return  _sfxPlayOnceFunc(sfxType, arg0, arg1, arg2, arg3, arg4);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sfxStop(IntPtr source);
         private static _sfxStop _sfxStopFunc;
         internal static void sfxStop(IntPtr source)
         {
         	if (_sfxStopFunc == null)
         	{
         		_sfxStopFunc =
         			(_sfxStop)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_sfxStop"), typeof(_sfxStop));
         	}
         
         	 _sfxStopFunc(source);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sfxStopAndDelete(IntPtr source);
         private static _sfxStopAndDelete _sfxStopAndDeleteFunc;
         internal static void sfxStopAndDelete(IntPtr source)
         {
         	if (_sfxStopAndDeleteFunc == null)
         	{
         		_sfxStopAndDeleteFunc =
         			(_sfxStopAndDelete)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_sfxStopAndDelete"), typeof(_sfxStopAndDelete));
         	}
         
         	 _sfxStopAndDeleteFunc(source);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sfxDeleteWhenStopped(IntPtr source);
         private static _sfxDeleteWhenStopped _sfxDeleteWhenStoppedFunc;
         internal static void sfxDeleteWhenStopped(IntPtr source)
         {
         	if (_sfxDeleteWhenStoppedFunc == null)
         	{
         		_sfxDeleteWhenStoppedFunc =
         			(_sfxDeleteWhenStopped)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_sfxDeleteWhenStopped"), typeof(_sfxDeleteWhenStopped));
         	}
         
         	 _sfxDeleteWhenStoppedFunc(source);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate SFXDistanceModel _sfxGetDistanceModel();
         private static _sfxGetDistanceModel _sfxGetDistanceModelFunc;
         internal static SFXDistanceModel sfxGetDistanceModel()
         {
         	if (_sfxGetDistanceModelFunc == null)
         	{
         		_sfxGetDistanceModelFunc =
         			(_sfxGetDistanceModel)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_sfxGetDistanceModel"), typeof(_sfxGetDistanceModel));
         	}
         
         	return  _sfxGetDistanceModelFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sfxSetDistanceModel(SFXDistanceModel model);
         private static _sfxSetDistanceModel _sfxSetDistanceModelFunc;
         internal static void sfxSetDistanceModel(SFXDistanceModel model)
         {
         	if (_sfxSetDistanceModelFunc == null)
         	{
         		_sfxSetDistanceModelFunc =
         			(_sfxSetDistanceModel)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_sfxSetDistanceModel"), typeof(_sfxSetDistanceModel));
         	}
         
         	 _sfxSetDistanceModelFunc(model);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _sfxGetDopplerFactor();
         private static _sfxGetDopplerFactor _sfxGetDopplerFactorFunc;
         internal static float sfxGetDopplerFactor()
         {
         	if (_sfxGetDopplerFactorFunc == null)
         	{
         		_sfxGetDopplerFactorFunc =
         			(_sfxGetDopplerFactor)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_sfxGetDopplerFactor"), typeof(_sfxGetDopplerFactor));
         	}
         
         	return  _sfxGetDopplerFactorFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sfxSetDopplerFactor(float value);
         private static _sfxSetDopplerFactor _sfxSetDopplerFactorFunc;
         internal static void sfxSetDopplerFactor(float value)
         {
         	if (_sfxSetDopplerFactorFunc == null)
         	{
         		_sfxSetDopplerFactorFunc =
         			(_sfxSetDopplerFactor)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_sfxSetDopplerFactor"), typeof(_sfxSetDopplerFactor));
         	}
         
         	 _sfxSetDopplerFactorFunc(value);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _sfxGetRolloffFactor();
         private static _sfxGetRolloffFactor _sfxGetRolloffFactorFunc;
         internal static float sfxGetRolloffFactor()
         {
         	if (_sfxGetRolloffFactorFunc == null)
         	{
         		_sfxGetRolloffFactorFunc =
         			(_sfxGetRolloffFactor)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_sfxGetRolloffFactor"), typeof(_sfxGetRolloffFactor));
         	}
         
         	return  _sfxGetRolloffFactorFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sfxSetRolloffFactor(float value);
         private static _sfxSetRolloffFactor _sfxSetRolloffFactorFunc;
         internal static void sfxSetRolloffFactor(float value)
         {
         	if (_sfxSetRolloffFactorFunc == null)
         	{
         		_sfxSetRolloffFactorFunc =
         			(_sfxSetRolloffFactor)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_sfxSetRolloffFactor"), typeof(_sfxSetRolloffFactor));
         	}
         
         	 _sfxSetRolloffFactorFunc(value);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sfxDumpSources(bool includeGroups);
         private static _sfxDumpSources _sfxDumpSourcesFunc;
         internal static void sfxDumpSources(bool includeGroups)
         {
         	if (_sfxDumpSourcesFunc == null)
         	{
         		_sfxDumpSourcesFunc =
         			(_sfxDumpSources)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_sfxDumpSources"), typeof(_sfxDumpSources));
         	}
         
         	 _sfxDumpSourcesFunc(includeGroups);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _sfxDumpSourcesToString(bool includeGroups);
         private static _sfxDumpSourcesToString _sfxDumpSourcesToStringFunc;
         internal static IntPtr sfxDumpSourcesToString(bool includeGroups)
         {
         	if (_sfxDumpSourcesToStringFunc == null)
         	{
         		_sfxDumpSourcesToStringFunc =
         			(_sfxDumpSourcesToString)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_sfxDumpSourcesToString"), typeof(_sfxDumpSourcesToString));
         	}
         
         	return  _sfxDumpSourcesToStringFunc(includeGroups);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _cls();
         private static _cls _clsFunc;
         internal static void cls()
         {
         	if (_clsFunc == null)
         	{
         		_clsFunc =
         			(_cls)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_cls"), typeof(_cls));
         	}
         
         	 _clsFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getClipboard();
         private static _getClipboard _getClipboardFunc;
         internal static IntPtr getClipboard()
         {
         	if (_getClipboardFunc == null)
         	{
         		_getClipboardFunc =
         			(_getClipboard)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getClipboard"), typeof(_getClipboard));
         	}
         
         	return  _getClipboardFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setClipboard([MarshalAs(UnmanagedType.LPWStr)]string text);
         private static _setClipboard _setClipboardFunc;
         internal static bool setClipboard([MarshalAs(UnmanagedType.LPWStr)]string text)
         {
         	if (_setClipboardFunc == null)
         	{
         		_setClipboardFunc =
         			(_setClipboard)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_setClipboard"), typeof(_setClipboard));
         	}
         
         	return  _setClipboardFunc(text);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _log([MarshalAs(UnmanagedType.LPWStr)]string message);
         private static _log _logFunc;
         internal static void log([MarshalAs(UnmanagedType.LPWStr)]string message)
         {
         	if (_logFunc == null)
         	{
         		_logFunc =
         			(_log)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_log"), typeof(_log));
         	}
         
         	 _logFunc(message);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _logError([MarshalAs(UnmanagedType.LPWStr)]string message);
         private static _logError _logErrorFunc;
         internal static void logError([MarshalAs(UnmanagedType.LPWStr)]string message)
         {
         	if (_logErrorFunc == null)
         	{
         		_logErrorFunc =
         			(_logError)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_logError"), typeof(_logError));
         	}
         
         	 _logErrorFunc(message);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _logWarning([MarshalAs(UnmanagedType.LPWStr)]string message);
         private static _logWarning _logWarningFunc;
         internal static void logWarning([MarshalAs(UnmanagedType.LPWStr)]string message)
         {
         	if (_logWarningFunc == null)
         	{
         		_logWarningFunc =
         			(_logWarning)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_logWarning"), typeof(_logWarning));
         	}
         
         	 _logWarningFunc(message);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _dumpConsoleClasses(bool dumpScript, bool dumpEngine);
         private static _dumpConsoleClasses _dumpConsoleClassesFunc;
         internal static void dumpConsoleClasses(bool dumpScript, bool dumpEngine)
         {
         	if (_dumpConsoleClassesFunc == null)
         	{
         		_dumpConsoleClassesFunc =
         			(_dumpConsoleClasses)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_dumpConsoleClasses"), typeof(_dumpConsoleClasses));
         	}
         
         	 _dumpConsoleClassesFunc(dumpScript, dumpEngine);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _dumpConsoleFunctions(bool dumpScript, bool dumpEngine);
         private static _dumpConsoleFunctions _dumpConsoleFunctionsFunc;
         internal static void dumpConsoleFunctions(bool dumpScript, bool dumpEngine)
         {
         	if (_dumpConsoleFunctionsFunc == null)
         	{
         		_dumpConsoleFunctionsFunc =
         			(_dumpConsoleFunctions)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_dumpConsoleFunctions"), typeof(_dumpConsoleFunctions));
         	}
         
         	 _dumpConsoleFunctionsFunc(dumpScript, dumpEngine);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _strasc([MarshalAs(UnmanagedType.LPWStr)]string chr);
         private static _strasc _strascFunc;
         internal static int strasc([MarshalAs(UnmanagedType.LPWStr)]string chr)
         {
         	if (_strascFunc == null)
         	{
         		_strascFunc =
         			(_strasc)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_strasc"), typeof(_strasc));
         	}
         
         	return  _strascFunc(chr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _strformat([MarshalAs(UnmanagedType.LPWStr)]string format, [MarshalAs(UnmanagedType.LPWStr)]string value);
         private static _strformat _strformatFunc;
         internal static IntPtr strformat([MarshalAs(UnmanagedType.LPWStr)]string format, [MarshalAs(UnmanagedType.LPWStr)]string value)
         {
         	if (_strformatFunc == null)
         	{
         		_strformatFunc =
         			(_strformat)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_strformat"), typeof(_strformat));
         	}
         
         	return  _strformatFunc(format, value);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _strcmp([MarshalAs(UnmanagedType.LPWStr)]string str1, [MarshalAs(UnmanagedType.LPWStr)]string str2);
         private static _strcmp _strcmpFunc;
         internal static int strcmp([MarshalAs(UnmanagedType.LPWStr)]string str1, [MarshalAs(UnmanagedType.LPWStr)]string str2)
         {
         	if (_strcmpFunc == null)
         	{
         		_strcmpFunc =
         			(_strcmp)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_strcmp"), typeof(_strcmp));
         	}
         
         	return  _strcmpFunc(str1, str2);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _stricmp([MarshalAs(UnmanagedType.LPWStr)]string str1, [MarshalAs(UnmanagedType.LPWStr)]string str2);
         private static _stricmp _stricmpFunc;
         internal static int stricmp([MarshalAs(UnmanagedType.LPWStr)]string str1, [MarshalAs(UnmanagedType.LPWStr)]string str2)
         {
         	if (_stricmpFunc == null)
         	{
         		_stricmpFunc =
         			(_stricmp)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_stricmp"), typeof(_stricmp));
         	}
         
         	return  _stricmpFunc(str1, str2);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _strnatcmp([MarshalAs(UnmanagedType.LPWStr)]string str1, [MarshalAs(UnmanagedType.LPWStr)]string str2);
         private static _strnatcmp _strnatcmpFunc;
         internal static int strnatcmp([MarshalAs(UnmanagedType.LPWStr)]string str1, [MarshalAs(UnmanagedType.LPWStr)]string str2)
         {
         	if (_strnatcmpFunc == null)
         	{
         		_strnatcmpFunc =
         			(_strnatcmp)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_strnatcmp"), typeof(_strnatcmp));
         	}
         
         	return  _strnatcmpFunc(str1, str2);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _strinatcmp([MarshalAs(UnmanagedType.LPWStr)]string str1, [MarshalAs(UnmanagedType.LPWStr)]string str2);
         private static _strinatcmp _strinatcmpFunc;
         internal static int strinatcmp([MarshalAs(UnmanagedType.LPWStr)]string str1, [MarshalAs(UnmanagedType.LPWStr)]string str2)
         {
         	if (_strinatcmpFunc == null)
         	{
         		_strinatcmpFunc =
         			(_strinatcmp)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_strinatcmp"), typeof(_strinatcmp));
         	}
         
         	return  _strinatcmpFunc(str1, str2);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _strlen([MarshalAs(UnmanagedType.LPWStr)]string str);
         private static _strlen _strlenFunc;
         internal static int strlen([MarshalAs(UnmanagedType.LPWStr)]string str)
         {
         	if (_strlenFunc == null)
         	{
         		_strlenFunc =
         			(_strlen)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_strlen"), typeof(_strlen));
         	}
         
         	return  _strlenFunc(str);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _strlenskip([MarshalAs(UnmanagedType.LPWStr)]string str, [MarshalAs(UnmanagedType.LPWStr)]string first, [MarshalAs(UnmanagedType.LPWStr)]string last);
         private static _strlenskip _strlenskipFunc;
         internal static int strlenskip([MarshalAs(UnmanagedType.LPWStr)]string str, [MarshalAs(UnmanagedType.LPWStr)]string first, [MarshalAs(UnmanagedType.LPWStr)]string last)
         {
         	if (_strlenskipFunc == null)
         	{
         		_strlenskipFunc =
         			(_strlenskip)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_strlenskip"), typeof(_strlenskip));
         	}
         
         	return  _strlenskipFunc(str, first, last);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _strstr([MarshalAs(UnmanagedType.LPWStr)]string _string, [MarshalAs(UnmanagedType.LPWStr)]string substring);
         private static _strstr _strstrFunc;
         internal static int strstr([MarshalAs(UnmanagedType.LPWStr)]string _string, [MarshalAs(UnmanagedType.LPWStr)]string substring)
         {
         	if (_strstrFunc == null)
         	{
         		_strstrFunc =
         			(_strstr)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_strstr"), typeof(_strstr));
         	}
         
         	return  _strstrFunc(_string, substring);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _strpos([MarshalAs(UnmanagedType.LPWStr)]string haystack, [MarshalAs(UnmanagedType.LPWStr)]string needle, int offset);
         private static _strpos _strposFunc;
         internal static int strpos([MarshalAs(UnmanagedType.LPWStr)]string haystack, [MarshalAs(UnmanagedType.LPWStr)]string needle, int offset)
         {
         	if (_strposFunc == null)
         	{
         		_strposFunc =
         			(_strpos)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_strpos"), typeof(_strpos));
         	}
         
         	return  _strposFunc(haystack, needle, offset);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _strposr([MarshalAs(UnmanagedType.LPWStr)]string haystack, [MarshalAs(UnmanagedType.LPWStr)]string needle, int offset);
         private static _strposr _strposrFunc;
         internal static int strposr([MarshalAs(UnmanagedType.LPWStr)]string haystack, [MarshalAs(UnmanagedType.LPWStr)]string needle, int offset)
         {
         	if (_strposrFunc == null)
         	{
         		_strposrFunc =
         			(_strposr)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_strposr"), typeof(_strposr));
         	}
         
         	return  _strposrFunc(haystack, needle, offset);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ltrim([MarshalAs(UnmanagedType.LPWStr)]string str);
         private static _ltrim _ltrimFunc;
         internal static IntPtr ltrim([MarshalAs(UnmanagedType.LPWStr)]string str)
         {
         	if (_ltrimFunc == null)
         	{
         		_ltrimFunc =
         			(_ltrim)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ltrim"), typeof(_ltrim));
         	}
         
         	return  _ltrimFunc(str);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _rtrim([MarshalAs(UnmanagedType.LPWStr)]string str);
         private static _rtrim _rtrimFunc;
         internal static IntPtr rtrim([MarshalAs(UnmanagedType.LPWStr)]string str)
         {
         	if (_rtrimFunc == null)
         	{
         		_rtrimFunc =
         			(_rtrim)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_rtrim"), typeof(_rtrim));
         	}
         
         	return  _rtrimFunc(str);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _trim([MarshalAs(UnmanagedType.LPWStr)]string str);
         private static _trim _trimFunc;
         internal static IntPtr trim([MarshalAs(UnmanagedType.LPWStr)]string str)
         {
         	if (_trimFunc == null)
         	{
         		_trimFunc =
         			(_trim)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_trim"), typeof(_trim));
         	}
         
         	return  _trimFunc(str);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _stripChars([MarshalAs(UnmanagedType.LPWStr)]string str, [MarshalAs(UnmanagedType.LPWStr)]string chars);
         private static _stripChars _stripCharsFunc;
         internal static IntPtr stripChars([MarshalAs(UnmanagedType.LPWStr)]string str, [MarshalAs(UnmanagedType.LPWStr)]string chars)
         {
         	if (_stripCharsFunc == null)
         	{
         		_stripCharsFunc =
         			(_stripChars)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_stripChars"), typeof(_stripChars));
         	}
         
         	return  _stripCharsFunc(str, chars);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _strlwr([MarshalAs(UnmanagedType.LPWStr)]string str);
         private static _strlwr _strlwrFunc;
         internal static IntPtr strlwr([MarshalAs(UnmanagedType.LPWStr)]string str)
         {
         	if (_strlwrFunc == null)
         	{
         		_strlwrFunc =
         			(_strlwr)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_strlwr"), typeof(_strlwr));
         	}
         
         	return  _strlwrFunc(str);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _strupr([MarshalAs(UnmanagedType.LPWStr)]string str);
         private static _strupr _struprFunc;
         internal static IntPtr strupr([MarshalAs(UnmanagedType.LPWStr)]string str)
         {
         	if (_struprFunc == null)
         	{
         		_struprFunc =
         			(_strupr)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_strupr"), typeof(_strupr));
         	}
         
         	return  _struprFunc(str);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _strchr([MarshalAs(UnmanagedType.LPWStr)]string str, [MarshalAs(UnmanagedType.LPWStr)]string chr);
         private static _strchr _strchrFunc;
         internal static IntPtr strchr([MarshalAs(UnmanagedType.LPWStr)]string str, [MarshalAs(UnmanagedType.LPWStr)]string chr)
         {
         	if (_strchrFunc == null)
         	{
         		_strchrFunc =
         			(_strchr)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_strchr"), typeof(_strchr));
         	}
         
         	return  _strchrFunc(str, chr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _strrchr([MarshalAs(UnmanagedType.LPWStr)]string str, [MarshalAs(UnmanagedType.LPWStr)]string chr);
         private static _strrchr _strrchrFunc;
         internal static IntPtr strrchr([MarshalAs(UnmanagedType.LPWStr)]string str, [MarshalAs(UnmanagedType.LPWStr)]string chr)
         {
         	if (_strrchrFunc == null)
         	{
         		_strrchrFunc =
         			(_strrchr)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_strrchr"), typeof(_strrchr));
         	}
         
         	return  _strrchrFunc(str, chr);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _strreplace([MarshalAs(UnmanagedType.LPWStr)]string source, [MarshalAs(UnmanagedType.LPWStr)]string from, [MarshalAs(UnmanagedType.LPWStr)]string to);
         private static _strreplace _strreplaceFunc;
         internal static IntPtr strreplace([MarshalAs(UnmanagedType.LPWStr)]string source, [MarshalAs(UnmanagedType.LPWStr)]string from, [MarshalAs(UnmanagedType.LPWStr)]string to)
         {
         	if (_strreplaceFunc == null)
         	{
         		_strreplaceFunc =
         			(_strreplace)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_strreplace"), typeof(_strreplace));
         	}
         
         	return  _strreplaceFunc(source, from, to);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _strrepeat([MarshalAs(UnmanagedType.LPWStr)]string str, int numTimes, [MarshalAs(UnmanagedType.LPWStr)]string delimiter);
         private static _strrepeat _strrepeatFunc;
         internal static IntPtr strrepeat([MarshalAs(UnmanagedType.LPWStr)]string str, int numTimes, [MarshalAs(UnmanagedType.LPWStr)]string delimiter)
         {
         	if (_strrepeatFunc == null)
         	{
         		_strrepeatFunc =
         			(_strrepeat)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_strrepeat"), typeof(_strrepeat));
         	}
         
         	return  _strrepeatFunc(str, numTimes, delimiter);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getSubStr([MarshalAs(UnmanagedType.LPWStr)]string str, int start, int numChars);
         private static _getSubStr _getSubStrFunc;
         internal static IntPtr getSubStr([MarshalAs(UnmanagedType.LPWStr)]string str, int start, int numChars)
         {
         	if (_getSubStrFunc == null)
         	{
         		_getSubStrFunc =
         			(_getSubStr)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getSubStr"), typeof(_getSubStr));
         	}
         
         	return  _getSubStrFunc(str, start, numChars);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _strIsMatchExpr([MarshalAs(UnmanagedType.LPWStr)]string pattern, [MarshalAs(UnmanagedType.LPWStr)]string str, bool caseSensitive);
         private static _strIsMatchExpr _strIsMatchExprFunc;
         internal static bool strIsMatchExpr([MarshalAs(UnmanagedType.LPWStr)]string pattern, [MarshalAs(UnmanagedType.LPWStr)]string str, bool caseSensitive)
         {
         	if (_strIsMatchExprFunc == null)
         	{
         		_strIsMatchExprFunc =
         			(_strIsMatchExpr)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_strIsMatchExpr"), typeof(_strIsMatchExpr));
         	}
         
         	return  _strIsMatchExprFunc(pattern, str, caseSensitive);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _strIsMatchMultipleExpr([MarshalAs(UnmanagedType.LPWStr)]string patterns, [MarshalAs(UnmanagedType.LPWStr)]string str, bool caseSensitive);
         private static _strIsMatchMultipleExpr _strIsMatchMultipleExprFunc;
         internal static bool strIsMatchMultipleExpr([MarshalAs(UnmanagedType.LPWStr)]string patterns, [MarshalAs(UnmanagedType.LPWStr)]string str, bool caseSensitive)
         {
         	if (_strIsMatchMultipleExprFunc == null)
         	{
         		_strIsMatchMultipleExprFunc =
         			(_strIsMatchMultipleExpr)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_strIsMatchMultipleExpr"), typeof(_strIsMatchMultipleExpr));
         	}
         
         	return  _strIsMatchMultipleExprFunc(patterns, str, caseSensitive);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getTrailingNumber([MarshalAs(UnmanagedType.LPWStr)]string str);
         private static _getTrailingNumber _getTrailingNumberFunc;
         internal static int getTrailingNumber([MarshalAs(UnmanagedType.LPWStr)]string str)
         {
         	if (_getTrailingNumberFunc == null)
         	{
         		_getTrailingNumberFunc =
         			(_getTrailingNumber)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getTrailingNumber"), typeof(_getTrailingNumber));
         	}
         
         	return  _getTrailingNumberFunc(str);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _stripTrailingNumber([MarshalAs(UnmanagedType.LPWStr)]string str);
         private static _stripTrailingNumber _stripTrailingNumberFunc;
         internal static IntPtr stripTrailingNumber([MarshalAs(UnmanagedType.LPWStr)]string str)
         {
         	if (_stripTrailingNumberFunc == null)
         	{
         		_stripTrailingNumberFunc =
         			(_stripTrailingNumber)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_stripTrailingNumber"), typeof(_stripTrailingNumber));
         	}
         
         	return  _stripTrailingNumberFunc(str);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getFirstNumber([MarshalAs(UnmanagedType.LPWStr)]string str);
         private static _getFirstNumber _getFirstNumberFunc;
         internal static IntPtr getFirstNumber([MarshalAs(UnmanagedType.LPWStr)]string str)
         {
         	if (_getFirstNumberFunc == null)
         	{
         		_getFirstNumberFunc =
         			(_getFirstNumber)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getFirstNumber"), typeof(_getFirstNumber));
         	}
         
         	return  _getFirstNumberFunc(str);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isspace([MarshalAs(UnmanagedType.LPWStr)]string str, int index);
         private static _isspace _isspaceFunc;
         internal static bool isspace([MarshalAs(UnmanagedType.LPWStr)]string str, int index)
         {
         	if (_isspaceFunc == null)
         	{
         		_isspaceFunc =
         			(_isspace)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_isspace"), typeof(_isspace));
         	}
         
         	return  _isspaceFunc(str, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isalnum([MarshalAs(UnmanagedType.LPWStr)]string str, int index);
         private static _isalnum _isalnumFunc;
         internal static bool isalnum([MarshalAs(UnmanagedType.LPWStr)]string str, int index)
         {
         	if (_isalnumFunc == null)
         	{
         		_isalnumFunc =
         			(_isalnum)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_isalnum"), typeof(_isalnum));
         	}
         
         	return  _isalnumFunc(str, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _startsWith([MarshalAs(UnmanagedType.LPWStr)]string str, [MarshalAs(UnmanagedType.LPWStr)]string prefix, bool caseSensitive);
         private static _startsWith _startsWithFunc;
         internal static bool startsWith([MarshalAs(UnmanagedType.LPWStr)]string str, [MarshalAs(UnmanagedType.LPWStr)]string prefix, bool caseSensitive)
         {
         	if (_startsWithFunc == null)
         	{
         		_startsWithFunc =
         			(_startsWith)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_startsWith"), typeof(_startsWith));
         	}
         
         	return  _startsWithFunc(str, prefix, caseSensitive);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _endsWith([MarshalAs(UnmanagedType.LPWStr)]string str, [MarshalAs(UnmanagedType.LPWStr)]string suffix, bool caseSensitive);
         private static _endsWith _endsWithFunc;
         internal static bool endsWith([MarshalAs(UnmanagedType.LPWStr)]string str, [MarshalAs(UnmanagedType.LPWStr)]string suffix, bool caseSensitive)
         {
         	if (_endsWithFunc == null)
         	{
         		_endsWithFunc =
         			(_endsWith)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_endsWith"), typeof(_endsWith));
         	}
         
         	return  _endsWithFunc(str, suffix, caseSensitive);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _strchrpos([MarshalAs(UnmanagedType.LPWStr)]string str, [MarshalAs(UnmanagedType.LPWStr)]string chr, int start);
         private static _strchrpos _strchrposFunc;
         internal static int strchrpos([MarshalAs(UnmanagedType.LPWStr)]string str, [MarshalAs(UnmanagedType.LPWStr)]string chr, int start)
         {
         	if (_strchrposFunc == null)
         	{
         		_strchrposFunc =
         			(_strchrpos)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_strchrpos"), typeof(_strchrpos));
         	}
         
         	return  _strchrposFunc(str, chr, start);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _strrchrpos([MarshalAs(UnmanagedType.LPWStr)]string str, [MarshalAs(UnmanagedType.LPWStr)]string chr, int start);
         private static _strrchrpos _strrchrposFunc;
         internal static int strrchrpos([MarshalAs(UnmanagedType.LPWStr)]string str, [MarshalAs(UnmanagedType.LPWStr)]string chr, int start)
         {
         	if (_strrchrposFunc == null)
         	{
         		_strrchrposFunc =
         			(_strrchrpos)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_strrchrpos"), typeof(_strrchrpos));
         	}
         
         	return  _strrchrposFunc(str, chr, start);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalColorIStruct _ColorFloatToInt(InternalColorFStruct color);
         private static _ColorFloatToInt _ColorFloatToIntFunc;
         internal static InternalColorIStruct ColorFloatToInt(InternalColorFStruct color)
         {
         	if (_ColorFloatToIntFunc == null)
         	{
         		_ColorFloatToIntFunc =
         			(_ColorFloatToInt)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ColorFloatToInt"), typeof(_ColorFloatToInt));
         	}
         
         	return  _ColorFloatToIntFunc(color);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalColorFStruct _ColorIntToFloat(InternalColorIStruct color);
         private static _ColorIntToFloat _ColorIntToFloatFunc;
         internal static InternalColorFStruct ColorIntToFloat(InternalColorIStruct color)
         {
         	if (_ColorIntToFloatFunc == null)
         	{
         		_ColorIntToFloatFunc =
         			(_ColorIntToFloat)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ColorIntToFloat"), typeof(_ColorIntToFloat));
         	}
         
         	return  _ColorIntToFloatFunc(color);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ColorRGBToHEX(InternalColorIStruct color);
         private static _ColorRGBToHEX _ColorRGBToHEXFunc;
         internal static IntPtr ColorRGBToHEX(InternalColorIStruct color)
         {
         	if (_ColorRGBToHEXFunc == null)
         	{
         		_ColorRGBToHEXFunc =
         			(_ColorRGBToHEX)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ColorRGBToHEX"), typeof(_ColorRGBToHEX));
         	}
         
         	return  _ColorRGBToHEXFunc(color);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _ColorRGBToHSB(InternalColorIStruct color);
         private static _ColorRGBToHSB _ColorRGBToHSBFunc;
         internal static IntPtr ColorRGBToHSB(InternalColorIStruct color)
         {
         	if (_ColorRGBToHSBFunc == null)
         	{
         		_ColorRGBToHSBFunc =
         			(_ColorRGBToHSB)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ColorRGBToHSB"), typeof(_ColorRGBToHSB));
         	}
         
         	return  _ColorRGBToHSBFunc(color);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalColorIStruct _ColorHEXToRGB([MarshalAs(UnmanagedType.LPWStr)]string hex);
         private static _ColorHEXToRGB _ColorHEXToRGBFunc;
         internal static InternalColorIStruct ColorHEXToRGB([MarshalAs(UnmanagedType.LPWStr)]string hex)
         {
         	if (_ColorHEXToRGBFunc == null)
         	{
         		_ColorHEXToRGBFunc =
         			(_ColorHEXToRGB)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ColorHEXToRGB"), typeof(_ColorHEXToRGB));
         	}
         
         	return  _ColorHEXToRGBFunc(hex);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalColorIStruct _ColorHSBToRGB(int[] hsb);
         private static _ColorHSBToRGB _ColorHSBToRGBFunc;
         internal static InternalColorIStruct ColorHSBToRGB(int[] hsb)
         {
         	if (_ColorHSBToRGBFunc == null)
         	{
         		_ColorHSBToRGBFunc =
         			(_ColorHSBToRGB)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ColorHSBToRGB"), typeof(_ColorHSBToRGB));
         	}
         
         	return  _ColorHSBToRGBFunc(hsb);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _strToggleCaseToWords([MarshalAs(UnmanagedType.LPWStr)]string str);
         private static _strToggleCaseToWords _strToggleCaseToWordsFunc;
         internal static IntPtr strToggleCaseToWords([MarshalAs(UnmanagedType.LPWStr)]string str)
         {
         	if (_strToggleCaseToWordsFunc == null)
         	{
         		_strToggleCaseToWordsFunc =
         			(_strToggleCaseToWords)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_strToggleCaseToWords"), typeof(_strToggleCaseToWords));
         	}
         
         	return  _strToggleCaseToWordsFunc(str);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isInt([MarshalAs(UnmanagedType.LPWStr)]string str);
         private static _isInt _isIntFunc;
         internal static bool isInt([MarshalAs(UnmanagedType.LPWStr)]string str)
         {
         	if (_isIntFunc == null)
         	{
         		_isIntFunc =
         			(_isInt)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_isInt"), typeof(_isInt));
         	}
         
         	return  _isIntFunc(str);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isFloat([MarshalAs(UnmanagedType.LPWStr)]string str, bool sciOk);
         private static _isFloat _isFloatFunc;
         internal static bool isFloat([MarshalAs(UnmanagedType.LPWStr)]string str, bool sciOk)
         {
         	if (_isFloatFunc == null)
         	{
         		_isFloatFunc =
         			(_isFloat)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_isFloat"), typeof(_isFloat));
         	}
         
         	return  _isFloatFunc(str, sciOk);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isValidPort([MarshalAs(UnmanagedType.LPWStr)]string str);
         private static _isValidPort _isValidPortFunc;
         internal static bool isValidPort([MarshalAs(UnmanagedType.LPWStr)]string str)
         {
         	if (_isValidPortFunc == null)
         	{
         		_isValidPortFunc =
         			(_isValidPort)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_isValidPort"), typeof(_isValidPort));
         	}
         
         	return  _isValidPortFunc(str);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isValidIP([MarshalAs(UnmanagedType.LPWStr)]string str);
         private static _isValidIP _isValidIPFunc;
         internal static bool isValidIP([MarshalAs(UnmanagedType.LPWStr)]string str)
         {
         	if (_isValidIPFunc == null)
         	{
         		_isValidIPFunc =
         			(_isValidIP)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_isValidIP"), typeof(_isValidIP));
         	}
         
         	return  _isValidIPFunc(str);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addCaseSensitiveStrings(int argc, string[] argv);
         private static _addCaseSensitiveStrings _addCaseSensitiveStringsFunc;
         internal static void addCaseSensitiveStrings(int argc, string[] argv)
         {
         	if (_addCaseSensitiveStringsFunc == null)
         	{
         		_addCaseSensitiveStringsFunc =
         			(_addCaseSensitiveStrings)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_addCaseSensitiveStrings"), typeof(_addCaseSensitiveStrings));
         	}
         
         	 _addCaseSensitiveStringsFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getWord([MarshalAs(UnmanagedType.LPWStr)]string text, int index);
         private static _getWord _getWordFunc;
         internal static IntPtr getWord([MarshalAs(UnmanagedType.LPWStr)]string text, int index)
         {
         	if (_getWordFunc == null)
         	{
         		_getWordFunc =
         			(_getWord)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getWord"), typeof(_getWord));
         	}
         
         	return  _getWordFunc(text, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getWords([MarshalAs(UnmanagedType.LPWStr)]string text, int startIndex, int endIndex);
         private static _getWords _getWordsFunc;
         internal static IntPtr getWords([MarshalAs(UnmanagedType.LPWStr)]string text, int startIndex, int endIndex)
         {
         	if (_getWordsFunc == null)
         	{
         		_getWordsFunc =
         			(_getWords)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getWords"), typeof(_getWords));
         	}
         
         	return  _getWordsFunc(text, startIndex, endIndex);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _setWord([MarshalAs(UnmanagedType.LPWStr)]string text, int index, [MarshalAs(UnmanagedType.LPWStr)]string replacement);
         private static _setWord _setWordFunc;
         internal static IntPtr setWord([MarshalAs(UnmanagedType.LPWStr)]string text, int index, [MarshalAs(UnmanagedType.LPWStr)]string replacement)
         {
         	if (_setWordFunc == null)
         	{
         		_setWordFunc =
         			(_setWord)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_setWord"), typeof(_setWord));
         	}
         
         	return  _setWordFunc(text, index, replacement);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _removeWord([MarshalAs(UnmanagedType.LPWStr)]string text, int index);
         private static _removeWord _removeWordFunc;
         internal static IntPtr removeWord([MarshalAs(UnmanagedType.LPWStr)]string text, int index)
         {
         	if (_removeWordFunc == null)
         	{
         		_removeWordFunc =
         			(_removeWord)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_removeWord"), typeof(_removeWord));
         	}
         
         	return  _removeWordFunc(text, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getWordCount([MarshalAs(UnmanagedType.LPWStr)]string text);
         private static _getWordCount _getWordCountFunc;
         internal static int getWordCount([MarshalAs(UnmanagedType.LPWStr)]string text)
         {
         	if (_getWordCountFunc == null)
         	{
         		_getWordCountFunc =
         			(_getWordCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getWordCount"), typeof(_getWordCount));
         	}
         
         	return  _getWordCountFunc(text);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _monthNumToStr(int num, bool abbreviate);
         private static _monthNumToStr _monthNumToStrFunc;
         internal static IntPtr monthNumToStr(int num, bool abbreviate)
         {
         	if (_monthNumToStrFunc == null)
         	{
         		_monthNumToStrFunc =
         			(_monthNumToStr)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_monthNumToStr"), typeof(_monthNumToStr));
         	}
         
         	return  _monthNumToStrFunc(num, abbreviate);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _weekdayNumToStr(int num, bool abbreviate);
         private static _weekdayNumToStr _weekdayNumToStrFunc;
         internal static IntPtr weekdayNumToStr(int num, bool abbreviate)
         {
         	if (_weekdayNumToStrFunc == null)
         	{
         		_weekdayNumToStrFunc =
         			(_weekdayNumToStr)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_weekdayNumToStr"), typeof(_weekdayNumToStr));
         	}
         
         	return  _weekdayNumToStrFunc(num, abbreviate);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getField([MarshalAs(UnmanagedType.LPWStr)]string text, int index);
         private static _getField _getFieldFunc;
         internal static IntPtr getField([MarshalAs(UnmanagedType.LPWStr)]string text, int index)
         {
         	if (_getFieldFunc == null)
         	{
         		_getFieldFunc =
         			(_getField)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getField"), typeof(_getField));
         	}
         
         	return  _getFieldFunc(text, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getFields([MarshalAs(UnmanagedType.LPWStr)]string text, int startIndex, int endIndex);
         private static _getFields _getFieldsFunc;
         internal static IntPtr getFields([MarshalAs(UnmanagedType.LPWStr)]string text, int startIndex, int endIndex)
         {
         	if (_getFieldsFunc == null)
         	{
         		_getFieldsFunc =
         			(_getFields)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getFields"), typeof(_getFields));
         	}
         
         	return  _getFieldsFunc(text, startIndex, endIndex);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _setField([MarshalAs(UnmanagedType.LPWStr)]string text, int index, [MarshalAs(UnmanagedType.LPWStr)]string replacement);
         private static _setField _setFieldFunc;
         internal static IntPtr setField([MarshalAs(UnmanagedType.LPWStr)]string text, int index, [MarshalAs(UnmanagedType.LPWStr)]string replacement)
         {
         	if (_setFieldFunc == null)
         	{
         		_setFieldFunc =
         			(_setField)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_setField"), typeof(_setField));
         	}
         
         	return  _setFieldFunc(text, index, replacement);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _removeField([MarshalAs(UnmanagedType.LPWStr)]string text, int index);
         private static _removeField _removeFieldFunc;
         internal static IntPtr removeField([MarshalAs(UnmanagedType.LPWStr)]string text, int index)
         {
         	if (_removeFieldFunc == null)
         	{
         		_removeFieldFunc =
         			(_removeField)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_removeField"), typeof(_removeField));
         	}
         
         	return  _removeFieldFunc(text, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getFieldCount([MarshalAs(UnmanagedType.LPWStr)]string text);
         private static _getFieldCount _getFieldCountFunc;
         internal static int getFieldCount([MarshalAs(UnmanagedType.LPWStr)]string text)
         {
         	if (_getFieldCountFunc == null)
         	{
         		_getFieldCountFunc =
         			(_getFieldCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getFieldCount"), typeof(_getFieldCount));
         	}
         
         	return  _getFieldCountFunc(text);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getRecord([MarshalAs(UnmanagedType.LPWStr)]string text, int index);
         private static _getRecord _getRecordFunc;
         internal static IntPtr getRecord([MarshalAs(UnmanagedType.LPWStr)]string text, int index)
         {
         	if (_getRecordFunc == null)
         	{
         		_getRecordFunc =
         			(_getRecord)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getRecord"), typeof(_getRecord));
         	}
         
         	return  _getRecordFunc(text, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getRecords([MarshalAs(UnmanagedType.LPWStr)]string text, int startIndex, int endIndex);
         private static _getRecords _getRecordsFunc;
         internal static IntPtr getRecords([MarshalAs(UnmanagedType.LPWStr)]string text, int startIndex, int endIndex)
         {
         	if (_getRecordsFunc == null)
         	{
         		_getRecordsFunc =
         			(_getRecords)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getRecords"), typeof(_getRecords));
         	}
         
         	return  _getRecordsFunc(text, startIndex, endIndex);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _setRecord([MarshalAs(UnmanagedType.LPWStr)]string text, int index, [MarshalAs(UnmanagedType.LPWStr)]string replacement);
         private static _setRecord _setRecordFunc;
         internal static IntPtr setRecord([MarshalAs(UnmanagedType.LPWStr)]string text, int index, [MarshalAs(UnmanagedType.LPWStr)]string replacement)
         {
         	if (_setRecordFunc == null)
         	{
         		_setRecordFunc =
         			(_setRecord)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_setRecord"), typeof(_setRecord));
         	}
         
         	return  _setRecordFunc(text, index, replacement);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _removeRecord([MarshalAs(UnmanagedType.LPWStr)]string text, int index);
         private static _removeRecord _removeRecordFunc;
         internal static IntPtr removeRecord([MarshalAs(UnmanagedType.LPWStr)]string text, int index)
         {
         	if (_removeRecordFunc == null)
         	{
         		_removeRecordFunc =
         			(_removeRecord)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_removeRecord"), typeof(_removeRecord));
         	}
         
         	return  _removeRecordFunc(text, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getRecordCount([MarshalAs(UnmanagedType.LPWStr)]string text);
         private static _getRecordCount _getRecordCountFunc;
         internal static int getRecordCount([MarshalAs(UnmanagedType.LPWStr)]string text)
         {
         	if (_getRecordCountFunc == null)
         	{
         		_getRecordCountFunc =
         			(_getRecordCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getRecordCount"), typeof(_getRecordCount));
         	}
         
         	return  _getRecordCountFunc(text);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _firstWord([MarshalAs(UnmanagedType.LPWStr)]string text);
         private static _firstWord _firstWordFunc;
         internal static IntPtr firstWord([MarshalAs(UnmanagedType.LPWStr)]string text)
         {
         	if (_firstWordFunc == null)
         	{
         		_firstWordFunc =
         			(_firstWord)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_firstWord"), typeof(_firstWord));
         	}
         
         	return  _firstWordFunc(text);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _restWords([MarshalAs(UnmanagedType.LPWStr)]string text);
         private static _restWords _restWordsFunc;
         internal static IntPtr restWords([MarshalAs(UnmanagedType.LPWStr)]string text)
         {
         	if (_restWordsFunc == null)
         	{
         		_restWordsFunc =
         			(_restWords)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_restWords"), typeof(_restWords));
         	}
         
         	return  _restWordsFunc(text);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _nextToken([MarshalAs(UnmanagedType.LPWStr)]string str1, [MarshalAs(UnmanagedType.LPWStr)]string token, [MarshalAs(UnmanagedType.LPWStr)]string delim);
         private static _nextToken _nextTokenFunc;
         internal static IntPtr nextToken([MarshalAs(UnmanagedType.LPWStr)]string str1, [MarshalAs(UnmanagedType.LPWStr)]string token, [MarshalAs(UnmanagedType.LPWStr)]string delim)
         {
         	if (_nextTokenFunc == null)
         	{
         		_nextTokenFunc =
         			(_nextToken)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_nextToken"), typeof(_nextToken));
         	}
         
         	return  _nextTokenFunc(str1, token, delim);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getToken([MarshalAs(UnmanagedType.LPWStr)]string text, [MarshalAs(UnmanagedType.LPWStr)]string delimiters, int index);
         private static _getToken _getTokenFunc;
         internal static IntPtr getToken([MarshalAs(UnmanagedType.LPWStr)]string text, [MarshalAs(UnmanagedType.LPWStr)]string delimiters, int index)
         {
         	if (_getTokenFunc == null)
         	{
         		_getTokenFunc =
         			(_getToken)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getToken"), typeof(_getToken));
         	}
         
         	return  _getTokenFunc(text, delimiters, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getTokens([MarshalAs(UnmanagedType.LPWStr)]string text, [MarshalAs(UnmanagedType.LPWStr)]string delimiters, int startIndex, int endIndex);
         private static _getTokens _getTokensFunc;
         internal static IntPtr getTokens([MarshalAs(UnmanagedType.LPWStr)]string text, [MarshalAs(UnmanagedType.LPWStr)]string delimiters, int startIndex, int endIndex)
         {
         	if (_getTokensFunc == null)
         	{
         		_getTokensFunc =
         			(_getTokens)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getTokens"), typeof(_getTokens));
         	}
         
         	return  _getTokensFunc(text, delimiters, startIndex, endIndex);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _setToken([MarshalAs(UnmanagedType.LPWStr)]string text, [MarshalAs(UnmanagedType.LPWStr)]string delimiters, int index, [MarshalAs(UnmanagedType.LPWStr)]string replacement);
         private static _setToken _setTokenFunc;
         internal static IntPtr setToken([MarshalAs(UnmanagedType.LPWStr)]string text, [MarshalAs(UnmanagedType.LPWStr)]string delimiters, int index, [MarshalAs(UnmanagedType.LPWStr)]string replacement)
         {
         	if (_setTokenFunc == null)
         	{
         		_setTokenFunc =
         			(_setToken)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_setToken"), typeof(_setToken));
         	}
         
         	return  _setTokenFunc(text, delimiters, index, replacement);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _removeToken([MarshalAs(UnmanagedType.LPWStr)]string text, [MarshalAs(UnmanagedType.LPWStr)]string delimiters, int index);
         private static _removeToken _removeTokenFunc;
         internal static IntPtr removeToken([MarshalAs(UnmanagedType.LPWStr)]string text, [MarshalAs(UnmanagedType.LPWStr)]string delimiters, int index)
         {
         	if (_removeTokenFunc == null)
         	{
         		_removeTokenFunc =
         			(_removeToken)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_removeToken"), typeof(_removeToken));
         	}
         
         	return  _removeTokenFunc(text, delimiters, index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getTokenCount([MarshalAs(UnmanagedType.LPWStr)]string text, [MarshalAs(UnmanagedType.LPWStr)]string delimiters);
         private static _getTokenCount _getTokenCountFunc;
         internal static int getTokenCount([MarshalAs(UnmanagedType.LPWStr)]string text, [MarshalAs(UnmanagedType.LPWStr)]string delimiters)
         {
         	if (_getTokenCountFunc == null)
         	{
         		_getTokenCountFunc =
         			(_getTokenCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getTokenCount"), typeof(_getTokenCount));
         	}
         
         	return  _getTokenCountFunc(text, delimiters);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _detag([MarshalAs(UnmanagedType.LPWStr)]string str);
         private static _detag _detagFunc;
         internal static IntPtr detag([MarshalAs(UnmanagedType.LPWStr)]string str)
         {
         	if (_detagFunc == null)
         	{
         		_detagFunc =
         			(_detag)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_detag"), typeof(_detag));
         	}
         
         	return  _detagFunc(str);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getTag([MarshalAs(UnmanagedType.LPWStr)]string textTagString);
         private static _getTag _getTagFunc;
         internal static IntPtr getTag([MarshalAs(UnmanagedType.LPWStr)]string textTagString)
         {
         	if (_getTagFunc == null)
         	{
         		_getTagFunc =
         			(_getTag)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getTag"), typeof(_getTag));
         	}
         
         	return  _getTagFunc(textTagString);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _echo(int argc, string[] argv);
         private static _echo _echoFunc;
         internal static void echo(int argc, string[] argv)
         {
         	if (_echoFunc == null)
         	{
         		_echoFunc =
         			(_echo)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_echo"), typeof(_echo));
         	}
         
         	 _echoFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _warn(int argc, string[] argv);
         private static _warn _warnFunc;
         internal static void warn(int argc, string[] argv)
         {
         	if (_warnFunc == null)
         	{
         		_warnFunc =
         			(_warn)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_warn"), typeof(_warn));
         	}
         
         	 _warnFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _error(int argc, string[] argv);
         private static _error _errorFunc;
         internal static void error(int argc, string[] argv)
         {
         	if (_errorFunc == null)
         	{
         		_errorFunc =
         			(_error)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_error"), typeof(_error));
         	}
         
         	 _errorFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _debugv([MarshalAs(UnmanagedType.LPWStr)]string variableName);
         private static _debugv _debugvFunc;
         internal static void debugv([MarshalAs(UnmanagedType.LPWStr)]string variableName)
         {
         	if (_debugvFunc == null)
         	{
         		_debugvFunc =
         			(_debugv)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_debugv"), typeof(_debugv));
         	}
         
         	 _debugvFunc(variableName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _expandEscape([MarshalAs(UnmanagedType.LPWStr)]string text);
         private static _expandEscape _expandEscapeFunc;
         internal static IntPtr expandEscape([MarshalAs(UnmanagedType.LPWStr)]string text)
         {
         	if (_expandEscapeFunc == null)
         	{
         		_expandEscapeFunc =
         			(_expandEscape)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_expandEscape"), typeof(_expandEscape));
         	}
         
         	return  _expandEscapeFunc(text);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _collapseEscape([MarshalAs(UnmanagedType.LPWStr)]string text);
         private static _collapseEscape _collapseEscapeFunc;
         internal static IntPtr collapseEscape([MarshalAs(UnmanagedType.LPWStr)]string text)
         {
         	if (_collapseEscapeFunc == null)
         	{
         		_collapseEscapeFunc =
         			(_collapseEscape)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_collapseEscape"), typeof(_collapseEscape));
         	}
         
         	return  _collapseEscapeFunc(text);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setLogMode(int mode);
         private static _setLogMode _setLogModeFunc;
         internal static void setLogMode(int mode)
         {
         	if (_setLogModeFunc == null)
         	{
         		_setLogModeFunc =
         			(_setLogMode)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_setLogMode"), typeof(_setLogMode));
         	}
         
         	 _setLogModeFunc(mode);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _quit();
         private static _quit _quitFunc;
         internal static void quit()
         {
         	if (_quitFunc == null)
         	{
         		_quitFunc =
         			(_quit)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_quit"), typeof(_quit));
         	}
         
         	 _quitFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _realQuit();
         private static _realQuit _realQuitFunc;
         internal static void realQuit()
         {
         	if (_realQuitFunc == null)
         	{
         		_realQuitFunc =
         			(_realQuit)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_realQuit"), typeof(_realQuit));
         	}
         
         	 _realQuitFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _quitWithErrorMessage([MarshalAs(UnmanagedType.LPWStr)]string message, int status);
         private static _quitWithErrorMessage _quitWithErrorMessageFunc;
         internal static void quitWithErrorMessage([MarshalAs(UnmanagedType.LPWStr)]string message, int status)
         {
         	if (_quitWithErrorMessageFunc == null)
         	{
         		_quitWithErrorMessageFunc =
         			(_quitWithErrorMessage)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_quitWithErrorMessage"), typeof(_quitWithErrorMessage));
         	}
         
         	 _quitWithErrorMessageFunc(message, status);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _quitWithStatus(int status);
         private static _quitWithStatus _quitWithStatusFunc;
         internal static void quitWithStatus(int status)
         {
         	if (_quitWithStatusFunc == null)
         	{
         		_quitWithStatusFunc =
         			(_quitWithStatus)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_quitWithStatus"), typeof(_quitWithStatus));
         	}
         
         	 _quitWithStatusFunc(status);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _gotoWebPage([MarshalAs(UnmanagedType.LPWStr)]string address);
         private static _gotoWebPage _gotoWebPageFunc;
         internal static void gotoWebPage([MarshalAs(UnmanagedType.LPWStr)]string address)
         {
         	if (_gotoWebPageFunc == null)
         	{
         		_gotoWebPageFunc =
         			(_gotoWebPage)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_gotoWebPage"), typeof(_gotoWebPage));
         	}
         
         	 _gotoWebPageFunc(address);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _displaySplashWindow([MarshalAs(UnmanagedType.LPWStr)]string path);
         private static _displaySplashWindow _displaySplashWindowFunc;
         internal static bool displaySplashWindow([MarshalAs(UnmanagedType.LPWStr)]string path)
         {
         	if (_displaySplashWindowFunc == null)
         	{
         		_displaySplashWindowFunc =
         			(_displaySplashWindow)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_displaySplashWindow"), typeof(_displaySplashWindow));
         	}
         
         	return  _displaySplashWindowFunc(path);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _closeSplashWindow();
         private static _closeSplashWindow _closeSplashWindowFunc;
         internal static void closeSplashWindow()
         {
         	if (_closeSplashWindowFunc == null)
         	{
         		_closeSplashWindowFunc =
         			(_closeSplashWindow)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_closeSplashWindow"), typeof(_closeSplashWindow));
         	}
         
         	 _closeSplashWindowFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _getWebDeployment();
         private static _getWebDeployment _getWebDeploymentFunc;
         internal static bool getWebDeployment()
         {
         	if (_getWebDeploymentFunc == null)
         	{
         		_getWebDeploymentFunc =
         			(_getWebDeployment)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getWebDeployment"), typeof(_getWebDeployment));
         	}
         
         	return  _getWebDeploymentFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _countBits(int v);
         private static _countBits _countBitsFunc;
         internal static int countBits(int v)
         {
         	if (_countBitsFunc == null)
         	{
         		_countBitsFunc =
         			(_countBits)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_countBits"), typeof(_countBits));
         	}
         
         	return  _countBitsFunc(v);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalUUIDStruct _generateUUID();
         private static _generateUUID _generateUUIDFunc;
         internal static InternalUUIDStruct generateUUID()
         {
         	if (_generateUUIDFunc == null)
         	{
         		_generateUUIDFunc =
         			(_generateUUID)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_generateUUID"), typeof(_generateUUID));
         	}
         
         	return  _generateUUIDFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _call(int argc, string[] argv);
         private static _call _callFunc;
         internal static IntPtr call(int argc, string[] argv)
         {
         	if (_callFunc == null)
         	{
         		_callFunc =
         			(_call)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_call"), typeof(_call));
         	}
         
         	return  _callFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getDSOPath([MarshalAs(UnmanagedType.LPWStr)]string scriptFileName);
         private static _getDSOPath _getDSOPathFunc;
         internal static IntPtr getDSOPath([MarshalAs(UnmanagedType.LPWStr)]string scriptFileName)
         {
         	if (_getDSOPathFunc == null)
         	{
         		_getDSOPathFunc =
         			(_getDSOPath)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getDSOPath"), typeof(_getDSOPath));
         	}
         
         	return  _getDSOPathFunc(scriptFileName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _compile([MarshalAs(UnmanagedType.LPWStr)]string fileName, bool overrideNoDSO);
         private static _compile _compileFunc;
         internal static bool compile([MarshalAs(UnmanagedType.LPWStr)]string fileName, bool overrideNoDSO)
         {
         	if (_compileFunc == null)
         	{
         		_compileFunc =
         			(_compile)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_compile"), typeof(_compile));
         	}
         
         	return  _compileFunc(fileName, overrideNoDSO);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _exec([MarshalAs(UnmanagedType.LPWStr)]string fileName, bool noCalls, bool journalScript);
         private static _exec _execFunc;
         internal static bool exec([MarshalAs(UnmanagedType.LPWStr)]string fileName, bool noCalls, bool journalScript)
         {
         	if (_execFunc == null)
         	{
         		_execFunc =
         			(_exec)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_exec"), typeof(_exec));
         	}
         
         	return  _execFunc(fileName, noCalls, journalScript);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _eval([MarshalAs(UnmanagedType.LPWStr)]string consoleString);
         private static _eval _evalFunc;
         internal static IntPtr eval([MarshalAs(UnmanagedType.LPWStr)]string consoleString)
         {
         	if (_evalFunc == null)
         	{
         		_evalFunc =
         			(_eval)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_eval"), typeof(_eval));
         	}
         
         	return  _evalFunc(consoleString);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getVariable([MarshalAs(UnmanagedType.LPWStr)]string varName);
         private static _getVariable _getVariableFunc;
         internal static IntPtr getVariable([MarshalAs(UnmanagedType.LPWStr)]string varName)
         {
         	if (_getVariableFunc == null)
         	{
         		_getVariableFunc =
         			(_getVariable)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getVariable"), typeof(_getVariable));
         	}
         
         	return  _getVariableFunc(varName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setVariable([MarshalAs(UnmanagedType.LPWStr)]string varName, [MarshalAs(UnmanagedType.LPWStr)]string value);
         private static _setVariable _setVariableFunc;
         internal static void setVariable([MarshalAs(UnmanagedType.LPWStr)]string varName, [MarshalAs(UnmanagedType.LPWStr)]string value)
         {
         	if (_setVariableFunc == null)
         	{
         		_setVariableFunc =
         			(_setVariable)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_setVariable"), typeof(_setVariable));
         	}
         
         	 _setVariableFunc(varName, value);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isFunction([MarshalAs(UnmanagedType.LPWStr)]string funcName);
         private static _isFunction _isFunctionFunc;
         internal static bool isFunction([MarshalAs(UnmanagedType.LPWStr)]string funcName)
         {
         	if (_isFunctionFunc == null)
         	{
         		_isFunctionFunc =
         			(_isFunction)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_isFunction"), typeof(_isFunction));
         	}
         
         	return  _isFunctionFunc(funcName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getFunctionPackage([MarshalAs(UnmanagedType.LPWStr)]string funcName);
         private static _getFunctionPackage _getFunctionPackageFunc;
         internal static IntPtr getFunctionPackage([MarshalAs(UnmanagedType.LPWStr)]string funcName)
         {
         	if (_getFunctionPackageFunc == null)
         	{
         		_getFunctionPackageFunc =
         			(_getFunctionPackage)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getFunctionPackage"), typeof(_getFunctionPackage));
         	}
         
         	return  _getFunctionPackageFunc(funcName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isMethod([MarshalAs(UnmanagedType.LPWStr)]string nameSpace, [MarshalAs(UnmanagedType.LPWStr)]string method);
         private static _isMethod _isMethodFunc;
         internal static bool isMethod([MarshalAs(UnmanagedType.LPWStr)]string nameSpace, [MarshalAs(UnmanagedType.LPWStr)]string method)
         {
         	if (_isMethodFunc == null)
         	{
         		_isMethodFunc =
         			(_isMethod)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_isMethod"), typeof(_isMethod));
         	}
         
         	return  _isMethodFunc(nameSpace, method);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getMethodPackage([MarshalAs(UnmanagedType.LPWStr)]string nameSpace, [MarshalAs(UnmanagedType.LPWStr)]string method);
         private static _getMethodPackage _getMethodPackageFunc;
         internal static IntPtr getMethodPackage([MarshalAs(UnmanagedType.LPWStr)]string nameSpace, [MarshalAs(UnmanagedType.LPWStr)]string method)
         {
         	if (_getMethodPackageFunc == null)
         	{
         		_getMethodPackageFunc =
         			(_getMethodPackage)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getMethodPackage"), typeof(_getMethodPackage));
         	}
         
         	return  _getMethodPackageFunc(nameSpace, method);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isDefined([MarshalAs(UnmanagedType.LPWStr)]string varName, [MarshalAs(UnmanagedType.LPWStr)]string varValue);
         private static _isDefined _isDefinedFunc;
         internal static bool isDefined([MarshalAs(UnmanagedType.LPWStr)]string varName, [MarshalAs(UnmanagedType.LPWStr)]string varValue)
         {
         	if (_isDefinedFunc == null)
         	{
         		_isDefinedFunc =
         			(_isDefined)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_isDefined"), typeof(_isDefined));
         	}
         
         	return  _isDefinedFunc(varName, varValue);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isCurrentScriptToolScript();
         private static _isCurrentScriptToolScript _isCurrentScriptToolScriptFunc;
         internal static bool isCurrentScriptToolScript()
         {
         	if (_isCurrentScriptToolScriptFunc == null)
         	{
         		_isCurrentScriptToolScriptFunc =
         			(_isCurrentScriptToolScript)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_isCurrentScriptToolScript"), typeof(_isCurrentScriptToolScript));
         	}
         
         	return  _isCurrentScriptToolScriptFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getModNameFromPath([MarshalAs(UnmanagedType.LPWStr)]string path);
         private static _getModNameFromPath _getModNameFromPathFunc;
         internal static IntPtr getModNameFromPath([MarshalAs(UnmanagedType.LPWStr)]string path)
         {
         	if (_getModNameFromPathFunc == null)
         	{
         		_getModNameFromPathFunc =
         			(_getModNameFromPath)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getModNameFromPath"), typeof(_getModNameFromPath));
         	}
         
         	return  _getModNameFromPathFunc(path);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _pushInstantGroup([MarshalAs(UnmanagedType.LPWStr)]string group);
         private static _pushInstantGroup _pushInstantGroupFunc;
         internal static void pushInstantGroup([MarshalAs(UnmanagedType.LPWStr)]string group)
         {
         	if (_pushInstantGroupFunc == null)
         	{
         		_pushInstantGroupFunc =
         			(_pushInstantGroup)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_pushInstantGroup"), typeof(_pushInstantGroup));
         	}
         
         	 _pushInstantGroupFunc(group);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _popInstantGroup();
         private static _popInstantGroup _popInstantGroupFunc;
         internal static void popInstantGroup()
         {
         	if (_popInstantGroupFunc == null)
         	{
         		_popInstantGroupFunc =
         			(_popInstantGroup)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_popInstantGroup"), typeof(_popInstantGroup));
         	}
         
         	 _popInstantGroupFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getPrefsPath([MarshalAs(UnmanagedType.LPWStr)]string relativeFileName);
         private static _getPrefsPath _getPrefsPathFunc;
         internal static IntPtr getPrefsPath([MarshalAs(UnmanagedType.LPWStr)]string relativeFileName)
         {
         	if (_getPrefsPathFunc == null)
         	{
         		_getPrefsPathFunc =
         			(_getPrefsPath)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getPrefsPath"), typeof(_getPrefsPath));
         	}
         
         	return  _getPrefsPathFunc(relativeFileName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _execPrefs(int argc, string[] argv);
         private static _execPrefs _execPrefsFunc;
         internal static bool execPrefs(int argc, string[] argv)
         {
         	if (_execPrefsFunc == null)
         	{
         		_execPrefsFunc =
         			(_execPrefs)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_execPrefs"), typeof(_execPrefs));
         	}
         
         	return  _execPrefsFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _export([MarshalAs(UnmanagedType.LPWStr)]string pattern, [MarshalAs(UnmanagedType.LPWStr)]string filename, bool append);
         private static _export _exportFunc;
         internal static void export([MarshalAs(UnmanagedType.LPWStr)]string pattern, [MarshalAs(UnmanagedType.LPWStr)]string filename, bool append)
         {
         	if (_exportFunc == null)
         	{
         		_exportFunc =
         			(_export)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_export"), typeof(_export));
         	}
         
         	 _exportFunc(pattern, filename, append);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _deleteVariables([MarshalAs(UnmanagedType.LPWStr)]string pattern);
         private static _deleteVariables _deleteVariablesFunc;
         internal static void deleteVariables([MarshalAs(UnmanagedType.LPWStr)]string pattern)
         {
         	if (_deleteVariablesFunc == null)
         	{
         		_deleteVariablesFunc =
         			(_deleteVariables)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_deleteVariables"), typeof(_deleteVariables));
         	}
         
         	 _deleteVariablesFunc(pattern);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _trace(bool enable);
         private static _trace _traceFunc;
         internal static void trace(bool enable)
         {
         	if (_traceFunc == null)
         	{
         		_traceFunc =
         			(_trace)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_trace"), typeof(_trace));
         	}
         
         	 _traceFunc(enable);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _debug();
         private static _debug _debugFunc;
         internal static void debug()
         {
         	if (_debugFunc == null)
         	{
         		_debugFunc =
         			(_debug)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_debug"), typeof(_debug));
         	}
         
         	 _debugFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isShippingBuild();
         private static _isShippingBuild _isShippingBuildFunc;
         internal static bool isShippingBuild()
         {
         	if (_isShippingBuildFunc == null)
         	{
         		_isShippingBuildFunc =
         			(_isShippingBuild)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_isShippingBuild"), typeof(_isShippingBuild));
         	}
         
         	return  _isShippingBuildFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isDebugBuild();
         private static _isDebugBuild _isDebugBuildFunc;
         internal static bool isDebugBuild()
         {
         	if (_isDebugBuildFunc == null)
         	{
         		_isDebugBuildFunc =
         			(_isDebugBuild)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_isDebugBuild"), typeof(_isDebugBuild));
         	}
         
         	return  _isDebugBuildFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isToolBuild();
         private static _isToolBuild _isToolBuildFunc;
         internal static bool isToolBuild()
         {
         	if (_isToolBuildFunc == null)
         	{
         		_isToolBuildFunc =
         			(_isToolBuild)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_isToolBuild"), typeof(_isToolBuild));
         	}
         
         	return  _isToolBuildFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getMaxDynamicVerts();
         private static _getMaxDynamicVerts _getMaxDynamicVertsFunc;
         internal static int getMaxDynamicVerts()
         {
         	if (_getMaxDynamicVertsFunc == null)
         	{
         		_getMaxDynamicVertsFunc =
         			(_getMaxDynamicVerts)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getMaxDynamicVerts"), typeof(_getMaxDynamicVerts));
         	}
         
         	return  _getMaxDynamicVertsFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _backtrace();
         private static _backtrace _backtraceFunc;
         internal static void backtrace()
         {
         	if (_backtraceFunc == null)
         	{
         		_backtraceFunc =
         			(_backtrace)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_backtrace"), typeof(_backtrace));
         	}
         
         	 _backtraceFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isPackage([MarshalAs(UnmanagedType.LPWStr)]string identifier);
         private static _isPackage _isPackageFunc;
         internal static bool isPackage([MarshalAs(UnmanagedType.LPWStr)]string identifier)
         {
         	if (_isPackageFunc == null)
         	{
         		_isPackageFunc =
         			(_isPackage)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_isPackage"), typeof(_isPackage));
         	}
         
         	return  _isPackageFunc(identifier);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _activatePackage([MarshalAs(UnmanagedType.LPWStr)]string packageName);
         private static _activatePackage _activatePackageFunc;
         internal static void activatePackage([MarshalAs(UnmanagedType.LPWStr)]string packageName)
         {
         	if (_activatePackageFunc == null)
         	{
         		_activatePackageFunc =
         			(_activatePackage)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_activatePackage"), typeof(_activatePackage));
         	}
         
         	 _activatePackageFunc(packageName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _deactivatePackage([MarshalAs(UnmanagedType.LPWStr)]string packageName);
         private static _deactivatePackage _deactivatePackageFunc;
         internal static void deactivatePackage([MarshalAs(UnmanagedType.LPWStr)]string packageName)
         {
         	if (_deactivatePackageFunc == null)
         	{
         		_deactivatePackageFunc =
         			(_deactivatePackage)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_deactivatePackage"), typeof(_deactivatePackage));
         	}
         
         	 _deactivatePackageFunc(packageName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getPackageList();
         private static _getPackageList _getPackageListFunc;
         internal static IntPtr getPackageList()
         {
         	if (_getPackageListFunc == null)
         	{
         		_getPackageListFunc =
         			(_getPackageList)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getPackageList"), typeof(_getPackageList));
         	}
         
         	return  _getPackageListFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isClass([MarshalAs(UnmanagedType.LPWStr)]string identifier);
         private static _isClass _isClassFunc;
         internal static bool isClass([MarshalAs(UnmanagedType.LPWStr)]string identifier)
         {
         	if (_isClassFunc == null)
         	{
         		_isClassFunc =
         			(_isClass)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_isClass"), typeof(_isClass));
         	}
         
         	return  _isClassFunc(identifier);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isMemberOfClass([MarshalAs(UnmanagedType.LPWStr)]string className, [MarshalAs(UnmanagedType.LPWStr)]string superClassName);
         private static _isMemberOfClass _isMemberOfClassFunc;
         internal static bool isMemberOfClass([MarshalAs(UnmanagedType.LPWStr)]string className, [MarshalAs(UnmanagedType.LPWStr)]string superClassName)
         {
         	if (_isMemberOfClassFunc == null)
         	{
         		_isMemberOfClassFunc =
         			(_isMemberOfClass)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_isMemberOfClass"), typeof(_isMemberOfClass));
         	}
         
         	return  _isMemberOfClassFunc(className, superClassName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getDescriptionOfClass([MarshalAs(UnmanagedType.LPWStr)]string className);
         private static _getDescriptionOfClass _getDescriptionOfClassFunc;
         internal static IntPtr getDescriptionOfClass([MarshalAs(UnmanagedType.LPWStr)]string className)
         {
         	if (_getDescriptionOfClassFunc == null)
         	{
         		_getDescriptionOfClassFunc =
         			(_getDescriptionOfClass)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getDescriptionOfClass"), typeof(_getDescriptionOfClass));
         	}
         
         	return  _getDescriptionOfClassFunc(className);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getCategoryOfClass([MarshalAs(UnmanagedType.LPWStr)]string className);
         private static _getCategoryOfClass _getCategoryOfClassFunc;
         internal static IntPtr getCategoryOfClass([MarshalAs(UnmanagedType.LPWStr)]string className)
         {
         	if (_getCategoryOfClassFunc == null)
         	{
         		_getCategoryOfClassFunc =
         			(_getCategoryOfClass)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getCategoryOfClass"), typeof(_getCategoryOfClass));
         	}
         
         	return  _getCategoryOfClassFunc(className);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _enumerateConsoleClasses([MarshalAs(UnmanagedType.LPWStr)]string className);
         private static _enumerateConsoleClasses _enumerateConsoleClassesFunc;
         internal static IntPtr enumerateConsoleClasses([MarshalAs(UnmanagedType.LPWStr)]string className)
         {
         	if (_enumerateConsoleClassesFunc == null)
         	{
         		_enumerateConsoleClassesFunc =
         			(_enumerateConsoleClasses)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_enumerateConsoleClasses"), typeof(_enumerateConsoleClasses));
         	}
         
         	return  _enumerateConsoleClassesFunc(className);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _enumerateConsoleClassesByCategory([MarshalAs(UnmanagedType.LPWStr)]string category);
         private static _enumerateConsoleClassesByCategory _enumerateConsoleClassesByCategoryFunc;
         internal static IntPtr enumerateConsoleClassesByCategory([MarshalAs(UnmanagedType.LPWStr)]string category)
         {
         	if (_enumerateConsoleClassesByCategoryFunc == null)
         	{
         		_enumerateConsoleClassesByCategoryFunc =
         			(_enumerateConsoleClassesByCategory)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_enumerateConsoleClassesByCategory"), typeof(_enumerateConsoleClassesByCategory));
         	}
         
         	return  _enumerateConsoleClassesByCategoryFunc(category);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _dumpNetStats();
         private static _dumpNetStats _dumpNetStatsFunc;
         internal static void dumpNetStats()
         {
         	if (_dumpNetStatsFunc == null)
         	{
         		_dumpNetStatsFunc =
         			(_dumpNetStats)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_dumpNetStats"), typeof(_dumpNetStats));
         	}
         
         	 _dumpNetStatsFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _sizeOf([MarshalAs(UnmanagedType.LPWStr)]string objectOrClass);
         private static _sizeOf _sizeOfFunc;
         internal static int sizeOf([MarshalAs(UnmanagedType.LPWStr)]string objectOrClass)
         {
         	if (_sizeOfFunc == null)
         	{
         		_sizeOfFunc =
         			(_sizeOf)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_sizeof"), typeof(_sizeOf));
         	}
         
         	return  _sizeOfFunc(objectOrClass);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _linkNamespaces([MarshalAs(UnmanagedType.LPWStr)]string childNSName, [MarshalAs(UnmanagedType.LPWStr)]string parentNSName);
         private static _linkNamespaces _linkNamespacesFunc;
         internal static bool linkNamespaces([MarshalAs(UnmanagedType.LPWStr)]string childNSName, [MarshalAs(UnmanagedType.LPWStr)]string parentNSName)
         {
         	if (_linkNamespacesFunc == null)
         	{
         		_linkNamespacesFunc =
         			(_linkNamespaces)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_linkNamespaces"), typeof(_linkNamespaces));
         	}
         
         	return  _linkNamespacesFunc(childNSName, parentNSName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _dumpEngineDocs([MarshalAs(UnmanagedType.LPWStr)]string outputFile);
         private static _dumpEngineDocs _dumpEngineDocsFunc;
         internal static bool dumpEngineDocs([MarshalAs(UnmanagedType.LPWStr)]string outputFile)
         {
         	if (_dumpEngineDocsFunc == null)
         	{
         		_dumpEngineDocsFunc =
         			(_dumpEngineDocs)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_dumpEngineDocs"), typeof(_dumpEngineDocs));
         	}
         
         	return  _dumpEngineDocsFunc(outputFile);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _debugDumpAllObjects();
         private static _debugDumpAllObjects _debugDumpAllObjectsFunc;
         internal static void debugDumpAllObjects()
         {
         	if (_debugDumpAllObjectsFunc == null)
         	{
         		_debugDumpAllObjectsFunc =
         			(_debugDumpAllObjects)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_debugDumpAllObjects"), typeof(_debugDumpAllObjects));
         	}
         
         	 _debugDumpAllObjectsFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _exportEngineAPIToXML();
         private static _exportEngineAPIToXML _exportEngineAPIToXMLFunc;
         internal static IntPtr exportEngineAPIToXML()
         {
         	if (_exportEngineAPIToXMLFunc == null)
         	{
         		_exportEngineAPIToXMLFunc =
         			(_exportEngineAPIToXML)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_exportEngineAPIToXML"), typeof(_exportEngineAPIToXML));
         	}
         
         	return  _exportEngineAPIToXMLFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _findFirstFile([MarshalAs(UnmanagedType.LPWStr)]string pattern, bool recurse);
         private static _findFirstFile _findFirstFileFunc;
         internal static IntPtr findFirstFile([MarshalAs(UnmanagedType.LPWStr)]string pattern, bool recurse)
         {
         	if (_findFirstFileFunc == null)
         	{
         		_findFirstFileFunc =
         			(_findFirstFile)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_findFirstFile"), typeof(_findFirstFile));
         	}
         
         	return  _findFirstFileFunc(pattern, recurse);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _findNextFile([MarshalAs(UnmanagedType.LPWStr)]string pattern);
         private static _findNextFile _findNextFileFunc;
         internal static IntPtr findNextFile([MarshalAs(UnmanagedType.LPWStr)]string pattern)
         {
         	if (_findNextFileFunc == null)
         	{
         		_findNextFileFunc =
         			(_findNextFile)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_findNextFile"), typeof(_findNextFile));
         	}
         
         	return  _findNextFileFunc(pattern);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getFileCount([MarshalAs(UnmanagedType.LPWStr)]string pattern, bool recurse);
         private static _getFileCount _getFileCountFunc;
         internal static int getFileCount([MarshalAs(UnmanagedType.LPWStr)]string pattern, bool recurse)
         {
         	if (_getFileCountFunc == null)
         	{
         		_getFileCountFunc =
         			(_getFileCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getFileCount"), typeof(_getFileCount));
         	}
         
         	return  _getFileCountFunc(pattern, recurse);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _findFirstFileMultiExpr([MarshalAs(UnmanagedType.LPWStr)]string pattern, bool recurse);
         private static _findFirstFileMultiExpr _findFirstFileMultiExprFunc;
         internal static IntPtr findFirstFileMultiExpr([MarshalAs(UnmanagedType.LPWStr)]string pattern, bool recurse)
         {
         	if (_findFirstFileMultiExprFunc == null)
         	{
         		_findFirstFileMultiExprFunc =
         			(_findFirstFileMultiExpr)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_findFirstFileMultiExpr"), typeof(_findFirstFileMultiExpr));
         	}
         
         	return  _findFirstFileMultiExprFunc(pattern, recurse);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _findNextFileMultiExpr([MarshalAs(UnmanagedType.LPWStr)]string pattern);
         private static _findNextFileMultiExpr _findNextFileMultiExprFunc;
         internal static IntPtr findNextFileMultiExpr([MarshalAs(UnmanagedType.LPWStr)]string pattern)
         {
         	if (_findNextFileMultiExprFunc == null)
         	{
         		_findNextFileMultiExprFunc =
         			(_findNextFileMultiExpr)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_findNextFileMultiExpr"), typeof(_findNextFileMultiExpr));
         	}
         
         	return  _findNextFileMultiExprFunc(pattern);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getFileCountMultiExpr([MarshalAs(UnmanagedType.LPWStr)]string pattern, bool recurse);
         private static _getFileCountMultiExpr _getFileCountMultiExprFunc;
         internal static int getFileCountMultiExpr([MarshalAs(UnmanagedType.LPWStr)]string pattern, bool recurse)
         {
         	if (_getFileCountMultiExprFunc == null)
         	{
         		_getFileCountMultiExprFunc =
         			(_getFileCountMultiExpr)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getFileCountMultiExpr"), typeof(_getFileCountMultiExpr));
         	}
         
         	return  _getFileCountMultiExprFunc(pattern, recurse);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getFileCRC([MarshalAs(UnmanagedType.LPWStr)]string fileName);
         private static _getFileCRC _getFileCRCFunc;
         internal static int getFileCRC([MarshalAs(UnmanagedType.LPWStr)]string fileName)
         {
         	if (_getFileCRCFunc == null)
         	{
         		_getFileCRCFunc =
         			(_getFileCRC)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getFileCRC"), typeof(_getFileCRC));
         	}
         
         	return  _getFileCRCFunc(fileName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isFile([MarshalAs(UnmanagedType.LPWStr)]string fileName);
         private static _isFile _isFileFunc;
         internal static bool isFile([MarshalAs(UnmanagedType.LPWStr)]string fileName)
         {
         	if (_isFileFunc == null)
         	{
         		_isFileFunc =
         			(_isFile)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_isFile"), typeof(_isFile));
         	}
         
         	return  _isFileFunc(fileName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _IsDirectory([MarshalAs(UnmanagedType.LPWStr)]string directory);
         private static _IsDirectory _IsDirectoryFunc;
         internal static bool IsDirectory([MarshalAs(UnmanagedType.LPWStr)]string directory)
         {
         	if (_IsDirectoryFunc == null)
         	{
         		_IsDirectoryFunc =
         			(_IsDirectory)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_IsDirectory"), typeof(_IsDirectory));
         	}
         
         	return  _IsDirectoryFunc(directory);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isWriteableFileName([MarshalAs(UnmanagedType.LPWStr)]string fileName);
         private static _isWriteableFileName _isWriteableFileNameFunc;
         internal static bool isWriteableFileName([MarshalAs(UnmanagedType.LPWStr)]string fileName)
         {
         	if (_isWriteableFileNameFunc == null)
         	{
         		_isWriteableFileNameFunc =
         			(_isWriteableFileName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_isWriteableFileName"), typeof(_isWriteableFileName));
         	}
         
         	return  _isWriteableFileNameFunc(fileName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _startFileChangeNotifications();
         private static _startFileChangeNotifications _startFileChangeNotificationsFunc;
         internal static void startFileChangeNotifications()
         {
         	if (_startFileChangeNotificationsFunc == null)
         	{
         		_startFileChangeNotificationsFunc =
         			(_startFileChangeNotifications)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_startFileChangeNotifications"), typeof(_startFileChangeNotifications));
         	}
         
         	 _startFileChangeNotificationsFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _stopFileChangeNotifications();
         private static _stopFileChangeNotifications _stopFileChangeNotificationsFunc;
         internal static void stopFileChangeNotifications()
         {
         	if (_stopFileChangeNotificationsFunc == null)
         	{
         		_stopFileChangeNotificationsFunc =
         			(_stopFileChangeNotifications)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_stopFileChangeNotifications"), typeof(_stopFileChangeNotifications));
         	}
         
         	 _stopFileChangeNotificationsFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getDirectoryList([MarshalAs(UnmanagedType.LPWStr)]string path, int depth);
         private static _getDirectoryList _getDirectoryListFunc;
         internal static IntPtr getDirectoryList([MarshalAs(UnmanagedType.LPWStr)]string path, int depth)
         {
         	if (_getDirectoryListFunc == null)
         	{
         		_getDirectoryListFunc =
         			(_getDirectoryList)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getDirectoryList"), typeof(_getDirectoryList));
         	}
         
         	return  _getDirectoryListFunc(path, depth);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _fileSize([MarshalAs(UnmanagedType.LPWStr)]string fileName);
         private static _fileSize _fileSizeFunc;
         internal static int fileSize([MarshalAs(UnmanagedType.LPWStr)]string fileName)
         {
         	if (_fileSizeFunc == null)
         	{
         		_fileSizeFunc =
         			(_fileSize)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_fileSize"), typeof(_fileSize));
         	}
         
         	return  _fileSizeFunc(fileName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _fileModifiedTime([MarshalAs(UnmanagedType.LPWStr)]string fileName);
         private static _fileModifiedTime _fileModifiedTimeFunc;
         internal static IntPtr fileModifiedTime([MarshalAs(UnmanagedType.LPWStr)]string fileName)
         {
         	if (_fileModifiedTimeFunc == null)
         	{
         		_fileModifiedTimeFunc =
         			(_fileModifiedTime)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_fileModifiedTime"), typeof(_fileModifiedTime));
         	}
         
         	return  _fileModifiedTimeFunc(fileName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _fileCreatedTime([MarshalAs(UnmanagedType.LPWStr)]string fileName);
         private static _fileCreatedTime _fileCreatedTimeFunc;
         internal static IntPtr fileCreatedTime([MarshalAs(UnmanagedType.LPWStr)]string fileName)
         {
         	if (_fileCreatedTimeFunc == null)
         	{
         		_fileCreatedTimeFunc =
         			(_fileCreatedTime)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_fileCreatedTime"), typeof(_fileCreatedTime));
         	}
         
         	return  _fileCreatedTimeFunc(fileName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _fileDelete([MarshalAs(UnmanagedType.LPWStr)]string path);
         private static _fileDelete _fileDeleteFunc;
         internal static bool fileDelete([MarshalAs(UnmanagedType.LPWStr)]string path)
         {
         	if (_fileDeleteFunc == null)
         	{
         		_fileDeleteFunc =
         			(_fileDelete)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_fileDelete"), typeof(_fileDelete));
         	}
         
         	return  _fileDeleteFunc(path);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _fileExt([MarshalAs(UnmanagedType.LPWStr)]string fileName);
         private static _fileExt _fileExtFunc;
         internal static IntPtr fileExt([MarshalAs(UnmanagedType.LPWStr)]string fileName)
         {
         	if (_fileExtFunc == null)
         	{
         		_fileExtFunc =
         			(_fileExt)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_fileExt"), typeof(_fileExt));
         	}
         
         	return  _fileExtFunc(fileName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _fileBase([MarshalAs(UnmanagedType.LPWStr)]string fileName);
         private static _fileBase _fileBaseFunc;
         internal static IntPtr fileBase([MarshalAs(UnmanagedType.LPWStr)]string fileName)
         {
         	if (_fileBaseFunc == null)
         	{
         		_fileBaseFunc =
         			(_fileBase)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_fileBase"), typeof(_fileBase));
         	}
         
         	return  _fileBaseFunc(fileName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _fileName([MarshalAs(UnmanagedType.LPWStr)]string fileName);
         private static _fileName _fileNameFunc;
         internal static IntPtr fileName([MarshalAs(UnmanagedType.LPWStr)]string fileName)
         {
         	if (_fileNameFunc == null)
         	{
         		_fileNameFunc =
         			(_fileName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_fileName"), typeof(_fileName));
         	}
         
         	return  _fileNameFunc(fileName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _filePath([MarshalAs(UnmanagedType.LPWStr)]string fileName);
         private static _filePath _filePathFunc;
         internal static IntPtr filePath([MarshalAs(UnmanagedType.LPWStr)]string fileName)
         {
         	if (_filePathFunc == null)
         	{
         		_filePathFunc =
         			(_filePath)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_filePath"), typeof(_filePath));
         	}
         
         	return  _filePathFunc(fileName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getWorkingDirectory();
         private static _getWorkingDirectory _getWorkingDirectoryFunc;
         internal static IntPtr getWorkingDirectory()
         {
         	if (_getWorkingDirectoryFunc == null)
         	{
         		_getWorkingDirectoryFunc =
         			(_getWorkingDirectory)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getWorkingDirectory"), typeof(_getWorkingDirectory));
         	}
         
         	return  _getWorkingDirectoryFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _makeFullPath([MarshalAs(UnmanagedType.LPWStr)]string path, [MarshalAs(UnmanagedType.LPWStr)]string cwd);
         private static _makeFullPath _makeFullPathFunc;
         internal static IntPtr makeFullPath([MarshalAs(UnmanagedType.LPWStr)]string path, [MarshalAs(UnmanagedType.LPWStr)]string cwd)
         {
         	if (_makeFullPathFunc == null)
         	{
         		_makeFullPathFunc =
         			(_makeFullPath)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_makeFullPath"), typeof(_makeFullPath));
         	}
         
         	return  _makeFullPathFunc(path, cwd);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _makeRelativePath([MarshalAs(UnmanagedType.LPWStr)]string path, [MarshalAs(UnmanagedType.LPWStr)]string to);
         private static _makeRelativePath _makeRelativePathFunc;
         internal static IntPtr makeRelativePath([MarshalAs(UnmanagedType.LPWStr)]string path, [MarshalAs(UnmanagedType.LPWStr)]string to)
         {
         	if (_makeRelativePathFunc == null)
         	{
         		_makeRelativePathFunc =
         			(_makeRelativePath)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_makeRelativePath"), typeof(_makeRelativePath));
         	}
         
         	return  _makeRelativePathFunc(path, to);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _pathConcat([MarshalAs(UnmanagedType.LPWStr)]string path, [MarshalAs(UnmanagedType.LPWStr)]string file);
         private static _pathConcat _pathConcatFunc;
         internal static IntPtr pathConcat([MarshalAs(UnmanagedType.LPWStr)]string path, [MarshalAs(UnmanagedType.LPWStr)]string file)
         {
         	if (_pathConcatFunc == null)
         	{
         		_pathConcatFunc =
         			(_pathConcat)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_pathConcat"), typeof(_pathConcat));
         	}
         
         	return  _pathConcatFunc(path, file);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getExecutableName();
         private static _getExecutableName _getExecutableNameFunc;
         internal static IntPtr getExecutableName()
         {
         	if (_getExecutableNameFunc == null)
         	{
         		_getExecutableNameFunc =
         			(_getExecutableName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getExecutableName"), typeof(_getExecutableName));
         	}
         
         	return  _getExecutableNameFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getMainDotCsDir();
         private static _getMainDotCsDir _getMainDotCsDirFunc;
         internal static IntPtr getMainDotCsDir()
         {
         	if (_getMainDotCsDirFunc == null)
         	{
         		_getMainDotCsDirFunc =
         			(_getMainDotCsDir)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getMainDotCsDir"), typeof(_getMainDotCsDir));
         	}
         
         	return  _getMainDotCsDirFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _openFolder([MarshalAs(UnmanagedType.LPWStr)]string path);
         private static _openFolder _openFolderFunc;
         internal static void openFolder([MarshalAs(UnmanagedType.LPWStr)]string path)
         {
         	if (_openFolderFunc == null)
         	{
         		_openFolderFunc =
         			(_openFolder)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_openFolder"), typeof(_openFolder));
         	}
         
         	 _openFolderFunc(path);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _openFile([MarshalAs(UnmanagedType.LPWStr)]string file);
         private static _openFile _openFileFunc;
         internal static void openFile([MarshalAs(UnmanagedType.LPWStr)]string file)
         {
         	if (_openFileFunc == null)
         	{
         		_openFileFunc =
         			(_openFile)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_openFile"), typeof(_openFile));
         	}
         
         	 _openFileFunc(file);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _pathCopy([MarshalAs(UnmanagedType.LPWStr)]string fromFile, [MarshalAs(UnmanagedType.LPWStr)]string toFile, bool noOverwrite);
         private static _pathCopy _pathCopyFunc;
         internal static bool pathCopy([MarshalAs(UnmanagedType.LPWStr)]string fromFile, [MarshalAs(UnmanagedType.LPWStr)]string toFile, bool noOverwrite)
         {
         	if (_pathCopyFunc == null)
         	{
         		_pathCopyFunc =
         			(_pathCopy)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_pathCopy"), typeof(_pathCopy));
         	}
         
         	return  _pathCopyFunc(fromFile, toFile, noOverwrite);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getCurrentDirectory();
         private static _getCurrentDirectory _getCurrentDirectoryFunc;
         internal static IntPtr getCurrentDirectory()
         {
         	if (_getCurrentDirectoryFunc == null)
         	{
         		_getCurrentDirectoryFunc =
         			(_getCurrentDirectory)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getCurrentDirectory"), typeof(_getCurrentDirectory));
         	}
         
         	return  _getCurrentDirectoryFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setCurrentDirectory([MarshalAs(UnmanagedType.LPWStr)]string path);
         private static _setCurrentDirectory _setCurrentDirectoryFunc;
         internal static bool setCurrentDirectory([MarshalAs(UnmanagedType.LPWStr)]string path)
         {
         	if (_setCurrentDirectoryFunc == null)
         	{
         		_setCurrentDirectoryFunc =
         			(_setCurrentDirectory)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_setCurrentDirectory"), typeof(_setCurrentDirectory));
         	}
         
         	return  _setCurrentDirectoryFunc(path);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _createPath([MarshalAs(UnmanagedType.LPWStr)]string path);
         private static _createPath _createPathFunc;
         internal static bool createPath([MarshalAs(UnmanagedType.LPWStr)]string path)
         {
         	if (_createPathFunc == null)
         	{
         		_createPathFunc =
         			(_createPath)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_createPath"), typeof(_createPath));
         	}
         
         	return  _createPathFunc(path);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _expandFilename(int argc, string[] argv);
         private static _expandFilename _expandFilenameFunc;
         internal static IntPtr expandFilename(int argc, string[] argv)
         {
         	if (_expandFilenameFunc == null)
         	{
         		_expandFilenameFunc =
         			(_expandFilename)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_expandFilename"), typeof(_expandFilename));
         	}
         
         	return  _expandFilenameFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _expandOldFilename(int argc, string[] argv);
         private static _expandOldFilename _expandOldFilenameFunc;
         internal static IntPtr expandOldFilename(int argc, string[] argv)
         {
         	if (_expandOldFilenameFunc == null)
         	{
         		_expandOldFilenameFunc =
         			(_expandOldFilename)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_expandOldFilename"), typeof(_expandOldFilename));
         	}
         
         	return  _expandOldFilenameFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _collapseFilename(int argc, string[] argv);
         private static _collapseFilename _collapseFilenameFunc;
         internal static IntPtr collapseFilename(int argc, string[] argv)
         {
         	if (_collapseFilenameFunc == null)
         	{
         		_collapseFilenameFunc =
         			(_collapseFilename)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_collapseFilename"), typeof(_collapseFilename));
         	}
         
         	return  _collapseFilenameFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setScriptPathExpando(int argc, string[] argv);
         private static _setScriptPathExpando _setScriptPathExpandoFunc;
         internal static void setScriptPathExpando(int argc, string[] argv)
         {
         	if (_setScriptPathExpandoFunc == null)
         	{
         		_setScriptPathExpandoFunc =
         			(_setScriptPathExpando)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_setScriptPathExpando"), typeof(_setScriptPathExpando));
         	}
         
         	 _setScriptPathExpandoFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeScriptPathExpando(int argc, string[] argv);
         private static _removeScriptPathExpando _removeScriptPathExpandoFunc;
         internal static void removeScriptPathExpando(int argc, string[] argv)
         {
         	if (_removeScriptPathExpandoFunc == null)
         	{
         		_removeScriptPathExpandoFunc =
         			(_removeScriptPathExpando)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_removeScriptPathExpando"), typeof(_removeScriptPathExpando));
         	}
         
         	 _removeScriptPathExpandoFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isScriptPathExpando(int argc, string[] argv);
         private static _isScriptPathExpando _isScriptPathExpandoFunc;
         internal static bool isScriptPathExpando(int argc, string[] argv)
         {
         	if (_isScriptPathExpandoFunc == null)
         	{
         		_isScriptPathExpandoFunc =
         			(_isScriptPathExpando)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_isScriptPathExpando"), typeof(_isScriptPathExpando));
         	}
         
         	return  _isScriptPathExpandoFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _nameToID([MarshalAs(UnmanagedType.LPWStr)]string objectName);
         private static _nameToID _nameToIDFunc;
         internal static int nameToID([MarshalAs(UnmanagedType.LPWStr)]string objectName)
         {
         	if (_nameToIDFunc == null)
         	{
         		_nameToIDFunc =
         			(_nameToID)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_nameToID"), typeof(_nameToID));
         	}
         
         	return  _nameToIDFunc(objectName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isObject([MarshalAs(UnmanagedType.LPWStr)]string objectName);
         private static _isObject _isObjectFunc;
         internal static bool isObject([MarshalAs(UnmanagedType.LPWStr)]string objectName)
         {
         	if (_isObjectFunc == null)
         	{
         		_isObjectFunc =
         			(_isObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_isObject"), typeof(_isObject));
         	}
         
         	return  _isObjectFunc(objectName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _spawnObject([MarshalAs(UnmanagedType.LPWStr)]string spawnClass, [MarshalAs(UnmanagedType.LPWStr)]string spawnDataBlock, [MarshalAs(UnmanagedType.LPWStr)]string spawnName, [MarshalAs(UnmanagedType.LPWStr)]string spawnProperties, [MarshalAs(UnmanagedType.LPWStr)]string spawnScript);
         private static _spawnObject _spawnObjectFunc;
         internal static int spawnObject([MarshalAs(UnmanagedType.LPWStr)]string spawnClass, [MarshalAs(UnmanagedType.LPWStr)]string spawnDataBlock, [MarshalAs(UnmanagedType.LPWStr)]string spawnName, [MarshalAs(UnmanagedType.LPWStr)]string spawnProperties, [MarshalAs(UnmanagedType.LPWStr)]string spawnScript)
         {
         	if (_spawnObjectFunc == null)
         	{
         		_spawnObjectFunc =
         			(_spawnObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_spawnObject"), typeof(_spawnObject));
         	}
         
         	return  _spawnObjectFunc(spawnClass, spawnDataBlock, spawnName, spawnProperties, spawnScript);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _cancel(int eventId);
         private static _cancel _cancelFunc;
         internal static void cancel(int eventId)
         {
         	if (_cancelFunc == null)
         	{
         		_cancelFunc =
         			(_cancel)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_cancel"), typeof(_cancel));
         	}
         
         	 _cancelFunc(eventId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _cancelAll([MarshalAs(UnmanagedType.LPWStr)]string objectId);
         private static _cancelAll _cancelAllFunc;
         internal static void cancelAll([MarshalAs(UnmanagedType.LPWStr)]string objectId)
         {
         	if (_cancelAllFunc == null)
         	{
         		_cancelAllFunc =
         			(_cancelAll)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_cancelAll"), typeof(_cancelAll));
         	}
         
         	 _cancelAllFunc(objectId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isEventPending(int scheduleId);
         private static _isEventPending _isEventPendingFunc;
         internal static bool isEventPending(int scheduleId)
         {
         	if (_isEventPendingFunc == null)
         	{
         		_isEventPendingFunc =
         			(_isEventPending)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_isEventPending"), typeof(_isEventPending));
         	}
         
         	return  _isEventPendingFunc(scheduleId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getEventTimeLeft(int scheduleId);
         private static _getEventTimeLeft _getEventTimeLeftFunc;
         internal static int getEventTimeLeft(int scheduleId)
         {
         	if (_getEventTimeLeftFunc == null)
         	{
         		_getEventTimeLeftFunc =
         			(_getEventTimeLeft)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getEventTimeLeft"), typeof(_getEventTimeLeft));
         	}
         
         	return  _getEventTimeLeftFunc(scheduleId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getScheduleDuration(int scheduleId);
         private static _getScheduleDuration _getScheduleDurationFunc;
         internal static int getScheduleDuration(int scheduleId)
         {
         	if (_getScheduleDurationFunc == null)
         	{
         		_getScheduleDurationFunc =
         			(_getScheduleDuration)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getScheduleDuration"), typeof(_getScheduleDuration));
         	}
         
         	return  _getScheduleDurationFunc(scheduleId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getTimeSinceStart(int scheduleId);
         private static _getTimeSinceStart _getTimeSinceStartFunc;
         internal static int getTimeSinceStart(int scheduleId)
         {
         	if (_getTimeSinceStartFunc == null)
         	{
         		_getTimeSinceStartFunc =
         			(_getTimeSinceStart)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getTimeSinceStart"), typeof(_getTimeSinceStart));
         	}
         
         	return  _getTimeSinceStartFunc(scheduleId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _schedule(int argc, string[] argv);
         private static _schedule _scheduleFunc;
         internal static int schedule(int argc, string[] argv)
         {
         	if (_scheduleFunc == null)
         	{
         		_scheduleFunc =
         			(_schedule)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_schedule"), typeof(_schedule));
         	}
         
         	return  _scheduleFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getUniqueName([MarshalAs(UnmanagedType.LPWStr)]string baseName);
         private static _getUniqueName _getUniqueNameFunc;
         internal static IntPtr getUniqueName([MarshalAs(UnmanagedType.LPWStr)]string baseName)
         {
         	if (_getUniqueNameFunc == null)
         	{
         		_getUniqueNameFunc =
         			(_getUniqueName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getUniqueName"), typeof(_getUniqueName));
         	}
         
         	return  _getUniqueNameFunc(baseName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getUniqueInternalName([MarshalAs(UnmanagedType.LPWStr)]string baseName, [MarshalAs(UnmanagedType.LPWStr)]string setString, bool searchChildren);
         private static _getUniqueInternalName _getUniqueInternalNameFunc;
         internal static IntPtr getUniqueInternalName([MarshalAs(UnmanagedType.LPWStr)]string baseName, [MarshalAs(UnmanagedType.LPWStr)]string setString, bool searchChildren)
         {
         	if (_getUniqueInternalNameFunc == null)
         	{
         		_getUniqueInternalNameFunc =
         			(_getUniqueInternalName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getUniqueInternalName"), typeof(_getUniqueInternalName));
         	}
         
         	return  _getUniqueInternalNameFunc(baseName, setString, searchChildren);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isValidObjectName([MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _isValidObjectName _isValidObjectNameFunc;
         internal static bool isValidObjectName([MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_isValidObjectNameFunc == null)
         	{
         		_isValidObjectNameFunc =
         			(_isValidObjectName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_isValidObjectName"), typeof(_isValidObjectName));
         	}
         
         	return  _isValidObjectNameFunc(name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _preloadClientDataBlocks();
         private static _preloadClientDataBlocks _preloadClientDataBlocksFunc;
         internal static void preloadClientDataBlocks()
         {
         	if (_preloadClientDataBlocksFunc == null)
         	{
         		_preloadClientDataBlocksFunc =
         			(_preloadClientDataBlocks)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_preloadClientDataBlocks"), typeof(_preloadClientDataBlocks));
         	}
         
         	 _preloadClientDataBlocksFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _deleteDataBlocks();
         private static _deleteDataBlocks _deleteDataBlocksFunc;
         internal static void deleteDataBlocks()
         {
         	if (_deleteDataBlocksFunc == null)
         	{
         		_deleteDataBlocksFunc =
         			(_deleteDataBlocks)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_deleteDataBlocks"), typeof(_deleteDataBlocks));
         	}
         
         	 _deleteDataBlocksFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _debugEnumInstances([MarshalAs(UnmanagedType.LPWStr)]string className, [MarshalAs(UnmanagedType.LPWStr)]string functionName);
         private static _debugEnumInstances _debugEnumInstancesFunc;
         internal static void debugEnumInstances([MarshalAs(UnmanagedType.LPWStr)]string className, [MarshalAs(UnmanagedType.LPWStr)]string functionName)
         {
         	if (_debugEnumInstancesFunc == null)
         	{
         		_debugEnumInstancesFunc =
         			(_debugEnumInstances)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_debugEnumInstances"), typeof(_debugEnumInstances));
         	}
         
         	 _debugEnumInstancesFunc(className, functionName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _saveObject(IntPtr _object, [MarshalAs(UnmanagedType.LPWStr)]string filename);
         private static _saveObject _saveObjectFunc;
         internal static bool saveObject(IntPtr _object, [MarshalAs(UnmanagedType.LPWStr)]string filename)
         {
         	if (_saveObjectFunc == null)
         	{
         		_saveObjectFunc =
         			(_saveObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_saveObject"), typeof(_saveObject));
         	}
         
         	return  _saveObjectFunc(_object, filename);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _loadObject([MarshalAs(UnmanagedType.LPWStr)]string filename);
         private static _loadObject _loadObjectFunc;
         internal static IntPtr loadObject([MarshalAs(UnmanagedType.LPWStr)]string filename)
         {
         	if (_loadObjectFunc == null)
         	{
         		_loadObjectFunc =
         			(_loadObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_loadObject"), typeof(_loadObject));
         	}
         
         	return  _loadObjectFunc(filename);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _telnetSetParameters(int port, [MarshalAs(UnmanagedType.LPWStr)]string consolePass, [MarshalAs(UnmanagedType.LPWStr)]string listenPass, bool remoteEcho);
         private static _telnetSetParameters _telnetSetParametersFunc;
         internal static void telnetSetParameters(int port, [MarshalAs(UnmanagedType.LPWStr)]string consolePass, [MarshalAs(UnmanagedType.LPWStr)]string listenPass, bool remoteEcho)
         {
         	if (_telnetSetParametersFunc == null)
         	{
         		_telnetSetParametersFunc =
         			(_telnetSetParameters)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_telnetSetParameters"), typeof(_telnetSetParameters));
         	}
         
         	 _telnetSetParametersFunc(port, consolePass, listenPass, remoteEcho);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _dbgSetParameters(int port, [MarshalAs(UnmanagedType.LPWStr)]string password, bool waitForClient);
         private static _dbgSetParameters _dbgSetParametersFunc;
         internal static void dbgSetParameters(int port, [MarshalAs(UnmanagedType.LPWStr)]string password, bool waitForClient)
         {
         	if (_dbgSetParametersFunc == null)
         	{
         		_dbgSetParametersFunc =
         			(_dbgSetParameters)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_dbgSetParameters"), typeof(_dbgSetParameters));
         	}
         
         	 _dbgSetParametersFunc(port, password, waitForClient);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _dbgIsConnected();
         private static _dbgIsConnected _dbgIsConnectedFunc;
         internal static bool dbgIsConnected()
         {
         	if (_dbgIsConnectedFunc == null)
         	{
         		_dbgIsConnectedFunc =
         			(_dbgIsConnected)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_dbgIsConnected"), typeof(_dbgIsConnected));
         	}
         
         	return  _dbgIsConnectedFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _dbgDisconnect();
         private static _dbgDisconnect _dbgDisconnectFunc;
         internal static void dbgDisconnect()
         {
         	if (_dbgDisconnectFunc == null)
         	{
         		_dbgDisconnectFunc =
         			(_dbgDisconnect)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_dbgDisconnect"), typeof(_dbgDisconnect));
         	}
         
         	 _dbgDisconnectFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getStockColorCount(int argc, string[] argv);
         private static _getStockColorCount _getStockColorCountFunc;
         internal static int getStockColorCount(int argc, string[] argv)
         {
         	if (_getStockColorCountFunc == null)
         	{
         		_getStockColorCountFunc =
         			(_getStockColorCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getStockColorCount"), typeof(_getStockColorCount));
         	}
         
         	return  _getStockColorCountFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getStockColorName(int argc, string[] argv);
         private static _getStockColorName _getStockColorNameFunc;
         internal static IntPtr getStockColorName(int argc, string[] argv)
         {
         	if (_getStockColorNameFunc == null)
         	{
         		_getStockColorNameFunc =
         			(_getStockColorName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getStockColorName"), typeof(_getStockColorName));
         	}
         
         	return  _getStockColorNameFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isStockColor(int argc, string[] argv);
         private static _isStockColor _isStockColorFunc;
         internal static bool isStockColor(int argc, string[] argv)
         {
         	if (_isStockColorFunc == null)
         	{
         		_isStockColorFunc =
         			(_isStockColor)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_isStockColor"), typeof(_isStockColor));
         	}
         
         	return  _isStockColorFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getStockColorF(int argc, string[] argv);
         private static _getStockColorF _getStockColorFFunc;
         internal static IntPtr getStockColorF(int argc, string[] argv)
         {
         	if (_getStockColorFFunc == null)
         	{
         		_getStockColorFFunc =
         			(_getStockColorF)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getStockColorF"), typeof(_getStockColorF));
         	}
         
         	return  _getStockColorFFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getStockColorI(int argc, string[] argv);
         private static _getStockColorI _getStockColorIFunc;
         internal static IntPtr getStockColorI(int argc, string[] argv)
         {
         	if (_getStockColorIFunc == null)
         	{
         		_getStockColorIFunc =
         			(_getStockColorI)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getStockColorI"), typeof(_getStockColorI));
         	}
         
         	return  _getStockColorIFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _DNetSetLogging(bool enabled);
         private static _DNetSetLogging _DNetSetLoggingFunc;
         internal static void DNetSetLogging(bool enabled)
         {
         	if (_DNetSetLoggingFunc == null)
         	{
         		_DNetSetLoggingFunc =
         			(_DNetSetLogging)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_DNetSetLogging"), typeof(_DNetSetLogging));
         	}
         
         	 _DNetSetLoggingFunc(enabled);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getMaxFrameAllocation(int argc, string[] argv);
         private static _getMaxFrameAllocation _getMaxFrameAllocationFunc;
         internal static int getMaxFrameAllocation(int argc, string[] argv)
         {
         	if (_getMaxFrameAllocationFunc == null)
         	{
         		_getMaxFrameAllocationFunc =
         			(_getMaxFrameAllocation)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getMaxFrameAllocation"), typeof(_getMaxFrameAllocation));
         	}
         
         	return  _getMaxFrameAllocationFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _resourceDump(int argc, string[] argv);
         private static _resourceDump _resourceDumpFunc;
         internal static void resourceDump(int argc, string[] argv)
         {
         	if (_resourceDumpFunc == null)
         	{
         		_resourceDumpFunc =
         			(_resourceDump)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_resourceDump"), typeof(_resourceDump));
         	}
         
         	 _resourceDumpFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _reloadResource([MarshalAs(UnmanagedType.LPWStr)]string path);
         private static _reloadResource _reloadResourceFunc;
         internal static void reloadResource([MarshalAs(UnmanagedType.LPWStr)]string path)
         {
         	if (_reloadResourceFunc == null)
         	{
         		_reloadResourceFunc =
         			(_reloadResource)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_reloadResource"), typeof(_reloadResource));
         	}
         
         	 _reloadResourceFunc(path);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sbmDumpStats();
         private static _sbmDumpStats _sbmDumpStatsFunc;
         internal static void sbmDumpStats()
         {
         	if (_sbmDumpStatsFunc == null)
         	{
         		_sbmDumpStatsFunc =
         			(_sbmDumpStats)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_sbmDumpStats"), typeof(_sbmDumpStats));
         	}
         
         	 _sbmDumpStatsFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sbmDumpStrings();
         private static _sbmDumpStrings _sbmDumpStringsFunc;
         internal static void sbmDumpStrings()
         {
         	if (_sbmDumpStringsFunc == null)
         	{
         		_sbmDumpStringsFunc =
         			(_sbmDumpStrings)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_sbmDumpStrings"), typeof(_sbmDumpStrings));
         	}
         
         	 _sbmDumpStringsFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _dumpStringMemStats();
         private static _dumpStringMemStats _dumpStringMemStatsFunc;
         internal static void dumpStringMemStats()
         {
         	if (_dumpStringMemStatsFunc == null)
         	{
         		_dumpStringMemStatsFunc =
         			(_dumpStringMemStats)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_dumpStringMemStats"), typeof(_dumpStringMemStats));
         	}
         
         	 _dumpStringMemStatsFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getCoreLangTable();
         private static _getCoreLangTable _getCoreLangTableFunc;
         internal static int getCoreLangTable()
         {
         	if (_getCoreLangTableFunc == null)
         	{
         		_getCoreLangTableFunc =
         			(_getCoreLangTable)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getCoreLangTable"), typeof(_getCoreLangTable));
         	}
         
         	return  _getCoreLangTableFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setCoreLangTable([MarshalAs(UnmanagedType.LPWStr)]string lgTable);
         private static _setCoreLangTable _setCoreLangTableFunc;
         internal static void setCoreLangTable([MarshalAs(UnmanagedType.LPWStr)]string lgTable)
         {
         	if (_setCoreLangTableFunc == null)
         	{
         		_setCoreLangTableFunc =
         			(_setCoreLangTable)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_setCoreLangTable"), typeof(_setCoreLangTable));
         	}
         
         	 _setCoreLangTableFunc(lgTable);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _CompileLanguage(int argc, string[] argv);
         private static _CompileLanguage _CompileLanguageFunc;
         internal static void CompileLanguage(int argc, string[] argv)
         {
         	if (_CompileLanguageFunc == null)
         	{
         		_CompileLanguageFunc =
         			(_CompileLanguage)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_CompileLanguage"), typeof(_CompileLanguage));
         	}
         
         	 _CompileLanguageFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getCurrentActionMap();
         private static _getCurrentActionMap _getCurrentActionMapFunc;
         internal static IntPtr getCurrentActionMap()
         {
         	if (_getCurrentActionMapFunc == null)
         	{
         		_getCurrentActionMapFunc =
         			(_getCurrentActionMap)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getCurrentActionMap"), typeof(_getCurrentActionMap));
         	}
         
         	return  _getCurrentActionMapFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _allowConnections(bool allow);
         private static _allowConnections _allowConnectionsFunc;
         internal static void allowConnections(bool allow)
         {
         	if (_allowConnectionsFunc == null)
         	{
         		_allowConnectionsFunc =
         			(_allowConnections)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_allowConnections"), typeof(_allowConnections));
         	}
         
         	 _allowConnectionsFunc(allow);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _dumpNetStringTable();
         private static _dumpNetStringTable _dumpNetStringTableFunc;
         internal static void dumpNetStringTable()
         {
         	if (_dumpNetStringTableFunc == null)
         	{
         		_dumpNetStringTableFunc =
         			(_dumpNetStringTable)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_dumpNetStringTable"), typeof(_dumpNetStringTable));
         	}
         
         	 _dumpNetStringTableFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _resetFPSTracker();
         private static _resetFPSTracker _resetFPSTrackerFunc;
         internal static void resetFPSTracker()
         {
         	if (_resetFPSTrackerFunc == null)
         	{
         		_resetFPSTrackerFunc =
         			(_resetFPSTracker)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_resetFPSTracker"), typeof(_resetFPSTracker));
         	}
         
         	 _resetFPSTrackerFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _beginSampling([MarshalAs(UnmanagedType.LPWStr)]string location, [MarshalAs(UnmanagedType.LPWStr)]string backend);
         private static _beginSampling _beginSamplingFunc;
         internal static void beginSampling([MarshalAs(UnmanagedType.LPWStr)]string location, [MarshalAs(UnmanagedType.LPWStr)]string backend)
         {
         	if (_beginSamplingFunc == null)
         	{
         		_beginSamplingFunc =
         			(_beginSampling)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_beginSampling"), typeof(_beginSampling));
         	}
         
         	 _beginSamplingFunc(location, backend);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _stopSampling();
         private static _stopSampling _stopSamplingFunc;
         internal static void stopSampling()
         {
         	if (_stopSamplingFunc == null)
         	{
         		_stopSamplingFunc =
         			(_stopSampling)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_stopSampling"), typeof(_stopSampling));
         	}
         
         	 _stopSamplingFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _enableSamples([MarshalAs(UnmanagedType.LPWStr)]string pattern, bool state);
         private static _enableSamples _enableSamplesFunc;
         internal static void enableSamples([MarshalAs(UnmanagedType.LPWStr)]string pattern, bool state)
         {
         	if (_enableSamplesFunc == null)
         	{
         		_enableSamplesFunc =
         			(_enableSamples)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_enableSamples"), typeof(_enableSamples));
         	}
         
         	 _enableSamplesFunc(pattern, state);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _mSolveQuadratic(float a, float b, float c);
         private static _mSolveQuadratic _mSolveQuadraticFunc;
         internal static IntPtr mSolveQuadratic(float a, float b, float c)
         {
         	if (_mSolveQuadraticFunc == null)
         	{
         		_mSolveQuadraticFunc =
         			(_mSolveQuadratic)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_mSolveQuadratic"), typeof(_mSolveQuadratic));
         	}
         
         	return  _mSolveQuadraticFunc(a, b, c);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _mSolveCubic(float a, float b, float c, float d);
         private static _mSolveCubic _mSolveCubicFunc;
         internal static IntPtr mSolveCubic(float a, float b, float c, float d)
         {
         	if (_mSolveCubicFunc == null)
         	{
         		_mSolveCubicFunc =
         			(_mSolveCubic)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_mSolveCubic"), typeof(_mSolveCubic));
         	}
         
         	return  _mSolveCubicFunc(a, b, c, d);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _mSolveQuartic(float a, float b, float c, float d, float e);
         private static _mSolveQuartic _mSolveQuarticFunc;
         internal static IntPtr mSolveQuartic(float a, float b, float c, float d, float e)
         {
         	if (_mSolveQuarticFunc == null)
         	{
         		_mSolveQuarticFunc =
         			(_mSolveQuartic)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_mSolveQuartic"), typeof(_mSolveQuartic));
         	}
         
         	return  _mSolveQuarticFunc(a, b, c, d, e);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _mFloor(float v);
         private static _mFloor _mFloorFunc;
         internal static int mFloor(float v)
         {
         	if (_mFloorFunc == null)
         	{
         		_mFloorFunc =
         			(_mFloor)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_mFloor"), typeof(_mFloor));
         	}
         
         	return  _mFloorFunc(v);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _mRound(float v);
         private static _mRound _mRoundFunc;
         internal static int mRound(float v)
         {
         	if (_mRoundFunc == null)
         	{
         		_mRoundFunc =
         			(_mRound)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_mRound"), typeof(_mRound));
         	}
         
         	return  _mRoundFunc(v);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _mRoundColour(float v, int n);
         private static _mRoundColour _mRoundColourFunc;
         internal static float mRoundColour(float v, int n)
         {
         	if (_mRoundColourFunc == null)
         	{
         		_mRoundColourFunc =
         			(_mRoundColour)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_mRoundColour"), typeof(_mRoundColour));
         	}
         
         	return  _mRoundColourFunc(v, n);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _mCeil(float v);
         private static _mCeil _mCeilFunc;
         internal static int mCeil(float v)
         {
         	if (_mCeilFunc == null)
         	{
         		_mCeilFunc =
         			(_mCeil)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_mCeil"), typeof(_mCeil));
         	}
         
         	return  _mCeilFunc(v);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _mFloatLength(float v, uint precision);
         private static _mFloatLength _mFloatLengthFunc;
         internal static IntPtr mFloatLength(float v, uint precision)
         {
         	if (_mFloatLengthFunc == null)
         	{
         		_mFloatLengthFunc =
         			(_mFloatLength)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_mFloatLength"), typeof(_mFloatLength));
         	}
         
         	return  _mFloatLengthFunc(v, precision);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _mAbs(float v);
         private static _mAbs _mAbsFunc;
         internal static float mAbs(float v)
         {
         	if (_mAbsFunc == null)
         	{
         		_mAbsFunc =
         			(_mAbs)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_mAbs"), typeof(_mAbs));
         	}
         
         	return  _mAbsFunc(v);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _mFMod(float v, float d);
         private static _mFMod _mFModFunc;
         internal static float mFMod(float v, float d)
         {
         	if (_mFModFunc == null)
         	{
         		_mFModFunc =
         			(_mFMod)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_mFMod"), typeof(_mFMod));
         	}
         
         	return  _mFModFunc(v, d);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _mSqrt(float v);
         private static _mSqrt _mSqrtFunc;
         internal static float mSqrt(float v)
         {
         	if (_mSqrtFunc == null)
         	{
         		_mSqrtFunc =
         			(_mSqrt)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_mSqrt"), typeof(_mSqrt));
         	}
         
         	return  _mSqrtFunc(v);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _mPow(float v, float p);
         private static _mPow _mPowFunc;
         internal static float mPow(float v, float p)
         {
         	if (_mPowFunc == null)
         	{
         		_mPowFunc =
         			(_mPow)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_mPow"), typeof(_mPow));
         	}
         
         	return  _mPowFunc(v, p);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _mLog(float v);
         private static _mLog _mLogFunc;
         internal static float mLog(float v)
         {
         	if (_mLogFunc == null)
         	{
         		_mLogFunc =
         			(_mLog)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_mLog"), typeof(_mLog));
         	}
         
         	return  _mLogFunc(v);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _mSin(float v);
         private static _mSin _mSinFunc;
         internal static float mSin(float v)
         {
         	if (_mSinFunc == null)
         	{
         		_mSinFunc =
         			(_mSin)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_mSin"), typeof(_mSin));
         	}
         
         	return  _mSinFunc(v);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _mCos(float v);
         private static _mCos _mCosFunc;
         internal static float mCos(float v)
         {
         	if (_mCosFunc == null)
         	{
         		_mCosFunc =
         			(_mCos)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_mCos"), typeof(_mCos));
         	}
         
         	return  _mCosFunc(v);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _mTan(float v);
         private static _mTan _mTanFunc;
         internal static float mTan(float v)
         {
         	if (_mTanFunc == null)
         	{
         		_mTanFunc =
         			(_mTan)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_mTan"), typeof(_mTan));
         	}
         
         	return  _mTanFunc(v);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _mAsin(float v);
         private static _mAsin _mAsinFunc;
         internal static float mAsin(float v)
         {
         	if (_mAsinFunc == null)
         	{
         		_mAsinFunc =
         			(_mAsin)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_mAsin"), typeof(_mAsin));
         	}
         
         	return  _mAsinFunc(v);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _mAcos(float v);
         private static _mAcos _mAcosFunc;
         internal static float mAcos(float v)
         {
         	if (_mAcosFunc == null)
         	{
         		_mAcosFunc =
         			(_mAcos)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_mAcos"), typeof(_mAcos));
         	}
         
         	return  _mAcosFunc(v);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _mAtan(float rise, float run);
         private static _mAtan _mAtanFunc;
         internal static float mAtan(float rise, float run)
         {
         	if (_mAtanFunc == null)
         	{
         		_mAtanFunc =
         			(_mAtan)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_mAtan"), typeof(_mAtan));
         	}
         
         	return  _mAtanFunc(rise, run);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _mRadToDeg(float radians);
         private static _mRadToDeg _mRadToDegFunc;
         internal static float mRadToDeg(float radians)
         {
         	if (_mRadToDegFunc == null)
         	{
         		_mRadToDegFunc =
         			(_mRadToDeg)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_mRadToDeg"), typeof(_mRadToDeg));
         	}
         
         	return  _mRadToDegFunc(radians);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _mDegToRad(float degrees);
         private static _mDegToRad _mDegToRadFunc;
         internal static float mDegToRad(float degrees)
         {
         	if (_mDegToRadFunc == null)
         	{
         		_mDegToRadFunc =
         			(_mDegToRad)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_mDegToRad"), typeof(_mDegToRad));
         	}
         
         	return  _mDegToRadFunc(degrees);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _mClamp(float v, float min, float max);
         private static _mClamp _mClampFunc;
         internal static float mClamp(float v, float min, float max)
         {
         	if (_mClampFunc == null)
         	{
         		_mClampFunc =
         			(_mClamp)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_mClamp"), typeof(_mClamp));
         	}
         
         	return  _mClampFunc(v, min, max);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _mSaturate(float v);
         private static _mSaturate _mSaturateFunc;
         internal static float mSaturate(float v)
         {
         	if (_mSaturateFunc == null)
         	{
         		_mSaturateFunc =
         			(_mSaturate)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_mSaturate"), typeof(_mSaturate));
         	}
         
         	return  _mSaturateFunc(v);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getMax(float v1, float v2);
         private static _getMax _getMaxFunc;
         internal static float getMax(float v1, float v2)
         {
         	if (_getMaxFunc == null)
         	{
         		_getMaxFunc =
         			(_getMax)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getMax"), typeof(_getMax));
         	}
         
         	return  _getMaxFunc(v1, v2);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getMin(float v1, float v2);
         private static _getMin _getMinFunc;
         internal static float getMin(float v1, float v2)
         {
         	if (_getMinFunc == null)
         	{
         		_getMinFunc =
         			(_getMin)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getMin"), typeof(_getMin));
         	}
         
         	return  _getMinFunc(v1, v2);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _mLerp(float v1, float v2, float time);
         private static _mLerp _mLerpFunc;
         internal static float mLerp(float v1, float v2, float time)
         {
         	if (_mLerpFunc == null)
         	{
         		_mLerpFunc =
         			(_mLerp)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_mLerp"), typeof(_mLerp));
         	}
         
         	return  _mLerpFunc(v1, v2, time);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _mPi();
         private static _mPi _mPiFunc;
         internal static float mPi()
         {
         	if (_mPiFunc == null)
         	{
         		_mPiFunc =
         			(_mPi)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_mPi"), typeof(_mPi));
         	}
         
         	return  _mPiFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _m2Pi();
         private static _m2Pi _m2PiFunc;
         internal static float m2Pi()
         {
         	if (_m2PiFunc == null)
         	{
         		_m2PiFunc =
         			(_m2Pi)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_m2Pi"), typeof(_m2Pi));
         	}
         
         	return  _m2PiFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _mIsPow2(int v);
         private static _mIsPow2 _mIsPow2Func;
         internal static bool mIsPow2(int v)
         {
         	if (_mIsPow2Func == null)
         	{
         		_mIsPow2Func =
         			(_mIsPow2)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_mIsPow2"), typeof(_mIsPow2));
         	}
         
         	return  _mIsPow2Func(v);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _VectorAdd(InternalPoint3FStruct a, InternalPoint3FStruct b);
         private static _VectorAdd _VectorAddFunc;
         internal static InternalPoint3FStruct VectorAdd(InternalPoint3FStruct a, InternalPoint3FStruct b)
         {
         	if (_VectorAddFunc == null)
         	{
         		_VectorAddFunc =
         			(_VectorAdd)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_VectorAdd"), typeof(_VectorAdd));
         	}
         
         	return  _VectorAddFunc(a, b);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _VectorSub(InternalPoint3FStruct a, InternalPoint3FStruct b);
         private static _VectorSub _VectorSubFunc;
         internal static InternalPoint3FStruct VectorSub(InternalPoint3FStruct a, InternalPoint3FStruct b)
         {
         	if (_VectorSubFunc == null)
         	{
         		_VectorSubFunc =
         			(_VectorSub)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_VectorSub"), typeof(_VectorSub));
         	}
         
         	return  _VectorSubFunc(a, b);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _VectorScale(InternalPoint3FStruct a, float scalar);
         private static _VectorScale _VectorScaleFunc;
         internal static InternalPoint3FStruct VectorScale(InternalPoint3FStruct a, float scalar)
         {
         	if (_VectorScaleFunc == null)
         	{
         		_VectorScaleFunc =
         			(_VectorScale)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_VectorScale"), typeof(_VectorScale));
         	}
         
         	return  _VectorScaleFunc(a, scalar);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _VectorMul(InternalPoint3FStruct a, InternalPoint3FStruct b);
         private static _VectorMul _VectorMulFunc;
         internal static InternalPoint3FStruct VectorMul(InternalPoint3FStruct a, InternalPoint3FStruct b)
         {
         	if (_VectorMulFunc == null)
         	{
         		_VectorMulFunc =
         			(_VectorMul)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_VectorMul"), typeof(_VectorMul));
         	}
         
         	return  _VectorMulFunc(a, b);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _VectorDiv(InternalPoint3FStruct a, InternalPoint3FStruct b);
         private static _VectorDiv _VectorDivFunc;
         internal static InternalPoint3FStruct VectorDiv(InternalPoint3FStruct a, InternalPoint3FStruct b)
         {
         	if (_VectorDivFunc == null)
         	{
         		_VectorDivFunc =
         			(_VectorDiv)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_VectorDiv"), typeof(_VectorDiv));
         	}
         
         	return  _VectorDivFunc(a, b);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _VectorNormalize(InternalPoint3FStruct v);
         private static _VectorNormalize _VectorNormalizeFunc;
         internal static InternalPoint3FStruct VectorNormalize(InternalPoint3FStruct v)
         {
         	if (_VectorNormalizeFunc == null)
         	{
         		_VectorNormalizeFunc =
         			(_VectorNormalize)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_VectorNormalize"), typeof(_VectorNormalize));
         	}
         
         	return  _VectorNormalizeFunc(v);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _VectorDot(InternalPoint3FStruct a, InternalPoint3FStruct b);
         private static _VectorDot _VectorDotFunc;
         internal static float VectorDot(InternalPoint3FStruct a, InternalPoint3FStruct b)
         {
         	if (_VectorDotFunc == null)
         	{
         		_VectorDotFunc =
         			(_VectorDot)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_VectorDot"), typeof(_VectorDot));
         	}
         
         	return  _VectorDotFunc(a, b);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _VectorCross(InternalPoint3FStruct a, InternalPoint3FStruct b);
         private static _VectorCross _VectorCrossFunc;
         internal static InternalPoint3FStruct VectorCross(InternalPoint3FStruct a, InternalPoint3FStruct b)
         {
         	if (_VectorCrossFunc == null)
         	{
         		_VectorCrossFunc =
         			(_VectorCross)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_VectorCross"), typeof(_VectorCross));
         	}
         
         	return  _VectorCrossFunc(a, b);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _VectorDist(InternalPoint3FStruct a, InternalPoint3FStruct b);
         private static _VectorDist _VectorDistFunc;
         internal static float VectorDist(InternalPoint3FStruct a, InternalPoint3FStruct b)
         {
         	if (_VectorDistFunc == null)
         	{
         		_VectorDistFunc =
         			(_VectorDist)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_VectorDist"), typeof(_VectorDist));
         	}
         
         	return  _VectorDistFunc(a, b);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _VectorMidPoint(InternalPoint3FStruct a, InternalPoint3FStruct b);
         private static _VectorMidPoint _VectorMidPointFunc;
         internal static InternalPoint3FStruct VectorMidPoint(InternalPoint3FStruct a, InternalPoint3FStruct b)
         {
         	if (_VectorMidPointFunc == null)
         	{
         		_VectorMidPointFunc =
         			(_VectorMidPoint)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_VectorMidPoint"), typeof(_VectorMidPoint));
         	}
         
         	return  _VectorMidPointFunc(a, b);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _VectorLen(InternalPoint3FStruct v);
         private static _VectorLen _VectorLenFunc;
         internal static float VectorLen(InternalPoint3FStruct v)
         {
         	if (_VectorLenFunc == null)
         	{
         		_VectorLenFunc =
         			(_VectorLen)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_VectorLen"), typeof(_VectorLen));
         	}
         
         	return  _VectorLenFunc(v);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalMatrixFStruct _VectorOrthoBasis(InternalAngAxisFStruct aa);
         private static _VectorOrthoBasis _VectorOrthoBasisFunc;
         internal static InternalMatrixFStruct VectorOrthoBasis(InternalAngAxisFStruct aa)
         {
         	if (_VectorOrthoBasisFunc == null)
         	{
         		_VectorOrthoBasisFunc =
         			(_VectorOrthoBasis)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_VectorOrthoBasis"), typeof(_VectorOrthoBasis));
         	}
         
         	return  _VectorOrthoBasisFunc(aa);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _VectorRot(InternalPoint3FStruct v, float angle);
         private static _VectorRot _VectorRotFunc;
         internal static IntPtr VectorRot(InternalPoint3FStruct v, float angle)
         {
         	if (_VectorRotFunc == null)
         	{
         		_VectorRotFunc =
         			(_VectorRot)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_VectorRot"), typeof(_VectorRot));
         	}
         
         	return  _VectorRotFunc(v, angle);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _VectorLerp(InternalPoint3FStruct a, InternalPoint3FStruct b, float t);
         private static _VectorLerp _VectorLerpFunc;
         internal static InternalPoint3FStruct VectorLerp(InternalPoint3FStruct a, InternalPoint3FStruct b, float t)
         {
         	if (_VectorLerpFunc == null)
         	{
         		_VectorLerpFunc =
         			(_VectorLerp)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_VectorLerp"), typeof(_VectorLerp));
         	}
         
         	return  _VectorLerpFunc(a, b, t);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalTransformFStruct _MatrixCreate(InternalPoint3FStruct position, InternalAngAxisFStruct orientation);
         private static _MatrixCreate _MatrixCreateFunc;
         internal static InternalTransformFStruct MatrixCreate(InternalPoint3FStruct position, InternalAngAxisFStruct orientation)
         {
         	if (_MatrixCreateFunc == null)
         	{
         		_MatrixCreateFunc =
         			(_MatrixCreate)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_MatrixCreate"), typeof(_MatrixCreate));
         	}
         
         	return  _MatrixCreateFunc(position, orientation);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalTransformFStruct _MatrixCreateFromEuler(InternalPoint3FStruct angles);
         private static _MatrixCreateFromEuler _MatrixCreateFromEulerFunc;
         internal static InternalTransformFStruct MatrixCreateFromEuler(InternalPoint3FStruct angles)
         {
         	if (_MatrixCreateFromEulerFunc == null)
         	{
         		_MatrixCreateFromEulerFunc =
         			(_MatrixCreateFromEuler)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_MatrixCreateFromEuler"), typeof(_MatrixCreateFromEuler));
         	}
         
         	return  _MatrixCreateFromEulerFunc(angles);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalTransformFStruct _MatrixMultiply(InternalTransformFStruct left, InternalTransformFStruct right);
         private static _MatrixMultiply _MatrixMultiplyFunc;
         internal static InternalTransformFStruct MatrixMultiply(InternalTransformFStruct left, InternalTransformFStruct right)
         {
         	if (_MatrixMultiplyFunc == null)
         	{
         		_MatrixMultiplyFunc =
         			(_MatrixMultiply)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_MatrixMultiply"), typeof(_MatrixMultiply));
         	}
         
         	return  _MatrixMultiplyFunc(left, right);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _MatrixMulVector(InternalTransformFStruct transform, InternalPoint3FStruct vector);
         private static _MatrixMulVector _MatrixMulVectorFunc;
         internal static InternalPoint3FStruct MatrixMulVector(InternalTransformFStruct transform, InternalPoint3FStruct vector)
         {
         	if (_MatrixMulVectorFunc == null)
         	{
         		_MatrixMulVectorFunc =
         			(_MatrixMulVector)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_MatrixMulVector"), typeof(_MatrixMulVector));
         	}
         
         	return  _MatrixMulVectorFunc(transform, vector);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _MatrixMulPoint(InternalTransformFStruct transform, InternalPoint3FStruct point);
         private static _MatrixMulPoint _MatrixMulPointFunc;
         internal static InternalPoint3FStruct MatrixMulPoint(InternalTransformFStruct transform, InternalPoint3FStruct point)
         {
         	if (_MatrixMulPointFunc == null)
         	{
         		_MatrixMulPointFunc =
         			(_MatrixMulPoint)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_MatrixMulPoint"), typeof(_MatrixMulPoint));
         	}
         
         	return  _MatrixMulPointFunc(transform, point);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getBoxCenter(InternalBox3FStruct box);
         private static _getBoxCenter _getBoxCenterFunc;
         internal static InternalPoint3FStruct getBoxCenter(InternalBox3FStruct box)
         {
         	if (_getBoxCenterFunc == null)
         	{
         		_getBoxCenterFunc =
         			(_getBoxCenter)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getBoxCenter"), typeof(_getBoxCenter));
         	}
         
         	return  _getBoxCenterFunc(box);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setRandomSeed(int seed);
         private static _setRandomSeed _setRandomSeedFunc;
         internal static void setRandomSeed(int seed)
         {
         	if (_setRandomSeedFunc == null)
         	{
         		_setRandomSeedFunc =
         			(_setRandomSeed)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_setRandomSeed"), typeof(_setRandomSeed));
         	}
         
         	 _setRandomSeedFunc(seed);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getRandomSeed();
         private static _getRandomSeed _getRandomSeedFunc;
         internal static int getRandomSeed()
         {
         	if (_getRandomSeedFunc == null)
         	{
         		_getRandomSeedFunc =
         			(_getRandomSeed)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getRandomSeed"), typeof(_getRandomSeed));
         	}
         
         	return  _getRandomSeedFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getRandom(int a, int b);
         private static _getRandom _getRandomFunc;
         internal static float getRandom(int a, int b)
         {
         	if (_getRandomFunc == null)
         	{
         		_getRandomFunc =
         			(_getRandom)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getRandom"), typeof(_getRandom));
         	}
         
         	return  _getRandomFunc(a, b);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _restartInstance(int argc, string[] argv);
         private static _restartInstance _restartInstanceFunc;
         internal static void restartInstance(int argc, string[] argv)
         {
         	if (_restartInstanceFunc == null)
         	{
         		_restartInstanceFunc =
         			(_restartInstance)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_restartInstance"), typeof(_restartInstance));
         	}
         
         	 _restartInstanceFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _Assert(int argc, string[] argv);
         private static _Assert _AssertFunc;
         internal static void Assert(int argc, string[] argv)
         {
         	if (_AssertFunc == null)
         	{
         		_AssertFunc =
         			(_Assert)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_Assert"), typeof(_Assert));
         	}
         
         	 _AssertFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getTemporaryDirectory();
         private static _getTemporaryDirectory _getTemporaryDirectoryFunc;
         internal static IntPtr getTemporaryDirectory()
         {
         	if (_getTemporaryDirectoryFunc == null)
         	{
         		_getTemporaryDirectoryFunc =
         			(_getTemporaryDirectory)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getTemporaryDirectory"), typeof(_getTemporaryDirectory));
         	}
         
         	return  _getTemporaryDirectoryFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getTemporaryFileName();
         private static _getTemporaryFileName _getTemporaryFileNameFunc;
         internal static IntPtr getTemporaryFileName()
         {
         	if (_getTemporaryFileNameFunc == null)
         	{
         		_getTemporaryFileNameFunc =
         			(_getTemporaryFileName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getTemporaryFileName"), typeof(_getTemporaryFileName));
         	}
         
         	return  _getTemporaryFileNameFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getUserDataDirectory();
         private static _getUserDataDirectory _getUserDataDirectoryFunc;
         internal static IntPtr getUserDataDirectory()
         {
         	if (_getUserDataDirectoryFunc == null)
         	{
         		_getUserDataDirectoryFunc =
         			(_getUserDataDirectory)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getUserDataDirectory"), typeof(_getUserDataDirectory));
         	}
         
         	return  _getUserDataDirectoryFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getUserHomeDirectory();
         private static _getUserHomeDirectory _getUserHomeDirectoryFunc;
         internal static IntPtr getUserHomeDirectory()
         {
         	if (_getUserHomeDirectoryFunc == null)
         	{
         		_getUserHomeDirectoryFunc =
         			(_getUserHomeDirectory)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getUserHomeDirectory"), typeof(_getUserHomeDirectory));
         	}
         
         	return  _getUserHomeDirectoryFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setMainDotCsDir([MarshalAs(UnmanagedType.LPWStr)]string path);
         private static _setMainDotCsDir _setMainDotCsDirFunc;
         internal static void setMainDotCsDir([MarshalAs(UnmanagedType.LPWStr)]string path)
         {
         	if (_setMainDotCsDirFunc == null)
         	{
         		_setMainDotCsDirFunc =
         			(_setMainDotCsDir)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_setMainDotCsDir"), typeof(_setMainDotCsDir));
         	}
         
         	 _setMainDotCsDirFunc(path);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _validateMemory();
         private static _validateMemory _validateMemoryFunc;
         internal static void validateMemory()
         {
         	if (_validateMemoryFunc == null)
         	{
         		_validateMemoryFunc =
         			(_validateMemory)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_validateMemory"), typeof(_validateMemory));
         	}
         
         	 _validateMemoryFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _freeMemoryDump();
         private static _freeMemoryDump _freeMemoryDumpFunc;
         internal static void freeMemoryDump()
         {
         	if (_freeMemoryDumpFunc == null)
         	{
         		_freeMemoryDumpFunc =
         			(_freeMemoryDump)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_freeMemoryDump"), typeof(_freeMemoryDump));
         	}
         
         	 _freeMemoryDumpFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _flagCurrentAllocs();
         private static _flagCurrentAllocs _flagCurrentAllocsFunc;
         internal static void flagCurrentAllocs()
         {
         	if (_flagCurrentAllocsFunc == null)
         	{
         		_flagCurrentAllocsFunc =
         			(_flagCurrentAllocs)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_flagCurrentAllocs"), typeof(_flagCurrentAllocs));
         	}
         
         	 _flagCurrentAllocsFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _dumpUnflaggedAllocs([MarshalAs(UnmanagedType.LPWStr)]string fileName);
         private static _dumpUnflaggedAllocs _dumpUnflaggedAllocsFunc;
         internal static void dumpUnflaggedAllocs([MarshalAs(UnmanagedType.LPWStr)]string fileName)
         {
         	if (_dumpUnflaggedAllocsFunc == null)
         	{
         		_dumpUnflaggedAllocsFunc =
         			(_dumpUnflaggedAllocs)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_dumpUnflaggedAllocs"), typeof(_dumpUnflaggedAllocs));
         	}
         
         	 _dumpUnflaggedAllocsFunc(fileName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _dumpAlloc(int allocNum);
         private static _dumpAlloc _dumpAllocFunc;
         internal static void dumpAlloc(int allocNum)
         {
         	if (_dumpAllocFunc == null)
         	{
         		_dumpAllocFunc =
         			(_dumpAlloc)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_dumpAlloc"), typeof(_dumpAlloc));
         	}
         
         	 _dumpAllocFunc(allocNum);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _dumpMemSnapshot([MarshalAs(UnmanagedType.LPWStr)]string fileName);
         private static _dumpMemSnapshot _dumpMemSnapshotFunc;
         internal static void dumpMemSnapshot([MarshalAs(UnmanagedType.LPWStr)]string fileName)
         {
         	if (_dumpMemSnapshotFunc == null)
         	{
         		_dumpMemSnapshotFunc =
         			(_dumpMemSnapshot)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_dumpMemSnapshot"), typeof(_dumpMemSnapshot));
         	}
         
         	 _dumpMemSnapshotFunc(fileName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _redbookOpen([MarshalAs(UnmanagedType.LPWStr)]string device);
         private static _redbookOpen _redbookOpenFunc;
         internal static bool redbookOpen([MarshalAs(UnmanagedType.LPWStr)]string device)
         {
         	if (_redbookOpenFunc == null)
         	{
         		_redbookOpenFunc =
         			(_redbookOpen)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_redbookOpen"), typeof(_redbookOpen));
         	}
         
         	return  _redbookOpenFunc(device);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _redbookClose();
         private static _redbookClose _redbookCloseFunc;
         internal static bool redbookClose()
         {
         	if (_redbookCloseFunc == null)
         	{
         		_redbookCloseFunc =
         			(_redbookClose)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_redbookClose"), typeof(_redbookClose));
         	}
         
         	return  _redbookCloseFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _redbookPlay(int track);
         private static _redbookPlay _redbookPlayFunc;
         internal static bool redbookPlay(int track)
         {
         	if (_redbookPlayFunc == null)
         	{
         		_redbookPlayFunc =
         			(_redbookPlay)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_redbookPlay"), typeof(_redbookPlay));
         	}
         
         	return  _redbookPlayFunc(track);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _redbookStop();
         private static _redbookStop _redbookStopFunc;
         internal static bool redbookStop()
         {
         	if (_redbookStopFunc == null)
         	{
         		_redbookStopFunc =
         			(_redbookStop)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_redbookStop"), typeof(_redbookStop));
         	}
         
         	return  _redbookStopFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _redbookGetTrackCount();
         private static _redbookGetTrackCount _redbookGetTrackCountFunc;
         internal static int redbookGetTrackCount()
         {
         	if (_redbookGetTrackCountFunc == null)
         	{
         		_redbookGetTrackCountFunc =
         			(_redbookGetTrackCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_redbookGetTrackCount"), typeof(_redbookGetTrackCount));
         	}
         
         	return  _redbookGetTrackCountFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _redbookGetVolume();
         private static _redbookGetVolume _redbookGetVolumeFunc;
         internal static float redbookGetVolume()
         {
         	if (_redbookGetVolumeFunc == null)
         	{
         		_redbookGetVolumeFunc =
         			(_redbookGetVolume)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_redbookGetVolume"), typeof(_redbookGetVolume));
         	}
         
         	return  _redbookGetVolumeFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _redbookSetVolume(float volume);
         private static _redbookSetVolume _redbookSetVolumeFunc;
         internal static bool redbookSetVolume(float volume)
         {
         	if (_redbookSetVolumeFunc == null)
         	{
         		_redbookSetVolumeFunc =
         			(_redbookSetVolume)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_redbookSetVolume"), typeof(_redbookSetVolume));
         	}
         
         	return  _redbookSetVolumeFunc(volume);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _redbookGetDeviceCount();
         private static _redbookGetDeviceCount _redbookGetDeviceCountFunc;
         internal static int redbookGetDeviceCount()
         {
         	if (_redbookGetDeviceCountFunc == null)
         	{
         		_redbookGetDeviceCountFunc =
         			(_redbookGetDeviceCount)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_redbookGetDeviceCount"), typeof(_redbookGetDeviceCount));
         	}
         
         	return  _redbookGetDeviceCountFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _redbookGetDeviceName(int index);
         private static _redbookGetDeviceName _redbookGetDeviceNameFunc;
         internal static IntPtr redbookGetDeviceName(int index)
         {
         	if (_redbookGetDeviceNameFunc == null)
         	{
         		_redbookGetDeviceNameFunc =
         			(_redbookGetDeviceName)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_redbookGetDeviceName"), typeof(_redbookGetDeviceName));
         	}
         
         	return  _redbookGetDeviceNameFunc(index);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _redbookGetLastError();
         private static _redbookGetLastError _redbookGetLastErrorFunc;
         internal static IntPtr redbookGetLastError()
         {
         	if (_redbookGetLastErrorFunc == null)
         	{
         		_redbookGetLastErrorFunc =
         			(_redbookGetLastError)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_redbookGetLastError"), typeof(_redbookGetLastError));
         	}
         
         	return  _redbookGetLastErrorFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _startPrecisionTimer();
         private static _startPrecisionTimer _startPrecisionTimerFunc;
         internal static int startPrecisionTimer()
         {
         	if (_startPrecisionTimerFunc == null)
         	{
         		_startPrecisionTimerFunc =
         			(_startPrecisionTimer)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_startPrecisionTimer"), typeof(_startPrecisionTimer));
         	}
         
         	return  _startPrecisionTimerFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _stopPrecisionTimer(int id);
         private static _stopPrecisionTimer _stopPrecisionTimerFunc;
         internal static int stopPrecisionTimer(int id)
         {
         	if (_stopPrecisionTimerFunc == null)
         	{
         		_stopPrecisionTimerFunc =
         			(_stopPrecisionTimer)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_stopPrecisionTimer"), typeof(_stopPrecisionTimer));
         	}
         
         	return  _stopPrecisionTimerFunc(id);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _profilerMarkerEnable([MarshalAs(UnmanagedType.LPWStr)]string markerName, bool enable);
         private static _profilerMarkerEnable _profilerMarkerEnableFunc;
         internal static void profilerMarkerEnable([MarshalAs(UnmanagedType.LPWStr)]string markerName, bool enable)
         {
         	if (_profilerMarkerEnableFunc == null)
         	{
         		_profilerMarkerEnableFunc =
         			(_profilerMarkerEnable)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_profilerMarkerEnable"), typeof(_profilerMarkerEnable));
         	}
         
         	 _profilerMarkerEnableFunc(markerName, enable);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _profilerEnable(bool enable);
         private static _profilerEnable _profilerEnableFunc;
         internal static void profilerEnable(bool enable)
         {
         	if (_profilerEnableFunc == null)
         	{
         		_profilerEnableFunc =
         			(_profilerEnable)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_profilerEnable"), typeof(_profilerEnable));
         	}
         
         	 _profilerEnableFunc(enable);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _profilerDump();
         private static _profilerDump _profilerDumpFunc;
         internal static void profilerDump()
         {
         	if (_profilerDumpFunc == null)
         	{
         		_profilerDumpFunc =
         			(_profilerDump)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_profilerDump"), typeof(_profilerDump));
         	}
         
         	 _profilerDumpFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _profilerDumpToFile([MarshalAs(UnmanagedType.LPWStr)]string fileName);
         private static _profilerDumpToFile _profilerDumpToFileFunc;
         internal static void profilerDumpToFile([MarshalAs(UnmanagedType.LPWStr)]string fileName)
         {
         	if (_profilerDumpToFileFunc == null)
         	{
         		_profilerDumpToFileFunc =
         			(_profilerDumpToFile)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_profilerDumpToFile"), typeof(_profilerDumpToFile));
         	}
         
         	 _profilerDumpToFileFunc(fileName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _profilerReset();
         private static _profilerReset _profilerResetFunc;
         internal static void profilerReset()
         {
         	if (_profilerResetFunc == null)
         	{
         		_profilerResetFunc =
         			(_profilerReset)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_profilerReset"), typeof(_profilerReset));
         	}
         
         	 _profilerResetFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _messageBox([MarshalAs(UnmanagedType.LPWStr)]string title, [MarshalAs(UnmanagedType.LPWStr)]string message, MBButtons buttons, MBIcons icons);
         private static _messageBox _messageBoxFunc;
         internal static int messageBox([MarshalAs(UnmanagedType.LPWStr)]string title, [MarshalAs(UnmanagedType.LPWStr)]string message, MBButtons buttons, MBIcons icons)
         {
         	if (_messageBoxFunc == null)
         	{
         		_messageBoxFunc =
         			(_messageBox)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_messageBox"), typeof(_messageBox));
         	}
         
         	return  _messageBoxFunc(title, message, buttons, icons);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _TestFunction2Args(int argc, string[] argv);
         private static _TestFunction2Args _TestFunction2ArgsFunc;
         internal static IntPtr TestFunction2Args(int argc, string[] argv)
         {
         	if (_TestFunction2ArgsFunc == null)
         	{
         		_TestFunction2ArgsFunc =
         			(_TestFunction2Args)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_TestFunction2Args"), typeof(_TestFunction2Args));
         	}
         
         	return  _TestFunction2ArgsFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _testJavaScriptBridge([MarshalAs(UnmanagedType.LPWStr)]string arg1, [MarshalAs(UnmanagedType.LPWStr)]string arg2, [MarshalAs(UnmanagedType.LPWStr)]string arg3);
         private static _testJavaScriptBridge _testJavaScriptBridgeFunc;
         internal static IntPtr testJavaScriptBridge([MarshalAs(UnmanagedType.LPWStr)]string arg1, [MarshalAs(UnmanagedType.LPWStr)]string arg2, [MarshalAs(UnmanagedType.LPWStr)]string arg3)
         {
         	if (_testJavaScriptBridgeFunc == null)
         	{
         		_testJavaScriptBridgeFunc =
         			(_testJavaScriptBridge)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_testJavaScriptBridge"), typeof(_testJavaScriptBridge));
         	}
         
         	return  _testJavaScriptBridgeFunc(arg1, arg2, arg3);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isQueueRegistered([MarshalAs(UnmanagedType.LPWStr)]string queueName);
         private static _isQueueRegistered _isQueueRegisteredFunc;
         internal static bool isQueueRegistered([MarshalAs(UnmanagedType.LPWStr)]string queueName)
         {
         	if (_isQueueRegisteredFunc == null)
         	{
         		_isQueueRegisteredFunc =
         			(_isQueueRegistered)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_isQueueRegistered"), typeof(_isQueueRegistered));
         	}
         
         	return  _isQueueRegisteredFunc(queueName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _registerMessageQueue([MarshalAs(UnmanagedType.LPWStr)]string queueName);
         private static _registerMessageQueue _registerMessageQueueFunc;
         internal static void registerMessageQueue([MarshalAs(UnmanagedType.LPWStr)]string queueName)
         {
         	if (_registerMessageQueueFunc == null)
         	{
         		_registerMessageQueueFunc =
         			(_registerMessageQueue)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_registerMessageQueue"), typeof(_registerMessageQueue));
         	}
         
         	 _registerMessageQueueFunc(queueName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _unregisterMessageQueue([MarshalAs(UnmanagedType.LPWStr)]string queueName);
         private static _unregisterMessageQueue _unregisterMessageQueueFunc;
         internal static void unregisterMessageQueue([MarshalAs(UnmanagedType.LPWStr)]string queueName)
         {
         	if (_unregisterMessageQueueFunc == null)
         	{
         		_unregisterMessageQueueFunc =
         			(_unregisterMessageQueue)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_unregisterMessageQueue"), typeof(_unregisterMessageQueue));
         	}
         
         	 _unregisterMessageQueueFunc(queueName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _registerMessageListener([MarshalAs(UnmanagedType.LPWStr)]string queueName, [MarshalAs(UnmanagedType.LPWStr)]string listenerName);
         private static _registerMessageListener _registerMessageListenerFunc;
         internal static bool registerMessageListener([MarshalAs(UnmanagedType.LPWStr)]string queueName, [MarshalAs(UnmanagedType.LPWStr)]string listenerName)
         {
         	if (_registerMessageListenerFunc == null)
         	{
         		_registerMessageListenerFunc =
         			(_registerMessageListener)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_registerMessageListener"), typeof(_registerMessageListener));
         	}
         
         	return  _registerMessageListenerFunc(queueName, listenerName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _unregisterMessageListener([MarshalAs(UnmanagedType.LPWStr)]string queueName, [MarshalAs(UnmanagedType.LPWStr)]string listenerName);
         private static _unregisterMessageListener _unregisterMessageListenerFunc;
         internal static void unregisterMessageListener([MarshalAs(UnmanagedType.LPWStr)]string queueName, [MarshalAs(UnmanagedType.LPWStr)]string listenerName)
         {
         	if (_unregisterMessageListenerFunc == null)
         	{
         		_unregisterMessageListenerFunc =
         			(_unregisterMessageListener)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_unregisterMessageListener"), typeof(_unregisterMessageListener));
         	}
         
         	 _unregisterMessageListenerFunc(queueName, listenerName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _dispatchMessage([MarshalAs(UnmanagedType.LPWStr)]string queueName, [MarshalAs(UnmanagedType.LPWStr)]string message, [MarshalAs(UnmanagedType.LPWStr)]string data);
         private static _dispatchMessage _dispatchMessageFunc;
         internal static bool dispatchMessage([MarshalAs(UnmanagedType.LPWStr)]string queueName, [MarshalAs(UnmanagedType.LPWStr)]string message, [MarshalAs(UnmanagedType.LPWStr)]string data)
         {
         	if (_dispatchMessageFunc == null)
         	{
         		_dispatchMessageFunc =
         			(_dispatchMessage)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_dispatchMessage"), typeof(_dispatchMessage));
         	}
         
         	return  _dispatchMessageFunc(queueName, message, data);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _dispatchMessageObject([MarshalAs(UnmanagedType.LPWStr)]string queueName, [MarshalAs(UnmanagedType.LPWStr)]string message);
         private static _dispatchMessageObject _dispatchMessageObjectFunc;
         internal static bool dispatchMessageObject([MarshalAs(UnmanagedType.LPWStr)]string queueName, [MarshalAs(UnmanagedType.LPWStr)]string message)
         {
         	if (_dispatchMessageObjectFunc == null)
         	{
         		_dispatchMessageObjectFunc =
         			(_dispatchMessageObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_dispatchMessageObject"), typeof(_dispatchMessageObject));
         	}
         
         	return  _dispatchMessageObjectFunc(queueName, message);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getActiveDDSFiles();
         private static _getActiveDDSFiles _getActiveDDSFilesFunc;
         internal static int getActiveDDSFiles()
         {
         	if (_getActiveDDSFilesFunc == null)
         	{
         		_getActiveDDSFilesFunc =
         			(_getActiveDDSFiles)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getActiveDDSFiles"), typeof(_getActiveDDSFiles));
         	}
         
         	return  _getActiveDDSFilesFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getBitmapInfo([MarshalAs(UnmanagedType.LPWStr)]string filename);
         private static _getBitmapInfo _getBitmapInfoFunc;
         internal static IntPtr getBitmapInfo([MarshalAs(UnmanagedType.LPWStr)]string filename)
         {
         	if (_getBitmapInfoFunc == null)
         	{
         		_getBitmapInfoFunc =
         			(_getBitmapInfo)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getBitmapInfo"), typeof(_getBitmapInfo));
         	}
         
         	return  _getBitmapInfoFunc(filename);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _startVideoCapture(IntPtr canvas, [MarshalAs(UnmanagedType.LPWStr)]string filename, [MarshalAs(UnmanagedType.LPWStr)]string encoder, float framerate, int[] resolution);
         private static _startVideoCapture _startVideoCaptureFunc;
         internal static void startVideoCapture(IntPtr canvas, [MarshalAs(UnmanagedType.LPWStr)]string filename, [MarshalAs(UnmanagedType.LPWStr)]string encoder, float framerate, int[] resolution)
         {
         	if (_startVideoCaptureFunc == null)
         	{
         		_startVideoCaptureFunc =
         			(_startVideoCapture)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_startVideoCapture"), typeof(_startVideoCapture));
         	}
         
         	 _startVideoCaptureFunc(canvas, filename, encoder, framerate, resolution);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _stopVideoCapture();
         private static _stopVideoCapture _stopVideoCaptureFunc;
         internal static void stopVideoCapture()
         {
         	if (_stopVideoCaptureFunc == null)
         	{
         		_stopVideoCaptureFunc =
         			(_stopVideoCapture)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_stopVideoCapture"), typeof(_stopVideoCapture));
         	}
         
         	 _stopVideoCaptureFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _playJournalToVideo([MarshalAs(UnmanagedType.LPWStr)]string journalFile, [MarshalAs(UnmanagedType.LPWStr)]string videoFile, [MarshalAs(UnmanagedType.LPWStr)]string encoder, float framerate, int[] resolution);
         private static _playJournalToVideo _playJournalToVideoFunc;
         internal static void playJournalToVideo([MarshalAs(UnmanagedType.LPWStr)]string journalFile, [MarshalAs(UnmanagedType.LPWStr)]string videoFile, [MarshalAs(UnmanagedType.LPWStr)]string encoder, float framerate, int[] resolution)
         {
         	if (_playJournalToVideoFunc == null)
         	{
         		_playJournalToVideoFunc =
         			(_playJournalToVideo)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_playJournalToVideo"), typeof(_playJournalToVideo));
         	}
         
         	 _playJournalToVideoFunc(journalFile, videoFile, encoder, framerate, resolution);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _populateFontCacheString([MarshalAs(UnmanagedType.LPWStr)]string faceName, int fontSize, [MarshalAs(UnmanagedType.LPWStr)]string _string);
         private static _populateFontCacheString _populateFontCacheStringFunc;
         internal static void populateFontCacheString([MarshalAs(UnmanagedType.LPWStr)]string faceName, int fontSize, [MarshalAs(UnmanagedType.LPWStr)]string _string)
         {
         	if (_populateFontCacheStringFunc == null)
         	{
         		_populateFontCacheStringFunc =
         			(_populateFontCacheString)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_populateFontCacheString"), typeof(_populateFontCacheString));
         	}
         
         	 _populateFontCacheStringFunc(faceName, fontSize, _string);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _populateFontCacheRange([MarshalAs(UnmanagedType.LPWStr)]string faceName, int fontSize, uint rangeStart, uint rangeEnd);
         private static _populateFontCacheRange _populateFontCacheRangeFunc;
         internal static void populateFontCacheRange([MarshalAs(UnmanagedType.LPWStr)]string faceName, int fontSize, uint rangeStart, uint rangeEnd)
         {
         	if (_populateFontCacheRangeFunc == null)
         	{
         		_populateFontCacheRangeFunc =
         			(_populateFontCacheRange)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_populateFontCacheRange"), typeof(_populateFontCacheRange));
         	}
         
         	 _populateFontCacheRangeFunc(faceName, fontSize, rangeStart, rangeEnd);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _dumpFontCacheStatus();
         private static _dumpFontCacheStatus _dumpFontCacheStatusFunc;
         internal static void dumpFontCacheStatus()
         {
         	if (_dumpFontCacheStatusFunc == null)
         	{
         		_dumpFontCacheStatusFunc =
         			(_dumpFontCacheStatus)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_dumpFontCacheStatus"), typeof(_dumpFontCacheStatus));
         	}
         
         	 _dumpFontCacheStatusFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _writeFontCache();
         private static _writeFontCache _writeFontCacheFunc;
         internal static void writeFontCache()
         {
         	if (_writeFontCacheFunc == null)
         	{
         		_writeFontCacheFunc =
         			(_writeFontCache)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_writeFontCache"), typeof(_writeFontCache));
         	}
         
         	 _writeFontCacheFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _populateAllFontCacheString([MarshalAs(UnmanagedType.LPWStr)]string _string);
         private static _populateAllFontCacheString _populateAllFontCacheStringFunc;
         internal static void populateAllFontCacheString([MarshalAs(UnmanagedType.LPWStr)]string _string)
         {
         	if (_populateAllFontCacheStringFunc == null)
         	{
         		_populateAllFontCacheStringFunc =
         			(_populateAllFontCacheString)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_populateAllFontCacheString"), typeof(_populateAllFontCacheString));
         	}
         
         	 _populateAllFontCacheStringFunc(_string);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _populateAllFontCacheRange(uint rangeStart, uint rangeEnd);
         private static _populateAllFontCacheRange _populateAllFontCacheRangeFunc;
         internal static void populateAllFontCacheRange(uint rangeStart, uint rangeEnd)
         {
         	if (_populateAllFontCacheRangeFunc == null)
         	{
         		_populateAllFontCacheRangeFunc =
         			(_populateAllFontCacheRange)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_populateAllFontCacheRange"), typeof(_populateAllFontCacheRange));
         	}
         
         	 _populateAllFontCacheRangeFunc(rangeStart, rangeEnd);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _exportCachedFont([MarshalAs(UnmanagedType.LPWStr)]string faceName, int fontSize, [MarshalAs(UnmanagedType.LPWStr)]string fileName, int padding, int kerning);
         private static _exportCachedFont _exportCachedFontFunc;
         internal static void exportCachedFont([MarshalAs(UnmanagedType.LPWStr)]string faceName, int fontSize, [MarshalAs(UnmanagedType.LPWStr)]string fileName, int padding, int kerning)
         {
         	if (_exportCachedFontFunc == null)
         	{
         		_exportCachedFontFunc =
         			(_exportCachedFont)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_exportCachedFont"), typeof(_exportCachedFont));
         	}
         
         	 _exportCachedFontFunc(faceName, fontSize, fileName, padding, kerning);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _importCachedFont([MarshalAs(UnmanagedType.LPWStr)]string faceName, int fontSize, [MarshalAs(UnmanagedType.LPWStr)]string fileName, int padding, int kerning);
         private static _importCachedFont _importCachedFontFunc;
         internal static void importCachedFont([MarshalAs(UnmanagedType.LPWStr)]string faceName, int fontSize, [MarshalAs(UnmanagedType.LPWStr)]string fileName, int padding, int kerning)
         {
         	if (_importCachedFontFunc == null)
         	{
         		_importCachedFontFunc =
         			(_importCachedFont)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_importCachedFont"), typeof(_importCachedFont));
         	}
         
         	 _importCachedFontFunc(faceName, fontSize, fileName, padding, kerning);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _duplicateCachedFont([MarshalAs(UnmanagedType.LPWStr)]string oldFontName, int oldFontSize, [MarshalAs(UnmanagedType.LPWStr)]string newFontName);
         private static _duplicateCachedFont _duplicateCachedFontFunc;
         internal static void duplicateCachedFont([MarshalAs(UnmanagedType.LPWStr)]string oldFontName, int oldFontSize, [MarshalAs(UnmanagedType.LPWStr)]string newFontName)
         {
         	if (_duplicateCachedFontFunc == null)
         	{
         		_duplicateCachedFontFunc =
         			(_duplicateCachedFont)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_duplicateCachedFont"), typeof(_duplicateCachedFont));
         	}
         
         	 _duplicateCachedFontFunc(oldFontName, oldFontSize, newFontName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getDisplayDeviceList();
         private static _getDisplayDeviceList _getDisplayDeviceListFunc;
         internal static IntPtr getDisplayDeviceList()
         {
         	if (_getDisplayDeviceListFunc == null)
         	{
         		_getDisplayDeviceListFunc =
         			(_getDisplayDeviceList)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getDisplayDeviceList"), typeof(_getDisplayDeviceList));
         	}
         
         	return  _getDisplayDeviceListFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _listGFXResources(bool unflaggedOnly);
         private static _listGFXResources _listGFXResourcesFunc;
         internal static void listGFXResources(bool unflaggedOnly)
         {
         	if (_listGFXResourcesFunc == null)
         	{
         		_listGFXResourcesFunc =
         			(_listGFXResources)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_listGFXResources"), typeof(_listGFXResources));
         	}
         
         	 _listGFXResourcesFunc(unflaggedOnly);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _flagCurrentGFXResources();
         private static _flagCurrentGFXResources _flagCurrentGFXResourcesFunc;
         internal static void flagCurrentGFXResources()
         {
         	if (_flagCurrentGFXResourcesFunc == null)
         	{
         		_flagCurrentGFXResourcesFunc =
         			(_flagCurrentGFXResources)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_flagCurrentGFXResources"), typeof(_flagCurrentGFXResources));
         	}
         
         	 _flagCurrentGFXResourcesFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearGFXResourceFlags();
         private static _clearGFXResourceFlags _clearGFXResourceFlagsFunc;
         internal static void clearGFXResourceFlags()
         {
         	if (_clearGFXResourceFlagsFunc == null)
         	{
         		_clearGFXResourceFlagsFunc =
         			(_clearGFXResourceFlags)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_clearGFXResourceFlags"), typeof(_clearGFXResourceFlags));
         	}
         
         	 _clearGFXResourceFlagsFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _describeGFXResources([MarshalAs(UnmanagedType.LPWStr)]string resourceTypes, [MarshalAs(UnmanagedType.LPWStr)]string filePath, bool unflaggedOnly);
         private static _describeGFXResources _describeGFXResourcesFunc;
         internal static void describeGFXResources([MarshalAs(UnmanagedType.LPWStr)]string resourceTypes, [MarshalAs(UnmanagedType.LPWStr)]string filePath, bool unflaggedOnly)
         {
         	if (_describeGFXResourcesFunc == null)
         	{
         		_describeGFXResourcesFunc =
         			(_describeGFXResources)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_describeGFXResources"), typeof(_describeGFXResources));
         	}
         
         	 _describeGFXResourcesFunc(resourceTypes, filePath, unflaggedOnly);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _describeGFXStateBlocks([MarshalAs(UnmanagedType.LPWStr)]string filePath);
         private static _describeGFXStateBlocks _describeGFXStateBlocksFunc;
         internal static void describeGFXStateBlocks([MarshalAs(UnmanagedType.LPWStr)]string filePath)
         {
         	if (_describeGFXStateBlocksFunc == null)
         	{
         		_describeGFXStateBlocksFunc =
         			(_describeGFXStateBlocks)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_describeGFXStateBlocks"), typeof(_describeGFXStateBlocks));
         	}
         
         	 _describeGFXStateBlocksFunc(filePath);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getPixelShaderVersion();
         private static _getPixelShaderVersion _getPixelShaderVersionFunc;
         internal static float getPixelShaderVersion()
         {
         	if (_getPixelShaderVersionFunc == null)
         	{
         		_getPixelShaderVersionFunc =
         			(_getPixelShaderVersion)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getPixelShaderVersion"), typeof(_getPixelShaderVersion));
         	}
         
         	return  _getPixelShaderVersionFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setPixelShaderVersion(float version);
         private static _setPixelShaderVersion _setPixelShaderVersionFunc;
         internal static void setPixelShaderVersion(float version)
         {
         	if (_setPixelShaderVersionFunc == null)
         	{
         		_setPixelShaderVersionFunc =
         			(_setPixelShaderVersion)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_setPixelShaderVersion"), typeof(_setPixelShaderVersion));
         	}
         
         	 _setPixelShaderVersionFunc(version);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getDisplayDeviceInformation();
         private static _getDisplayDeviceInformation _getDisplayDeviceInformationFunc;
         internal static IntPtr getDisplayDeviceInformation()
         {
         	if (_getDisplayDeviceInformationFunc == null)
         	{
         		_getDisplayDeviceInformationFunc =
         			(_getDisplayDeviceInformation)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getDisplayDeviceInformation"), typeof(_getDisplayDeviceInformation));
         	}
         
         	return  _getDisplayDeviceInformationFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate GFXFormat _getBestHDRFormat();
         private static _getBestHDRFormat _getBestHDRFormatFunc;
         internal static GFXFormat getBestHDRFormat()
         {
         	if (_getBestHDRFormatFunc == null)
         	{
         		_getBestHDRFormatFunc =
         			(_getBestHDRFormat)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getBestHDRFormat"), typeof(_getBestHDRFormat));
         	}
         
         	return  _getBestHDRFormatFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _ResetGFX();
         private static _ResetGFX _ResetGFXFunc;
         internal static void ResetGFX()
         {
         	if (_ResetGFXFunc == null)
         	{
         		_ResetGFXFunc =
         			(_ResetGFX)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_ResetGFX"), typeof(_ResetGFX));
         	}
         
         	 _ResetGFXFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate InternalPoint3FStruct _getDesktopResolution();
         private static _getDesktopResolution _getDesktopResolutionFunc;
         internal static InternalPoint3FStruct getDesktopResolution()
         {
         	if (_getDesktopResolutionFunc == null)
         	{
         		_getDesktopResolutionFunc =
         			(_getDesktopResolution)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getDesktopResolution"), typeof(_getDesktopResolution));
         	}
         
         	return  _getDesktopResolutionFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addGlobalShaderMacro([MarshalAs(UnmanagedType.LPWStr)]string name, [MarshalAs(UnmanagedType.LPWStr)]string value);
         private static _addGlobalShaderMacro _addGlobalShaderMacroFunc;
         internal static void addGlobalShaderMacro([MarshalAs(UnmanagedType.LPWStr)]string name, [MarshalAs(UnmanagedType.LPWStr)]string value)
         {
         	if (_addGlobalShaderMacroFunc == null)
         	{
         		_addGlobalShaderMacroFunc =
         			(_addGlobalShaderMacro)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_addGlobalShaderMacro"), typeof(_addGlobalShaderMacro));
         	}
         
         	 _addGlobalShaderMacroFunc(name, value);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _removeGlobalShaderMacro([MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _removeGlobalShaderMacro _removeGlobalShaderMacroFunc;
         internal static void removeGlobalShaderMacro([MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_removeGlobalShaderMacroFunc == null)
         	{
         		_removeGlobalShaderMacroFunc =
         			(_removeGlobalShaderMacro)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_removeGlobalShaderMacro"), typeof(_removeGlobalShaderMacro));
         	}
         
         	 _removeGlobalShaderMacroFunc(name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _flushTextureCache();
         private static _flushTextureCache _flushTextureCacheFunc;
         internal static void flushTextureCache()
         {
         	if (_flushTextureCacheFunc == null)
         	{
         		_flushTextureCacheFunc =
         			(_flushTextureCache)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_flushTextureCache"), typeof(_flushTextureCache));
         	}
         
         	 _flushTextureCacheFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _cleanupTexturePool();
         private static _cleanupTexturePool _cleanupTexturePoolFunc;
         internal static void cleanupTexturePool()
         {
         	if (_cleanupTexturePoolFunc == null)
         	{
         		_cleanupTexturePoolFunc =
         			(_cleanupTexturePool)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_cleanupTexturePool"), typeof(_cleanupTexturePool));
         	}
         
         	 _cleanupTexturePoolFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _reloadTextures();
         private static _reloadTextures _reloadTexturesFunc;
         internal static void reloadTextures()
         {
         	if (_reloadTexturesFunc == null)
         	{
         		_reloadTexturesFunc =
         			(_reloadTextures)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_reloadTextures"), typeof(_reloadTextures));
         	}
         
         	 _reloadTexturesFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _dumpTextureObjects();
         private static _dumpTextureObjects _dumpTextureObjectsFunc;
         internal static void dumpTextureObjects()
         {
         	if (_dumpTextureObjectsFunc == null)
         	{
         		_dumpTextureObjectsFunc =
         			(_dumpTextureObjects)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_dumpTextureObjects"), typeof(_dumpTextureObjects));
         	}
         
         	 _dumpTextureObjectsFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getTextureProfileStats();
         private static _getTextureProfileStats _getTextureProfileStatsFunc;
         internal static IntPtr getTextureProfileStats()
         {
         	if (_getTextureProfileStatsFunc == null)
         	{
         		_getTextureProfileStatsFunc =
         			(_getTextureProfileStats)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getTextureProfileStats"), typeof(_getTextureProfileStats));
         	}
         
         	return  _getTextureProfileStatsFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _screenShot([MarshalAs(UnmanagedType.LPWStr)]string file, [MarshalAs(UnmanagedType.LPWStr)]string format, uint tileCount, float tileOverlap);
         private static _screenShot _screenShotFunc;
         internal static void screenShot([MarshalAs(UnmanagedType.LPWStr)]string file, [MarshalAs(UnmanagedType.LPWStr)]string format, uint tileCount, float tileOverlap)
         {
         	if (_screenShotFunc == null)
         	{
         		_screenShotFunc =
         			(_screenShot)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_screenShot"), typeof(_screenShot));
         	}
         
         	 _screenShotFunc(file, format, tileCount, tileOverlap);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _StripMLControlChars([MarshalAs(UnmanagedType.LPWStr)]string inString);
         private static _StripMLControlChars _StripMLControlCharsFunc;
         internal static IntPtr StripMLControlChars([MarshalAs(UnmanagedType.LPWStr)]string inString)
         {
         	if (_StripMLControlCharsFunc == null)
         	{
         		_StripMLControlCharsFunc =
         			(_StripMLControlChars)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_StripMLControlChars"), typeof(_StripMLControlChars));
         	}
         
         	return  _StripMLControlCharsFunc(inString);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _excludeOtherInstance([MarshalAs(UnmanagedType.LPWStr)]string appIdentifer);
         private static _excludeOtherInstance _excludeOtherInstanceFunc;
         internal static bool excludeOtherInstance([MarshalAs(UnmanagedType.LPWStr)]string appIdentifer)
         {
         	if (_excludeOtherInstanceFunc == null)
         	{
         		_excludeOtherInstanceFunc =
         			(_excludeOtherInstance)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_excludeOtherInstance"), typeof(_excludeOtherInstance));
         	}
         
         	return  _excludeOtherInstanceFunc(appIdentifer);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _reInitMaterials();
         private static _reInitMaterials _reInitMaterialsFunc;
         internal static void reInitMaterials()
         {
         	if (_reInitMaterialsFunc == null)
         	{
         		_reInitMaterialsFunc =
         			(_reInitMaterials)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_reInitMaterials"), typeof(_reInitMaterials));
         	}
         
         	 _reInitMaterialsFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _addMaterialMapping([MarshalAs(UnmanagedType.LPWStr)]string texName, [MarshalAs(UnmanagedType.LPWStr)]string matName);
         private static _addMaterialMapping _addMaterialMappingFunc;
         internal static void addMaterialMapping([MarshalAs(UnmanagedType.LPWStr)]string texName, [MarshalAs(UnmanagedType.LPWStr)]string matName)
         {
         	if (_addMaterialMappingFunc == null)
         	{
         		_addMaterialMappingFunc =
         			(_addMaterialMapping)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_addMaterialMapping"), typeof(_addMaterialMapping));
         	}
         
         	 _addMaterialMappingFunc(texName, matName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getMaterialMapping([MarshalAs(UnmanagedType.LPWStr)]string texName);
         private static _getMaterialMapping _getMaterialMappingFunc;
         internal static IntPtr getMaterialMapping([MarshalAs(UnmanagedType.LPWStr)]string texName)
         {
         	if (_getMaterialMappingFunc == null)
         	{
         		_getMaterialMappingFunc =
         			(_getMaterialMapping)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getMaterialMapping"), typeof(_getMaterialMapping));
         	}
         
         	return  _getMaterialMappingFunc(texName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _dumpMaterialInstances();
         private static _dumpMaterialInstances _dumpMaterialInstancesFunc;
         internal static void dumpMaterialInstances()
         {
         	if (_dumpMaterialInstancesFunc == null)
         	{
         		_dumpMaterialInstancesFunc =
         			(_dumpMaterialInstances)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_dumpMaterialInstances"), typeof(_dumpMaterialInstances));
         	}
         
         	 _dumpMaterialInstancesFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getMapEntry([MarshalAs(UnmanagedType.LPWStr)]string texName);
         private static _getMapEntry _getMapEntryFunc;
         internal static IntPtr getMapEntry([MarshalAs(UnmanagedType.LPWStr)]string texName)
         {
         	if (_getMapEntryFunc == null)
         	{
         		_getMapEntryFunc =
         			(_getMapEntry)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getMapEntry"), typeof(_getMapEntry));
         	}
         
         	return  _getMapEntryFunc(texName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setLightManager([MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _setLightManager _setLightManagerFunc;
         internal static bool setLightManager([MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_setLightManagerFunc == null)
         	{
         		_setLightManagerFunc =
         			(_setLightManager)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_setLightManager"), typeof(_setLightManager));
         	}
         
         	return  _setLightManagerFunc(name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _lightScene([MarshalAs(UnmanagedType.LPWStr)]string completeCallbackFn, [MarshalAs(UnmanagedType.LPWStr)]string mode);
         private static _lightScene _lightSceneFunc;
         internal static bool lightScene([MarshalAs(UnmanagedType.LPWStr)]string completeCallbackFn, [MarshalAs(UnmanagedType.LPWStr)]string mode)
         {
         	if (_lightSceneFunc == null)
         	{
         		_lightSceneFunc =
         			(_lightScene)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_lightScene"), typeof(_lightScene));
         	}
         
         	return  _lightSceneFunc(completeCallbackFn, mode);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getLightManagerNames();
         private static _getLightManagerNames _getLightManagerNamesFunc;
         internal static IntPtr getLightManagerNames()
         {
         	if (_getLightManagerNamesFunc == null)
         	{
         		_getLightManagerNamesFunc =
         			(_getLightManagerNames)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getLightManagerNames"), typeof(_getLightManagerNames));
         	}
         
         	return  _getLightManagerNamesFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getActiveLightManager();
         private static _getActiveLightManager _getActiveLightManagerFunc;
         internal static IntPtr getActiveLightManager()
         {
         	if (_getActiveLightManagerFunc == null)
         	{
         		_getActiveLightManagerFunc =
         			(_getActiveLightManager)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getActiveLightManager"), typeof(_getActiveLightManager));
         	}
         
         	return  _getActiveLightManagerFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _resetLightManager();
         private static _resetLightManager _resetLightManagerFunc;
         internal static void resetLightManager()
         {
         	if (_resetLightManagerFunc == null)
         	{
         		_resetLightManagerFunc =
         			(_resetLightManager)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_resetLightManager"), typeof(_resetLightManager));
         	}
         
         	 _resetLightManagerFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _setShadowManager([MarshalAs(UnmanagedType.LPWStr)]string sShadowSystemName);
         private static _setShadowManager _setShadowManagerFunc;
         internal static bool setShadowManager([MarshalAs(UnmanagedType.LPWStr)]string sShadowSystemName)
         {
         	if (_setShadowManagerFunc == null)
         	{
         		_setShadowManagerFunc =
         			(_setShadowManager)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_setShadowManager"), typeof(_setShadowManager));
         	}
         
         	return  _setShadowManagerFunc(sShadowSystemName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearServerPaths();
         private static _clearServerPaths _clearServerPathsFunc;
         internal static void clearServerPaths()
         {
         	if (_clearServerPathsFunc == null)
         	{
         		_clearServerPathsFunc =
         			(_clearServerPaths)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_clearServerPaths"), typeof(_clearServerPaths));
         	}
         
         	 _clearServerPathsFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _clearClientPaths();
         private static _clearClientPaths _clearClientPathsFunc;
         internal static void clearClientPaths()
         {
         	if (_clearClientPathsFunc == null)
         	{
         		_clearClientPathsFunc =
         			(_clearClientPaths)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_clearClientPaths"), typeof(_clearClientPaths));
         	}
         
         	 _clearClientPathsFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setReflectFormat(GFXFormat format);
         private static _setReflectFormat _setReflectFormatFunc;
         internal static void setReflectFormat(GFXFormat format)
         {
         	if (_setReflectFormatFunc == null)
         	{
         		_setReflectFormatFunc =
         			(_setReflectFormat)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_setReflectFormat"), typeof(_setReflectFormat));
         	}
         
         	 _setReflectFormatFunc(format);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _containerBoxEmpty(uint mask, InternalPoint3FStruct center, float xRadius, float yRadius, float zRadius, bool useClientContainer);
         private static _containerBoxEmpty _containerBoxEmptyFunc;
         internal static bool containerBoxEmpty(uint mask, InternalPoint3FStruct center, float xRadius, float yRadius, float zRadius, bool useClientContainer)
         {
         	if (_containerBoxEmptyFunc == null)
         	{
         		_containerBoxEmptyFunc =
         			(_containerBoxEmpty)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_containerBoxEmpty"), typeof(_containerBoxEmpty));
         	}
         
         	return  _containerBoxEmptyFunc(mask, center, xRadius, yRadius, zRadius, useClientContainer);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _initContainerRadiusSearch(InternalPoint3FStruct pos, float radius, uint mask, bool useClientContainer);
         private static _initContainerRadiusSearch _initContainerRadiusSearchFunc;
         internal static void initContainerRadiusSearch(InternalPoint3FStruct pos, float radius, uint mask, bool useClientContainer)
         {
         	if (_initContainerRadiusSearchFunc == null)
         	{
         		_initContainerRadiusSearchFunc =
         			(_initContainerRadiusSearch)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_initContainerRadiusSearch"), typeof(_initContainerRadiusSearch));
         	}
         
         	 _initContainerRadiusSearchFunc(pos, radius, mask, useClientContainer);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _initContainerTypeSearch(uint mask, bool useClientContainer);
         private static _initContainerTypeSearch _initContainerTypeSearchFunc;
         internal static void initContainerTypeSearch(uint mask, bool useClientContainer)
         {
         	if (_initContainerTypeSearchFunc == null)
         	{
         		_initContainerTypeSearchFunc =
         			(_initContainerTypeSearch)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_initContainerTypeSearch"), typeof(_initContainerTypeSearch));
         	}
         
         	 _initContainerTypeSearchFunc(mask, useClientContainer);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _containerSearchNext(bool useClientContainer);
         private static _containerSearchNext _containerSearchNextFunc;
         internal static IntPtr containerSearchNext(bool useClientContainer)
         {
         	if (_containerSearchNextFunc == null)
         	{
         		_containerSearchNextFunc =
         			(_containerSearchNext)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_containerSearchNext"), typeof(_containerSearchNext));
         	}
         
         	return  _containerSearchNextFunc(useClientContainer);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _containerSearchCurrDist(bool useClientContainer);
         private static _containerSearchCurrDist _containerSearchCurrDistFunc;
         internal static float containerSearchCurrDist(bool useClientContainer)
         {
         	if (_containerSearchCurrDistFunc == null)
         	{
         		_containerSearchCurrDistFunc =
         			(_containerSearchCurrDist)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_containerSearchCurrDist"), typeof(_containerSearchCurrDist));
         	}
         
         	return  _containerSearchCurrDistFunc(useClientContainer);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _containerSearchCurrRadiusDist(bool useClientContainer);
         private static _containerSearchCurrRadiusDist _containerSearchCurrRadiusDistFunc;
         internal static float containerSearchCurrRadiusDist(bool useClientContainer)
         {
         	if (_containerSearchCurrRadiusDistFunc == null)
         	{
         		_containerSearchCurrRadiusDistFunc =
         			(_containerSearchCurrRadiusDist)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_containerSearchCurrRadiusDist"), typeof(_containerSearchCurrRadiusDist));
         	}
         
         	return  _containerSearchCurrRadiusDistFunc(useClientContainer);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _containerRayCast(InternalPoint3FStruct start, InternalPoint3FStruct end, uint mask, IntPtr pExempt, bool useClientContainer);
         private static _containerRayCast _containerRayCastFunc;
         internal static IntPtr containerRayCast(InternalPoint3FStruct start, InternalPoint3FStruct end, uint mask, IntPtr pExempt, bool useClientContainer)
         {
         	if (_containerRayCastFunc == null)
         	{
         		_containerRayCastFunc =
         			(_containerRayCast)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_containerRayCast"), typeof(_containerRayCast));
         	}
         
         	return  _containerRayCastFunc(start, end, mask, pExempt, useClientContainer);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _sceneDumpZoneStates(bool updateFirst);
         private static _sceneDumpZoneStates _sceneDumpZoneStatesFunc;
         internal static void sceneDumpZoneStates(bool updateFirst)
         {
         	if (_sceneDumpZoneStatesFunc == null)
         	{
         		_sceneDumpZoneStatesFunc =
         			(_sceneDumpZoneStates)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_sceneDumpZoneStates"), typeof(_sceneDumpZoneStates));
         	}
         
         	 _sceneDumpZoneStatesFunc(updateFirst);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _sceneGetZoneOwner(uint zoneId);
         private static _sceneGetZoneOwner _sceneGetZoneOwnerFunc;
         internal static IntPtr sceneGetZoneOwner(uint zoneId)
         {
         	if (_sceneGetZoneOwnerFunc == null)
         	{
         		_sceneGetZoneOwnerFunc =
         			(_sceneGetZoneOwner)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_sceneGetZoneOwner"), typeof(_sceneGetZoneOwner));
         	}
         
         	return  _sceneGetZoneOwnerFunc(zoneId);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _pathOnMissionLoadDone();
         private static _pathOnMissionLoadDone _pathOnMissionLoadDoneFunc;
         internal static void pathOnMissionLoadDone()
         {
         	if (_pathOnMissionLoadDoneFunc == null)
         	{
         		_pathOnMissionLoadDoneFunc =
         			(_pathOnMissionLoadDone)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_pathOnMissionLoadDone"), typeof(_pathOnMissionLoadDone));
         	}
         
         	 _pathOnMissionLoadDoneFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getTerrainUnderWorldPoint([MarshalAs(UnmanagedType.LPWStr)]string ptOrX, [MarshalAs(UnmanagedType.LPWStr)]string y, [MarshalAs(UnmanagedType.LPWStr)]string z);
         private static _getTerrainUnderWorldPoint _getTerrainUnderWorldPointFunc;
         internal static int getTerrainUnderWorldPoint([MarshalAs(UnmanagedType.LPWStr)]string ptOrX, [MarshalAs(UnmanagedType.LPWStr)]string y, [MarshalAs(UnmanagedType.LPWStr)]string z)
         {
         	if (_getTerrainUnderWorldPointFunc == null)
         	{
         		_getTerrainUnderWorldPointFunc =
         			(_getTerrainUnderWorldPoint)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getTerrainUnderWorldPoint"), typeof(_getTerrainUnderWorldPoint));
         	}
         
         	return  _getTerrainUnderWorldPointFunc(ptOrX, y, z);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getTerrainHeight([MarshalAs(UnmanagedType.LPWStr)]string ptOrX, [MarshalAs(UnmanagedType.LPWStr)]string y);
         private static _getTerrainHeight _getTerrainHeightFunc;
         internal static float getTerrainHeight([MarshalAs(UnmanagedType.LPWStr)]string ptOrX, [MarshalAs(UnmanagedType.LPWStr)]string y)
         {
         	if (_getTerrainHeightFunc == null)
         	{
         		_getTerrainHeightFunc =
         			(_getTerrainHeight)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getTerrainHeight"), typeof(_getTerrainHeight));
         	}
         
         	return  _getTerrainHeightFunc(ptOrX, y);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _getTerrainHeightBelowPosition([MarshalAs(UnmanagedType.LPWStr)]string ptOrX, [MarshalAs(UnmanagedType.LPWStr)]string y, [MarshalAs(UnmanagedType.LPWStr)]string z);
         private static _getTerrainHeightBelowPosition _getTerrainHeightBelowPositionFunc;
         internal static float getTerrainHeightBelowPosition([MarshalAs(UnmanagedType.LPWStr)]string ptOrX, [MarshalAs(UnmanagedType.LPWStr)]string y, [MarshalAs(UnmanagedType.LPWStr)]string z)
         {
         	if (_getTerrainHeightBelowPositionFunc == null)
         	{
         		_getTerrainHeightBelowPositionFunc =
         			(_getTerrainHeightBelowPosition)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getTerrainHeightBelowPosition"), typeof(_getTerrainHeightBelowPosition));
         	}
         
         	return  _getTerrainHeightBelowPositionFunc(ptOrX, y, z);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _SetFogVolumeQuality(uint new_quality);
         private static _SetFogVolumeQuality _SetFogVolumeQualityFunc;
         internal static int SetFogVolumeQuality(uint new_quality)
         {
         	if (_SetFogVolumeQualityFunc == null)
         	{
         		_SetFogVolumeQualityFunc =
         			(_SetFogVolumeQuality)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_SetFogVolumeQuality"), typeof(_SetFogVolumeQuality));
         	}
         
         	return  _SetFogVolumeQualityFunc(new_quality);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _tsUpdateImposterImages(bool forceUpdate);
         private static _tsUpdateImposterImages _tsUpdateImposterImagesFunc;
         internal static void tsUpdateImposterImages(bool forceUpdate)
         {
         	if (_tsUpdateImposterImagesFunc == null)
         	{
         		_tsUpdateImposterImagesFunc =
         			(_tsUpdateImposterImages)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_tsUpdateImposterImages"), typeof(_tsUpdateImposterImages));
         	}
         
         	 _tsUpdateImposterImagesFunc(forceUpdate);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _dumpRandomNormalMap();
         private static _dumpRandomNormalMap _dumpRandomNormalMapFunc;
         internal static void dumpRandomNormalMap()
         {
         	if (_dumpRandomNormalMapFunc == null)
         	{
         		_dumpRandomNormalMapFunc =
         			(_dumpRandomNormalMap)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_dumpRandomNormalMap"), typeof(_dumpRandomNormalMap));
         	}
         
         	 _dumpRandomNormalMapFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _aiAddPlayer([MarshalAs(UnmanagedType.LPWStr)]string name, [MarshalAs(UnmanagedType.LPWStr)]string ns);
         private static _aiAddPlayer _aiAddPlayerFunc;
         internal static int aiAddPlayer([MarshalAs(UnmanagedType.LPWStr)]string name, [MarshalAs(UnmanagedType.LPWStr)]string ns)
         {
         	if (_aiAddPlayerFunc == null)
         	{
         		_aiAddPlayerFunc =
         			(_aiAddPlayer)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_aiAddPlayer"), typeof(_aiAddPlayer));
         	}
         
         	return  _aiAddPlayerFunc(name, ns);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _aiConnect(int argc, string[] argv);
         private static _aiConnect _aiConnectFunc;
         internal static int aiConnect(int argc, string[] argv)
         {
         	if (_aiConnectFunc == null)
         	{
         		_aiConnectFunc =
         			(_aiConnect)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_aiConnect"), typeof(_aiConnect));
         	}
         
         	return  _aiConnectFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _containerFindFirst(uint typeMask, InternalPoint3FStruct origin, InternalPoint3FStruct size);
         private static _containerFindFirst _containerFindFirstFunc;
         internal static IntPtr containerFindFirst(uint typeMask, InternalPoint3FStruct origin, InternalPoint3FStruct size)
         {
         	if (_containerFindFirstFunc == null)
         	{
         		_containerFindFirstFunc =
         			(_containerFindFirst)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_containerFindFirst"), typeof(_containerFindFirst));
         	}
         
         	return  _containerFindFirstFunc(typeMask, origin, size);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _containerFindNext();
         private static _containerFindNext _containerFindNextFunc;
         internal static IntPtr containerFindNext()
         {
         	if (_containerFindNextFunc == null)
         	{
         		_containerFindNextFunc =
         			(_containerFindNext)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_containerFindNext"), typeof(_containerFindNext));
         	}
         
         	return  _containerFindNextFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setDefaultFov(float defaultFOV);
         private static _setDefaultFov _setDefaultFovFunc;
         internal static void setDefaultFov(float defaultFOV)
         {
         	if (_setDefaultFovFunc == null)
         	{
         		_setDefaultFovFunc =
         			(_setDefaultFov)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_setDefaultFov"), typeof(_setDefaultFov));
         	}
         
         	 _setDefaultFovFunc(defaultFOV);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setZoomSpeed(int speed);
         private static _setZoomSpeed _setZoomSpeedFunc;
         internal static void setZoomSpeed(int speed)
         {
         	if (_setZoomSpeedFunc == null)
         	{
         		_setZoomSpeedFunc =
         			(_setZoomSpeed)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_setZoomSpeed"), typeof(_setZoomSpeed));
         	}
         
         	 _setZoomSpeedFunc(speed);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _setFov(float FOV);
         private static _setFov _setFovFunc;
         internal static void setFov(float FOV)
         {
         	if (_setFovFunc == null)
         	{
         		_setFovFunc =
         			(_setFov)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_setFov"), typeof(_setFov));
         	}
         
         	 _setFovFunc(FOV);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _snapToggle();
         private static _snapToggle _snapToggleFunc;
         internal static void snapToggle()
         {
         	if (_snapToggleFunc == null)
         	{
         		_snapToggleFunc =
         			(_snapToggle)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_snapToggle"), typeof(_snapToggle));
         	}
         
         	 _snapToggleFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getMissionAreaServerObject();
         private static _getMissionAreaServerObject _getMissionAreaServerObjectFunc;
         internal static IntPtr getMissionAreaServerObject()
         {
         	if (_getMissionAreaServerObjectFunc == null)
         	{
         		_getMissionAreaServerObjectFunc =
         			(_getMissionAreaServerObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getMissionAreaServerObject"), typeof(_getMissionAreaServerObject));
         	}
         
         	return  _getMissionAreaServerObjectFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _calcExplosionCoverage(InternalPoint3FStruct pos, int id, uint covMask);
         private static _calcExplosionCoverage _calcExplosionCoverageFunc;
         internal static float calcExplosionCoverage(InternalPoint3FStruct pos, int id, uint covMask)
         {
         	if (_calcExplosionCoverageFunc == null)
         	{
         		_calcExplosionCoverageFunc =
         			(_calcExplosionCoverage)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_calcExplosionCoverage"), typeof(_calcExplosionCoverage));
         	}
         
         	return  _calcExplosionCoverageFunc(pos, id, covMask);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _StartFoliageReplication();
         private static _StartFoliageReplication _StartFoliageReplicationFunc;
         internal static void StartFoliageReplication()
         {
         	if (_StartFoliageReplicationFunc == null)
         	{
         		_StartFoliageReplicationFunc =
         			(_StartFoliageReplication)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_StartFoliageReplication"), typeof(_StartFoliageReplication));
         	}
         
         	 _StartFoliageReplicationFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _StartClientReplication();
         private static _StartClientReplication _StartClientReplicationFunc;
         internal static void StartClientReplication()
         {
         	if (_StartClientReplicationFunc == null)
         	{
         		_StartClientReplicationFunc =
         			(_StartClientReplication)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_StartClientReplication"), typeof(_StartClientReplication));
         	}
         
         	 _StartClientReplicationFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _physicsPluginPresent();
         private static _physicsPluginPresent _physicsPluginPresentFunc;
         internal static bool physicsPluginPresent()
         {
         	if (_physicsPluginPresentFunc == null)
         	{
         		_physicsPluginPresentFunc =
         			(_physicsPluginPresent)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_physicsPluginPresent"), typeof(_physicsPluginPresent));
         	}
         
         	return  _physicsPluginPresentFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _physicsInit([MarshalAs(UnmanagedType.LPWStr)]string library);
         private static _physicsInit _physicsInitFunc;
         internal static bool physicsInit([MarshalAs(UnmanagedType.LPWStr)]string library)
         {
         	if (_physicsInitFunc == null)
         	{
         		_physicsInitFunc =
         			(_physicsInit)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_physicsInit"), typeof(_physicsInit));
         	}
         
         	return  _physicsInitFunc(library);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _physicsDestroy();
         private static _physicsDestroy _physicsDestroyFunc;
         internal static void physicsDestroy()
         {
         	if (_physicsDestroyFunc == null)
         	{
         		_physicsDestroyFunc =
         			(_physicsDestroy)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_physicsDestroy"), typeof(_physicsDestroy));
         	}
         
         	 _physicsDestroyFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _physicsInitWorld([MarshalAs(UnmanagedType.LPWStr)]string worldName);
         private static _physicsInitWorld _physicsInitWorldFunc;
         internal static bool physicsInitWorld([MarshalAs(UnmanagedType.LPWStr)]string worldName)
         {
         	if (_physicsInitWorldFunc == null)
         	{
         		_physicsInitWorldFunc =
         			(_physicsInitWorld)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_physicsInitWorld"), typeof(_physicsInitWorld));
         	}
         
         	return  _physicsInitWorldFunc(worldName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _physicsDestroyWorld([MarshalAs(UnmanagedType.LPWStr)]string worldName);
         private static _physicsDestroyWorld _physicsDestroyWorldFunc;
         internal static void physicsDestroyWorld([MarshalAs(UnmanagedType.LPWStr)]string worldName)
         {
         	if (_physicsDestroyWorldFunc == null)
         	{
         		_physicsDestroyWorldFunc =
         			(_physicsDestroyWorld)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_physicsDestroyWorld"), typeof(_physicsDestroyWorld));
         	}
         
         	 _physicsDestroyWorldFunc(worldName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _physicsStartSimulation([MarshalAs(UnmanagedType.LPWStr)]string worldName);
         private static _physicsStartSimulation _physicsStartSimulationFunc;
         internal static void physicsStartSimulation([MarshalAs(UnmanagedType.LPWStr)]string worldName)
         {
         	if (_physicsStartSimulationFunc == null)
         	{
         		_physicsStartSimulationFunc =
         			(_physicsStartSimulation)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_physicsStartSimulation"), typeof(_physicsStartSimulation));
         	}
         
         	 _physicsStartSimulationFunc(worldName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _physicsStopSimulation([MarshalAs(UnmanagedType.LPWStr)]string worldName);
         private static _physicsStopSimulation _physicsStopSimulationFunc;
         internal static void physicsStopSimulation([MarshalAs(UnmanagedType.LPWStr)]string worldName)
         {
         	if (_physicsStopSimulationFunc == null)
         	{
         		_physicsStopSimulationFunc =
         			(_physicsStopSimulation)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_physicsStopSimulation"), typeof(_physicsStopSimulation));
         	}
         
         	 _physicsStopSimulationFunc(worldName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _physicsSimulationEnabled();
         private static _physicsSimulationEnabled _physicsSimulationEnabledFunc;
         internal static bool physicsSimulationEnabled()
         {
         	if (_physicsSimulationEnabledFunc == null)
         	{
         		_physicsSimulationEnabledFunc =
         			(_physicsSimulationEnabled)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_physicsSimulationEnabled"), typeof(_physicsSimulationEnabled));
         	}
         
         	return  _physicsSimulationEnabledFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _physicsSetTimeScale(float scale);
         private static _physicsSetTimeScale _physicsSetTimeScaleFunc;
         internal static void physicsSetTimeScale(float scale)
         {
         	if (_physicsSetTimeScaleFunc == null)
         	{
         		_physicsSetTimeScaleFunc =
         			(_physicsSetTimeScale)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_physicsSetTimeScale"), typeof(_physicsSetTimeScale));
         	}
         
         	 _physicsSetTimeScaleFunc(scale);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate float _physicsGetTimeScale();
         private static _physicsGetTimeScale _physicsGetTimeScaleFunc;
         internal static float physicsGetTimeScale()
         {
         	if (_physicsGetTimeScaleFunc == null)
         	{
         		_physicsGetTimeScaleFunc =
         			(_physicsGetTimeScale)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_physicsGetTimeScale"), typeof(_physicsGetTimeScale));
         	}
         
         	return  _physicsGetTimeScaleFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _physicsStoreState();
         private static _physicsStoreState _physicsStoreStateFunc;
         internal static void physicsStoreState()
         {
         	if (_physicsStoreStateFunc == null)
         	{
         		_physicsStoreStateFunc =
         			(_physicsStoreState)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_physicsStoreState"), typeof(_physicsStoreState));
         	}
         
         	 _physicsStoreStateFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _physicsRestoreState();
         private static _physicsRestoreState _physicsRestoreStateFunc;
         internal static void physicsRestoreState()
         {
         	if (_physicsRestoreStateFunc == null)
         	{
         		_physicsRestoreStateFunc =
         			(_physicsRestoreState)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_physicsRestoreState"), typeof(_physicsRestoreState));
         	}
         
         	 _physicsRestoreStateFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _physicsDebugDraw(bool enable);
         private static _physicsDebugDraw _physicsDebugDrawFunc;
         internal static void physicsDebugDraw(bool enable)
         {
         	if (_physicsDebugDrawFunc == null)
         	{
         		_physicsDebugDrawFunc =
         			(_physicsDebugDraw)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_physicsDebugDraw"), typeof(_physicsDebugDraw));
         	}
         
         	 _physicsDebugDrawFunc(enable);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _decalManagerSave([MarshalAs(UnmanagedType.LPWStr)]string decalSaveFile);
         private static _decalManagerSave _decalManagerSaveFunc;
         internal static void decalManagerSave([MarshalAs(UnmanagedType.LPWStr)]string decalSaveFile)
         {
         	if (_decalManagerSaveFunc == null)
         	{
         		_decalManagerSaveFunc =
         			(_decalManagerSave)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_decalManagerSave"), typeof(_decalManagerSave));
         	}
         
         	 _decalManagerSaveFunc(decalSaveFile);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _decalManagerLoad([MarshalAs(UnmanagedType.LPWStr)]string fileName);
         private static _decalManagerLoad _decalManagerLoadFunc;
         internal static bool decalManagerLoad([MarshalAs(UnmanagedType.LPWStr)]string fileName)
         {
         	if (_decalManagerLoadFunc == null)
         	{
         		_decalManagerLoadFunc =
         			(_decalManagerLoad)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_decalManagerLoad"), typeof(_decalManagerLoad));
         	}
         
         	return  _decalManagerLoadFunc(fileName);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _decalManagerDirty();
         private static _decalManagerDirty _decalManagerDirtyFunc;
         internal static bool decalManagerDirty()
         {
         	if (_decalManagerDirtyFunc == null)
         	{
         		_decalManagerDirtyFunc =
         			(_decalManagerDirty)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_decalManagerDirty"), typeof(_decalManagerDirty));
         	}
         
         	return  _decalManagerDirtyFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _decalManagerClear();
         private static _decalManagerClear _decalManagerClearFunc;
         internal static void decalManagerClear()
         {
         	if (_decalManagerClearFunc == null)
         	{
         		_decalManagerClearFunc =
         			(_decalManagerClear)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_decalManagerClear"), typeof(_decalManagerClear));
         	}
         
         	 _decalManagerClearFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _decalManagerAddDecal(InternalPoint3FStruct position, InternalPoint3FStruct normal, float rot, float scale, IntPtr decalData, bool isImmortal);
         private static _decalManagerAddDecal _decalManagerAddDecalFunc;
         internal static int decalManagerAddDecal(InternalPoint3FStruct position, InternalPoint3FStruct normal, float rot, float scale, IntPtr decalData, bool isImmortal)
         {
         	if (_decalManagerAddDecalFunc == null)
         	{
         		_decalManagerAddDecalFunc =
         			(_decalManagerAddDecal)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_decalManagerAddDecal"), typeof(_decalManagerAddDecal));
         	}
         
         	return  _decalManagerAddDecalFunc(position, normal, rot, scale, decalData, isImmortal);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _decalManagerRemoveDecal(int decalID);
         private static _decalManagerRemoveDecal _decalManagerRemoveDecalFunc;
         internal static bool decalManagerRemoveDecal(int decalID)
         {
         	if (_decalManagerRemoveDecalFunc == null)
         	{
         		_decalManagerRemoveDecalFunc =
         			(_decalManagerRemoveDecal)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_decalManagerRemoveDecal"), typeof(_decalManagerRemoveDecal));
         	}
         
         	return  _decalManagerRemoveDecalFunc(decalID);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _decalManagerEditDecal(int decalID, InternalPoint3FStruct pos, InternalPoint3FStruct normal, float rotAroundNormal, float decalScale);
         private static _decalManagerEditDecal _decalManagerEditDecalFunc;
         internal static bool decalManagerEditDecal(int decalID, InternalPoint3FStruct pos, InternalPoint3FStruct normal, float rotAroundNormal, float decalScale)
         {
         	if (_decalManagerEditDecalFunc == null)
         	{
         		_decalManagerEditDecalFunc =
         			(_decalManagerEditDecal)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_decalManagerEditDecal"), typeof(_decalManagerEditDecal));
         	}
         
         	return  _decalManagerEditDecalFunc(decalID, pos, normal, rotAroundNormal, decalScale);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _dumpProcessList();
         private static _dumpProcessList _dumpProcessListFunc;
         internal static void dumpProcessList()
         {
         	if (_dumpProcessListFunc == null)
         	{
         		_dumpProcessListFunc =
         			(_dumpProcessList)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_dumpProcessList"), typeof(_dumpProcessList));
         	}
         
         	 _dumpProcessListFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _TamlWrite(IntPtr simObject, [MarshalAs(UnmanagedType.LPWStr)]string filename, [MarshalAs(UnmanagedType.LPWStr)]string format, bool compressed);
         private static _TamlWrite _TamlWriteFunc;
         internal static bool TamlWrite(IntPtr simObject, [MarshalAs(UnmanagedType.LPWStr)]string filename, [MarshalAs(UnmanagedType.LPWStr)]string format, bool compressed)
         {
         	if (_TamlWriteFunc == null)
         	{
         		_TamlWriteFunc =
         			(_TamlWrite)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_TamlWrite"), typeof(_TamlWrite));
         	}
         
         	return  _TamlWriteFunc(simObject, filename, format, compressed);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _TamlRead([MarshalAs(UnmanagedType.LPWStr)]string filename, [MarshalAs(UnmanagedType.LPWStr)]string format);
         private static _TamlRead _TamlReadFunc;
         internal static IntPtr TamlRead([MarshalAs(UnmanagedType.LPWStr)]string filename, [MarshalAs(UnmanagedType.LPWStr)]string format)
         {
         	if (_TamlReadFunc == null)
         	{
         		_TamlReadFunc =
         			(_TamlRead)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_TamlRead"), typeof(_TamlRead));
         	}
         
         	return  _TamlReadFunc(filename, format);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _GenerateTamlSchema();
         private static _GenerateTamlSchema _GenerateTamlSchemaFunc;
         internal static bool GenerateTamlSchema()
         {
         	if (_GenerateTamlSchemaFunc == null)
         	{
         		_GenerateTamlSchemaFunc =
         			(_GenerateTamlSchema)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_GenerateTamlSchema"), typeof(_GenerateTamlSchema));
         	}
         
         	return  _GenerateTamlSchemaFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _enumColladaForImport([MarshalAs(UnmanagedType.LPWStr)]string shapePath, [MarshalAs(UnmanagedType.LPWStr)]string ctrl);
         private static _enumColladaForImport _enumColladaForImportFunc;
         internal static bool enumColladaForImport([MarshalAs(UnmanagedType.LPWStr)]string shapePath, [MarshalAs(UnmanagedType.LPWStr)]string ctrl)
         {
         	if (_enumColladaForImportFunc == null)
         	{
         		_enumColladaForImportFunc =
         			(_enumColladaForImport)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_enumColladaForImport"), typeof(_enumColladaForImport));
         	}
         
         	return  _enumColladaForImportFunc(shapePath, ctrl);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _loadColladaLights([MarshalAs(UnmanagedType.LPWStr)]string filename, [MarshalAs(UnmanagedType.LPWStr)]string parentGroup, [MarshalAs(UnmanagedType.LPWStr)]string baseObject);
         private static _loadColladaLights _loadColladaLightsFunc;
         internal static bool loadColladaLights([MarshalAs(UnmanagedType.LPWStr)]string filename, [MarshalAs(UnmanagedType.LPWStr)]string parentGroup, [MarshalAs(UnmanagedType.LPWStr)]string baseObject)
         {
         	if (_loadColladaLightsFunc == null)
         	{
         		_loadColladaLightsFunc =
         			(_loadColladaLights)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_loadColladaLights"), typeof(_loadColladaLights));
         	}
         
         	return  _loadColladaLightsFunc(filename, parentGroup, baseObject);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getFormatExtensions();
         private static _getFormatExtensions _getFormatExtensionsFunc;
         internal static IntPtr getFormatExtensions()
         {
         	if (_getFormatExtensionsFunc == null)
         	{
         		_getFormatExtensionsFunc =
         			(_getFormatExtensions)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getFormatExtensions"), typeof(_getFormatExtensions));
         	}
         
         	return  _getFormatExtensionsFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getFormatFilters();
         private static _getFormatFilters _getFormatFiltersFunc;
         internal static IntPtr getFormatFilters()
         {
         	if (_getFormatFiltersFunc == null)
         	{
         		_getFormatFiltersFunc =
         			(_getFormatFilters)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getFormatFilters"), typeof(_getFormatFilters));
         	}
         
         	return  _getFormatFiltersFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _setShadowVizLight([MarshalAs(UnmanagedType.LPWStr)]string name);
         private static _setShadowVizLight _setShadowVizLightFunc;
         internal static IntPtr setShadowVizLight([MarshalAs(UnmanagedType.LPWStr)]string name)
         {
         	if (_setShadowVizLightFunc == null)
         	{
         		_setShadowVizLightFunc =
         			(_setShadowVizLight)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_setShadowVizLight"), typeof(_setShadowVizLight));
         	}
         
         	return  _setShadowVizLightFunc(name);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getNavMeshEventManager();
         private static _getNavMeshEventManager _getNavMeshEventManagerFunc;
         internal static int getNavMeshEventManager()
         {
         	if (_getNavMeshEventManagerFunc == null)
         	{
         		_getNavMeshEventManagerFunc =
         			(_getNavMeshEventManager)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getNavMeshEventManager"), typeof(_getNavMeshEventManager));
         	}
         
         	return  _getNavMeshEventManagerFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _NavMeshUpdateAll(int objid, bool remove);
         private static _NavMeshUpdateAll _NavMeshUpdateAllFunc;
         internal static void NavMeshUpdateAll(int objid, bool remove)
         {
         	if (_NavMeshUpdateAllFunc == null)
         	{
         		_NavMeshUpdateAllFunc =
         			(_NavMeshUpdateAll)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_NavMeshUpdateAll"), typeof(_NavMeshUpdateAll));
         	}
         
         	 _NavMeshUpdateAllFunc(objid, remove);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _NavMeshUpdateAroundObject(int objid, bool remove);
         private static _NavMeshUpdateAroundObject _NavMeshUpdateAroundObjectFunc;
         internal static void NavMeshUpdateAroundObject(int objid, bool remove)
         {
         	if (_NavMeshUpdateAroundObjectFunc == null)
         	{
         		_NavMeshUpdateAroundObjectFunc =
         			(_NavMeshUpdateAroundObject)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_NavMeshUpdateAroundObject"), typeof(_NavMeshUpdateAroundObject));
         	}
         
         	 _NavMeshUpdateAroundObjectFunc(objid, remove);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _NavMeshIgnore(int objid, bool _ignore);
         private static _NavMeshIgnore _NavMeshIgnoreFunc;
         internal static void NavMeshIgnore(int objid, bool _ignore)
         {
         	if (_NavMeshIgnoreFunc == null)
         	{
         		_NavMeshIgnoreFunc =
         			(_NavMeshIgnore)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_NavMeshIgnore"), typeof(_NavMeshIgnore));
         	}
         
         	 _NavMeshIgnoreFunc(objid, _ignore);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _NavMeshUpdateOne(int meshid, int objid, bool remove);
         private static _NavMeshUpdateOne _NavMeshUpdateOneFunc;
         internal static void NavMeshUpdateOne(int meshid, int objid, bool remove)
         {
         	if (_NavMeshUpdateOneFunc == null)
         	{
         		_NavMeshUpdateOneFunc =
         			(_NavMeshUpdateOne)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_NavMeshUpdateOne"), typeof(_NavMeshUpdateOne));
         	}
         
         	 _NavMeshUpdateOneFunc(meshid, objid, remove);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _runAllUnitTests([MarshalAs(UnmanagedType.LPWStr)]string testSpecs);
         private static _runAllUnitTests _runAllUnitTestsFunc;
         internal static int runAllUnitTests([MarshalAs(UnmanagedType.LPWStr)]string testSpecs)
         {
         	if (_runAllUnitTestsFunc == null)
         	{
         		_runAllUnitTestsFunc =
         			(_runAllUnitTests)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_runAllUnitTests"), typeof(_runAllUnitTests));
         	}
         
         	return  _runAllUnitTestsFunc(testSpecs);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _initDisplayDeviceInfo();
         private static _initDisplayDeviceInfo _initDisplayDeviceInfoFunc;
         internal static void initDisplayDeviceInfo()
         {
         	if (_initDisplayDeviceInfoFunc == null)
         	{
         		_initDisplayDeviceInfoFunc =
         			(_initDisplayDeviceInfo)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_initDisplayDeviceInfo"), typeof(_initDisplayDeviceInfo));
         	}
         
         	 _initDisplayDeviceInfoFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _enableWinConsole(bool flag);
         private static _enableWinConsole _enableWinConsoleFunc;
         internal static void enableWinConsole(bool flag)
         {
         	if (_enableWinConsoleFunc == null)
         	{
         		_enableWinConsoleFunc =
         			(_enableWinConsole)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_enableWinConsole"), typeof(_enableWinConsole));
         	}
         
         	 _enableWinConsoleFunc(flag);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _enableJoystick();
         private static _enableJoystick _enableJoystickFunc;
         internal static bool enableJoystick()
         {
         	if (_enableJoystickFunc == null)
         	{
         		_enableJoystickFunc =
         			(_enableJoystick)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_enableJoystick"), typeof(_enableJoystick));
         	}
         
         	return  _enableJoystickFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _disableJoystick();
         private static _disableJoystick _disableJoystickFunc;
         internal static void disableJoystick()
         {
         	if (_disableJoystickFunc == null)
         	{
         		_disableJoystickFunc =
         			(_disableJoystick)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_disableJoystick"), typeof(_disableJoystick));
         	}
         
         	 _disableJoystickFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isJoystickEnabled();
         private static _isJoystickEnabled _isJoystickEnabledFunc;
         internal static bool isJoystickEnabled()
         {
         	if (_isJoystickEnabledFunc == null)
         	{
         		_isJoystickEnabledFunc =
         			(_isJoystickEnabled)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_isJoystickEnabled"), typeof(_isJoystickEnabled));
         	}
         
         	return  _isJoystickEnabledFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _enableXInput();
         private static _enableXInput _enableXInputFunc;
         internal static bool enableXInput()
         {
         	if (_enableXInputFunc == null)
         	{
         		_enableXInputFunc =
         			(_enableXInput)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_enableXInput"), typeof(_enableXInput));
         	}
         
         	return  _enableXInputFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _disableXInput();
         private static _disableXInput _disableXInputFunc;
         internal static void disableXInput()
         {
         	if (_disableXInputFunc == null)
         	{
         		_disableXInputFunc =
         			(_disableXInput)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_disableXInput"), typeof(_disableXInput));
         	}
         
         	 _disableXInputFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _resetXInput();
         private static _resetXInput _resetXInputFunc;
         internal static void resetXInput()
         {
         	if (_resetXInputFunc == null)
         	{
         		_resetXInputFunc =
         			(_resetXInput)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_resetXInput"), typeof(_resetXInput));
         	}
         
         	 _resetXInputFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isXInputConnected(int controllerID);
         private static _isXInputConnected _isXInputConnectedFunc;
         internal static bool isXInputConnected(int controllerID)
         {
         	if (_isXInputConnectedFunc == null)
         	{
         		_isXInputConnectedFunc =
         			(_isXInputConnected)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_isXInputConnected"), typeof(_isXInputConnected));
         	}
         
         	return  _isXInputConnectedFunc(controllerID);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate int _getXInputState(int controllerID, [MarshalAs(UnmanagedType.LPWStr)]string properties, bool current);
         private static _getXInputState _getXInputStateFunc;
         internal static int getXInputState(int controllerID, [MarshalAs(UnmanagedType.LPWStr)]string properties, bool current)
         {
         	if (_getXInputStateFunc == null)
         	{
         		_getXInputStateFunc =
         			(_getXInputState)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getXInputState"), typeof(_getXInputState));
         	}
         
         	return  _getXInputStateFunc(controllerID, properties, current);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _echoInputState();
         private static _echoInputState _echoInputStateFunc;
         internal static void echoInputState()
         {
         	if (_echoInputStateFunc == null)
         	{
         		_echoInputStateFunc =
         			(_echoInputState)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_echoInputState"), typeof(_echoInputState));
         	}
         
         	 _echoInputStateFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _rumble([MarshalAs(UnmanagedType.LPWStr)]string device, float xRumble, float yRumble);
         private static _rumble _rumbleFunc;
         internal static void rumble([MarshalAs(UnmanagedType.LPWStr)]string device, float xRumble, float yRumble)
         {
         	if (_rumbleFunc == null)
         	{
         		_rumbleFunc =
         			(_rumble)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_rumble"), typeof(_rumble));
         	}
         
         	 _rumbleFunc(device, xRumble, yRumble);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _shellExecute([MarshalAs(UnmanagedType.LPWStr)]string executable, [MarshalAs(UnmanagedType.LPWStr)]string args, [MarshalAs(UnmanagedType.LPWStr)]string directory);
         private static _shellExecute _shellExecuteFunc;
         internal static bool shellExecute([MarshalAs(UnmanagedType.LPWStr)]string executable, [MarshalAs(UnmanagedType.LPWStr)]string args, [MarshalAs(UnmanagedType.LPWStr)]string directory)
         {
         	if (_shellExecuteFunc == null)
         	{
         		_shellExecuteFunc =
         			(_shellExecute)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_shellExecute"), typeof(_shellExecute));
         	}
         
         	return  _shellExecuteFunc(executable, args, directory);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isJoystickDetected();
         private static _isJoystickDetected _isJoystickDetectedFunc;
         internal static bool isJoystickDetected()
         {
         	if (_isJoystickDetectedFunc == null)
         	{
         		_isJoystickDetectedFunc =
         			(_isJoystickDetected)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_isJoystickDetected"), typeof(_isJoystickDetected));
         	}
         
         	return  _isJoystickDetectedFunc();
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate IntPtr _getJoystickAxes(uint deviceID);
         private static _getJoystickAxes _getJoystickAxesFunc;
         internal static IntPtr getJoystickAxes(uint deviceID)
         {
         	if (_getJoystickAxesFunc == null)
         	{
         		_getJoystickAxesFunc =
         			(_getJoystickAxes)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_getJoystickAxes"), typeof(_getJoystickAxes));
         	}
         
         	return  _getJoystickAxesFunc(deviceID);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         private delegate void _mathInit(int argc, string[] argv);
         private static _mathInit _mathInitFunc;
         internal static void mathInit(int argc, string[] argv)
         {
         	if (_mathInitFunc == null)
         	{
         		_mathInitFunc =
         			(_mathInit)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_mathInit"), typeof(_mathInit));
         	}
         
         	 _mathInitFunc(argc, argv);
         }
      
         [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
         [return: MarshalAs(UnmanagedType.I1)]
         private delegate bool _isKoreanBuild();
         private static _isKoreanBuild _isKoreanBuildFunc;
         internal static bool isKoreanBuild()
         {
         	if (_isKoreanBuildFunc == null)
         	{
         		_isKoreanBuildFunc =
         			(_isKoreanBuild)Marshal.GetDelegateForFunctionPointer(Torque3D.DllLoadUtils.GetProcAddress(Torque3D.Torque3DLibHandle,
         				"fn_isKoreanBuild"), typeof(_isKoreanBuild));
         	}
         
         	return  _isKoreanBuildFunc();
         }
      
      }
      
      #endregion


      #region Functions
      
         public static bool addBadWord(string badWord)
         {
            return InternalUnsafeMethods.addBadWord(badWord);
         }
      
         public static string filterString(string baseString = null, string replacementChars = null)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.filterString(baseString, replacementChars));
         }
      
         public static bool containsBadWords(string text)
         {
            return InternalUnsafeMethods.containsBadWords(text);
         }
      
         public static void deactivateDirectInput()
         {
            InternalUnsafeMethods.deactivateDirectInput();
         }
      
         public static void activateDirectInput()
         {
            InternalUnsafeMethods.activateDirectInput();
         }
      
         public static string strToPlayerName(string ptr)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.strToPlayerName(ptr));
         }
      
         public static void lockMouse(bool isLocked)
         {
            InternalUnsafeMethods.lockMouse(isLocked);
         }
      
         public static bool setNetPort(int port, bool bind = true)
         {
            return InternalUnsafeMethods.setNetPort(port, bind);
         }
      
         public static void closeNetPort()
         {
            InternalUnsafeMethods.closeNetPort();
         }
      
         public static void saveJournal(string filename)
         {
            InternalUnsafeMethods.saveJournal(filename);
         }
      
         public static void playJournal(string filename)
         {
            InternalUnsafeMethods.playJournal(filename);
         }
      
         public static int getSimTime()
         {
            return InternalUnsafeMethods.getSimTime();
         }
      
         public static int getRealTime()
         {
            return InternalUnsafeMethods.getRealTime();
         }
      
         public static string getLocalTime()
         {
            List<string> tmp_arg_list = new List<string> {""};
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getLocalTime(tmp_arg_list.Count, tmp_arg_list.ToArray()));
         }
      
         public static void commandToServer(string func, params string[] args)
         {
            List<string> tmp_arg_list = new List<string> {""};
            tmp_arg_list.Add(func.ToString());
         tmp_arg_list.AddRange(args);
                  InternalUnsafeMethods.commandToServer(tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public static void commandToClient(NetConnection client, string func, params string[] args)
         {
            List<string> tmp_arg_list = new List<string> {""};
            tmp_arg_list.Add(client.getId().ToString());
                  tmp_arg_list.Add(func.ToString());
         tmp_arg_list.AddRange(args);
                  InternalUnsafeMethods.commandToClient(tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public static void removeTaggedString(int tag = -1)
         {
            InternalUnsafeMethods.removeTaggedString(tag);
         }
      
         public static string addTaggedString(string str = "")
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.addTaggedString(str));
         }
      
         public static string getTaggedString(string tag = "")
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getTaggedString(tag));
         }
      
         public static string buildTaggedString(string format)
         {
            List<string> tmp_arg_list = new List<string> {""};
            tmp_arg_list.Add(format.ToString());
                  return Marshal.PtrToStringUni(InternalUnsafeMethods.buildTaggedString(tmp_arg_list.Count, tmp_arg_list.ToArray()));
         }
      
         public static void queryAllServers(uint lanPort, uint flags, string gameType, string missionType, uint minPlayers, uint maxPlayers, uint maxBots, uint regionMask, uint maxPing, uint minCPU, uint filterFlags)
         {
            InternalUnsafeMethods.queryAllServers(lanPort, flags, gameType, missionType, minPlayers, maxPlayers, maxBots, regionMask, maxPing, minCPU, filterFlags);
         }
      
         public static void queryLanServers(uint lanPort, uint flags, string gameType, string missionType, uint minPlayers, uint maxPlayers, uint maxBots, uint regionMask, uint maxPing, uint minCPU, uint filterFlags)
         {
            InternalUnsafeMethods.queryLanServers(lanPort, flags, gameType, missionType, minPlayers, maxPlayers, maxBots, regionMask, maxPing, minCPU, filterFlags);
         }
      
         public static void queryMasterServer(uint flags, string gameType, string missionType, uint minPlayers, uint maxPlayers, uint maxBots, uint regionMask, uint maxPing, uint minCPU, uint filterFlags)
         {
            InternalUnsafeMethods.queryMasterServer(flags, gameType, missionType, minPlayers, maxPlayers, maxBots, regionMask, maxPing, minCPU, filterFlags);
         }
      
         public static void querySingleServer(string addrText, byte flags = 0)
         {
            InternalUnsafeMethods.querySingleServer(addrText, flags);
         }
      
         public static void cancelServerQuery()
         {
            InternalUnsafeMethods.cancelServerQuery();
         }
      
         public static void stopServerQuery()
         {
            InternalUnsafeMethods.stopServerQuery();
         }
      
         public static void startHeartbeat()
         {
            InternalUnsafeMethods.startHeartbeat();
         }
      
         public static void stopHeartbeat()
         {
            InternalUnsafeMethods.stopHeartbeat();
         }
      
         public static int getServerCount()
         {
            return InternalUnsafeMethods.getServerCount();
         }
      
         public static bool setServerInfo(uint index)
         {
            return InternalUnsafeMethods.setServerInfo(index);
         }
      
         public static int getVersionNumber()
         {
            return InternalUnsafeMethods.getVersionNumber();
         }
      
         public static int getAppVersionNumber()
         {
            return InternalUnsafeMethods.getAppVersionNumber();
         }
      
         public static string getVersionString()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getVersionString());
         }
      
         public static string getAppVersionString()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getAppVersionString());
         }
      
         public static string getEngineName()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getEngineName());
         }
      
         public static string getCompileTimeString()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getCompileTimeString());
         }
      
         public static string getBuildString()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getBuildString());
         }
      
         public static string sfxGetActiveStates()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.sfxGetActiveStates());
         }
      
         public static string sfxGetAvailableDevices()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.sfxGetAvailableDevices());
         }
      
         public static bool sfxCreateDevice(string provider, string device, bool useHardware, int maxBuffers)
         {
            return InternalUnsafeMethods.sfxCreateDevice(provider, device, useHardware, maxBuffers);
         }
      
         public static void sfxDeleteDevice()
         {
            InternalUnsafeMethods.sfxDeleteDevice();
         }
      
         public static string sfxGetDeviceInfo()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.sfxGetDeviceInfo());
         }
      
         public static int sfxCreateSource(string sfxType, string arg0 = "", string arg1 = "", string arg2 = "", string arg3 = "")
         {
            return InternalUnsafeMethods.sfxCreateSource(sfxType, arg0, arg1, arg2, arg3);
         }
      
         public static int sfxPlay(string trackName, string pointOrX = "", string y = "", string z = "")
         {
            return InternalUnsafeMethods.sfxPlay(trackName, pointOrX, y, z);
         }
      
         public static int sfxPlayOnce(string sfxType, string arg0 = "", string arg1 = "", string arg2 = "", string arg3 = "", string arg4 = "-1.0f")
         {
            return InternalUnsafeMethods.sfxPlayOnce(sfxType, arg0, arg1, arg2, arg3, arg4);
         }
      
         public static void sfxStop(SFXSource source)
         {
            InternalUnsafeMethods.sfxStop(source.ObjectPtr);
         }
      
         public static void sfxStopAndDelete(SFXSource source)
         {
            InternalUnsafeMethods.sfxStopAndDelete(source.ObjectPtr);
         }
      
         public static void sfxDeleteWhenStopped(SFXSource source)
         {
            InternalUnsafeMethods.sfxDeleteWhenStopped(source.ObjectPtr);
         }
      
         public static SFXDistanceModel sfxGetDistanceModel()
         {
            return InternalUnsafeMethods.sfxGetDistanceModel();
         }
      
         public static void sfxSetDistanceModel(SFXDistanceModel model)
         {
            InternalUnsafeMethods.sfxSetDistanceModel(model);
         }
      
         public static float sfxGetDopplerFactor()
         {
            return InternalUnsafeMethods.sfxGetDopplerFactor();
         }
      
         public static void sfxSetDopplerFactor(float value)
         {
            InternalUnsafeMethods.sfxSetDopplerFactor(value);
         }
      
         public static float sfxGetRolloffFactor()
         {
            return InternalUnsafeMethods.sfxGetRolloffFactor();
         }
      
         public static void sfxSetRolloffFactor(float value)
         {
            InternalUnsafeMethods.sfxSetRolloffFactor(value);
         }
      
         public static void sfxDumpSources(bool includeGroups = false)
         {
            InternalUnsafeMethods.sfxDumpSources(includeGroups);
         }
      
         public static string sfxDumpSourcesToString(bool includeGroups = false)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.sfxDumpSourcesToString(includeGroups));
         }
      
         public static void cls()
         {
            InternalUnsafeMethods.cls();
         }
      
         public static string getClipboard()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getClipboard());
         }
      
         public static bool setClipboard(string text)
         {
            return InternalUnsafeMethods.setClipboard(text);
         }
      
         public static void log(string message)
         {
            InternalUnsafeMethods.log(message);
         }
      
         public static void logError(string message)
         {
            InternalUnsafeMethods.logError(message);
         }
      
         public static void logWarning(string message)
         {
            InternalUnsafeMethods.logWarning(message);
         }
      
         public static void dumpConsoleClasses(bool dumpScript = true, bool dumpEngine = true)
         {
            InternalUnsafeMethods.dumpConsoleClasses(dumpScript, dumpEngine);
         }
      
         public static void dumpConsoleFunctions(bool dumpScript = true, bool dumpEngine = true)
         {
            InternalUnsafeMethods.dumpConsoleFunctions(dumpScript, dumpEngine);
         }
      
         public static int strasc(string chr)
         {
            return InternalUnsafeMethods.strasc(chr);
         }
      
         public static string strformat(string format, string value)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.strformat(format, value));
         }
      
         public static int strcmp(string str1, string str2)
         {
            return InternalUnsafeMethods.strcmp(str1, str2);
         }
      
         public static int stricmp(string str1, string str2)
         {
            return InternalUnsafeMethods.stricmp(str1, str2);
         }
      
         public static int strnatcmp(string str1, string str2)
         {
            return InternalUnsafeMethods.strnatcmp(str1, str2);
         }
      
         public static int strinatcmp(string str1, string str2)
         {
            return InternalUnsafeMethods.strinatcmp(str1, str2);
         }
      
         public static int strlen(string str)
         {
            return InternalUnsafeMethods.strlen(str);
         }
      
         public static int strlenskip(string str, string first, string last)
         {
            return InternalUnsafeMethods.strlenskip(str, first, last);
         }
      
         public static int strstr(string _string, string substring)
         {
            return InternalUnsafeMethods.strstr(_string, substring);
         }
      
         public static int strpos(string haystack, string needle, int offset = 0)
         {
            return InternalUnsafeMethods.strpos(haystack, needle, offset);
         }
      
         public static int strposr(string haystack, string needle, int offset = 0)
         {
            return InternalUnsafeMethods.strposr(haystack, needle, offset);
         }
      
         public static string ltrim(string str)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.ltrim(str));
         }
      
         public static string rtrim(string str)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.rtrim(str));
         }
      
         public static string trim(string str)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.trim(str));
         }
      
         public static string stripChars(string str, string chars)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.stripChars(str, chars));
         }
      
         public static string strlwr(string str)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.strlwr(str));
         }
      
         public static string strupr(string str)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.strupr(str));
         }
      
         public static string strchr(string str, string chr)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.strchr(str, chr));
         }
      
         public static string strrchr(string str, string chr)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.strrchr(str, chr));
         }
      
         public static string strreplace(string source, string from, string to)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.strreplace(source, from, to));
         }
      
         public static string strrepeat(string str, int numTimes, string delimiter = "")
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.strrepeat(str, numTimes, delimiter));
         }
      
         public static string getSubStr(string str, int start, int numChars = -1)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getSubStr(str, start, numChars));
         }
      
         public static bool strIsMatchExpr(string pattern, string str, bool caseSensitive = false)
         {
            return InternalUnsafeMethods.strIsMatchExpr(pattern, str, caseSensitive);
         }
      
         public static bool strIsMatchMultipleExpr(string patterns, string str, bool caseSensitive = false)
         {
            return InternalUnsafeMethods.strIsMatchMultipleExpr(patterns, str, caseSensitive);
         }
      
         public static int getTrailingNumber(string str)
         {
            return InternalUnsafeMethods.getTrailingNumber(str);
         }
      
         public static string stripTrailingNumber(string str)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.stripTrailingNumber(str));
         }
      
         public static string getFirstNumber(string str)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getFirstNumber(str));
         }
      
         public static bool isspace(string str, int index)
         {
            return InternalUnsafeMethods.isspace(str, index);
         }
      
         public static bool isalnum(string str, int index)
         {
            return InternalUnsafeMethods.isalnum(str, index);
         }
      
         public static bool startsWith(string str, string prefix, bool caseSensitive = false)
         {
            return InternalUnsafeMethods.startsWith(str, prefix, caseSensitive);
         }
      
         public static bool endsWith(string str, string suffix, bool caseSensitive = false)
         {
            return InternalUnsafeMethods.endsWith(str, suffix, caseSensitive);
         }
      
         public static int strchrpos(string str, string chr, int start = 0)
         {
            return InternalUnsafeMethods.strchrpos(str, chr, start);
         }
      
         public static int strrchrpos(string str, string chr, int start = 0)
         {
            return InternalUnsafeMethods.strrchrpos(str, chr, start);
         }
      
         public static ColorI ColorFloatToInt(ColorF color)
         {
            return new ColorI(InternalUnsafeMethods.ColorFloatToInt(color.ToStruct()));
         }
      
         public static ColorF ColorIntToFloat(ColorI color)
         {
            return new ColorF(InternalUnsafeMethods.ColorIntToFloat(color.ToStruct()));
         }
      
         public static string ColorRGBToHEX(ColorI color)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.ColorRGBToHEX(color.ToStruct()));
         }
      
         public static string ColorRGBToHSB(ColorI color)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.ColorRGBToHSB(color.ToStruct()));
         }
      
         public static ColorI ColorHEXToRGB(string hex)
         {
            return new ColorI(InternalUnsafeMethods.ColorHEXToRGB(hex));
         }
      
         public static ColorI ColorHSBToRGB(Point3I hsb)
         {
            return new ColorI(InternalUnsafeMethods.ColorHSBToRGB(hsb.ToArray()));
         }
      
         public static string strToggleCaseToWords(string str)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.strToggleCaseToWords(str));
         }
      
         public static bool isInt(string str)
         {
            return InternalUnsafeMethods.isInt(str);
         }
      
         public static bool isFloat(string str, bool sciOk = false)
         {
            return InternalUnsafeMethods.isFloat(str, sciOk);
         }
      
         public static bool isValidPort(string str)
         {
            return InternalUnsafeMethods.isValidPort(str);
         }
      
         public static bool isValidIP(string str)
         {
            return InternalUnsafeMethods.isValidIP(str);
         }
      
         public static void addCaseSensitiveStrings()
         {
            List<string> tmp_arg_list = new List<string> {""};
            InternalUnsafeMethods.addCaseSensitiveStrings(tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public static string getWord(string text, int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getWord(text, index));
         }
      
         public static string getWords(string text, int startIndex, int endIndex = -1)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getWords(text, startIndex, endIndex));
         }
      
         public static string setWord(string text, int index, string replacement)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.setWord(text, index, replacement));
         }
      
         public static string removeWord(string text, int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.removeWord(text, index));
         }
      
         public static int getWordCount(string text)
         {
            return InternalUnsafeMethods.getWordCount(text);
         }
      
         public static string monthNumToStr(int num, bool abbreviate = false)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.monthNumToStr(num, abbreviate));
         }
      
         public static string weekdayNumToStr(int num, bool abbreviate = false)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.weekdayNumToStr(num, abbreviate));
         }
      
         public static string getField(string text, int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getField(text, index));
         }
      
         public static string getFields(string text, int startIndex, int endIndex = -1)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getFields(text, startIndex, endIndex));
         }
      
         public static string setField(string text, int index, string replacement)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.setField(text, index, replacement));
         }
      
         public static string removeField(string text, int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.removeField(text, index));
         }
      
         public static int getFieldCount(string text)
         {
            return InternalUnsafeMethods.getFieldCount(text);
         }
      
         public static string getRecord(string text, int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getRecord(text, index));
         }
      
         public static string getRecords(string text, int startIndex, int endIndex = -1)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getRecords(text, startIndex, endIndex));
         }
      
         public static string setRecord(string text, int index, string replacement)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.setRecord(text, index, replacement));
         }
      
         public static string removeRecord(string text, int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.removeRecord(text, index));
         }
      
         public static int getRecordCount(string text)
         {
            return InternalUnsafeMethods.getRecordCount(text);
         }
      
         public static string firstWord(string text)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.firstWord(text));
         }
      
         public static string restWords(string text)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.restWords(text));
         }
      
         public static string nextToken(string str1, string token, string delim)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.nextToken(str1, token, delim));
         }
      
         public static string getToken(string text, string delimiters, int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getToken(text, delimiters, index));
         }
      
         public static string getTokens(string text, string delimiters, int startIndex, int endIndex = -1)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getTokens(text, delimiters, startIndex, endIndex));
         }
      
         public static string setToken(string text, string delimiters, int index, string replacement)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.setToken(text, delimiters, index, replacement));
         }
      
         public static string removeToken(string text, string delimiters, int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.removeToken(text, delimiters, index));
         }
      
         public static int getTokenCount(string text, string delimiters)
         {
            return InternalUnsafeMethods.getTokenCount(text, delimiters);
         }
      
         public static string detag(string str)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.detag(str));
         }
      
         public static string getTag(string textTagString)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getTag(textTagString));
         }
      
         public static void echo(params string[] message)
         {
            List<string> tmp_arg_list = new List<string> {""};
            tmp_arg_list.AddRange(message);
                  InternalUnsafeMethods.echo(tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public static void warn(params string[] message)
         {
            List<string> tmp_arg_list = new List<string> {""};
            tmp_arg_list.AddRange(message);
                  InternalUnsafeMethods.warn(tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public static void error(params string[] message)
         {
            List<string> tmp_arg_list = new List<string> {""};
            tmp_arg_list.AddRange(message);
                  InternalUnsafeMethods.error(tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public static void debugv(string variableName)
         {
            InternalUnsafeMethods.debugv(variableName);
         }
      
         public static string expandEscape(string text)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.expandEscape(text));
         }
      
         public static string collapseEscape(string text)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.collapseEscape(text));
         }
      
         public static void setLogMode(int mode)
         {
            InternalUnsafeMethods.setLogMode(mode);
         }
      
         public static void quit()
         {
            InternalUnsafeMethods.quit();
         }
      
         public static void realQuit()
         {
            InternalUnsafeMethods.realQuit();
         }
      
         public static void quitWithErrorMessage(string message, int status = 0)
         {
            InternalUnsafeMethods.quitWithErrorMessage(message, status);
         }
      
         public static void quitWithStatus(int status = 0)
         {
            InternalUnsafeMethods.quitWithStatus(status);
         }
      
         public static void gotoWebPage(string address)
         {
            InternalUnsafeMethods.gotoWebPage(address);
         }
      
         public static bool displaySplashWindow(string path = "art/gui/splash.bmp")
         {
            return InternalUnsafeMethods.displaySplashWindow(path);
         }
      
         public static void closeSplashWindow()
         {
            InternalUnsafeMethods.closeSplashWindow();
         }
      
         public static bool getWebDeployment()
         {
            return InternalUnsafeMethods.getWebDeployment();
         }
      
         public static int countBits(int v)
         {
            return InternalUnsafeMethods.countBits(v);
         }
      
         public static UUID generateUUID()
         {
            return new UUID(InternalUnsafeMethods.generateUUID());
         }
      
         public static string call(string functionName, params string[] args)
         {
            List<string> tmp_arg_list = new List<string> {""};
            tmp_arg_list.Add(functionName.ToString());
                  tmp_arg_list.AddRange(args);
                  return Marshal.PtrToStringUni(InternalUnsafeMethods.call(tmp_arg_list.Count, tmp_arg_list.ToArray()));
         }
      
         public static string getDSOPath(string scriptFileName)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getDSOPath(scriptFileName));
         }
      
         public static bool compile(string fileName, bool overrideNoDSO = false)
         {
            return InternalUnsafeMethods.compile(fileName, overrideNoDSO);
         }
      
         public static bool exec(string fileName, bool noCalls = false, bool journalScript = false)
         {
            return InternalUnsafeMethods.exec(fileName, noCalls, journalScript);
         }
      
         public static string eval(string consoleString)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.eval(consoleString));
         }
      
         public static string getVariable(string varName)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getVariable(varName));
         }
      
         public static void setVariable(string varName, string value)
         {
            InternalUnsafeMethods.setVariable(varName, value);
         }
      
         public static bool isFunction(string funcName)
         {
            return InternalUnsafeMethods.isFunction(funcName);
         }
      
         public static string getFunctionPackage(string funcName)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getFunctionPackage(funcName));
         }
      
         public static bool isMethod(string nameSpace, string method)
         {
            return InternalUnsafeMethods.isMethod(nameSpace, method);
         }
      
         public static string getMethodPackage(string nameSpace, string method)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getMethodPackage(nameSpace, method));
         }
      
         public static bool isDefined(string varName, string varValue = "")
         {
            return InternalUnsafeMethods.isDefined(varName, varValue);
         }
      
         public static bool isCurrentScriptToolScript()
         {
            return InternalUnsafeMethods.isCurrentScriptToolScript();
         }
      
         public static string getModNameFromPath(string path)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getModNameFromPath(path));
         }
      
         public static void pushInstantGroup(string group = "")
         {
            InternalUnsafeMethods.pushInstantGroup(group);
         }
      
         public static void popInstantGroup()
         {
            InternalUnsafeMethods.popInstantGroup();
         }
      
         public static string getPrefsPath(string relativeFileName = "")
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getPrefsPath(relativeFileName));
         }
      
         public static bool execPrefs(string relativeFileName, bool noCalls = false, bool journalScript = false)
         {
            List<string> tmp_arg_list = new List<string> {""};
            tmp_arg_list.Add(relativeFileName.ToString());
                  tmp_arg_list.Add(noCalls.ToString());
                  tmp_arg_list.Add(journalScript.ToString());
                  return InternalUnsafeMethods.execPrefs(tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public static void export(string pattern, string filename = "", bool append = false)
         {
            InternalUnsafeMethods.export(pattern, filename, append);
         }
      
         public static void deleteVariables(string pattern)
         {
            InternalUnsafeMethods.deleteVariables(pattern);
         }
      
         public static void trace(bool enable = true)
         {
            InternalUnsafeMethods.trace(enable);
         }
      
         public static void debug()
         {
            InternalUnsafeMethods.debug();
         }
      
         public static bool isShippingBuild()
         {
            return InternalUnsafeMethods.isShippingBuild();
         }
      
         public static bool isDebugBuild()
         {
            return InternalUnsafeMethods.isDebugBuild();
         }
      
         public static bool isToolBuild()
         {
            return InternalUnsafeMethods.isToolBuild();
         }
      
         public static int getMaxDynamicVerts()
         {
            return InternalUnsafeMethods.getMaxDynamicVerts();
         }
      
         public static void backtrace()
         {
            InternalUnsafeMethods.backtrace();
         }
      
         public static bool isPackage(string identifier)
         {
            return InternalUnsafeMethods.isPackage(identifier);
         }
      
         public static void activatePackage(string packageName)
         {
            InternalUnsafeMethods.activatePackage(packageName);
         }
      
         public static void deactivatePackage(string packageName)
         {
            InternalUnsafeMethods.deactivatePackage(packageName);
         }
      
         public static string getPackageList()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getPackageList());
         }
      
         public static bool isClass(string identifier)
         {
            return InternalUnsafeMethods.isClass(identifier);
         }
      
         public static bool isMemberOfClass(string className, string superClassName)
         {
            return InternalUnsafeMethods.isMemberOfClass(className, superClassName);
         }
      
         public static string getDescriptionOfClass(string className)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getDescriptionOfClass(className));
         }
      
         public static string getCategoryOfClass(string className)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getCategoryOfClass(className));
         }
      
         public static string enumerateConsoleClasses(string className = "")
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.enumerateConsoleClasses(className));
         }
      
         public static string enumerateConsoleClassesByCategory(string category)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.enumerateConsoleClassesByCategory(category));
         }
      
         public static void dumpNetStats()
         {
            InternalUnsafeMethods.dumpNetStats();
         }
      
         public static int sizeOf(string objectOrClass)
         {
            return InternalUnsafeMethods.sizeOf(objectOrClass);
         }
      
         public static bool linkNamespaces(string childNSName, string parentNSName)
         {
            return InternalUnsafeMethods.linkNamespaces(childNSName, parentNSName);
         }
      
         public static bool dumpEngineDocs(string outputFile)
         {
            return InternalUnsafeMethods.dumpEngineDocs(outputFile);
         }
      
         public static void debugDumpAllObjects()
         {
            InternalUnsafeMethods.debugDumpAllObjects();
         }
      
         public static SimXMLDocument exportEngineAPIToXML()
         {
            return new SimXMLDocument(InternalUnsafeMethods.exportEngineAPIToXML());
         }
      
         public static string findFirstFile(string pattern = "", bool recurse = true)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.findFirstFile(pattern, recurse));
         }
      
         public static string findNextFile(string pattern = "")
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.findNextFile(pattern));
         }
      
         public static int getFileCount(string pattern = "", bool recurse = true)
         {
            return InternalUnsafeMethods.getFileCount(pattern, recurse);
         }
      
         public static string findFirstFileMultiExpr(string pattern = "", bool recurse = true)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.findFirstFileMultiExpr(pattern, recurse));
         }
      
         public static string findNextFileMultiExpr(string pattern = "")
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.findNextFileMultiExpr(pattern));
         }
      
         public static int getFileCountMultiExpr(string pattern = "", bool recurse = true)
         {
            return InternalUnsafeMethods.getFileCountMultiExpr(pattern, recurse);
         }
      
         public static int getFileCRC(string fileName)
         {
            return InternalUnsafeMethods.getFileCRC(fileName);
         }
      
         public static bool isFile(string fileName)
         {
            return InternalUnsafeMethods.isFile(fileName);
         }
      
         public static bool IsDirectory(string directory)
         {
            return InternalUnsafeMethods.IsDirectory(directory);
         }
      
         public static bool isWriteableFileName(string fileName)
         {
            return InternalUnsafeMethods.isWriteableFileName(fileName);
         }
      
         public static void startFileChangeNotifications()
         {
            InternalUnsafeMethods.startFileChangeNotifications();
         }
      
         public static void stopFileChangeNotifications()
         {
            InternalUnsafeMethods.stopFileChangeNotifications();
         }
      
         public static string getDirectoryList(string path = "", int depth = 0)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getDirectoryList(path, depth));
         }
      
         public static int fileSize(string fileName)
         {
            return InternalUnsafeMethods.fileSize(fileName);
         }
      
         public static string fileModifiedTime(string fileName)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.fileModifiedTime(fileName));
         }
      
         public static string fileCreatedTime(string fileName)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.fileCreatedTime(fileName));
         }
      
         public static bool fileDelete(string path)
         {
            return InternalUnsafeMethods.fileDelete(path);
         }
      
         public static string fileExt(string fileName)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.fileExt(fileName));
         }
      
         public static string fileBase(string fileName)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.fileBase(fileName));
         }
      
         public static string fileName(string fileName)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.fileName(fileName));
         }
      
         public static string filePath(string fileName)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.filePath(fileName));
         }
      
         public static string getWorkingDirectory()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getWorkingDirectory());
         }
      
         public static string makeFullPath(string path = "", string cwd = "")
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.makeFullPath(path, cwd));
         }
      
         public static string makeRelativePath(string path = "", string to = "")
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.makeRelativePath(path, to));
         }
      
         public static string pathConcat(string path = "", string file = "")
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.pathConcat(path, file));
         }
      
         public static string getExecutableName()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getExecutableName());
         }
      
         public static string getMainDotCsDir()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getMainDotCsDir());
         }
      
         public static void openFolder(string path)
         {
            InternalUnsafeMethods.openFolder(path);
         }
      
         public static void openFile(string file)
         {
            InternalUnsafeMethods.openFile(file);
         }
      
         public static bool pathCopy(string fromFile = "", string toFile = "", bool noOverwrite = true)
         {
            return InternalUnsafeMethods.pathCopy(fromFile, toFile, noOverwrite);
         }
      
         public static string getCurrentDirectory()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getCurrentDirectory());
         }
      
         public static bool setCurrentDirectory(string path)
         {
            return InternalUnsafeMethods.setCurrentDirectory(path);
         }
      
         public static bool createPath(string path)
         {
            return InternalUnsafeMethods.createPath(path);
         }
      
         public static string expandFilename(string filename)
         {
            List<string> tmp_arg_list = new List<string> {""};
            tmp_arg_list.Add(filename.ToString());
                  return Marshal.PtrToStringUni(InternalUnsafeMethods.expandFilename(tmp_arg_list.Count, tmp_arg_list.ToArray()));
         }
      
         public static string expandOldFilename(string filename)
         {
            List<string> tmp_arg_list = new List<string> {""};
            tmp_arg_list.Add(filename.ToString());
                  return Marshal.PtrToStringUni(InternalUnsafeMethods.expandOldFilename(tmp_arg_list.Count, tmp_arg_list.ToArray()));
         }
      
         public static string collapseFilename(string filename)
         {
            List<string> tmp_arg_list = new List<string> {""};
            tmp_arg_list.Add(filename.ToString());
                  return Marshal.PtrToStringUni(InternalUnsafeMethods.collapseFilename(tmp_arg_list.Count, tmp_arg_list.ToArray()));
         }
      
         public static void setScriptPathExpando(string expando, string path, bool toolsOnly)
         {
            List<string> tmp_arg_list = new List<string> {""};
            tmp_arg_list.Add(expando.ToString());
                  tmp_arg_list.Add(path.ToString());
                  tmp_arg_list.Add(toolsOnly.ToString());
                  InternalUnsafeMethods.setScriptPathExpando(tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public static void removeScriptPathExpando(string expando)
         {
            List<string> tmp_arg_list = new List<string> {""};
            tmp_arg_list.Add(expando.ToString());
                  InternalUnsafeMethods.removeScriptPathExpando(tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public static bool isScriptPathExpando(string expando)
         {
            List<string> tmp_arg_list = new List<string> {""};
            tmp_arg_list.Add(expando.ToString());
                  return InternalUnsafeMethods.isScriptPathExpando(tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public static int nameToID(string objectName)
         {
            return InternalUnsafeMethods.nameToID(objectName);
         }
      
         public static bool isObject(string objectName)
         {
            return InternalUnsafeMethods.isObject(objectName);
         }
      
         public static int spawnObject(string spawnClass, string spawnDataBlock = "", string spawnName = "", string spawnProperties = "", string spawnScript = "")
         {
            return InternalUnsafeMethods.spawnObject(spawnClass, spawnDataBlock, spawnName, spawnProperties, spawnScript);
         }
      
         public static void cancel(int eventId)
         {
            InternalUnsafeMethods.cancel(eventId);
         }
      
         public static void cancelAll(string objectId)
         {
            InternalUnsafeMethods.cancelAll(objectId);
         }
      
         public static bool isEventPending(int scheduleId)
         {
            return InternalUnsafeMethods.isEventPending(scheduleId);
         }
      
         public static int getEventTimeLeft(int scheduleId)
         {
            return InternalUnsafeMethods.getEventTimeLeft(scheduleId);
         }
      
         public static int getScheduleDuration(int scheduleId)
         {
            return InternalUnsafeMethods.getScheduleDuration(scheduleId);
         }
      
         public static int getTimeSinceStart(int scheduleId)
         {
            return InternalUnsafeMethods.getTimeSinceStart(scheduleId);
         }
      
         public static int schedule(params string[] args)
         {
            List<string> tmp_arg_list = new List<string> {""};
         tmp_arg_list.AddRange(args);
            return InternalUnsafeMethods.schedule(tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public static string getUniqueName(string baseName)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getUniqueName(baseName));
         }
      
         public static string getUniqueInternalName(string baseName, string setString, bool searchChildren)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getUniqueInternalName(baseName, setString, searchChildren));
         }
      
         public static bool isValidObjectName(string name)
         {
            return InternalUnsafeMethods.isValidObjectName(name);
         }
      
         public static void preloadClientDataBlocks()
         {
            InternalUnsafeMethods.preloadClientDataBlocks();
         }
      
         public static void deleteDataBlocks()
         {
            InternalUnsafeMethods.deleteDataBlocks();
         }
      
         public static void debugEnumInstances(string className, string functionName)
         {
            InternalUnsafeMethods.debugEnumInstances(className, functionName);
         }
      
         public static bool saveObject(SimObject _object, string filename)
         {
            return InternalUnsafeMethods.saveObject(_object.ObjectPtr, filename);
         }
      
         public static SimObject loadObject(string filename)
         {
            return new SimObject(InternalUnsafeMethods.loadObject(filename));
         }
      
         public static void telnetSetParameters(int port, string consolePass, string listenPass, bool remoteEcho = false)
         {
            InternalUnsafeMethods.telnetSetParameters(port, consolePass, listenPass, remoteEcho);
         }
      
         public static void dbgSetParameters(int port, string password, bool waitForClient = false)
         {
            InternalUnsafeMethods.dbgSetParameters(port, password, waitForClient);
         }
      
         public static bool dbgIsConnected()
         {
            return InternalUnsafeMethods.dbgIsConnected();
         }
      
         public static void dbgDisconnect()
         {
            InternalUnsafeMethods.dbgDisconnect();
         }
      
         public static int getStockColorCount()
         {
            List<string> tmp_arg_list = new List<string> {""};
            return InternalUnsafeMethods.getStockColorCount(tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public static string getStockColorName()
         {
            List<string> tmp_arg_list = new List<string> {""};
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getStockColorName(tmp_arg_list.Count, tmp_arg_list.ToArray()));
         }
      
         public static bool isStockColor()
         {
            List<string> tmp_arg_list = new List<string> {""};
            return InternalUnsafeMethods.isStockColor(tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public static string getStockColorF()
         {
            List<string> tmp_arg_list = new List<string> {""};
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getStockColorF(tmp_arg_list.Count, tmp_arg_list.ToArray()));
         }
      
         public static string getStockColorI()
         {
            List<string> tmp_arg_list = new List<string> {""};
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getStockColorI(tmp_arg_list.Count, tmp_arg_list.ToArray()));
         }
      
         public static void DNetSetLogging(bool enabled)
         {
            InternalUnsafeMethods.DNetSetLogging(enabled);
         }
      
         public static int getMaxFrameAllocation()
         {
            List<string> tmp_arg_list = new List<string> {""};
            return InternalUnsafeMethods.getMaxFrameAllocation(tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public static void resourceDump()
         {
            List<string> tmp_arg_list = new List<string> {""};
            InternalUnsafeMethods.resourceDump(tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public static void reloadResource(string path)
         {
            InternalUnsafeMethods.reloadResource(path);
         }
      
         public static void sbmDumpStats()
         {
            InternalUnsafeMethods.sbmDumpStats();
         }
      
         public static void sbmDumpStrings()
         {
            InternalUnsafeMethods.sbmDumpStrings();
         }
      
         public static void dumpStringMemStats()
         {
            InternalUnsafeMethods.dumpStringMemStats();
         }
      
         public static int getCoreLangTable()
         {
            return InternalUnsafeMethods.getCoreLangTable();
         }
      
         public static void setCoreLangTable(string lgTable)
         {
            InternalUnsafeMethods.setCoreLangTable(lgTable);
         }
      
         public static void CompileLanguage(string inputFile, bool createMap)
         {
            List<string> tmp_arg_list = new List<string> {""};
            tmp_arg_list.Add(inputFile.ToString());
                  tmp_arg_list.Add(createMap.ToString());
                  InternalUnsafeMethods.CompileLanguage(tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public static ActionMap getCurrentActionMap()
         {
            return new ActionMap(InternalUnsafeMethods.getCurrentActionMap());
         }
      
         public static void allowConnections(bool allow)
         {
            InternalUnsafeMethods.allowConnections(allow);
         }
      
         public static void dumpNetStringTable()
         {
            InternalUnsafeMethods.dumpNetStringTable();
         }
      
         public static void resetFPSTracker()
         {
            InternalUnsafeMethods.resetFPSTracker();
         }
      
         public static void beginSampling(string location, string backend = "CSV")
         {
            InternalUnsafeMethods.beginSampling(location, backend);
         }
      
         public static void stopSampling()
         {
            InternalUnsafeMethods.stopSampling();
         }
      
         public static void enableSamples(string pattern, bool state = true)
         {
            InternalUnsafeMethods.enableSamples(pattern, state);
         }
      
         public static string mSolveQuadratic(float a, float b, float c)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.mSolveQuadratic(a, b, c));
         }
      
         public static string mSolveCubic(float a, float b, float c, float d)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.mSolveCubic(a, b, c, d));
         }
      
         public static string mSolveQuartic(float a, float b, float c, float d, float e)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.mSolveQuartic(a, b, c, d, e));
         }
      
         public static int mFloor(float v)
         {
            return InternalUnsafeMethods.mFloor(v);
         }
      
         public static int mRound(float v)
         {
            return InternalUnsafeMethods.mRound(v);
         }
      
         public static float mRoundColour(float v, int n = 0)
         {
            return InternalUnsafeMethods.mRoundColour(v, n);
         }
      
         public static int mCeil(float v)
         {
            return InternalUnsafeMethods.mCeil(v);
         }
      
         public static string mFloatLength(float v, uint precision)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.mFloatLength(v, precision));
         }
      
         public static float mAbs(float v)
         {
            return InternalUnsafeMethods.mAbs(v);
         }
      
         public static float mFMod(float v, float d)
         {
            return InternalUnsafeMethods.mFMod(v, d);
         }
      
         public static float mSqrt(float v)
         {
            return InternalUnsafeMethods.mSqrt(v);
         }
      
         public static float mPow(float v, float p)
         {
            return InternalUnsafeMethods.mPow(v, p);
         }
      
         public static float mLog(float v)
         {
            return InternalUnsafeMethods.mLog(v);
         }
      
         public static float mSin(float v)
         {
            return InternalUnsafeMethods.mSin(v);
         }
      
         public static float mCos(float v)
         {
            return InternalUnsafeMethods.mCos(v);
         }
      
         public static float mTan(float v)
         {
            return InternalUnsafeMethods.mTan(v);
         }
      
         public static float mAsin(float v)
         {
            return InternalUnsafeMethods.mAsin(v);
         }
      
         public static float mAcos(float v)
         {
            return InternalUnsafeMethods.mAcos(v);
         }
      
         public static float mAtan(float rise, float run)
         {
            return InternalUnsafeMethods.mAtan(rise, run);
         }
      
         public static float mRadToDeg(float radians)
         {
            return InternalUnsafeMethods.mRadToDeg(radians);
         }
      
         public static float mDegToRad(float degrees)
         {
            return InternalUnsafeMethods.mDegToRad(degrees);
         }
      
         public static float mClamp(float v, float min, float max)
         {
            return InternalUnsafeMethods.mClamp(v, min, max);
         }
      
         public static float mSaturate(float v)
         {
            return InternalUnsafeMethods.mSaturate(v);
         }
      
         public static float getMax(float v1, float v2)
         {
            return InternalUnsafeMethods.getMax(v1, v2);
         }
      
         public static float getMin(float v1, float v2)
         {
            return InternalUnsafeMethods.getMin(v1, v2);
         }
      
         public static float mLerp(float v1, float v2, float time)
         {
            return InternalUnsafeMethods.mLerp(v1, v2, time);
         }
      
         public static float mPi()
         {
            return InternalUnsafeMethods.mPi();
         }
      
         public static float m2Pi()
         {
            return InternalUnsafeMethods.m2Pi();
         }
      
         public static bool mIsPow2(int v)
         {
            return InternalUnsafeMethods.mIsPow2(v);
         }
      
         public static VectorF VectorAdd(VectorF a, VectorF b)
         {
            return new VectorF(InternalUnsafeMethods.VectorAdd(a.ToStruct(), b.ToStruct()));
         }
      
         public static VectorF VectorSub(VectorF a, VectorF b)
         {
            return new VectorF(InternalUnsafeMethods.VectorSub(a.ToStruct(), b.ToStruct()));
         }
      
         public static VectorF VectorScale(VectorF a, float scalar)
         {
            return new VectorF(InternalUnsafeMethods.VectorScale(a.ToStruct(), scalar));
         }
      
         public static VectorF VectorMul(VectorF a, VectorF b)
         {
            return new VectorF(InternalUnsafeMethods.VectorMul(a.ToStruct(), b.ToStruct()));
         }
      
         public static VectorF VectorDiv(VectorF a, VectorF b)
         {
            return new VectorF(InternalUnsafeMethods.VectorDiv(a.ToStruct(), b.ToStruct()));
         }
      
         public static VectorF VectorNormalize(VectorF v)
         {
            return new VectorF(InternalUnsafeMethods.VectorNormalize(v.ToStruct()));
         }
      
         public static float VectorDot(VectorF a, VectorF b)
         {
            return InternalUnsafeMethods.VectorDot(a.ToStruct(), b.ToStruct());
         }
      
         public static VectorF VectorCross(VectorF a, VectorF b)
         {
            return new VectorF(InternalUnsafeMethods.VectorCross(a.ToStruct(), b.ToStruct()));
         }
      
         public static float VectorDist(VectorF a, VectorF b)
         {
            return InternalUnsafeMethods.VectorDist(a.ToStruct(), b.ToStruct());
         }
      
         public static VectorF VectorMidPoint(VectorF a, VectorF b)
         {
            return new VectorF(InternalUnsafeMethods.VectorMidPoint(a.ToStruct(), b.ToStruct()));
         }
      
         public static float VectorLen(VectorF v)
         {
            return InternalUnsafeMethods.VectorLen(v.ToStruct());
         }
      
         public static MatrixF VectorOrthoBasis(AngAxisF aa)
         {
            return new MatrixF(InternalUnsafeMethods.VectorOrthoBasis(aa.ToStruct()));
         }
      
         public static string VectorRot(Point3F v, float angle)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.VectorRot(v.ToStruct(), angle));
         }
      
         public static VectorF VectorLerp(VectorF a, VectorF b, float t)
         {
            return new VectorF(InternalUnsafeMethods.VectorLerp(a.ToStruct(), b.ToStruct(), t));
         }
      
         public static TransformF MatrixCreate(VectorF position, AngAxisF orientation)
         {
            return new TransformF(InternalUnsafeMethods.MatrixCreate(position.ToStruct(), orientation.ToStruct()));
         }
      
         public static TransformF MatrixCreateFromEuler(Point3F angles)
         {
            return new TransformF(InternalUnsafeMethods.MatrixCreateFromEuler(angles.ToStruct()));
         }
      
         public static TransformF MatrixMultiply(TransformF left, TransformF right)
         {
            return new TransformF(InternalUnsafeMethods.MatrixMultiply(left.ToStruct(), right.ToStruct()));
         }
      
         public static VectorF MatrixMulVector(TransformF transform, VectorF vector)
         {
            return new VectorF(InternalUnsafeMethods.MatrixMulVector(transform.ToStruct(), vector.ToStruct()));
         }
      
         public static Point3F MatrixMulPoint(TransformF transform, Point3F point)
         {
            return new Point3F(InternalUnsafeMethods.MatrixMulPoint(transform.ToStruct(), point.ToStruct()));
         }
      
         public static Point3F getBoxCenter(Box3F box)
         {
            return new Point3F(InternalUnsafeMethods.getBoxCenter(box.ToStruct()));
         }
      
         public static void setRandomSeed(int seed = -1)
         {
            InternalUnsafeMethods.setRandomSeed(seed);
         }
      
         public static int getRandomSeed()
         {
            return InternalUnsafeMethods.getRandomSeed();
         }
      
         public static float getRandom(int a = 2147483647, int b = 2147483647)
         {
            return InternalUnsafeMethods.getRandom(a, b);
         }
      
         public static void restartInstance()
         {
            List<string> tmp_arg_list = new List<string> {""};
            InternalUnsafeMethods.restartInstance(tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public static void Assert()
         {
            List<string> tmp_arg_list = new List<string> {""};
            InternalUnsafeMethods.Assert(tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public static string getTemporaryDirectory()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getTemporaryDirectory());
         }
      
         public static string getTemporaryFileName()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getTemporaryFileName());
         }
      
         public static string getUserDataDirectory()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getUserDataDirectory());
         }
      
         public static string getUserHomeDirectory()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getUserHomeDirectory());
         }
      
         public static void setMainDotCsDir(string path)
         {
            InternalUnsafeMethods.setMainDotCsDir(path);
         }
      
         public static void validateMemory()
         {
            InternalUnsafeMethods.validateMemory();
         }
      
         public static void freeMemoryDump()
         {
            InternalUnsafeMethods.freeMemoryDump();
         }
      
         public static void flagCurrentAllocs()
         {
            InternalUnsafeMethods.flagCurrentAllocs();
         }
      
         public static void dumpUnflaggedAllocs(string fileName = "")
         {
            InternalUnsafeMethods.dumpUnflaggedAllocs(fileName);
         }
      
         public static void dumpAlloc(int allocNum)
         {
            InternalUnsafeMethods.dumpAlloc(allocNum);
         }
      
         public static void dumpMemSnapshot(string fileName)
         {
            InternalUnsafeMethods.dumpMemSnapshot(fileName);
         }
      
         public static bool redbookOpen(string device = "")
         {
            return InternalUnsafeMethods.redbookOpen(device);
         }
      
         public static bool redbookClose()
         {
            return InternalUnsafeMethods.redbookClose();
         }
      
         public static bool redbookPlay(int track)
         {
            return InternalUnsafeMethods.redbookPlay(track);
         }
      
         public static bool redbookStop()
         {
            return InternalUnsafeMethods.redbookStop();
         }
      
         public static int redbookGetTrackCount()
         {
            return InternalUnsafeMethods.redbookGetTrackCount();
         }
      
         public static float redbookGetVolume()
         {
            return InternalUnsafeMethods.redbookGetVolume();
         }
      
         public static bool redbookSetVolume(float volume)
         {
            return InternalUnsafeMethods.redbookSetVolume(volume);
         }
      
         public static int redbookGetDeviceCount()
         {
            return InternalUnsafeMethods.redbookGetDeviceCount();
         }
      
         public static string redbookGetDeviceName(int index)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.redbookGetDeviceName(index));
         }
      
         public static string redbookGetLastError()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.redbookGetLastError());
         }
      
         public static int startPrecisionTimer()
         {
            return InternalUnsafeMethods.startPrecisionTimer();
         }
      
         public static int stopPrecisionTimer(int id)
         {
            return InternalUnsafeMethods.stopPrecisionTimer(id);
         }
      
         public static void profilerMarkerEnable(string markerName, bool enable = true)
         {
            InternalUnsafeMethods.profilerMarkerEnable(markerName, enable);
         }
      
         public static void profilerEnable(bool enable)
         {
            InternalUnsafeMethods.profilerEnable(enable);
         }
      
         public static void profilerDump()
         {
            InternalUnsafeMethods.profilerDump();
         }
      
         public static void profilerDumpToFile(string fileName)
         {
            InternalUnsafeMethods.profilerDumpToFile(fileName);
         }
      
         public static void profilerReset()
         {
            InternalUnsafeMethods.profilerReset();
         }
      
         public static int messageBox(string title, string message, MBButtons buttons = MBButtons.OkCancel, MBIcons icons = MBIcons.Information)
         {
            return InternalUnsafeMethods.messageBox(title, message, buttons, icons);
         }
      
         public static string TestFunction2Args()
         {
            List<string> tmp_arg_list = new List<string> {""};
            return Marshal.PtrToStringUni(InternalUnsafeMethods.TestFunction2Args(tmp_arg_list.Count, tmp_arg_list.ToArray()));
         }
      
         public static string testJavaScriptBridge(string arg1, string arg2, string arg3)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.testJavaScriptBridge(arg1, arg2, arg3));
         }
      
         public static bool isQueueRegistered(string queueName)
         {
            return InternalUnsafeMethods.isQueueRegistered(queueName);
         }
      
         public static void registerMessageQueue(string queueName)
         {
            InternalUnsafeMethods.registerMessageQueue(queueName);
         }
      
         public static void unregisterMessageQueue(string queueName)
         {
            InternalUnsafeMethods.unregisterMessageQueue(queueName);
         }
      
         public static bool registerMessageListener(string queueName, string listenerName)
         {
            return InternalUnsafeMethods.registerMessageListener(queueName, listenerName);
         }
      
         public static void unregisterMessageListener(string queueName, string listenerName)
         {
            InternalUnsafeMethods.unregisterMessageListener(queueName, listenerName);
         }
      
         public static bool dispatchMessage(string queueName, string message, string data = "")
         {
            return InternalUnsafeMethods.dispatchMessage(queueName, message, data);
         }
      
         public static bool dispatchMessageObject(string queueName = "", string message = "")
         {
            return InternalUnsafeMethods.dispatchMessageObject(queueName, message);
         }
      
         public static int getActiveDDSFiles()
         {
            return InternalUnsafeMethods.getActiveDDSFiles();
         }
      
         public static string getBitmapInfo(string filename)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getBitmapInfo(filename));
         }
      
         public static void startVideoCapture(GuiCanvas canvas, string filename, string encoder = "THEORA", float framerate = 30.0f, Point2I resolution = null)
         {
            if (resolution == null) resolution = Point2I.Zero;
                  InternalUnsafeMethods.startVideoCapture(canvas.ObjectPtr, filename, encoder, framerate, resolution.ToArray());
         }
      
         public static void stopVideoCapture()
         {
            InternalUnsafeMethods.stopVideoCapture();
         }
      
         public static void playJournalToVideo(string journalFile, string videoFile = null, string encoder = "THEORA", float framerate = 30.0f, Point2I resolution = null)
         {
            if (resolution == null) resolution = Point2I.Zero;
                  InternalUnsafeMethods.playJournalToVideo(journalFile, videoFile, encoder, framerate, resolution.ToArray());
         }
      
         public static void populateFontCacheString(string faceName, int fontSize, string _string)
         {
            InternalUnsafeMethods.populateFontCacheString(faceName, fontSize, _string);
         }
      
         public static void populateFontCacheRange(string faceName, int fontSize, uint rangeStart, uint rangeEnd)
         {
            InternalUnsafeMethods.populateFontCacheRange(faceName, fontSize, rangeStart, rangeEnd);
         }
      
         public static void dumpFontCacheStatus()
         {
            InternalUnsafeMethods.dumpFontCacheStatus();
         }
      
         public static void writeFontCache()
         {
            InternalUnsafeMethods.writeFontCache();
         }
      
         public static void populateAllFontCacheString(string _string)
         {
            InternalUnsafeMethods.populateAllFontCacheString(_string);
         }
      
         public static void populateAllFontCacheRange(uint rangeStart, uint rangeEnd)
         {
            InternalUnsafeMethods.populateAllFontCacheRange(rangeStart, rangeEnd);
         }
      
         public static void exportCachedFont(string faceName, int fontSize, string fileName, int padding, int kerning)
         {
            InternalUnsafeMethods.exportCachedFont(faceName, fontSize, fileName, padding, kerning);
         }
      
         public static void importCachedFont(string faceName, int fontSize, string fileName, int padding, int kerning)
         {
            InternalUnsafeMethods.importCachedFont(faceName, fontSize, fileName, padding, kerning);
         }
      
         public static void duplicateCachedFont(string oldFontName, int oldFontSize, string newFontName)
         {
            InternalUnsafeMethods.duplicateCachedFont(oldFontName, oldFontSize, newFontName);
         }
      
         public static string getDisplayDeviceList()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getDisplayDeviceList());
         }
      
         public static void listGFXResources(bool unflaggedOnly = false)
         {
            InternalUnsafeMethods.listGFXResources(unflaggedOnly);
         }
      
         public static void flagCurrentGFXResources()
         {
            InternalUnsafeMethods.flagCurrentGFXResources();
         }
      
         public static void clearGFXResourceFlags()
         {
            InternalUnsafeMethods.clearGFXResourceFlags();
         }
      
         public static void describeGFXResources(string resourceTypes, string filePath, bool unflaggedOnly = false)
         {
            InternalUnsafeMethods.describeGFXResources(resourceTypes, filePath, unflaggedOnly);
         }
      
         public static void describeGFXStateBlocks(string filePath)
         {
            InternalUnsafeMethods.describeGFXStateBlocks(filePath);
         }
      
         public static float getPixelShaderVersion()
         {
            return InternalUnsafeMethods.getPixelShaderVersion();
         }
      
         public static void setPixelShaderVersion(float version)
         {
            InternalUnsafeMethods.setPixelShaderVersion(version);
         }
      
         public static string getDisplayDeviceInformation()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getDisplayDeviceInformation());
         }
      
         public static GFXFormat getBestHDRFormat()
         {
            return InternalUnsafeMethods.getBestHDRFormat();
         }
      
         public static void ResetGFX()
         {
            InternalUnsafeMethods.ResetGFX();
         }
      
         public static Point3F getDesktopResolution()
         {
            return new Point3F(InternalUnsafeMethods.getDesktopResolution());
         }
      
         public static void addGlobalShaderMacro(string name, string value = null)
         {
            InternalUnsafeMethods.addGlobalShaderMacro(name, value);
         }
      
         public static void removeGlobalShaderMacro(string name)
         {
            InternalUnsafeMethods.removeGlobalShaderMacro(name);
         }
      
         public static void flushTextureCache()
         {
            InternalUnsafeMethods.flushTextureCache();
         }
      
         public static void cleanupTexturePool()
         {
            InternalUnsafeMethods.cleanupTexturePool();
         }
      
         public static void reloadTextures()
         {
            InternalUnsafeMethods.reloadTextures();
         }
      
         public static void dumpTextureObjects()
         {
            InternalUnsafeMethods.dumpTextureObjects();
         }
      
         public static string getTextureProfileStats()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getTextureProfileStats());
         }
      
         public static void screenShot(string file, string format, uint tileCount = 1, float tileOverlap = 0)
         {
            InternalUnsafeMethods.screenShot(file, format, tileCount, tileOverlap);
         }
      
         public static string StripMLControlChars(string inString)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.StripMLControlChars(inString));
         }
      
         public static bool excludeOtherInstance(string appIdentifer)
         {
            return InternalUnsafeMethods.excludeOtherInstance(appIdentifer);
         }
      
         public static void reInitMaterials()
         {
            InternalUnsafeMethods.reInitMaterials();
         }
      
         public static void addMaterialMapping(string texName, string matName)
         {
            InternalUnsafeMethods.addMaterialMapping(texName, matName);
         }
      
         public static string getMaterialMapping(string texName)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getMaterialMapping(texName));
         }
      
         public static void dumpMaterialInstances()
         {
            InternalUnsafeMethods.dumpMaterialInstances();
         }
      
         public static string getMapEntry(string texName)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getMapEntry(texName));
         }
      
         public static bool setLightManager(string name)
         {
            return InternalUnsafeMethods.setLightManager(name);
         }
      
         public static bool lightScene(string completeCallbackFn = null, string mode = null)
         {
            return InternalUnsafeMethods.lightScene(completeCallbackFn, mode);
         }
      
         public static string getLightManagerNames()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getLightManagerNames());
         }
      
         public static string getActiveLightManager()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getActiveLightManager());
         }
      
         public static void resetLightManager()
         {
            InternalUnsafeMethods.resetLightManager();
         }
      
         public static bool setShadowManager(string sShadowSystemName = "")
         {
            return InternalUnsafeMethods.setShadowManager(sShadowSystemName);
         }
      
         public static void clearServerPaths()
         {
            InternalUnsafeMethods.clearServerPaths();
         }
      
         public static void clearClientPaths()
         {
            InternalUnsafeMethods.clearClientPaths();
         }
      
         public static void setReflectFormat(GFXFormat format)
         {
            InternalUnsafeMethods.setReflectFormat(format);
         }
      
         public static bool containerBoxEmpty(uint mask, Point3F center, float xRadius, float yRadius = -1, float zRadius = -1, bool useClientContainer = false)
         {
            return InternalUnsafeMethods.containerBoxEmpty(mask, center.ToStruct(), xRadius, yRadius, zRadius, useClientContainer);
         }
      
         public static void initContainerRadiusSearch(Point3F pos, float radius, uint mask, bool useClientContainer = false)
         {
            InternalUnsafeMethods.initContainerRadiusSearch(pos.ToStruct(), radius, mask, useClientContainer);
         }
      
         public static void initContainerTypeSearch(uint mask, bool useClientContainer = false)
         {
            InternalUnsafeMethods.initContainerTypeSearch(mask, useClientContainer);
         }
      
         public static SceneObject containerSearchNext(bool useClientContainer = false)
         {
            return new SceneObject(InternalUnsafeMethods.containerSearchNext(useClientContainer));
         }
      
         public static float containerSearchCurrDist(bool useClientContainer = false)
         {
            return InternalUnsafeMethods.containerSearchCurrDist(useClientContainer);
         }
      
         public static float containerSearchCurrRadiusDist(bool useClientContainer = false)
         {
            return InternalUnsafeMethods.containerSearchCurrRadiusDist(useClientContainer);
         }
      
         public static string containerRayCast(Point3F start, Point3F end, uint mask, SceneObject pExempt = null, bool useClientContainer = false)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.containerRayCast(start.ToStruct(), end.ToStruct(), mask, pExempt == null ? IntPtr.Zero : pExempt.ObjectPtr, useClientContainer));
         }
      
         public static void sceneDumpZoneStates(bool updateFirst = true)
         {
            InternalUnsafeMethods.sceneDumpZoneStates(updateFirst);
         }
      
         public static SceneObject sceneGetZoneOwner(uint zoneId)
         {
            return new SceneObject(InternalUnsafeMethods.sceneGetZoneOwner(zoneId));
         }
      
         public static void pathOnMissionLoadDone()
         {
            InternalUnsafeMethods.pathOnMissionLoadDone();
         }
      
         public static int getTerrainUnderWorldPoint(string ptOrX, string y = "", string z = "")
         {
            return InternalUnsafeMethods.getTerrainUnderWorldPoint(ptOrX, y, z);
         }
      
         public static float getTerrainHeight(string ptOrX, string y = "")
         {
            return InternalUnsafeMethods.getTerrainHeight(ptOrX, y);
         }
      
         public static float getTerrainHeightBelowPosition(string ptOrX, string y = "", string z = "")
         {
            return InternalUnsafeMethods.getTerrainHeightBelowPosition(ptOrX, y, z);
         }
      
         public static int SetFogVolumeQuality(uint new_quality)
         {
            return InternalUnsafeMethods.SetFogVolumeQuality(new_quality);
         }
      
         public static void tsUpdateImposterImages(bool forceUpdate = false)
         {
            InternalUnsafeMethods.tsUpdateImposterImages(forceUpdate);
         }
      
         public static void dumpRandomNormalMap()
         {
            InternalUnsafeMethods.dumpRandomNormalMap();
         }
      
         public static int aiAddPlayer(string name, string ns = "")
         {
            return InternalUnsafeMethods.aiAddPlayer(name, ns);
         }
      
         public static int aiConnect()
         {
            List<string> tmp_arg_list = new List<string> {""};
            return InternalUnsafeMethods.aiConnect(tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public static string containerFindFirst(uint typeMask, Point3F origin, Point3F size)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.containerFindFirst(typeMask, origin.ToStruct(), size.ToStruct()));
         }
      
         public static string containerFindNext()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.containerFindNext());
         }
      
         public static void setDefaultFov(float defaultFOV)
         {
            InternalUnsafeMethods.setDefaultFov(defaultFOV);
         }
      
         public static void setZoomSpeed(int speed)
         {
            InternalUnsafeMethods.setZoomSpeed(speed);
         }
      
         public static void setFov(float FOV)
         {
            InternalUnsafeMethods.setFov(FOV);
         }
      
         public static void snapToggle()
         {
            InternalUnsafeMethods.snapToggle();
         }
      
         public static MissionArea getMissionAreaServerObject()
         {
            return new MissionArea(InternalUnsafeMethods.getMissionAreaServerObject());
         }
      
         public static float calcExplosionCoverage(Point3F pos, int id, uint covMask)
         {
            return InternalUnsafeMethods.calcExplosionCoverage(pos.ToStruct(), id, covMask);
         }
      
         public static void StartFoliageReplication()
         {
            InternalUnsafeMethods.StartFoliageReplication();
         }
      
         public static void StartClientReplication()
         {
            InternalUnsafeMethods.StartClientReplication();
         }
      
         public static bool physicsPluginPresent()
         {
            return InternalUnsafeMethods.physicsPluginPresent();
         }
      
         public static bool physicsInit(string library = "default")
         {
            return InternalUnsafeMethods.physicsInit(library);
         }
      
         public static void physicsDestroy()
         {
            InternalUnsafeMethods.physicsDestroy();
         }
      
         public static bool physicsInitWorld(string worldName)
         {
            return InternalUnsafeMethods.physicsInitWorld(worldName);
         }
      
         public static void physicsDestroyWorld(string worldName)
         {
            InternalUnsafeMethods.physicsDestroyWorld(worldName);
         }
      
         public static void physicsStartSimulation(string worldName)
         {
            InternalUnsafeMethods.physicsStartSimulation(worldName);
         }
      
         public static void physicsStopSimulation(string worldName)
         {
            InternalUnsafeMethods.physicsStopSimulation(worldName);
         }
      
         public static bool physicsSimulationEnabled()
         {
            return InternalUnsafeMethods.physicsSimulationEnabled();
         }
      
         public static void physicsSetTimeScale(float scale)
         {
            InternalUnsafeMethods.physicsSetTimeScale(scale);
         }
      
         public static float physicsGetTimeScale()
         {
            return InternalUnsafeMethods.physicsGetTimeScale();
         }
      
         public static void physicsStoreState()
         {
            InternalUnsafeMethods.physicsStoreState();
         }
      
         public static void physicsRestoreState()
         {
            InternalUnsafeMethods.physicsRestoreState();
         }
      
         public static void physicsDebugDraw(bool enable)
         {
            InternalUnsafeMethods.physicsDebugDraw(enable);
         }
      
         public static void decalManagerSave(string decalSaveFile = "")
         {
            InternalUnsafeMethods.decalManagerSave(decalSaveFile);
         }
      
         public static bool decalManagerLoad(string fileName)
         {
            return InternalUnsafeMethods.decalManagerLoad(fileName);
         }
      
         public static bool decalManagerDirty()
         {
            return InternalUnsafeMethods.decalManagerDirty();
         }
      
         public static void decalManagerClear()
         {
            InternalUnsafeMethods.decalManagerClear();
         }
      
         public static int decalManagerAddDecal(Point3F position, Point3F normal, float rot, float scale, DecalData decalData, bool isImmortal = false)
         {
            return InternalUnsafeMethods.decalManagerAddDecal(position.ToStruct(), normal.ToStruct(), rot, scale, decalData.ObjectPtr, isImmortal);
         }
      
         public static bool decalManagerRemoveDecal(int decalID)
         {
            return InternalUnsafeMethods.decalManagerRemoveDecal(decalID);
         }
      
         public static bool decalManagerEditDecal(int decalID, Point3F pos, Point3F normal, float rotAroundNormal, float decalScale)
         {
            return InternalUnsafeMethods.decalManagerEditDecal(decalID, pos.ToStruct(), normal.ToStruct(), rotAroundNormal, decalScale);
         }
      
         public static void dumpProcessList()
         {
            InternalUnsafeMethods.dumpProcessList();
         }
      
         public static bool TamlWrite(SimObject simObject, string filename, string format = "xml", bool compressed = true)
         {
            return InternalUnsafeMethods.TamlWrite(simObject.ObjectPtr, filename, format, compressed);
         }
      
         public static string TamlRead(string filename, string format = "xml")
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.TamlRead(filename, format));
         }
      
         public static bool GenerateTamlSchema()
         {
            return InternalUnsafeMethods.GenerateTamlSchema();
         }
      
         public static bool enumColladaForImport(string shapePath, string ctrl)
         {
            return InternalUnsafeMethods.enumColladaForImport(shapePath, ctrl);
         }
      
         public static bool loadColladaLights(string filename, string parentGroup = "", string baseObject = "")
         {
            return InternalUnsafeMethods.loadColladaLights(filename, parentGroup, baseObject);
         }
      
         public static string getFormatExtensions()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getFormatExtensions());
         }
      
         public static string getFormatFilters()
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getFormatFilters());
         }
      
         public static string setShadowVizLight(string name = "")
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.setShadowVizLight(name));
         }
      
         public static int getNavMeshEventManager()
         {
            return InternalUnsafeMethods.getNavMeshEventManager();
         }
      
         public static void NavMeshUpdateAll(int objid = 0, bool remove = false)
         {
            InternalUnsafeMethods.NavMeshUpdateAll(objid, remove);
         }
      
         public static void NavMeshUpdateAroundObject(int objid = 0, bool remove = false)
         {
            InternalUnsafeMethods.NavMeshUpdateAroundObject(objid, remove);
         }
      
         public static void NavMeshIgnore(int objid = 0, bool _ignore = true)
         {
            InternalUnsafeMethods.NavMeshIgnore(objid, _ignore);
         }
      
         public static void NavMeshUpdateOne(int meshid = 0, int objid = 0, bool remove = false)
         {
            InternalUnsafeMethods.NavMeshUpdateOne(meshid, objid, remove);
         }
      
         public static int runAllUnitTests(string testSpecs = "")
         {
            return InternalUnsafeMethods.runAllUnitTests(testSpecs);
         }
      
         public static void initDisplayDeviceInfo()
         {
            InternalUnsafeMethods.initDisplayDeviceInfo();
         }
      
         public static void enableWinConsole(bool flag)
         {
            InternalUnsafeMethods.enableWinConsole(flag);
         }
      
         public static bool enableJoystick()
         {
            return InternalUnsafeMethods.enableJoystick();
         }
      
         public static void disableJoystick()
         {
            InternalUnsafeMethods.disableJoystick();
         }
      
         public static bool isJoystickEnabled()
         {
            return InternalUnsafeMethods.isJoystickEnabled();
         }
      
         public static bool enableXInput()
         {
            return InternalUnsafeMethods.enableXInput();
         }
      
         public static void disableXInput()
         {
            InternalUnsafeMethods.disableXInput();
         }
      
         public static void resetXInput()
         {
            InternalUnsafeMethods.resetXInput();
         }
      
         public static bool isXInputConnected(int controllerID)
         {
            return InternalUnsafeMethods.isXInputConnected(controllerID);
         }
      
         public static int getXInputState(int controllerID, string properties, bool current = false)
         {
            return InternalUnsafeMethods.getXInputState(controllerID, properties, current);
         }
      
         public static void echoInputState()
         {
            InternalUnsafeMethods.echoInputState();
         }
      
         public static void rumble(string device, float xRumble, float yRumble)
         {
            InternalUnsafeMethods.rumble(device, xRumble, yRumble);
         }
      
         public static bool shellExecute(string executable, string args = "", string directory = "")
         {
            return InternalUnsafeMethods.shellExecute(executable, args, directory);
         }
      
         public static bool isJoystickDetected()
         {
            return InternalUnsafeMethods.isJoystickDetected();
         }
      
         public static string getJoystickAxes(uint deviceID)
         {
            return Marshal.PtrToStringUni(InternalUnsafeMethods.getJoystickAxes(deviceID));
         }
      
         public static void mathInit()
         {
            List<string> tmp_arg_list = new List<string> {""};
            InternalUnsafeMethods.mathInit(tmp_arg_list.Count, tmp_arg_list.ToArray());
         }
      
         public static bool isKoreanBuild()
         {
            return InternalUnsafeMethods.isKoreanBuild();
         }
      
      
      #endregion

	}
}