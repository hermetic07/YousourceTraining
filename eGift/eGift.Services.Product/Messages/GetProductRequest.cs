namespace Egift.Services.Product.Messages
{
    using System.Runtime.Serialization;
    using Egift.Services.Product.Models;

    [DataContract]
    public class GetProductRequest
    {
        [DataMember]
        public Product Product { get; set; }
    }
}
