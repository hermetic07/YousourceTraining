﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Interfaces;

namespace Decorator.Classes
{
    public class AppendingBehavior : StringBehaviorDecorator
    {
        public AppendingBehavior(IStringBehavior stringBehavior) : base(stringBehavior)
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

            return Append(new string(chars));
        }

        private string Append(string reversedInput)
        {
            return reversedInput + "Evander";
        }
    }
}
