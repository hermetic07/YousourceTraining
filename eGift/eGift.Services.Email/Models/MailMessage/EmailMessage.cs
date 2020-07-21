namespace Egift.Services.Email.Models
{
    public class EmailMessage
    {
        public string Recipient { get; set; }

        public string RecipientName { get; set; }

        public string Sender { get; set; }

        public string SenderName { get; set; }

        public string Subject { get; set; }

        public string HtmlContent { get; set; }

        public string PlainTextContent { get; set; }
    }
}
