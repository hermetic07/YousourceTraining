namespace eGift.Services.Product
{
    using System;
    using System.Threading.Tasks;
    using eGift.Services.Product.Data.Gateways;
    using eGift.Services.Product.Exceptions;
    using eGift.Services.Product.Extensions;
    using eGift.Services.Product.Messages;

    public class ProductService : IProductService
    {
        private readonly IProductDataGateway gateway;

        public ProductService(IProductDataGateway gateway)
        {
            this.gateway = gateway;
        }

        public async Task<CreateProductResponse> CreateProductAsync(CreateProductRequest request)
        {
            var response = new CreateProductResponse { Code = 200 };

            try
            {
                //// Do complex stuff here. You may call other design patterns-inspired classes here.
                //// For the most basic stuff, the service class depends on Data Gateways to perform CRUD operations such as this

                await this.gateway.InsertProductAsync(request.Product.AsEntity());
            }
            catch (Exception ex)
            {
                //// You may catch other "expected" exceptions in a different catch block; You may also set Error Codes to your response respectively
                //// Always catch unexpected exceptions and wrap them as a Layer exception - Service Exception in this case
                //// Log your errors e.g. to ApplicationInsights
                //// this.logger.Log(ex);
                throw new ProductServiceException(ex);
            }

            return response;
        }
    }
}
