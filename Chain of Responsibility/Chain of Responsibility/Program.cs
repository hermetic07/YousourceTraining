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
            //JSON Data
            Request _request = new Request() {
                ContentType = "json",
                Content = @"{""name"":""John Doe"",""age"":20}"
            };

            RequestParser requestParser = new RequestParser(_request);
            requestParser.Parse();

            //XML Data
            _request = new Request()
            {
                ContentType = "xml",
                Content = @"<PurchaseOrder>
                                <PurchasedGame>
                                    <Name>GTA</Name>
                                </PurchasedGame>
                                <Customer>
                                    <Name>Evander</Name>
                                </Customer>
                            </PurchaseOrder>"
            };

            requestParser = new RequestParser(_request);
            requestParser.Parse();

            //Invalid data
            _request = new Request()
            {
                ContentType = "string",
                Content = "test"
            };

            requestParser = new RequestParser(_request);
            requestParser.Parse();

            Console.ReadKey();
        }
    }
}
