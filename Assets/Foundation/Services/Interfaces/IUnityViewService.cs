using UnityEngine;

namespace Foundation.Services.Interfaces
{
    public interface IUnityViewService
    {
        T CreateViewFromPrefab<T>(T prefab, string name = null) where T : Object;
        Object CreateEmpty(string name = "GameObject");
    }
}