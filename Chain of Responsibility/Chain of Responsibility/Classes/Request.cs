using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Classes
{
    public class Request
    {
        public string ContentType { get; set; }
        public string Content { get; set; }
    }
}
