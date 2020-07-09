namespace eGift.Services.Product.Data.Gateways
{
    using System.Threading.Tasks;
    using eGift.Services.Product.Data.Entities;

    public interface IProductDataGateway
    {
        Task InsertProductAsync(ProductEntity product);
    }
}
