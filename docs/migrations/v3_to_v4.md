## Migrate to Core v4

For this major release the main motivation was switching from our own MORYX Runtime to ASP.NET Core with MORYX extensions.

### .NET Framework

MORYX Core no longer supports the legacy .NET Framework and is only available for .NET 5.0 and above. There is also no more WCF support or embedded kestrel hosting. Instead standard ASP.NET API-Controllers can be used that import MORYX components (kernel, modules or facade).

### DI Container replacement

As of version 4 we replaced the global Castle Windsor container with Microsofts `ServiceCollection`. This has several benefits:

- Improved integration of ASP components, controller and MORYX modules and facades
- Bigger community and support
- Simplified project setup with standard ASP templates

It also requires a couple of changes when you migrate modules or applications from Core version 3.

- Constructor injection instead of properties
- Use constructors instead of Initialize methods to prepare a component
- StartProjects are ASP projects now and `Main` method only uses ASP now

Example for the application project:

````cs
...
using Moryx.Runtime.Kernel;
using Moryx.Tools;
using Moryx.Model;
...
public static void Main(string[] args)
{            
    AppDomainBuilder.LoadAssemblies();

    var host = Host.CreateDefaultBuilder(args)
        .ConfigureServices(serviceCollection =>
        {
            serviceCollection.AddMoryxKernel();
            serviceCollection.AddMoryxModels();
            serviceCollection.AddMoryxModules();
        })
        .ConfigureWebHostDefaults(webBuilder =>
        {
            webBuilder.UseStartup<Startup>();
        }).Build();

    host.Services.UseMoryxConfigurations("Config");
    host.Services.StartMoryxModules();

    host.Run();

    host.Services.StopMoryxModules();
}
````

Constructor for a `ModuleController`. This also includes further imports like `IDbContextManager`.

````cs
public ModuleController(IModuleContainerFactory containerFactory, IConfigManager configManager, ILoggerFactory loggerFactory, IDbContextManager contextManager) 
    : base(containerFactory, configManager, loggerFactory)
{
    ContextManager = contextManager;
}
````

When exporting facades from you module, the new structure no longer exports facades with implicit polymorphism. Instead when your facade provides multiple interfaces, for example after a new minor version, you need to export each one explicitly.

````cs
public class ModuleController : ServerModuleFacadeControllerBase<ModuleConfig>, 
    IFacadeContainer<IProductManagement>, 
    IFacadeContainer<IProductManagementModification>,
    IFacadeContainer<IProductManagementTypeSearch>

private readonly ProductManagementFacade _productManagement = new ProductManagementFacade();

IProductManagement IFacadeContainer<IProductManagement>.Facade => _productManagement;
IProductManagementTypeSearch IFacadeContainer<IProductManagementTypeSearch>.Facade => _productManagement;
IProductManagementModification IFacadeContainer<IProductManagementModification>.Facade => _productManagement;    
````

### Hosting

Hosting of Endpoints from within Modules is no longer supported removing IEndpointHosting and IEndpointHostFactory from within modules as well as the Activate Hosting extension on the container. Asp Controllers can get the Facade injected and are hosted by Asp natively.

### Logging

Most of the MORYX logging was replaced by the types from "Microsoft.Extensions.Logging". 

Changes:
- `IModuleLogger` is basically `ILogger`, thereby `LogException` is just `Log` now
- `Moryx.Logging.LogLevel` was replaced with log level from MS, there LogLevel.Info becomes LogLevel.Information
- LoggerManagement is gone without replacement
- The DummyLogger was removed, an equivalent is given by instantiating `new ModuleLogger("Dummy", typeof(ResourceManager), new NullLoggerFactory())`

### Maintenance

The Maintenance module and its internally hosted web UI are gone. They are replaced by kernel based ASP endpoints and a razor hosted frontend.

### Package changes

Added:
- Moryx.Runtime.Endpoints // Contains endpoints for maintenance now
- Moryx.Maintenance.Web

Removed:
- Moryx.Runtime.WinService
- Moryx.Runtime.Wcf
- Moryx.Runtime.Kestrel
- Moryx.Runtime.DbUpdate
- Moryx.TestTools.SystemTest
- Moryx.Runtime.SmokeTest
- Moryx.Runtime.Maintenance
- Moryx.Runtime.Wcf
- Moryx.Runtime.Maintenance.Web /Replaced by Moryx.Maintenance.Web with razor hosting
- Moryx.Asp.Extensions // Not needed anymore, Shell related content moved to "Moryx" package

### Database
With the update to MORYX Core 4 we also update the reference to Entity Framework. The update to Entity Framework Core comes with some changes to the API we are used to, for an overview of the changes provided by Microsoft see [here](https://docs.microsoft.com/en-us/ef/efcore-and-ef6/porting/). In order for you to have less of a headache when searching through the EF Core documentation to find the right translation for your code into the new way of doing things, we list the changes we went through in the subsequent bullet points:

- The DB contexts requires changes
    - `DbConfigurationType` attribute was removed
    - The constructure parameter of the context changed to `DbContextOptions` (The parameterless constructor remains unchanged)
    - An `OnConfiguring` method needs to be added
    - The fluent API used in `OnModelCreating` changed:
    - `.HasRequired(a => a.Property).WithMany(b => b.Property);` => `.HasOne(a => a.Property).WithMany(b => b.Property).IsRequired();`
    - `.HasOptional(a => a.Property);` => `.HasOne(a => a.Property).WithMany();`
    - `.HasMany(a => a.Property).WithOptional(b => b.Property);` => `.HasMany(a => a.Property).WithOne(b => b.Property);`
    - `.HasOptional(a => a.Property).WithMany()` => `.HasOne(a => a.Property).WithMany();`
- The Configuration.cs for the DB migration was removed, for the new way of setting up a database migration read the section below.

### Add database migrations (with Postgres)

You need, at least, an initial migration for each of your database contexts. [Read more](https://docs.microsoft.com/de-de/ef/core/cli/dotnet#dotnet-ef-migrations-add) about how to add migrations with EntityFramework.

After you navigated to the root directory of the project that contains the database context file, you can create a migration:

```
dotnet ef migrations add InitialCreate --startup-project Path\To\StartProject.csproj --output-dir .\Model\Migrations 
```

#### Set things up

In order to run this successfully, you might have to go through some configuration.

##### Required packages

The `StartProject.csproj` has to reference 

  * `Microsoft.EntityFrameworkCore.Design`

##### Database connection

You need to have a connection to the database that corresponds to the context. To find out how this connection is set up, have a look at the contexts `OnConfigure()` method. By default it should look somewhat like this:

```cs
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    if (!optionsBuilder.IsConfigured)
    {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.

      optionsBuilder.UseNpgsql("Host=localhost;Database=ProcessContext;Username=postgres;Password=postgres");
    }
}
```

You can setup your connection string directly there, but it is **not recommended**. You might follow the pattern, that is used within your application or have a look at the docs, mentioned by the `#warning`:

> #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.

However, this is the go to place to look for how to provide your StartProject with a `ConnectionString`.

**Important!** Remember to not push sensitive data to your version control system!
