﻿namespace Marvin.Container.Tests
{
    internal class ParentOnly
    {
        public Parent Parent { get; set; }
    }

    internal class NamedParentOnly
    {
        [Named("Parent2")]
        public Parent Parent { get; set; }
    }

    internal class TypedChild
    {
        [UseChild]
        public Child Child { get; set; }
    }

    internal class NamedChild
    {
        [UseChild("Child")]
        public Child Child { get; set; }
    }

    internal class NamedChildNamedParent
    {
        [UseChild("Child", "Parent2")]
        public Child Child { get; set; }
    }
}
