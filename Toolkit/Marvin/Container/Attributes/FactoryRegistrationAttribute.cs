﻿using System;

namespace Marvin.Container
{
    /// <summary>
    /// Installation attribute for factories
    /// </summary>
    [AttributeUsage(AttributeTargets.Interface)]
    public class FactoryRegistrationAttribute : Attribute
    {
        /// <summary>
        /// Optional component selector
        /// </summary>
        public Type Selector
        {
            get;
            private set;
        }

        /// <summary>
        /// Optional name of factory
        /// </summary>
        public string Name
        {
            get;
            private set;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public FactoryRegistrationAttribute()
        {
        }

        /// <summary>
        /// Constructor with component selector
        /// </summary>
        /// <param name="selectorType">Selector</param>
        public FactoryRegistrationAttribute(Type selectorType)
        {
            Selector = selectorType;
        }

        /// <summary>
        /// Constructor with name
        /// </summary>
        /// <param name="name">Name of factory</param>
        public FactoryRegistrationAttribute(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Constructor with name and selector
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="selectorType">Selector</param>
        public FactoryRegistrationAttribute(string name, Type selectorType)
        {
            Selector = selectorType;
            Name = name;
        }
    }
}
