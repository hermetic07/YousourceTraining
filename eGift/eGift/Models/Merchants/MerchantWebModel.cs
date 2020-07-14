namespace Api.Models.Products
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// Web Models directly map to the JSON passed to the API and should contain necessary JsonProperty mappings.
    /// </summary>
    public class ProductWebModel
    {
        [JsonProperty("productId")]
        public Guid ProductId { get; set; }

        [JsonProperty("productName")]
        public string ProductName { get; set; }

        [JsonProperty("merchantId")]
        public Guid MerchantId { get; set; }

        [JsonProperty("merchantName")]
        public string MerchantName { get; set; }
    }
}