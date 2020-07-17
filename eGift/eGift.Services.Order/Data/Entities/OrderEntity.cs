namespace Egift.Services.Order.Data.Entities
{
    using System;

    public class OrderEntity
    {
        public Guid OrderId { get; set; }

        public Guid ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }

        public Guid MerchantId { get; set; }

        public string MerchantName { get; set; }

        public string SenderName { get; set; }

        public string SenderEmail { get; set; }

        public string RecipientName { get; set; }

        public string RecipientEmail { get; set; }

        public int OrderQuantity { get; set; }

        public DateTime OrderDate { get; set; }

        public string OrderMessage { get; set; }
    }
}
