using Domain;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace IoC
{
    public static class NativeInjectorConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IRick, Rick>();
            services.AddScoped<IOperations, Operations>();
        }
    }
}

