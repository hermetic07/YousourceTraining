namespace eGift.Services.Merchant.Data.Factories
{
    using System.Data.SqlClient;
    using eGift.Services.Merchant.Data.Entities;

    public interface IMerchantSqlCommandFactory
    {
        SqlCommand CreateGetMerchantsCommand();

        SqlCommand CreateGetMerchantCommand(MerchantEntity merchant);
    }
}

