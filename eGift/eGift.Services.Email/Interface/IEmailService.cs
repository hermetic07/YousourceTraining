namespace Egift.Services.Email.Interface
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using Egift.Services.Email.Models;
    using EGift.Services.Email.Messages;

    public interface IEmailService
    {
        public Task<EmailSendingResponse> Send(EmailMessage email);
    }
}
