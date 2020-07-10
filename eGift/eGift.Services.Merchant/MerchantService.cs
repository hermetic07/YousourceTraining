namespace eGift.Services.Merchant
{
    using System;
    using System.Threading.Tasks;
    using eGift.Services.Merchant.Data.Gateways;
    using eGift.Services.Merchant.Exceptions;
    using eGift.Services.Merchant.Extensions;
    using eGift.Services.Merchant.Messages;

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
