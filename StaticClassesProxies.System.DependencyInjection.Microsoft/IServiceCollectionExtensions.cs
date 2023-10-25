using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace StaticClassesProxies.System.DependencyInjection.Microsoft
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds all proxies
        /// </summary>
        public static IServiceCollection AddSystemProxies(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddStaticClassesProxies()
                .AddRandomProxies();
        }

        /// <summary>
        /// Adds proxies for static classes to microsoft DI through service collection
        /// </summary>
        public static IServiceCollection AddStaticClassesProxies(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<IDateTimeService, DateTimeService>()
                .AddSystemIOProxies();
        }

        /// <summary>
        /// Adds proxies for static classes to microsoft DI through service collection
        /// </summary>
        private static IServiceCollection AddSystemIOProxies(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<IDirectory, DirectoryImpl>()
                .AddTransient<IFile, FileImpl>();
        }

        /// <summary>
        /// Adds proxies for random class through service collection
        /// </summary>
        public static IServiceCollection AddRandomProxies(this IServiceCollection serviceCollection)
        {
            return serviceCollection.AddTransient<IRandom>(x => RandomProxy.Shared);
        }
    }
}
