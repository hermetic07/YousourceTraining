﻿namespace eGift.Services.Product.Models
{
    using System;
    using System.Runtime.Serialization;

    public class Product
    {
        [DataMember]
        public Guid ProductId { get; set; }

        [DataMember]
        public int MerchantId { get; set; }

        [DataMember]
        public string ProductName { get; set; }
    }
}