namespace eGift.Services.Product.Data.Entities
{
    using System;

    public class ProductEntity
    {
        public Guid ProductId { get; set; }

        public int MerchantId { get; set; }

        public string ProductName { get; set; }
    }
}
