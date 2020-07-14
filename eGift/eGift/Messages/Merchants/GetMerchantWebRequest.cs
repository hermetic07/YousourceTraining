namespace Api.Messages.Merchant
{
    using Api.Models.Products;
    using Newtonsoft.Json;

    /// <summary>
    /// Web Models directly map to the JSON passed to the API and should contain necessary JsonProperty mappings.
    /// </summary>
    public class GetMerchantWebRequest
    {
        [JsonProperty("data")]
        public MerchantWebModel Data { get; set; }
    }
}
