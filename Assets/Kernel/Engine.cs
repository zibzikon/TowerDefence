using System;
using Kernel.Systems.Registration;
using UnityEngine;
using Zenject;

namespace Kernel
{
    public class Engine : MonoBehaviour
    {
        private GameSystems _systems;

        [Inject]
        private void Construct(GameSystems systems)
        {
            _systems = systems;
        }

        private void Start()
        {
            _systems.Initialize();
        }

        private void Update()
        {
            _systems.Execute();
            _systems.Cleanup();
        }

        private void OnApplicationQuit()
        {
            _systems.TearDown();
        }
    }
}