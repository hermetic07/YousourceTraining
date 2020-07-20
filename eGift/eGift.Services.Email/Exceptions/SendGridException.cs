using System;
using System.Collections.Generic;
using System.Text;

namespace EGift.Services.Email.Exceptions
{
    public class SendGridException : Exception
    {
        public SendGridException(Exception innerException) : base(string.Empty, innerException)
        {
        }
    }
}
