﻿namespace Api.Extensions
{
    using Api.Messages.Products;
    using Egift.Services.Product.Messages;
    using Egift.Services.Product.Models;

    /// <summary>
    /// Extension methods can be used to convert Models from One Assembly to Another
    /// Typically, Web Requests are Model classes that belong to the Api project and is ought to be
    /// Converted into Service Model classes via Extension methods. 
    /// In this way, models are decoupled. This is an intentional code repetition.
    /// </summary>
    public static class ProductExtensions
    {
        public static GetProductRequest AsRequest(this GetProductWebRequest request)
        {
            var result = new GetProductRequest
            {
                Product = new Product
                {
                    ProductId = request.Data.ProductId,
                    MerchantId = request.Data.MerchantId
                }
            };

            return result;
        }
    }
}
