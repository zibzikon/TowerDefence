using System;
using UnityEngine;

namespace Foundation.ECSIntegration.Behaviours
{
    [RequireComponent(typeof(EntityView))]
    public abstract class EntityBehaviour : MonoBehaviour
    {
        public GameEntity Entity => _entityView.Entity;

        private EntityView _entityView;

        private void Awake()
        {
            _entityView = GetComponent<EntityView>();
        }

        private void Start() => OnStart();
        
        protected virtual void OnStart(){}
    }
}