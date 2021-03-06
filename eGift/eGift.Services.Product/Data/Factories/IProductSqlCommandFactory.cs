﻿namespace Egift.Services.Product.Data.Factories
{
    using System.Data.SqlClient;
    using Egift.Services.Product.Data.Entities;

    public interface IProductSqlCommandFactory
    {
        SqlCommand CreateInsertProductCommand(ProductEntity product);

        SqlCommand CreateGetProductsCommand(ProductEntity product);

        SqlCommand CreateGetProductCommand(ProductEntity product);
    }
}