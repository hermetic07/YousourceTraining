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
            RequestParser _xml = new XmlRequestHandler();
            RequestParser _json = new JsonRequestHandler();
            RequestParser _base = new BaseRequestHandler();

            _xml.setSuccessor(_json);
            _json.setSuccessor(_base);

            Request _request = new Request();

            Console.Write("Content Type: ");
            _request.ContentType = Console.ReadLine();
            Console.Write("Content: ");
            _request.Content = Console.ReadLine();

            _xml.Handle(_request);

            Console.ReadKey();
        }
    }
}
