namespace Egift.Services.Merchant
{
    using System;
    using System.Threading.Tasks;
    using Egift.Services.Merchant.Data.Gateways;
    using Egift.Services.Merchant.Exceptions;
    using Egift.Services.Merchant.Extensions;
    using Egift.Services.Merchant.Messages;

    public class MerchantService : IMerchantService
    {
        private readonly IMerchantDataGateway gateway;

        public MerchantService(IMerchantDataGateway gateway)
        {
            this.gateway = gateway;
        }

        public async Task<GetMerchantResponse> GetMerchantAsync(GetMerchantRequest request)
        {
            var response = new GetMerchantResponse { Code = 200 };

            try
            {
                var result = await this.gateway.GetMerchantAsync(request.Merchant.AsEntity());

                response.Merchant = result.AsResponse();
            }
            catch (Exception ex)
            {
                throw new MerchantServiceException(ex);
            }

            return response;
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
                throw new MerchantServiceException(ex);
            }

            return response;
        }
    }
}
