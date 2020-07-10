namespace eGift.Services.Order.Messages
{
    using System.Runtime.Serialization;
    using Models;

    [DataContract]
    public class CreateOrderRequest
    {
        [DataMember]
        public Order Order { get; set; }
    }
}
