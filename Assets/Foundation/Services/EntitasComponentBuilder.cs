using System;
using System.Reflection;
using DesperateDevs.Utils;
using Entitas;
using Foundation.Data;
using Foundation.Exceptions;
using Foundation.Services.Interfaces;

namespace Foundation.Services
{
    public class EntitasComponentBuilder : IComponentBuilder
    {
        public T BuildComponent<T>(ComponentData data) where T : IComponent, new()
        {
            var type = typeof(T);

            if (data.Type != type)
                throw new InvalidCastException($"The component data type: ({type}) is not equal with generic ({type})");

            return (T)BuildComponent(data);
        }

        public IComponent BuildComponent(ComponentData data)
        {
            var type = data.Type;

            if (!type.ImplementsInterface<IComponent>())
                throw new NotImplementsInterfaceException(type, typeof(IComponent));

            var properties = type.GetProperties(BindingFlags.Default | BindingFlags.Instance);

            if (properties.Length > 1) throw new NotImplementedException();
            
            var instance = Activator.CreateInstance(type);
            
            if(properties.Length == 1)
            {
                var destProp = properties[0];
                if (!destProp.PropertyType.IsInstanceOfType(data.Value)) throw new
                    InvalidOperationException(@$"The component data Value type: ({data.Value.GetType()} cannot be assigned to component: ({type}) property with name {destProp.Name} and type: ({destProp.PropertyType}))");

                destProp.SetValue(instance, data.Value);
            }

            return instance as IComponent;
        }
    }
}