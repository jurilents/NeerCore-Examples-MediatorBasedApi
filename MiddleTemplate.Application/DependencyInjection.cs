using Microsoft.Extensions.DependencyInjection;
using NeerCore.Application.Extensions;
using NeerCore.Mapping.Extensions;

namespace MiddleTemplate.Application;

public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection services)
    {
        // TODO: Fixed in v1.5.0
        services.AddMediatorApplicationFromCurrentAssembly();
        services.RegisterAllMappers();
    }
}