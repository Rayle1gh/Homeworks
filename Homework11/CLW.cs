using System;
using System.Collections.Generic;
using System.Text;

namespace Homework11
{
    class ConsoleLogWriter : AbstractLogWriter
    {
        public override void LogWriting(string message)
        {
            Console.WriteLine(message);
        }
    }
}
