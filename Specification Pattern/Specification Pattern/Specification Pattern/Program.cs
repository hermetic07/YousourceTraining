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

            OrderRequest orderRequest = new OrderRequest();
            orderRequest.RecipientEmail = "evndr.ls@gmail.com";
            orderRequest.SenderEmail = "evndr.ls@gmail.com";

            OrderEmailSpecification emailSpecification = new OrderEmailSpecification();
            OrderNameSpecification nameSpecification = new OrderNameSpecification();

            emailSpecification.And(nameSpecification).IsSatisfiedBy(orderRequest, ref errors);

            foreach (var item in errors)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
