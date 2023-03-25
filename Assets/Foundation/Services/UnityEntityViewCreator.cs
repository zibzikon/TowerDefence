using Foundation.Factories;
using Foundation.Services.Interfaces;
using Kernel.ECSIntegration;
using Unity.VisualScripting;

namespace Foundation.Services
{
    public class UnityEntityViewCreator : IUnityEntityViewCreator
    {
        private readonly IUnityViewService _viewService;
        private readonly IResourcesLoader _resourcesLoader;

        public UnityEntityViewCreator(IUnityViewService viewService, IResourcesLoader resourcesLoader)
        {
            _viewService = viewService;
            _resourcesLoader = resourcesLoader;
        }

        public EntityView CreateFromPrefab(EntityView prefab) => _viewService.CreateViewFromPrefab(prefab);

        public EntityView CreateFromResourceName(string name) =>
            CreateFromPrefab(_resourcesLoader.Load<EntityView>(name));

        public EntityView CreateEmpty() => _viewService.CreateEmpty().AddComponent<EntityView>();

    }
}