namespace Egift.Services.Order.Models
{
    using System;
    using System.Runtime.Serialization;

    public class Order
    {
        [DataMember]
        public Guid OrderId { get; set; }
        [DataMember]
        public Guid ProductId { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public string MerchantName { get; set; }

        [DataMember]
        public Guid MerchantId { get; set; }

        [DataMember]
        public string SenderName { get; set; }

        [DataMember]
        public string SenderEmail { get; set; }

        [DataMember]
        public string RecipientName { get; set; }

        [DataMember]
        public string RecipientEmail { get; set; }

        [DataMember]
        public int OrderQuantity { get; set; }

        [DataMember]
        public decimal OrderTotal { get; set; }
    }
}
