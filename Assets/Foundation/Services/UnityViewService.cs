using Foundation.Services.Interfaces;
using Kernel.Extensions;
using UnityEngine;
using static System.String;
using static Foundation.Constants;
using Object = UnityEngine.Object;

namespace Foundation.Services
{
    public class UnityViewService : IUnityViewService
    {
        private Transform _viewsRoot;

        public UnityViewService()
        {
            _viewsRoot = CreateRootTransform();
        }

        public T CreateViewFromPrefab<T>(T prefab, string name = null) where T : Object => 
            Object.Instantiate(prefab, _viewsRoot).With(x => x.name = IsNullOrEmpty(name)? nameof(T) : name );

        public Object CreateEmpty(string name = "GameObject") => new GameObject(name);
        
        private Transform CreateRootTransform() => new GameObject(ViewsRootName).transform;

    }
}