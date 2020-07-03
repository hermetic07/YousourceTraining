namespace SpecificationPattern.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class OrderSenderContactSpecification : Specification<OrderRequest>
    {
        public override bool IsSatisfiedBy(OrderRequest order, ref ICollection<string> errors)
        {
            if (Regex.Match(order.SenderContactNumber, @"(^(\+63)(\d){10}$)").Success)
            {
                return true;
            }
            else
            {
                errors.Add("Invalid Sender contact number");
                return false;
            }
        }
    }
}
