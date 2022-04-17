using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace StaticClassesProxies.System.DependencyInjection.Microsoft
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Add proxies for static classes to microsoft DI through service collection
        /// </summary>
        public static IServiceCollection AddStaticClassesProxies(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<IDateTimeService, DateTimeService>()
                .AddSystemIOProxies();
        }

        private static IServiceCollection AddSystemIOProxies(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                .AddTransient<IDirectory, DirectoryImpl>()
                .AddTransient<IFile, FileImpl>();
        }
    }
}
