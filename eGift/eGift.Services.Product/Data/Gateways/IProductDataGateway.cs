namespace Egift.Services.Product.Data.Gateways
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Egift.Services.Product.Data.Entities;

    public interface IProductDataGateway
    {
        Task<List<ProductEntity>> GetProductsAsync(ProductEntity product);

        Task<ProductEntity> GetProductAsync(ProductEntity product);
    }
}
