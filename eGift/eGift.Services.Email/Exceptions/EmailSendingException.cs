using System;
using System.Collections.Generic;
using System.Text;

namespace EGift.Services.Email.Exceptions
{
    public class EmailSendingException : Exception
    {
        public EmailSendingException(Exception innerException) : base(string.Empty, innerException)
        {
        }
    }
}
