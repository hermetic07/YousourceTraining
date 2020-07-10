namespace eGift.Services.Product
{
    using System.Threading.Tasks;
    using eGift.Services.Product.Messages;

    public interface IProductService
    {
        Task<CreateProductResponse> CreateProductAsync(CreateProductRequest request);

        Task<GetProductsResponse> GetProductsAsync();

        Task<GetProductResponse> GetProductAsync(GetProductRequest request);
    }
}
