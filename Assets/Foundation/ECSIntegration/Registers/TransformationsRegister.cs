namespace Kernel.ECSIntegration.Behaviours
{
    public class TransformationsRegister : EntityBehaviour
    {
        protected override void OnStart()
        {
            Entity.AddPosition(transform.position);
            Entity.AddRotation(transform.rotation);
        }
    }
}