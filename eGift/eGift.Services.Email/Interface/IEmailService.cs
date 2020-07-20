using Egift.Services.Email.Models;
using EGift.Services.Email.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Egift.Services.Email.Interface
{
    public interface IEmailService
    {
        public Task<EmailSendingResponse> Send(EmailMessage email);
    }
}
