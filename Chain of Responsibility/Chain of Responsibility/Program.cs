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
            
            Request _request = new Request() {
                ContentType = "json",
                Content = @"{""name"":""John Doe"",""age"":20}"
            };

            RequestParser requestParser = new RequestParser(_request);
            requestParser.Parse();

            _request = new Request()
            {
                ContentType = "xml",
                Content = @"<item><name>wrench</name></item>"
            };

            requestParser = new RequestParser(_request);
            requestParser.Parse();

            Console.ReadKey();
        }
    }
}
