namespace Chain_of_Responsibility.Handlers
{
    using Chain_of_Responsibility.Classes;

    public abstract class BaseRequestHandler 
    {
        private BaseRequestHandler successor;

        public abstract void Handle(Request request);

        public void SetSuccessor(BaseRequestHandler successor)
        {
            this.successor = successor;
        }

        public BaseRequestHandler GetSuccessor()
        {
            return this.successor;
        }
    }
}
