namespace EGift.Services.Email.Providers
{
    using System.IO;
    using EGift.Services.Email.Models;
    using Microsoft.Extensions.Configuration;

    public class MailGunProvider
    {
        private readonly MailGunSettings mailGunSettings;

        public MailGunProvider()
        {
            this.mailGunSettings = new MailGunSettings();

            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);

            var root = configurationBuilder.Build();
            this.mailGunSettings.ApiBaseUri = root.GetSection("EmailSettings").GetSection("ApiBaseUri").Value;
            this.mailGunSettings.ApiKey = root.GetSection("EmailSettings").GetSection("ApiKey").Value;
            this.mailGunSettings.RequestUri = root.GetSection("EmailSettings").GetSection("RequestUri").Value;
            this.mailGunSettings.From = root.GetSection("EmailSettings").GetSection("From").Value;
        }

        public MailGunSettings GetEmailSettings()
        {
            return this.mailGunSettings;
        }
    }
}
