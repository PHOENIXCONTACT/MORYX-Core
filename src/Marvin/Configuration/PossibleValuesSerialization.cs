﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Marvin.Container;
using Marvin.Serialization;
using Marvin.Tools;

namespace Marvin.Configuration
{
    /// <summary>
    /// Base class for config to model transformer
    /// </summary>
    public class PossibleValuesSerialization : DefaultSerialization
    {
        /// <summary>
        /// Container used to include current information from current composition into the configuration
        /// </summary>
        protected IContainer Container { get; }

        /// <summary>
        /// Empty property provider to pre-fill newley created objects
        /// </summary>
        protected IEmptyPropertyProvider EmptyPropertyProvider { get; }

        /// <summary>
        /// Initialize base class
        /// </summary>
        public PossibleValuesSerialization(IContainer container, IEmptyPropertyProvider emptyPropertyProvider)
        {
            Container = container;
            EmptyPropertyProvider = emptyPropertyProvider;
        }

        /// <see cref="T:Marvin.Serialization.ICustomSerialization"/>
        public override EntryPrototype[] Prototypes(Type memberType, ICustomAttributeProvider attributeProvider)
        {
            // Create prototypes from possible values
            var possibleValuesAtt = attributeProvider.GetCustomAttribute<PossibleValuesAttribute>();
            if (possibleValuesAtt == null)
            {
                return base.Prototypes(memberType, attributeProvider);
            }

            var list = new List<EntryPrototype>();
            foreach (var value in possibleValuesAtt.GetValues(Container))
            {
                var prototype = possibleValuesAtt.Parse(Container, value);
                EmptyPropertyProvider.FillEmpty(prototype);
                list.Add(new EntryPrototype(value, prototype));
            }
            return list.ToArray();
        }

        /// <see cref="T:Marvin.Serialization.ICustomSerialization"/>
        public override string[] PossibleValues(Type memberType, ICustomAttributeProvider attributeProvider)
        {
            var valuesAttribute = attributeProvider.GetCustomAttribute<PossibleValuesAttribute>();
            if (valuesAttribute == null)
            {
                return base.PossibleValues(memberType, attributeProvider);
            }

            // Use attribute
            var values = valuesAttribute.GetValues(Container);
            return values?.Distinct().ToArray();
        }


        /// <see cref="T:Marvin.Serialization.ICustomSerialization"/>
        public override string[] PossibleElementValues(Type memberType, ICustomAttributeProvider attributeProvider)
        {
            var valuesAttribute = attributeProvider.GetCustomAttribute<PossibleValuesAttribute>();
            if (valuesAttribute == null)
            {
                return base.PossibleElementValues(memberType, attributeProvider);
            }

            // Use attribute
            var values = valuesAttribute.GetValues(Container);
            return values?.Distinct().ToArray();
        }

        /// <see cref="T:Marvin.Serialization.ICustomSerialization"/>
        public override object CreateInstance(Type memberType, ICustomAttributeProvider attributeProvider, Entry encoded)
        {
            var possibleValuesAtt = attributeProvider.GetCustomAttribute<PossibleValuesAttribute>();
            var instance = possibleValuesAtt != null
                ? possibleValuesAtt.Parse(Container, encoded.Value.Current)
                : base.CreateInstance(memberType, attributeProvider, encoded);

            EmptyPropertyProvider.FillEmpty(instance);

            return instance;
        }

        /// <see cref="T:Marvin.Serialization.ICustomSerialization"/>
        public override object ConvertValue(Type memberType, ICustomAttributeProvider attributeProvider, Entry mappedEntry, object currentValue)
        {
            var value = mappedEntry.Value;

            var att = attributeProvider.GetCustomAttribute<PossibleValuesAttribute>();
            if (att == null || !att.OverridesConversion || value.Type == EntryValueType.Collection)
                return base.ConvertValue(memberType, attributeProvider, mappedEntry, currentValue);

            // If old and current type are identical, keep the object
            if (value.Type == EntryValueType.Class && currentValue != null && currentValue.GetType().Name == value.Current)
                return currentValue;

            var instance = att.Parse(Container, mappedEntry.Value.Current);
            if (mappedEntry.Value.Type == EntryValueType.Class)
            {
                EmptyPropertyProvider.FillEmpty(instance);
            }

            return instance;
        }
    }
}