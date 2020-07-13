namespace eGift.Services.Order
{
    using System;
    using System.Threading.Tasks;
    using eGift.Services.Order.Data.Gateways;
    using eGift.Services.Order.Exceptions;
    using eGift.Services.Order.Extensions;
    using eGift.Services.Order.Messages;

    public class OrderService : IOrderService
    {
        private readonly IOrderDataGateway gateway;

        public OrderService(IOrderDataGateway gateway)
        {
            this.gateway = gateway;
        }

        public async Task<CreateOrderResponse> CreateOrderAsync(CreateOrderRequest request)
        {
            var response = new CreateOrderResponse { Code = 200 };

            try
            {
                //// Do complex stuff here. You may call other design patterns-inspired classes here.
                //// For the most basic stuff, the service class depends on Data Gateways to perform CRUD operations such as this

                await this.gateway.InsertOrderAsync(request.Order.AsEntity());
            }
            catch (Exception ex)
            {
                //// You may catch other "expected" exceptions in a different catch block; You may also set Error Codes to your response respectively
                //// Always catch unexpected exceptions and wrap them as a Layer exception - Service Exception in this case
                //// Log your errors e.g. to ApplicationInsights
                //// this.logger.Log(ex);
                throw new OrderServiceException(ex);
            }

            return response;
        }

        public async Task<GetOrderResponse> GetOrderAsync(GetOrderRequest request)
        {
            var response = new GetOrderResponse { Code = 200 };

            try
            {
                var result = await this.gateway.GetOrderAsync(request.Order.AsEntity());

                response.Order = result.AsResponse();
            }
            catch (Exception ex)
            {
                throw new OrderServiceException(ex);
            }

            return response;
        }

        public async Task<GetOrdersResponse> GetOrdersAsync()
        {
            var response = new GetOrdersResponse { Code = 200 };

            try
            {
                var result = await this.gateway.GetOrdersAsync();

                response.Order = result.AsResponseList();
            }
            catch (Exception ex)
            {
                throw new OrderServiceException(ex);
            }

            return response;
        }
    }
}
