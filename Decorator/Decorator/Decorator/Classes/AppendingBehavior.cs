using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Interfaces;

namespace Decorator.Classes
{
    public class AppendingBehavior : IStringBehavior
    {
        IStringBehavior stringBehavior;
        public AppendingBehavior(IStringBehavior stringBehavior)
        {
            this.stringBehavior = stringBehavior;
        }

        public string Reverse(string input)
        {
            string reversedString = this.stringBehavior.Reverse(input);

            string appendedString = string.Format("{0} Evander", reversedString);

            return appendedString;
        }
    }
}
