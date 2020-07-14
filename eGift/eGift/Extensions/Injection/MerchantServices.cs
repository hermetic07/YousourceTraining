namespace Egift.Api.Extensions.Injection
{
    using Egift.Services.Merchant;
    using Egift.Services.Merchant.Data.Factories;
    using Egift.Services.Merchant.Data.Gateways;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public static class MerchantServices
    {
        public static void InjectMerchantService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IMerchantService, MerchantService>();
            services.AddScoped<IMerchantSqlCommandFactory, MerchantSqlCommandFactory>();
            services.AddScoped<IMerchantDataGateway, MerchantDataGateway>();
        }
    }
}
