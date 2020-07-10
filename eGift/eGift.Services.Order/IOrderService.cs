namespace eGift.Services.Order
{
    using System.Threading.Tasks;
    using eGift.Services.Order.Messages;

    public interface IOrderService
    {
        Task<CreateOrderResponse> CreateProductAsync(CreateOrderRequest request);

        Task<GetOrdersResponse> GetProductsAsync();

        Task<GetOrderResponse> GetProductAsync(GetOrderRequest request);
    }
}
