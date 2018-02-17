using System;

using LogWrap.Core;
using LogWrap.Empty.Loggers;

namespace LogWrap.Empty.Factories
{
    public class EmptyLoggerFactory : ILoggerFactory
    {
        public ILogger GetLogger(string name) => new EmptyLogger(name);

        public ILogger GetLogger(Type type) => new EmptyLogger(type);
    }
}