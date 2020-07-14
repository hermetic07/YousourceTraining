namespace Egift.Services.Order.Data.Gateways
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Egift.Infrastructure.Helpers;
    using Egift.Services.Order.Data.Entities;
    using Egift.Services.Order.Data.Factories;
    using Egift.Services.Order.Exceptions;

    public class OrderDataGateway : IOrderDataGateway
    {
        private readonly ISqlHelper helper;
        private readonly IOrderSqlCommandFactory factory;

        public OrderDataGateway(IOrderSqlCommandFactory factory, ISqlHelper helper)
        {
            this.factory = factory;
            this.helper = helper;
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
                //// You may catch other "expected" exceptions in a different catch block; You may also set Error Codes to your response respectively
                //// Always catch unexpected exceptions and wrap them as a Layer exception - Data Exception in this case
                //// Log your errors e.g. to ApplicationInsights
                //// this.logger.Log(ex);
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
                //// You may catch other "expected" exceptions in a different catch block; You may also set Error Codes to your response respectively
                //// Always catch unexpected exceptions and wrap them as a Layer exception - Data Exception in this case
                //// Log your errors e.g. to ApplicationInsights
                //// this.logger.Log(ex);
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
                //// You may catch other "expected" exceptions in a different catch block; You may also set Error Codes to your response respectively
                //// Always catch unexpected exceptions and wrap them as a Layer exception - Data Exception in this case
                //// Log your errors e.g. to ApplicationInsights
                //// this.logger.Log(ex);
                throw new OrderDataException(ex);
            }
        }
    }
}
