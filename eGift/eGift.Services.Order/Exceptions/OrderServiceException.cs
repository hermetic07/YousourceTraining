namespace eGift.Services.Order.Exceptions
{
    using System;

    public class OrderServiceException : Exception
    {
        public OrderServiceException(Exception innerException) : base(string.Empty, innerException)
        {
        }
    }
}