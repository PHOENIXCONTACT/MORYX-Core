// Copyright (c) 2023, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

namespace Moryx.Modules
{
    /// <summary>
    /// This generic interface is intended for all components that require a configuration for their initialization to work properly.
    /// This configuration is passed to the plugin via the Initialize(TConf config) method.
    /// </summary>
    public interface IConfiguredInitializable<in T>
        where T : IPluginConfig
    {
        /// <summary>
        /// Initialize this component with its config
        /// </summary>
        /// <param name="config">Config of this component</param>
        void Initialize(T config);
    }
}