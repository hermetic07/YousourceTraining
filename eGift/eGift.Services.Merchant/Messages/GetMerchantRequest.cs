namespace Egift.Services.Merchant.Messages
{
    using System.Runtime.Serialization;
    using Models;

    [DataContract]
    public class GetMerchantRequest
    {
        [DataMember]
        public Merchant Merchant { get; set; }
    }
}
