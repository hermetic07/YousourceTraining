namespace Egift.Api.Extensions.Injection
{
    using Egift.Services.Email.Interface;
    using Egift.Services.Product;
    using Egift.Services.Product.Data.Factories;
    using Egift.Services.Product.Data.Gateways;
    using EGift.Services.Email;
    using EGift.Services.Email.Models.MailService;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public static class EmailServices
    {
        public static void InjectEmailService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IEmailService, SendGridEmailService>();
            services.AddScoped<IEmailSender, EmailSender>();
        }
    }
}
