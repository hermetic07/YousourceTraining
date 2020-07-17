namespace Egift.Services.Product.Data.Gateways
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Egift.Infrastructure.Helpers;
    using Egift.Services.Product.Data.Entities;
    using Egift.Services.Product.Data.Factories;
    using Egift.Services.Product.Exceptions;
    using Microsoft.Extensions.Logging;

    public class ProductDataGateway : IProductDataGateway
    {
        private readonly ISqlHelper helper;
        private readonly IProductSqlCommandFactory factory;
        private readonly ILogger<ProductDataException> logger;

        public ProductDataGateway(IProductSqlCommandFactory factory, ISqlHelper helper, ILogger<ProductDataException> logger)
        {
            this.factory = factory;
            this.helper = helper;
            this.logger = logger;
        }

        public async Task<List<ProductEntity>> GetProductsAsync(ProductEntity product)
        {
            try
            {
                var command = this.factory.CreateGetProductsCommand(product);
                var result = await this.helper.ReadAsListAsync<ProductEntity>(command);

                return result;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex.Message);
                throw new ProductDataException(ex);
            }
        }

        public async Task<ProductEntity> GetProductAsync(ProductEntity product)
        {
            try
            {
                var command = this.factory.CreateGetProductCommand(product);
                var result = await this.helper.ReadAsync<ProductEntity>(command);

                return result;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex.Message);
                throw new ProductDataException(ex);
            }
        }
    }
}
