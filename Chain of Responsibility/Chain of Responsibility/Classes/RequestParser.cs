using Chain_of_Responsibility.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Classes
{
    public class RequestParser
    {
        Request request;
        BaseRequestHandler _xml = new XmlRequestHandler();
        BaseRequestHandler _json = new JsonRequestHandler();

        public RequestParser(Request request)
        {
            this.request = request;
            SetChain();
        }

        public void Parse()
        {
            _xml.Handle(this.request);
        }

        void SetChain()
        {
            _xml.setSuccessor(_json);
        }
    }
}
