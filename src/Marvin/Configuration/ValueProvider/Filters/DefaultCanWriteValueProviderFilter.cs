// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using System.Reflection;

namespace Marvin.Configuration
{
    /// <summary>
    /// ValueProviderFilter that skips read only properties
    /// </summary>
    public sealed class DefaultCanWriteValueProviderFilter : IValueProviderFilter
    {
        /// <inheritdoc />
        public bool CheckProperty(PropertyInfo propertyInfo)
        {
            return propertyInfo.CanWrite;
        }
    }
}
