using System.Linq;
using Foundation.ECSIntegration.Behaviours;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Splines;

namespace Kernel.Path
{
    public class FollowingPathRegister : EntityBehaviour
    {
        [Required, SerializeField] private SplineContainer _splineContainer;
        protected override void OnStart()
        {
            Entity.AddFollowingPath(_splineContainer.Splines.First());
        }
    }
}