using Entitas;
using Foundation.Data;

namespace Foundation.Services.Interfaces
{
    public interface IComponentBuilder
    {
        T BuildComponent<T>(ComponentData data) where T : IComponent, new();
        
        IComponent BuildComponent(ComponentData data);
        
    }
}