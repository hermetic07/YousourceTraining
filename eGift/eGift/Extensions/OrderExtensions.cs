namespace Egift.Api.Extensions
{
    using Egift.Api.Messages.Order;
    using Egift.Services.Order.Messages;
    using Egift.Services.Order.Models;

    /// <summary>
    /// Extension methods can be used to convert Models from One Assembly to Another
    /// Typically, Web Requests are Model classes that belong to the Api project and is ought to be
    /// Converted into Service Model classes via Extension methods. 
    /// In this way, models are decoupled. This is an intentional code repetition.
    /// </summary>
    public static class OrderExtensions
    {
        public static CreateOrderRequest AsRequest(this CreateOrderWebRequest request)
        {
            var result = new CreateOrderRequest
            {
                Order = new Order
                {
                    ProductId = request.Data.ProductId,
                    SenderEmail = request.Data.SenderEmail,
                    SenderName = request.Data.SenderName,
                    RecipientEmail = request.Data.RecipientEmail,
                    RecipientName = request.Data.RecipientName,
                    OrderQuantity = request.Data.OrderQuantity,
                    OrderTotal = request.Data.OrderTotal
                }
            };

            return result;
        }

        public static GetOrderRequest AsRequest(this GetOrderWebRequest request)
        {
            var result = new GetOrderRequest
            {
                Order = new Order
                {
                    OrderId = request.Data.OrderId
                }
            };

            return result;
        }
    }
}
