using UnityEngine;
using static UnityEngine.Vector2;

namespace Foundation.Prototyping
{
    public readonly struct BezierCurvePrototype
    {
        private readonly Vector2 _point1;
        private readonly Vector2 _point2;
        private readonly Vector2 _point3;
        private readonly Vector2 _point4;

        public BezierCurvePrototype(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4)
        {
            _point1 = p1;
            _point2 = p2;
            _point3 = p3;
            _point4 = p4;
        }

        public Vector2 EvaluatePoint(float t)
        {
            var p12 = Lerp(_point1, _point2, t);
            var p23 = Lerp(_point2, _point3, t);
            var p34 = Lerp(_point3, _point4, t);
            
            var p123 = Lerp(p12, p23, t);
            var p234 = Lerp(p23, p34, t);
            
            var p1234 = Lerp(p123, p234, t);

            return p1234;
        }
    }
}