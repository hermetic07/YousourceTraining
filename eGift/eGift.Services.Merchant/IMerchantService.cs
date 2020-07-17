namespace Egift.Services.Merchant
{
    using System.Threading.Tasks;
    using Egift.Services.Merchant.Messages;

    public interface IMerchantService
    {
        Task<GetMerchantsResponse> GetMerchantsAsync();
    }
}
