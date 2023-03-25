using System;

namespace Kernel.Extensions
{
    public static class CleanCodeExtensions
    {
        public static bool HaveCustomAttribute<T>(this object o) =>
            Attribute.GetCustomAttribute(o.GetType(), typeof(T)) is not null;

        public static bool Exists(this object o) => o is not null;
        public static bool Exists(this UnityEngine.Object o) => o;
        
        public static bool NotExists(this object o) => o is null;
        public static bool NotExists(this UnityEngine.Object o) => !o;
    }
}