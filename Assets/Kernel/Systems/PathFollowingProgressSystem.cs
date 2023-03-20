using Entitas;
using UnityEngine;
using static GameMatcher;

namespace Kernel.Systems
{
    public class PathFollowingProgressSystem : IExecuteSystem
    { 
        private IGroup<GameEntity> _pathFollowers;

        public PathFollowingProgressSystem(GameContext context)
        {
            _pathFollowers = context.GetGroup(AllOf(FollowingPath, MovingSpeed));
        }
        
        public void Execute()
        {
            foreach (var pathFollower in _pathFollowers)
            {
                if (!pathFollower.hasPathFollowingProgress)
                    pathFollower.AddPathFollowingProgress(0);

                var progress = pathFollower.pathFollowingProgress.Value;
                var speed = pathFollower.movingSpeed.Value;
                pathFollower.ReplacePathFollowingProgress(progress + speed * Time.deltaTime);
            }
        }
    }
}