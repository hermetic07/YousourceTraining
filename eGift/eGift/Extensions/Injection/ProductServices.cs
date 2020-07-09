namespace eGift.Api.Extensions.Injection
{
    using eGift.Services.Product;
    using eGift.Services.Product.Data.Factories;
    using eGift.Services.Product.Data.Gateways;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public static class ProductServices
    {
        public static void InjectProductService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductSqlCommandFactory, ProductSqlCommandFactory>();
            services.AddScoped<IProductDataGateway, ProductDataGateway>();
        }
    }
}
