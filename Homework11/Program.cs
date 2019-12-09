using System;

namespace Homework11
{
    class Program
    {
        static void Main(string[] args)
        {
            LogWriterFactory factory = LogWriterFactory.GetInstance();

            var cw = factory.GetLogWriter<ConsoleLogWriter>();
            var fw = factory.GetLogWriter<FileLogWriter>();
            var mw = factory.GetLogWriter<MultipleLogWriter>(cw, fw);
            mw.LogError("Error message");
            mw.LogInfo("Info message");
            mw.LogWarning("Warning message");
            Console.ReadKey();
        }
    }
}
