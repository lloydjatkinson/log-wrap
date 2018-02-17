using System;

using LogWrap.Core;

namespace LogWrap.Empty.Loggers
{
    public class EmptyLogger : ILogger
    {
        public bool IsDebugEnabled { get; } = false;

        public bool IsErrorEnabled { get; } = false;

        public bool IsFatalEnabled { get; } = false;

        public bool IsInfoEnabled { get; } = false;

        public bool IsTraceEnabled { get; } = false;

        public bool IsWarnEnabled { get; } = false;

        public void Debug(string message)
        {
        }

        public void Debug(string message, Exception exception)
        {
        }

        public void Debug<T>(T value)
        {
        }

        public void DebugFormat(string message, params object[] args)
        {
        }

        public void Error(string message)
        {
        }

        public void Error(string message, Exception exception)
        {
        }

        public void Error<T>(T value)
        {
        }

        public void ErrorFormat(string message, params object[] args)
        {
        }

        public void Fatal(string message)
        {
        }

        public void Fatal(string message, Exception exception)
        {
        }

        public void Fatal<T>(T value)
        {
        }

        public void FatalFormat(string message, params object[] args)
        {
        }

        public void Info(string message)
        {
        }

        public void Info(string message, Exception exception)
        {
        }

        public void Info<T>(T value)
        {
        }

        public void InfoFormat(string message, params object[] args)
        {
        }

        public void Trace(string message)
        {
        }

        public void Trace(string message, Exception exception)
        {
        }

        public void Trace<T>(T value)
        {
        }

        public void TraceFormat(string message, params object[] args)
        {
        }

        public void Warn(string message)
        {
        }

        public void Warn(string message, Exception exception)
        {
        }

        public void Warn<T>(T value)
        {
        }

        public void WarnFormat(string message, params object[] args)
        {
        }

        public EmptyLogger(Type type)
        {
        }

        public EmptyLogger(string name)
        {
        }
    }
}