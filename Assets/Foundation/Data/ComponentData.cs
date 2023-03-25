using System;

namespace Foundation.Data
{
    public class ComponentData
    {
        public readonly Type Type;
        public readonly object Value;

        public ComponentData(Type type, object value = default)
        {
            Type = type;
            Value = value;
        }
    }
}