using Foundation.Services;
using Foundation.Services.Interfaces;
using Zenject;

namespace Kernel.Installers
{
    public class ServicesInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IComponentsIndexesProvider>().To<ComponentsIndexesProvider>().AsSingle();
            Container.Bind<IInput>().To<UnityInput>().AsSingle();
            Container.Bind<IResourcesLoader>().To<UnityResourcesBasedResourceLoader>().AsSingle();
            Container.Bind<IUnityEntityViewCreator>().To<UnityEntityViewCreator>().AsSingle();
            Container.Bind<IUnityViewService>().To<UnityViewService>().AsSingle();
            Container.Bind<IComponentBuilder>().To<EntitasComponentBuilder>().AsSingle();
        }
    }
}