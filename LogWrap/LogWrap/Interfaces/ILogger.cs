using System;

namespace LogWrap.Interfaces
{
    /// <summary>
    /// Defines methods used for logging.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Gets a value indicating whether this logger has trace enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this logger has trace enabled; otherwise, <c>false</c>.
        /// </value>
        bool IsTraceEnabled { get; }

        /// <summary>
        /// Gets a value indicating whether this logger has debug enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this logger has debug enabled; otherwise, <c>false</c>.
        /// </value>
        bool IsDebugEnabled { get; }

        /// <summary>
        /// Gets a value indicating whether this logger has information enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this logeer has information enabled; otherwise, <c>false</c>.
        /// </value>
        bool IsInfoEnabled { get; }

        /// <summary>
        /// Gets a value indicating whether this logger has warn enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this logger has warn enabled; otherwise, <c>false</c>.
        /// </value>
        bool IsWarnEnabled { get; }

        /// <summary>
        /// Gets a value indicating whether this logger has error enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this logger has error enabled; otherwise, <c>false</c>.
        /// </value>
        bool IsErrorEnabled { get; }

        /// <summary>
        /// Gets a value indicating whether this logger has fatal enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this logger has fatal enabled; otherwise, <c>false</c>.
        /// </value>
        bool IsFatalEnabled { get; }

        /// <summary>
        /// Writes the specified message to trace.
        /// </summary>
        /// <param name="message">The message.</param>
        void Trace(string message);

        /// <summary>
        /// Writes the specified message to trace.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        void Trace(string message, Exception exception);

        /// <summary>
        /// Writes the specified message to trace.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        void Trace<T>(T value);

        /// <summary>
        /// Writes the specified message to trace.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        void TraceFormat(string message, params object[] args);

        /// <summary>
        /// Writes the specified message to debug.
        /// </summary>
        /// <param name="message">The message.</param>
        void Debug(string message);

        /// <summary>
        /// Writes the specified message to debug.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        void Debug(string message, Exception exception);

        /// <summary>
        /// Writes the specified message to debug.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        void Debug<T>(T value);

        /// <summary>
        /// Writes the specified message to debug.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        void DebugFormat(string message, params object[] args);

        /// <summary>
        /// Writes the specified message to information.
        /// </summary>
        /// <param name="message">The message.</param>
        void Info(string message);

        /// <summary>
        /// Writes the specified message to information.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        void Info(string message, Exception exception);

        /// <summary>
        /// Writes the specified message to information.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        void Info<T>(T value);

        /// <summary>
        /// Writes the specified message to information.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        void InfoFormat(string message, params object[] args);

        /// <summary>
        /// Writes the specified message to warn.
        /// </summary>
        /// <param name="message">The message.</param>
        void Warn(string message);

        /// <summary>
        /// Writes the specified message to warn.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        void Warn(string message, Exception exception);

        /// <summary>
        /// Writes the specified message to warn.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        void Warn<T>(T value);

        /// <summary>
        /// Writes the specified message to warn.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        void WarnFormat(string message, params object[] args);

        /// <summary>
        /// Writes the specified message to error.
        /// </summary>
        /// <param name="message">The message.</param>
        void Error(string message);

        /// <summary>
        /// Writes the specified message to error.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        void Error(string message, Exception exception);

        /// <summary>
        /// Writes the specified message to error.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        void Error<T>(T value);

        /// <summary>
        /// Writes the specified message to error.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        void ErrorFormat(string message, params object[] args);

        /// <summary>
        /// Writes the specified message to fatal.
        /// </summary>
        /// <param name="message">The message.</param>
        void Fatal(string message);

        /// <summary>
        /// Writes the specified message to fatal.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        void Fatal(string message, Exception exception);

        /// <summary>
        /// Writes the specified message to fatal.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        void Fatal<T>(T value);

        /// <summary>
        /// Writes the specified message to fatal.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="args">The arguments.</param>
        void FatalFormat(string message, params object[] args);
    }
}