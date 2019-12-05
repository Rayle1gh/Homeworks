using System;

namespace Homework10
{
    class ConsoleLogWriter : AbstractLogWriter
    {
        public override void LogWriting(string message)
        {
            Console.WriteLine(message);
        }
    }
}
