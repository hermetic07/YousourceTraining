﻿namespace eGift.Services.Merchant.Messages
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using Models;

    [DataContract]
    public class GetMerchantsResponse : Response
    {
        [DataMember]
        public List<Merchant> Merchant { get; set; }
    }
}

