namespace Api.Extensions
{
    using Api.Messages.Products;
    using eGift.Services.Product.Messages;
    using eGift.Services.Product.Models;

    /// <summary>
    /// Extension methods can be used to convert Models from One Assembly to Another
    /// Typically, Web Requests are Model classes that belong to the Api project and is ought to be
    /// Converted into Service Model classes via Extension methods. 
    /// In this way, models are decoupled. This is an intentional code repetition.
    /// </summary>
    public static class ProductExtensions
    {
        public static CreateProductRequest AsRequest(this CreateProductWebRequest request)
        {
            var result = new CreateProductRequest
            {
                Product = new Product
                {
                    MerchantId = request.Data.MerchantId,
                    ProductName = request.Data.ProductName
                }
            };

            return result;
        }
    }
}
