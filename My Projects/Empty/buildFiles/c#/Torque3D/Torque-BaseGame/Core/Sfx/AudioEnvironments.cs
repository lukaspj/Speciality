using Torque3D;

namespace Game.Core.Sfx
{
   class AudioEnvironments
   {
      public static SFXEnvironment AudioEnvOff;
      public static SFXEnvironment AudioEnvGeneric;
      public static SFXEnvironment AudioEnvRoom;
      public static SFXEnvironment AudioEnvPaddedCell;
      public static SFXEnvironment AudioEnvBathroom;
      public static SFXEnvironment AudioEnvLivingRoom;
      public static SFXEnvironment AudioEnvStoneRoom;
      public static SFXEnvironment AudioEnvAuditorium;
      public static SFXEnvironment AudioEnvConcertHall;
      public static SFXEnvironment AudioEnvCave;
      public static SFXEnvironment AudioEnvArena;
      public static SFXEnvironment AudioEnvHangar;
      public static SFXEnvironment AudioEnvCarpettedHallway;
      public static SFXEnvironment AudioEnvHallway;
      public static SFXEnvironment AudioEnvStoneCorridor;
      public static SFXEnvironment AudioEnvAlley;
      public static SFXEnvironment AudioEnvForest;
      public static SFXEnvironment AudioEnvCity;
      public static SFXEnvironment AudioEnvMountains;
      public static SFXEnvironment AudioEnvQuary;
      public static SFXEnvironment AudioEnvPlain;
      public static SFXEnvironment AudioEnvParkingLot;
      public static SFXEnvironment AudioEnvSewerPipe;
      public static SFXEnvironment AudioEnvUnderwater;
      public static SFXEnvironment AudioEnvDrugged;
      public static SFXEnvironment AudioEnvDizzy;
      public static SFXEnvironment AudioEnvPsychotic;

      public static void Init()
      {
         // Reverb environment presets.
         //
         // For customized presets, best derive from one of these presets.
         AudioEnvOff = new SFXEnvironment("AudioEnvOff")
         {
            EnvSize = 7.5f,
            EnvDiffusion = 1.0f,
            Room = -10000,
            RoomHF = -10000,
            RoomLF = 0,
            DecayTime = 1.0f,
            DecayHFRatio = 1.0f,
            DecayLFRatio = 1.0f,
            Reflections = -2602,
            ReflectionsDelay = 0.007f,
            ReflectionsPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            Reverb = 200,
            ReverbDelay = 0.011f,
            ReverbPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            EchoTime = 0.25f,
            EchoDepth = 0.0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0.0f,
            AirAbsorptionHF = -5.0f,
            HFReference = 5000.0f,
            LFReference = 250.0f,
            RoomRolloffFactor = 0.0f,
            Diffusion = 0.0f,
            Density = 0.0f,
            Flags = 0x33,
         };
         AudioEnvOff.registerSingleton();

         AudioEnvGeneric = new SFXEnvironment("AudioEnvGeneric")
         {
            EnvSize = 7.5f,
            EnvDiffusion = 1.0f,
            Room = -1000,
            RoomHF = -100,
            RoomLF = 0,
            DecayTime = 1.49f,
            DecayHFRatio = 0.83f,
            DecayLFRatio = 1.0f,
            Reflections = -2602,
            ReflectionsDelay = 0.007f,
            ReflectionsPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            Reverb = 200,
            ReverbDelay = 0.011f,
            ReverbPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            EchoTime = 0.25f,
            EchoDepth = 0.0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0.0f,
            AirAbsorptionHF = -5.0f,
            HFReference = 5000.0f,
            LFReference = 250.0f,
            RoomRolloffFactor = 0.0f,
            Diffusion = 100.0f,
            Density = 100.0f,
            Flags = 0x3f
         };
         AudioEnvGeneric.registerSingleton();

         AudioEnvRoom = new SFXEnvironment("AudioEnvRoom")
         {
            EnvSize = 1.9f,
            EnvDiffusion = 1.0f,
            Room = -1000,
            RoomHF = -454,
            RoomLF = 0,
            DecayTime = 0.4f,
            DecayHFRatio = 0.83f,
            DecayLFRatio = 1.0f,
            Reflections = -1646,
            ReflectionsDelay = 0.002f,
            ReflectionsPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            Reverb = 53,
            ReverbDelay = 0.003f,
            ReverbPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            EchoTime = 0.25f,
            EchoDepth = 0.0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0.0f,
            AirAbsorptionHF = -5.0f,
            HFReference = 5000.0f,
            LFReference = 250.0f,
            RoomRolloffFactor = 0.0f,
            Diffusion = 100.0f,
            Density = 100.0f,
            Flags = 0x3f
         };
         AudioEnvRoom.registerSingleton();

         AudioEnvPaddedCell = new SFXEnvironment("AudioEnvPaddedCell")
         {
            EnvSize = 1.4f,
            EnvDiffusion = 1.0f,
            Room = -1000,
            RoomHF = -6000,
            RoomLF = 0,
            DecayTime = 0.17f,
            DecayHFRatio = 0.1f,
            DecayLFRatio = 1.0f,
            Reflections = -1204,
            ReflectionsDelay = 0.001f,
            ReflectionsPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            Reverb = 207,
            ReverbDelay = 0.002f,
            ReverbPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            EchoTime = 0.25f,
            EchoDepth = 0.0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0.0f,
            AirAbsorptionHF = -5.0f,
            HFReference = 5000.0f,
            LFReference = 250.0f,
            RoomRolloffFactor = 0.0f,
            Diffusion = 100.0f,
            Density = 100.0f,
            Flags = 0x3f
         };
         AudioEnvPaddedCell.registerSingleton();

         AudioEnvBathroom = new SFXEnvironment("AudioEnvBathroom")
         {
            EnvSize = 1.4f,
            EnvDiffusion = 1.0f,
            Room = -1000,
            RoomHF = -1200,
            RoomLF = 0,
            DecayTime = 1.49f,
            DecayHFRatio = 0.54f,
            DecayLFRatio = 1.0f,
            Reflections = -370,
            ReflectionsDelay = 0.007f,
            ReflectionsPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            Reverb = 1030,
            ReverbDelay = 0.011f,
            ReverbPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            EchoTime = 0.25f,
            EchoDepth = 0.0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0.0f,
            AirAbsorptionHF = -5.0f,
            HFReference = 5000.0f,
            LFReference = 250.0f,
            RoomRolloffFactor = 0.0f,
            Diffusion = 100.0f,
            Density = 60.0f,
            Flags = 0x3f
         };
         AudioEnvBathroom.registerSingleton();

         AudioEnvLivingRoom = new SFXEnvironment("AudioEnvLivingRoom")
         {
            EnvSize = 2.5f,
            EnvDiffusion = 1.0f,
            Room = -1000,
            RoomHF = -6000,
            RoomLF = 0,
            DecayTime = 0.5f,
            DecayHFRatio = 0.1f,
            DecayLFRatio = 1.0f,
            Reflections = -1376,
            ReflectionsDelay = 0.003f,
            ReflectionsPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            Reverb = 1140,
            ReverbDelay = 0.004f,
            ReverbPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            EchoTime = 0.25f,
            EchoDepth = 0.0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0.0f,
            AirAbsorptionHF = -5.0f,
            HFReference = 5000.0f,
            LFReference = 250.0f,
            RoomRolloffFactor = 0.0f,
            Diffusion = 100.0f,
            Density = 100.0f,
            Flags = 0x3f
         };
         AudioEnvLivingRoom.registerSingleton();

         AudioEnvStoneRoom = new SFXEnvironment("AudioEnvStoneRoom")
         {
            EnvSize = 11.6f,
            EnvDiffusion = 1.0f,
            Room = -1000,
            RoomHF = 300,
            RoomLF = 0,
            DecayTime = 2.31f,
            DecayHFRatio = 0.64f,
            DecayLFRatio = 1.0f,
            Reflections = -711,
            ReflectionsDelay = 0.012f,
            ReflectionsPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            Reverb = 83,
            ReverbDelay = 0.017f,
            ReverbPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            EchoTime = 0.25f,
            EchoDepth = 0.0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0.0f,
            AirAbsorptionHF = -5.0f,
            HFReference = 5000.0f,
            LFReference = 250.0f,
            RoomRolloffFactor = 0.0f,
            Diffusion = 100.0f,
            Density = 100.0f,
            Flags = 0x3f
         };
         AudioEnvStoneRoom.registerSingleton();

         AudioEnvAuditorium = new SFXEnvironment("AudioEnvAuditorium")
         {
            EnvSize = 21.6f,
            EnvDiffusion = 1.0f,
            Room = -1000,
            RoomHF = -476,
            RoomLF = 0,
            DecayTime = 4.32f,
            DecayHFRatio = 0.59f,
            DecayLFRatio = 1.0f,
            Reflections = 1, //todo Reflections = 0.789f,
            ReflectionsDelay = 0.01f,
            ReflectionsPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            Reverb = -289,
            ReverbDelay = 0.03f,
            ReverbPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            EchoTime = 0.25f,
            EchoDepth = 0.0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0.0f,
            AirAbsorptionHF = -5.0f,
            HFReference = 5000.0f,
            LFReference = 250.0f,
            RoomRolloffFactor = 0.0f,
            Diffusion = 100.0f,
            Density = 100.0f,
            Flags = 0x3f
         };
         AudioEnvAuditorium.registerSingleton();

         AudioEnvConcertHall = new SFXEnvironment("AudioEnvConcertHall")
         {
            EnvSize = 19.6f,
            EnvDiffusion = 1.0f,
            Room = -1000,
            RoomHF = -500,
            RoomLF = 0,
            DecayTime = 3.92f,
            DecayHFRatio = 0.7f,
            DecayLFRatio = 1.0f,
            Reflections = -1230,
            ReflectionsDelay = 0.02f,
            ReflectionsPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            Reverb = -2,
            ReverbDelay = 0.029f,
            ReverbPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            EchoTime = 0.25f,
            EchoDepth = 0.0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0.0f,
            AirAbsorptionHF = -5.0f,
            HFReference = 5000.0f,
            LFReference = 250.0f,
            RoomRolloffFactor = 0.0f,
            Diffusion = 100.0f,
            Density = 100.0f,
            Flags = 0x3f
         };
         AudioEnvConcertHall.registerSingleton();

         AudioEnvCave = new SFXEnvironment("AudioEnvCave")
         {
            EnvSize = 14.6f,
            EnvDiffusion = 1.0f,
            Room = -1000,
            RoomHF = 0,
            RoomLF = 0,
            DecayTime = 2.91f,
            DecayHFRatio = 1.3f,
            DecayLFRatio = 1.0f,
            Reflections = -602,
            ReflectionsDelay = 0.015f,
            ReflectionsPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            Reverb = -302,
            ReverbDelay = 0.022f,
            ReverbPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            EchoTime = 0.25f,
            EchoDepth = 0.0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0.0f,
            AirAbsorptionHF = -5.0f,
            HFReference = 5000.0f,
            LFReference = 250.0f,
            RoomRolloffFactor = 0.0f,
            Diffusion = 100.0f,
            Density = 100.0f,
            Flags = 0x1f
         };
         AudioEnvCave.registerSingleton();

         AudioEnvArena = new SFXEnvironment("AudioEnvArena")
         {
            EnvSize = 36.2f,
            EnvDiffusion = 1.0f,
            Room = -1000,
            RoomHF = -698,
            RoomLF = 0,
            DecayTime = 7.24f,
            DecayHFRatio = 0.33f,
            DecayLFRatio = 1.0f,
            Reflections = -1166,
            ReflectionsDelay = 0.02f,
            ReflectionsPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            Reverb = 16,
            ReverbDelay = 0.03f,
            ReverbPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            EchoTime = 0.25f,
            EchoDepth = 0.0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0.0f,
            AirAbsorptionHF = -5.0f,
            HFReference = 5000.0f,
            LFReference = 250.0f,
            RoomRolloffFactor = 0.0f,
            Diffusion = 100.0f,
            Density = 100.0f,
            Flags = 0x3f
         };
         AudioEnvArena.registerSingleton();

         AudioEnvHangar = new SFXEnvironment("AudioEnvHangar")
         {
            EnvSize = 50.3f,
            EnvDiffusion = 1.0f,
            Room = -1000,
            RoomHF = -1000,
            RoomLF = 0,
            DecayTime = 10.05f,
            DecayHFRatio = 0.23f,
            DecayLFRatio = 1.0f,
            Reflections = -602,
            ReflectionsDelay = 0.02f,
            ReflectionsPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            Reverb = 198,
            ReverbDelay = 0.03f,
            ReverbPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            EchoTime = 0.25f,
            EchoDepth = 0.0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0.0f,
            AirAbsorptionHF = -5.0f,
            HFReference = 5000.0f,
            LFReference = 250.0f,
            RoomRolloffFactor = 0.0f,
            Diffusion = 100.0f,
            Density = 100.0f,
            Flags = 0x3f
         };
         AudioEnvHangar.registerSingleton();

         AudioEnvCarpettedHallway = new SFXEnvironment("AudioEnvCarpettedHallway")
         {
            EnvSize = 1.9f,
            EnvDiffusion = 1.0f,
            Room = -1000,
            RoomHF = -4000,
            RoomLF = 0,
            DecayTime = 0.3f,
            DecayHFRatio = 0.1f,
            DecayLFRatio = 1.0f,
            Reflections = -1831,
            ReflectionsDelay = 0.002f,
            ReflectionsPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            Reverb = -1630,
            ReverbDelay = 0.03f,
            ReverbPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            EchoTime = 0.25f,
            EchoDepth = 0.0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0.0f,
            AirAbsorptionHF = -5.0f,
            HFReference = 5000.0f,
            LFReference = 250.0f,
            RoomRolloffFactor = 0.0f,
            Diffusion = 100.0f,
            Density = 100.0f,
            Flags = 0x3f
         };
         AudioEnvCarpettedHallway.registerSingleton();

         AudioEnvHallway = new SFXEnvironment("AudioEnvHallway")
         {
            EnvSize = 1.8f,
            EnvDiffusion = 1.0f,
            Room = -1000,
            RoomHF = -300,
            RoomLF = 0,
            DecayTime = 1.49f,
            DecayHFRatio = 0.59f,
            DecayLFRatio = 1.0f,
            Reflections = -1219,
            ReflectionsDelay = 0.007f,
            ReflectionsPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            Reverb = 441,
            ReverbDelay = 0.011f,
            ReverbPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            EchoTime = 0.25f,
            EchoDepth = 0.0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0.0f,
            AirAbsorptionHF = -5.0f,
            HFReference = 5000.0f,
            LFReference = 250.0f,
            RoomRolloffFactor = 0.0f,
            Diffusion = 100.0f,
            Density = 100.0f,
            Flags = 0x3f
         };
         AudioEnvHallway.registerSingleton();

         AudioEnvStoneCorridor = new SFXEnvironment("AudioEnvStoneCorridor")
         {
            EnvSize = 13.5f,
            EnvDiffusion = 1.0f,
            Room = -1000,
            RoomHF = -237,
            RoomLF = 0,
            DecayTime = 2.7f,
            DecayHFRatio = 0.79f,
            DecayLFRatio = 1.0f,
            Reflections = -1214,
            ReflectionsDelay = 0.013f,
            ReflectionsPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            Reverb = 395,
            ReverbDelay = 0.02f,
            ReverbPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            EchoTime = 0.25f,
            EchoDepth = 0.0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0.0f,
            AirAbsorptionHF = -5.0f,
            HFReference = 5000.0f,
            LFReference = 250.0f,
            RoomRolloffFactor = 0.0f,
            Diffusion = 100.0f,
            Density = 100.0f,
            Flags = 0x3f
         };
         AudioEnvStoneCorridor.registerSingleton();

         AudioEnvAlley = new SFXEnvironment("AudioEnvAlley")
         {
            EnvSize = 7.5f,
            EnvDiffusion = 0.3f,
            Room = -1000,
            RoomHF = -270,
            RoomLF = 0,
            DecayTime = 1.49f,
            DecayHFRatio = 0.86f,
            DecayLFRatio = 1.0f,
            Reflections = -1204,
            ReflectionsDelay = 0.007f,
            ReflectionsPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            Reverb = -4,
            ReverbDelay = 0.011f,
            ReverbPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            EchoTime = 0.125f,
            EchoDepth = 0.95f,
            ModulationTime = 0.25f,
            ModulationDepth = 0.0f,
            AirAbsorptionHF = -5.0f,
            HFReference = 5000.0f,
            LFReference = 250.0f,
            RoomRolloffFactor = 0.0f,
            Diffusion = 100.0f,
            Density = 100.0f,
            Flags = 0x3f
         };
         AudioEnvAlley.registerSingleton();

         AudioEnvForest = new SFXEnvironment("AudioEnvForest")
         {
            EnvSize = 38.0f,
            EnvDiffusion = 0.3f,
            Room = -1000,
            RoomHF = -3300,
            RoomLF = 0,
            DecayTime = 1.49f,
            DecayHFRatio = 0.54f,
            DecayLFRatio = 1.0f,
            Reflections = -2560,
            ReflectionsDelay = 0.162f,
            ReflectionsPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            Reverb = -229,
            ReverbDelay = 0.088f,
            ReverbPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            EchoTime = 0.125f,
            EchoDepth = 1.0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0.0f,
            AirAbsorptionHF = -5.0f,
            HFReference = 5000.0f,
            LFReference = 250.0f,
            RoomRolloffFactor = 0.0f,
            Diffusion = 79.0f,
            Density = 100.0f,
            Flags = 0x3f
         };
         AudioEnvForest.registerSingleton();

         AudioEnvCity = new SFXEnvironment("AudioEnvCity")
         {
            EnvSize = 7.5f,
            EnvDiffusion = 0.5f,
            Room = -1000,
            RoomHF = -800,
            RoomLF = 0,
            DecayTime = 1.49f,
            DecayHFRatio = 0.67f,
            DecayLFRatio = 1.0f,
            Reflections = -2273,
            ReflectionsDelay = 0.007f,
            ReflectionsPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            Reverb = -1691,
            ReverbDelay = 0.011f,
            ReverbPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            EchoTime = 0.25f,
            EchoDepth = 0.0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0.0f,
            AirAbsorptionHF = -5.0f,
            HFReference = 5000.0f,
            LFReference = 250.0f,
            RoomRolloffFactor = 0.0f,
            Diffusion = 50.0f,
            Density = 100.0f,
            Flags = 0x3f
         };
         AudioEnvCity.registerSingleton();

         AudioEnvMountains = new SFXEnvironment("AudioEnvMountains")
         {
            EnvSize = 100.0f,
            EnvDiffusion = 0.27f,
            Room = -1000,
            RoomHF = -2500,
            RoomLF = 0,
            DecayTime = 1.49f,
            DecayHFRatio = 0.21f,
            DecayLFRatio = 1.0f,
            Reflections = -2780,
            ReflectionsDelay = 0.3f,
            ReflectionsPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            Reverb = -1434,
            ReverbDelay = 0.1f,
            ReverbPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            EchoTime = 0.25f,
            EchoDepth = 1.0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0.0f,
            AirAbsorptionHF = -5.0f,
            HFReference = 5000.0f,
            LFReference = 250.0f,
            RoomRolloffFactor = 0.0f,
            Diffusion = 27.0f,
            Density = 100.0f,
            Flags = 0x1f
         };
         AudioEnvMountains.registerSingleton();

         AudioEnvQuary = new SFXEnvironment("AudioEnvQuary")
         {
            EnvSize = 17.5f,
            EnvDiffusion = 1.0f,
            Room = -1000,
            RoomHF = -1000,
            RoomLF = 0,
            DecayTime = 1.49f,
            DecayHFRatio = 0.83f,
            DecayLFRatio = 1.0f,
            Reflections = -10000,
            ReflectionsDelay = 0.061f,
            ReflectionsPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            Reverb = 500,
            ReverbDelay = 0.025f,
            ReverbPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            EchoTime = 0.125f,
            EchoDepth = 0.7f,
            ModulationTime = 0.25f,
            ModulationDepth = 0.0f,
            AirAbsorptionHF = -5.0f,
            HFReference = 5000.0f,
            LFReference = 250.0f,
            RoomRolloffFactor = 0.0f,
            Diffusion = 100.0f,
            Density = 100.0f,
            Flags = 0x3f
         };
         AudioEnvQuary.registerSingleton();

         AudioEnvPlain = new SFXEnvironment("AudioEnvPlain")
         {
            EnvSize = 42.5f,
            EnvDiffusion = 0.21f,
            Room = -1000,
            RoomHF = -2000,
            RoomLF = 0,
            DecayTime = 1.49f,
            DecayHFRatio = 0.5f,
            DecayLFRatio = 1.0f,
            Reflections = -2466,
            ReflectionsDelay = 0.179f,
            ReflectionsPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            Reverb = -1926,
            ReverbDelay = 0.1f,
            ReverbPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            EchoTime = 0.25f,
            EchoDepth = 1.0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0.0f,
            AirAbsorptionHF = -5.0f,
            HFReference = 5000.0f,
            LFReference = 250.0f,
            RoomRolloffFactor = 0.0f,
            Diffusion = 21.0f,
            Density = 100.0f,
            Flags = 0x3f
         };
         AudioEnvPlain.registerSingleton();

         AudioEnvParkingLot = new SFXEnvironment("AudioEnvParkingLot")
         {
            EnvSize = 8.3f,
            EnvDiffusion = 1.0f,
            Room = -1000,
            RoomHF = 0,
            RoomLF = 0,
            DecayTime = 1.65f,
            DecayHFRatio = 1.5f,
            DecayLFRatio = 1.0f,
            Reflections = -1363,
            ReflectionsDelay = 0.008f,
            ReflectionsPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            Reverb = -1153,
            ReverbDelay = 0.012f,
            ReverbPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            EchoTime = 0.25f,
            EchoDepth = 0.0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0.0f,
            AirAbsorptionHF = -5.0f,
            HFReference = 5000.0f,
            LFReference = 250.0f,
            RoomRolloffFactor = 0.0f,
            Diffusion = 100.0f,
            Density = 100.0f,
            Flags = 0x1f
         };
         AudioEnvParkingLot.registerSingleton();

         AudioEnvSewerPipe = new SFXEnvironment("AudioEnvSewerPipe")
         {
            EnvSize = 1.7f,
            EnvDiffusion = 0.8f,
            Room = -1000,
            RoomHF = -1000,
            RoomLF = 0,
            DecayTime = 2.81f,
            DecayHFRatio = 0.14f,
            DecayLFRatio = 1.0f,
            Reflections = 429,
            ReflectionsDelay = 0.014f,
            ReflectionsPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            Reverb = 1023,
            ReverbDelay = 0.21f,
            ReverbPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            EchoTime = 0.25f,
            EchoDepth = 0.0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0.0f,
            AirAbsorptionHF = -5.0f,
            HFReference = 5000.0f,
            LFReference = 250.0f,
            RoomRolloffFactor = 0.0f,
            Diffusion = 80.0f,
            Density = 60.0f,
            Flags = 0x3f
         };
         AudioEnvSewerPipe.registerSingleton();

         AudioEnvUnderwater = new SFXEnvironment("AudioEnvUnderwater")
         {
            EnvSize = 1.8f,
            EnvDiffusion = 1.0f,
            Room = -1000,
            RoomHF = -4000,
            RoomLF = 0,
            DecayTime = 1.49f,
            DecayHFRatio = 0.1f,
            DecayLFRatio = 1.0f,
            Reflections = -449,
            ReflectionsDelay = 0.007f,
            ReflectionsPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            Reverb = 1700,
            ReverbDelay = 0.011f,
            ReverbPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            EchoTime = 0.25f,
            EchoDepth = 0.0f,
            ModulationTime = 1.18f,
            ModulationDepth = 0.348f,
            AirAbsorptionHF = -5.0f,
            HFReference = 5000.0f,
            LFReference = 250.0f,
            RoomRolloffFactor = 0.0f,
            Diffusion = 100.0f,
            Density = 100.0f,
            Flags = 0x3f
         };
         AudioEnvUnderwater.registerSingleton();

         AudioEnvDrugged = new SFXEnvironment("AudioEnvDrugged")
         {
            EnvSize = 1.9f,
            EnvDiffusion = 0.5f,
            Room = -1000,
            RoomHF = 0,
            RoomLF = 0,
            DecayTime = 8.39f,
            DecayHFRatio = 1.39f,
            DecayLFRatio = 1.0f,
            Reflections = -115,
            ReflectionsDelay = 0.002f,
            ReflectionsPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            Reverb = 985,
            ReverbDelay = 0.03f,
            ReverbPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            EchoTime = 0.25f,
            EchoDepth = 0.0f,
            ModulationTime = 0.25f,
            ModulationDepth = 0.0f,
            AirAbsorptionHF = -5.0f,
            HFReference = 5000.0f,
            LFReference = 250.0f,
            RoomRolloffFactor = 0.0f,
            Diffusion = 100.0f,
            Density = 100.0f,
            Flags = 0x1f
         };
         AudioEnvDrugged.registerSingleton();

         AudioEnvDizzy = new SFXEnvironment("AudioEnvDizzy")
         {
            EnvSize = 1.8f,
            EnvDiffusion = 0.6f,
            Room = -1000,
            RoomHF = -400,
            RoomLF = 0,
            DecayTime = 17.23f,
            DecayHFRatio = 0.56f,
            DecayLFRatio = 1.0f,
            Reflections = -1713,
            ReflectionsDelay = 0.02f,
            ReflectionsPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            Reverb = -613,
            ReverbDelay = 0.03f,
            ReverbPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            EchoTime = 0.25f,
            EchoDepth = 1.0f,
            ModulationTime = 0.81f,
            ModulationDepth = 0.31f,
            AirAbsorptionHF = -5.0f,
            HFReference = 5000.0f,
            LFReference = 250.0f,
            RoomRolloffFactor = 0.0f,
            Diffusion = 100.0f,
            Density = 100.0f,
            Flags = 0x1f
         };
         AudioEnvDizzy.registerSingleton();

         AudioEnvPsychotic = new SFXEnvironment("AudioEnvPsychotic")
         {
            EnvSize = 1.0f,
            EnvDiffusion = 0.5f,
            Room = -1000,
            RoomHF = -151,
            RoomLF = 0,
            DecayTime = 7.56f,
            DecayHFRatio = 0.91f,
            DecayLFRatio = 1.0f,
            Reflections = -626,
            ReflectionsDelay = 0.02f,
            ReflectionsPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            Reverb = 774,
            ReverbDelay = 0.03f,
            ReverbPan =
            {
               [0] = 0,
               [1] = 0,
               [2] = 0
            },
            EchoTime = 0.25f,
            EchoDepth = 0.0f,
            ModulationTime = 4.0f,
            ModulationDepth = 1.0f,
            AirAbsorptionHF = -5.0f,
            HFReference = 5000.0f,
            LFReference = 250.0f,
            RoomRolloffFactor = 0.0f,
            Diffusion = 100.0f,
            Density = 100.0f,
            Flags = 0x1f
         };
         AudioEnvPsychotic.registerSingleton();
      }
   }
}
