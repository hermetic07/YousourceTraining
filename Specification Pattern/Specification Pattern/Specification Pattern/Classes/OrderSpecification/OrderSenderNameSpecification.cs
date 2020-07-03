namespace SpecificationPattern.Classes
{
    using System.Collections.Generic;

    public class OrderSenderNameSpecification : Specification<OrderRequest>
    {
        public override bool IsSatisfiedBy(OrderRequest order, ref ICollection<string> errors)
        {
            if (!string.IsNullOrWhiteSpace(order.SenderName))
            {
                return true;
            }
            else
            {
                errors.Add("Invalid Sender name");
                return false;
            }
        }
    }
}
