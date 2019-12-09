﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Homework11
{
    public interface ILogWriter
    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message);
    }
}
