namespace Egift.Services.Order.Messages
{
    using System.Runtime.Serialization;
    using Egift.Services.Order.Models;

    [DataContract]
    public class GetOrderRequest
    {
        [DataMember]
        public Order Order { get; set; }
    }
}
