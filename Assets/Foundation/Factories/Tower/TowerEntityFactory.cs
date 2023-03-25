using Foundation.Data;
using Foundation.Services;
using Foundation.Services.Interfaces;

namespace Foundation.Factories
{
    public class TowerEntityFactory : ITowerEntityFactory
    {
        
        private readonly IGameEntityCreator _creator;
        private readonly IComponentBuilder _componentBuilder;
        private readonly IComponentsIndexesProvider _componentsIndexesProvider;

        public TowerEntityFactory(IGameEntityCreator creator,
            IComponentBuilder componentBuilder, IComponentsIndexesProvider componentsIndexesProvider)
        {
            _creator = creator;
            _componentBuilder = componentBuilder;
            _componentsIndexesProvider = componentsIndexesProvider;
        }

        public GameEntity CreateTowerEntity(TowerData towerData)
        {
            var towerEntity = _creator.CreateEmpty();
            
            AddComponentsToTower(towerEntity, towerData);

            return towerEntity;
        }

        private void AddComponentsToTower(GameEntity towerEntity, TowerData data)
        {
            foreach (var componentData in data.Components)
            {
                towerEntity.AddComponent(_componentsIndexesProvider.GetComponentIndex(componentData.Type),
                    _componentBuilder.BuildComponent(componentData));
            }
        }
    }
}