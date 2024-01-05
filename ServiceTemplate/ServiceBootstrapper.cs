using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Nexus.Framework.Web;
using OpenTelemetry.Resources;
using {{RootNamespace}}.Abstractions;
using {{RootNamespace}}.Data;
using {{RootNamespace}}.Data.Repositories;
using {{RootNamespace}}.Mapping;
using {{RootNamespace}}.Services;
using {{RootNamespace}}.Telemetry;

namespace {{RootNamespace}};

public class ServiceBootstrapper : NexusServiceBootstrapper
{
    public ServiceBootstrapper(string[] args) : base(args)
    {
    }

   
    protected override void ConfigureMiddleware()
    {
        base.ConfigureMiddleware();
        App.MapControllers();
    }
}