// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using System.ComponentModel;
using Moryx.Workflows;
using Moryx.Workflows.Transitions;
using Moryx.Workflows.WorkplanSteps;

namespace Moryx.Tests.Workflows
{
    internal class DefaultValueStep : WorkplanStepBase
    {
        ///
        public override string Name
        {
            get { return "DefaultValue"; }
        }

        [EditorBrowsable]
        public int OptionalParameter { get; set; }

        [DefaultValue(10), EditorBrowsable]
        public ushort OptionalWithDefault { get; set; }

        public DefaultValueStep(int mandatory, ushort mandatoryWithDefault = 2)
        {
            _mandatory = mandatory;
            _mandatoryWithDefault = mandatoryWithDefault;
        }

        ///
        protected override TransitionBase Instantiate(IWorkplanContext context)
        {
            return null;
        }

        private readonly int _mandatory;
        private readonly ushort _mandatoryWithDefault;

    }
}
