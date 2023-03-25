using UnityEngine;

namespace Kernel.ECSIntegration.Listeners
{
    public class RotationListener : MonoBehaviour, IGameEventListener, IRotationListener
    {
        public void Register(GameEntity entity) => entity.AddRotationListener(this);

        public void Unregister(GameEntity entity) => entity.RemoveRotationListener(this);

        public void OnRotation(GameEntity entity, Quaternion value)
        {
            transform.rotation = value;
        }
    }
}