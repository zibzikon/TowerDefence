using Foundation.ECSIntegration.Behaviours;

namespace Kernel.Enemy
{
    public class EnemyEntity : EntityBehaviour
    {
        protected override void OnStart()
        {
            Entity.AddPosition(transform.position);
            Entity.AddRotation(transform.localRotation);
            Entity.AddMovingSpeed(0.2f);
        }
    }
}