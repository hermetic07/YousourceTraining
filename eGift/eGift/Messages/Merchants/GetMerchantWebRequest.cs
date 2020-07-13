namespace Api.Messages.Merchant
{
    using Newtonsoft.Json;
    using Api.Models.Products;

    /// <summary>
    /// Web Models directly map to the JSON passed to the API and should contain necessary JsonProperty mappings.
    /// </summary>
    public class GetMerchantWebRequest
    {
        [JsonProperty("data")]
        public MerchantWebModel Data { get; set; }
    }
}
