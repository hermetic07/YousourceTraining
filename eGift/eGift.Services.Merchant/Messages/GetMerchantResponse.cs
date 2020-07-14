namespace Egift.Services.Merchant.Messages
{
    using System.Runtime.Serialization;
    using Models;

    [DataContract]
    public class GetMerchantResponse : Response
    {
        [DataMember]
        public Merchant Merchant { get; set; }
    }
}