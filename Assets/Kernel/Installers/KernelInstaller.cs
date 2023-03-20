using Kernel.Systems.Registration;
using Sirenix.OdinInspector;
using UnityEngine;
using Zenject;

namespace Kernel
{
    public class KernelInstaller : MonoInstaller
    {
        [Required, SerializeField] private Engine _engine;
        
        public override void InstallBindings()
        {
            var contexts = Contexts.sharedInstance;

            Container.BindInstance(contexts);
            Container.BindInstance(contexts.game);
            Container.BindInstance(contexts.input);
            
            Container.Bind<GameSystems>().AsSingle();
            Container.BindInstance(_engine);
        }
    }
}