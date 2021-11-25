using GraphQL;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

namespace Api
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApi(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddOptions();

            ConfigureGraphQl(serviceCollection);

            return serviceCollection;
        }

        private static void ConfigureGraphQl(IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddGraphQLServer()
                .AddQueries();
        }
    }
}