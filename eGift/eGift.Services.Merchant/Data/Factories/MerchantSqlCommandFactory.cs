namespace eGift.Services.Merchant.Data.Factories
{
    using System.Data;
    using System.Data.SqlClient;
    using eGift.Services.Merchant.Data.Entities;

    /// <summary>
    /// Sql Command Factories remove responsibility from the Data Gateways by creating SqlCommands to be executed.
    /// This includes but not limited to: Setting the Command Name, Parameters, and Etc.
    /// </summary>
    public class MerchantSqlCommandFactory : IMerchantSqlCommandFactory
    {
        public SqlCommand CreateGetMerchantsCommand()
        {
            var result = new SqlCommand("sp_GetMerchants")
            {
                CommandTimeout = 30,
                CommandType = CommandType.StoredProcedure
            };

            return result;
        }

        public SqlCommand CreateGetMerchantCommand(MerchantEntity merchant)
        {
            var result = new SqlCommand("sp_GetMerchant")
            {
                CommandTimeout = 30,
                CommandType = CommandType.StoredProcedure
            };

            result.Parameters.AddWithValue("@id", merchant.MerchantId);

            return result;
        }
    }
}