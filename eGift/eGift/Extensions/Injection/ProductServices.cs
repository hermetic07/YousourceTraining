namespace Egift.Api.Extensions.Injection
{
    using Egift.Services.Product;
    using Egift.Services.Product.Data.Factories;
    using Egift.Services.Product.Data.Gateways;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

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
