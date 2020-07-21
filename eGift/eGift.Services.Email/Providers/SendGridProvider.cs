namespace EGift.Services.Email.Providers
{
    using System.IO;
    using Microsoft.Extensions.Configuration;

    public class SendGridProvider
    {
        public readonly string SendGridKey = string.Empty;

        public SendGridProvider()
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);

            var root = configurationBuilder.Build();
            this.SendGridKey = root.GetSection("EmailServices").GetSection("SendGridKey").Value;
        }

        public string GetSendGridKey()
        {
            return this.SendGridKey;
        }
    }
}
