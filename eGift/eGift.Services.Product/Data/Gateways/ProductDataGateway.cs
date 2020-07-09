namespace eGift.Services.Product.Data.Gateways
{
    using System;
    using System.Threading.Tasks;
    using eGift.Infrastructure.Helpers;
    using eGift.Services.Product.Data.Entities;
    using eGift.Services.Product.Data.Factories;
    using eGift.Services.Product.Exceptions;

    public class ProductDataGateway : IProductDataGateway
    {
        private readonly ISqlHelper helper;
        private readonly IProductSqlCommandFactory factory;

        public ProductDataGateway(IProductSqlCommandFactory factory)
        {
            this.factory = factory;
        }

        public async Task InsertProductAsync(ProductEntity product)
        {
            try
            {
                var command = this.factory.CreateInsertProductCommand(product);
                await this.helper.ExecuteAsync(command);
            }
            catch (Exception ex)
            {
                //// You may catch other "expected" exceptions in a different catch block; You may also set Error Codes to your response respectively
                //// Always catch unexpected exceptions and wrap them as a Layer exception - Data Exception in this case
                //// Log your errors e.g. to ApplicationInsights
                //// this.logger.Log(ex);
                throw new ProductDataException(ex);
            }
        }
    }
}
