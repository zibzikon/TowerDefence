using System.Collections.Generic;
using Entitas;
using UnityEngine;
using UnityEngine.Splines;
using static GameMatcher;

namespace Kernel.Systems
{
    public class PathFollowingSystem : ReactiveSystem<GameEntity>
    {
        public PathFollowingSystem(GameContext context) : base(context) { }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(PathFollowingProgress);

        protected override bool Filter(GameEntity entity)
            => AllOf(FollowingPath, PathFollowingProgress, Position, Rotation).Matches(entity);

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var follower in entities)
            {
                var path = follower.followingPath.Value;
                var followingProgress = follower.pathFollowingProgress.Value;
                follower.ReplacePosition((Vector3)path.EvaluatePosition(followingProgress));
                follower.ReplaceRotation(Quaternion.Euler(path.EvaluateTangent(followingProgress)));
            }
        }
    }
}