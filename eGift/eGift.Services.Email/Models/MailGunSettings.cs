namespace EGift.Services.Email.Models
{
    public class MailGunSettings
    {
        public string ApiKey { get; set; }

        public string ApiBaseUri { get; set; }

        public string RequestUri { get; set; }

        public string From { get; set; }
    }
}
