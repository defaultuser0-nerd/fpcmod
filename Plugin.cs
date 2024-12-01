using BepInEx;
using System;
using UnityEngine;

namespace fpc
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        void Start()
        {
            HarmonyPatches.ApplyHarmonyPatches();
            GorillaTagger.OnPlayerSpawned(Initialized);
        }

        void Initialized()
        {
            GameObject.Find("Player Objects/Third Person Camera").SetActive(false);
        }
    }
}