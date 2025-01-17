﻿using Client.Console;
using GameConsole;
using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Video;
using Object = UnityEngine.Object;

namespace Client
{
    internal class MelonModMain : MelonMod
    {
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            try
            {
                MonoSingleton<GameConsole.Console>.Instance.RegisterCommands(new ICommand[1]
                {
                    new Connect()
                });
            }
            catch (Exception e)
            {
                // lazy but works 
            }
        }
    }
}
