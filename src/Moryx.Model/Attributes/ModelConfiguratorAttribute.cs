// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using System;

namespace Moryx.Model
{
    /// <summary>
    /// Registration attribute for data model configurators
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class ModelConfiguratorAttribute : Attribute
    {
        /// <summary>
        /// Configurator used for the context
        /// </summary>
        public Type ConfiguratorType { get; }

        /// <summary>
        /// Creates a new instance of <see cref="ModelConfiguratorAttribute"/>
        /// </summary>
        public ModelConfiguratorAttribute(Type configuratorType)
        {
            ConfiguratorType = configuratorType;
        }
    }
}
