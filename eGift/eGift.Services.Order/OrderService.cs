namespace Egift.Services.Order
{
    using System;
    using System.Threading.Tasks;
    using Egift.Services.Order.Data.Gateways;
    using Egift.Services.Order.Exceptions;
    using Egift.Services.Order.Extensions;
    using Egift.Services.Order.Messages;
    using EGift.Services.Email;
    using Microsoft.Extensions.Logging;

    public class OrderService : IOrderService
    {
        private readonly IOrderDataGateway gateway;
        private readonly IEmailSender emailSender;
        private readonly ILogger<OrderServiceException> logger;

        public OrderService(IOrderDataGateway gateway, ILogger<OrderServiceException> logger, IEmailSender emailSender)
        {
            this.gateway = gateway;
            this.emailSender = emailSender;
            this.logger = logger;
        }

        public async Task<CreateOrderResponse> CreateOrderAsync(CreateOrderRequest request)
        {
            var response = new CreateOrderResponse { Code = 200 };

            try
            {
                await this.gateway.InsertOrderAsync(request.Order.AsEntity());
                await this.emailSender.SendEmail(request.Order.AsSenderEmail());
                await this.emailSender.SendEmail(request.Order.AsRecipientEmail());
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex.Message);
                response.Code = 500;
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
                this.logger.LogError(ex.Message);
                response.Code = 500;
            }

            return response;
        }

        public async Task<GetOrdersResponse> GetOrdersAsync()
        {
            var response = new GetOrdersResponse { Code = 200 };

            try
            {
                var result = await this.gateway.GetOrdersAsync();

                response.Orders = result.AsResponseList();
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex.Message);
                response.Code = 500;
            }

            return response;
        }
    }
}
