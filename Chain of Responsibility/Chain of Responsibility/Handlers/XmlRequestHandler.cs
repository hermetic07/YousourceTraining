using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Chain_of_Responsibility.Classes;

namespace Chain_of_Responsibility.Handlers
{
    class XmlRequestHandler : BaseRequestHandler
    {
        public override void Handle(Request _request)
        {
            if (_request.ContentType == "xml")
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(_request.Content);

                Console.WriteLine("{0} handled request", this.GetType().Name);
            }
            else if (successor != null)
            {
                successor.Handle(_request);
            }
        }
    }
}
