// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using Moryx.Runtime.Configuration;
using Moryx.Runtime.Container;
using Moryx.Runtime.Modules;
using Moryx.Runtime.Tests.Mocks;
using Moryx.Runtime.Tests.Modules;
using Moq;
using NUnit.Framework;

namespace Moryx.Runtime.Tests
{
    [TestFixture]
    public class ModuleBaseTest
    {
        private TestModule _moduleUnderTest;

        [SetUp]
        public void Init()
        {
            var configManagerMock = new Mock<IRuntimeConfigManager>();
            configManagerMock.Setup(c => c.GetConfiguration<TestConfig>()).Returns(new TestConfig
            {
                Strategy = new StrategyConfig { PluginName = "Test" },
                StrategyName = "Test"
            });


            _moduleUnderTest = new TestModule
            {
                ConfigManager = configManagerMock.Object,
                LoggerManagement = new TestLoggerMgmt()
            };
        }

        [Test]
        public void StrategiesInConfigFound()
        {
            var casted = (IServerModule) _moduleUnderTest;
            casted.Initialize();

            var containerConfig = ((IContainerHost) _moduleUnderTest).Strategies;

            Assert.GreaterOrEqual(containerConfig.Count, 1, "No strategy found!");
            Assert.IsTrue(containerConfig.ContainsKey(typeof(IStrategy)), "Wrong type!");
            Assert.AreEqual("Test", containerConfig[typeof(IStrategy)], "Wrong implementation instance set!");
        }
    }
}
