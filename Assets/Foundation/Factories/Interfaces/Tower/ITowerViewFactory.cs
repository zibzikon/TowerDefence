using Foundation.Data;
using Kernel.ECSIntegration;

namespace Foundation.Factories
{
    public interface ITowerViewFactory
    {
        EntityView CreateTowerView(TowerData towerData);
    }
}