namespace Egift.Infrastructure.Providers
{
    using System.IO;
    using Microsoft.Extensions.Configuration;

    public class ConnectionStringProvider : IConnectionStringProvider
    {
        public readonly string ConnectionString = string.Empty;

        public ConnectionStringProvider()
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);

            var root = configurationBuilder.Build();
            this.ConnectionString = root.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
        }

        public string GetConnectionString()
        {
            return this.ConnectionString;
        }
    }
}
