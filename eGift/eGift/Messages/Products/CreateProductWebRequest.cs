namespace Api.Messages.Products
{
    using Newtonsoft.Json;
    using eGift.Services.Product.Models;

    /// <summary>
    /// Web Models directly map to the JSON passed to the API and should contain necessary JsonProperty mappings.
    /// </summary>
    public class CreateProductWebRequest
    {
        [JsonProperty("data")]
        public Product Data { get; set; }
    }
}
