namespace eGift.Services.Merchant.Data.Gateways
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using eGift.Services.Merchant.Data.Entities;

    public interface IMerchantDataGateway
    {
        Task<List<MerchantEntity>> GetMerchantsAsync();

        Task<MerchantEntity> GetMerchantAsync(MerchantEntity merchant);
    }
}
