using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Chain_of_Responsibility.Classes;

namespace Chain_of_Responsibility.Handlers
{
    public class JsonRequestHandler : BaseRequestHandler
    {
        public override void Handle(Request _request)
        {
            if (_request.ContentType == "json")
            {
                Console.WriteLine("JsonRequestHandler:");

                var JsonObject = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(_request.Content);
                
                foreach (var item in JsonObject)
                {
                    Console.WriteLine("Key: {0}, Value: {1} \n",item.Key,item.Value);
                }
            }
            else if (successor != null)
            {
                successor.Handle(_request);
            }
            else
            {
                Console.WriteLine("Unable to find a specific handler for the request");
            }
        }
    }
}
