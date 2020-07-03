namespace SpecificationPattern.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OrderEmailSpecification : Specification<OrderRequest>
    {
        public override bool IsSatisfiedBy(OrderRequest order, ref ICollection<string> errors)
        {
            try
            {
                var recipientEmail = new System.Net.Mail.MailAddress(order.RecipientEmail);
                var senderEmail = new System.Net.Mail.MailAddress(order.SenderEmail);

                return senderEmail.Address == order.SenderEmail && recipientEmail.Address == order.RecipientEmail;
            }
            catch
            {
                errors.Add("Invalid email address");
                return false;
            }
        }
    }
}
