﻿using System.Reflection;

using Mauve;
using Mauve.Extensibility;

namespace Freya.Core
{
    /// <summary>
    /// Represents a factory for creating instances of concrete implementations of a specified type marked with an <see cref="AliasAttribute"/>.
    /// </summary>
    /// <typeparam name="T">Specifies the type of objects the factory can create.</typeparam>
    public abstract class AliasedTypeFactory<T>
    {
        /// <summary>
        /// Gets all qualified types for the factory.
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/> containing the qualified types for the factory.</returns>
        protected IEnumerable<Type>? GetQualifiedTypes()
        {
            // Get the entry assembly, if we can't find it, there's no work.
            var assembly = Assembly.GetEntryAssembly();
            if (assembly is null)
                return null;

            // Get any types considered valid for the factory.
            return from type
                   in assembly.GetTypes()
                   where !type.IsAbstract &&
                         !type.IsInterface &&
                         type.GetCustomAttribute<AliasAttribute>() is not null &&
                         type.DerivesFrom<T>()
                   select type;
        }
    }
}