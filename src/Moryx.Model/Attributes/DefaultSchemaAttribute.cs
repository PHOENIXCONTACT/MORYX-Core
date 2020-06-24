// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using System;

namespace Moryx.Model
{
    /// <summary>
    /// Defines the default schmea for this database context
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class DefaultSchemaAttribute : Attribute
    {
        /// <summary>
        /// Default schema name
        /// </summary>
        public const string DefaultName = "public";

        /// <summary>
        /// Name of the default schema
        /// </summary>
        public string Schema { get; }

        /// <inheritdoc />
        public DefaultSchemaAttribute(string schema)
        {
            Schema = schema;
        }
    }
}
