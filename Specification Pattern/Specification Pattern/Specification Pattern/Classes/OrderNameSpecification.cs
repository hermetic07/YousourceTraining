namespace SpecificationPattern.Classes
{
    using System.Collections.Generic;

    public class OrderNameSpecification : Specification<OrderRequest>
    {
        public override bool IsSatisfiedBy(OrderRequest order, ref ICollection<string> errors)
        {
            if (!string.IsNullOrWhiteSpace(order.RecipientName) && !string.IsNullOrWhiteSpace(order.SenderName))
            {
                return true;
            }
            else
            {
                errors.Add("Invalid name");
                return false;
            }
        }
    }
}
