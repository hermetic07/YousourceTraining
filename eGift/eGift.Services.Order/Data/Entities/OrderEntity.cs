﻿namespace eGift.Services.Order.Data.Entities
{
    using System;

    public class OrderEntity
    {
        public Guid OrderId { get; set; }

        public Guid ProductId { get; set; }

        public string ProductName { get; set; }

        public Guid MerchantId { get; set; }

        public string MerchantName { get; set; }

        public string SenderName { get; set; }

        public string SenderEmail { get; set; }

        public string RecipientName { get; set; }

        public string RecipientEmail { get; set; }
    }
}