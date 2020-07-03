namespace SpecificationPattern.Classes
{
    using System.Collections.Generic;

    public class OrderRecipientNameSpecification : Specification<OrderRequest>
    {
        public override bool IsSatisfiedBy(OrderRequest order, ref ICollection<string> errors)
        {
            if (!string.IsNullOrWhiteSpace(order.RecipientName))
            {
                return true;
            }
            else
            {
                errors.Add("Invalid Recipient name");
                return false;
            }
        }
    }
}
