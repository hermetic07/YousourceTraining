namespace SpecificationPattern
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using SpecificationPattern.Classes;

    public class Program
    {
        public static void Main(string[] args)
        {
            ICollection<string> errors = new List<string>();

            OrderRequest orderRequest = new OrderRequest
            {
                SenderName = "test",
                SenderEmail = "emacandog@you-source.com",
                SenderContactNumber = "+639476158346",
                RecipientName = "Louis",
                RecipientEmail = "evndr.ls@gmail.com",
                RecipientContactNumber = "09476158346",
                Dedication = "test"
            };

            Specification<OrderRequest> orderSpecification = new OrderSenderEmailSpecification();
            orderSpecification.And(new OrderRecipientEmailSpecification())
                .And(new OrderSenderContactSpecification())
                .And(new OrderSenderNameSpecification())
                .And(new OrderRecipientNameSpecification())
                .And(new OrderRecipientContactSpecification())
                .And(new OrderRecipientNameSpecification()).IsSatisfiedBy(orderRequest, ref errors);

            if (errors.Count > 0)
            {
                foreach (var item in errors)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Valid order request");
            }

            Console.ReadKey();
        }
    }
}
