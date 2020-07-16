namespace Egift.Api.Models.Orders
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// Web Models directly map to the JSON passed to the API and should contain necessary JsonProperty mappings.
    /// </summary>
    public class OrderWebModel
    {
        [JsonProperty("orderId")]
        public Guid OrderId { get; set; }

        [JsonProperty("productId")]
        public Guid ProductId { get; set; }

        [JsonProperty("senderName")]
        public string SenderName { get; set; }

        [JsonProperty("senderEmail")]
        public string SenderEmail { get; set; }

        [JsonProperty("recipientName")]
        public string RecipientName { get; set; }

        [JsonProperty("recipientEmail")]
        public string RecipientEmail { get; set; }

        [JsonProperty("orderQuantity")]
        public int OrderQuantity { get; set; }

        [JsonProperty("orderTotal")]
        public decimal OrderTotal { get; set; }
    }
}
