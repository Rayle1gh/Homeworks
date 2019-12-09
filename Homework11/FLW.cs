using System;
using System.IO;

namespace Homework11
{
    class FileLogWriter : AbstractLogWriter, IDisposable
    {
        private StreamWriter _writer;
        public FileLogWriter()
        {
            _writer = new StreamWriter(File.Open("log.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read));
            _writer.BaseStream.Seek(0, SeekOrigin.End);
        }
        public override void LogWriting(string message)
        {
            _writer.WriteLine(message);
            _writer.Flush();
        }
        public void Dispose()
        {
            _writer?.Dispose();
        }
    }
}
