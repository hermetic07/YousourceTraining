﻿namespace Egift.Services.Product.Extensions
{
    using System.Collections.Generic;
    using System.Linq;
    using Egift.Services.Product.Data.Entities;
    using Egift.Services.Product.Models;

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

        public static Product AsResponse(this ProductEntity product)
        {
            var result = new Product
            {
                MerchantId = product.MerchantId,
                MerchantName = product.MerchantName,
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                ProductPrice = product.ProductPrice
            };

            return result;
        }

        public static List<Product> AsResponseList(this List<ProductEntity> products)
        {
            var result = (from product in products
                          select new Product
                          {
                              MerchantId = product.MerchantId,
                              MerchantName = product.MerchantName,
                              ProductId = product.ProductId,
                              ProductName = product.ProductName,
                              ProductPrice = product.ProductPrice
                          }).ToList();

            return result;
        }
    }
}