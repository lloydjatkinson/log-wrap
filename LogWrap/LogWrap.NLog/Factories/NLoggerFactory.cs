using System;

using LogWrap.Core;
using LogWrap.NLog.Loggers;

namespace LogWrap.NLog.Factories
{
    public class NLogLoggerFactory : ILoggerFactory
    {
        public ILogger GetLogger(string name) => new NLogLogger(name);

        public ILogger GetLogger(Type type) => new NLogLogger(type);
    }
}