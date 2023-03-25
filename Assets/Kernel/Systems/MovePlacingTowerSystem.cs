using System.Collections.Generic;
using Entitas;
using static GameMatcher;
using static InputMatcher;

namespace Kernel.Systems
{
    public class MovePlacingTowerSystem : ReactiveSystem<InputEntity>
    {
        private readonly IGroup<GameEntity> _placingTowers;
        private IGroup<GameEntity> _towerHolders;
        
        public MovePlacingTowerSystem(GameContext gameContext, InputContext inputContext) : base(inputContext)
        {
            _placingTowers = gameContext.GetGroup(AllOf(PlacingTower, Position));
            _placingTowers = gameContext.GetGroup(AllOf(TowerHolder, Position));
        }

        protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
            => context.CreateCollector(MousePosition.Added());

        protected override bool Filter(InputEntity entity)
            => AllOf(Mouse, MousePosition).Matches(entity);
        
        protected override void Execute(List<InputEntity> mouses)
        {
            
            foreach (var placingTower in _placingTowers)
            foreach (var towerHolder in _towerHolders)
            foreach (var mouse in mouses)
            {
                var newPosition = mouse.mousePosition.Value;
                    
                if (placingTower.hasNearestTowerHolderID &&
                    towerHolder.iD.Value == placingTower.nearestTowerHolderID.Value)
                    newPosition = towerHolder.position.Value;
                
                placingTower.ReplacePosition(newPosition);
            }
        }
    }
}