﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chain_of_Responsibility.Classes;

namespace Chain_of_Responsibility.Handlers
{
    class XmlRequestHandler : RequestParser
    {
        public override void Handle(Request _request)
        {
            if (_request.ContentType.ToUpper() == "XML")
            {
                Console.WriteLine("{0} handled request", this.GetType().Name);
            }
            else if (successor != null)
            {
                successor.Handle(_request);
            }
        }
    }
}
