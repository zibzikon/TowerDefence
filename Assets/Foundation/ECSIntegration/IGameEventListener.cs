namespace Foundation.ECSIntegration
{
    public interface IGameEventListener
    {
        void Register(GameEntity entity);
        void Unregister(GameEntity entity);
    }
}