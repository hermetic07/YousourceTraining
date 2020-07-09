using Microsoft.Extensions.Configuration;
using System.IO;

namespace eGift.Infrastructure.Providers
{
    public class ConnectionStringProvider : IConnectionStringProvider
    {
        public readonly string connectionString = string.Empty;
        public ConnectionStringProvider()
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);

            var root = configurationBuilder.Build();
            connectionString = root.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
        }

        public string GetConnectionString()
        {
            return this.connectionString;
        }
    }
}
