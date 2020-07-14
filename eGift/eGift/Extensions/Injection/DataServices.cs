namespace Egift.Api.Extensions.Injection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Egift.Api.Models.Connections;
    using Egift.Infrastructure.Helpers;
    using Egift.Infrastructure.Providers;
    using Egift.Services.Product;
    using Egift.Services.Product.Data.Factories;
    using Egift.Services.Product.Data.Gateways;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public static class DataServices
    {
        public static void InjectDataService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IConnectionStringProvider, ConnectionStringProvider>();
            services.AddScoped<ISqlHelper, SqlHelper>();
        }
    }
}
