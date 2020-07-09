namespace eGift.Services.Product.Data.Factories
{
    using System.Data.SqlClient;
    using eGift.Services.Product.Data.Entities;

    public interface IProductSqlCommandFactory
    {
        SqlCommand CreateInsertProductCommand(ProductEntity product);
    }
}

