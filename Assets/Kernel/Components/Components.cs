using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;
using UnityEngine.Splines;
using static Entitas.CodeGeneration.Attributes.EventTarget;

namespace Kernel.Components
{
    [Game] public class Enemy : IComponent{ }
    [Game] public class MovingSpeed : IComponent { public float Value; }
    [Game] public class PathFollowingProgress : IComponent { public float Value; }
    [Game] public class FollowingPath : IComponent { public Spline Value; }
    [Game, Event(Self)] public class Position : IComponent { public Vector2 Value; }
    [Game, Event(Self)] public class Rotation : IComponent { public Quaternion Value; }
}
