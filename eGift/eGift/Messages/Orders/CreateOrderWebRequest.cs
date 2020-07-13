namespace Api.Messages.Order
{
    using Newtonsoft.Json;
    using eGift.Services.Order.Models;

    /// <summary>
    /// Web Models directly map to the JSON passed to the API and should contain necessary JsonProperty mappings.
    /// </summary>
    public class CreateOrderWebRequest
    {
        [JsonProperty("data")]
        public Order Data { get; set; }
    }
}
