// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using System.Collections.Generic;
using System.Runtime.Serialization;
using Marvin.Tools.Wcf;

namespace Marvin.TestModule
{
    [DataContract]
    public class TestSubPluginConfig1 : TestSubPluginConfig
    {
        public TestSubPluginConfig1()
        {
            OrderWcfService = new HostConfig
            {
                BindingType = ServiceBindingType.BasicHttp,
                Endpoint = "OrderImporting",
                MetadataEnabled = true,
                HelpEnabled = true
            };

            OrderSources = new List<SourceConfig>();
        }

        public override string PluginName { get { return TestSubPlugin1.ComponentName; } }

        /// <summary>
        /// Gets or sets the configuration for the wcf service.
        /// </summary>
        [DataMember]
        public HostConfig OrderWcfService { get; set; }

        /// <summary>
        /// Gets or sets the order source.
        /// </summary>
        /// <value>
        /// The order source.
        /// </value>
        [DataMember]
        public List<SourceConfig> OrderSources { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class SourceConfig
    {
        /// <summary>
        /// Gets or sets the source identifier.
        /// </summary>
        /// <value>
        /// The source identifier.
        /// </value>
        [DataMember]
        public int SourceId { get; set; }

        /// <summary>
        /// Gets or sets the name of the source.
        /// </summary>
        /// <value>
        /// The name of the source.
        /// </value>
        [DataMember]
        public string SourceName { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return "Source: '" + (!string.IsNullOrWhiteSpace(SourceName) ? SourceName : string.Empty) + "' ID: '" + SourceId + "'";
        }
    }
}
