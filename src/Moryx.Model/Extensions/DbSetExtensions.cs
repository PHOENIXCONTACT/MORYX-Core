﻿// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using System;
using System.Data.Entity;
using System.Linq;

namespace Moryx.Model
{
    /// <summary>
    /// Extensions for the entity framework DbSet
    /// </summary>
    public static class DbSetExtensions
    {
        /// <summary>
        /// Get or create an entity for a business object
        /// </summary>
        /// <param name="dbSet">An open database set</param>
        /// <param name="obj">The business object</param>
        /// <typeparam name="TEntity">The entity type to use</typeparam>
        public static TEntity GetEntity<TEntity>(this IDbSet<TEntity> dbSet, IPersistentObject obj)
            where TEntity : class, IEntity
        {
            var entity = dbSet.FirstOrDefault(e => e.Id == obj.Id);
            if (entity != null)
                return entity;

            entity = dbSet.Create();
            dbSet.Add(entity);
            EntityIdListener.Listen(entity, obj);

            return entity;
        }

        /// <summary>
        /// Does not remove the entity from context, it sets the deleted property on <see cref="IModificationTrackedEntity"/>
        /// </summary>
        /// <typeparam name="TEntity">Entity type of <see cref="IModificationTrackedEntity"/></typeparam>
        /// <param name="dbSet">Extended db set</param>
        /// <param name="entity">Entity to remove soft</param>
        /// <returns>soft removed entity</returns>
        public static TEntity RemoveSoft<TEntity>(this IDbSet<TEntity> dbSet, TEntity entity) where TEntity : class, IModificationTrackedEntity
        {
            entity.Deleted = DateTime.Now;
            return entity;
        }
    }
}
