namespace EGift.Services.Email.Models.MailService
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;
    using Egift.Services.Email.Interface;
    using Egift.Services.Email.Models;
    using EGift.Services.Email.Exceptions;
    using EGift.Services.Email.Messages;
    using EGift.Services.Email.Providers;
    using Microsoft.Extensions.Logging;
    using RestSharp;
    using RestSharp.Authenticators;

    public class MailGunEmailService : IEmailService
    {
        private readonly ILogger<MailGunException> logger;
        private readonly MailGunProvider mailGunProvider;

        public MailGunEmailService(ILogger<MailGunException> logger)
        {
            this.logger = logger;
            this.mailGunProvider = new MailGunProvider();
        }

        public async Task<EmailSendingResponse> Send(EmailMessage email)
        {
            var response = new EmailSendingResponse { Code = 200 };

            try
            {
                var emailSettings = this.mailGunProvider.GetEmailSettings();

                RestClient client = new RestClient();
                client.BaseUrl = new Uri("https://api.mailgun.net/v3"); 

                client.Authenticator = new HttpBasicAuthenticator("api",emailSettings.ApiKey);
                RestRequest request = new RestRequest();
                request.AddParameter("domain", emailSettings.RequestUri, ParameterType.UrlSegment);
                request.Resource = "{domain}/messages";
                request.AddParameter("from", email.SenderName+" <"+emailSettings.From+">");
                request.AddParameter("to", email.Recipient);
                request.AddParameter("subject", email.Subject);
                request.AddParameter("text", email.PlainTextContent);
                request.Method = Method.POST;
                
                var x = client.Execute(request);
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
