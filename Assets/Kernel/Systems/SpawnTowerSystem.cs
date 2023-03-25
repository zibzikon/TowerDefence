using System.Collections.Generic;
using Entitas;
using Foundation.Data;
using Foundation.Factories.Interfaces;
using Kernel.Components;
using Kernel.Extensions;
using static GameMatcher;

namespace Kernel.Systems
{
    public class SpawnTowerSystem : ReactiveSystem<InputEntity>
    {
        private readonly GameContext _gameContext;
        private readonly ITowerFactory _towerFactory;

        public SpawnTowerSystem(GameContext gameContext, InputContext inputContext, ITowerFactory towerFactory) : base(inputContext)
        {
            _gameContext = gameContext;
            _towerFactory = towerFactory;
        }

        protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
            => context.CreateCollector(InputMatcher.LeftMouse.Added());

        protected override bool Filter(InputEntity entity)
            => entity.isMouse;


        protected override void Execute(List<InputEntity> mouses)
        {
            foreach (var _ in mouses)
            {
                var towerData = new TowerData("EmptyTower", 0,
                    new[] { new ComponentData(typeof(Enemy)) });
                
                var tower = _towerFactory.CreateTower(towerData);
                
                tower.With(x => x.isPlacingTower = true).With(x => x.AddTowerTypeID(towerData.Index));
            }
        }
    }
}