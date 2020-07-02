namespace Decorator
{
    using System;
    using Decorator.Classes;

    public class Program
    {
        public static void Main(string[] args)
        {
            DefaultStringBehavior defaultStringBehavior = new DefaultStringBehavior();
            AppendingBehavior appendingBehavior = new AppendingBehavior(defaultStringBehavior);
            LoggingBehavior loggingBehavior = new LoggingBehavior(defaultStringBehavior, new DebugLogger());

            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.WriteLine(defaultStringBehavior.Reverse(input));
            Console.WriteLine(appendingBehavior.Reverse(input));
            loggingBehavior.Reverse(input);

            Console.ReadKey();
        }
    }
}
