using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace StaticClassesProxies.System.DependencyInjection.Microsoft
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddStaticClassesProxies(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IDirectory, DirectoryImpl>();
            serviceCollection.AddTransient<IFile, FileImpl>();

            return serviceCollection;
        }
    }
}
