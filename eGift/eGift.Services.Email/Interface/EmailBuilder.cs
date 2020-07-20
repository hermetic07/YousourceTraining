using System;
using System.Collections.Generic;
using System.Text;
using Egift.Services.Email.Models;

namespace Egift.Services.Email.Interface
{
    public abstract class EmailBuilder
    {
        protected readonly EmailMessage email;

        public EmailBuilder()
        {
            this.email = new EmailMessage();
        }
        public EmailBuilder To(string address)
        {
            email.To = address;
            return this;
        }

        public EmailBuilder From()
        {
            email.From = "emacandog@you-source.com";
            return this;
        }

        public abstract EmailBuilder Subject();

        public abstract EmailBuilder Body(string to, string product, decimal price, int quantity);

        public EmailMessage Build()
        {
            return email;
        }
    }
}
