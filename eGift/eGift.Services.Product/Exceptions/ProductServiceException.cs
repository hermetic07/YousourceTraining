namespace eGift.Services.Product.Exceptions
{
    using System;

    public class ProductServiceException : Exception
    {
        public ProductServiceException(Exception innerException) : base(string.Empty, innerException)
        {
        }
    }
}