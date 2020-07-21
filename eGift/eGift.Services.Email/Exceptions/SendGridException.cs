namespace EGift.Services.Email.Exceptions
{
    using System;

    public class SendGridException : Exception
    {
        public SendGridException(Exception innerException) : base(string.Empty, innerException)
        {
        }
    }
}
