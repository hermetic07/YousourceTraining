using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Interfaces;

namespace Decorator.Classes
{
    public abstract class StringBehaviorDecorator : IStringBehavior
    {
        private IStringBehavior _stringBehavior;

        public StringBehaviorDecorator(IStringBehavior stringBehavior)
        {
            this._stringBehavior = stringBehavior;
        }

        public virtual string Reverse(string input)
        {
            return this._stringBehavior.Reverse(input);
        }
    }
}
