namespace Kernel.ECSIntegration.Behaviours
{
    public class TowerHolderBehaviour : EntityBehaviour
    {
        protected override void OnStart()
        {
            Entity.isTowerHolder = true;
            Entity.AddPosition(transform.position);
        }
    }
}