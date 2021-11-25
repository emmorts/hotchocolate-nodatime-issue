using HotChocolate.Execution.Configuration;
using HotChocolate.Types;
using HotChocolate.Types.NodaTime;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQL
{
    public static class RequestExecutorBuilderExtensions
    {
        public static IRequestExecutorBuilder AddQueries(this IRequestExecutorBuilder builder)
        {
            builder
                .AddType(() => new UuidType("Uuid", defaultFormat: 'D'))
                .AddType<InstantType>()
                .AddQueryType<Queries>()
                .AddFiltering()
                .AddSorting();
            
            return builder;
        }
    }
}