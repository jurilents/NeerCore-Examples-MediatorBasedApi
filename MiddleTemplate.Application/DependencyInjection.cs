﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NeerCore.Application.Extensions;
using NeerCore.Mapping;
using NeerCore.Mapping.Extensions;

namespace MiddleTemplate.Application;

public static class DependencyInjection
{
	public static void AddApplication(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddMediatorApplicationFromCurrentAssembly();
		services.BindConfigurationOptions(configuration);
		services.RegisterMappings();
	}


	private static void BindConfigurationOptions(this IServiceCollection services, IConfiguration configuration)
	{
		// services.Configure<SmtpOptions>(configuration.GetSection("Smtp"));
	}

	private static void RegisterMappings(this IServiceCollection services)
	{
		services.RegisterMapper<MapperRegister>();
	}
}