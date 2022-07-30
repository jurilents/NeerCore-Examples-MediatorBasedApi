using Microsoft.Extensions.DependencyInjection;
using NeerCore.Application.Extensions;
using NeerCore.Mapping.Extensions;

namespace MiddleTemplate.Application;

public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddMediatorApplication();
        services.RegisterAllMappers();
    }
}