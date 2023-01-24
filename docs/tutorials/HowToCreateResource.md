---
uid: HowToCreateAResource
---
# How to create a resource

This tutorial shows how [Resource](xref:Moryx.AbstractionLayer.Resources.Resource) should be implemented. Look [here](../articles/Resources/Overview.md) if you are not firm with `Resource`. This tutorial describes how a basic `Resource` is created. Other specializations are [Public resources](xref:Moryx.AbstractionLayer.Resources.PublicResource), [Driver resources](../Resources/Types/DriverResource.md) or [Interaction resources](../Resources/Types/InteractionResource.md).

## Basic resource files

A resource has this basic solution structure which can be extended for your needs:

````fs
-Moryx.Resource.ExampleResource
|-IExampleResource.cs
|-ExampleResource.cs
````

The interface `IExampleResource` is optional for a resource and probably better located in a shared project between resources and modules. The implementation of this interface is done with the `ExampleResource` class.

### The interface

This interface is simply derived from [IResource](xref:Moryx.AbstractionLayer.Resources.IResource). No further definitions are needed.

````cs
using Moryx.AbstractionLayer.Resources;

namespace Moryx.Resources.Samples.DriverTutorial
{
    public interface IExampleResource : IResource
    {
    }
}
````

### The implementation

Now implement `IExampleResource`:

````cs
using System.ComponentModel;
using System.Runtime.Serialization;
using Moryx.AbstractionLayer.Resources;
using Moryx.Serialization;

namespace Moryx.Resources.Samples.DriverTutorial
{
    [ResourceRegistration]
    [DisplayName("Example Resource"), Description("An example resource")]
    public class ExampleResource : Resource, IExampleResource
    {
        [DataMember, EntrySerialize]
        public string AStringValue { get; set; }

        [DataMember, EntrySerialize]
        public int AnIntValue { get; set; }

        public string ANonEntrySerializeMember { get; set; }

        [EntrySerialize, DisplayName("Square"), Description("Just multiplies given value with itself")]
        public int Square(int value)
        {
            return value * value;
        }
    }
}
````

The implementation of the `ExampleResource` derives from the [Resource](xref:Moryx.AbstractionLayer.Resources.Resource) base class. It also implements the `IResource` interface. This is enough to use your resource definition within MORYX. If your resource relies on dependency injection like logging it is important to add the [ResourceRegistration attribute](xref:Moryx.AbstractionLayer.Resources.ResourceRegistrationAttribute). MORYX can now identify this class as a resource. Additional attributes like `DisplayName` and `Description` are used within the Resource UI.

## Configure Relations between Resources
Resources can reference other resources. When for example a cell communicates with a PLC via a Driver, the Driver has to be referenced in the Cell. Every Resource have the References `Children` and `Parent` as default. In order to overwrite 
References use the attribute `ReferenceOverride`. New References can be added using the attribute `ResourceReference`. For the different ResourceRelationTypes look [here](xref:Moryx.AbstractionLayer.Resources.ResourceRelationType).

```C#
[ResourceRegistration]
    public class ExampleCell : PublicResource
    {
        [ResourceReference(ResourceRelationType.Driver)]
        public IMessageDriver<object> Driver {get;set;}

        [ReferenceOverride(nameof(Children))]
        public IReferences<IMessageChannel> Channels {get;set;}
    }

```

## How to use the Resource in a custom module

If you want to use the new resource from a custom module, you need to request the resource from the [ResourceManagement](xref:Moryx.AbstractionLayer.Resources.IResourceManagement). Inject the `ResourceManagement` into the `ModuleController` and pass the object to the inner container of your custom module.

````cs
    [ServerModule(ModuleName)]
    public class ModuleController : ServerModuleBase<ModuleConfig>
    {
        //Let the component be injected from the external container
        [RequiredModuleApi(IsOptional = false, IsStartDependency = true)]
        public IResourceManagement ResourceManagement { get; set; }

        public override string Name
        {
           ///
        }

        #region state transition
        protected override void OnInitialize()
        {
            //pass the component to the inner container
            Container.SetInstance(ResourceManagement);

            ResourceManagement.CapabilitiesChanged += ExampleResourceCapabilityChanged;
        }

        protected override void OnStart()
        {
            ///
        }

        protected override void OnStop()
        {
           ///
        }
        #endregion

    }
````

## CapabilityChanged event

If it is nesessary to react when a capability has changed, is it possible to attach to the [CapabilityChanged](xref:Moryx.AbstractionLayer.Resources.IResourceManagement.CapabilitiesChanged) event:

````cs
private void ExampleResourceCapabilityChanged(object sender, ICapabilities newCapabilities)
{
    var id = ((IResource)sender).Id;

    // Do something
}
````