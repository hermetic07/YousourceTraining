namespace eGift.Api.Extensions.Injection
{
    using eGift.Services.Merchant;
    using eGift.Services.Merchant.Data.Factories;
    using eGift.Services.Merchant.Data.Gateways;
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
