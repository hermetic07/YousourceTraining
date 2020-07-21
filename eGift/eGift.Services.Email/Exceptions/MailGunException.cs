namespace EGift.Services.Email.Exceptions
{
    using System;

    public class MailGunException : Exception
    {
        public MailGunException(Exception innerException) : base(string.Empty, innerException)
        {
        }
    }
}
