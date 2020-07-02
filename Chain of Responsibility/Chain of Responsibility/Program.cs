using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chain_of_Responsibility.Classes;
using Chain_of_Responsibility.Handlers;

namespace Chain_of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Request _request = new Request();

            Console.WriteLine("Content Type: ");
            _request.ContentType = Console.ReadLine();

            Console.WriteLine("Content: ");
            _request.Content = Console.ReadLine();

            RequestParser requestParser = new RequestParser(_request);
            requestParser.Parse();

            Console.ReadKey();
        }
    }
}
