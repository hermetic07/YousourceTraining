namespace SpecificationPattern.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OrderRecipientEmailSpecification : Specification<OrderRequest>
    {
        public override bool IsSatisfiedBy(OrderRequest order, ref ICollection<string> errors)
        {
            try
            {
                var recipientEmail = new System.Net.Mail.MailAddress(order.RecipientEmail);

                return recipientEmail.Address == order.RecipientEmail;
            }
            catch
            {
                errors.Add("Invalid Recipient email address");
                return false;
            }
        }
    }
}
