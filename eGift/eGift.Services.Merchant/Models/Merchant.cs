namespace eGift.Services.Merchant.Models
{
    using System;
    using System.Runtime.Serialization;

    public class Merchant
    {
        [DataMember]
        public Guid MerchantId { get; set; }

        [DataMember]
        public string MerchantName { get; set; }
    }
}
