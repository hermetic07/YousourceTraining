namespace EGift.Services.Email.Interface
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Egift.Services.Email.Models;

    public interface IEmailBuilder
    {
        void BuildSender();

        void BuildSenderName();

        void BuildRecipient();

        void BuildRecipientName();

        void BuildSubject();

        void BuildPlainTextContent();

        void BuildHtmlContent();

        void BuildAttachments();

        EmailMessage BuildEmail();
    }
}
