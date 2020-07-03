namespace SpecificationPattern.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class OrderRecipientContactSpecification : Specification<OrderRequest>
    {
        public override bool IsSatisfiedBy(OrderRequest order, ref ICollection<string> errors)
        {
            if (Regex.Match(order.RecipientContactNumber, @"(^(\+63)(\d){10}$)").Success)
            {
                return true;
            }
            else
            {
                errors.Add("Invalid Recipient contact number");
                return false;
            }
        }
    }
}
