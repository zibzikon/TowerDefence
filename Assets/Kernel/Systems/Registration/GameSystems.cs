using Kernel.Systems.Input;
using Zenject;

namespace Kernel.Systems.Registration
{
    public class GameSystems : InjectableFeature
    {
        public GameSystems(DiContainer container) : base(container)
        {
            AddInjected<RegisterInputSystem>();
            AddInjected<EmmitInputSystem>();
            AddInjected<GameEventSystems>();
            AddInjected<SpawnTowerSystem>();
            AddInjected<MovePlacingTowerSystem>();
            AddInjected<PathFollowingProgressSystem>();
            AddInjected<PathFollowingSystem>();
            AddInjected<SingleEnemyAttackSystem>();
        }
    }
}