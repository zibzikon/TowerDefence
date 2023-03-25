using UnityEngine;

namespace Kernel.ECSIntegration
{
    public sealed class EntityView : MonoBehaviour
    {
        public GameEntity Entity { get; private set; }

        public void Initialize(GameEntity entity)
        {
            Entity = entity;
        }

        private void Start()
        {
            RegisterListeners();
        }

        private void RegisterListeners()
        {
            foreach (var listener in GetComponents<IGameEventListener>())
                listener.Register(Entity);
        }
    }
}