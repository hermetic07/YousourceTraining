using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chain_of_Responsibility.Classes;

namespace Chain_of_Responsibility.Handlers
{
    public abstract class BaseRequestHandler 
    {
        protected BaseRequestHandler successor;

        public abstract void Handle(Request _request);

        public void setSuccessor(BaseRequestHandler successor)
        {
            this.successor = successor;
        }
    }
}
