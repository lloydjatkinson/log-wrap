using System;

namespace LogWrap.Core
{
    /// <summary>
    /// Defines the methods exposed by factory implementations.
    /// </summary>
    public interface ILoggerFactory
    {
        /// <summary>
        /// Gets a new logger instance.
        /// </summary>
        /// <param name="type">The type. Used for context in the log messages.</param>
        /// <returns></returns>
        ILogger GetLogger(Type type);

        /// <summary>
        /// Gets a new logger instance.
        /// </summary>
        /// <param name="type">The type. Used for context in the log messages.</param>
        /// <returns></returns>
        ILogger GetLogger(string name);
    }
}