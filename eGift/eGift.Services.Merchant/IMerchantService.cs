namespace eGift.Services.Merchant
{
    using System.Threading.Tasks;
    using eGift.Services.Merchant.Messages;

    public interface IMerchantService
    {
        Task<GetMerchantsResponse> GetMerchantsAsync();

        Task<GetMerchantResponse> GetMerchantAsync(GetMerchantRequest request);
    }
}
