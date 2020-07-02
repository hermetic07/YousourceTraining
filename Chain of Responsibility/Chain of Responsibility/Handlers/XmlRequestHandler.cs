namespace Chain_of_Responsibility.Handlers
{
    using System;
    using System.Xml;
    using Chain_of_Responsibility.Classes;

    public class XmlRequestHandler : BaseRequestHandler
    {
        public override void Handle(Request request)
        {
            if (request.ContentType == "xml")
            {
                Console.WriteLine("XmlRequestHandler:");

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(request.Content);

                for (int i = 0; i < xmlDoc.ChildNodes[0].ChildNodes.Count; i++)
                {
                    Console.WriteLine("Key: {0}, Value: {1} \n", xmlDoc.ChildNodes[0].ChildNodes[i].Name, xmlDoc.ChildNodes[0].ChildNodes[i].InnerText);
                }
            }
            else if (this.GetSuccessor() != null)
            {
                this.GetSuccessor().Handle(request);
            }
        }
    }
}
