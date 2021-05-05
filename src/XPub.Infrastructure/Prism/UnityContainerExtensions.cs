using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace XPub.Infrastructure.Prism
{
    /// <summary>
    /// UnityContainerExtensions extension object
    /// Provides extension methods for the UnitContainer object
    /// </summary>
    public static class UnityContainerExtensions
    {
        #region Static Extension Methods
        /// <summary>
        /// RegisterTypeForNavigation method
        /// Used to register a type for navigation
        /// </summary>
        /// <typeparam name="T">Type to navigate to</typeparam>
        /// <param name="container">UnityContainer</param>
        public static void RegisterTypeForNavigation<T>(this IUnityContainer container)
        {
            container.RegisterType(typeof(Object), typeof(T), typeof(T).FullName);
        }

        /// <summary>
        /// RegisterTypeForNavigation method
        /// Used to register a type for navigation
        /// </summary>
        /// <param name="container">UnityContainer</param>
        /// <param name="type">Type to navigate to</param>
        public static void RegisterTypeForNavigation(this IUnityContainer container, Type type)
        {
            container.RegisterType(typeof(Object), type, type.FullName);
        }
        #endregion
    }
}
