namespace Api.Messages.Order
{
    using Newtonsoft.Json;
    using Api.Models.Products;

    /// <summary>
    /// Web Models directly map to the JSON passed to the API and should contain necessary JsonProperty mappings.
    /// </summary>
    public class GetOrderWebRequest
    {
        [JsonProperty("data")]
        public OrderWebModel Data { get; set; }
    }
}
