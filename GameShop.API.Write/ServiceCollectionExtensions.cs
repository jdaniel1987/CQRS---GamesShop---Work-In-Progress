﻿using Carter;
using GameShop.Application.Write;
using GameShop.Infrastructure.Write;

namespace GameShop.API.Write;

public static class ServiceCollectionExtensions
{
    public static void AddWriteApi(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddWriteInfrastructure(configuration);
        services.AddWriteApplication();

        //services.AddRefitClient<IShowApi>()
        //        .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://your-api-url.com")); // Reemplaza con la URL base de tu API

        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddCarter();
    }
}
