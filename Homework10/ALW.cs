﻿using System;

namespace Homework10
{
    abstract class AbstractLogWriter : ILogWriter
    {
        public enum LogLevel { Info, Error, Warning }

        private const string _logMessage = "{0:yyyy-MM-ddThh:mm:ss:ffff}\t{1}\t{2}";
        public void LogError(string message)
        {
            LogWriting(String.Format(_logMessage, DateTime.Now, LogLevel.Error, message));
        }
        public void LogInfo(string message)
        {
            LogWriting(String.Format(_logMessage, DateTime.Now, LogLevel.Info, message));
        }
        public void LogWarning(string message)
        {
            LogWriting(String.Format(_logMessage, DateTime.Now, LogLevel.Warning, message));
        }
        public abstract void LogWriting(string message);
    }
}
