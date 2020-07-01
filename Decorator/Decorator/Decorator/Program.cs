using Decorator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            DefaultStringBehavior defaultStringBehavior = new DefaultStringBehavior();
            AppendingBehavior appendingBehavior = new AppendingBehavior(defaultStringBehavior);
            LoggingBehavior loggingBehavior = new LoggingBehavior(defaultStringBehavior, new DebugLogger());

            Console.Write("Enter a string: ");
            string _input = Console.ReadLine();

            Console.WriteLine(defaultStringBehavior.Reverse(_input));
            Console.WriteLine(appendingBehavior.Reverse(_input));
            loggingBehavior.Reverse(_input);

            Console.ReadKey();
        }
    }
}
