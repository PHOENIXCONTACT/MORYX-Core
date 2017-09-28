﻿using Marvin.Configuration;

namespace Marvin.Tools.Wcf
{
    /// <summary>
    /// Simple implementation of a WCF client factory for console applications or system tests.
    /// </summary>
    public class SimpleWcfClientFactory : BaseWcfClientFactory
    {
        /// <summary>
        /// Initializes this factory without proxy configuration.
        /// </summary>
        /// <param name="config">The configuration of this factory.</param>
        public void Initialize(IWcfClientFactoryConfig config)
        {
            Initialize(config, null);
        }

        /// <summary>
        /// Initializes this factory.
        /// </summary>
        /// <param name="config">The configuration of this factory.</param>
        /// <param name="proxyConfig">An optional proxy configuration.</param>
        public void Initialize(IWcfClientFactoryConfig config, IProxyConfig proxyConfig)
        {
            Initialize(config, proxyConfig, new SimpleThreadContext());
        }
    }
}