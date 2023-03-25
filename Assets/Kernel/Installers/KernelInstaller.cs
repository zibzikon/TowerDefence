using System.Collections.Generic;
using System.Linq;
using Foundation.Services;
using Foundation.Services.Interfaces;
using Kernel.Systems.Registration;
using Sirenix.OdinInspector;
using UnityEngine;
using Zenject;

namespace Kernel.Installers
{
    public class KernelInstaller : MonoInstaller
    {
        [Required, SerializeField] private Engine _engine;
        [Required, SerializeField] private List<string> _towerViewsPrefabsResourcesNames;
        
        public override void InstallBindings()
        {
            var contexts = Contexts.sharedInstance;

            Container.BindInstance(contexts);
            Container.BindInstance(contexts.game);
            Container.BindInstance(contexts.input);
            Container.BindInstance(_engine);
            
            Container.Bind<GameSystems>().ToSelf().AsSingle();
            
            Container.Bind<ITowersViewsProvider>().To<TowersViewsProvider>().AsSingle().WithArguments(
                _towerViewsPrefabsResourcesNames.ToDictionary(x => _towerViewsPrefabsResourcesNames.IndexOf(x)));
        }
    }
}