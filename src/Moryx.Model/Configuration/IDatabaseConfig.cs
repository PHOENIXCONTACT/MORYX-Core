// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using Moryx.Configuration;
using System.Runtime.Serialization;

namespace Moryx.Model.Configuration
{
    /// <summary>
    /// Interface for database configuration
    /// </summary>
    public interface IDatabaseConfig : IConfig
    {
        /// <summary>
        /// Connection string
        /// </summary>
        DatabaseConnectionSettings ConnectionSettings { get; set; }

        /// <summary>
        /// Database configurator typename
        /// </summary>
        string ConfiguratorTypename { get; set; }
    }
}
