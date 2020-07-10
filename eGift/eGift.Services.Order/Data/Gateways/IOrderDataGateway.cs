namespace eGift.Services.Order.Data.Gateways
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using eGift.Services.Order.Data.Entities;

    public interface IOrderDataGateway
    {
        Task InsertOrderAsync(OrderEntity product);

        Task<List<OrderEntity>> GetOrdersAsync();

        Task<OrderEntity> GetOrderAsync(OrderEntity product);
    }
}
