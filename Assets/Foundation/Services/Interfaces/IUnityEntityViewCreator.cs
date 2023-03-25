using Kernel.ECSIntegration;

namespace Foundation.Services.Interfaces
{
    public interface IUnityEntityViewCreator
    {
        EntityView CreateFromPrefab(EntityView prefab);
        EntityView CreateFromResourceName(string name);
        EntityView CreateEmpty();
    }
}