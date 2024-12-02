using BepInEx;
using GorillaNetworking;
using HarmonyLib;
using System;
using System.Threading;
using UnityEngine;

namespace fpc
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        bool inRoom;

        void Start()
        {
            /* A lot of Gorilla Tag systems will not be set up when start is called /*
			/* Put code in OnGameInitialized to avoid null references */
        }

        void OnEnable()
        {
            GameObject.Find("Player Objects/Third Person Camera").SetActive(false);
        }

        void OnDisable()
        {
            GameObject.Find("Player Objects/Third Person Camera").SetActive(false);
        }

        void OnGameInitialized()
        {
 
        }

        void Update()
        {


        }
    }
}
