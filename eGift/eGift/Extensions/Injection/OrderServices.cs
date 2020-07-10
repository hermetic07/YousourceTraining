namespace eGift.Api.Extensions.Injection
{
    using eGift.Services.Order;
    using eGift.Services.Order.Data.Factories;
    using eGift.Services.Order.Data.Gateways;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public static class OrderServices
    {
        public static void InjectOrderService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderSqlCommandFactory, OrderSqlCommandFactory>();
            services.AddScoped<IOrderDataGateway, OrderDataGateway>();

        }
    }
}
