namespace EGift.Services.Email.Models.MailDirector
{
    using Egift.Services.Email.Models;
    using EGift.Services.Email.Interface;

    public class EmailDirector
    {
        public static EmailMessage ConstructEmail(IEmailBuilder builder)
        {
            builder.BuildHtmlContent();
            builder.BuildPlainTextContent();
            builder.BuildRecipient();
            builder.BuildRecipientName();
            builder.BuildSender();
            builder.BuildSenderName();
            builder.BuildSubject();

            return builder.BuildEmail();
        }
    }
}
