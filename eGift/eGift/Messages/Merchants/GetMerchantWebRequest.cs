namespace Api.Messages.Merchant
{
    using Newtonsoft.Json;
    using eGift.Services.Merchant.Models;

    /// <summary>
    /// Web Models directly map to the JSON passed to the API and should contain necessary JsonProperty mappings.
    /// </summary>
    public class GetMerchantWebRequest
    {
        [JsonProperty("data")]
        public Merchant Data { get; set; }
    }
}
