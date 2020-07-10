namespace eGift.Services.Product.Messages
{
    using System.Runtime.Serialization;
    using eGift.Services.Product.Models;

    [DataContract]
    public class GetProductRequest
    {
        [DataMember]
        public Product Product { get; set; }
    }
}
