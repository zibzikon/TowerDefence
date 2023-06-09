//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Kernel.Components.MovingSpeed movingSpeed { get { return (Kernel.Components.MovingSpeed)GetComponent(GameComponentsLookup.MovingSpeed); } }
    public bool hasMovingSpeed { get { return HasComponent(GameComponentsLookup.MovingSpeed); } }

    public void AddMovingSpeed(float newValue) {
        var index = GameComponentsLookup.MovingSpeed;
        var component = (Kernel.Components.MovingSpeed)CreateComponent(index, typeof(Kernel.Components.MovingSpeed));
        component.Value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceMovingSpeed(float newValue) {
        var index = GameComponentsLookup.MovingSpeed;
        var component = (Kernel.Components.MovingSpeed)CreateComponent(index, typeof(Kernel.Components.MovingSpeed));
        component.Value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveMovingSpeed() {
        RemoveComponent(GameComponentsLookup.MovingSpeed);
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

    static Entitas.IMatcher<GameEntity> _matcherMovingSpeed;

    public static Entitas.IMatcher<GameEntity> MovingSpeed {
        get {
            if (_matcherMovingSpeed == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.MovingSpeed);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMovingSpeed = matcher;
            }

            return _matcherMovingSpeed;
        }
    }
}
