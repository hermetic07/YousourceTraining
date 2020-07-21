namespace EGift.Services.Email.Exceptions
{
    using System;

    public class EmailSendingException : Exception
    {
        public EmailSendingException(Exception innerException) : base(string.Empty, innerException)
        {
        }
    }
}
