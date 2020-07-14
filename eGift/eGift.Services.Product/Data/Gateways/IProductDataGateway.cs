namespace Egift.Services.Product.Data.Gateways
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Egift.Services.Product.Data.Entities;

    public interface IProductDataGateway
    {
        Task InsertProductAsync(ProductEntity product);

        Task<List<ProductEntity>> GetProductsAsync();

        Task<ProductEntity> GetProductAsync(ProductEntity product);
    }
}
