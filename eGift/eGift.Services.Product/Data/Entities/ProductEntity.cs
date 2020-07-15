namespace Egift.Services.Product.Data.Entities
{
    using System;

    public class ProductEntity
    {
        public Guid ProductId { get; set; }

        public string ProductName { get; set; }

        public Guid MerchantId { get; set; }

        public string MerchantName { get; set; }

        public decimal ProductPrice { get; set; }
    }
}
