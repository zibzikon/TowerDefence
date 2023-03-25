namespace Kernel.ECSIntegration.Behaviours
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