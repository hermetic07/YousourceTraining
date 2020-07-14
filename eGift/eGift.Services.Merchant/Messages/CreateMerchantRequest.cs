namespace Egift.Services.Merchant.Messages
{
    using System.Runtime.Serialization;
    using Models;

    [DataContract]
    public class CreateMerchantRequest
    {
        [DataMember]
        public Merchant Merchant { get; set; }
    }
}
