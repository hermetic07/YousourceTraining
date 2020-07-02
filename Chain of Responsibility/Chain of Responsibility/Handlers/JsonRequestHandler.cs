namespace Chain_of_Responsibility.Handlers
{
    using System;
    using System.Collections.Generic;
    using System.Web.Script.Serialization;
    using Chain_of_Responsibility.Classes;

    public class JsonRequestHandler : BaseRequestHandler
    {
        public override void Handle(Request request)
        {
            if (request.ContentType == "json")
            {
                Console.WriteLine("JsonRequestHandler:");

                var jsonObject = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(request.Content);
                
                foreach (var item in jsonObject)
                {
                    Console.WriteLine("Key: {0}, Value: {1} \n", item.Key, item.Value);
                }
            }
            else if (this.GetSuccessor() != null)
            {
                this.GetSuccessor().Handle(request);
            }
            else
            {
                Console.WriteLine("Unable to find a specific handler for the request");
            }
        }
    }
}
