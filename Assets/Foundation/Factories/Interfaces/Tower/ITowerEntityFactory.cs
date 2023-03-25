using Foundation.Data;

namespace Foundation.Factories
{
    public interface ITowerEntityFactory
    {
        GameEntity CreateTowerEntity(TowerData towerData);
    }
}