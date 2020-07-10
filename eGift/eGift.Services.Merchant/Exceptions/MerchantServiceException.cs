namespace eGift.Services.Merchant.Exceptions
{
    using System;

    public class MerchantServiceException : Exception
    {
        public MerchantServiceException(Exception innerException) : base(string.Empty, innerException)
        {
        }
    }
}