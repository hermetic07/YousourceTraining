namespace EGift.Services.Email
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using Egift.Services.Email.Models;
    using EGift.Services.Email.Messages;

    public interface IEmailSender
    {
        Task<EmailSendingResponse> SendEmail(EmailMessage email);
    }
}
