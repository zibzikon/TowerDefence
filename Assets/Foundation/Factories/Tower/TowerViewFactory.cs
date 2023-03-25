using Foundation.Data;
using Foundation.Services.Interfaces;
using Kernel.ECSIntegration;

namespace Foundation.Factories
{
    public class TowerViewFactory : ITowerViewFactory
    {
        private readonly ITowersViewsProvider _towersViewsProvider;
        private readonly IResourcesLoader _resourcesLoader;
        private readonly IUnityEntityViewCreator _entityViewCreator;

        public TowerViewFactory(ITowersViewsProvider towersViewsProvider, IResourcesLoader resourcesLoader, IUnityEntityViewCreator entityViewCreator)
        {
            _towersViewsProvider = towersViewsProvider;
            _resourcesLoader = resourcesLoader;
            _entityViewCreator = entityViewCreator;
        }
        
        public EntityView CreateTowerView(TowerData towerData)
        {
            var prefab =
                _resourcesLoader.Load<EntityView>(
                    _towersViewsProvider.GetTowerViewResourceNameByIndex(towerData.Index));

            var instance = _entityViewCreator.CreateFromPrefab(prefab);

            return instance;
        }
    }
}