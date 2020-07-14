namespace Api.Models.Products
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// Web Models directly map to the JSON passed to the API and should contain necessary JsonProperty mappings.
    /// </summary>
    public class MerchantWebModel
    {
        [JsonProperty("merchantName")]
        public string MerchantName { get; set; }

        [JsonProperty("merchantId")]
        public Guid MerchantId { get; set; }
    }
}
