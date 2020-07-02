namespace Decorator.Classes
{
    using Decorator.Interfaces;

    public class AppendingBehavior : IStringBehavior
    {
        private IStringBehavior stringBehavior;

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
