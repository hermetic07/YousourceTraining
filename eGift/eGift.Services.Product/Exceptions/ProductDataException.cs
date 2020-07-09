namespace eGift.Services.Product.Exceptions
{
    using System;

    public class ProductDataException : Exception
    {
        public ProductDataException(Exception innerException) : base(string.Empty, innerException)
        {
        }
    }
}
