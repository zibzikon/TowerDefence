using System.Threading.Tasks;
using Foundation.Services.Interfaces;
using Kernel.Extensions;
using UnityEngine;

namespace Foundation.Services
{
    public class UnityResourcesBasedResourceLoader : IResourcesLoader
    {
        public T Load<T>(string resourceName) where T : Object
            => Resources.Load<T>(resourceName);
        
        public Task<T> LoadAsync<T>(string resourceName) where T : Object
        {
            var request = Resources.LoadAsync<T>(resourceName);
            return request.AsTask<T>();
        }
    }
}