namespace Egift.Services.Order.Data.Gateways
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Egift.Infrastructure.Helpers;
    using Egift.Services.Order.Data.Entities;
    using Egift.Services.Order.Data.Factories;
    using Egift.Services.Order.Exceptions;
    using Microsoft.Extensions.Logging;

    public class OrderDataGateway : IOrderDataGateway
    {
        private readonly ISqlHelper helper;
        private readonly IOrderSqlCommandFactory factory;
        private readonly ILogger<OrderDataException> logger;

        public OrderDataGateway(IOrderSqlCommandFactory factory, ISqlHelper helper, ILogger<OrderDataException> logger)
        {
            this.factory = factory;
            this.helper = helper;
            this.logger = logger;
        }

        public async Task InsertOrderAsync(OrderEntity order)
        {
            try
            {
                var command = this.factory.CreateInsertOrderCommand(order);
                await this.helper.ExecuteAsync(command);
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex.Message);
                throw new OrderDataException(ex);
            }
        }

        public async Task<List<OrderEntity>> GetOrdersAsync()
        {
            try
            {
                var command = this.factory.CreateGetOrdersCommand();
                var result = await this.helper.ReadAsListAsync<OrderEntity>(command);

                return result;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex.Message);
                throw new OrderDataException(ex);
            }
        }

        public async Task<OrderEntity> GetOrderAsync(OrderEntity order)
        {
            try
            {
                var command = this.factory.CreateGetOrderCommand(order);
                var result = await this.helper.ReadAsync<OrderEntity>(command);

                return result;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex.Message);
                throw new OrderDataException(ex);
            }
        }
    }
}
