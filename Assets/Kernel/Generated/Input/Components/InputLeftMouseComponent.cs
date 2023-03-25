//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    static readonly Kernel.Components.LeftMouse leftMouseComponent = new Kernel.Components.LeftMouse();

    public bool isLeftMouse {
        get { return HasComponent(InputComponentsLookup.LeftMouse); }
        set {
            if (value != isLeftMouse) {
                var index = InputComponentsLookup.LeftMouse;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : leftMouseComponent;

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
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherLeftMouse;

    public static Entitas.IMatcher<InputEntity> LeftMouse {
        get {
            if (_matcherLeftMouse == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.LeftMouse);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherLeftMouse = matcher;
            }

            return _matcherLeftMouse;
        }
    }
}
