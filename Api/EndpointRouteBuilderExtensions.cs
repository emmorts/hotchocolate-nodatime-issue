using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Api
{
    public static class EndpointRouteBuilderExtensions
    {
        public static void MapApi(this IEndpointRouteBuilder endpointsRouteBuilder)
        {
            endpointsRouteBuilder.MapControllers();
            endpointsRouteBuilder.MapGraphQL();
        }
    }
}