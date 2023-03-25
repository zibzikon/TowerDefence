using Foundation.Services.Interfaces;

namespace Foundation.Services
{
    public class GameEntityCreator : IGameEntityCreator
    {
        private readonly GameContext _gameContext;

        public GameEntityCreator(GameContext gameContext) => _gameContext = gameContext;

        public GameEntity CreateEmpty() => _gameContext.CreateEntity();
    }
}