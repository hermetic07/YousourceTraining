namespace Decorator.Classes
{
    using Decorator.Interfaces;

    public class DefaultStringBehavior : IStringBehavior
    {
        public string Reverse(string input)
        {
            char[] chars = new char[input.Length];
            for (int i = 0, j = input.Length - 1; i <= j; i++, j--)
            {
                chars[i] = input[j];
                chars[j] = input[i];
            }

            return new string(chars);
        }
    }
}
