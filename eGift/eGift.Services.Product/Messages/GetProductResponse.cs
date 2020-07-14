namespace Egift.Services.Product.Messages
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Models;

    [DataContract]
    public class GetProductResponse : Response
    {
        [DataMember]
        public Product Product { get; set; }
    }
}