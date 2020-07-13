namespace eGift.Services.Order
{
    using System.Threading.Tasks;
    using eGift.Services.Order.Messages;

    public interface IOrderService
    {
        Task<CreateOrderResponse> CreateOrderAsync(CreateOrderRequest request);

        Task<GetOrdersResponse> GetOrdersAsync();

        Task<GetOrderResponse> GetOrderAsync(GetOrderRequest request);
    }
}
