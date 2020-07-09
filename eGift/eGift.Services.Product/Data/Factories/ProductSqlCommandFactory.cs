namespace eGift.Services.Product.Data.Factories
{
    using System.Data;
    using System.Data.SqlClient;
    using eGift.Services.Product.Data.Entities;

    /// <summary>
    /// Sql Command Factories remove responsibility from the Data Gateways by creating SqlCommands to be executed.
    /// This includes but not limited to: Setting the Command Name, Parameters, and Etc.
    /// </summary>
    public class ProductSqlCommandFactory : IProductSqlCommandFactory
    {
        public SqlCommand CreateInsertProductCommand(ProductEntity product)
        {
            var result = new SqlCommand("sp_InsertProduct")
            {
                CommandTimeout = 30,
                CommandType = CommandType.StoredProcedure
            };

            result.Parameters.AddWithValue("@productName", product.ProductName);
            result.Parameters.AddWithValue("@merchantId", product.MerchantId);

            return result;
        }
    }
}