namespace eGift.Services.Product.Data.Entities
{
    using System;

    public class ProductEntity
    {
        public Guid ProductId { get; set; }

        public Guid MerchantId { get; set; }

        public string ProductName { get; set; }
    }
}
