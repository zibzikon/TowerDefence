using System.Collections;
using System.Linq;
using Entitas;
using Kernel.Extensions;
using static GameMatcher;

namespace Kernel.Systems
{
    public class FindNearestTowerHolderSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _placingTowers;
        private readonly IGroup<GameEntity> _towerHolders;

        public FindNearestTowerHolderSystem(GameContext context)
        {
            _placingTowers = context.GetGroup(AllOf(PlacingTower, Position));
            _towerHolders = context.GetGroup(AllOf(TowerHolder, Position, ID));
        }
        
        public void Execute()
        {
            const float maxDistanceToAttach = .5f;
            
            foreach (var placingTower in _placingTowers)
            {
                var towerHoldersEnumerable = _towerHolders.AsEnumerable();
                var towerHolders = towerHoldersEnumerable as GameEntity[] ?? towerHoldersEnumerable.ToArray();


                var nearestTowerHolderId = 
                    towerHolders.Select(x => x.position.Value)
                        .GetNearestVectorIndex(placingTower.position.Value, maxDistanceToAttach); 
                
                if(nearestTowerHolderId > 0)
                    placingTower.ReplaceNearestTowerHolderID(towerHolders[nearestTowerHolderId].iD.Value);
            }
            
        }
    }
}