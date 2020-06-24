// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using Moryx.Workflows;

namespace Moryx.Tests.Workflows
{
    public class DummyToken : IToken
    {
        /// <summary>
        /// Token name
        /// </summary>
        public string Name { get { return "DummyToken"; } }
    }
}
