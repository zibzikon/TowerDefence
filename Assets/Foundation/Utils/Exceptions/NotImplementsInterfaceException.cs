using System;

namespace Foundation.Exceptions
{
    public class NotImplementsInterfaceException : Exception
    {
        private readonly Type _sourceType;
        private readonly Type _interfaceType;

        public NotImplementsInterfaceException(Type sourceType, Type interfaceType)
        {
            _sourceType = sourceType;
            _interfaceType = interfaceType;
        }

        public override string ToString()
            => $"The type ({_sourceType}) is not implements ({_interfaceType}) interface";

    }
}