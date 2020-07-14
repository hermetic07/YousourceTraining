namespace Egift.Services.Product.Messages
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Models;

    [DataContract]
    public class GetProductsResponse : Response
    {
        [DataMember]
        public List<Product> Products { get; set; }
    }
}
