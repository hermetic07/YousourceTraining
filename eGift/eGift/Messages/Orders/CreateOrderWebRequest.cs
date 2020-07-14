namespace Egift.Api.Messages.Order
{
    using Egift.Api.Models.Orders;
    using Newtonsoft.Json;

    /// <summary>
    /// Web Models directly map to the JSON passed to the API and should contain necessary JsonProperty mappings.
    /// </summary>
    public class CreateOrderWebRequest
    {
        [JsonProperty("data")]
        public OrderWebModel Data { get; set; }
    }
}
