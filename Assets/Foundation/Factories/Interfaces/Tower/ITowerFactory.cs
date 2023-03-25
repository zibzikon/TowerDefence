using Foundation.Data;

namespace Foundation.Factories.Interfaces
{
    public interface ITowerFactory
    {
        GameEntity CreateTower(TowerData towerData);
    }
}