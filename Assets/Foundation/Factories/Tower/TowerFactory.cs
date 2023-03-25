using Foundation.Data;
using Foundation.Factories.Interfaces;
using Kernel.Extensions;

namespace Foundation.Factories
{
    public class TowerFactory : ITowerFactory
    {
        private readonly ITowerEntityFactory _entityFactory;
        private readonly ITowerViewFactory _viewFactory;

        public TowerFactory(ITowerEntityFactory entityFactory, ITowerViewFactory viewFactory)
        {
            _entityFactory = entityFactory;
            _viewFactory = viewFactory;
        }
        
        public GameEntity CreateTower(TowerData towerData)
        {
            var towerEntity = _entityFactory.CreateTowerEntity(towerData);

            _viewFactory.CreateTowerView(towerData).With(x => x.Initialize(towerEntity));

            return towerEntity;
        }

    }
}