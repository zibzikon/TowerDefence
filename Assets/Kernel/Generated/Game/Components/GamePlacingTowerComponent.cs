//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Kernel.Components.PlacingTower placingTowerComponent = new Kernel.Components.PlacingTower();

    public bool isPlacingTower {
        get { return HasComponent(GameComponentsLookup.PlacingTower); }
        set {
            if (value != isPlacingTower) {
                var index = GameComponentsLookup.PlacingTower;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : placingTowerComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherPlacingTower;

    public static Entitas.IMatcher<GameEntity> PlacingTower {
        get {
            if (_matcherPlacingTower == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PlacingTower);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPlacingTower = matcher;
            }

            return _matcherPlacingTower;
        }
    }
}
