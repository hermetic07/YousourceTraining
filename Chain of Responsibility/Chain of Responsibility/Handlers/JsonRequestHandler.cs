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
                var JSONObj = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(_request.Content);
                Console.WriteLine("{0} handled request",this.GetType().Name);
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
