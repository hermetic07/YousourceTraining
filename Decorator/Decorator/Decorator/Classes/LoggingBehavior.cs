using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Interfaces;

namespace Decorator.Classes
{
    class LoggingBehavior : StringBehaviorDecorator
    {
        public LoggingBehavior(IStringBehavior stringBehavior) : base(stringBehavior)
        {

        }

        public override string Reverse(string input)
        {
            char[] chars = new char[input.Length];
            for (int i = 0, j = input.Length - 1; i <= j; i++, j--)
            {
                chars[i] = input[j];
                chars[j] = input[i];
            }

            Log(new string(chars));

            return new string(chars);
        }

        private void Log(string reversedInput)
        {
            DebugLogger debugLogger = new DebugLogger();
            debugLogger.Log(reversedInput);
        }
    }
}
