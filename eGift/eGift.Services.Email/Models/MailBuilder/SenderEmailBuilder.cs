namespace EGift.Services.Email.Models.MailBuilder
{
    using Egift.Services.Email.Models;
    using EGift.Services.Email.Interface;

    public class SenderEmailBuilder : IEmailBuilder
    {
        private readonly EmailMessage result;
        private readonly string senderEmail;
        private readonly string senderName;
        private readonly string recipientName;
        private readonly string productName;
        private readonly decimal productPrice;
        private readonly int productQuantity;

        public SenderEmailBuilder(string senderEmail, string senderName, string recipientName, string productName, decimal productPrice, int productQuantity)
        {
            this.senderName = senderName;
            this.senderEmail = senderEmail;
            this.recipientName = recipientName;
            this.productName = productName;
            this.productPrice = productPrice;
            this.productQuantity = productQuantity;
            this.result = new EmailMessage();
        }

        public void BuildRecipient()
        {
            this.result.Recipient = this.senderEmail;
        }

        public void BuildRecipientName()
        {
            this.result.RecipientName = this.senderName;
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
            this.result.Subject = "EGift purchase confirmation";
        }

        public void BuildHtmlContent()
        {
            this.result.HtmlContent = "<strong> Recipient: " + this.recipientName + "</strong>";
            this.result.HtmlContent += "<strong> Product: " + this.productName + "</strong>";
            this.result.HtmlContent += "<strong> Price: " + this.productPrice + "</strong>";
            this.result.HtmlContent += "<strong> Quantity: " + this.productQuantity + "</strong>";
        }

        public void BuildPlainTextContent()
        {
            this.result.PlainTextContent = "Recipient: " + this.recipientName + "\n";
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
