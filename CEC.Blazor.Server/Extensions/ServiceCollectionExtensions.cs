﻿using CEC.Weather.Data;
using CEC.Weather.Data.Validators;
using CEC.Weather.Services;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace CEC.Blazor.Server.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddSingleton<IWeatherForecastDataService, WeatherForecastServerDataService>();
            services.AddScoped<WeatherForecastControllerService>();
            services.AddTransient<IValidator<DbWeatherForecast>, WeatherForecastValidator>();
            return services;
        }

    }
}
