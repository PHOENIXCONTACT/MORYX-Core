// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

namespace Marvin.Communication.Sockets.IntegrationTests.DelimiterProtocol
{
    public class TestDelimiterValidator : IMessageValidator
    {
        public bool Validate(BinaryMessage message) => true;

        public IMessageInterpreter Interpreter => new TestDelimiterInterpreter();
    }
}
