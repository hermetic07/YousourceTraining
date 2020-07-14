namespace Egift.Services.Merchant.Data.Factories
{
    using System.Data.SqlClient;
    using Egift.Services.Merchant.Data.Entities;

    public interface IMerchantSqlCommandFactory
    {
        SqlCommand CreateGetMerchantsCommand();

        SqlCommand CreateGetMerchantCommand(MerchantEntity merchant);
    }
}
