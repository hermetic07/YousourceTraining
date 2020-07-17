namespace Egift.Services.Product
{
    using System;
    using System.Threading.Tasks;
    using Egift.Services.Product.Data.Gateways;
    using Egift.Services.Product.Exceptions;
    using Egift.Services.Product.Extensions;
    using Egift.Services.Product.Messages;
    using Microsoft.Extensions.Logging;

    public class ProductService : IProductService
    {
        private readonly IProductDataGateway gateway;
        private readonly ILogger<ProductServiceException> logger;

        public ProductService(IProductDataGateway gateway, ILogger<ProductServiceException> logger)
        {
            this.gateway = gateway;
            this.logger = logger;
        }

        public async Task<GetProductResponse> GetProductAsync(GetProductRequest request)
        {
            var response = new GetProductResponse { Code = 200 };

            try
            {
                var result = await this.gateway.GetProductAsync(request.Product.AsEntity());

                response.Product = result.AsResponse();
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex.Message);
                response.Code = 500;
            }

            return response;
        }

        public async Task<GetProductsResponse> GetProductsAsync(GetProductRequest request)
        {
            var response = new GetProductsResponse { Code = 200 };

            try
            {
                var result = await this.gateway.GetProductsAsync(request.Product.AsEntity());

                response.Products = result.AsResponseList();
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex.Message);
                response.Code = 500;
            }

            return response;
        }
    }
}
