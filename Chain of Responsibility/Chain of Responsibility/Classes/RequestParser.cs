using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Classes
{
    public abstract class RequestParser
    {
        protected RequestParser successor;

        public abstract void Handle(Request _request);

        public void setSuccessor(RequestParser successor)
        {
            this.successor = successor;
        }
    }
}
