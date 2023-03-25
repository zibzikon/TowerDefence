using Foundation.Prototyping;
//using Sirenix.OdinInspector;
using UnityEngine;
using static UnityEngine.Vector3;

public class BezierCurvePrototypeVisualizer : MonoBehaviour
{
    [SerializeField] private float t;
    
    [SerializeField] private Transform point1, point2, point3, point4;


    private void OnDrawGizmos()
    {
        if (point1 is null || point2 is null || point3 is null || point4 is null) return;
        
        const float r = 0.1f;
        
        var p1 = point1.position;
        var p2 = point2.position;
        var p3 = point3.position;
        var p4 = point4.position;
        
        var p5 = Lerp(p1, p2, t);
        var p6 = Lerp(p2, p3, t);
        var p7 = Lerp(p3, p4, t);
        var p8 = Lerp(p5, p6, t);
        var p9 = Lerp(p6, p7, t);
        var p10 = Lerp(p8, p9, t);
        
        Gizmos.color = Color.white;
        Gizmos.DrawSphere(p5, r);
        Gizmos.DrawSphere(p6, r);
        Gizmos.DrawSphere(p7, r);
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(p8, r);
        Gizmos.DrawSphere(p9, r);
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(p10, r);
        Gizmos.color = Color.red;
        Gizmos.DrawLine(p1, p2);
        Gizmos.DrawLine(p2, p3);
        Gizmos.DrawLine(p3, p4);
        Gizmos.color = Color.white;
        Gizmos.DrawLine(p5, p6);
        Gizmos.DrawLine(p6, p7);
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(p8, p9);
            
        DrawCurve(p1, p2, p3, p4);
    }

    //[ShowInInspector, Button]
    public void Button() => Debug.Log("Opetenis");

    private static void DrawCurve(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4)
    {
        Gizmos.color = Color.black;

        var bezier = new BezierCurvePrototype(p1, p2, p3, p4);

        const int segmentation = 20;

        var previousPoint = p1;

        for (int i = 0; i < segmentation + 1; i++)
        {
            var parameter = (float)i / segmentation;
            var point = bezier.EvaluatePoint(parameter);
            Gizmos.DrawLine(previousPoint, point);

            previousPoint = point;
        }
    }
}
