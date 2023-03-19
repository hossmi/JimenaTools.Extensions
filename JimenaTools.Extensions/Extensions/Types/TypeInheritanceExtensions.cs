using System;
using System.Linq;
using JimenaTools.Exceptions;
using JimenaTools.Extensions.Validations;

namespace JimenaTools.Extensions.Types
{
    public static class TypeInheritanceExtensions
    {
        public static bool Implements(this Type type, Type interfaceType)
        {
            return ImplementsInterface(type, interfaceType);
        }

        public static bool Implements<T>(this Type type) where T : class
        {
            return ImplementsInterface(type, typeof(T));
        }

        public static bool InheritsFrom(this Type type, Type predecesorType)
        {
            return StartInheritsFrom(type, predecesorType);
        }

        public static bool InheritsFrom<T>(this Type type) where T : class
        {
            return StartInheritsFrom(type, typeof(T));
        }

        private static bool ImplementsInterface(Type type, Type interfaceType)
        {
            type.ShouldBeNotNull(nameof(type));
            interfaceType.ShouldBeNotNull(nameof(interfaceType));

            if (type.IsInterface)
                throw new ArgumentException($"Parameter {nameof(type)} cannot be interface.");

            if (!interfaceType.IsInterface)
                throw new ArgumentException($"Parameter {nameof(interfaceType)} must be interface.");

            return type
                .GetInterfaces()
                .Any(t => t.Equals(interfaceType));
        }

        private static bool StartInheritsFrom(Type type, Type predecesorType)
        {
            bool result, bothAreInterfaces, bothAreClasses, bothAreInterfacesOrClasses;

            type.ShouldBeNotNull(nameof(type));
            predecesorType.ShouldBeNotNull(nameof(predecesorType));

            if (type.Equals(predecesorType))
                throw new ArgumentException($"Types cannot be the same type.");

            bothAreInterfaces = type.IsInterface && predecesorType.IsInterface;
            bothAreClasses = type.IsClass && predecesorType.IsClass;
            bothAreInterfacesOrClasses = bothAreInterfaces || bothAreClasses;

            if (!bothAreInterfacesOrClasses)
                throw new ArgumentException($"Both types must be interfaces or classes.");

            if (bothAreInterfaces)
                result = type
                    .GetInterfaces()
                    .Any(t => t.Equals(predecesorType));
            else
                result = RecurseInheritsFrom(type, predecesorType, 1);

            return result;
        }

        private static bool RecurseInheritsFrom(Type type, Type predecesorType, int recursion)
        {
            bool result;
            Type baseType;

            if (1000 < recursion)
                throw new RecursiveCallException(1000);

            baseType = type.BaseType;

            if (baseType == null)
                result = false;
            else if (baseType.Equals(predecesorType))
                result = true;
            else
                result = RecurseInheritsFrom(baseType, predecesorType, recursion + 1);

            return result;
        }

    }
}
