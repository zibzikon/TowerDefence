using System;
using Entitas;

namespace Foundation.Services.Interfaces
{
    public interface IComponentsIndexesProvider
    {
        int GetComponentIndex<T>() where T : IComponent;
        int GetComponentIndex(Type type);
    }
}