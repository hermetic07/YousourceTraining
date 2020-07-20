using Egift.Services.Email.Models;
using EGift.Services.Email.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EGift.Services.Email
{
    public interface IEmailSender
    {
        Task<EmailSendingResponse> SendEmail(EmailMessage email);
    }
}
