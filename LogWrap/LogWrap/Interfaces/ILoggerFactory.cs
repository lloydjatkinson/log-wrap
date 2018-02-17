using System;

namespace LogWrap.Interfaces
{
    public interface ILoggerFactory
    {
        ILogger GetLogger(Type type);

        ILogger GetLogger(string name);
    }
}
