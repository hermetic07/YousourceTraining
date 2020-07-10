namespace eGift.Services.Product.Extensions
{
    using eGift.Services.Product.Models;
    using eGift.Services.Product.Data.Entities;

    /// <summary>
    /// Extension methods can be used to convert Models from One Assembly to Another
    /// Typically, Web Requests are Model classes that belong to the Api project and is ought to be
    /// Converted into Service Model classes via Extension methods. 
    /// In this way, models are decoupled. This is an intentional code repetition.
    /// </summary>
    public static class ProductExtensions
    {
        public static ProductEntity AsEntity(this Product product)
        {
            var result = new ProductEntity
            {
                ProductName = product.ProductName,
                ProductId = product.ProductId,
                MerchantId = product.MerchantId
            };

            return result;
        }
    }
}