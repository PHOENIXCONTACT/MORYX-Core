﻿namespace Marvin.Container.Tests
{
    public interface INamedComponent
    {
        string GetName();
    }
    
    [Plugin(LifeCycle.Transient, typeof(INamedComponent), Name = ComponentName)]
    internal class NamedComponentA : INamedComponent
    {
        internal const string ComponentName = "CompA";

        public string GetName()
        {
            return ComponentName;
        }
    }

    [Plugin(LifeCycle.Transient, typeof(INamedComponent), Name = ComponentName)]
    internal class NamedComponentB : INamedComponent
    {
        internal const string ComponentName = "CompB";

        public string GetName()
        {
            return ComponentName;
        }
    }

    [PluginFactory(typeof(INameBasedComponentSelector))]
    public interface INamedComponentFactory
    {
        INamedComponent Create(string name);
    }
}
