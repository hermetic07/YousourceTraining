namespace Egift.Services.Merchant.Data.Gateways
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Egift.Infrastructure.Helpers;
    using Egift.Services.Merchant.Data.Entities;
    using Egift.Services.Merchant.Data.Factories;
    using Egift.Services.Merchant.Exceptions;
    using Microsoft.Extensions.Logging;

    public class MerchantDataGateway : IMerchantDataGateway
    {
        private readonly ISqlHelper helper;
        private readonly IMerchantSqlCommandFactory factory;
        private readonly ILogger<MerchantDataException> logger;

        public MerchantDataGateway(IMerchantSqlCommandFactory factory, ISqlHelper helper, ILogger<MerchantDataException> logger)
        {
            this.factory = factory;
            this.helper = helper;
            this.logger = logger;
        }

        public async Task<List<MerchantEntity>> GetMerchantsAsync()
        {
            try
            {
                var command = this.factory.CreateGetMerchantsCommand();
                var result = await this.helper.ReadAsListAsync<MerchantEntity>(command);

                return result;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex.Message);
                throw new MerchantDataException(ex);
            }
        }

        public async Task<MerchantEntity> GetMerchantAsync(MerchantEntity merchant)
        {
            try
            {
                var command = this.factory.CreateGetMerchantCommand(merchant);
                var result = await this.helper.ReadAsync<MerchantEntity>(command);

                return result;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex.Message);
                throw new MerchantDataException(ex);
            }
        }
    }
}
