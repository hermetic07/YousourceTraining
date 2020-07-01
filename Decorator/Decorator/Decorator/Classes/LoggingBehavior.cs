using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Interfaces;

namespace Decorator.Classes
{
    class LoggingBehavior : IStringBehavior
    {
        IStringBehavior stringBehavior;
        public LoggingBehavior(IStringBehavior stringBehavior)
        {
            this.stringBehavior = stringBehavior;
        }

        public string Reverse(string input)
        {
            string reversedString = this.stringBehavior.Reverse(input);

            DebugLogger debugLogger = new DebugLogger();
            debugLogger.Log(reversedString);

            return reversedString;
        }
    }
}
