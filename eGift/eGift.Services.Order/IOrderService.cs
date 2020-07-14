namespace Egift.Services.Order
{
    using System.Threading.Tasks;
    using Egift.Services.Order.Messages;

    public interface IOrderService
    {
        Task<CreateOrderResponse> CreateOrderAsync(CreateOrderRequest request);

        Task<GetOrdersResponse> GetOrdersAsync();

        Task<GetOrderResponse> GetOrderAsync(GetOrderRequest request);
    }
}
