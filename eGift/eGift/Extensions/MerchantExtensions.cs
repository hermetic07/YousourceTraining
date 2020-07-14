namespace Api.Extensions
{
    using Api.Messages.Merchant;
    using Egift.Services.Merchant.Messages;
    using Egift.Services.Merchant.Models;
    using Egift.Services.Product.Messages;
    using Egift.Services.Product.Models;

    /// <summary>
    /// Extension methods can be used to convert Models from One Assembly to Another
    /// Typically, Web Requests are Model classes that belong to the Api project and is ought to be
    /// Converted into Service Model classes via Extension methods. 
    /// In this way, models are decoupled. This is an intentional code repetition.
    /// </summary>
    public static class MerchantExtensions
    {
        public static GetMerchantRequest AsRequest(this GetMerchantWebRequest request)
        {
            var result = new GetMerchantRequest
            {
                Merchant = new Merchant
                {
                    MerchantId = request.Data.MerchantId
                }
            };

            return result;
        }
    }
}
