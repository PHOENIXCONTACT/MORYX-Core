// Copyright (c) 2023, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

namespace Moryx.Products.Management
{
    /// <summary>
    /// Config interface for generic strategies
    /// </summary>
    internal interface IGenericMapperConfiguration : IPropertyMappedConfiguration
    {
        /// <summary>
        /// Column that should be used to store all non-configured properties as JSON
        /// </summary>
        string JsonColumn { get; }
    }
}
