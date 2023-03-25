//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Kernel.Components.TowerTypeID towerTypeID { get { return (Kernel.Components.TowerTypeID)GetComponent(GameComponentsLookup.TowerTypeID); } }
    public bool hasTowerTypeID { get { return HasComponent(GameComponentsLookup.TowerTypeID); } }

    public void AddTowerTypeID(int newValue) {
        var index = GameComponentsLookup.TowerTypeID;
        var component = (Kernel.Components.TowerTypeID)CreateComponent(index, typeof(Kernel.Components.TowerTypeID));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceTowerTypeID(int newValue) {
        var index = GameComponentsLookup.TowerTypeID;
        var component = (Kernel.Components.TowerTypeID)CreateComponent(index, typeof(Kernel.Components.TowerTypeID));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveTowerTypeID() {
        RemoveComponent(GameComponentsLookup.TowerTypeID);
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

    static Entitas.IMatcher<GameEntity> _matcherTowerTypeID;

    public static Entitas.IMatcher<GameEntity> TowerTypeID {
        get {
            if (_matcherTowerTypeID == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.TowerTypeID);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTowerTypeID = matcher;
            }

            return _matcherTowerTypeID;
        }
    }
}
