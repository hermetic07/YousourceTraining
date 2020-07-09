namespace eGift.Api.Extensions.Injection
{
    using eGift.Api.Models.Connections;
    using eGift.Infrastructure.Helpers;
    using eGift.Infrastructure.Providers;
    using eGift.Services.Product;
    using eGift.Services.Product.Data.Factories;
    using eGift.Services.Product.Data.Gateways;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public static class DataServices
    {
        public static void InjectDataService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IConnectionStringProvider, ConnectionStringProvider>();
            services.AddScoped<ISqlHelper, SqlHelper>();

        }
    }
}
