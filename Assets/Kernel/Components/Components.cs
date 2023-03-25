using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;
using UnityEngine.Splines;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace Kernel.Components
{
    public class ID : IComponent { [PrimaryEntityIndex] public int Value;}
    
    [Game] public class Enemy : IComponent{ }
    [Game] public class TowerHolder : IComponent{ }
    [Game] public class PlacingTower : IComponent{ }
    
    [Game] public class Movable : IComponent{ }
    
    [Game] public class NearestTowerHolderID : IComponent{ public int Value;}
    [Game] public class TowerTypeID : IComponent{ public int Value; }
    [Game] public class MovingSpeed : IComponent { public float Value; }
    [Game] public class PathFollowingProgress : IComponent { public float Value; }
    [Game] public class FollowingPath : IComponent { public Spline Value; }
    [Game] public class MovePosition : IComponent { public Vector2 Value; }

    [Input, Unique] public class Mouse : IComponent { }
    [Input] public class LeftMouse : IComponent { }
    [Input] public class MouseAxis : IComponent { public Vector2 Value; }
    [Input] public class MousePosition : IComponent { public Vector2 Value; }
;    
    [Game, Event(Self)] public class Position : IComponent { public Vector2 Value; }
    [Game, Event(Self)] public class Rotation : IComponent { public Quaternion Value; }
}
