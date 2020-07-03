namespace SpecificationPattern.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OrderSenderEmailSpecification : Specification<OrderRequest>
    {
        public override bool IsSatisfiedBy(OrderRequest order, ref ICollection<string> errors)
        {
            try
            {
                var senderEmail = new System.Net.Mail.MailAddress(order.SenderEmail);

                return senderEmail.Address == order.SenderEmail;
            }
            catch
            {
                errors.Add("Invalid Sender email address");
                return false;
            }
        }
    }
}
