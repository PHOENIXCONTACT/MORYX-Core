// Copyright (c) 2023, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using Microsoft.EntityFrameworkCore;
using Moryx.Model.Sqlite.Attributes;

// ReSharper disable once CheckNamespace
namespace Moryx.Resources.Model
{
    /// <summary>
    /// Sqlite specific implementation of <see cref="ResourcesContext"/>
    /// </summary>
    [SqliteContext]
    public class SqliteResourcesContext : ResourcesContext
    {
        /// <inheritdoc />
        public SqliteResourcesContext()
        {
        }

        /// <inheritdoc />
        public SqliteResourcesContext(DbContextOptions options) : base(options)
        {
        }

        /// <inheritdoc />
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
