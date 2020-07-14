namespace Egift.Services.Product.Messages
{
    using System.Runtime.Serialization;
    using Models;

    [DataContract]
    public class CreateProductRequest
    {
        [DataMember]
        public Product Product { get; set; }
    }
}
