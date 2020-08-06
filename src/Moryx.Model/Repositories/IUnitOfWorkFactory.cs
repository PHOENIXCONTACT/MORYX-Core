﻿// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using System.Data.Entity;
using Moryx.Model.Configuration;

namespace Moryx.Model.Repositories
{
    /// <summary>
    /// Dedicated factory for a database context using the unit of work pattern
    /// </summary>
    public interface IUnitOfWorkFactory<out TContext>
        where TContext : DbContext
    {
        /// <summary>
        /// Create unit of work using standard mode and config from config manager
        /// </summary>
        IUnitOfWork<TContext> Create();

        /// <summary>
        /// Create unit of work using standard mode and alternative config
        /// </summary>
        IUnitOfWork<TContext> Create(IDatabaseConfig config);

        /// <summary>
        /// Create unit of work using given mode and config from config manager
        /// </summary>
        IUnitOfWork<TContext> Create(ContextMode contextMode);

        /// <summary>
        /// Create unit of work using given mode and alternative config
        /// </summary>
        IUnitOfWork<TContext> Create(IDatabaseConfig config, ContextMode contextMode);
    }
}