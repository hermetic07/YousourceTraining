namespace EGift.Services.Email.Models.MailBuilder
{
    using Egift.Services.Email.Models;
    using EGift.Services.Email.Interface;

    public class RecipientEmailBuilder : IEmailBuilder
    {
        private readonly EmailMessage result;
        private readonly string recipientEmail;
        private readonly string recipientName;
        private readonly string senderName;
        private readonly string productName;
        private readonly decimal productPrice;
        private readonly int productQuantity;

        public RecipientEmailBuilder(string recipientEmail, string recipientName, string senderName, string productName, decimal productPrice, int productQuantity)
        {
            this.senderName = senderName;
            this.recipientEmail = recipientEmail;
            this.recipientName = recipientName;
            this.productName = productName;
            this.productPrice = productPrice;
            this.productQuantity = productQuantity;
            this.result = new EmailMessage();
        }

        public void BuildRecipient()
        {
            this.result.Recipient = this.recipientEmail;
        }

        public void BuildRecipientName()
        {
            this.result.RecipientName = this.recipientName;
        }

        public void BuildSender()
        {
            this.result.Sender = "emacandog@you-source.com";
        }

        public void BuildSenderName()
        {
            this.result.SenderName = "EGift";
        }

        public void BuildSubject()
        {
            this.result.Subject = "EGift received from " + this.senderName;
        }

        public void BuildHtmlContent()
        {
            this.result.HtmlContent += "<strong> Product: " + this.productName + "</strong>";
            this.result.HtmlContent += "<strong> Price: " + this.productPrice + "</strong>";
            this.result.HtmlContent += "<strong> Quantity: " + this.productQuantity;
        }

        public void BuildPlainTextContent()
        {
            this.result.PlainTextContent += "Product: " + this.productName + "\n";
            this.result.PlainTextContent += "Price: " + this.productPrice + "\n";
            this.result.PlainTextContent += "Quantity: " + this.productQuantity;
        }

        public void BuildAttachments()
        {
        }

        public EmailMessage BuildEmail()
        {
            return this.result;
        }
    }
}
