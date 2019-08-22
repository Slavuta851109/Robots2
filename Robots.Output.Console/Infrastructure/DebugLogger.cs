using System.Diagnostics;
using Robots.Application;

namespace Robots.Output.AConsole.Infrastructure
{
    internal sealed class DebugLogger : ILogger
    {
        public void Log(string message)
        {
            Debug.WriteLine(message);
        }
    }
}
