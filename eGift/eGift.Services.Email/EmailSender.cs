namespace EGift.Services.Email
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using Egift.Services.Email.Interface;
    using Egift.Services.Email.Models;
    using EGift.Services.Email.Exceptions;
    using EGift.Services.Email.Messages;
    using Microsoft.Extensions.Logging;

    public class EmailSender : IEmailSender
    {
        private readonly ILogger<SendGridException> logger;
        private IEmailService emailService;

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
