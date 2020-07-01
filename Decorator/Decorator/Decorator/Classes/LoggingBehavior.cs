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
        ILogger debugLogger;

        public LoggingBehavior(IStringBehavior stringBehavior, ILogger debugLogger)
        {
            this.stringBehavior = stringBehavior;
            this.debugLogger = debugLogger;
        }

        public string Reverse(string input)
        {
            string reversedString = this.stringBehavior.Reverse(input);

            debugLogger.Log(reversedString);

            return reversedString;
        }
    }
}
