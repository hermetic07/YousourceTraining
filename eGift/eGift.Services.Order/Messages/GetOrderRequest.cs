namespace eGift.Services.Order.Messages
{
    using System.Runtime.Serialization;
    using eGift.Services.Order.Models;

    [DataContract]
    public class GetOrderRequest
    {
        [DataMember]
        public Order Order { get; set; }
    }
}
