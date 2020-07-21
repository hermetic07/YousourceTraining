namespace Egift.Services.Order.Extensions
{
    using System.Collections.Generic;
    using System.Linq;
    using Egift.Services.Email;
    using Egift.Services.Email.Models;
    using Egift.Services.Order.Data.Entities;
    using Egift.Services.Order.Models;

    /// <summary>
    /// Extension methods can be used to convert Models from One Assembly to Another
    /// Typically, Web Requests are Model classes that belong to the Api project and is ought to be
    /// Converted into Service Model classes via Extension methods. 
    /// In this way, models are decoupled. This is an intentional code repetition.
    /// </summary>
    public static class OrderExtensions
    {
        public static OrderEntity AsEntity(this Order order)
        {
            var result = new OrderEntity
            {
                OrderId = order.OrderId,
                ProductId = order.ProductId,
                MerchantId = order.MerchantId,
                SenderName = order.SenderName,
                SenderEmail = order.SenderEmail,
                RecipientEmail = order.RecipientEmail,
                RecipientName = order.RecipientName,
                OrderQuantity = order.OrderQuantity,
                OrderMessage = order.OrderMessage,
            };

            return result;
        }

        public static Order AsResponse(this OrderEntity order)
        {
            var result = new Order
            {
                OrderId = order.OrderId,
                ProductId = order.ProductId,
                ProductName = order.ProductName,
                ProductPrice = order.ProductPrice,
                MerchantId = order.MerchantId,
                MerchantName = order.MerchantName,
                SenderName = order.SenderName,
                SenderEmail = order.SenderEmail,
                RecipientEmail = order.RecipientEmail,
                RecipientName = order.RecipientName,
                OrderQuantity = order.OrderQuantity,
                OrderMessage = order.OrderMessage,
                OrderDate = order.OrderDate
            };

            return result;
        }

        public static List<Order> AsResponseList(this List<OrderEntity> orders)
        {
            var result = (from order in orders
                            select new Order
                            {
                                OrderId = order.OrderId,
                                ProductId = order.ProductId,
                                ProductName = order.ProductName,
                                ProductPrice = order.ProductPrice,
                                MerchantId = order.MerchantId,
                                MerchantName = order.MerchantName,
                                SenderName = order.SenderName,
                                SenderEmail = order.SenderEmail,
                                RecipientEmail = order.RecipientEmail,
                                RecipientName = order.RecipientName,
                                OrderQuantity = order.OrderQuantity,
                                OrderMessage = order.OrderMessage,
                                OrderDate = order.OrderDate
                            }).ToList();

            return result;
        }
    }
}