// Copyright (c) 2023, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using System;
using Microsoft.Extensions.Logging;

namespace Moryx.Runtime.Tests.Mocks
{
    internal class TestLoggerMgmt : ILoggerFactory, ILogger
    {
        public void AddProvider(ILoggerProvider provider)
        {
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public ILogger CreateLogger(string categoryName)
        {
            return this;
        }

        public void Dispose()
        {
        }

        public bool IsEnabled(Microsoft.Extensions.Logging.LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(Microsoft.Extensions.Logging.LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
        }
    }
}
