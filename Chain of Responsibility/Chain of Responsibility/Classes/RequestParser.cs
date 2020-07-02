namespace Chain_of_Responsibility.Classes
{
    using Chain_of_Responsibility.Handlers;

    public class RequestParser
    {
        private Request request;
        private BaseRequestHandler xml = new XmlRequestHandler();
        private BaseRequestHandler json = new JsonRequestHandler();

        public RequestParser(Request request)
        {
            this.request = request;
            this.SetChain();
        }

        public void Parse()
        {
            this.xml.Handle(this.request);
        }

        public void SetChain()
        {
            this.xml.SetSuccessor(this.json);
        }
    }
}
