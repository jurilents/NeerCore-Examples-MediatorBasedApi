using Microsoft.Extensions.DependencyInjection;
using NeerCore.Application.Extensions;
using NeerCore.DependencyInjection.Extensions;
using NeerCore.Mapping.Extensions;

namespace MiddleTemplate.Application;

public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddMediatorApplication();
        services.ConfigureAllOptions();
        services.RegisterAllMappers();
    }
}