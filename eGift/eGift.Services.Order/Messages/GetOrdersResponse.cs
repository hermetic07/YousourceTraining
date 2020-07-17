namespace Egift.Services.Order.Messages
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Models;

    [DataContract]
    public class GetOrdersResponse : Response
    {
        [DataMember]
        public List<Order> Orders { get; set; }
    }
}
