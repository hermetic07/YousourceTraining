namespace Egift.Services.Merchant
{
    using System;
    using System.Threading.Tasks;
    using Egift.Services.Merchant.Data.Gateways;
    using Egift.Services.Merchant.Exceptions;
    using Egift.Services.Merchant.Extensions;
    using Egift.Services.Merchant.Messages;
    using Microsoft.Extensions.Logging;

    public class MerchantService : IMerchantService
    {
        private readonly IMerchantDataGateway gateway;
        private readonly ILogger<MerchantServiceException> logger;

        public MerchantService(IMerchantDataGateway gateway, ILogger<MerchantServiceException> logger)
        {
            this.gateway = gateway;
            this.logger = logger;
        }

        public async Task<GetMerchantsResponse> GetMerchantsAsync()
        {
            var response = new GetMerchantsResponse { Code = 200 };

            try
            {
                var result = await this.gateway.GetMerchantsAsync();

                response.Merchants = result.AsResponseList();
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
