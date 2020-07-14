namespace Egift.Services.Merchant.Extensions
{
    using System.Collections.Generic;
    using System.Linq;
    using Egift.Services.Merchant.Data.Entities;
    using Egift.Services.Merchant.Models;

    /// <summary>
    /// Extension methods can be used to convert Models from One Assembly to Another
    /// Typically, Web Requests are Model classes that belong to the Api project and is ought to be
    /// Converted into Service Model classes via Extension methods. 
    /// In this way, models are decoupled. This is an intentional code repetition.
    /// </summary>
    public static class MerchantExtensions
    {
        public static MerchantEntity AsEntity(this Merchant merchant)
        {
            var result = new MerchantEntity
            {
                MerchantId = merchant.MerchantId,
                MerchantName = merchant.MerchantName,
            };

            return result;
        }

        public static Merchant AsResponse(this MerchantEntity merchant)
        {
            var result = new Merchant
            {
                MerchantId = merchant.MerchantId,
                MerchantName = merchant.MerchantName,
            };

            return result;
        }

        public static List<Merchant> AsResponseList(this List<MerchantEntity> merchants)
        {
            var result = (from merchant in merchants
                           select new Merchant
                           {
                               MerchantId = merchant.MerchantId,
                               MerchantName = merchant.MerchantName,
                           }).ToList();

            return result;
        }
    }
}