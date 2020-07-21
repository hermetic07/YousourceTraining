namespace EGift.Services.Email.Models.MailService
{
    using System;
    using System.Threading.Tasks;
    using Egift.Services.Email.Interface;
    using Egift.Services.Email.Models;
    using EGift.Services.Email.Exceptions;
    using EGift.Services.Email.Messages;
    using EGift.Services.Email.Providers;
    using Microsoft.Extensions.Logging;
    using SendGrid;
    using SendGrid.Helpers.Mail;

    public class SendGridEmailService : IEmailService
    {
        private readonly ILogger<SendGridException> logger;
        private readonly SendGridProvider sendGridProvider;

        public SendGridEmailService(ILogger<SendGridException> logger)
        {
            this.logger = logger;
            this.sendGridProvider = new SendGridProvider();
        }

        public async Task<EmailSendingResponse> Send(EmailMessage email)
        {
            var response = new EmailSendingResponse { Code = 200 };

            try
            {
                var apiKey = this.sendGridProvider.GetSendGridKey();
                var client = new SendGridClient(apiKey);

                var msg = MailHelper.CreateSingleEmail(
                    new EmailAddress(email.Sender, email.SenderName),
                    new EmailAddress(email.Recipient, email.RecipientName), 
                    email.Subject, 
                    email.PlainTextContent,
                    email.HtmlContent);

                var emailResponse = await client.SendEmailAsync(msg);
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
