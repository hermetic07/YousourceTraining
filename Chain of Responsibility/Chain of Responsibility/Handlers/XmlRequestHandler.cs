using System;
using System.Collections.Generic;
using System.IO;
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
                Console.WriteLine("XmlRequestHandler:");

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(_request.Content);

                for (int i = 0; i < xmlDoc.ChildNodes[0].ChildNodes.Count; i++)
                {
                    Console.WriteLine("Key: {0}, Value: {1} \n", xmlDoc.ChildNodes[0].ChildNodes[i].Name, xmlDoc.ChildNodes[0].ChildNodes[i].InnerText);
                }
            }
            else if (successor != null)
            {
                successor.Handle(_request);
            }
        }
    }
}
