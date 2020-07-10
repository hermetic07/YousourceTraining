namespace eGift.Services.Order.Messages
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Models;

    [DataContract]
    public class GetOrderResponse : Response
    {
        [DataMember]
        public Order Order { get; set; }
    }
}

