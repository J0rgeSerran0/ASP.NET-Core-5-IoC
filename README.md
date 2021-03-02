# ASP.NET-Core-5-IoC
IoC implementations in ASP.NET Core 5

## About this code
This sample shows you how to use **IoC** in your ASP.NET Core programs.

The target of this sample is to show you how *singleton*, *transient* and *scoped* work in the typical Web Api app.

I try to show you the lifetime, use and reuse of a *Log* object inside of the Web Api too.

You will have to change the type of object that you want to use, in the **Startup.cs** file to see the different behaviours.

To use **singleton**, your code will look as:

```csharp
public void ConfigureServices(IServiceCollection services)
{
    // Singleton
    services.AddSingleton<ILog, FakeLog>();

    // Transient
    //services.AddTransient<ILog, FakeLog>();

    // Scoped
    //services.AddScoped<ILog, FakeLog>();

    services.AddControllers();

    services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApp", Version = "v1" });
    });
}
```

To use **transient**:

```csharp
public void ConfigureServices(IServiceCollection services)
{
    // Singleton
    //services.AddSingleton<ILog, FakeLog>();

    // Transient
    //services.AddTransient<ILog, FakeLog>();

    // Scoped
    services.AddScoped<ILog, FakeLog>();

    services.AddControllers();

    services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApp", Version = "v1" });
    });
}
```

To use **scoped**:

```csharp
public void ConfigureServices(IServiceCollection services)
{
    // Singleton
    //services.AddSingleton<ILog, FakeLog>();

    // Transient
    //services.AddTransient<ILog, FakeLog>();

    // Scoped
    services.AddScoped<ILog, FakeLog>();

    services.AddControllers();

    services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApp", Version = "v1" });
    });
}
```

The *FakeLog.cs* file that is used, write a message in the **Output** window of Visual Studio too, to know if the object has been disposed or not.

> For more information about dependency injection in ASP.NET Core, please [read this information](https://docs.microsoft.com/en-us/dotnet/core/extensions/dependency-injection)
> 
