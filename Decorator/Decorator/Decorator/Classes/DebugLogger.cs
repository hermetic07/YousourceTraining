namespace Decorator.Classes
{
    using System;
    using System.Diagnostics;

    public interface ILogger
    {
        void Log(string message);
    }

    public class DebugLogger : ILogger
    {
        public void Log(string message)
        {
            Debug.WriteLine(message);
        }
    }
}
