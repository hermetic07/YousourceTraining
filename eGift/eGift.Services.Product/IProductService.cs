namespace Egift.Services.Product
{
    using System.Threading.Tasks;
    using Egift.Services.Product.Messages;

    public interface IProductService
    {
        Task<GetProductsResponse> GetProductsAsync(GetProductRequest request);

        Task<GetProductResponse> GetProductAsync(GetProductRequest request);
    }
}
