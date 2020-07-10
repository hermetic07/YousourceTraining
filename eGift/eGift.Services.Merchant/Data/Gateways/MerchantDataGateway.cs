namespace eGift.Services.Merchant.Data.Gateways
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using eGift.Infrastructure.Helpers;
    using eGift.Services.Merchant.Data.Entities;
    using eGift.Services.Merchant.Data.Factories;
    using eGift.Services.Merchant.Exceptions;

    public class MerchantDataGateway : IMerchantDataGateway
    {
        private readonly ISqlHelper helper;
        private readonly IMerchantSqlCommandFactory factory;

        public MerchantDataGateway(IMerchantSqlCommandFactory factory, ISqlHelper helper)
        {
            this.factory = factory;
            this.helper = helper;
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
                //// You may catch other "expected" exceptions in a different catch block; You may also set Error Codes to your response respectively
                //// Always catch unexpected exceptions and wrap them as a Layer exception - Data Exception in this case
                //// Log your errors e.g. to ApplicationInsights
                //// this.logger.Log(ex);
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
                //// You may catch other "expected" exceptions in a different catch block; You may also set Error Codes to your response respectively
                //// Always catch unexpected exceptions and wrap them as a Layer exception - Data Exception in this case
                //// Log your errors e.g. to ApplicationInsights
                //// this.logger.Log(ex);
                throw new MerchantDataException(ex);
            }
        }
    }
}
