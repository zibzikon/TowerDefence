using Zenject;

namespace Kernel.Systems.Registration
{
    public class GameSystems : InjectableFeature
    {
        public GameSystems(DiContainer container) : base(container)
        {
            AddInjected<GameEventSystems>();
            AddInjected<PathFollowingProgressSystem>();
            AddInjected<PathFollowingSystem>();
        }
    }
}