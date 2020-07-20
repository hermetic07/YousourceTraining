using Egift.Services.Email.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Egift.Services.Email
{
    public class RecipientEmailMessage : EmailBuilder
    {
        public override EmailBuilder Subject()
        {
            email.Subject = "eGift Received";
            return this;
        }

        public override EmailBuilder Body(string to, string product, decimal price, int quantity)
        {
            email.Body = "Sender: " + to + "\n";
            email.Body += "Product: " + product + "\n";
            email.Body += "Price: " + price + "\n";
            email.Body += "Quantity: " + quantity;

            return this;
        }
    }
}
