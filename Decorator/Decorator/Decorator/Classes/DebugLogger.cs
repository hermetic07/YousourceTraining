using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Classes
{
    public class DebugLogger : ILogger
    {

        public void Log(string message)
        {
            Debug.WriteLine(message);
        }

    }

    public interface ILogger
    {
        void Log(string message);
    }
}
