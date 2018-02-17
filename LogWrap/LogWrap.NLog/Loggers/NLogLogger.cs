using System;

using NLog;

namespace LogWrap.NLog.Loggers
{
    public class NLogLogger : Core.ILogger
    {
        private readonly global::NLog.ILogger _logger;

        public NLogLogger(string name)
        {
            _logger = LogManager.GetLogger(name);
        }

        public NLogLogger(Type type)
        {
            _logger = LogManager.GetLogger(type.FullName);
        }

        public bool IsDebugEnabled
        {
            get
            {
                return _logger.IsDebugEnabled;
            }
        }

        public bool IsErrorEnabled
        {
            get
            {
                return _logger.IsErrorEnabled;
            }
        }

        public bool IsFatalEnabled
        {
            get
            {
                return _logger.IsFatalEnabled;
            }
        }

        public bool IsInfoEnabled
        {
            get
            {
                return _logger.IsInfoEnabled;
            }
        }

        public bool IsTraceEnabled
        {
            get
            {
                return _logger.IsTraceEnabled;
            }
        }

        public bool IsWarnEnabled
        {
            get
            {
                return _logger.IsWarnEnabled;
            }
        }

        public void Debug(string message)
        {
            if (_logger.IsDebugEnabled)
            {
                _logger.Debug(message);
            }
        }

        public void Debug(string message, Exception exception)
        {
            if (IsDebugEnabled)
            {
                _logger.Debug(exception, message);
            }
        }

        public void Debug<T>(T value)
        {
            if (IsDebugEnabled)
            {
                _logger.Debug(value);
            }
        }

        public void DebugFormat(string message, params object[] args)
        {
            if (IsDebugEnabled)
            {
                _logger.Debug(message, args);
            }
        }

        public void Error(string message)
        {
            if (IsErrorEnabled)
            {
                _logger.Error(message);
            }
        }

        public void Error(string message, Exception exception)
        {
            if (IsErrorEnabled)
            {
                _logger.Error(exception, message);
            }
        }

        public void Error<T>(T value)
        {
            if (IsErrorEnabled)
            {
                _logger.Error(value);
            }
        }

        public void ErrorFormat(string message, params object[] args)
        {
            if (IsErrorEnabled)
            {
                _logger.Error(message, args);
            }
        }

        public void Fatal(string message)
        {
            if (IsFatalEnabled)
            {
                _logger.Fatal(message);
            }
        }

        public void Fatal(string message, Exception exception)
        {
            if (IsFatalEnabled)
            {
                _logger.Fatal(exception, message);
            }
        }

        public void Fatal<T>(T value)
        {
            if (IsFatalEnabled)
            {
                _logger.Fatal(value);
            }
        }

        public void FatalFormat(string message, params object[] args)
        {
            if (IsFatalEnabled)
            {
                _logger.Fatal(message, args);
            }
        }

        public void Info(string message)
        {
            if (IsInfoEnabled)
            {
                _logger.Info(message);
            }
        }

        public void Info(string message, Exception exception)
        {
            if (IsInfoEnabled)
            {
                _logger.Info(exception, message);
            }
        }

        public void Info<T>(T value)
        {
            if (IsInfoEnabled)
            {
                _logger.Info(value);
            }
        }

        public void InfoFormat(string message, params object[] args)
        {
            if (IsInfoEnabled)
            {
                _logger.Info(message, args);
            }
        }

        public void Trace(string message)
        {
            if (IsTraceEnabled)
            {
                _logger.Trace(message);
            }
        }

        public void Trace(string message, Exception exception)
        {
            if (IsTraceEnabled)
            {
                _logger.Trace(exception, message);
            }
        }

        public void Trace<T>(T value)
        {
            if (IsTraceEnabled)
            {
                _logger.Trace(value);
            }
        }

        public void TraceFormat(string message, params object[] args)
        {
            if (IsTraceEnabled)
            {
                _logger.Trace(message, args);
            }
        }

        public void Warn(string message)
        {
            if (IsWarnEnabled)
            {
                _logger.Warn(message);
            }
        }

        public void Warn(string message, Exception exception)
        {
            if (IsWarnEnabled)
            {
                _logger.Warn(exception, message);
            }
        }

        public void Warn<T>(T value)
        {
            if (IsWarnEnabled)
            {
                _logger.Warn(value);
            }
        }

        public void WarnFormat(string message, params object[] args)
        {
            if (IsWarnEnabled)
            {
                _logger.Warn(message, args);
            }
        }
    }
}