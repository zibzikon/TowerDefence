using System;
using System.Linq;
using DesperateDevs.Utils;
using Entitas;
using Foundation.Services.Interfaces;
using Foundation.Utils.Exceptions;
using Kernel.Extensions;
using ModestTree;

namespace Foundation.Services
{
    public class ComponentsIndexesProvider : IComponentsIndexesProvider
    {
       
        public int GetComponentIndex<T>() where T : IComponent
            => GetComponentIndex(typeof(T));
        
        public int GetComponentIndex(Type type)
        {
            if (!type.ImplementsInterface<IComponent>())
                throw new NotImplementsInterfaceException(type, typeof(IComponent));

            var componentsTypesCollection = GameComponentsLookup.componentTypes;
            
            if (type.HaveCustomAttribute<InputAttribute>())
                componentsTypesCollection = InputComponentsLookup.componentTypes;

            return componentsTypesCollection.IndexOf(componentsTypesCollection.First(t => t == type));
        }
    }
}