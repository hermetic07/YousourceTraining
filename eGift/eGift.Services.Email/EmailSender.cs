using Egift.Services.Email.Interface;
using Egift.Services.Email.Models;
using EGift.Services.Email.Exceptions;
using EGift.Services.Email.Messages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EGift.Services.Email
{
    public class EmailSender : IEmailSender
    {
        private IEmailService emailService;
        private readonly ILogger<SendGridException> logger;

        public EmailSender(IEmailService emailService, ILogger<SendGridException> logger)
        {
            this.emailService = emailService;
            this.logger = logger;
        }

        public async Task<EmailSendingResponse> SendEmail(EmailMessage email)
        {
            var response = new EmailSendingResponse { Code = 200 };

            try
            {
                await this.emailService.Send(email);
            }
            catch (Exception ex)
            {
                response.Code = 500;
                this.logger.LogError(ex.Message);
            }

            return response;
        }
    }
}
