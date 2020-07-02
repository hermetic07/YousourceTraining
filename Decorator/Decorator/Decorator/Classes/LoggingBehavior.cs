namespace Decorator.Classes
{
    using Decorator.Interfaces;

    public class LoggingBehavior : IStringBehavior
    {
        private IStringBehavior stringBehavior;
        private ILogger debugLogger;

        public LoggingBehavior(IStringBehavior stringBehavior, ILogger debugLogger)
        {
            this.stringBehavior = stringBehavior;
            this.debugLogger = debugLogger;
        }

        public string Reverse(string input)
        {
            string reversedString = this.stringBehavior.Reverse(input);

            this.debugLogger.Log(reversedString);

            return reversedString;
        }
    }
}
